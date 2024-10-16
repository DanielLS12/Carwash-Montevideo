using System;
using System.Windows.Forms;

namespace pruebaLoading.Formularios.frmCrudVeh
{
    public partial class addEdit : Form
    {
        private string mensaje;
        private string placa;
        public addEdit()
        {
            InitializeComponent();
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            if(txtIdVeh.Text != "0")
            {
                cmbCate.SelectedValue = Negocio.Vehiculo.SeleccionarCat(Placa);
                btnHec.DialogResult = DialogResult.OK;
            }
        }

        public void CargarCategorias()
        {
            var listarCategorias = Negocio.Vehiculo.traerCategorias();
            if (listarCategorias.Count > 0)
            {
                cmbCate.DisplayMember = "descripcion";
                cmbCate.ValueMember = "id_Categoria";
                cmbCate.DataSource = listarCategorias;
            }
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Alerta(string msg, frmAlert.enmType type)
        {
            frmAlert frm = new frmAlert();
            frm.mostrarAlerta(msg, type);
        }

        public string devolverMensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }

        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        public void btnHec_Click(object sender, EventArgs e)
        {
            byte id_cate = byte.Parse(cmbCate.SelectedValue.ToString());
            int id_veh = Int32.Parse(txtIdVeh.Text);
            string placaPart1 = txtPlac1.Text.Trim().ToUpper(), placaPart2 = txtPlac2.Text.Trim().ToUpper(), 
                placa = $"{placaPart1}-{placaPart2}";


            if (!String.IsNullOrWhiteSpace(placaPart1) && !String.IsNullOrWhiteSpace(placaPart2))
            {
                bool verifDup = Negocio.Vehiculo.evitarDup(placa);
                if (!verifDup || placa == Placa)
                {
                    devolverMensaje = id_veh == 0 ? Negocio.Vehiculo.agregar(id_cate, placa) : Negocio.Vehiculo.actualizar(id_veh, id_cate, placa);
                }
                else
                {
                    lblMen.Text = "Evitar duplicado de placa";
                    lblMen.Visible = true;
                }
            }
            else
            {
                lblMen.Text = "No se aceptan campos vacios";
                lblMen.Visible = true;
            }
        }

        private void txtPlac1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPlac2.Focus();
                e.Handled = true;
            }

            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <=96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void txtPlac2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);

            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void txtPlac1_TextChanged(object sender, EventArgs e)
        {
            comprobarCampVacios();
        }

        private void txtPlac2_TextChanged(object sender, EventArgs e)
        {
            comprobarCampVacios();
        }

        public void comprobarCampVacios()
        {
            string placaPart1 = txtPlac1.Text.Trim().ToUpper(), placaPart2 = txtPlac2.Text.Trim(),
                placa = $"{placaPart1}-{placaPart2}";

            btnHec.DialogResult = txtPlac1.Text.Length > 0 && txtPlac2.Text.Length > 0 ? placa == Placa ? DialogResult.OK : 
                !Negocio.Vehiculo.evitarDup(placa) ? DialogResult.OK : DialogResult.None : DialogResult.None;
        }
    }
}
