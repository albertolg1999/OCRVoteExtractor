namespace OCRVoteExtractor
{
    partial class frmResultados
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chrtresultados = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnExportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chrtresultados)).BeginInit();
            this.SuspendLayout();
            // 
            // chrtresultados
            // 
            chartArea3.Name = "ChartArea1";
            this.chrtresultados.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chrtresultados.Legends.Add(legend3);
            this.chrtresultados.Location = new System.Drawing.Point(12, 12);
            this.chrtresultados.Name = "chrtresultados";
            this.chrtresultados.Size = new System.Drawing.Size(898, 391);
            this.chrtresultados.TabIndex = 0;
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.Transparent;
            this.btnExportar.BackgroundImage = global::OCRVoteExtractor.Properties.Resources._5895d3becba9841eabab6082;
            this.btnExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.ForeColor = System.Drawing.Color.Black;
            this.btnExportar.Location = new System.Drawing.Point(466, 417);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(131, 53);
            this.btnExportar.TabIndex = 30;
            this.btnExportar.Text = "Exportar Grafica";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // frmResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OCRVoteExtractor.Properties.Resources.bgcontrol;
            this.ClientSize = new System.Drawing.Size(961, 505);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.chrtresultados);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmResultados";
            this.Text = "frmResultados";
            this.Load += new System.EventHandler(this.frmResultados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrtresultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrtresultados;
        private System.Windows.Forms.Button btnExportar;
    }
}