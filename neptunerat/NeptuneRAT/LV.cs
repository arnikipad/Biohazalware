// Decompiled with JetBrains decompiler
// Type: NeptuneRAT.LV
// Assembly: NeptuneRAT Free Version V2, Version=2.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 48C579C5-C5A1-4244-9537-C19C9217B961
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\Tools\NeptuneRAT\NeptuneRAT.7z\neptunerat.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NeptuneRAT;

public class LV : ListView
{
  internal object \u2694️MasonRAT\u270Cؤۡب̍\u0020ۡٺ\u0608\u060D\u060Cــ\u060Aـگ;
  private ColumnHeader \u2694️MasonRAT\u270Cؤּټ\u060Aـۚ\u0609ـۜڟټ;

  public LV()
  {
    this.ColumnClick += new ColumnClickEventHandler(this.\u2694️MasonRAT\u270Cٸى\u0609ـ\u060Cټ̍ٽٸٸۡ\u060Bڙ\u0608);
    this.AllowDrop = false;
    this.Font = new Font(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3880), 8f, FontStyle.Bold);
    this.Dock = (DockStyle) ((-1860561810 - ~1860581702 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) - (((-80914379 ^ ~571135571) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) >> (1676245787 + ~60068619 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - -0 >> 0);
    this.FullRowSelect = true;
    this.View = View.Details;
    this.SetStyle((ControlStyles) ((-954859578 - 1395925961 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) - (-1787451665 - 613840114 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0 | (593345141 ^ 20) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 + 0) >> 0), true);
    this.SetStyle((ControlStyles) ((-215811770 ^ 10) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 + ((-565306502 ^ 1766444775 << 2116671425) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 >> 1) ^ 0), true);
  }

  public void \u2694️MasonRAT\u270Cۡٺ\u060F\u060Fؤٺ\u060Fـمڜـ\u0608\u060Aْـڙﯧ()
  {
    this.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
  }

  protected override void OnNotifyMessage(Message m)
  {
  }

  public void \u2694️MasonRAT\u270Cٸى\u0609ـ\u060Cټ̍ٽٸٸۡ\u060Bڙ\u0608(
    object sender,
    ColumnClickEventArgs e)
  {
    ColumnHeader columnHeader = (ColumnHeader) NewLateBinding.LateGet(sender, (System.Type) null, \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3881), new object[1]
    {
      (object) e.Column
    }, (string[]) null, (System.Type[]) null, (bool[]) null);
    SortOrder sort_order;
    if (this.\u2694️MasonRAT\u270Cؤּټ\u060Aـۚ\u0609ـۜڟټ == null)
    {
      sort_order = SortOrder.Ascending;
    }
    else
    {
      sort_order = !columnHeader.Equals((object) this.\u2694️MasonRAT\u270Cؤּټ\u060Aـۚ\u0609ـۜڟټ) ? SortOrder.Ascending : (!this.\u2694️MasonRAT\u270Cؤּټ\u060Aـۚ\u0609ـۜڟټ.Text.StartsWith(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3882)) ? SortOrder.Ascending : (SortOrder) ((624862520 - 1657075783 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) - -((-130670702 ^ ~978301820) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 << 1) + 0));
      this.\u2694️MasonRAT\u270Cؤּټ\u060Aـۚ\u0609ـۜڟټ.Text = this.\u2694️MasonRAT\u270Cؤּټ\u060Aـۚ\u0609ـۜڟټ.Text.Substring(1);
    }
    this.\u2694️MasonRAT\u270Cؤּټ\u060Aـۚ\u0609ـۜڟټ = columnHeader;
    this.\u2694️MasonRAT\u270Cؤּټ\u060Aـۚ\u0609ـۜڟټ.Text = sort_order != SortOrder.Ascending ? \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3884) + this.\u2694️MasonRAT\u270Cؤּټ\u060Aـۚ\u0609ـۜڟټ.Text : \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3883) + this.\u2694️MasonRAT\u270Cؤּټ\u060Aـۚ\u0609ـۜڟټ.Text;
    if (sender == null)
      return;
    NewLateBinding.LateSet(sender, (System.Type) null, \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3885), new object[1]
    {
      (object) new LV.clsListviewSorter(e.Column, sort_order)
    }, (string[]) null, (System.Type[]) null);
    NewLateBinding.LateCall(sender, (System.Type) null, \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3886), new object[0], (string[]) null, (System.Type[]) null, (bool[]) null, true);
    NewLateBinding.LateSet(sender, (System.Type) null, \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3887), new object[1], (string[]) null, (System.Type[]) null);
  }

  public class clsListviewSorter : IComparer
  {
    private int m_ColumnNumber;
    private SortOrder m_SortOrder;

    public clsListviewSorter(int column_number, SortOrder sort_order)
    {
      this.m_ColumnNumber = column_number;
      this.m_SortOrder = sort_order;
    }

    public int Compare(object x, object y)
    {
      ListViewItem listViewItem1 = (ListViewItem) x;
      ListViewItem listViewItem2 = (ListViewItem) y;
      string str1 = listViewItem1.SubItems.Count > this.m_ColumnNumber ? listViewItem1.SubItems[this.m_ColumnNumber].Text : \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3888);
      string str2 = listViewItem2.SubItems.Count > this.m_ColumnNumber ? listViewItem2.SubItems[this.m_ColumnNumber].Text : \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3889);
      if (this.m_SortOrder == SortOrder.Ascending)
      {
        if (Versioned.IsNumeric((object) str1) & Versioned.IsNumeric((object) str2))
          return Conversion.Val(str1).CompareTo(Conversion.Val(str2));
        return Information.IsDate((object) str1) & Information.IsDate((object) str2) ? DateTime.Parse(str1).CompareTo(DateTime.Parse(str2)) : string.Compare(str1, str2);
      }
      if (Versioned.IsNumeric((object) str1) & Versioned.IsNumeric((object) str2))
        return Conversion.Val(str2).CompareTo(Conversion.Val(str1));
      return Information.IsDate((object) str1) & Information.IsDate((object) str2) ? DateTime.Parse(str2).CompareTo(DateTime.Parse(str1)) : string.Compare(str2, str1);
    }
  }
}
