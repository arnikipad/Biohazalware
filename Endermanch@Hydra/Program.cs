// Decompiled with JetBrains decompiler
// Type: Hydra.Program
// Assembly: Hydra, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FE967A65-D44D-4D25-B3F9-59D325AB8DF5
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\BadJoke\Endermanch@Hydra\Endermanch@Hydra.exe

using System;
using System.Windows.Forms;

#nullable disable
namespace Hydra;

internal class Program
{
  public static Random rand = new Random();
  public static short textLength = 5;
  private static byte _textInsanity = 0;
  private static byte textInsanity = 0;

  public static byte TextInsanity()
  {
    if (Program.textInsanity >= (byte) 5)
    {
      Program.textInsanity = (byte) 0;
      if (Program._textInsanity < (byte) 3)
        ++Program._textInsanity;
    }
    else
      ++Program.textInsanity;
    return Program._textInsanity;
  }

  private static void Main(string[] args)
  {
    Application.EnableVisualStyles();
    Application.SetCompatibleTextRenderingDefault(false);
    Application.Run((Form) new MsgBoxForm()
    {
      IsStartupForm = true
    });
  }
}
