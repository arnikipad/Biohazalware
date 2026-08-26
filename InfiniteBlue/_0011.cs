// Decompiled with JetBrains decompiler
// Type: A.
// Assembly: InfiniteBlue, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 75787C59-6E69-48EC-8991-CFBDA71A3167
// Assembly location: C:\Users\adriel\Downloads\InfiniteBlue.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace A;

public sealed class \u0011 : Form
{
  private static int \u001D = \u001D\u0012.\u001D(1744);
  private int \u0012;
  private int \u0010;
  private bool \u001D;
  private static Random \u001D = new Random();
  private IContainer \u001D;
  private Label \u001D;
  private Label \u0012;
  private Label \u0010;
  private PictureBox \u001D;
  private Label \u000A;
  private Label \u001A;
  private Label \u000B;

  public \u0011(int _param1, int _param2)
  {
    this.\u0010 = _param1;
    this.\u0012 = _param2;
    this.\u001D();
    int width = \u001D\u0012.\u001D(1716);
    int height = \u001D\u0012.\u001D(1720);
    Screen[] allScreens = Screen.AllScreens;
    for (int index = \u001D\u0012.\u001D(1724); index < allScreens.Length; index += \u001D\u0012.\u001D(1728))
    {
      Screen screen = allScreens[index];
      width += screen.Bounds.Width;
      height += screen.Bounds.Height;
    }
    this.Bounds = new Rectangle(\u001D\u0012.\u001D(1732), \u001D\u0012.\u001D(1736), width, height);
    Control.CheckForIllegalCrossThreadCalls = \u001D\u0012.\u001D(1740) != 0;
    this.Activate();
  }

  protected override CreateParams CreateParams => \u0012\u0010.\u001D(this);

  private void \u001D(object _param1, EventArgs _param2)
  {
    \u0010\u0010.\u001D(this, _param1, _param2);
  }

  private void \u001D(object _param1, FormClosingEventArgs _param2)
  {
    \u000A\u0010.\u001D(this, _param1, _param2);
  }

  protected override void Dispose(bool disposing) => \u001A\u0010.\u001D(this, disposing);

  private void \u001D() => \u000B\u0010.\u001D(this);
}
