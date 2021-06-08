namespace OCRVoteExtractor
{
    partial class frmLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOcultarpsw = new System.Windows.Forms.Button();
            this.btnVerpsw = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnScanners = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::OCRVoteExtractor.Properties.Resources.bgcontrol;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnOcultarpsw);
            this.panel1.Controls.Add(this.btnVerpsw);
            this.panel1.Controls.Add(this.btnRegistro);
            this.panel1.Controls.Add(this.btnScanners);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 477);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnOcultarpsw
            // 
            this.btnOcultarpsw.BackColor = System.Drawing.Color.Transparent;
            this.btnOcultarpsw.BackgroundImage = global::OCRVoteExtractor.Properties.Resources.hide_icon_153458;
            this.btnOcultarpsw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOcultarpsw.FlatAppearance.BorderSize = 0;
            this.btnOcultarpsw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOcultarpsw.Location = new System.Drawing.Point(390, 242);
            this.btnOcultarpsw.Margin = new System.Windows.Forms.Padding(2);
            this.btnOcultarpsw.Name = "btnOcultarpsw";
            this.btnOcultarpsw.Size = new System.Drawing.Size(27, 25);
            this.btnOcultarpsw.TabIndex = 18;
            this.btnOcultarpsw.UseVisualStyleBackColor = false;
            this.btnOcultarpsw.Visible = false;
            this.btnOcultarpsw.Click += new System.EventHandler(this.btnOcultarpsw_Click);
            // 
            // btnVerpsw
            // 
            this.btnVerpsw.BackColor = System.Drawing.Color.Transparent;
            this.btnVerpsw.BackgroundImage = global::OCRVoteExtractor.Properties.Resources.show_icon_153436;
            this.btnVerpsw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerpsw.FlatAppearance.BorderSize = 0;
            this.btnVerpsw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerpsw.Location = new System.Drawing.Point(390, 242);
            this.btnVerpsw.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerpsw.Name = "btnVerpsw";
            this.btnVerpsw.Size = new System.Drawing.Size(27, 25);
            this.btnVerpsw.TabIndex = 17;
            this.btnVerpsw.UseVisualStyleBackColor = false;
            this.btnVerpsw.Click += new System.EventHandler(this.btnVerpsw_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistro.BackgroundImage = global::OCRVoteExtractor.Properties.Resources._5895d3becba9841eabab6082;
            this.btnRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistro.FlatAppearance.BorderSize = 0;
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistro.Location = new System.Drawing.Point(254, 345);
            this.btnRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(131, 53);
            this.btnRegistro.TabIndex = 16;
            this.btnRegistro.Text = "Registrarse";
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnScanners
            // 
            this.btnScanners.BackColor = System.Drawing.Color.Transparent;
            this.btnScanners.BackgroundImage = global::OCRVoteExtractor.Properties.Resources._5895d3becba9841eabab6082;
            this.btnScanners.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScanners.FlatAppearance.BorderSize = 0;
            this.btnScanners.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScanners.Location = new System.Drawing.Point(87, 345);
            this.btnScanners.Margin = new System.Windows.Forms.Padding(2);
            this.btnScanners.Name = "btnScanners";
            this.btnScanners.Size = new System.Drawing.Size(131, 53);
            this.btnScanners.TabIndex = 15;
            this.btnScanners.Text = "Entrar";
            this.btnScanners.UseVisualStyleBackColor = false;
            this.btnScanners.Click += new System.EventHandler(this.btnScanners_Click);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(152, 242);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(233, 26);
            this.txtPass.TabIndex = 6;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(152, 183);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(233, 26);
            this.txtUser.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::OCRVoteExtractor.Properties.Resources.password;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(87, 228);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(81, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Image = global::OCRVoteExtractor.Properties.Resources._585e4bd7cb11b227491c3397;
            this.label2.Location = new System.Drawing.Point(141, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 63);
            this.label2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::OCRVoteExtractor.Properties.Resources._585e4bd7cb11b227491c3397;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(87, 169);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(63, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "VoteExtractor";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 476);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Button btnScanners;
        private System.Windows.Forms.Button btnVerpsw;
        private System.Windows.Forms.Button btnOcultarpsw;
    }
}