// Decompiled with JetBrains decompiler
// Type: A.
// Assembly: InfiniteBlue, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 75787C59-6E69-48EC-8991-CFBDA71A3167
// Assembly location: C:\Users\adriel\Downloads\InfiniteBlue.exe

using System;
using System.Drawing;

#nullable disable
namespace A;

internal sealed class \u0010 : \u000B
{
  private IntPtr \u001D;
  private Bitmap \u001D;
  private new int \u001D = \u001D\u0012.\u001D(216);
  private new int \u0012;
  private int \u0010;
  private double \u001D;

  public \u0010()
  {
    this.\u001D = new Bitmap((Image) \u0006.image, new Size(\u000B.\u001D / \u001D\u0012.\u001D(220), \u000B.\u0012 / \u001D\u0012.\u001D(224 /*0xE0*/)));
    this.\u001D = this.\u001D.GetHbitmap();
  }

  protected override void \u001D(IntPtr _param1) => \u0005\u0012.\u001D(this, _param1);
}
