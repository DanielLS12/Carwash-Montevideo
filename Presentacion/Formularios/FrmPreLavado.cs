using pruebaLoading.Formularios.frmPreLavado;
using pruebaLoading;
using System;
using System.Windows.Forms;

namespace Interfaz.Formularios
{
    public partial class FrmPreLavado : Form
    {
        public FrmPreLavado()
        {
            InitializeComponent();
            Cargar();
            CargarCategorias();
        }

        private void Cargar()
        {
            cmbTipLav.SelectedIndex = 1;
            dataGridView1.DataSource = Negocio.Lavado.traerLavado();
            lblTL.Text = "Tarifas de lavados encontrados: " + Negocio.Lavado.traerLavado().Count.ToString();
            dataGridView1.ColumnHeadersVisible = Negocio.Lavado.traerLavado().Count == 0 ? false : true;
        }

        private void CargarCategorias()
        {
            var listarCategorias = Negocio.Vehiculo.traerCategorias();
            if (listarCategorias.Count > 0)
            {
                cmbCate.DisplayMember = "descripcion";
                cmbCate.ValueMember = "id_Categoria";
                cmbCate.DataSource = listarCategorias;

            }
        }

        private void Alerta(string msg, frmAlert.enmType type)
        {
            frmAlert frm = new frmAlert();
            frm.mostrarAlerta(msg, type);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string tipo_lavado = cmbTipLav.Text;
            decimal precio = 0.00m;
            byte id_Cat = byte.Parse(cmbCate.SelectedValue.ToString());
            var veh = Negocio.Lavado.busqTarLav(tipo_lavado, id_Cat);

            try
            {
                precio = decimal.Parse(String.IsNullOrEmpty(txtPrec.Text) ? "0.00" : txtPrec.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            if(precio > 0)
            {
                if (veh.Count == 0)
                {
                    string mensaje = Negocio.Lavado.agregar(tipo_lavado, precio, id_Cat);
                    Alerta(mensaje, frmAlert.enmType.Success);
                    Cargar();
                }
                else
                {
                    lblMen.Visible = true;
                    lblMen.Text = "Evitar duplicado de tarifa";
                    timer1.Start();
                }
            }
            
        }

        private void txtPrec_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);

            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar == 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void txtPrec_TextChanged(object sender, EventArgs e)
        {
            btnAgregar.Enabled = txtPrec.Text.Length > 0 ? true : false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblMen.Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdTar.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            edit editar = new edit();
            editar.txtIdTar.Text = txtIdTar.Text;
            editar.txtPrec.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            if (editar.ShowDialog() == DialogResult.OK)
            {
                Alerta(editar.devolverMensaje, frmAlert.enmType.Success);
                Cargar();
            }
        }
    }
}
