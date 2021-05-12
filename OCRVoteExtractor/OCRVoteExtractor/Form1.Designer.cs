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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.scannerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.origenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirOrigenSeleccionadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarOrigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarAdministradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkRemoveBlankPages = new System.Windows.Forms.CheckBox();
            this.chkRemoveDots = new System.Windows.Forms.CheckBox();
            this.chkAutoDesk = new System.Windows.Forms.CheckBox();
            this.chkRotate180 = new System.Windows.Forms.CheckBox();
            this.chkRotate90 = new System.Windows.Forms.CheckBox();
            this.chkIndicator = new System.Windows.Forms.CheckBox();
            this.chkHideUI = new System.Windows.Forms.CheckBox();
            this.ChkAutoCrop = new System.Windows.Forms.CheckBox();
            this.ChkNeg = new System.Windows.Forms.CheckBox();
            this.chkDuplex = new System.Windows.Forms.CheckBox();
            this.chkAutoBrightness = new System.Windows.Forms.CheckBox();
            this.HContrast = new System.Windows.Forms.HScrollBar();
            this.HBrightness = new System.Windows.Forms.HScrollBar();
            this.Line3 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Line1 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Brightness = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnScanners = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scannerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1036, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // scannerToolStripMenuItem
            // 
            this.scannerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.origenesToolStripMenuItem,
            this.abrirOrigenSeleccionadoToolStripMenuItem,
            this.sourceSetupToolStripMenuItem,
            this.cerrarOrigenToolStripMenuItem,
            this.cerrarAdministradorToolStripMenuItem});
            this.scannerToolStripMenuItem.Name = "scannerToolStripMenuItem";
            this.scannerToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.scannerToolStripMenuItem.Text = "Scanner";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.BackgroundImage = global::OCRVoteExtractor.Properties.Resources.unnamed;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.chkRemoveBlankPages);
            this.panel2.Controls.Add(this.chkRemoveDots);
            this.panel2.Controls.Add(this.chkAutoDesk);
            this.panel2.Controls.Add(this.chkRotate180);
            this.panel2.Controls.Add(this.chkRotate90);
            this.panel2.Controls.Add(this.chkIndicator);
            this.panel2.Controls.Add(this.chkHideUI);
            this.panel2.Controls.Add(this.ChkAutoCrop);
            this.panel2.Controls.Add(this.ChkNeg);
            this.panel2.Controls.Add(this.chkDuplex);
            this.panel2.Controls.Add(this.chkAutoBrightness);
            this.panel2.Controls.Add(this.HContrast);
            this.panel2.Controls.Add(this.HBrightness);
            this.panel2.Controls.Add(this.Line3);
            this.panel2.Controls.Add(this.Label9);
            this.panel2.Controls.Add(this.Label8);
            this.panel2.Controls.Add(this.Line1);
            this.panel2.Controls.Add(this.Label7);
            this.panel2.Controls.Add(this.Label6);
            this.panel2.Controls.Add(this.Label5);
            this.panel2.Controls.Add(this.Label4);
            this.panel2.Controls.Add(this.Label3);
            this.panel2.Controls.Add(this.Label2);
            this.panel2.Controls.Add(this.Label1);
            this.panel2.Controls.Add(this.Brightness);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btnScanners);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1036, 443);
            this.panel2.TabIndex = 11;
            // 
            // chkRemoveBlankPages
            // 
            this.chkRemoveBlankPages.BackColor = System.Drawing.Color.Transparent;
            this.chkRemoveBlankPages.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkRemoveBlankPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRemoveBlankPages.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkRemoveBlankPages.Location = new System.Drawing.Point(8, 321);
            this.chkRemoveBlankPages.Name = "chkRemoveBlankPages";
            this.chkRemoveBlankPages.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkRemoveBlankPages.Size = new System.Drawing.Size(176, 19);
            this.chkRemoveBlankPages.TabIndex = 69;
            this.chkRemoveBlankPages.Text = "Discard blank pages";
            this.chkRemoveBlankPages.UseVisualStyleBackColor = false;
            // 
            // chkRemoveDots
            // 
            this.chkRemoveDots.BackColor = System.Drawing.Color.Transparent;
            this.chkRemoveDots.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkRemoveDots.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRemoveDots.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkRemoveDots.Location = new System.Drawing.Point(190, 296);
            this.chkRemoveDots.Name = "chkRemoveDots";
            this.chkRemoveDots.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkRemoveDots.Size = new System.Drawing.Size(176, 19);
            this.chkRemoveDots.TabIndex = 68;
            this.chkRemoveDots.Text = "Remove isolated dots";
            this.chkRemoveDots.UseVisualStyleBackColor = false;
            // 
            // chkAutoDesk
            // 
            this.chkAutoDesk.BackColor = System.Drawing.Color.Transparent;
            this.chkAutoDesk.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkAutoDesk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutoDesk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkAutoDesk.Location = new System.Drawing.Point(8, 296);
            this.chkAutoDesk.Name = "chkAutoDesk";
            this.chkAutoDesk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkAutoDesk.Size = new System.Drawing.Size(92, 19);
            this.chkAutoDesk.TabIndex = 67;
            this.chkAutoDesk.Text = "Auto Deskew";
            this.chkAutoDesk.UseVisualStyleBackColor = false;
            // 
            // chkRotate180
            // 
            this.chkRotate180.BackColor = System.Drawing.Color.Transparent;
            this.chkRotate180.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkRotate180.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRotate180.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkRotate180.Location = new System.Drawing.Point(190, 271);
            this.chkRotate180.Name = "chkRotate180";
            this.chkRotate180.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkRotate180.Size = new System.Drawing.Size(127, 19);
            this.chkRotate180.TabIndex = 64;
            this.chkRotate180.Text = "Rotate 180°";
            this.chkRotate180.UseVisualStyleBackColor = false;
            // 
            // chkRotate90
            // 
            this.chkRotate90.BackColor = System.Drawing.Color.Transparent;
            this.chkRotate90.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkRotate90.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRotate90.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkRotate90.Location = new System.Drawing.Point(190, 246);
            this.chkRotate90.Name = "chkRotate90";
            this.chkRotate90.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkRotate90.Size = new System.Drawing.Size(127, 19);
            this.chkRotate90.TabIndex = 63;
            this.chkRotate90.Text = "Rotate 90°";
            this.chkRotate90.UseVisualStyleBackColor = false;
            // 
            // chkIndicator
            // 
            this.chkIndicator.BackColor = System.Drawing.Color.Transparent;
            this.chkIndicator.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkIndicator.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIndicator.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkIndicator.Location = new System.Drawing.Point(211, 164);
            this.chkIndicator.Name = "chkIndicator";
            this.chkIndicator.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkIndicator.Size = new System.Drawing.Size(174, 17);
            this.chkIndicator.TabIndex = 62;
            this.chkIndicator.Text = "Show Progress Indicator";
            this.chkIndicator.UseVisualStyleBackColor = false;
            // 
            // chkHideUI
            // 
            this.chkHideUI.BackColor = System.Drawing.Color.Transparent;
            this.chkHideUI.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkHideUI.Checked = true;
            this.chkHideUI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHideUI.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkHideUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHideUI.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkHideUI.Location = new System.Drawing.Point(320, 188);
            this.chkHideUI.Name = "chkHideUI";
            this.chkHideUI.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkHideUI.Size = new System.Drawing.Size(65, 17);
            this.chkHideUI.TabIndex = 61;
            this.chkHideUI.Text = "Hide UI";
            this.chkHideUI.UseVisualStyleBackColor = false;
            // 
            // ChkAutoCrop
            // 
            this.ChkAutoCrop.BackColor = System.Drawing.Color.Transparent;
            this.ChkAutoCrop.Cursor = System.Windows.Forms.Cursors.Default;
            this.ChkAutoCrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkAutoCrop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ChkAutoCrop.Location = new System.Drawing.Point(8, 271);
            this.ChkAutoCrop.Name = "ChkAutoCrop";
            this.ChkAutoCrop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChkAutoCrop.Size = new System.Drawing.Size(157, 19);
            this.ChkAutoCrop.TabIndex = 60;
            this.ChkAutoCrop.Text = "Remove Black Borders";
            this.ChkAutoCrop.UseVisualStyleBackColor = false;
            // 
            // ChkNeg
            // 
            this.ChkNeg.BackColor = System.Drawing.Color.Transparent;
            this.ChkNeg.Cursor = System.Windows.Forms.Cursors.Default;
            this.ChkNeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkNeg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ChkNeg.Location = new System.Drawing.Point(8, 246);
            this.ChkNeg.Name = "ChkNeg";
            this.ChkNeg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChkNeg.Size = new System.Drawing.Size(127, 19);
            this.ChkNeg.TabIndex = 59;
            this.ChkNeg.Text = "Negative ";
            this.ChkNeg.UseVisualStyleBackColor = false;
            // 
            // chkDuplex
            // 
            this.chkDuplex.BackColor = System.Drawing.Color.Transparent;
            this.chkDuplex.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkDuplex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDuplex.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkDuplex.Location = new System.Drawing.Point(8, 188);
            this.chkDuplex.Name = "chkDuplex";
            this.chkDuplex.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkDuplex.Size = new System.Drawing.Size(147, 17);
            this.chkDuplex.TabIndex = 55;
            this.chkDuplex.Text = "Enable Duplex";
            this.chkDuplex.UseVisualStyleBackColor = false;
            // 
            // chkAutoBrightness
            // 
            this.chkAutoBrightness.BackColor = System.Drawing.Color.Transparent;
            this.chkAutoBrightness.Checked = true;
            this.chkAutoBrightness.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoBrightness.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkAutoBrightness.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutoBrightness.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkAutoBrightness.Location = new System.Drawing.Point(8, 93);
            this.chkAutoBrightness.Name = "chkAutoBrightness";
            this.chkAutoBrightness.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkAutoBrightness.Size = new System.Drawing.Size(157, 17);
            this.chkAutoBrightness.TabIndex = 54;
            this.chkAutoBrightness.Text = "Auto-Brightness";
            this.chkAutoBrightness.UseVisualStyleBackColor = false;
            // 
            // HContrast
            // 
            this.HContrast.Cursor = System.Windows.Forms.Cursors.Default;
            this.HContrast.LargeChange = 1;
            this.HContrast.Location = new System.Drawing.Point(8, 128);
            this.HContrast.Maximum = 1000;
            this.HContrast.Minimum = -1000;
            this.HContrast.Name = "HContrast";
            this.HContrast.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HContrast.Size = new System.Drawing.Size(378, 21);
            this.HContrast.TabIndex = 49;
            this.HContrast.TabStop = true;
            // 
            // HBrightness
            // 
            this.HBrightness.Cursor = System.Windows.Forms.Cursors.Default;
            this.HBrightness.LargeChange = 1;
            this.HBrightness.Location = new System.Drawing.Point(8, 53);
            this.HBrightness.Maximum = 1000;
            this.HBrightness.Minimum = -1000;
            this.HBrightness.Name = "HBrightness";
            this.HBrightness.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HBrightness.Size = new System.Drawing.Size(378, 21);
            this.HBrightness.TabIndex = 44;
            this.HBrightness.TabStop = true;
            // 
            // Line3
            // 
            this.Line3.BackColor = System.Drawing.SystemColors.WindowText;
            this.Line3.Location = new System.Drawing.Point(12, 212);
            this.Line3.Name = "Line3";
            this.Line3.Size = new System.Drawing.Size(370, 1);
            this.Line3.TabIndex = 65;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label9.Location = new System.Drawing.Point(114, 218);
            this.Label9.Name = "Label9";
            this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label9.Size = new System.Drawing.Size(163, 13);
            this.Label9.TabIndex = 58;
            this.Label9.Text = "Some image filters / effects";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label8.Location = new System.Drawing.Point(118, 26);
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label8.Size = new System.Drawing.Size(158, 13);
            this.Label8.TabIndex = 57;
            this.Label8.Text = "Basic device configuration";
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.SystemColors.WindowText;
            this.Line1.Location = new System.Drawing.Point(12, 20);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(370, 1);
            this.Line1.TabIndex = 66;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label7.Location = new System.Drawing.Point(362, 149);
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label7.Size = new System.Drawing.Size(35, 13);
            this.Label7.TabIndex = 53;
            this.Label7.Text = "1000";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label6.Location = new System.Drawing.Point(8, 154);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label6.Size = new System.Drawing.Size(39, 13);
            this.Label6.TabIndex = 52;
            this.Label6.Text = "-1000";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label5.Location = new System.Drawing.Point(192, 155);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label5.Size = new System.Drawing.Size(14, 13);
            this.Label5.TabIndex = 51;
            this.Label5.Text = "0";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label4.Location = new System.Drawing.Point(8, 114);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label4.Size = new System.Drawing.Size(54, 13);
            this.Label4.TabIndex = 50;
            this.Label4.Text = "Contrast";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label3.Location = new System.Drawing.Point(362, 79);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(35, 13);
            this.Label3.TabIndex = 48;
            this.Label3.Text = "1000";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(8, 79);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(39, 13);
            this.Label2.TabIndex = 47;
            this.Label2.Text = "-1000";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(192, 79);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(14, 13);
            this.Label1.TabIndex = 46;
            this.Label1.Text = "0";
            // 
            // Brightness
            // 
            this.Brightness.AutoSize = true;
            this.Brightness.BackColor = System.Drawing.Color.Transparent;
            this.Brightness.Cursor = System.Windows.Forms.Cursors.Default;
            this.Brightness.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brightness.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Brightness.Location = new System.Drawing.Point(8, 39);
            this.Brightness.Name = "Brightness";
            this.Brightness.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Brightness.Size = new System.Drawing.Size(66, 13);
            this.Brightness.TabIndex = 45;
            this.Brightness.Text = "Brightness";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(450, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 385);
            this.panel1.TabIndex = 15;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(127, 381);
            this.listBox1.TabIndex = 0;
            // 
            // btnScanners
            // 
            this.btnScanners.BackColor = System.Drawing.Color.Transparent;
            this.btnScanners.BackgroundImage = global::OCRVoteExtractor.Properties.Resources._5895d3becba9841eabab6082;
            this.btnScanners.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScanners.FlatAppearance.BorderSize = 0;
            this.btnScanners.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScanners.Location = new System.Drawing.Point(8, 359);
            this.btnScanners.Margin = new System.Windows.Forms.Padding(2);
            this.btnScanners.Name = "btnScanners";
            this.btnScanners.Size = new System.Drawing.Size(109, 42);
            this.btnScanners.TabIndex = 14;
            this.btnScanners.Text = "Escanear";
            this.btnScanners.UseVisualStyleBackColor = false;
            this.btnScanners.Click += new System.EventHandler(this.btnScanners_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(616, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 385);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::OCRVoteExtractor.Properties.Resources._5895d3becba9841eabab6082;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(121, 359);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 42);
            this.button2.TabIndex = 12;
            this.button2.Text = "Template";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::OCRVoteExtractor.Properties.Resources._5895d3becba9841eabab6082;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(236, 359);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 42);
            this.button1.TabIndex = 11;
            this.button1.Text = "Cuadros";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 467);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.CheckBox chkRemoveBlankPages;
        public System.Windows.Forms.CheckBox chkRemoveDots;
        public System.Windows.Forms.CheckBox chkAutoDesk;
        public System.Windows.Forms.CheckBox chkRotate180;
        public System.Windows.Forms.CheckBox chkRotate90;
        public System.Windows.Forms.CheckBox chkIndicator;
        public System.Windows.Forms.CheckBox chkHideUI;
        public System.Windows.Forms.CheckBox ChkAutoCrop;
        public System.Windows.Forms.CheckBox ChkNeg;
        public System.Windows.Forms.CheckBox chkDuplex;
        public System.Windows.Forms.CheckBox chkAutoBrightness;
        public System.Windows.Forms.HScrollBar HContrast;
        public System.Windows.Forms.HScrollBar HBrightness;
        public System.Windows.Forms.Label Line3;
        public System.Windows.Forms.Label Label9;
        public System.Windows.Forms.Label Label8;
        public System.Windows.Forms.Label Line1;
        public System.Windows.Forms.Label Label7;
        public System.Windows.Forms.Label Label6;
        public System.Windows.Forms.Label Label5;
        public System.Windows.Forms.Label Label4;
        public System.Windows.Forms.Label Label3;
        public System.Windows.Forms.Label Label2;
        public System.Windows.Forms.Label Label1;
        public System.Windows.Forms.Label Brightness;
    }
}

