using System;
using System.Windows.Forms;

namespace pruebaLoading.Formularios.frmPreAdicional
{
    public partial class edit : Form
    {
        private string mensaje;
        private string descripcion;
        public edit()
        {
            InitializeComponent();
        }

        public string devolverMensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHec_Click(object sender, EventArgs e)
        {

            short id_Adicional = short.Parse(txtIdAdicional.Text);
            string desc = txtDesc.Text.Trim();
            decimal precio = decimal.Parse(txtPrec.Text);

            if (!Negocio.Adicional.evitarDupTar(desc) || Descripcion == desc)
            {
                devolverMensaje = Negocio.Adicional.actualizar(id_Adicional, desc, precio);
            } else
            {
                lblMen.Visible = true;
                lblMen.Text = "Evitar duplicado de tarifa";
            }
        }

        private void validaciones()
        {

            decimal precio = 0.00m;
            string desc = txtDesc.Text.Trim();

            try
                {
                    precio = decimal.Parse(String.IsNullOrEmpty(txtPrec.Text) ? "0.00" : txtPrec.Text);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

    
            if (precio > 0 && txtDesc.Text.Length > 0 && !String.IsNullOrWhiteSpace(txtDesc.Text))
            {
                btnHec.Enabled = true;
                if (desc == Descripcion)
                {
                    btnHec.DialogResult = DialogResult.OK;
                } else
                {
                    if (!Negocio.Adicional.evitarDupTar(desc))
                    {
                        btnHec.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        btnHec.DialogResult = DialogResult.None;
                    }
                }
            }
            else
            {
                btnHec.DialogResult = DialogResult.None;
                btnHec.Enabled = false;
            }
        }

        private void txtPrec_TextChanged(object sender, EventArgs e)
        {
            validaciones();
        }

        private void txtPrec_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);

            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar == 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {
            validaciones();
        }

        private void txtDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPrec.Focus();
                e.Handled = true;
            }
        }

        private void Editar_Load(object sender, EventArgs e)
        {
            btnHec.DialogResult = DialogResult.OK;
        }
    }
}
