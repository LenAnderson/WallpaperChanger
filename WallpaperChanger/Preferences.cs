using System;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Management;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WallpaperChanger
{
    public partial class Preferences : Form
    {
        WallpaperChanger wc;


        public Preferences()
        {
            InitializeComponent();

            cbxWallpaperStyle.Text = Properties.Settings.Default.wallpaperStyle;
            chkRotate.Checked = Properties.Settings.Default.rotate;
            numRotate.Value = Properties.Settings.Default.rotateTime;
            cbxRotate.Text = Properties.Settings.Default.rotateUnit;
            chkStartup.Checked = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run", "WallpaperChanger", null) != null;
            chkMinimized.Checked = Properties.Settings.Default.minimized;

            wc = new WallpaperChanger();

            if (Properties.Settings.Default.minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }


        private void btnRescan_Click(object sender, EventArgs e)
        {
            wc.ScanWallpapers();
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Save();
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            cbxWallpaperStyle.Text = Properties.Settings.Default.wallpaperStyle;
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            this.Save();
        }


        private void Save()
        {
            Properties.Settings.Default.wallpaperStyle = cbxWallpaperStyle.Text;
            Properties.Settings.Default.rotate = chkRotate.Checked;
            Properties.Settings.Default.rotateTime = (int)numRotate.Value;
            Properties.Settings.Default.rotateUnit = cbxRotate.Text;
            if (chkStartup.Checked)
            {
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run", "WallpaperChanger", Path.GetFullPath(@"WallpaperChanger.exe"));
            }
            else
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true))
                {
                    if (key.GetValueNames().Contains("WallpaperChanger"))
                    {
                        key.DeleteValue("WallpaperChanger");
                    }
                }
            }
            Properties.Settings.Default.minimized = chkMinimized.Checked;
            Properties.Settings.Default.Save();
        }


        private void Preferences_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                this.Hide();
            }
        }

        private void systray_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }
    }
}
