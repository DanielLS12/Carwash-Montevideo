using Datos;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using Newtonsoft.Json.Linq;
using PagedList;
using pruebaLoading;
using pruebaLoading.Formularios.frmCrudGast;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.tool.xml.css.parser.state;

namespace Interfaz.Formularios
{
    public partial class FrmGasto : Form
    {
        int numPag = 1;
        decimal? gastoTotal = 0;
        string personal = "";
        string desc = "";
        DateTime fecIni = DateTime.Today;
        DateTime fecFin = DateTime.Today;
        byte opc = 0;
        IPagedList<buscarEgreso_Result> list;

        public FrmGasto()
        {
            InitializeComponent();
            Cargar();
        }

        private async Task<IPagedList<buscarEgreso_Result>> obtenerListPagAsync(int numPag = 1, int pageSize = 25)
        {
            gastoTotal = 0;
            var gastos = Negocio.Gasto.buscarEgresos(personal,desc,fecIni,fecFin,opc);
            lblGasto.Text = $"Gastos encontrados: {gastos.Count}";
            dataGridView1.ColumnHeadersVisible = gastos.Count == 0 ? false : true;
            foreach (var g in gastos)
            {
                gastoTotal += g.gasto;
            }
            lblGastTot.Text = $"Gasto total: S/.{gastoTotal}";
            return await Task.Factory.StartNew(() =>
            {
                return gastos.ToPagedList(numPag, pageSize);
            });
        }

        private void FrmGasto_Load(object sender, EventArgs e)
        {
            cmbPrec.SelectedIndex = 0;
            Cargar();
        }

        private async void Cargar()
        {
            numPag = 1;
            list = await obtenerListPagAsync();
            btnAtras.Enabled = list.HasPreviousPage;
            btnSig.Enabled = list.HasNextPage;
            dataGridView1.DataSource = list.ToList();
            lblNumPag.Text = $"Página {numPag}/{list.PageCount}";
        }
        
        private void Alerta(string msg, frmAlert.enmType type)
        {
            frmAlert frm = new frmAlert();
            frm.mostrarAlerta(msg, type);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            addEdit agregarGast = new addEdit();
            agregarGast.Text = "Agregar";
            if(agregarGast.ShowDialog() == DialogResult.OK)
            {
                Alerta(agregarGast.devolverMensaje, frmAlert.enmType.Success);
                btnBusc_Click(sender, e);
            }
        }

        private void chkFec_CheckedChanged(object sender, EventArgs e)
        {
            dtpFecIni.Enabled = chkFec.Checked ? true : false;
            dtpFecFin.Enabled = chkFec.Checked ? true : false;
            chkFec.Text = chkFec.Checked ? "ON" : "OFF";
        }

