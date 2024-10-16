using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Formularios.frmPersonal.frmAsistencias
{
    public partial class frmAsistencias : Form
    {
        bool sideBarExpand;
        public frmAsistencias()
        {
            InitializeComponent();
        }

        private void frmAsistencias_Load(object sender, EventArgs e)
        {
            var datosAsist = Negocio.Asistencia.listarAsistencias("", DateTime.Today, DateTime.Today);
            dgvAsistencias.DataSource = datosAsist;
            dgvAsistencias.ColumnHeadersVisible = datosAsist.Count == 0 ? false : true;
            cargarPersonal();
        }

        private void cargarPersonal()
        {
            //Autocompletar lo que se escribe en el textbox
            AutoCompleteStringCollection listaPersonal = new AutoCompleteStringCollection();
            var datos = Negocio.Persona.listarPersonal();
            foreach(var p in datos)
            {
                listaPersonal.Add($"{p.nombres} {p.apellido_paterno} {p.apellido_materno}");
            }
            txtPersonal.AutoCompleteCustomSource = listaPersonal;

            //Los datos se cargaran en un combobox del sideBar
            var listarPersonal = Negocio.Trabajador.busqTrabajador("", "", "", "", 0, true);
            if (listarPersonal.Count > 0)
            {
                cmbPersonal.DisplayMember = "Nombres_Apellidos";
                cmbPersonal.ValueMember = "ID";
                cmbPersonal.DataSource = listarPersonal;
            }
        }

        private void timerBarraLateral_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                sideBar.Width -= 10;
                if(sideBar.Width == sideBar.MinimumSize.Width)
                {
                    sideBarExpand =  false;
                    txtPersonal.Focus();
                    timerBarraLateral.Stop();
                }
            } else
            {
                sideBar.Width += 10;
                if(sideBar.Width == sideBar.MaximumSize.Width)
                {
                    sideBarExpand = true;
                    cmbPersonal.Focus();
                    timerBarraLateral.Stop();
                }
            }
        }

        private void btnEnt_Click(object sender, EventArgs e)
        {
            string mensaje = Negocio.Asistencia.registrarEntrada(short.Parse(txtIdTrab.Text));
            var datosAsist = Negocio.Asistencia.listarAsistencias(txtPersonal.Text, dtpFecIni.Value, dtpFecFin.Value);
            MessageBox.Show(mensaje,"Información",MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvAsistencias.DataSource = datosAsist;
            dgvAsistencias.ColumnHeadersVisible = datosAsist.Count == 0 ? false : true;
            txtPersonal.Clear();
            txtPersonal.Focus();
            txtIdTrab.Text = "0";
        }

        private void btnSal_Click(object sender, EventArgs e)
        {
            string hora_salida = dgvAsistencias.CurrentRow.Cells[4].Value.ToString();
            DialogResult respuesta = hora_salida.Equals("00:00:00") ? DialogResult.Yes : MessageBox.Show("¿Esta seguro que desea actualizar la hora de salida de este registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes == respuesta)
            {
                string mensaje = Negocio.Asistencia.registrarSalida(short.Parse(txtIdAsist.Text));
                MessageBox.Show(hora_salida.Equals("00:00:00") ? mensaje : "Se actualizo su hora de salida", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvAsistencias.DataSource = Negocio.Asistencia.listarAsistencias(txtPersonal.Text, dtpFecIni.Value, dtpFecFin.Value);
                txtIdAsist.Text = "0";
                txtPersonal.Focus();
            }
        }

        private void btnElim_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Esta seguro que desea eliminar este registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(respuesta == DialogResult.Yes)
            {
                string mensaje = Negocio.Asistencia.eliminarAsist(short.Parse(txtIdAsist.Text));
                var datosAsist = Negocio.Asistencia.listarAsistencias(txtPersonal.Text, dtpFecIni.Value, dtpFecFin.Value);
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvAsistencias.DataSource = datosAsist;
                dgvAsistencias.ColumnHeadersVisible = datosAsist.Count == 0 ? false : true;
                txtIdAsist.Text = "0";
                txtPersonal.Focus();
            }
        }

        private void btnHec_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Esta seguro que desea actualizar este registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(respuesta == DialogResult.Yes)
            {
                string mensaje = Negocio.Asistencia.actAsist(int.Parse(txtIdAsist.Text), short.Parse(cmbPersonal.SelectedValue.ToString()), dtpFecha.Value, dtpHoraEntrada.Value.TimeOfDay, dtpHoraSalida.Value.TimeOfDay);
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvAsistencias.DataSource = Negocio.Asistencia.listarAsistencias(txtPersonal.Text, dtpFecIni.Value, dtpFecFin.Value);
                timerBarraLateral.Start();

            }
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            timerBarraLateral.Start();
        }

        private void actualizarDgvAsist()
        {
            var datosAsist = Negocio.Asistencia.listarAsistencias(txtPersonal.Text, dtpFecIni.Value, dtpFecFin.Value);
            dgvAsistencias.DataSource = datosAsist;
            dgvAsistencias.ColumnHeadersVisible = datosAsist.Count == 0 ? false : true;
        }

        private void txtPersonal_TextChanged(object sender, EventArgs e)
        {
            actualizarDgvAsist();
        }

        private void dtpFecIni_ValueChanged(object sender, EventArgs e)
        {
            actualizarDgvAsist();
        }

        private void dtpFecFin_ValueChanged(object sender, EventArgs e)
        {
            actualizarDgvAsist();
        }

        private void btnAyer_Click(object sender, EventArgs e)
        {
            dtpFecIni.Value = dtpFecFin.Value = DateTime.Today.AddDays(-1);
            dgvAsistencias.DataSource = Negocio.Asistencia.listarAsistencias(txtPersonal.Text, DateTime.Today.AddDays(-1), DateTime.Today.AddDays(-1));
        }

        private void btnHoy_Click(object sender, EventArgs e)
        {
            dtpFecIni.Value = dtpFecFin.Value = DateTime.Today;
            dgvAsistencias.DataSource = Negocio.Asistencia.listarAsistencias(txtPersonal.Text, DateTime.Today, DateTime.Today);
        }

        private void txtPersonal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtIdTrab.Text = Negocio.Persona.traerId(txtPersonal.Text).ToString();
                e.Handled = true;
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            btnEnt.Enabled = txtIdTrab.Text.Equals("0") ? false : true;
        }

        private void txtIdAsist_TextChanged(object sender, EventArgs e)
        {
            btnSal.Enabled = btnElim.Enabled = txtIdAsist.Text.Equals("0") ? false : true;
        }

        private void dgvAsistencias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdAsist.Text = dgvAsistencias.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgvAsistencias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            timerBarraLateral.Start();
            cmbPersonal.SelectedValue = Negocio.Persona.traerId(dgvAsistencias.CurrentRow.Cells[1].Value.ToString());
            dtpFecha.Text = dgvAsistencias.CurrentRow.Cells[2].Value.ToString();
            dtpHoraEntrada.Text = dgvAsistencias.CurrentRow.Cells[3].Value.ToString();
            dtpHoraSalida.Text = dgvAsistencias.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
