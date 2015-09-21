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
            this.grpRescan.SuspendLayout();
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
            this.systray.Text = "notifyIcon1";
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
            this.btnCancel.Location = new System.Drawing.Point(172, 162);
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
            this.btnOk.Location = new System.Drawing.Point(91, 162);
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
            this.grpRescan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRescan.Controls.Add(this.lblRescan);
            this.grpRescan.Controls.Add(this.btnRescan);
            this.grpRescan.Location = new System.Drawing.Point(12, 39);
            this.grpRescan.Name = "grpRescan";
            this.grpRescan.Size = new System.Drawing.Size(235, 94);
            this.grpRescan.TabIndex = 5;
            this.grpRescan.TabStop = false;
            this.grpRescan.Text = "Rescan";
            // 
            // lblRescan
            // 
            this.lblRescan.AutoSize = true;
            this.lblRescan.Location = new System.Drawing.Point(6, 16);
            this.lblRescan.MaximumSize = new System.Drawing.Size(215, 0);
            this.lblRescan.Name = "lblRescan";
            this.lblRescan.Size = new System.Drawing.Size(213, 39);
            this.lblRescan.TabIndex = 0;
            this.lblRescan.Text = "Scan the \"wallpapers\" folder for new files and subfolders if you have added new c" +
    "ontent after launching Wallpaper Changer.";
            // 
            // Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 197);
            this.Controls.Add(this.grpRescan);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblWallpaperStyle);
            this.Controls.Add(this.cbxWallpaperStyle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(265, 225);
            this.Name = "Preferences";
            this.Text = "Wallpaper Changer";
            this.Resize += new System.EventHandler(this.Preferences_Resize);
            this.grpRescan.ResumeLayout(false);
            this.grpRescan.PerformLayout();
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



    }
}

