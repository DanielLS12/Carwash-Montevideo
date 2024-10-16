namespace Presentacion.Formularios
{
    partial class FrmAct
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
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Perfil = new System.Windows.Forms.Label();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.txtId = new System.Windows.Forms.TextBox();
            this.sideBar = new System.Windows.Forms.Panel();
            this.txtEnlace = new System.Windows.Forms.TextBox();
            this.txtVersion = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnHec = new System.Windows.Forms.Button();
            this.btnCan = new System.Windows.Forms.Button();
            this.timerSideBar = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel2.SuspendLayout();
            this.sideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(84)))));
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1096, 75);
            this.panelTitulo.TabIndex = 20;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(68)))), ((int)(((byte)(115)))));
            this.flowLayoutPanel2.Controls.Add(this.Perfil);
            this.flowLayoutPanel2.Controls.Add(this.btnAgregar);
            this.flowLayoutPanel2.Controls.Add(this.btnEdit);
            this.flowLayoutPanel2.Controls.Add(this.iconButton2);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 75);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1096, 82);
            this.flowLayoutPanel2.TabIndex = 32;
            // 
            // Perfil
            // 
            this.Perfil.AutoSize = true;
            this.Perfil.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Bold);
            this.Perfil.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Perfil.Location = new System.Drawing.Point(3, 0);
            this.Perfil.Name = "Perfil";
            this.Perfil.Size = new System.Drawing.Size(362, 61);
            this.Perfil.TabIndex = 0;
            this.Perfil.Text = "Actualizaciones";
            this.Perfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            this.btnAgregar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.Location = new System.Drawing.Point(371, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(54, 59);
            this.btnAgregar.TabIndex = 95;
            this.btnAgregar.TabStop = false;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.PenSquare;
            this.btnEdit.IconColor = System.Drawing.Color.Gray;
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdit.Location = new System.Drawing.Point(431, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(54, 59);
            this.btnEdit.TabIndex = 98;
            this.btnEdit.TabStop = false;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.AutoSize = true;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 42;
            this.iconButton2.Location = new System.Drawing.Point(491, 3);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(54, 59);
            this.iconButton2.TabIndex = 99;
            this.iconButton2.TabStop = false;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(402, 6);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 92;
            this.txtId.TabStop = false;
            this.txtId.Text = "0";
            this.txtId.Visible = false;
            // 
            // sideBar
            // 
            this.sideBar.Controls.Add(this.txtEnlace);
            this.sideBar.Controls.Add(this.txtId);
            this.sideBar.Controls.Add(this.txtVersion);
            this.sideBar.Controls.Add(this.label7);
            this.sideBar.Controls.Add(this.label8);
            this.sideBar.Controls.Add(this.btnHec);
            this.sideBar.Controls.Add(this.btnCan);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 157);
            this.sideBar.MaximumSize = new System.Drawing.Size(511, 152);
            this.sideBar.MinimumSize = new System.Drawing.Size(5, 152);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(511, 152);
            this.sideBar.TabIndex = 94;
            // 
            // txtEnlace
            // 
            this.txtEnlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnlace.Location = new System.Drawing.Point(94, 28);
            this.txtEnlace.Name = "txtEnlace";
            this.txtEnlace.Size = new System.Drawing.Size(408, 24);
            this.txtEnlace.TabIndex = 101;
            this.txtEnlace.TabStop = false;
            // 
            // txtVersion
            // 
            this.txtVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVersion.Location = new System.Drawing.Point(95, 87);
            this.txtVersion.Mask = "0.0.0.0";
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(78, 31);
            this.txtVersion.TabIndex = 100;
            this.txtVersion.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(12, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 26);
            this.label7.TabIndex = 93;
            this.label7.Text = "Versión:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(12, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 26);
            this.label8.TabIndex = 57;
            this.label8.Text = "Enlace:";
            // 
            // btnHec
            // 
            this.btnHec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHec.Location = new System.Drawing.Point(225, 84);
            this.btnHec.Name = "btnHec";
            this.btnHec.Size = new System.Drawing.Size(111, 38);
            this.btnHec.TabIndex = 67;
            this.btnHec.TabStop = false;
            this.btnHec.Text = "Hecho";
            this.btnHec.UseVisualStyleBackColor = true;
            this.btnHec.Click += new System.EventHandler(this.btnHec_Click);
            // 
            // btnCan
            // 
            this.btnCan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCan.Location = new System.Drawing.Point(371, 84);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(111, 38);
            this.btnCan.TabIndex = 98;
            this.btnCan.TabStop = false;
            this.btnCan.Text = "Cancelar";
            this.btnCan.UseVisualStyleBackColor = true;
            this.btnCan.Click += new System.EventHandler(this.btnCan_Click);
            // 
            // timerSideBar
            // 
            this.timerSideBar.Interval = 2;
            this.timerSideBar.Tick += new System.EventHandler(this.timerSideBar_Tick);
            // 
            // FrmAct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(66)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(1096, 696);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panelTitulo);
            this.Name = "FrmAct";
            this.Text = "FrmAct";
            this.Load += new System.EventHandler(this.FrmAct_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.sideBar.ResumeLayout(false);
            this.sideBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label Perfil;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Panel sideBar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnHec;
        private System.Windows.Forms.Button btnCan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtVersion;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton btnEdit;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Timer timerSideBar;
        private System.Windows.Forms.TextBox txtEnlace;
    }
}