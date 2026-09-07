using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using OC = OpenCvSharp;
using OpenCvSharp.WpfExtensions;

namespace UACMockup {
    public partial class ScanWindow : Window {
        DispatcherTimer timer = new DispatcherTimer();
        Random rand = new Random();
        // Camera capture
        OC.VideoCapture? capture = null;
        OC.Mat frame = new OC.Mat();
        DispatcherTimer cameraTimer = new DispatcherTimer();
        CancellationTokenSource? cameraOpenCts = null;
        const double CreditCardAspect = 85.6 / 53.98; // width / height (approx 1.586)

        enum DetectMode { None, ID, Face }
        DetectMode currentMode = DetectMode.None;
        bool isLoading = false;
        bool paused = false;
        bool idTextToggle = false;
        bool faceTextToggle = false;

        public ScanWindow() {
            InitializeComponent();
            timer.Interval = TimeSpan.FromMilliseconds(50);
            timer.Tick += Timer_Tick;
            // Do not start timer automatically; waits for numeric input

            cameraTimer.Interval = TimeSpan.FromMilliseconds(33); // ~30 FPS
            cameraTimer.Tick += CameraTimer_Tick;
            // Register this window so overlays show while it's open
            try { ((WindowsAdminAgeCheck.App)System.Windows.Application.Current).RegisterWindow(this); } catch { }
        }

        private void Window_Loaded(object? sender, RoutedEventArgs e) {
            Focus();
            Keyboard.Focus(this);
            ScanProgress.Value = 0;
            StatusLabel.Text = "Please hold your ID into the camera.";
            // Try to open the default camera asynchronously to avoid blocking UI startup
            StatusLabel.Text = "Starting camera...";
            cameraOpenCts = new CancellationTokenSource();
            var token = cameraOpenCts.Token;
            Task.Run(() => {
                OC.VideoCapture? localCap = null;
                var sw = Stopwatch.StartNew();
                try {
                    // Try DirectShow first (often faster on Windows), fall back to default
                    try {
                        localCap = new OC.VideoCapture(0, OC.VideoCaptureAPIs.DSHOW);
                    } catch { localCap = null; }

                    if (localCap == null || !localCap.IsOpened()) {
                        try { localCap = new OC.VideoCapture(0, OC.VideoCaptureAPIs.MSMF); } catch { localCap = null; }
                    }

                    if (localCap == null || !localCap.IsOpened()) {
                        try { localCap = new OC.VideoCapture(0); } catch { localCap = null; }
                    }
                } catch {
                    localCap = null;
                }

                if (token.IsCancellationRequested) {
                    try { localCap?.Release(); } catch { }
                    return;
                }

                var elapsed = sw.ElapsedMilliseconds;
                Debug.WriteLine($"VideoCapture open took {elapsed} ms");

                Dispatcher.Invoke(() => {
                    capture = localCap;
                    if (capture != null && capture.IsOpened()) {
                        capture.FrameWidth = 640;
                        capture.FrameHeight = 480;
                        cameraTimer.Start();
                        StatusLabel.Text = "Camera ready";

                        // After 3 seconds, revert the status text back to the original
                        // message, but only if it hasn't been changed by another action.
                        _ = Task.Run(async () => {
                            await Task.Delay(3000);
                            try {
                                Dispatcher.Invoke(() => {
                                    if (StatusLabel.Text == "Camera ready") {
                                        StatusLabel.Text = "Please hold your ID into the camera.";
                                    }
                                });
                            } catch { }
                        });
                    } else {
                        try { capture?.Release(); } catch { }
                        capture = null;
                        StatusLabel.Text = "No camera available";
                    }
                });
            }, token);

            // Ensure camera border uses credit-card aspect ratio
            try {
                CameraBorder.SizeChanged += CameraBorder_SizeChanged;
                // initial sizing
                CameraBorder_SizeChanged(CameraBorder, default);
            } catch { }
        }

        private void CameraBorder_SizeChanged(object? sender, SizeChangedEventArgs e) {
            try {
                double w = CameraBorder.ActualWidth;
                if (w <= 0) return;
                double desiredH = w / CreditCardAspect;
                // Optionally limit height so it doesn't grow too tall
                CameraBorder.Height = desiredH;
            } catch { }
        }

        private void CameraTimer_Tick(object? sender, EventArgs e) {
            if (capture == null || !capture.IsOpened()) return;
            try {
                if (!capture.Read(frame)) return;
                if (frame.Empty()) return;
                var bmp = frame.ToBitmapSource();
                bmp.Freeze();
                CameraImage.Source = bmp;
            } catch {
                // ignore frame errors
            }
        }

