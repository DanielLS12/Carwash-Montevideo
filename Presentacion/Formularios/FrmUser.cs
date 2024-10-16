using pruebaLoading;
using System;
using System.Windows.Forms;

namespace Interfaz.Formularios
{
    public partial class FrmUser : Form
    {

        public FrmUser()
        {
            InitializeComponent();
        }

        private void Alerta(string msg, frmAlert.enmType type)
        {
            frmAlert frm = new frmAlert();
            frm.mostrarAlerta(msg, type);
        }

        private void btnActDatos_Click(object sender, EventArgs e)
        {
            short id_per = short.Parse(txtIdPers.Text);
            string nom = txtNom.Text.Trim(),ape_pat = txtApePat.Text.Trim(),ape_mat = txtApeMat.Text.Trim(),
                telef = txtTelef.Text.Trim(),correo = txtCorreo.Text.Trim();

            if (nom.Trim() == "" || ape_mat.Trim() == "" || ape_pat.Trim() == "")
            {
                Alerta("Verifique que uno de los campos no este vacio", frmAlert.enmType.Error);
            }
            else
            {
                String mensaje = Negocio.Persona.editarPerfil(id_per, nom, ape_pat, ape_mat, telef, correo);

                Alerta(mensaje, frmAlert.enmType.Success);
            }
            

        }

        private void btnActAcc_Click(object sender, EventArgs e)
        {
            short id_user = short.Parse(txtIdUser.Text);
            string user = txtUser.Text.Trim(), actClave = txtActPass.Text, nueClave = txtNuePass.Text,mensaje;

            if(!String.IsNullOrEmpty(user) && !String.IsNullOrEmpty(actClave))
            {
                var comprobarClave = Negocio.Login.comprobarClave(id_user,actClave);

                if (comprobarClave.Count > 0)
                {
                    if (String.IsNullOrEmpty(nueClave))
                    {
                        mensaje = Negocio.Login.actUser(id_user, user);
                        Alerta(mensaje, frmAlert.enmType.Success);
                    }
                    else
                    {
                        mensaje = Negocio.Login.actAcc(id_user, user, nueClave);
                        Alerta(mensaje, frmAlert.enmType.Success);
                    }
                    txtActPass.Text = "";
                    txtNuePass.Text = "";

                } else
                {
                    Alerta("Contraseña incorrecta", frmAlert.enmType.Error);
                }
            } else
            {
                Alerta("Revise que algunos de los campos no esten vacios", frmAlert.enmType.Error);
            }
        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtApePat.Focus();
                e.Handled = true;
            }

            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void txtApePat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtApeMat.Focus();
                e.Handled = true;
            }

            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void txtApeMat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtCorreo.Focus();
                e.Handled = true;
            }

            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtTelef.Focus();
                e.Handled = true;
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
                txtNom.Focus();
                e.Handled = true;
            }
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtActPass.Focus();
                e.Handled = true;
            }
        }

        private void txtActPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNuePass.Focus();
                e.Handled = true;
            }
        }

        private void txtNuePass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtUser.Focus();
                e.Handled = true;
            }
        }
    }
}
