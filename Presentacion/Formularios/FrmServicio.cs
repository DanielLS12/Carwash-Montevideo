using Datos;
using PagedList;
using pruebaLoading;
using pruebaLoading.Formularios.frmServicio;
using System;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using iTextSharp.tool.xml.css.parser.state;
using System.util;

namespace Interfaz.Formularios
{
    public partial class FrmServicio : Form
    {
        private string placa;
        private decimal? montoTotal = 0;
        int numPag = 1;
        string placaBusq = "";
        byte id_cat = 0;
        DateTime fecIni = DateTime.Today;
        DateTime fecFin = DateTime.Today;
        string trabajador = "";
        byte opc = 0;
        byte opcDscto = 0;
        bool estPago = false;

        IPagedList<busqServicio_Result> list;
        public FrmServicio()
        {
            InitializeComponent();
        }

        public string tomarPlaca
        {
            get { return placa; }
            set { placa = value; }
        }

        private async Task<IPagedList<busqServicio_Result>> obtenerListPagAsync(int numPag = 1,int pageSize= 25)
        {
            this.montoTotal = 0;
            var serv = Negocio.Servicio.listarServicios(placaBusq,id_cat,fecIni, fecFin,trabajador,opc,opcDscto,estPago);
            lblNumServ.Text = $"Servicios encontrados: {serv.Count}";
            dataGridView1.ColumnHeadersVisible = serv.Count == 0 ? false : true;
            foreach (var s in serv)
            {
                this.montoTotal += s.monto;
            }
            lblMonTot.Text = $"Monto total: S/.{this.montoTotal}";
            return await Task.Factory.StartNew(() =>
            {
                return serv.ToPagedList(numPag, pageSize);
            });
        }

        private async void FrmServicio_Load(object sender, EventArgs e)
        {
            list = await obtenerListPagAsync();
            btnAtras.Enabled = list.HasPreviousPage;
            btnSig.Enabled = list.HasNextPage;
            dataGridView1.DataSource = list.ToList();
            lblNumPag.Text = $"Página {numPag}/{list.PageCount}";

            CargarCategorias();
            cmbPago.SelectedIndex = 0;
            cmbDscto.SelectedIndex = 0;
        }

        private void CargarCategorias()
        {
            var listarCategorias = Negocio.Vehiculo.traerCategorias();
            if (listarCategorias.Count > 0)
            {
                cmbCate.Items.Add("Seleccionar");
                cmbCate.SelectedIndex = 0;
                foreach(var c in listarCategorias)
                {
                    cmbCate.Items.Add(c.descripcion);
                }
            }
        }

