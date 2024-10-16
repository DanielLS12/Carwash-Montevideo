namespace pruebaLoading.Formularios.frmPreLavado
{
    partial class edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(edit));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdTar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCan = new System.Windows.Forms.Button();
            this.btnHec = new System.Windows.Forms.Button();
            this.txtPrec = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.txtIdTar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCan);
            this.groupBox1.Controls.Add(this.btnHec);
            this.groupBox1.Controls.Add(this.txtPrec);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 274);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Tarifa Lavado";
            // 
            // txtIdTar
            // 
            this.txtIdTar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdTar.Location = new System.Drawing.Point(165, 74);
            this.txtIdTar.Multiline = true;
            this.txtIdTar.Name = "txtIdTar";
            this.txtIdTar.ReadOnly = true;
            this.txtIdTar.Size = new System.Drawing.Size(67, 30);
            this.txtIdTar.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 29);
            this.label1.TabIndex = 58;
            this.label1.Text = "ID:";
            // 
            // btnCan
            // 
            this.btnCan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCan.Location = new System.Drawing.Point(40, 216);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(105, 32);
            this.btnCan.TabIndex = 57;
            this.btnCan.Text = "Cancelar";
            this.btnCan.UseVisualStyleBackColor = true;
            this.btnCan.Click += new System.EventHandler(this.btnCan_Click);
            // 
            // btnHec
            // 
            this.btnHec.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnHec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHec.Location = new System.Drawing.Point(293, 216);
            this.btnHec.Name = "btnHec";
            this.btnHec.Size = new System.Drawing.Size(98, 32);
            this.btnHec.TabIndex = 56;
            this.btnHec.Text = "Hecho";
            this.btnHec.UseVisualStyleBackColor = true;
            this.btnHec.Click += new System.EventHandler(this.btnHec_Click);
            // 
            // txtPrec
            // 
            this.txtPrec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrec.Location = new System.Drawing.Point(165, 140);
            this.txtPrec.MaxLength = 7;
            this.txtPrec.Multiline = true;
            this.txtPrec.Name = "txtPrec";
            this.txtPrec.Size = new System.Drawing.Size(160, 30);
            this.txtPrec.TabIndex = 53;
            this.txtPrec.Text = "0.00";
            this.txtPrec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrec.TextChanged += new System.EventHandler(this.txtPrec_TextChanged);
            this.txtPrec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrec_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 29);
            this.label4.TabIndex = 54;
            this.label4.Text = "Precio: S/.";
            // 
            // edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(449, 304);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(465, 343);
            this.MinimumSize = new System.Drawing.Size(465, 343);
            this.Name = "edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCan;
        private System.Windows.Forms.Button btnHec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtPrec;
        public System.Windows.Forms.TextBox txtIdTar;
    }
}