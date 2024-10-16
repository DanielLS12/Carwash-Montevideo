using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using pruebaLoading.Formularios.frmServicio.frmServAdic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Numerics;
using System.Windows.Forms;

namespace pruebaLoading.Formularios.frmServicio
{
    public partial class addEdit : Form
    {
        private string placa;
        private bool est_pago = false;
        private string mensaje;
        private List<short> id_TA;
        private List<string> descripciones;
        private List<decimal> precAdic;
        private decimal total_adic;

        public addEdit()
        {
            InitializeComponent();
            id_TA = new List<short>();
            descripciones = new List<string>();
            precAdic = new List<decimal>();
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

        private void addEdit_Load(object sender, EventArgs e)
        {
            int id_serv = Int32.Parse(txtIdServ.Text);
            CargarCategorias();
            CargarLavador();
            cmbCate.SelectedValue = 0;
            cmbTipLav.SelectedIndex = 0;

            if (!id_serv.Equals(0))
            {
                bool estServ = Negocio.Servicio.seleccionarEstado(id_serv);
                var serv_adic = Negocio.Servicio_Adicional.traerServAdic(id_serv);
                short? id_tarLav = Negocio.Servicio.seleccionarIdTarLav(id_serv);
                cmbCate.SelectedValue = Negocio.Vehiculo.SeleccionarCat(Placa);
                cmbTipLav.Text = id_tarLav is null ? "Seleccionar" : Negocio.Lavado.traerTipLav((short)id_tarLav);
                cmbLav.SelectedValue = Negocio.Servicio.seleccionarTrab(id_serv);
                txtDscto.Text = Math.Round(Negocio.Servicio.tomarDscto(id_serv),2).ToString();
                btnEstPag.BackColor = estServ ? Color.FromArgb(0, 192, 0) : Color.Red;
                btnEstPag.Text = estServ ? "Pagado" : "No pagado";
                chkEstServ.Visible = true;
                chkEstServ.Checked = Negocio.Servicio.estado_servicio(id_serv);
                this.est_pago = estServ;
                btnServAdic.Text = $"Servicios Adicionales: {serv_adic.Count}";
                foreach(var sa in serv_adic)
                {
                    this.id_TA.Add(sa.id_TA);
                    this.descripciones.Add(Negocio.Adicional.traerDescAdic(sa.id_TA));
                    this.precAdic.Add(sa.precioAct);
                    this.total_adic += sa.precioAct;
                }
                lblPrecAdic.Text = this.total_adic.Equals(0) ? "0.00" : Math.Round(this.total_adic, 2).ToString();
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

        public void CargarLavador()
        {
            var listarPersonal = Negocio.Trabajador.busqTrabajador("","lavador","","",0,true);
            if (listarPersonal.Count > 0)
            {
                cmbLav.DisplayMember = "Nombres_Apellidos";
                cmbLav.ValueMember = "ID";
                cmbLav.DataSource = listarPersonal;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
            }
        }

        private void btnHec_Click(object sender, EventArgs e)
        {
            short id_trab = short.Parse(cmbLav.SelectedValue.ToString());
            byte id_cate = byte.Parse(cmbCate.SelectedValue.ToString());
            int id_veh = 0, id_serv = Int32.Parse(txtIdServ.Text);
            string placa = $"{txtPlac1.Text}-{txtPlac2.Text}", tip_lav = cmbTipLav.Text.Trim(), cate = cmbCate.Text;
            short? id_tarLav = Negocio.Servicio.seleccionarIdTarLav(id_serv);
            decimal precLav = 0,dscto = decimal.Parse(String.IsNullOrEmpty(txtDscto.Text) ? "0.00" : txtDscto.Text),precAdic = decimal.Parse(lblPrecAdic.Text);
            DateTime? fec_pago = null;
            TimeSpan hora_salida = dtpHoraSalida.Value.TimeOfDay;
            bool estado_servicio = chkEstServ.Checked;
            var datosTarLiv = Negocio.Lavado.busqTarLav(tip_lav, id_cate);
            var datosVeh = Negocio.Vehiculo.buscarVehiculo(placa, cate);

            if (this.est_pago) fec_pago = DateTime.Today;

            foreach (var v in datosVeh)
            {
                id_veh = v.ID;
            }

            foreach (var tl in datosTarLiv)
            {
                id_tarLav = tl.id_TarifaL;
                precLav = tl.precio;
            }
            
            devolverMensaje = id_serv.Equals(0) ? 
                Negocio.Servicio.agregar(id_trab, id_veh, id_tarLav, precLav, precAdic, dscto, this.est_pago, fec_pago,hora_salida) : 
                Negocio.Servicio.actualizar(id_serv,id_trab,id_veh,id_tarLav,precLav,precAdic,dscto,hora_salida,estado_servicio);

            if (!id_serv.Equals(0))Negocio.Servicio_Adicional.elimId_SA(id_serv);

            id_serv = id_serv.Equals(0) ? Negocio.Servicio.traerUltIdServ() : id_serv;
            
            for (int i = 0; i < this.id_TA.Count; i++)
            {
                Negocio.Servicio_Adicional.agregar(id_serv, this.id_TA[i], this.precAdic[i]);
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

            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void txtPlac2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo numeros y letras
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPlac1.Focus();
                e.Handled = true;
            }
        }

        private void soloNumeros(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);

            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar == 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void Alerta(string msg, frmAlert.enmType type)
        {
            frmAlert frm = new frmAlert();
            frm.mostrarAlerta(msg, type);
        }

        private void btnEstPag_Click(object sender, EventArgs e)
        {     
            int id_serv = Int32.Parse(txtIdServ.Text);
            if (!id_serv.Equals(0))
            {
                DialogResult resultado = this.est_pago ? MessageBox.Show("Advertencia: Si cambia el estado del servicio a NO PAGADO, corre el riesgo de perder definitivamente su fecha de pago\n\n¿Esta seguro de realizar el cambio de estado?","ATENCIÓN",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) : DialogResult.Yes;
                if (resultado == DialogResult.Yes)
                {
                    Negocio.Servicio.actEstado(id_serv, this.est_pago ? false : true, this.est_pago ? (DateTime?)null : DateTime.Today); ;
                    cambioEstiloBtnEstPago();
                }
            } else
            {
                cambioEstiloBtnEstPago();
            }
        }

        private void cambioEstiloBtnEstPago()
        {
            this.est_pago = this.est_pago ? false : true;
            btnEstPag.BackColor = this.est_pago ? Color.FromArgb(0, 192, 0) : Color.Red;
            btnEstPag.Text = this.est_pago ? "Pagado" : "No pagado";
        }

        private void txtPlac1_TextChanged(object sender, EventArgs e)
        {
            traerVeh();
        }

        private void txtPlac2_TextChanged(object sender, EventArgs e)
        {
            traerVeh();
        }

        private void traerVeh()
        {
            int numCaracPlac1 = txtPlac1.Text.Length;
            int numCaracPlac2 = txtPlac2.Text.Length;
            if ((numCaracPlac1 == 2 && numCaracPlac2 == 4) || (numCaracPlac1 == 3 && numCaracPlac2 == 3) || (numCaracPlac1 == 4 && numCaracPlac2 == 2))
            {
                byte id = Negocio.Vehiculo.SeleccionarCat($"{txtPlac1.Text}-{txtPlac2.Text}");
                cmbCate.SelectedValue = !id.Equals(0) ? id : byte.Parse("0");
                btnResVeh.Visible = id.Equals(0) ? true : false;
            } else
            {
                cmbCate.SelectedValue = 0;
                btnResVeh.Visible = false;
            }
        }

        public void verifDsctoPrecMonto()
        {
            decimal dscto = 0.00m;
            decimal precLav = decimal.Parse(lblPrecLav.Text), precAdic = decimal.Parse(lblPrecAdic.Text);

            try
            {
                dscto = decimal.Parse(String.IsNullOrEmpty(txtDscto.Text) ? "0.00" : txtDscto.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDscto.Text = "0.00";
            }


            lblMontoPagar.ForeColor = precLav >= dscto ? Color.Black : Color.Red;
            label9.ForeColor = precLav >= dscto ? Color.Black : Color.Red;
            lblMontoPagar.Text = Math.Round((precLav + this.total_adic) - dscto, 2).ToString();

            btnHec.Enabled = label3.ForeColor != Color.Red && cmbCate.SelectedValue != null && precLav >= dscto && (precLav > 0 || precAdic > 0) ? true : false;
        }

        private void cmbCate_TextChanged(object sender, EventArgs e)
        {
            traerTarLav();
  
        }


        private void cmbTipLav_TextChanged(object sender, EventArgs e)
        {
            traerTarLav();

        }

        private void traerTarLav()
        {
            string tip_lav = cmbTipLav.Text;

            if(!tip_lav.Equals("Seleccionar") && !cmbCate.Text.Equals(""))
            {
                byte id_cate = byte.Parse(cmbCate.SelectedValue.ToString());
                var tar_lav = Negocio.Lavado.busqTarLav(tip_lav, id_cate);

                if(tar_lav.Count != 0)
                {
                    foreach (var tl in tar_lav)
                    {
                        lblPrecLav.Visible = true;
                        label3.Text = $"Precio lavado: S/.";
                        lblPrecLav.Text = Math.Round(tl.precio,2).ToString();
                        label3.ForeColor = Color.Black;
                    }
                } else
                {
                    label3.Text = "Tarifa no encontrada";
                    lblPrecLav.Visible = false;
                    label3.ForeColor = Color.Red;
                }

            } else
            {
                lblPrecLav.Visible = true;
                label3.Text = "Precio lavado: S/.";
                lblPrecLav.Text = "0.00";
                label3.ForeColor = Color.Black;
            }
        }
        private void lblPrecLav_TextChanged(object sender, EventArgs e)
        {
            verifDsctoPrecMonto();

        }

        private void txtDscto_TextChanged(object sender, EventArgs e)
        {
            verifDsctoPrecMonto();

        }

        private void lblPrecAdic_TextChanged(object sender, EventArgs e)
        {

            verifDsctoPrecMonto();
        }

       

        private void txtDscto_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
        }

        private void btnServAdic_Click(object sender, EventArgs e)
        {
            frmServAdic.addEdit agregarServ = new frmServAdic.addEdit();
            agregarServ.Text = "Servicios Adicionales";

            for(int i = 0; i < this.id_TA.Count; i++)
            {
                agregarServ.traerId_ta.Add(this.id_TA[i]);
                agregarServ.traerDesc.Add(this.descripciones[i]);
                agregarServ.traerPrecios.Add(this.precAdic[i]);
            }

            if (agregarServ.ShowDialog() == DialogResult.OK)
            {
                
                //Se agregará en una lista el id de la tarifa
                //adicional y el precio de esta para generar un servicio adicional, estás se irán almacenando
                //hasta que el usuario decida que hacer con ellas
                this.id_TA.Clear();
                this.descripciones.Clear();
                this.precAdic.Clear();
                this.total_adic = 0;

                for(int i = 0; i < agregarServ.traerId_ta.Count; i++)
                {
                    this.id_TA.Add(agregarServ.traerId_ta[i]);
                    this.descripciones.Add(agregarServ.traerDesc[i]);
                    this.precAdic.Add(agregarServ.traerPrecios[i]);
                    this.total_adic += agregarServ.traerPrecios[i];
                }
                
                btnServAdic.Text = $"Servicios Adicionales: {this.id_TA.Count}";
                lblPrecAdic.Text = this.id_TA.Count > 0 ? Math.Round(this.total_adic,2).ToString() : "0.00";
            }
        }

        private void label3_ForeColorChanged(object sender, EventArgs e)
        {
            verifDsctoPrecMonto();
        }

        private void btnResVeh_Click(object sender, EventArgs e)
        {
            frmCrudVeh.addEdit agregarVeh = new frmCrudVeh.addEdit();
            agregarVeh.Text = "Agregar";
            agregarVeh.txtPlac1.Text = txtPlac1.Text;
            agregarVeh.txtPlac2.Text = txtPlac2.Text;

            if (agregarVeh.ShowDialog() == DialogResult.OK)
            {
                Alerta(agregarVeh.devolverMensaje, frmAlert.enmType.Success);
                txtPlac1.Clear();
                txtPlac2.Clear();
                txtPlac1.Text = agregarVeh.txtPlac1.Text;
                txtPlac2.Text = agregarVeh.txtPlac2.Text;
            }
        }

        private void chkEstServ_CheckedChanged(object sender, EventArgs e)
        {
            chkEstServ.Text = chkEstServ.Checked ? "Terminado" : "En proceso";
            chkEstServ.ForeColor = chkEstServ.Checked ? Color.FromArgb(0, 192, 0) : Color.Red;
        }
    }
}
