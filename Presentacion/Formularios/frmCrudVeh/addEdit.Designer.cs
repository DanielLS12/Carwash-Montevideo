namespace pruebaLoading.Formularios.frmCrudVeh
{
    partial class addEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addEdit));
            this.txtPlac1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCate = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdVeh = new System.Windows.Forms.TextBox();
            this.lblMen = new System.Windows.Forms.Label();
            this.lblEnt = new System.Windows.Forms.Label();
            this.txtPlac2 = new System.Windows.Forms.TextBox();
            this.btnCan = new System.Windows.Forms.Button();
            this.btnHec = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPlac1
            // 
            this.txtPlac1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlac1.Location = new System.Drawing.Point(165, 70);
            this.txtPlac1.MaxLength = 4;
            this.txtPlac1.Multiline = true;
            this.txtPlac1.Name = "txtPlac1";
            this.txtPlac1.Size = new System.Drawing.Size(81, 30);
            this.txtPlac1.TabIndex = 53;
            this.txtPlac1.TextChanged += new System.EventHandler(this.txtPlac1_TextChanged);
            this.txtPlac1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlac1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 29);
            this.label3.TabIndex = 52;
            this.label3.Text = "Placa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 29);
            this.label4.TabIndex = 50;
            this.label4.Text = "Categoria:";
            // 
            // cmbCate
            // 
            this.cmbCate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCate.FormattingEnabled = true;
            this.cmbCate.Location = new System.Drawing.Point(165, 142);
            this.cmbCate.Name = "cmbCate";
            this.cmbCate.Size = new System.Drawing.Size(226, 32);
            this.cmbCate.TabIndex = 55;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.txtIdVeh);
            this.groupBox1.Controls.Add(this.lblMen);
            this.groupBox1.Controls.Add(this.lblEnt);
            this.groupBox1.Controls.Add(this.txtPlac2);
            this.groupBox1.Controls.Add(this.btnCan);
            this.groupBox1.Controls.Add(this.btnHec);
            this.groupBox1.Controls.Add(this.txtPlac1);
            this.groupBox1.Controls.Add(this.cmbCate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(42, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 286);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Vehiculo";
            // 
            // txtIdVeh
            // 
            this.txtIdVeh.Location = new System.Drawing.Point(54, 28);
            this.txtIdVeh.Name = "txtIdVeh";
            this.txtIdVeh.Size = new System.Drawing.Size(53, 40);
            this.txtIdVeh.TabIndex = 61;
            this.txtIdVeh.Text = "0";
            this.txtIdVeh.Visible = false;
            // 
            // lblMen
            // 
            this.lblMen.AutoSize = true;
            this.lblMen.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMen.ForeColor = System.Drawing.Color.Red;
            this.lblMen.Location = new System.Drawing.Point(162, 110);
            this.lblMen.Name = "lblMen";
            this.lblMen.Size = new System.Drawing.Size(51, 16);
            this.lblMen.TabIndex = 60;
            this.lblMen.Text = "label1";
            this.lblMen.Visible = false;
            // 
            // lblEnt
            // 
            this.lblEnt.AutoSize = true;
            this.lblEnt.Font = new System.Drawing.Font("Lucida Sans Unicode", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnt.Location = new System.Drawing.Point(259, 63);
            this.lblEnt.Name = "lblEnt";
            this.lblEnt.Size = new System.Drawing.Size(37, 39);
            this.lblEnt.TabIndex = 59;
            this.lblEnt.Text = "-";
            // 
            // txtPlac2
            // 
            this.txtPlac2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlac2.Location = new System.Drawing.Point(310, 70);
            this.txtPlac2.MaxLength = 4;
            this.txtPlac2.Multiline = true;
            this.txtPlac2.Name = "txtPlac2";
            this.txtPlac2.Size = new System.Drawing.Size(81, 30);
            this.txtPlac2.TabIndex = 54;
            this.txtPlac2.TextChanged += new System.EventHandler(this.txtPlac2_TextChanged);
            this.txtPlac2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlac2_KeyPress);
            // 
            // btnCan
            // 
            this.btnCan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCan.Location = new System.Drawing.Point(54, 231);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(105, 32);
            this.btnCan.TabIndex = 57;
            this.btnCan.Text = "Cancelar";
            this.btnCan.UseVisualStyleBackColor = true;
            this.btnCan.Click += new System.EventHandler(this.btnCan_Click);
            // 
            // btnHec
            // 
            this.btnHec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHec.Location = new System.Drawing.Point(293, 231);
            this.btnHec.Name = "btnHec";
            this.btnHec.Size = new System.Drawing.Size(98, 32);
            this.btnHec.TabIndex = 56;
            this.btnHec.Text = "Hecho";
            this.btnHec.UseVisualStyleBackColor = true;
            this.btnHec.Click += new System.EventHandler(this.btnHec_Click);
            // 
            // addEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(536, 347);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(552, 386);
            this.MinimumSize = new System.Drawing.Size(552, 386);
            this.Name = "addEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Agregar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCan;
        private System.Windows.Forms.Label lblEnt;
        public System.Windows.Forms.Button btnHec;
        public System.Windows.Forms.TextBox txtPlac1;
        public System.Windows.Forms.TextBox txtPlac2;
        private System.Windows.Forms.Label lblMen;
        public System.Windows.Forms.TextBox txtIdVeh;
        public System.Windows.Forms.ComboBox cmbCate;
    }
}