        private void txtPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
            }
        }


        private void txtLav_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 129)
            || (e.KeyChar >= 131 && e.KeyChar <= 159) || (e.KeyChar >= 166 && e.KeyChar <= 200))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
            }
        }

        private void Alerta(string msg, frmAlert.enmType type)
        {
            frmAlert frm = new frmAlert();
            frm.mostrarAlerta(msg, type);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            addEdit agregarServ = new addEdit();
            agregarServ.Text = "Agregar";
            if(agregarServ.ShowDialog() == DialogResult.OK)
            {
                Alerta(agregarServ.devolverMensaje, frmAlert.enmType.Success);
                cargar(dataGridView1.Rows.Count == 25 ? ++numPag : numPag);
            }
        }

        private void btnElim_Click(object sender, EventArgs e)
        {
            int id_serv = Int32.Parse(txtIdServ.Text);
            DialogResult dialogResult = MessageBox.Show($"¿Desea eliminar el servicio de N°ID: {id_serv}?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Negocio.Servicio_Adicional.elimId_SA(id_serv);
                string mensaje = Negocio.Servicio.eliminar(id_serv);
                Alerta(mensaje, frmAlert.enmType.Success);
                cargar(dataGridView1.Rows.Count == 1 ? ( numPag != 1 ? --numPag : numPag ) : numPag);                
                txtIdServ.Text = "0";
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardarArchivo = new SaveFileDialog();
            guardarArchivo.Filter = "File PDF (*.pdf)|*.pdf";
            guardarArchivo.FileName = DateTime.Now.ToString("ddMMyyyy-Servicio") + ".pdf";


            string paginaInforme = Presentacion.Properties.Resources.informeServicio.ToString();
            paginaInforme = paginaInforme.Replace("@NumServicios", lblNumServ.Text);
            paginaInforme = paginaInforme.Replace("@Fecha",fecIni.ToString() == dtpFecIni.MinDate.ToString() ? "" : fecIni.ToString() == fecFin.ToString() ? fecIni.ToShortDateString() : $"{fecIni.ToShortDateString()} - {fecFin.ToShortDateString()}");
            paginaInforme = paginaInforme.Replace("@MontoTotal", this.montoTotal.ToString());
            paginaInforme = paginaInforme.Replace("@ColumnaFecPedido", fecIni.ToString() == dtpFecIni.MinDate.ToString() ? "<td></td>" : "");

            string filas = string.Empty;
            var serv = Negocio.Servicio.listarServicios(placaBusq, id_cat, fecIni, fecFin, trabajador, opc, opcDscto, estPago);
            foreach (var s in serv)
            {
                string fecPago = s.fecha_pago is null ? "--/--/----" : s.fecha_pago.Value.ToShortDateString();
                filas += "<tr>";
                filas += "<td class=\"datosTabla\">" + s.Placa +"</td>";
                filas += "<td class=\"datosTabla\">" + s.Categoria +"</td>";
                filas += "<td class=\"datosTabla\">" + s.tipo_lavado +"</td>";
                filas += "<td class=\"datosTabla\">" + s.Lavador +"</td>";
                filas += fecIni.ToString() == dtpFecIni.MinDate.ToString()? "<td class=\"datosTabla\">" + s.fecha_pedido.ToShortDateString() + "</td>" : "";
                filas += "<td class=\"datosTabla\">" + s.estado_pago +"</td>";
                filas += "<td class=\"datosTabla\">" + fecPago+"</td>";
                filas += "<td class=\"datosTabla\">" + s.descuento +"</td>";
                filas += "<td class=\"datosTabla\">" + s.monto +"</td>";
                filas += "</tr>";
            }
            paginaInforme = paginaInforme.Replace("@Pedido", fecIni.ToString() == dtpFecIni.MinDate.ToString() ? "<th class=\"datosTabla\">FECHA PEDIDO</th>" : "");
            paginaInforme = paginaInforme.Replace("@Filas",filas);
            

            if (guardarArchivo.ShowDialog() == DialogResult.OK)
            {
                using(FileStream stream = new FileStream(guardarArchivo.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));
                    using(StringReader sr = new StringReader(paginaInforme))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer,pdfDoc,sr);
                    }
                    pdfDoc.Close();
                    stream.Close();
                }
                Alerta("Informe generado correctamente", frmAlert.enmType.Success);
            }
        }

        private async void btnBusc_Click(object sender, EventArgs e)
        {
            this.montoTotal = 0;

            placaBusq = txtPlaca.Text.Trim(); trabajador = txtLav.Text.Trim();
            id_cat = (byte)(cmbCate.SelectedIndex == 0 ? 0 : Negocio.Vehiculo.tomarIdCat(cmbCate.Text)); opc = (byte)(chkAscDesc.Checked ? 1 : 0);
            opcDscto = (byte)(cmbDscto.SelectedIndex == 0 ? 0 : byte.Parse(cmbDscto.SelectedIndex.ToString()));
            fecIni = chkFec.Checked ? dtpFecIni.Value : dtpFecIni.MinDate; fecFin = chkFec.Checked ? dtpFecFin.Value : DateTime.Now;
            estPago = cmbPago.SelectedIndex == 1 ? true : false;
            if (cmbPago.SelectedIndex != 0) opc = (byte)(chkAscDesc.Checked ? 3 : 2);


            numPag = 1;
            list = await obtenerListPagAsync();
            btnAtras.Enabled = list.HasPreviousPage;
            btnSig.Enabled = list.HasNextPage;
            dataGridView1.DataSource = list.ToList();
            lblNumPag.Text = $"Página {numPag}/{list.PageCount}";
        }

        private void chkAscDesc_CheckedChanged(object sender, EventArgs e)
        {
            chkAscDesc.Text = chkAscDesc.Checked ? "Ascendente" : "Descendente";
        }

        private void chkFec_CheckedChanged(object sender, EventArgs e)
        {
            chkFec.Text = chkFec.Checked ? "ON" : "OFF";
            dtpFecIni.Enabled = chkFec.Checked ? true : false;
            dtpFecFin.Enabled = chkFec.Checked ? true : false;
        }

        private void txtIdServ_TextChanged(object sender, EventArgs e)
        {
            btnElim.Enabled = txtIdServ.Text.Equals("0") ? false : true;
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtIdServ.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            addEdit editarServ = new addEdit();
            editarServ.Text = "Editar";
            editarServ.txtIdServ.Text = txtIdServ.Text;
            tomarPlaca = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string[] subs = tomarPlaca.Split('-');
            editarServ.txtPlac1.Text = subs[0];
            editarServ.txtPlac2.Text = subs[1];
            editarServ.dtpHoraSalida.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[11].Value.ToString());
            editarServ.Placa = tomarPlaca;
            if (editarServ.ShowDialog() == DialogResult.OK)
            {
                Alerta(editarServ.devolverMensaje, frmAlert.enmType.Success);
                cargar(numPag);
            }
            else
            {
                cargar(numPag);
            }
        }
        private async void cargar(int numPag)
        {
            list = await obtenerListPagAsync(numPag);
            btnAtras.Enabled = list.HasPreviousPage;
            btnSig.Enabled = list.HasNextPage;
            dataGridView1.DataSource = list.ToList();
            lblNumPag.Text = $"Página {numPag}/{list.PageCount}";
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
