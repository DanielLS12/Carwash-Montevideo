using pruebaLoading;
using pruebaLoading.Formularios.frmPreAdicional;
using System;
using System.Windows.Forms;
using edit = pruebaLoading.Formularios.frmPreAdicional.edit;

namespace Interfaz.Formularios
{
    public partial class FrmPreAdicional : Form
    {
        public FrmPreAdicional()
        {
            InitializeComponent();
            Cargar();
        }

        private void Cargar()
        {
            dataGridView1.DataSource = Negocio.Adicional.traerAdicionales();
            lblAdici.Text = "Adicionales encontrados: " + Negocio.Adicional.traerAdicionales().Count.ToString();
            dataGridView1.ColumnHeadersVisible = Negocio.Adicional.traerAdicionales().Count == 0 ? false : true;
        }

        private void Alerta(string msg, frmAlert.enmType type)
        {
            frmAlert frm = new frmAlert();
            frm.mostrarAlerta(msg, type);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string descripcion = txtDesc.Text.Trim();
            decimal precio = 0.00m;

            try
            {
                precio = decimal.Parse(String.IsNullOrEmpty(txtPrec.Text) ? "0.00" : txtPrec.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            if(!String.IsNullOrWhiteSpace(txtDesc.Text) && precio > 0)
            {
                if (!Negocio.Adicional.evitarDupTar(descripcion))
                {
                    string mensaje = Negocio.Adicional.agregar(descripcion, precio);
                    Alerta(mensaje, frmAlert.enmType.Success);
                    Cargar();
                    txtDesc.Text = "";
                    txtPrec.Text = "0";
                }
                else
                {
                    lblMen.Visible = true;
                    lblMen.Text = "Evitar duplicado de tarifa";
                    timer1.Start();
                }
            } else
            {
                txtDesc.Focus();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblMen.Visible = false;
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
                btnAgregar_Click(sender, e);
                e.Handled = true;
            }
        }


        private void evitarCamposVacios()
        {
            btnAgregar.Enabled = txtPrec.Text.Length > 0 && txtDesc.Text.Length > 0 && !String.IsNullOrWhiteSpace(txtDesc.Text) ? true : false;


        }
        private void txtPrec_TextChanged(object sender, EventArgs e)
        {
            evitarCamposVacios();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdTaAdi.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            edit editar = new edit();
            editar.txtIdAdicional.Text = txtIdTaAdi.Text;
            editar.txtPrec.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            editar.txtDesc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            editar.Descripcion = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            if (editar.ShowDialog() == DialogResult.OK)
            {
                Alerta(editar.devolverMensaje, frmAlert.enmType.Success);
                Cargar();
                txtIdTaAdi.Text = "0";
            }
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {
            evitarCamposVacios();
        }

        private void txtDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPrec.Focus();
                e.Handled = true;
            }
        }
    }
}
