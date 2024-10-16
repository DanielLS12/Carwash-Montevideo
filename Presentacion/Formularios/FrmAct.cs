using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Formularios
{
    public partial class FrmAct : Form
    {
        bool sideBarExpand;
        public FrmAct()
        {
            InitializeComponent();
        }

        private void FrmAct_Load(object sender, EventArgs e)
        {

        }

        private void timerSideBar_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                sideBar.Width -= 10;
                if (sideBar.Width == sideBar.MinimumSize.Width)
                {
                    sideBarExpand = false;
                    txtEnlace.Focus();
                    timerSideBar.Stop();
                }
            }
            else
            {
                sideBar.Width += 10;
                if (sideBar.Width == sideBar.MaximumSize.Width)
                {
                    sideBarExpand = true;
                    timerSideBar.Stop();
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            timerSideBar.Start();
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            timerSideBar.Start();
        }

        private void btnHec_Click(object sender, EventArgs e)
        {
            timerSideBar.Start();
        }
    }
}
