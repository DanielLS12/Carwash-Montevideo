using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebaLoading.Formularios.frmPersonal.frmPago
{
    public partial class pagoPersonal : Form
    {
        private short id_trab;
        private string mensaje;

        public pagoPersonal()
        {
            InitializeComponent();
        }

        public short Id_Trab
        {
            get { return id_trab; }
            set { id_trab = value; }
        }

        public string devolverMensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }

        private void pagoPersonal_Load(object sender, EventArgs e)
        {
            decimal sueldo = decimal.Parse(txtSueldo.Text);
            float comision = float.Parse(txtComision.Text);
            cmbTipPag.SelectedIndex = sueldo > 0 && comision > 0 ? 1 : sueldo > 0 && comision == 0 ? 0 : 2;
            lblMontoServ.Text = Math.Round(Negocio.Trabajador.montosPorServicio(this.id_trab, DateTime.Today, DateTime.Today),2).ToString();
        }

        private void cmbTipPag_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipPag.SelectedIndex == 0)
            {
                txtComision.Enabled = false;
                txtComision.Text = "0.00";
                txtSueldo.Enabled = true;
            }
            else if (cmbTipPag.SelectedIndex == 1)
            {
                txtComision.Enabled = true;
                txtSueldo.Enabled = true;
            }
            else
            {
                txtComision.Enabled = true;
                txtSueldo.Text = "0.00";
                txtSueldo.Enabled = false;
            }
            verificarCampos();
        }

        private void verificarCampos()
        {
            float comision = 0.00f, sueldo = 0.00f,montoServ = float.Parse(lblMontoServ.Text);
            DateTime fecIni = dtpFecIni.Value, fecFin = dtpFecFin.Value;


            try
            {
                sueldo = float.Parse(String.IsNullOrEmpty(txtSueldo.Text) ? "0.00" : txtSueldo.Text);
                comision = float.Parse(String.IsNullOrEmpty(txtComision.Text) ? "0.00" : txtComision.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (cmbTipPag.SelectedIndex == 0)
            {
                btnPagar.Enabled = sueldo > 0  && montoServ > 0? true : false;
            }
            else if (cmbTipPag.SelectedIndex == 1)
            {
                btnPagar.Enabled = sueldo > 0 && comision > 0 && montoServ > 0? true : false;
            }
            else
            {
                btnPagar.Enabled = comision > 0 && montoServ > 0 ? true : false;
            }

            //Consultar el pago que se realizará cada vez que cambien los datos
            decimal montoPorComision = Negocio.Trabajador.montosPorServicio(this.id_trab, fecIni, fecFin);
            lblComision.Text = Math.Round((float)montoPorComision * comision / 100, 2).ToString();
            lblPago.Text = Math.Round(sueldo + ((float)montoPorComision * comision / 100), 2).ToString();
        }

        private void soloNumeros(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);

            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar == 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void txtSueldo_TextChanged(object sender, EventArgs e)
        {
            verificarCampos();
        }

        private void txtComision_TextChanged(object sender, EventArgs e)
        {
            verificarCampos();
        }

        private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
        }

        private void txtComision_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            decimal totalPago = decimal.Parse(lblPago.Text),sueldo = decimal.Parse(txtSueldo.Text);
            string desc = cmbTipPag.SelectedIndex == 0 ? "Pago | Sueldo" : cmbTipPag.SelectedIndex == 1 ? "Pago | Sueldo + Comisión" : "Pago | Comisión";
            float comision = float.Parse(txtComision.Text);
            if (totalPago > 0)
            {
                DialogResult actPago = MessageBox.Show($"¿Esta seguro de querer entregar el pago al trabajador?\n Total a pagar: S/.{lblPago.Text}", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (actPago == DialogResult.Yes)
                {
                    Negocio.Gasto.agregar(this.id_trab,desc, totalPago, DateTime.Today);
                    MessageBox.Show("Pago realizado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                }
            }
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calcularMontoTotalServicios()
        {
            DateTime fecIni = dtpFecIni.Value, fecFin = dtpFecFin.Value;
            lblMontoServ.Text = Math.Round(Negocio.Trabajador.montosPorServicio(this.id_trab, fecIni,fecFin), 2).ToString();
        }

        private void dtpFecIni_ValueChanged(object sender, EventArgs e)
        {
            calcularMontoTotalServicios();
        }

        private void dtpFecFin_ValueChanged(object sender, EventArgs e)
        {
            calcularMontoTotalServicios();
        }

        private void lblMontoServ_TextChanged(object sender, EventArgs e)
        {
            verificarCampos();
        }
    }
}
