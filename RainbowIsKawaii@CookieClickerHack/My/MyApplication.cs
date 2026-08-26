// Decompiled with JetBrains decompiler
// Type: CookieClicker_Hack2017.My.MyApplication
// Assembly: CookieClicker_Hack2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B73F46C-B45D-4F1F-8EA2-FFEC6388E296
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\BadJoke\RainbowIsKawaii@CookieClickerHack\RainbowIsKawaii@CookieClickerHack.exe

using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace CookieClicker_Hack2017.My;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class MyApplication : WindowsFormsApplicationBase
{
  [STAThread]
  [DebuggerHidden]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
  internal static void Main(string[] Args)
  {
    try
    {
      Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
    }
    finally
    {
    }
    MyProject.Application.Run(Args);
  }

  [DebuggerStepThrough]
  public MyApplication()
    : base(AuthenticationMode.Windows)
  {
    this.IsSingleInstance = false;
    this.EnableVisualStyles = true;
    this.SaveMySettingsOnExit = true;
    this.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
  }

  [DebuggerStepThrough]
  protected override void OnCreateMainForm() => this.MainForm = (Form) MyProject.Forms.Form1;
}
