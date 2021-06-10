namespace OCRVoteExtractor
{
    partial class frmAdminUsuarios
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModicar = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 12);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(898, 381);
            this.dgvUsuarios.TabIndex = 19;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BackgroundImage = global::OCRVoteExtractor.Properties.Resources._5895d3becba9841eabab6082;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(698, 403);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(145, 57);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModicar
            // 
            this.btnModicar.BackColor = System.Drawing.Color.Transparent;
            this.btnModicar.BackgroundImage = global::OCRVoteExtractor.Properties.Resources._5895d3becba9841eabab6082;
            this.btnModicar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModicar.FlatAppearance.BorderSize = 0;
            this.btnModicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModicar.Location = new System.Drawing.Point(402, 403);
            this.btnModicar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModicar.Name = "btnModicar";
            this.btnModicar.Size = new System.Drawing.Size(145, 57);
            this.btnModicar.TabIndex = 21;
            this.btnModicar.Text = "Modificar";
            this.btnModicar.UseVisualStyleBackColor = false;
            this.btnModicar.Click += new System.EventHandler(this.btnModicar_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.Transparent;
            this.btnAñadir.BackgroundImage = global::OCRVoteExtractor.Properties.Resources._5895d3becba9841eabab6082;
            this.btnAñadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAñadir.FlatAppearance.BorderSize = 0;
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.Location = new System.Drawing.Point(83, 403);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(2);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(145, 57);
            this.btnAñadir.TabIndex = 20;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = false;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // frmAdminUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OCRVoteExtractor.Properties.Resources.bgcontrol;
            this.ClientSize = new System.Drawing.Size(905, 471);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModicar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.dgvUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminUsuarios";
            this.Text = "frmAdminUsuarios";
            this.Load += new System.EventHandler(this.frmAdminUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModicar;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.DataGridView dgvUsuarios;
    }
}