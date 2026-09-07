using System.IO;
using System.Windows.Media.Imaging;

namespace UACMockup
{
    public class TerminalIconHelper
    {
        public BitmapSource? Icon { get; }

        public TerminalIconHelper()
        {
            string exePath = @"C:\Program Files\WindowsApps\Microsoft.WindowsTerminal_1.23.20211.0_x64__8wekyb3d8bbwe\wt.exe";
            Icon = GetIcon(exePath);
        }

        private BitmapSource? GetIcon(string exePath)
        {
            try
            {
                var icon = System.Drawing.Icon.ExtractAssociatedIcon(exePath);
                if (icon != null)
                {
                    using (var bmp = icon.ToBitmap())
                    {
                        var ms = new MemoryStream();
                        bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        ms.Seek(0, SeekOrigin.Begin);
                        var bitmap = new BitmapImage();
                        bitmap.BeginInit();
                        bitmap.StreamSource = ms;
                        bitmap.CacheOption = BitmapCacheOption.OnLoad;
                        bitmap.EndInit();
                        return bitmap;
                    }
                }
            }
            catch { }
            return null;
        }
    }
}