        private void Timer_Tick(object? sender, EventArgs e) {
            if (!isLoading || paused) return;

            if (ScanProgress.Value >= 100) {
                // Stop automatic progression — require explicit Proceed button press
                timer.Stop();
                isLoading = false;
                paused = false;
                return;
            }

            // Irregular increments: random chance to skip, random step size
            if (rand.NextDouble() < 0.15) return; // occasional skip

            double maxStep = currentMode == DetectMode.Face ? 3.5 : 2.5;
            double step = rand.NextDouble() * maxStep + 0.2;
            ScanProgress.Value = Math.Min(100, ScanProgress.Value + step);
        }

        private void Window_KeyDown(object? sender, System.Windows.Input.KeyEventArgs e) {
            if (e.Key == System.Windows.Input.Key.Escape) {
                Close();
                return;
            }
            // Accept both top-row numbers and numpad keys
            if (e.Key == Key.D1 || e.Key == Key.NumPad1) {
                currentMode = DetectMode.ID;
                isLoading = true;
                paused = false;
                idTextToggle = false;
                StatusLabel.Text = "ID detected. Please hold still...";
                if (!timer.IsEnabled) timer.Start();
            } else if (e.Key == Key.D2 || e.Key == Key.NumPad2) {
                if (currentMode == DetectMode.ID) {
                    idTextToggle = !idTextToggle;
                    StatusLabel.Text = idTextToggle ? "Keep holding still..." : "ID detected. Please hold still...";
                }
            } else if (e.Key == Key.D3 || e.Key == Key.NumPad3) {
                if (isLoading) {
                    paused = !paused; // toggle pause
                }
            } else if (e.Key == Key.D4 || e.Key == Key.NumPad4) {
                currentMode = DetectMode.Face;
                isLoading = true;
                paused = false;
                faceTextToggle = false;
                StatusLabel.Text = "Face detected. Please hold still...";
                if (!timer.IsEnabled) timer.Start();
            } else if (e.Key == Key.D5 || e.Key == Key.NumPad5) {
                if (currentMode == DetectMode.Face) {
                    faceTextToggle = !faceTextToggle;
                    StatusLabel.Text = faceTextToggle ? "Keep holding still..." : "Face detected. Please hold still...";
                }
            } else if (e.Key == Key.D6 || e.Key == Key.NumPad6) {
                // stop loading and set final check text
                ScanProgress.Value = 0;
                isLoading = false;
                paused = false;
                StatusLabel.Text = "Now hold your face into the camera for the final check.";
            } else if (e.Key == Key.D7 || e.Key == Key.NumPad7) {
                ScanProgress.Value = 0;
                isLoading = false;
                paused = false;
                currentMode = DetectMode.None;
                StatusLabel.Text = "No ID detected. Please hold your ID closely into the camera. Make sure to hold the ID still and to have proper lighting.";
            } else if (e.Key == Key.D8 || e.Key == Key.NumPad8) {
                ScanProgress.Value = 0;
                isLoading = false;
                paused = false;
                currentMode = DetectMode.None;
                StatusLabel.Text = "No face detected. Please hold your face closely into the camera. Make sure to hold your face still and to have proper lighting.";
            } else if (e.Key == Key.D9 || e.Key == Key.NumPad9) {
                ScanProgress.Value = 0;
                isLoading = false;
                paused = false;
                currentMode = DetectMode.None;
                StatusLabel.Text = "Generic error (0x7fffffff). Please contact your adminstrator or try again.";
            } else if (e.Key == Key.D0 || e.Key == Key.NumPad0) {
                StatusLabel.Text = "Detection successful. Click the button to proceed.";
                if (ActionButton != null) {
                    ActionButton.Content = "Proceed";
                    try {
                        ActionButton.Background = (System.Windows.Media.Brush)FindResource("AccentBrush");
                        ActionButton.Foreground = (System.Windows.Media.Brush)FindResource("AccentButtonForegroundBrush");
                    } catch { }
                }
            }
        }

        private void CloseButton_Click(object? sender, RoutedEventArgs e) {
            timer.Stop();
            cameraOpenCts?.Cancel();
            cameraTimer.Stop();
            if (capture != null) {
                try { capture.Release(); } catch { }
                capture = null;
            }
            try { frame.Dispose(); } catch { }
            Close();
        }

        private void TopBar_MouseLeftButtonDown(object? sender, MouseButtonEventArgs e) {
            if (e.ButtonState == MouseButtonState.Pressed) DragMove();
        }

        private void CancelButton_Click(object? sender, RoutedEventArgs e) {
            timer.Stop();
            cameraOpenCts?.Cancel();
            cameraTimer.Stop();
            if (capture != null) {
                try { capture.Release(); } catch { }
                capture = null;
            }
            try { frame.Dispose(); } catch { }
            if (ActionButton != null && ActionButton.Content is string s && s == "Proceed") {
                MainWindow unlockedWin = new MainWindow();
                unlockedWin.UnlockYesButton();
                unlockedWin.Show();
                Close();
                return;
            }

            MainWindow main = new MainWindow();
            main.Show();
            Close();
        }
    }
}