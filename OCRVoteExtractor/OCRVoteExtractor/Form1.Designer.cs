﻿namespace OCRVoteExtractor
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.scannerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.origenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirOrigenSeleccionadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarOrigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarAdministradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmtSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnScanners = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTemplate = new System.Windows.Forms.Button();
            this.btnBuscarCuadros = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.BackgroundImage = global::OCRVoteExtractor.Properties.Resources.unnamed;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scannerToolStripMenuItem,
            this.tsmtSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1036, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // scannerToolStripMenuItem
            // 
            this.scannerToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.scannerToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.scannerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.origenesToolStripMenuItem,
            this.abrirOrigenSeleccionadoToolStripMenuItem,
            this.sourceSetupToolStripMenuItem,
            this.cerrarOrigenToolStripMenuItem,
            this.cerrarAdministradorToolStripMenuItem});
            this.scannerToolStripMenuItem.Font = new System.Drawing.Font("Neo Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scannerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.scannerToolStripMenuItem.Name = "scannerToolStripMenuItem";
            this.scannerToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.scannerToolStripMenuItem.Text = "Scanner";
            // 
            // origenesToolStripMenuItem
            // 
            this.origenesToolStripMenuItem.Name = "origenesToolStripMenuItem";
            this.origenesToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.origenesToolStripMenuItem.Text = "Origenes";
            this.origenesToolStripMenuItem.Click += new System.EventHandler(this.origenesToolStripMenuItem_Click);
            // 
            // abrirOrigenSeleccionadoToolStripMenuItem
            // 
            this.abrirOrigenSeleccionadoToolStripMenuItem.Name = "abrirOrigenSeleccionadoToolStripMenuItem";
            this.abrirOrigenSeleccionadoToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.abrirOrigenSeleccionadoToolStripMenuItem.Text = "Abrir Origen Seleccionado";
            this.abrirOrigenSeleccionadoToolStripMenuItem.Click += new System.EventHandler(this.abrirOrigenSeleccionadoToolStripMenuItem_Click);
            // 
            // sourceSetupToolStripMenuItem
            // 
            this.sourceSetupToolStripMenuItem.Name = "sourceSetupToolStripMenuItem";
            this.sourceSetupToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.sourceSetupToolStripMenuItem.Text = "Source Setup";
            this.sourceSetupToolStripMenuItem.Click += new System.EventHandler(this.sourceSetupToolStripMenuItem_Click);
            // 
            // cerrarOrigenToolStripMenuItem
            // 
            this.cerrarOrigenToolStripMenuItem.Name = "cerrarOrigenToolStripMenuItem";
            this.cerrarOrigenToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.cerrarOrigenToolStripMenuItem.Text = "Cerrar Origen";
            this.cerrarOrigenToolStripMenuItem.Click += new System.EventHandler(this.cerrarOrigenToolStripMenuItem_Click);
            // 
            // cerrarAdministradorToolStripMenuItem
            // 
            this.cerrarAdministradorToolStripMenuItem.Name = "cerrarAdministradorToolStripMenuItem";
            this.cerrarAdministradorToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.cerrarAdministradorToolStripMenuItem.Text = "Cerrar Administrador de Fuentes";
            this.cerrarAdministradorToolStripMenuItem.Click += new System.EventHandler(this.cerrarAdministradorToolStripMenuItem_Click);
            // 
            // tsmtSalir
            // 
            this.tsmtSalir.BackColor = System.Drawing.Color.Transparent;
            this.tsmtSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsmtSalir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmtSalir.Image = global::OCRVoteExtractor.Properties.Resources._340_3402060_marketing_clipart_succession_planning_iconos_de_salir_png;
            this.tsmtSalir.Name = "tsmtSalir";
            this.tsmtSalir.Size = new System.Drawing.Size(28, 20);
            this.tsmtSalir.Click += new System.EventHandler(this.tsmtSalir_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.BackgroundImage = global::OCRVoteExtractor.Properties.Resources.bgcontrol1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btnTerminar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btnScanners);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnTemplate);
            this.panel2.Controls.Add(this.btnBuscarCuadros);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1036, 523);
            this.panel2.TabIndex = 11;
            // 
            // btnTerminar
            // 
            this.btnTerminar.BackColor = System.Drawing.Color.Transparent;
            this.btnTerminar.BackgroundImage = global::OCRVoteExtractor.Properties.Resources._5895d3becba9841eabab6082;
            this.btnTerminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTerminar.FlatAppearance.BorderSize = 0;
            this.btnTerminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerminar.Location = new System.Drawing.Point(529, 436);
            this.btnTerminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(181, 76);
            this.btnTerminar.TabIndex = 17;
            this.btnTerminar.Text = "Terminar Votación";
            this.btnTerminar.UseVisualStyleBackColor = false;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Papeletas";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(32, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(187, 381);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(32, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 381);
            this.panel1.TabIndex = 15;
            // 
            // btnScanners
            // 
            this.btnScanners.BackColor = System.Drawing.Color.Transparent;
            this.btnScanners.BackgroundImage = global::OCRVoteExtractor.Properties.Resources._5895d3becba9841eabab6082;
            this.btnScanners.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScanners.FlatAppearance.BorderSize = 0;
            this.btnScanners.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScanners.Location = new System.Drawing.Point(38, 436);
            this.btnScanners.Margin = new System.Windows.Forms.Padding(2);
            this.btnScanners.Name = "btnScanners";
            this.btnScanners.Size = new System.Drawing.Size(181, 76);
            this.btnScanners.TabIndex = 14;
            this.btnScanners.Text = "Escanear Papeletas";
            this.btnScanners.UseVisualStyleBackColor = false;
            this.btnScanners.Click += new System.EventHandler(this.btnScanners_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(297, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(708, 385);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnTemplate
            // 
            this.btnTemplate.BackColor = System.Drawing.Color.Transparent;
            this.btnTemplate.BackgroundImage = global::OCRVoteExtractor.Properties.Resources._5895d3becba9841eabab6082;
            this.btnTemplate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTemplate.Enabled = false;
            this.btnTemplate.FlatAppearance.BorderSize = 0;
            this.btnTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemplate.Location = new System.Drawing.Point(297, 435);
            this.btnTemplate.Margin = new System.Windows.Forms.Padding(2);
            this.btnTemplate.Name = "btnTemplate";
            this.btnTemplate.Size = new System.Drawing.Size(181, 76);
            this.btnTemplate.TabIndex = 12;
            this.btnTemplate.Text = "Buscar Template";
            this.btnTemplate.UseVisualStyleBackColor = false;
            this.btnTemplate.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBuscarCuadros
            // 
            this.btnBuscarCuadros.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarCuadros.BackgroundImage = global::OCRVoteExtractor.Properties.Resources._5895d3becba9841eabab6082;
            this.btnBuscarCuadros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarCuadros.Enabled = false;
            this.btnBuscarCuadros.FlatAppearance.BorderSize = 0;
            this.btnBuscarCuadros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCuadros.Location = new System.Drawing.Point(746, 435);
            this.btnBuscarCuadros.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarCuadros.Name = "btnBuscarCuadros";
            this.btnBuscarCuadros.Size = new System.Drawing.Size(181, 76);
            this.btnBuscarCuadros.TabIndex = 11;
            this.btnBuscarCuadros.Text = "Dectectar Casillas";
            this.btnBuscarCuadros.UseVisualStyleBackColor = false;
            this.btnBuscarCuadros.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 547);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "OCRVoteExtractor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem scannerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem origenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirOrigenSeleccionadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sourceSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarOrigenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarAdministradorToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnScanners;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTemplate;
        private System.Windows.Forms.Button btnBuscarCuadros;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem tsmtSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTerminar;
    }
}

