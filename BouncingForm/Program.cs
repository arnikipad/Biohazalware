// Decompiled with JetBrains decompiler
// Type: BouncingForm.Program
// Assembly: BouncingForm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 70EF9BDA-F99B-498E-AD3F-2E6BE04A9BA7
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\BadJoke\BouncingForm\BouncingForm.exe

using System;
using System.Windows.Forms;

#nullable disable
namespace BouncingForm;

internal static class Program
{
  [STAThread]
  private static void Main()
  {
    Application.EnableVisualStyles();
    Application.SetCompatibleTextRenderingDefault(false);
    Application.Run((Form) new Form1());
  }
}
