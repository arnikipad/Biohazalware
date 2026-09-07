using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Media.Imaging;

namespace UACMockup {
    public partial class WallpaperOverlayWindow : Window {
        private const int SPI_GETDESKWALLPAPER = 0x0073;
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern bool SystemParametersInfo(int uAction, int uParam, StringBuilder pvParam, int fWinIni);

        public WallpaperOverlayWindow(string wallpaperPath) {
            InitializeComponent();

            // Window defaults are set in XAML; we'll position/size externally.

            try {
                if (!string.IsNullOrEmpty(wallpaperPath) && File.Exists(wallpaperPath)) {
                    var bi = new BitmapImage();
                    bi.BeginInit();
                    bi.CacheOption = BitmapCacheOption.OnLoad;
                    bi.UriSource = new Uri(wallpaperPath);
                    bi.EndInit();
                    WallpaperImage.Source = bi;
                }
            } catch {
                // ignore failures — leave blank
            }
        }

        public static string? GetCurrentWallpaperPath() {
            try {
                var sb = new StringBuilder(260);
                if (SystemParametersInfo(SPI_GETDESKWALLPAPER, sb.Capacity, sb, 0)) {
                    var path = sb.ToString();
                    if (!string.IsNullOrEmpty(path)) return path;
                }
            } catch { }
            return null;
        }
    }
}
