using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz.Formularios
{
    public partial class FrmCaja : Form
    {
        public FrmCaja()
        {
            InitializeComponent();
            
        }

        private void FrmCaja_Load(object sender, EventArgs e)
        {
            cargarTablas();
            controlFechas();
        }

        private void cargarTablas()
        {
            //Tabla Ingreso
            var ResIngre = Negocio.Caja.ListarResIngre(DateTime.Now, DateTime.Now);
            dataGridView1.DataSource = Negocio.Caja.ListarResIngre(DateTime.Now, DateTime.Now);
            lblCantIngre.Text = ResIngre.Count.ToString();


            //Tabla Egreso
            var ResEgre = Negocio.Caja.ListarResEgre(DateTime.Now, DateTime.Now);
            dataGridView2.DataSource = ResEgre; 
            lblCantEgre.Text = ResEgre.Count.ToString();
        }

        private void controlFechas()
        {
            decimal? gastTot = 0;
            decimal? ingreTot = 0;
            DateTime fecInicio = DateTime.MinValue, fecFinal = DateTime.Now;

            fecInicio = DateTime.Parse(dtpFecIni.Text);
            fecFinal = DateTime.Parse(dtpFecFin.Text);

            //Tabla Ingreso
            var ingresos = Negocio.Caja.ListarResIngre(fecInicio, fecFinal);
            dataGridView1.DataSource = ingresos;
            lblCantIngre.Text = ingresos.Count.ToString();
            dataGridView1.ColumnHeadersVisible = ingresos.Count == 0 ? false : true;

            foreach (var g in ingresos)
            {
                ingreTot += g.monto;
            }
            lblIngreso.Text = Math.Round((decimal)ingreTot, 2).ToString();


            //Tabla Egreso
            var egresos = Negocio.Caja.ListarResEgre(fecInicio, fecFinal);
            dataGridView2.DataSource = egresos;
            lblCantEgre.Text = egresos.Count.ToString();
            dataGridView2.ColumnHeadersVisible = egresos.Count == 0 ? false : true;

            foreach (var g in egresos)
            {
                gastTot += g.costo;
            }

            lblEgreso.Text = Math.Round((decimal)gastTot, 2).ToString();
            decimal Egreso = decimal.Parse(lblEgreso.Text), Ingreso = decimal.Parse(lblIngreso.Text);
            lblMonto.Text = Math.Round(Ingreso - Egreso, 2).ToString();

            lblMontoAnt.Text = Math.Round(Negocio.Caja.saldoAnt(fecInicio.AddDays(-1)),2).ToString();
        }


        private void dtpFecIni_ValueChanged(object sender, EventArgs e)
        {
            controlFechas();
        }

        private void dtpFecFin_ValueChanged(object sender, EventArgs e)
        {
            controlFechas();
        }
    }
}
