namespace OCRVoteExtractor
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administraciónUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiResultados = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::OCRVoteExtractor.Properties.Resources.bgcontrol;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administraciónUsuariosToolStripMenuItem,
            this.tsmiResultados,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(931, 44);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administraciónUsuariosToolStripMenuItem
            // 
            this.administraciónUsuariosToolStripMenuItem.AutoSize = false;
            this.administraciónUsuariosToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.administraciónUsuariosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.administraciónUsuariosToolStripMenuItem.Image = global::OCRVoteExtractor.Properties.Resources._585e4bd7cb11b227491c3397;
            this.administraciónUsuariosToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.administraciónUsuariosToolStripMenuItem.Name = "administraciónUsuariosToolStripMenuItem";
            this.administraciónUsuariosToolStripMenuItem.Size = new System.Drawing.Size(150, 40);
            this.administraciónUsuariosToolStripMenuItem.Text = "Administración Usuarios";
            this.administraciónUsuariosToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.administraciónUsuariosToolStripMenuItem.Click += new System.EventHandler(this.administraciónUsuariosToolStripMenuItem_Click);
            // 
            // tsmiResultados
            // 
            this.tsmiResultados.BackColor = System.Drawing.SystemColors.Control;
            this.tsmiResultados.ForeColor = System.Drawing.Color.White;
            this.tsmiResultados.Image = global::OCRVoteExtractor.Properties.Resources.estadisticas;
            this.tsmiResultados.Name = "tsmiResultados";
            this.tsmiResultados.Size = new System.Drawing.Size(76, 40);
            this.tsmiResultados.Text = "Resultados";
            this.tsmiResultados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiResultados.Click += new System.EventHandler(this.tsmiResultados_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.BackgroundImage = global::OCRVoteExtractor.Properties.Resources._340_3402060_marketing_clipart_succession_planning_iconos_de_salir_png;
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.salirToolStripMenuItem.Image = global::OCRVoteExtractor.Properties.Resources._340_3402060_marketing_clipart_succession_planning_iconos_de_salir_png;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 40);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 530);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administraciónUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiResultados;
    }
}