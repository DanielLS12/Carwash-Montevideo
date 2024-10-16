using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebaLoading
{
    public partial class frmAlert : Form
    {
        public frmAlert()
        {
            InitializeComponent();
        }

        public enum enmAction
        {
            wait,
            start,
            close
        }

        public enum enmType
        {
            Success,
            Error,
            Info,
            Warning
        }

        private frmAlert.enmAction action;

        private int x, y;

        private void txtCerrarAlerta_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = enmAction.close;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.wait:
                    timer1.Interval = 1500;
                    action = enmAction.close;
                    break;
                case enmAction.start:
                    timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if(this.x < this.Location.X)
                    {
                        this.Left--;
                    } else
                    {
                        if(this.Opacity == 1.0)
                        {
                            action = enmAction.wait;
                        }
                    }
                    break;
                case enmAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;
                    this.Left -= 3;
                    if(base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        public void mostrarAlerta(string msg,enmType type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fName;

            for (int i = 1; i < 10; i++)
            {
                fName = "alert " + i.ToString();
                frmAlert frm = (frmAlert)Application.OpenForms[fName];

                if (frm == null)
                {
                    this.Name = fName;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }
            }

            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch (type)
            {
                case enmType.Success:
                    this.pictureBox1.Image = Presentacion.Properties.Resources.success;
                    lblMsg.ForeColor = Color.FromArgb(0, 192, 0);
                    break;
                case enmType.Error:
                    this.pictureBox1.Image = Presentacion.Properties.Resources.error;
                    lblMsg.ForeColor = Color.FromArgb(192, 0, 0);
                    break;
                case enmType.Warning:
                    this.pictureBox1.Image = Presentacion.Properties.Resources.warning;
                    lblMsg.ForeColor = Color.FromArgb(192, 192, 0);
                    break;
                case enmType.Info:
                    this.pictureBox1.Image = Presentacion.Properties.Resources.info;
                    lblMsg.ForeColor = Color.FromArgb(0, 192, 192);
                    break;
            }

            this.lblMsg.Text = msg;
            this.Show();
            this.action = enmAction.start;
            this.timer1.Interval = 1;
            timer1.Start();
            
        }
    }
}
