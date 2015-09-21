using System;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Management;
using System.IO;
using System.Collections.Generic;

namespace WallpaperChanger
{
    public partial class Preferences : Form
    {
        String[] wallpapers;
        String currentProcess;
        String wallpaperStyle;
        Dictionary<String, String> wallpaperStyles;

        public Preferences()
        {
            InitializeComponent();

            wallpaperStyles = new Dictionary<String, String>();
            wallpaperStyles.Add("Fill", "10");
            wallpaperStyles.Add("Fit", "6");
            wallpaperStyles.Add("Stretch", "2");
            wallpaperStyles.Add("Tile", "0");
            wallpaperStyles.Add("Center", "0");

            cbxWallpaperStyle.Text = Properties.Settings.Default.wallpaperStyle;
            wallpaperStyle = cbxWallpaperStyle.Text;

            scanWallpapers();

            ManagementEventWatcher startWatch = new ManagementEventWatcher(new WqlEventQuery("SELECT * FROM Win32_ProcessStartTrace"));
            startWatch.EventArrived += new EventArrivedEventHandler(startWatch_EventArrived);
            startWatch.Start();

            ManagementEventWatcher stopWatch = new ManagementEventWatcher(new WqlEventQuery("SELECT * FROM Win32_ProcessStopTrace"));
            stopWatch.EventArrived += new EventArrivedEventHandler(stopWatch_EventArrived);
            stopWatch.Start();
        }

        private void scanWallpapers()
        {
            wallpapers = Directory.GetFiles(@"wallpapers\", "*.jpg").Concat(Directory.GetDirectories(@"wallpapers\")).ToArray();
        }

        void stopWatch_EventArrived(object sender, EventArrivedEventArgs e)
        {
            if (e.NewEvent.Properties["ProcessName"].Value.ToString() == currentProcess && wallpapers.Contains(@"wallpapers\default.jpg"))
            {
                currentProcess = "";
                setWallpaper(@"wallpapers\default.jpg");
            }
        }

        void startWatch_EventArrived(object sender, EventArrivedEventArgs e)
        {
            String process = e.NewEvent.Properties["ProcessName"].Value.ToString();
            if (wallpapers.Contains(@"wallpapers\" + process + ".jpg"))
            {
                currentProcess = process;
                setWallpaper(@"wallpapers\" + process + ".jpg");
            }
            else if (wallpapers.Contains(@"wallpapers\" + process))
            {
                String[] subpapers = Directory.GetFiles(@"wallpapers\" + process, "*.jpg");
                if (subpapers.Count() > 0)
                {
                    currentProcess = process;
                    setWallpaper(subpapers[new Random().Next(subpapers.Count())]);
                }
                
            }
        }

        private void setWallpaper(String path)
        {
            Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "WallpaperStyle", wallpaperStyles[wallpaperStyle]);
            if (wallpaperStyle == "Tile")
            {
                Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "TileWallpaper", "1");
            }
            else
            {
                Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "TileWallpaper", "0");
            }
            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, Path.GetFullPath(path), SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
        }

        private void EnableActiveDesktop()
        {
            IntPtr result = IntPtr.Zero;
            // enable active desktop
            SendMessageTimeout(FindWindow("Progman", IntPtr.Zero), 0x52c, IntPtr.Zero, IntPtr.Zero, 0, 500, out result);


        }


        private void btnRescan_Click(object sender, EventArgs e)
        {
            scanWallpapers();
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            wallpaperStyle = cbxWallpaperStyle.Text;
            Properties.Settings.Default.wallpaperStyle = cbxWallpaperStyle.Text;
            Properties.Settings.Default.Save();
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            cbxWallpaperStyle.Text = wallpaperStyle;
            this.WindowState = FormWindowState.Minimized;
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




        const int SPI_SETDESKWALLPAPER = 20;
        const int SPIF_UPDATEINIFILE = 0x01;
        const int SPIF_SENDWININICHANGE = 0x02;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessageTimeout(
            IntPtr hWnd,      // handle to destination window
            uint Msg,       // message
            IntPtr wParam,  // first message parameter
            IntPtr lParam,   // second message parameter
            uint fuFlags, uint uTimeout, out IntPtr result);

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, IntPtr ZeroOnly);
    }
}
