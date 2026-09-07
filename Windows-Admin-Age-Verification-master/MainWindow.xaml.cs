using System.Windows;
using System.Windows.Media;

namespace UACMockup {
    public partial class MainWindow : Window {
        public TerminalIconHelper TerminalIcon { get; } = new TerminalIconHelper();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            TerminalIcon = new TerminalIconHelper();
            // Register this window so overlays show while it's open
            try { ((WindowsAdminAgeCheck.App)System.Windows.Application.Current).RegisterWindow(this); } catch { }
        }

        private void Window_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Escape) Close();
        }

        private void TopBar_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ButtonState == System.Windows.Input.MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void ShowDetailsButton_Click(object sender, RoutedEventArgs e)
        {
            if (DetailsPanel.Visibility == Visibility.Visible)
            {
                DetailsPanel.Visibility = Visibility.Collapsed;
                ShowDetailsButton.Content = "Show more details";
            }
            else
            {
                DetailsPanel.Visibility = Visibility.Visible;
                ShowDetailsButton.Content = "Hide details";
            }
        }

        private void StartScan_Click(object sender, RoutedEventArgs e) {
            ScanWindow scanWin = new ScanWindow();
            scanWin.Show();
            Close();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e) {
            Close();
        }

        public void UnlockYesButton(bool showRemember = true) {
            YesButton.Content = "Yes";
            YesButton.IsEnabled = true;
            VerificationStatusText.Text = "Identity successfully verified.";
            VerificationInstructionsText.Text = "You may now proceed with the action.";
            VerificationStatusText.Foreground = (System.Windows.Media.Brush)FindResource("VerificationMarkBrush");
            ScanButtonCanvas.Visibility = Visibility.Collapsed;
            ScanLine.Visibility = Visibility.Collapsed;
            VerificationMark.Visibility = Visibility.Visible;
            RememberPanel.Visibility = showRemember ? Visibility.Visible : Visibility.Collapsed;
        }
    }
}