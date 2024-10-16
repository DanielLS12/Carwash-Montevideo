using Datos;
using Presentacion.Formularios.frmPersonal.frmAsistencias;
using pruebaLoading;
using pruebaLoading.Formularios.frmPersonal;
using System;
using System.Windows.Forms;

namespace Interfaz.Formularios
{
    public partial class FrmPersonal : Form
    {
        public FrmPersonal()
        {
            InitializeComponent();
        }

        private void FrmPersonal_Load(object sender, EventArgs e)
        {
            Cargar();
            CargarOcup();
            cmbEst.SelectedIndex = 0;
            cmbTipPag.SelectedIndex = 0;
        }

        private void Cargar()
        {
            var datosTrab = Negocio.Trabajador.busqTrabajador("", "", "", "",0, true);
            dataGridView1.DataSource = datosTrab;
            lblPerson.Text = "Personal encontrados: " + datosTrab.Count.ToString();
            dataGridView1.ColumnHeadersVisible = datosTrab.Count == 0 ? false : true;
        }

        private void CargarOcup()
        {
            var listarOcup = Negocio.Trabajador.traerOcup();
            if(listarOcup.Count > 0)
            {
                cmbOcup.Items.Add("Seleccionar");
                cmbOcup.SelectedIndex = 0;
                foreach(var c in listarOcup)
                {
                    cmbOcup.Items.Add(c.ocupacion);
                }
            }
        }

        private void Alerta(string msg, frmAlert.enmType type)
        {
            frmAlert frm = new frmAlert();
            frm.mostrarAlerta(msg, type);
        }

        private void btnContr_Click(object sender, EventArgs e)
        {
            addEdit contratarPersonal = new addEdit();
            contratarPersonal.Text = "Contratar";
            if(contratarPersonal.ShowDialog() == DialogResult.OK)
            {
                Alerta(contratarPersonal.devolverMensaje, frmAlert.enmType.Success);
                Cargar();
            }
        }

        private void txtSuel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);

            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void txtCor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPer.Focus();
                e.Handled = true;
            }
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);

            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtCor.Focus();
                e.Handled = true;
            }
        }


        private void btnBusc_Click(object sender, EventArgs e)
        {
            string nomApe = txtPer.Text.Trim(), ocup = "", telef = txtTel.Text.Trim(), correo = txtCor.Text.Trim();
            byte tip_pag = (byte)cmbTipPag.SelectedIndex;
            bool estado = true;
    
            if (cmbOcup.SelectedIndex != 0)
            {
                ocup = cmbOcup.Text;
            }

            if(cmbEst.SelectedIndex == 1)
            {
                estado = false;
            }

            var datosTrab = Negocio.Trabajador.busqTrabajador(nomApe, ocup, telef, correo,tip_pag,estado);

            dataGridView1.DataSource = datosTrab;
            lblPerson.Text = "Personal encontrados: " + datosTrab.Count.ToString();
            dataGridView1.ColumnHeadersVisible = datosTrab.Count == 0 ? false : true;
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            addEdit contratarPersonal = new addEdit();
            contratarPersonal.Text = "Editar";
            contratarPersonal.txtIdTrab.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (contratarPersonal.ShowDialog() == DialogResult.OK)
            {
                Alerta(contratarPersonal.devolverMensaje, frmAlert.enmType.Success);
                btnBusc_Click(sender, e);
            } else
            {
                btnBusc_Click(sender, e);
            }
        }

        private void txtPer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtTel.Focus();
                e.Handled = true;
            }

            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 129)
                || (e.KeyChar >= 131 && e.KeyChar <= 159) || (e.KeyChar >= 166 && e.KeyChar <= 200))
            {
                e.Handled = true;
            }
        }

        private void btnAsist_Click(object sender, EventArgs e)
        {
            frmAsistencias frmAsist = new frmAsistencias();
            if (frmAsist.ShowDialog() == DialogResult.Cancel) return;
        }
    }
    
}
