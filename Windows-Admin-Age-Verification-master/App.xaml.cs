using System.Windows;
using System.Collections.Generic;
using System.Windows.Interop;
using System;
using System.Threading.Tasks;
using OpenCvSharp;

namespace WindowsAdminAgeCheck
{
	public partial class App : System.Windows.Application
	{
		protected override void OnStartup(StartupEventArgs e)
		{
			// Preload OpenCV native libraries on a background thread to avoid
			// blocking the first camera open call later.
			Task.Run(() => {
				try { var v = OpenCvSharp.Cv2.GetVersionString(); } catch { }
			});

			// Create wallpaper overlay windows for all screens and show them
			// behind our app windows for the lifetime of the application.
			CreateWallpaperOverlays();

			base.OnStartup(e);
			SetThemeAccordingToOS();
			Microsoft.Win32.SystemEvents.UserPreferenceChanged += SystemEvents_UserPreferenceChanged;

			// If started with --verified, open MainWindow in verified state.
			bool startVerified = false;
			if (e.Args != null)
			{
				foreach (var a in e.Args)
				{
					if (a == "--verified")
					{
						startVerified = true;
						break;
					}
				}
			}

			var main = new global::UACMockup.MainWindow();
			main.Show();
			if (startVerified)
			{
				try { main.UnlockYesButton(false); } catch { }
			}
		}

		private List<System.Windows.Window> wallpaperOverlays = new List<System.Windows.Window>();
		private HashSet<System.Windows.Window> trackedWindows = new HashSet<System.Windows.Window>();

		private void CreateWallpaperOverlays() {
			try {
				string? wallpaper = UACMockup.WallpaperOverlayWindow.GetCurrentWallpaperPath();
				foreach (var s in System.Windows.Forms.Screen.AllScreens) {
					var overlay = new UACMockup.WallpaperOverlayWindow(wallpaper ?? string.Empty);
					overlay.WindowStartupLocation = WindowStartupLocation.Manual;
					overlay.Left = s.Bounds.Left;
					overlay.Top = s.Bounds.Top;
					overlay.Width = s.Bounds.Width;
					overlay.Height = s.Bounds.Height;
					overlay.ShowInTaskbar = false;
					overlay.ShowActivated = false;
					// Keep the overlay topmost so it stays above the desktop background
					// but we'll explicitly bring tracked app windows above it.
					overlay.Topmost = true;
					overlay.ResizeMode = ResizeMode.NoResize;
					overlay.WindowStyle = WindowStyle.None;
					overlay.Focusable = false;
					// start hidden; overlays will be shown when app windows register
					overlay.Hide();
					// send to back so our topmost dialogs remain above it
					var hwnd = new WindowInteropHelper(overlay).Handle;
					if (hwnd != IntPtr.Zero) {
						// no-op for now; overlay is a normal window and will sit above desktop
					}
					wallpaperOverlays.Add(overlay);
				}
			} catch { }
		}

		public void RegisterWindow(System.Windows.Window w) {
			if (w == null) return;
			// ignore overlays themselves
			if (w.GetType().FullName == "UACMockup.WallpaperOverlayWindow") return;
			trackedWindows.Add(w);
			w.Closed += (s, e) => UnregisterWindow(w);
			UpdateOverlaysVisibility();
		}

		public void UnregisterWindow(System.Windows.Window w) {
			if (w == null) return;
			if (trackedWindows.Contains(w)) trackedWindows.Remove(w);
			UpdateOverlaysVisibility();
		}

		private void UpdateOverlaysVisibility() {
			try {
				if (trackedWindows.Count > 0) {
					// Show overlays first and mark them topmost (so they are above the desktop)
					foreach (var ov in wallpaperOverlays) {
						try { ov.Show(); ov.Topmost = true; } catch { }
					}
					// Then ensure each tracked app window is topmost and activated so
					// it appears above the overlay.
					foreach (var w in trackedWindows) {
						try { w.Topmost = true; w.Activate(); } catch { }
					}
				} else {
					foreach (var ov in wallpaperOverlays) {
						try { ov.Close(); } catch { }
					}
					wallpaperOverlays.Clear();
				}
			} catch { }
		}

		protected override void OnExit(ExitEventArgs e) {
			try {
				foreach (var w in wallpaperOverlays) {
					try { w.Close(); } catch { }
				}
			} catch { }
			base.OnExit(e);
		}

		private void SystemEvents_UserPreferenceChanged(object sender, Microsoft.Win32.UserPreferenceChangedEventArgs e)
		{
			if (e.Category == Microsoft.Win32.UserPreferenceCategory.General)
			{
				SetThemeAccordingToOS();
			}
		}

		private void SetThemeAccordingToOS()
		{
			bool isDark = IsDarkTheme();
			var dicts = Resources.MergedDictionaries;
			string darkThemePath = "Themes/DarkTheme.xaml";
			string lightThemePath = "Themes/LightTheme.xaml";
			ResourceDictionary? darkDict = null;
			ResourceDictionary? lightDict = null;
			foreach (var d in dicts)
			{
				if (d.Source != null && d.Source.OriginalString.EndsWith("DarkTheme.xaml")) darkDict = d;
				if (d.Source != null && d.Source.OriginalString.EndsWith("LightTheme.xaml")) lightDict = d;
			}
			if (isDark)
			{
				if (lightDict != null) dicts.Remove(lightDict);
				if (darkDict == null)
					dicts.Add(new ResourceDictionary { Source = new Uri(darkThemePath, UriKind.Relative) });
			}
			else
			{
				if (darkDict != null) dicts.Remove(darkDict);
				if (lightDict == null)
					dicts.Add(new ResourceDictionary { Source = new Uri(lightThemePath, UriKind.Relative) });
			}
		}

		private static bool IsDarkTheme()
		{
			try
			{
				var key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(
					"Software\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize");
				if (key != null)
				{
					var value = key.GetValue("AppsUseLightTheme");
					if (value != null && value is int intValue)
						return intValue == 0;
				}
			}
			catch { }
			return false;
		}
	}
}

