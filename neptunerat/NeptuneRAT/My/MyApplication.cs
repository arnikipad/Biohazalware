// Decompiled with JetBrains decompiler
// Type: NeptuneRAT.My.MyApplication
// Assembly: NeptuneRAT Free Version V2, Version=2.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 48C579C5-C5A1-4244-9537-C19C9217B961
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\Tools\NeptuneRAT\NeptuneRAT.7z\neptunerat.exe

using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace NeptuneRAT.My;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class MyApplication : WindowsFormsApplicationBase
{
  [STAThread]
  [DebuggerHidden]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
  internal static void \u2694️MasonRAT\u270Cڠ\u060Aڠـٸ\u060Aڞٺـىحٺ(string[] Args)
  {
    try
    {
      Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
    }
    finally
    {
    }
    MyProject.\u2694️MasonRAT\u270Cبڠ\u060A\u0608ٺـﻋٸ\u060Dۡ\u060Eـٺٻ̨ۨٺـ\u060F\u0608.Run(Args);
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
  protected override void OnCreateMainForm()
  {
    this.MainForm = (Form) MyProject.\u2694️MasonRAT\u270C\u060Dطڞڛ\u060F\u060Dټـٽټ\u060Bطـﻋۨ\u060Dﻼ.Port;
  }

  [DebuggerStepThrough]
  protected override bool OnInitialize(ReadOnlyCollection<string> commandLineArgs)
  {
    this.MinimumSplashScreenDisplayTime = 0;
    return base.OnInitialize(commandLineArgs);
  }
}
