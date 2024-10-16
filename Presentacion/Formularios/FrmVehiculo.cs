using Datos;
using PagedList;
using pruebaLoading;
using pruebaLoading.Formularios.frmCrudVeh;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz.Formularios
{
    public partial class FrmVehiculo : Form
    {
        private string placa;
        int numPag = 1;
        string placaBusq = "";
        string categoria = "";
        IPagedList<buscarVehiculo_Result> list;

        public FrmVehiculo()
        {
            InitializeComponent();
        }

        private string tomarPlaca
        {
            get { return placa; }
            set { placa = value; }
        }

        private async Task<IPagedList<buscarVehiculo_Result>> obtenerListPagAsync(int numPag = 1, int pageSize = 25)
        {
            var vehiculos = Negocio.Vehiculo.buscarVehiculo(placaBusq,categoria);
            lblCantVeh.Text = $"Vehiculos encontrados: {vehiculos.Count}";
            dataGridView1.ColumnHeadersVisible = vehiculos.Count == 0 ? false : true;
            return await Task.Factory.StartNew(() =>
            {
                return vehiculos.ToPagedList(numPag, pageSize);
            });
        }

        private void FrmVehiculo_Load(object sender, EventArgs e)
        {
            Cargar();
            CargarCategorias();
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

        private void CargarCategorias()
        {
            var listarCategorias = Negocio.Vehiculo.traerCategorias();
            if (listarCategorias.Count > 0)
            {
                cmbCate.Items.Add("Seleccionar");
                cmbCate.SelectedIndex = 0;
                foreach (var c in listarCategorias)
                {
                    cmbCate.Items.Add(c.descripcion);
                }
            }
        }

        private void btnBusc_Click(object sender, EventArgs e)
        {
            placaBusq = txtPlac.Text.Trim();
            categoria = cmbCate.SelectedIndex == 0 ? "" : cmbCate.Text;

            Cargar();
        }

        private void Alerta(string msg, frmAlert.enmType type)
        {
            frmAlert frm = new frmAlert();
            frm.mostrarAlerta(msg, type);
        }

        private void btnAgre_Click(object sender, EventArgs e)
        {
            addEdit agregarVeh = new addEdit();
            agregarVeh.Text = "Agregar";

            if (agregarVeh.ShowDialog() == DialogResult.OK)
            {
                Alerta(agregarVeh.devolverMensaje, frmAlert.enmType.Success);
                Cargar();
            }
        }

        private void txtPlac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnBusc_Click(sender, e);
                e.Handled = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdVeh.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tomarPlaca = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            addEdit agregarVeh = new addEdit();
            agregarVeh.Text = "Editar";
            agregarVeh.txtIdVeh.Text = txtIdVeh.Text;
            string[] subs = tomarPlaca.Split('-');
            agregarVeh.txtPlac1.Text = subs[0];
            agregarVeh.txtPlac2.Text = subs[1];
            agregarVeh.Placa = tomarPlaca;
            if (agregarVeh.ShowDialog() == DialogResult.OK)
            {
                Alerta(agregarVeh.devolverMensaje, frmAlert.enmType.Success);
                Cargar();
                txtIdVeh.Text = "0";
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
