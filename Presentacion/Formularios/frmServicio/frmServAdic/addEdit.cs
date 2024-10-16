using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace pruebaLoading.Formularios.frmServicio.frmServAdic
{
    public partial class addEdit : Form
    {
        private List<short> listId_ta;
        private List<string> listDesc;
        private List<decimal> listPrecios;
        public addEdit()
        {
            InitializeComponent();
            listId_ta = new List<short>();
            listDesc = new List<string>();
            listPrecios = new List<decimal>();
        }
        public List<short> traerId_ta
        {
            get { return listId_ta; }
            set { listId_ta = value; }
        }

        public List<string> traerDesc
        {
            get { return listDesc; }
            set { listDesc = value; }
        }

        public List<decimal> traerPrecios
        {
            get { return listPrecios; }
            set { listPrecios = value; }
        }

        private void addEdit_Load(object sender, EventArgs e)
        {
            cargarAdicionales();
            for(int i = 0; i < this.traerId_ta.Count; i++)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = this.traerId_ta[i];
                dataGridView1.Rows[n].Cells[1].Value = this.traerDesc[i];
                dataGridView1.Rows[n].Cells[2].Value = Math.Round(this.traerPrecios[i],2);
            }
        }
        private void cargarAdicionales()
        {
            var listarAdicionales = Negocio.Adicional.traerAdicionales();
            if (listarAdicionales.Count > 0)
            {
                cmbAdic.DisplayMember = "descripcion";
                cmbAdic.ValueMember = "ID";
                cmbAdic.DataSource = listarAdicionales;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            short id_ta = (short)cmbAdic.SelectedValue;
            bool agregar = false;

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                short id = (short)fila.Cells[0].Value;
                agregar = id != id_ta || id_ta == 18 ? true : false;
                if(!agregar)break;
            }
            if(dataGridView1.Rows.Count == 0 || agregar)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = id_ta;
                dataGridView1.Rows[n].Cells[1].Value = cmbAdic.Text;
                dataGridView1.Rows[n].Cells[2].Value = Math.Round(Negocio.Adicional.traerPrecAdic(id_ta), 2);
                label3.Visible = false;
            } else
            {
                label3.Text = "Esta tarifa ya esta registrada";
                label3.Visible = true;
            }
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbAdic_TextChanged(object sender, EventArgs e)
        {
            if(cmbAdic != null)
            {
                short id_ta = (short)cmbAdic.SelectedValue;
                decimal precAct = Negocio.Adicional.traerPrecAdic(id_ta);
                label2.Text = Math.Round(precAct,2).ToString();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if(n != -1)
            {
                dataGridView1.Rows.RemoveAt(n);
            }
        }

        private void btnHec_Click(object sender, EventArgs e)
        {
            this.listId_ta.Clear();
            this.listDesc.Clear();
            this.listPrecios.Clear();
            foreach(DataGridViewRow fila in dataGridView1.Rows)
            {
                this.listId_ta.Add((short)fila.Cells[0].Value);
                this.listDesc.Add(fila.Cells[1].Value.ToString());
                this.listPrecios.Add(Math.Round((decimal)fila.Cells[2].Value,2));
            }
        }
    }
}
