using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace pruebaLoading.Formularios.frmCrudGast
{
    public partial class addEdit : Form
    {
        private string mensaje;
        public addEdit()
        {
            InitializeComponent();
        }

        public string devolverMensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            CargarPersonal();
            camposVacios();
            if(txtIdGast.Text != "0")
            {
                cmbPer.SelectedValue = Negocio.Gasto.seleccionarTrab(Int32.Parse(txtIdGast.Text));
                btnHec.Enabled = true;
            }
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {
            camposVacios();
        }

        private void txtPrec_TextChanged(object sender, EventArgs e)
        {
            camposVacios();
        }

        public void CargarPersonal()
        {
            var listarPersonal = Negocio.Trabajador.busqTrabajador("","","","",0,true);
            if (listarPersonal.Count > 0)
            {

                cmbPer.DisplayMember = "Nombres_Apellidos";
                cmbPer.ValueMember = "ID";
                cmbPer.DataSource = listarPersonal;

            }
        }

        public void camposVacios()
        {
            decimal precio = 0.00m;

            try
            {
                precio = decimal.Parse(String.IsNullOrEmpty(txtPrec.Text) ? "0.00" : txtPrec.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (txtDesc.Text.Length > 0 && precio > 0)
            {
                btnHec.Enabled = true;
            } else
            {
                btnHec.Enabled = false;
            }
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPrec.Focus();
                e.Handled = true;
            }
        }

        private void txtPrec_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);

            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar == 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
            }
        }

        private void btnHec_Click(object sender, EventArgs e)
        {
            string desc = txtDesc.Text.Trim();
            int id_TE = Int32.Parse(txtIdGast.Text);
            short id_trabajador = short.Parse(cmbPer.SelectedValue.ToString());
            decimal precio = decimal.Parse(txtPrec.Text);
            DateTime fec = DateTime.Parse(dtpFec.Text);

            if(id_TE == 0)
            {
                devolverMensaje = Negocio.Gasto.agregar(id_trabajador, desc, precio, fec);
            }
            else
            {
                devolverMensaje = Negocio.Gasto.actualizar(id_TE,id_trabajador, desc, precio, fec);
            }
        }
    }
}
