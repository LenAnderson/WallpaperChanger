using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Management;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Threading;

namespace WallpaperChanger
{
    class WallpaperChanger
    {
        Dictionary<String, String[]> wallpapers;
        String currentProcess;
        Dictionary<String, String> wallpaperStyles;
        Thread rotate;


        public WallpaperChanger()
        {
            wallpaperStyles = new Dictionary<string, string>()
            {
                {"Fill", "10"}, {"Fit", "6"}, {"Stretch", "2"}, {"Tile", "0"}, {"Center", "0"}
                
                //{"Fill", Desktop.WallPaperStyle.WPSTYLE_CROPTOFIT},
                //{"Fit", Desktop.WallPaperStyle.WPSTYLE_KEEPASPECT},
                //{"Stretch", Desktop.WallPaperStyle.WPSTYLE_STRETCH},
                //{"Tile", Desktop.WallPaperStyle.WPSTYLE_TILE},
                //{"Center", Desktop.WallPaperStyle.WPSTYLE_CENTER}
            };

            ScanWallpapers();
            InitEventWatchers();
        }

        private void InitEventWatchers()
        {
            ManagementEventWatcher startWatch = new ManagementEventWatcher(new WqlEventQuery("SELECT * FROM Win32_ProcessStartTrace"));
            startWatch.EventArrived += new EventArrivedEventHandler(ProcessStarted);
            startWatch.Start();

            ManagementEventWatcher stopWatch = new ManagementEventWatcher(new WqlEventQuery("SELECT * FROM Win32_ProcessStopTrace"));
            stopWatch.EventArrived += new EventArrivedEventHandler(ProcessStopped);
            stopWatch.Start();
        }

        void ProcessStarted(object sender, EventArrivedEventArgs e)
        {
            String process = e.NewEvent.Properties["ProcessName"].Value.ToString();
            UpdateWallpaper(process);
        }

        void ProcessStopped(object sender, EventArrivedEventArgs e)
        {
            if (e.NewEvent.Properties["ProcessName"].Value.ToString() == currentProcess && wallpapers.Keys.Contains("default"))
            {
                if (rotate != null)
                {
                    rotate.Abort();
                    rotate = null;
                }
                currentProcess = "";
                UpdateWallpaper("default");
            }
        }


        public void UpdateWallpaper(String process)
        {
            String wallpaper = GetWallpaper(process);
            if (wallpaper != "")
            {
                currentProcess = process;
                SetWallpaper(wallpaper);
                if (Properties.Settings.Default.rotate && rotate == null && wallpapers[process].Count() > 1)
                {
                    ThreadStart threadStarter = () =>
                        {
                            while (true)
                            {
                                Thread.Sleep(GetRotateMillis());
                                UpdateWallpaper(process);
                            }
                        };
                    rotate = new Thread(threadStarter);
                    rotate.Start();
                }
            }
        }
        private int GetRotateMillis()
        {
            switch (Properties.Settings.Default.rotateUnit)
            {
                case "Hours":
                    return Properties.Settings.Default.rotateTime * 3600000;
                case "Minutes":
                    return Properties.Settings.Default.rotateTime * 60000;
                case "Seconds":
                    return Properties.Settings.Default.rotateTime * 1000;
            }
            return Properties.Settings.Default.rotateTime;
        }


        public void ScanWallpapers()
        {
            wallpapers = new Dictionary<String, String[]>();
            String[] files = Directory.GetFiles(@"wallpapers\").Where(s => s.EndsWith(".jpg") || s.EndsWith(".bmp") || s.EndsWith(".png") || s.EndsWith(".gif")).ToArray();
            foreach (String file in files)
            {
                Regex regex = new Regex(@"wallpapers\\(.+)\.[^\.]+$");
                wallpapers[regex.Replace(file, "$1")] = new String[]{file};
            }
            String[] dirs = Directory.GetDirectories(@"wallpapers\");
            foreach (String dir in dirs)
            {
                Regex regex = new Regex(@"wallpapers\\(.+)$");
                wallpapers[regex.Replace(dir, "$1")] = Directory.GetFiles(dir).Where(s => s.EndsWith(".jpg") || s.EndsWith(".bmp") || s.EndsWith(".png") || s.EndsWith(".gif")).ToArray();
            }
        }

        public String GetWallpaper(String process)
        {
            if (wallpapers.Keys.Contains(process))
            {
                if (wallpapers[process].Count() > 0)
                {
                    return wallpapers[process][new Random().Next(wallpapers[process].Count())];
                }
                else
                {
                    return "";
                }
            }
            else
            {
                return "";
            }
        }

        public void SetWallpaper(String path)
        {
            String style = Properties.Settings.Default.wallpaperStyle;
            Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "WallpaperStyle", wallpaperStyles[style]);
            if (style == "Tile")
            {
                Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "TileWallpaper", "1");
            }
            else
            {
                Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "TileWallpaper", "0");
            }
            SetWallpaperAD(path);
            //SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, Path.GetFullPath(path), SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
        }

        public void SetWallpaperAD(String path)
        {
            Desktop.EnableActiveDesktop();
            ThreadStart threadStarter = () =>
                {
                    Desktop.IActiveDesktop ad = Desktop.GetActiveDesktop();
                    ad.SetWallpaper(Path.GetFullPath(path), 0);
                    ad.ApplyChanges(Desktop.AD_Apply.ALL | Desktop.AD_Apply.FORCE);
                    Marshal.ReleaseComObject(ad);
                };
            Thread thread = new Thread(threadStarter);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join(2000);
            
        }





        const int SPI_SETDESKWALLPAPER = 20;
        const int SPIF_UPDATEINIFILE = 0x01;
        const int SPIF_SENDWININICHANGE = 0x02;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);
    }
}
