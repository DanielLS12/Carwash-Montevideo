namespace pruebaLoading
{
    partial class frmAlert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlert));
            this.lblMsg = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCerrarAlerta = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblMsg.Location = new System.Drawing.Point(60, 11);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(245, 46);
            this.lblMsg.TabIndex = 1;
            this.lblMsg.Text = "Message";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.success;
            this.pictureBox1.Location = new System.Drawing.Point(8, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtCerrarAlerta
            // 
            this.txtCerrarAlerta.AutoSize = true;
            this.txtCerrarAlerta.FlatAppearance.BorderSize = 0;
            this.txtCerrarAlerta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtCerrarAlerta.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.txtCerrarAlerta.IconColor = System.Drawing.Color.White;
            this.txtCerrarAlerta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.txtCerrarAlerta.IconSize = 40;
            this.txtCerrarAlerta.Location = new System.Drawing.Point(311, 13);
            this.txtCerrarAlerta.Name = "txtCerrarAlerta";
            this.txtCerrarAlerta.Size = new System.Drawing.Size(46, 46);
            this.txtCerrarAlerta.TabIndex = 2;
            this.txtCerrarAlerta.UseCompatibleTextRendering = true;
            this.txtCerrarAlerta.UseVisualStyleBackColor = false;
            this.txtCerrarAlerta.Click += new System.EventHandler(this.txtCerrarAlerta_Click);
            // 
            // frmAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(360, 68);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCerrarAlerta);
            this.Controls.Add(this.lblMsg);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmAlert";
            this.Text = "Notificación";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMsg;
        private FontAwesome.Sharp.IconButton txtCerrarAlerta;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Timer timer1;
    }
}