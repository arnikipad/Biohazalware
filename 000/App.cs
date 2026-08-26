// Decompiled with JetBrains decompiler
// Type: Creep.App
// Assembly: 000, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 13F43A77-4E8B-438F-A69A-882CC6C087E6
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\Trojan\000\000.exe

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Windows;

#nullable disable
namespace Creep;

public class App : Application
{
  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    this.StartupUri = new Uri("MainWindow.xaml", UriKind.Relative);
  }

  [STAThread]
  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public static void Main()
  {
    App app = new App();
    app.InitializeComponent();
    app.Run();
  }
}