        private void chkRan_CheckedChanged(object sender, EventArgs e)
        {
            /*cmbPrec.Enabled = !chkRan.Checked ? true : false;
            txtPrec1.Enabled = !chkRan.Checked ? false : true;
            txtPrec2.Enabled = !chkRan.Checked ? false : true; */
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardarArchivo = new SaveFileDialog();
            guardarArchivo.Filter = "File PDF (*.pdf)|*.pdf";
            guardarArchivo.FileName = DateTime.Now.ToString("ddMMyyyy") + "-Gasto" + ".pdf";


            string paginaInforme = Presentacion.Properties.Resources.informeGastos.ToString();
            paginaInforme = paginaInforme.Replace("@NumGastos", lblGasto.Text);
            paginaInforme = paginaInforme.Replace("@Fecha", fecIni.ToString() == dtpFecIni.MinDate.ToString() ? "" : fecIni.ToString() == fecFin.ToString() ? fecIni.ToShortDateString() : $"{fecIni.ToShortDateString()} - {fecFin.ToShortDateString()}");
            paginaInforme = paginaInforme.Replace("@GastoTotal", this.gastoTotal.ToString());
            paginaInforme = paginaInforme.Replace("@ColumnaFecha", fecIni.ToString() == dtpFecIni.MinDate.ToString() ? "<td></td>" : "");

            string filas = string.Empty;
            var gastos = Negocio.Gasto.buscarEgresos(personal, desc, fecIni, fecFin, opc);
            foreach (var g in gastos)
            {
                filas += "<tr>";
                filas += "<td class=\"datosTabla\">" + g.Nombres + "</td>";
                filas += "<td class=\"datosTabla\">" + g.Apellidos + "</td>";
                filas += "<td class=\"datosTabla\">" + g.descripcion + "</td>";
                filas += fecIni.ToString() == dtpFecIni.MinDate.ToString() ? "<td class=\"datosTabla\">" + g.Fecha.ToShortDateString() + "</td>" : "";
                filas += "<td class=\"datosTabla\">" + g.gasto + "</td>";
                filas += "</tr>";
            }
            paginaInforme = paginaInforme.Replace("@GastoFec", fecIni.ToString() == dtpFecIni.MinDate.ToString() ? "<th class=\"datosTabla\">FECHA</th>" : "");
            paginaInforme = paginaInforme.Replace("@Filas", filas);


            if (guardarArchivo.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(guardarArchivo.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));
                    using (StringReader sr = new StringReader(paginaInforme))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }
                    pdfDoc.Close();
                    stream.Close();
                }
                Alerta("Informe generado correctamente", frmAlert.enmType.Success);
            }
        }

        private void btnBusc_Click(object sender, EventArgs e)
        {
            gastoTotal = 0;
            personal = txtPer.Text.Trim(); desc = txtDesc.Text.Trim();
            opc = (byte)cmbPrec.SelectedIndex;
            fecIni = dtpFecIni.MinDate; fecFin = DateTime.Now;

            if (chkFec.Checked)
            {
                fecIni = DateTime.Parse(dtpFecIni.Text);
                fecFin = DateTime.Parse(dtpFecFin.Text);
            }

            if (chkAscDesc.Checked && cmbPrec.SelectedIndex == 0)
            {
                opc = 3;
            }

            Cargar();
        }

        private void chkAscDesc_CheckedChanged(object sender, EventArgs e)
        {
            chkAscDesc.Text = chkAscDesc.Checked ? "Ascendente" : "Descendente";
        }


        private void txtPrec1_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*e.Handled = char.IsWhiteSpace(e.KeyChar);

            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPrec2.Focus();
                e.Handled = true;
            }*/
        }

        private void txtPrec2_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*e.Handled = char.IsWhiteSpace(e.KeyChar);

            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
            }*/
        }

        private void txtDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdGast.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void txtIdGast_TextChanged(object sender, EventArgs e)
        {
            btnElim.Enabled = !txtIdGast.Text.Equals("0") ? true : false;
        }

        private void btnElim_Click(object sender, EventArgs e)
        {
            int id_egreso = Int32.Parse(txtIdGast.Text);
            DialogResult dialogResult = MessageBox.Show($"¿Desea eliminar este gasto de N° ID: {id_egreso}?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                string mensaje = Negocio.Gasto.eliminar(id_egreso);
                Alerta(mensaje, frmAlert.enmType.Success);
                Cargar();
                txtIdGast.Text = "0";
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            addEdit agregarGast = new addEdit();
            agregarGast.Text = "Editar";
            agregarGast.txtIdGast.Text = txtIdGast.Text;
            agregarGast.txtDesc.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            agregarGast.txtPrec.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            agregarGast.dtpFec.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            if (agregarGast.ShowDialog() == DialogResult.OK)
            {
                Alerta(agregarGast.devolverMensaje, frmAlert.enmType.Success);
                Cargar();
            }
        }

        private void txtPer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtDesc.Focus();
                e.Handled = true;
            }

            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 129)
            || (e.KeyChar >= 131 && e.KeyChar <= 159) || (e.KeyChar >= 166 && e.KeyChar <= 200))
            {
                e.Handled = true;
            }
        }

        private async void btnAtras_Click(object sender, EventArgs e)
        {
            if (list.HasPreviousPage)
            {
                list = await obtenerListPagAsync(numPag != 1 ? --numPag : 1);
                btnAtras.Enabled = list.HasPreviousPage;
                btnSig.Enabled = list.HasNextPage;
                dataGridView1.DataSource = list.ToList();
                lblNumPag.Text = string.Format($"Página {numPag}/{list.PageCount}");
            }
        }

        private async void btnSig_Click(object sender, EventArgs e)
        {
            if (list.HasNextPage)
            {
                list = await obtenerListPagAsync(numPag != list.PageCount ? ++numPag : numPag);
                btnAtras.Enabled = list.HasPreviousPage;
                btnSig.Enabled = list.HasNextPage;
                dataGridView1.DataSource = list.ToList();
                lblNumPag.Text = string.Format($"Página {numPag}/{list.PageCount}");
            }
        }
    }
}
