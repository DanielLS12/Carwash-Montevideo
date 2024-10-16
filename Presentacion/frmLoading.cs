using System;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;

namespace pruebaLoading
{
    public partial class frmLoading : Form
    {
        public frmLoading()
        {
            InitializeComponent();

            WebClient webclient = new WebClient();

            try
            {
                if (!webclient.DownloadString("https://pastebin.com/raw/35ucfDtF").Contains("1.0.0"))
                {
                    if (MessageBox.Show("Hay una nueva versión disponible, ¿Desea actualizar?", "Actualización - Carwash Montevideo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Process.Start("Updater.exe");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 7;

            if (panel2.Width >= 700)
            {
                timer1.Stop();
                this.Hide();
                frmLogin prueba = new frmLogin();
                prueba.FormClosed += (s, args) => this.Close();
                prueba.Show();
            }
        }

        public void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
