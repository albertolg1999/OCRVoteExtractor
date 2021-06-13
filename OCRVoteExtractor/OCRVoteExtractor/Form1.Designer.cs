namespace OCRVoteExtractor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.progresResultado = new System.Windows.Forms.ProgressBar();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnScanners = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.scannerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.origenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirOrigenSeleccionadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarOrigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarAdministradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmtSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btnEnviar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.progresResultado);
            this.panel2.Controls.Add(this.btnTerminar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btnScanners);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1036, 508);
            this.panel2.TabIndex = 11;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.Location = new System.Drawing.Point(419, 424);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(181, 76);
            this.btnEnviar.TabIndex = 20;
            this.btnEnviar.Text = "Enviar Resultados";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Visible = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(854, 468);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Extrayendo  Resultados...";
            // 
            // progresResultado
            // 
            this.progresResultado.Location = new System.Drawing.Point(621, 468);
            this.progresResultado.Name = "progresResultado";
            this.progresResultado.Size = new System.Drawing.Size(227, 13);
            this.progresResultado.Step = 1;
            this.progresResultado.TabIndex = 18;
            // 
            // btnTerminar
            // 
            this.btnTerminar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTerminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTerminar.Enabled = false;
            this.btnTerminar.FlatAppearance.BorderSize = 0;
            this.btnTerminar.Location = new System.Drawing.Point(419, 424);
            this.btnTerminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(181, 76);
            this.btnTerminar.TabIndex = 17;
            this.btnTerminar.Text = "Procesar Papeletas";
            this.btnTerminar.UseVisualStyleBackColor = false;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(72, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Papeletas";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.LightGray;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(34, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(187, 381);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(34, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 381);
            this.panel1.TabIndex = 15;
            // 
            // btnScanners
            // 
            this.btnScanners.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnScanners.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScanners.FlatAppearance.BorderSize = 0;
            this.btnScanners.Location = new System.Drawing.Point(40, 424);
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
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox1.Location = new System.Drawing.Point(299, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(708, 381);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // scannerToolStripMenuItem
            // 
            this.scannerToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.scannerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.origenesToolStripMenuItem,
            this.abrirOrigenSeleccionadoToolStripMenuItem,
            this.sourceSetupToolStripMenuItem,
            this.cerrarOrigenToolStripMenuItem,
            this.cerrarAdministradorToolStripMenuItem});
            this.scannerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scannerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.scannerToolStripMenuItem.Image = global::OCRVoteExtractor.Properties.Resources.scanner_PNG11368;
            this.scannerToolStripMenuItem.Name = "scannerToolStripMenuItem";
            this.scannerToolStripMenuItem.Size = new System.Drawing.Size(61, 35);
            this.scannerToolStripMenuItem.Text = "Scanner";
            this.scannerToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // origenesToolStripMenuItem
            // 
            this.origenesToolStripMenuItem.Name = "origenesToolStripMenuItem";
            this.origenesToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.origenesToolStripMenuItem.Text = "Origenes";
            this.origenesToolStripMenuItem.Click += new System.EventHandler(this.origenesToolStripMenuItem_Click);
            // 
            // abrirOrigenSeleccionadoToolStripMenuItem
            // 
            this.abrirOrigenSeleccionadoToolStripMenuItem.Name = "abrirOrigenSeleccionadoToolStripMenuItem";
            this.abrirOrigenSeleccionadoToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.abrirOrigenSeleccionadoToolStripMenuItem.Text = "Abrir Origen Seleccionado";
            this.abrirOrigenSeleccionadoToolStripMenuItem.Click += new System.EventHandler(this.abrirOrigenSeleccionadoToolStripMenuItem_Click);
            // 
            // sourceSetupToolStripMenuItem
            // 
            this.sourceSetupToolStripMenuItem.Name = "sourceSetupToolStripMenuItem";
            this.sourceSetupToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.sourceSetupToolStripMenuItem.Text = "Source Setup";
            this.sourceSetupToolStripMenuItem.Click += new System.EventHandler(this.sourceSetupToolStripMenuItem_Click);
            // 
            // cerrarOrigenToolStripMenuItem
            // 
            this.cerrarOrigenToolStripMenuItem.Name = "cerrarOrigenToolStripMenuItem";
            this.cerrarOrigenToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.cerrarOrigenToolStripMenuItem.Text = "Cerrar Origen";
            this.cerrarOrigenToolStripMenuItem.Click += new System.EventHandler(this.cerrarOrigenToolStripMenuItem_Click);
            // 
            // cerrarAdministradorToolStripMenuItem
            // 
            this.cerrarAdministradorToolStripMenuItem.Name = "cerrarAdministradorToolStripMenuItem";
            this.cerrarAdministradorToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.cerrarAdministradorToolStripMenuItem.Text = "Cerrar Administrador de Fuentes";
            this.cerrarAdministradorToolStripMenuItem.Click += new System.EventHandler(this.cerrarAdministradorToolStripMenuItem_Click);
            // 
            // tsmtSalir
            // 
            this.tsmtSalir.BackColor = System.Drawing.Color.Transparent;
            this.tsmtSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsmtSalir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmtSalir.ForeColor = System.Drawing.Color.White;
            this.tsmtSalir.Image = global::OCRVoteExtractor.Properties.Resources._340_3402060_marketing_clipart_succession_planning_iconos_de_salir_png;
            this.tsmtSalir.Name = "tsmtSalir";
            this.tsmtSalir.Size = new System.Drawing.Size(41, 35);
            this.tsmtSalir.Text = "Salir";
            this.tsmtSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmtSalir.Click += new System.EventHandler(this.tsmtSalir_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(1036, 39);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 547);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Procesado Papeletas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnScanners;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progresResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ToolStripMenuItem scannerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem origenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirOrigenSeleccionadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sourceSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarOrigenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarAdministradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmtSalir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnTerminar;
    }
}

