using pruebaLoading.Formularios.frmPersonal.frmPago;
using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;

namespace pruebaLoading.Formularios.frmPersonal
{
    public partial class addEdit : Form
    {
        private string mensaje;
        decimal sueldo;
        float comision;
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
            CargarOcup();
            CargarDatosTrab();
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarDatosTrab()
        {
            short id_trab = short.Parse(txtIdTrab.Text);
            if (!id_trab.Equals(0))
            {
                var trab = Negocio.Trabajador.traerDatosPerfil(id_trab);
                foreach (var t in trab)
                {
                    txtNom.Text = t.nombres;
                    txtApePat.Text = t.apellido_paterno;
                    txtApeMat.Text = t.apellido_materno;
                    sueldo = t.sueldo;
                    comision = t.comision;
                    txtTelef.Text = t.telefono;
                    txtTelef.ForeColor = Color.Black;
                    if (String.IsNullOrWhiteSpace(txtTelef.Text))
                    {
                        txtTelef.Text = "(Opcional)";
                        txtTelef.ForeColor = Color.Gray;
                    }
                    txtCorreo.Text = t.correo;
                    txtCorreo.ForeColor = Color.Black;
                    if (String.IsNullOrWhiteSpace(txtCorreo.Text))
                    {
                        txtCorreo.Text = "(Opcional)";
                        txtCorreo.ForeColor = Color.Gray;
                    }
                    cmbOcup.SelectedValue = t.id_rol;
                }
                btnEst.Visible = true;
                btnPago.Visible = true;
                bool estado = Negocio.Trabajador.solicitarEstado(id_trab);
                btnEst.Text = !estado ? "Recontratar" : "Despedir";
                btnEst.BackColor = !estado ? Color.DodgerBlue : Color.Red;
            }
        }


        private void CargarOcup()
        {
            var listarOcup = Negocio.Trabajador.traerOcup();
            if (listarOcup.Count > 0)
            {
                cmbOcup.DisplayMember = "ocupacion";
                cmbOcup.ValueMember = "id_rol";
                cmbOcup.DataSource = listarOcup;
            }
        }

        private void txtTelef_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);

            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtCorreo.Focus();
                e.Handled = true;
            }
        }

        private void verificarCampos()
        {
            if (txtNom.Text.Length > 0 && txtApePat.Text.Length > 0 && txtApeMat.Text.Length > 0)
            {
                btnHec.Enabled = true;
            }
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            verificarCampos();
        }

        private void txtApePat_TextChanged(object sender, EventArgs e)
        {
            verificarCampos();
        }

        private void txtApeMat_TextChanged(object sender, EventArgs e)
        {
            verificarCampos();
 
        }

        private void txtTelef_Enter(object sender, EventArgs e)
        {
            if (txtTelef.Text == "(Opcional)")
            {
                txtTelef.Text = "";
                txtTelef.ForeColor = Color.Black;
            }
        }

        private void txtTelef_Leave(object sender, EventArgs e)
        {
            if (txtTelef.Text == "")
            {
                txtTelef.Text = "(Opcional)";
                txtTelef.ForeColor = Color.Gray;
            }
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "(Opcional)")
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.Black;
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            {
                if (txtCorreo.Text == "")
                {
                    txtCorreo.Text = "(Opcional)";
                    txtCorreo.ForeColor = Color.Gray;
                }
            }
        }

        private void btnHec_Click(object sender, EventArgs e)
        {
            short id_trab = short.Parse(txtIdTrab.Text), id_per;
            byte ocup = byte.Parse(cmbOcup.SelectedValue.ToString());
            string nombres = txtNom.Text.Trim(), apePat = txtApePat.Text.Trim(), apeMat = txtApeMat.Text.Trim(),
                telef = txtTelef.Text.Trim(), correo = txtCorreo.Text.Trim();

            if (telef.Equals("(Opcional)")) telef = "";

            if (correo.Equals("(Opcional)")) correo = "";


            if (txtIdTrab.Text.Equals("0"))
            {
                //Agregar
                id_per = Negocio.Persona.agregar(nombres, apePat, apeMat, telef, correo);
                devolverMensaje = Negocio.Trabajador.agregar(id_per,ocup);

            } else
            {
                //Actualizar
                var datosTrab = Negocio.Trabajador.traerDatosPerfil(id_trab);
                foreach(var t in datosTrab)
                {
                    Negocio.Persona.editarPerfil(t.id_Persona, nombres, apePat, apeMat, telef, correo);
                    devolverMensaje = Negocio.Trabajador.actDatos(id_trab,ocup);
                }
            }
        }

        public void soloLetras(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 129)
            || (e.KeyChar >= 131 && e.KeyChar <= 159) || (e.KeyChar >= 166 && e.KeyChar <= 200))
            {
                e.Handled = true;
            }
        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(sender, e);
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtApePat.Focus();
                e.Handled = true;
            }
        }

        private void txtApePat_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(sender, e);
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtApeMat.Focus();
                e.Handled = true;
            }
        }

        private void txtApeMat_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(sender, e);
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtTelef.Focus();
                e.Handled = true;
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNom.Focus();
                e.Handled = true;
            }
        }

        public void Alerta(string msg, frmAlert.enmType type)
        {
            frmAlert frm = new frmAlert();
            frm.mostrarAlerta(msg, type);
        }

        private void btnEst_Click(object sender, EventArgs e)
        {
            string notificacion;
            short id_trab = short.Parse(txtIdTrab.Text);
            bool estTrab = Negocio.Trabajador.solicitarEstado(id_trab);
            DialogResult dialogResult = MessageBox.Show(estTrab ? "¿Desea despedir a este personal?" : "¿Desea recontratar a este personal?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                notificacion = Negocio.Trabajador.actEstado(id_trab, estTrab ? false : true);
                this.Agregar_Load(sender, e);
                Alerta(notificacion, frmAlert.enmType.Success);
            }
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            pagoPersonal pagos = new pagoPersonal();
            pagos.Id_Trab = short.Parse(txtIdTrab.Text);
            pagos.txtSueldo.Text = Math.Round(sueldo,2).ToString();
            pagos.txtComision.Text = comision.ToString();
            if (pagos.ShowDialog() == DialogResult.OK)return;
        }
    }
}
