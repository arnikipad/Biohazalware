// Decompiled with JetBrains decompiler
// Type: CookieClicker_Hack2017.My.MyProject
// Assembly: CookieClicker_Hack2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B73F46C-B45D-4F1F-8EA2-FFEC6388E296
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\BadJoke\RainbowIsKawaii@CookieClickerHack\RainbowIsKawaii@CookieClickerHack.exe

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
namespace CookieClicker_Hack2017.My;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class MyProject
{
  private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();
  private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();
  private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();
  private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();
  private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

  [HelpKeyword("My.Computer")]
  internal static MyComputer Computer
  {
    [DebuggerHidden] get => MyProject.m_ComputerObjectProvider.GetInstance;
  }

  [HelpKeyword("My.Application")]
  internal static MyApplication Application
  {
    [DebuggerHidden] get => MyProject.m_AppObjectProvider.GetInstance;
  }

  [HelpKeyword("My.User")]
  internal static User User
  {
    [DebuggerHidden] get => MyProject.m_UserObjectProvider.GetInstance;
  }

  [HelpKeyword("My.Forms")]
  internal static MyProject.MyForms Forms
  {
    [DebuggerHidden] get => MyProject.m_MyFormsObjectProvider.GetInstance;
  }

  [HelpKeyword("My.WebServices")]
  internal static MyProject.MyWebServices WebServices
  {
    [DebuggerHidden] get => MyProject.m_MyWebServicesObjectProvider.GetInstance;
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  [MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
  internal sealed class MyForms
  {
    [ThreadStatic]
    private static Hashtable m_FormBeingCreated;
    [EditorBrowsable(EditorBrowsableState.Never)]
    public attacjstart5 m_attacjstart5;
    [EditorBrowsable(EditorBrowsableState.Never)]
    public attackstart m_attackstart;
    [EditorBrowsable(EditorBrowsableState.Never)]
    public attackstart1 m_attackstart1;
    [EditorBrowsable(EditorBrowsableState.Never)]
    public attackstart2 m_attackstart2;
    [EditorBrowsable(EditorBrowsableState.Never)]
    public attackstart3 m_attackstart3;
    [EditorBrowsable(EditorBrowsableState.Never)]
    public attackstart4 m_attackstart4;
    [EditorBrowsable(EditorBrowsableState.Never)]
    public attackstart6 m_attackstart6;
    [EditorBrowsable(EditorBrowsableState.Never)]
    public attackstart7 m_attackstart7;
    [EditorBrowsable(EditorBrowsableState.Never)]
    public Form1 m_Form1;

    [DebuggerHidden]
    private static T Create__Instance__<T>(T Instance) where T : Form, new()
    {
      if ((object) Instance != null && !Instance.IsDisposed)
        return Instance;
      if (MyProject.MyForms.m_FormBeingCreated != null)
      {
        if (MyProject.MyForms.m_FormBeingCreated.ContainsKey((object) typeof (T)))
          throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate"));
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
        throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", invocationException.InnerException.Message), invocationException.InnerException);
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

    public attacjstart5 attacjstart5
    {
      [DebuggerHidden] get
      {
        this.m_attacjstart5 = MyProject.MyForms.Create__Instance__<attacjstart5>(this.m_attacjstart5);
        return this.m_attacjstart5;
      }
      [DebuggerHidden] set
      {
        if (value == this.m_attacjstart5)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<attacjstart5>(ref this.m_attacjstart5);
      }
    }

    public attackstart attackstart
    {
      [DebuggerHidden] get
      {
        this.m_attackstart = MyProject.MyForms.Create__Instance__<attackstart>(this.m_attackstart);
        return this.m_attackstart;
      }
      [DebuggerHidden] set
      {
        if (value == this.m_attackstart)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<attackstart>(ref this.m_attackstart);
      }
    }

    public attackstart1 attackstart1
    {
      [DebuggerHidden] get
      {
        this.m_attackstart1 = MyProject.MyForms.Create__Instance__<attackstart1>(this.m_attackstart1);
        return this.m_attackstart1;
      }
      [DebuggerHidden] set
      {
        if (value == this.m_attackstart1)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<attackstart1>(ref this.m_attackstart1);
      }
    }

    public attackstart2 attackstart2
    {
      [DebuggerHidden] get
      {
        this.m_attackstart2 = MyProject.MyForms.Create__Instance__<attackstart2>(this.m_attackstart2);
        return this.m_attackstart2;
      }
      [DebuggerHidden] set
      {
        if (value == this.m_attackstart2)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<attackstart2>(ref this.m_attackstart2);
      }
    }

    public attackstart3 attackstart3
    {
      [DebuggerHidden] get
      {
        this.m_attackstart3 = MyProject.MyForms.Create__Instance__<attackstart3>(this.m_attackstart3);
        return this.m_attackstart3;
      }
      [DebuggerHidden] set
      {
        if (value == this.m_attackstart3)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<attackstart3>(ref this.m_attackstart3);
      }
    }

    public attackstart4 attackstart4
    {
      [DebuggerHidden] get
      {
        this.m_attackstart4 = MyProject.MyForms.Create__Instance__<attackstart4>(this.m_attackstart4);
        return this.m_attackstart4;
      }
      [DebuggerHidden] set
      {
        if (value == this.m_attackstart4)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<attackstart4>(ref this.m_attackstart4);
      }
    }

    public attackstart6 attackstart6
    {
      [DebuggerHidden] get
      {
        this.m_attackstart6 = MyProject.MyForms.Create__Instance__<attackstart6>(this.m_attackstart6);
        return this.m_attackstart6;
      }
      [DebuggerHidden] set
      {
        if (value == this.m_attackstart6)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<attackstart6>(ref this.m_attackstart6);
      }
    }

    public attackstart7 attackstart7
    {
      [DebuggerHidden] get
      {
        this.m_attackstart7 = MyProject.MyForms.Create__Instance__<attackstart7>(this.m_attackstart7);
        return this.m_attackstart7;
      }
      [DebuggerHidden] set
      {
        if (value == this.m_attackstart7)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<attackstart7>(ref this.m_attackstart7);
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
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<Form1>(ref this.m_Form1);
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
