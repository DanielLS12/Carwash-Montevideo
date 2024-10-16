namespace pruebaLoading.Formularios.frmCrudGast
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdGast = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFec = new System.Windows.Forms.DateTimePicker();
            this.cmbPer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCan = new System.Windows.Forms.Button();
            this.btnHec = new System.Windows.Forms.Button();
            this.txtPrec = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtIdGast);
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpFec);
            this.groupBox1.Controls.Add(this.cmbPer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCan);
            this.groupBox1.Controls.Add(this.btnHec);
            this.groupBox1.Controls.Add(this.txtPrec);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 406);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Gasto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(112, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 29);
            this.label5.TabIndex = 74;
            this.label5.Text = "ID:";
            // 
            // txtIdGast
            // 
            this.txtIdGast.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdGast.Location = new System.Drawing.Point(156, 51);
            this.txtIdGast.Name = "txtIdGast";
            this.txtIdGast.ReadOnly = true;
            this.txtIdGast.Size = new System.Drawing.Size(146, 37);
            this.txtIdGast.TabIndex = 73;
            this.txtIdGast.Text = "0";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(156, 106);
            this.txtDesc.MaxLength = 300;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(317, 63);
            this.txtDesc.TabIndex = 1;
            this.txtDesc.TextChanged += new System.EventHandler(this.txtDesc_TextChanged);
            this.txtDesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesc_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 29);
            this.label2.TabIndex = 72;
            this.label2.Text = "Fecha:";
            // 
            // dtpFec
            // 
            this.dtpFec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFec.Location = new System.Drawing.Point(161, 297);
            this.dtpFec.MinDate = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.dtpFec.Name = "dtpFec";
            this.dtpFec.Size = new System.Drawing.Size(312, 26);
            this.dtpFec.TabIndex = 4;
            // 
            // cmbPer
            // 
            this.cmbPer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPer.FormattingEnabled = true;
            this.cmbPer.Location = new System.Drawing.Point(161, 241);
            this.cmbPer.Name = "cmbPer";
            this.cmbPer.Size = new System.Drawing.Size(312, 32);
            this.cmbPer.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 58;
            this.label1.Text = "Personal:";
            // 
            // btnCan
            // 
            this.btnCan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCan.Location = new System.Drawing.Point(79, 355);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(105, 32);
            this.btnCan.TabIndex = 6;
            this.btnCan.Text = "Cancelar";
            this.btnCan.UseVisualStyleBackColor = true;
            this.btnCan.Click += new System.EventHandler(this.btnCan_Click);
            // 
            // btnHec
            // 
            this.btnHec.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnHec.Enabled = false;
            this.btnHec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHec.Location = new System.Drawing.Point(318, 355);
            this.btnHec.Name = "btnHec";
            this.btnHec.Size = new System.Drawing.Size(98, 32);
            this.btnHec.TabIndex = 5;
            this.btnHec.Text = "Hecho";
            this.btnHec.UseVisualStyleBackColor = true;
            this.btnHec.Click += new System.EventHandler(this.btnHec_Click);
            // 
            // txtPrec
            // 
            this.txtPrec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrec.Location = new System.Drawing.Point(161, 191);
            this.txtPrec.MaxLength = 6;
            this.txtPrec.Multiline = true;
            this.txtPrec.Name = "txtPrec";
            this.txtPrec.Size = new System.Drawing.Size(105, 30);
            this.txtPrec.TabIndex = 2;
            this.txtPrec.Text = "0.00";
            this.txtPrec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrec.TextChanged += new System.EventHandler(this.txtPrec_TextChanged);
            this.txtPrec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrec_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 29);
            this.label3.TabIndex = 52;
            this.label3.Text = "Descripción:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 29);
            this.label4.TabIndex = 54;
            this.label4.Text = "Gasto:";
            // 
            // addEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(533, 430);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(549, 469);
            this.MinimumSize = new System.Drawing.Size(549, 469);
            this.Name = "addEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar";
            this.Load += new System.EventHandler(this.Agregar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCan;
        private System.Windows.Forms.Button btnHec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtDesc;
        public System.Windows.Forms.TextBox txtPrec;
        public System.Windows.Forms.ComboBox cmbPer;
        public System.Windows.Forms.DateTimePicker dtpFec;
        public System.Windows.Forms.TextBox txtIdGast;
        private System.Windows.Forms.Label label5;
    }
}