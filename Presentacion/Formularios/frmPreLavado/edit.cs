using System;
using System.Windows.Forms;

namespace pruebaLoading.Formularios.frmPreLavado
{
    public partial class edit : Form
    {
        private string mensaje;
        public edit()
        {
            InitializeComponent();
        }

        public string devolverMensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
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
            decimal precio = 0.00m;

            try
            {
                precio = decimal.Parse(String.IsNullOrEmpty(txtPrec.Text) ? "0.00" : txtPrec.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (precio > 0)
            {
                btnHec.DialogResult = DialogResult.OK;
                btnHec.Enabled = true;
            } else
            {
                btnHec.DialogResult = DialogResult.None;
                btnHec.Enabled = false;
            }
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHec_Click(object sender, EventArgs e)
        {
            short id_tarifa = short.Parse(txtIdTar.Text);
            decimal precio = decimal.Parse(txtPrec.Text);
            devolverMensaje = Negocio.Lavado.actualizar(id_tarifa, precio);
        }
    }
}
