namespace WallpaperChanger
{
    partial class Preferences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preferences));
            this.cbxWallpaperStyle = new System.Windows.Forms.ComboBox();
            this.systray = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblWallpaperStyle = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnRescan = new System.Windows.Forms.Button();
            this.grpRescan = new System.Windows.Forms.GroupBox();
            this.lblRescan = new System.Windows.Forms.Label();
            this.chkRotate = new System.Windows.Forms.CheckBox();
            this.lblRotate = new System.Windows.Forms.Label();
            this.numRotate = new System.Windows.Forms.NumericUpDown();
            this.cbxRotate = new System.Windows.Forms.ComboBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.chkStartup = new System.Windows.Forms.CheckBox();
            this.chkMinimized = new System.Windows.Forms.CheckBox();
            this.grpRescan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRotate)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxWallpaperStyle
            // 
            this.cbxWallpaperStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxWallpaperStyle.FormattingEnabled = true;
            this.cbxWallpaperStyle.Items.AddRange(new object[] {
            "Fill",
            "Fit",
            "Stretch",
            "Tile",
            "Center"});
            this.cbxWallpaperStyle.Location = new System.Drawing.Point(99, 12);
            this.cbxWallpaperStyle.Name = "cbxWallpaperStyle";
            this.cbxWallpaperStyle.Size = new System.Drawing.Size(121, 21);
            this.cbxWallpaperStyle.TabIndex = 0;
            // 
            // systray
            // 
            this.systray.BalloonTipText = "Wallpaper Changer";
            this.systray.BalloonTipTitle = "WC";
            this.systray.Icon = ((System.Drawing.Icon)(resources.GetObject("systray.Icon")));
            this.systray.Text = "Wallpaper Changer";
            this.systray.Visible = true;
            this.systray.DoubleClick += new System.EventHandler(this.systray_DoubleClick);
            // 
            // lblWallpaperStyle
            // 
            this.lblWallpaperStyle.AutoSize = true;
            this.lblWallpaperStyle.Location = new System.Drawing.Point(12, 15);
            this.lblWallpaperStyle.Name = "lblWallpaperStyle";
            this.lblWallpaperStyle.Size = new System.Drawing.Size(81, 13);
            this.lblWallpaperStyle.TabIndex = 1;
            this.lblWallpaperStyle.Text = "Wallpaper Style";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(96, 263);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(15, 263);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnRescan
            // 
            this.btnRescan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRescan.Location = new System.Drawing.Point(9, 65);
            this.btnRescan.Name = "btnRescan";
            this.btnRescan.Size = new System.Drawing.Size(75, 23);
            this.btnRescan.TabIndex = 4;
            this.btnRescan.Text = "Rescan";
            this.btnRescan.UseVisualStyleBackColor = true;
            this.btnRescan.Click += new System.EventHandler(this.btnRescan_Click);
            // 
            // grpRescan
            // 
            this.grpRescan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRescan.Controls.Add(this.lblRescan);
            this.grpRescan.Controls.Add(this.btnRescan);
            this.grpRescan.Location = new System.Drawing.Point(12, 149);
            this.grpRescan.Name = "grpRescan";
            this.grpRescan.Size = new System.Drawing.Size(240, 94);
            this.grpRescan.TabIndex = 5;
            this.grpRescan.TabStop = false;
            this.grpRescan.Text = "Rescan";
            // 
            // lblRescan
            // 
            this.lblRescan.AutoSize = true;
            this.lblRescan.Location = new System.Drawing.Point(6, 16);
            this.lblRescan.MaximumSize = new System.Drawing.Size(240, 0);
            this.lblRescan.Name = "lblRescan";
            this.lblRescan.Size = new System.Drawing.Size(232, 39);
            this.lblRescan.TabIndex = 0;
            this.lblRescan.Text = "Scan the \"wallpapers\" folder for new files and subfolders if you have added new c" +
    "ontent after launching Wallpaper Changer.";
            // 
            // chkRotate
            // 
            this.chkRotate.AutoSize = true;
            this.chkRotate.Location = new System.Drawing.Point(12, 39);
            this.chkRotate.Name = "chkRotate";
            this.chkRotate.Size = new System.Drawing.Size(114, 17);
            this.chkRotate.TabIndex = 7;
            this.chkRotate.Text = "Rotate Wallpapers";
            this.chkRotate.UseVisualStyleBackColor = true;
            // 
            // lblRotate
            // 
            this.lblRotate.AutoSize = true;
            this.lblRotate.Location = new System.Drawing.Point(18, 64);
            this.lblRotate.Name = "lblRotate";
            this.lblRotate.Size = new System.Drawing.Size(37, 13);
            this.lblRotate.TabIndex = 8;
            this.lblRotate.Text = "Every:";
            // 
            // numRotate
            // 
            this.numRotate.Location = new System.Drawing.Point(61, 62);
            this.numRotate.Name = "numRotate";
            this.numRotate.Size = new System.Drawing.Size(50, 20);
            this.numRotate.TabIndex = 9;
            this.numRotate.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // cbxRotate
            // 
            this.cbxRotate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRotate.FormattingEnabled = true;
            this.cbxRotate.Items.AddRange(new object[] {
            "Hours",
            "Minutes",
            "Seconds"});
            this.cbxRotate.Location = new System.Drawing.Point(117, 61);
            this.cbxRotate.Name = "cbxRotate";
            this.cbxRotate.Size = new System.Drawing.Size(103, 21);
            this.cbxRotate.TabIndex = 10;
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Location = new System.Drawing.Point(177, 263);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 11;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // chkStartup
            // 
            this.chkStartup.AutoSize = true;
            this.chkStartup.Location = new System.Drawing.Point(12, 88);
            this.chkStartup.Name = "chkStartup";
            this.chkStartup.Size = new System.Drawing.Size(145, 17);
            this.chkStartup.TabIndex = 13;
            this.chkStartup.Text = "Run on Windows Startup";
            this.chkStartup.UseVisualStyleBackColor = true;
            // 
            // chkMinimized
            // 
            this.chkMinimized.AutoSize = true;
            this.chkMinimized.Location = new System.Drawing.Point(12, 111);
            this.chkMinimized.Name = "chkMinimized";
            this.chkMinimized.Size = new System.Drawing.Size(97, 17);
            this.chkMinimized.TabIndex = 14;
            this.chkMinimized.Text = "Start Minimized";
            this.chkMinimized.UseVisualStyleBackColor = true;
            // 
            // Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 298);
            this.Controls.Add(this.chkMinimized);
            this.Controls.Add(this.chkStartup);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.cbxRotate);
            this.Controls.Add(this.numRotate);
            this.Controls.Add(this.lblRotate);
            this.Controls.Add(this.chkRotate);
            this.Controls.Add(this.grpRescan);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblWallpaperStyle);
            this.Controls.Add(this.cbxWallpaperStyle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(270, 275);
            this.Name = "Preferences";
            this.Text = "Wallpaper Changer";
            this.Resize += new System.EventHandler(this.Preferences_Resize);
            this.grpRescan.ResumeLayout(false);
            this.grpRescan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRotate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxWallpaperStyle;
        private System.Windows.Forms.NotifyIcon systray;
        private System.Windows.Forms.Label lblWallpaperStyle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnRescan;
        private System.Windows.Forms.GroupBox grpRescan;
        private System.Windows.Forms.Label lblRescan;
        private System.Windows.Forms.CheckBox chkRotate;
        private System.Windows.Forms.Label lblRotate;
        private System.Windows.Forms.NumericUpDown numRotate;
        private System.Windows.Forms.ComboBox cbxRotate;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.CheckBox chkStartup;
        private System.Windows.Forms.CheckBox chkMinimized;



    }
}

