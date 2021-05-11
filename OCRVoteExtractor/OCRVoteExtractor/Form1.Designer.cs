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
            this.btnScanners = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.scannerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.origenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirOrigenSeleccionadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnScanners
            // 
            this.btnScanners.Location = new System.Drawing.Point(120, 169);
            this.btnScanners.Margin = new System.Windows.Forms.Padding(2);
            this.btnScanners.Name = "btnScanners";
            this.btnScanners.Size = new System.Drawing.Size(99, 42);
            this.btnScanners.TabIndex = 8;
            this.btnScanners.Text = "Scanners..";
            this.btnScanners.UseVisualStyleBackColor = true;
            this.btnScanners.Click += new System.EventHandler(this.btnScanners_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(251, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(481, 299);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(69, 111);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 42);
            this.button2.TabIndex = 6;
            this.button2.Text = "Template";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 50);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scannerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // scannerToolStripMenuItem
            // 
            this.scannerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.origenesToolStripMenuItem,
            this.abrirOrigenSeleccionadoToolStripMenuItem,
            this.sourceSetupToolStripMenuItem});
            this.scannerToolStripMenuItem.Name = "scannerToolStripMenuItem";
            this.scannerToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.scannerToolStripMenuItem.Text = "Scanner";
            // 
            // origenesToolStripMenuItem
            // 
            this.origenesToolStripMenuItem.Name = "origenesToolStripMenuItem";
            this.origenesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.origenesToolStripMenuItem.Text = "Origenes";
            this.origenesToolStripMenuItem.Click += new System.EventHandler(this.origenesToolStripMenuItem_Click);
            // 
            // abrirOrigenSeleccionadoToolStripMenuItem
            // 
            this.abrirOrigenSeleccionadoToolStripMenuItem.Name = "abrirOrigenSeleccionadoToolStripMenuItem";
            this.abrirOrigenSeleccionadoToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.abrirOrigenSeleccionadoToolStripMenuItem.Text = "Abrir Origen Seleccionado";
            this.abrirOrigenSeleccionadoToolStripMenuItem.Click += new System.EventHandler(this.abrirOrigenSeleccionadoToolStripMenuItem_Click);
            // 
            // sourceSetupToolStripMenuItem
            // 
            this.sourceSetupToolStripMenuItem.Name = "sourceSetupToolStripMenuItem";
            this.sourceSetupToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.sourceSetupToolStripMenuItem.Text = "Source Setup";
            this.sourceSetupToolStripMenuItem.Click += new System.EventHandler(this.sourceSetupToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnScanners);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnScanners;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem scannerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem origenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirOrigenSeleccionadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sourceSetupToolStripMenuItem;
    }
}

