// Decompiled with JetBrains decompiler
// Type: L47_tV91}lx=cDU!4n1=]|DK$
// Assembly: SOCIAL CREDIT TEST, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A9FFD1C6-DD6B-47BE-B937-02E8EB54F42C
// Assembly location: C:\Users\adriel\Downloads\SOCIAL CREDIT TEST.exe

using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
public class L47_tV91\u007Dlx\u003DcDU\u00214n1\u003D\u005D\u007CDK\u0024 : Form
{
  private static SoundPlayer \u202E‫‪‏⁪‪‏‬⁪‎‌‫‪‫‮⁪⁭‫‏‎‭⁭‭⁪‎​‭‫⁭⁭‭​‭⁬‎‪‏⁪‪‫‮;
  private static SoundPlayer \u202A‌⁯‪⁪‭⁯‪⁪‬⁭⁫‏‏​‏​‌⁯​‎⁬‎‍‮‪⁮⁬⁯⁪‭⁮⁮‍⁭‮‪‫‪‏‮;
  private static SoundPlayer \u200E‌‬‪​‬⁬‫‌⁫⁭⁯⁮‭⁮‌‬‬‭‏‫‭⁯​‫‌‮‫​‭‎‍‍‌‬‭‮⁫‏⁯‮;
  private static SoundPlayer \u200D‫⁬‏⁫‪‎⁬‬‌⁬‬​⁯‮⁭⁬‬⁪‪‪‌⁫‮⁪‭⁮‎‍‭‏⁫‬⁬⁫‎⁫‭‪‎‮;
  public int \u202C⁪‎‪⁫⁬⁪‏‪‏‪⁭​‬⁪⁯⁫⁮‏⁪‬‎‬‎⁪‮‬‭‌⁯⁪‬‫‮‬‬⁭‭⁮‏‮;
  private int \u206B⁬‎‭⁮⁮‬‌⁪‍‪⁮⁬‌⁮⁭⁪‫​‎⁭​⁭⁬⁭‮‪‬⁪⁯‍⁮⁮‫‫‫‫⁪‏‬‮;
  private bool \u206E‏⁭‬‬⁭⁫⁫‮‬⁯‏‭‍⁬⁭⁮‫​⁫‫​⁭⁭‌‮‪⁪⁮⁫‍‎‍‫‪‏‮⁮⁬‌‮;
  private bool \u206C‏‏​‍‪‪⁯‬‮⁫‪‮‭‫⁬‌‎‫⁭‫⁫⁯‌‍‪‎‫‍⁬‍⁬⁪​‬⁭​‭⁮⁪‮;
  private bool \u200E‎​‫⁬⁮‬‪⁮‌‪⁬⁯​‭‎‏⁪⁮‫⁬‌‪‮‍‌‭⁮‍‎‭⁮‭‪⁬‏‮⁭‬‮;
  private \u202B‏‭‪‮⁫‫⁮⁬‫‪‍‮‫​‪⁯​‍‏‫‫‬‍⁪‪⁪‭⁬‏‍‎‎⁫‌‮‍‌‏‬‮ \u200C⁯⁮⁬‌​‬⁪⁭⁭‏⁫‫⁫​​‌‭‭⁮⁬⁫⁮⁯⁮⁮‏‌‭‮⁫‮⁬‫⁪‭‍‮‏‫‮;
  private string[] \u202C‭‭⁮‬‪⁮⁭​​⁫‏⁮⁪⁫⁪‌​‮‮⁯⁯‮⁪⁯⁪⁯​‬⁮‬⁭⁪‏⁫⁮‮‍⁪⁯‮;
  private string[] \u200B‮‎‫‪‌⁫‍‌⁬​‏⁪‏‍‪⁫⁯⁫⁭⁫​‌⁫‎‎⁮‌‏‎⁬⁮‎⁯⁫‏‭‬‭‌‮;
  private IContainer \u206E‪‏⁮‭‏‌‮‮‏‍‪‌​‫‬⁯‭⁭‮‏⁫⁫⁬⁯​‍‌⁯‍⁭​‫‎‬‭​‌⁯⁯‮;
  private Button \u206A‮‎⁪‎⁭⁯‎‬‪⁫‍‏‎⁭⁬⁫‎‎⁭‭‌‬‎⁬‬‫‬‬‌‭‏‫⁯⁫‬​‫‮‏‮;
  private Label \u200E‪⁬⁯‍‎⁯‍‌‮⁪‪‏⁭⁪⁮‍⁬⁬‎‪⁭‫⁭‏‌‬‪⁬‏‬⁫⁬⁯⁫‪‌‪⁯‍‮;
  private Label \u206F‏‌‫⁫‪⁫​⁯⁪⁮‏⁫⁬‎⁯​⁯‎‪​⁬‍‍⁬‌‭‍‭‌⁪⁮⁯‬‭⁭⁫⁬‎⁮‮;
  private Button \u206A⁮​⁮‪⁮‎‮​‫⁭⁪⁬⁭⁫‭⁬‬‏‌⁪⁪​‍⁪‌⁬‪‪⁫⁬‏‮‌⁬‭‍⁮‏⁪‮;
  private Button \u202E⁫‏‮⁬⁭⁫‭‬‏‏⁮‎⁭​‮⁪⁪‌‪⁮​⁮‬​‌‮‬‮‍⁭⁮⁫⁮⁭‪‏⁫⁯⁯‮;
  private Label \u206B⁯‫‫‎‎​⁯‎‪‮⁭⁪‍‮‫‬⁬⁪⁪⁯⁭‏⁮⁯‌‭‬⁯⁮‪‏‬​‎‫‭⁬⁮‬‮;
  private Button \u202A​‎‭‮‫‪‬‏⁫⁯‪⁭⁫‫‌‌‌‫‮⁬‏‭‫​‪‌⁭⁫⁮⁮‏⁯​​‎‍‫⁭‍‮;
  private Label \u202B‬‏‏⁯‬⁪⁪⁭‭‫‏​​⁬⁬‫‭⁬‬⁫‫‌‭‫‫‮​⁭‭⁪⁯⁫‮‫⁯⁮‍‍⁫‮;
  private Label \u202E‬⁪‎⁫‪⁮⁮⁫‭‎⁮‪‪⁯‮‪‭‏‪⁯‭‭⁮‫‪⁪⁮⁭​⁭⁪⁬​‮‪‎‫⁮‮‮;
  private Label \u200B‫‍‎‎⁭‫⁭⁯​⁫‪‭​‭‪⁯‍⁯⁪⁫‫‮‭‎⁬⁬⁫‎⁬‪​‏‏‍⁬⁪⁫‏⁭‮;
  private Button \u202A⁫‌‌‭‭‏‬⁮⁫‏⁫‎​‍⁫⁪⁪‮‫‪‮⁪‫‏‏‌​⁮⁫‬⁭⁭​‌⁬‏‌‍‭‮;

  [DllImport("user32.dll", EntryPoint = "InvalidateRect")]
  private static extern bool \u200C⁬‫‌​‬‫‍⁮‬⁭⁯‬⁪‎⁪‎‪‍‪‏‬⁮⁭⁪⁭‏‫‬⁮‭⁬‭⁯‌‮⁮⁪⁯‎‮(
    IntPtr _param0,
    IntPtr _param1,
    bool _param2);

  public L47_tV91\u007Dlx\u003DcDU\u00214n1\u003D\u005D\u007CDK\u0024()
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u206A⁪‍⁮⁯⁫⁪⁫⁫⁬‍⁬‪‮‎⁪‭⁯⁭⁫⁫‫⁪‮‬‭‏‬​⁬‏‬‮‮‭⁯‬‫⁫⁫‮(object _param1, EventArgs _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u202C⁯‮⁬​‬⁮⁬⁯‎‭‮⁭‎⁯‏⁬⁬‍⁯⁮⁯‫‮⁭‎⁫‌‮⁬‭⁮‮‭⁯⁯​⁫⁮‏‮()
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u206E⁫⁫‍⁪‍⁫‌‍‮​‫‫‏‌⁪⁫⁮‮⁮⁪⁭‮⁯​‌⁪‏‮⁫⁬⁮‍‭⁭‫‎⁬‎‮‮(
    object _param1,
    FormClosingEventArgs _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u200B‏‮‌‮‍⁭‪⁬‍‮⁬⁪⁬⁭‮⁪​‌⁬⁮‬‫⁮‍‌‫‬‫‬‎‪⁬‌‌⁭‏‬⁭‌‮(object _param1, EventArgs _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u206B‫⁯⁭⁪‎‬⁮‏⁭‫‭‍‬⁪‮⁪⁪⁫‎⁯‌‭⁭⁯‏⁪⁮⁪⁮‫‪‍​⁪‮‌⁯⁯‎‮(object _param1, EventArgs _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u202E‌‬⁬‪‎​⁪⁮​⁬‌‪⁮‭⁮‌‍‪‌​⁪‍​⁫​⁪⁮‭‮‌‪‍‬‮‭‍‮⁮⁫‮(object _param1, EventArgs _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u206F‏⁮⁬‬‫⁯‎‫‮‏‬⁫‮⁯‍‫‫‍⁭‪‬‬⁫⁫‍‏‪​‭⁯​‬⁪⁪‬​‎‎⁬‮(object _param1, EventArgs _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u206C‪‌⁪‬‬⁪​⁬‏⁯​‭‎⁭‭⁮‏⁭‫⁫‪‍‌‭⁯‫⁫‬⁮⁯‬‎​‎‭‪‪‬⁯‮(object _param1, EventArgs _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u202A⁯⁬‎‬‬⁬⁮‭⁬‌‬‮⁪‍‬⁪‌‬‭⁮⁮⁪⁬⁬⁫⁫​‫​⁯⁫⁭⁬⁬‫⁪⁪‬⁯‮()
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u200F‌‍‭‎⁫‪‬⁫⁪‫‏‌‪‌⁮‏‬‏⁮⁪⁫‮‫‪‮‬‏​‎‎‮‎⁮‎​⁬‏‌‬‮(object _param1, EventArgs _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u200B⁪⁫‪⁯‏‍‫‏‮‫​⁬⁮‮‮⁪‬‫⁫‭‮⁪⁯‏‌⁬‏‮‌​‬⁪⁫‏‪‮‌‬⁯‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u202C​⁭‎⁯⁮‎‬⁪‌‮⁭‏‮⁯‎⁮‎⁬‫⁮‬⁮⁯⁮​‎⁫‫⁮‫‫​‎⁭⁫⁫‎⁮‭‮()
  {
    // ISSUE: unable to decompile the method.
  }

  void Form.\u206B⁬‌‮‌‏‏‭⁮⁬⁪‮⁫⁯⁭‌​⁬⁫‭‪‬‎‪⁪​‎‌‌‬⁪⁮‪‌‍‪⁫⁪‬⁫‮(bool _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u206C‮⁪⁬‌‏‫⁮​‎⁬‬⁬⁫‭‎⁫⁬‫⁯⁯‭⁬⁯‪⁭‪​‬⁭⁪‫⁪⁫‬⁪‬⁪‎⁮‮()
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u206B‫⁪‏‮‮‬⁮‏‫‪‬⁭‮⁭‪⁬​‬‭‌​‮‬‎⁫‍‍‮‭⁫⁯⁬‏‏‍⁭⁫‮⁫‮() => Environment.NewLine;

  static string \u202B‌⁫‌‏‮⁬‮⁬⁪‫​⁪​‫⁫‮⁯⁬‭‪⁪‪‪‭‬‭‮‍‍‌‎‮‏‌‍⁭‏‮([In] string obj0, [In] string obj1, [In] string obj2)
  {
    return obj0 + obj1 + obj2;
  }

  static void \u200C⁫‏​⁮⁬⁮⁫​⁯‌⁪‬⁭⁫‬⁭⁬⁬‪‌‭‌⁮‮⁯⁪⁫⁪⁫⁯‍‬‪⁫‌‌‎⁮⁬‮([In] Control obj0, [In] bool obj1)
  {
    obj0.Visible = obj1;
  }

  static string \u202E⁭‍⁬‪⁬⁪‎⁪‍‪⁪⁭‬⁭‍‬‎‍‮⁯⁪​​⁮‫‏⁬‭‮‮‌⁯​⁪⁫‫‭‫⁯‮([In] string obj0, [In] string obj1)
  {
    return obj0 + obj1;
  }

  static void \u200F‍‭‌⁭‎​‍‍​‭⁪‭‌⁪‪​⁯⁫‍‌‪‏⁫‎⁯‍⁫‬⁬⁫​‎‎‏⁫⁬⁯‎‏‮([In] Control obj0, [In] string obj1)
  {
    obj0.Text = obj1;
  }

  static void \u200B‪​‮⁭⁫‌⁮‌‭‫⁯⁭⁫⁯‮‌‌‮​‮‌‌‮‪​‫‌⁪‌‍‫‍‌​‬‫⁪‭‏‮([In] CancelEventArgs obj0, [In] bool obj1)
  {
    obj0.Cancel = obj1;
  }

  static SoundPlayer \u200F‭⁫‭‭⁭‍‫‎‍​⁬⁭‫⁪‭‎‫‮⁫⁭‎⁭‏⁭⁪⁪‏‭‫‭​‍‏‏‏⁭⁮‍‌‮([In] string obj0)
  {
    return new SoundPlayer(obj0);
  }

  static void \u206B​⁮⁬‮‍‭⁭‏⁪⁫‍⁭‌‭‍‏‍‪‎‪‫‪‭‬‬‭⁭‌‮⁭‬‮⁪​​⁫‪‫‏‮([In] SoundPlayer obj0) => obj0.Stop();

  static void \u202B⁯‭⁬⁮⁭⁫‬⁪‬‏⁬‪⁯‏‍‬⁮⁪⁯‪‪‍⁪​‌⁪‮‍​‭⁮⁬⁫⁬‭⁯⁫⁪‌‮([In] Control obj0) => obj0.Hide();

  static ProcessStartInfo \u206B⁭‫‌‎⁪⁫‪‪⁭⁮⁫⁬⁮⁮‏‏‏‪⁮‭⁮‮‫‎⁪⁮⁯‪⁮‭‪⁭⁯‬⁮‌⁯‬‮() => new ProcessStartInfo();

  static void \u200E‫‭‌⁪‌⁬‬⁭‫‭⁯​‌‫⁪⁮‭‍‫⁮⁭‎‍‌‭‌‫‏⁫⁮⁯⁭‫‍‍​⁬‍⁯‮([In] ProcessStartInfo obj0, [In] string obj1)
  {
    obj0.FileName = obj1;
  }

  static void \u202C⁬​⁬‮‫⁪⁮⁯‌‍⁫‫⁫⁬‍⁭‌‎​‪‭‫‎‮‍‫⁭‏⁮‍⁬‌‍‎‌​⁬‮‫‮(
    [In] ProcessStartInfo obj0,
    [In] ProcessWindowStyle obj1)
  {
    obj0.WindowStyle = obj1;
  }

  static void \u200C‍⁪‫⁭‏⁪⁬⁪‪‭‪⁫‌‮‏‬‭​⁭⁮⁪⁬⁯‭‎⁪‭‪⁫⁬‫⁫‭⁮‬⁭‪‎⁫‮([In] ProcessStartInfo obj0, [In] string obj1)
  {
    obj0.Arguments = obj1;
  }

  static Process \u200F‫⁭‌‫‫‬⁫⁭‎‌‫⁭‎​‪‪⁬​⁯‭⁮​⁫‬⁭⁭⁭‮​⁮‬‍​⁭‬⁫‬‏‎‮([In] ProcessStartInfo obj0)
  {
    return Process.Start(obj0);
  }

  static void \u200D‮⁬⁭‍⁮​‫‪‍⁪‌⁭‏‪⁯‌‎⁭‌⁬⁪⁭‫‭⁯‮‬‎‏⁫‌‍‭‬‭⁮⁪⁫⁯‮([In] int obj0)
  {
    Environment.Exit(obj0);
  }

  static void \u202E‫‌‫‪‮‫‍‎⁪⁭⁯‬‬‮‬⁫‎‮‭‌‫‏‍⁯‭‏​‌‎⁬‫⁭⁪‭‏⁯⁪‏‌‮([In] Control obj0, [In] System.Drawing.Color obj1)
  {
    obj0.ForeColor = obj1;
  }

  static void \u202C‪‏⁭‏​‭‭‮‮‮​‬⁫‮‬‫‍⁭‭⁪‏⁪‍‭⁭⁬‌‍⁫‌‏⁯​‮‫⁮⁫‭⁭‮([In] SoundPlayer obj0) => obj0.Play();

  static void \u206F‪‍‎‌⁪‭‪‫‫‎‌⁭‍⁬⁪⁬⁭⁯‮​⁫‪​‬‪⁯‫‎‎‍‫‫⁭‭⁭‎⁯‎‌‮([In] Control obj0, [In] System.Drawing.Color obj1)
  {
    obj0.BackColor = obj1;
  }

  static Thread \u206D⁮‫⁫⁪‬‪‮⁭⁫‭⁬⁬‌‏⁯⁭‪​‬‮‭‮‬‌⁫‌⁫‎‍‎⁪​⁪‪‍‫‪‮‌‮([In] ThreadStart obj0)
  {
    return new Thread(obj0);
  }

  static void \u206E⁬‭‪‏⁮‫‮‫‫‮‌‏‏⁯⁮‭‬‬‌‮‪‌‏‫⁪⁪‫‍⁭‍⁮⁮‬‬‪‮‬⁪‪‮([In] Thread obj0) => obj0.Start();

  static RegistryKey \u202A⁬⁯⁯‮‮‫‫‌‮‫‌​‬⁯‫⁪​‎‏‪‮​⁭‫‎‌⁪⁮⁮‎⁯​‭⁫​⁭⁯‬‮([In] RegistryKey obj0, [In] string obj1)
  {
    return obj0.CreateSubKey(obj1);
  }

  static void \u206D⁭⁮‫‍⁭‬⁯⁪⁫​⁯‫‌‭‬‮‮​​‎‏‎‬⁬⁯‭⁮‌‪‪⁯⁭‮⁪⁮‪‪‏⁪‮(
    [In] RegistryKey obj0,
    [In] string obj1,
    [In] object obj2,
    [In] RegistryValueKind obj3)
  {
    obj0.SetValue(obj1, obj2, obj3);
  }

  static string \u202C⁬⁬‭⁫⁬⁮​⁬⁮⁭‮‬⁫‮‪⁭⁫⁪⁫⁭⁪‌‌‪‎‎​‭⁪‪‏‮‫‌‌‍‍⁪⁬‮([In] Environment.SpecialFolder obj0)
  {
    return Environment.GetFolderPath(obj0);
  }

  static bool \u202E⁫‪⁫⁭‮‭⁮‍⁮‍‍‎‪‏⁬‏‏​​‍‪‭⁮‪⁬⁭⁯‌⁬​⁫‍‪‫‭‍‍⁮‫‮([In] string obj0) => File.Exists(obj0);

  static void \u202E‭⁯⁮‬‫‭⁪⁮‬​‏⁬‌⁯‍‎⁫‍‫‌⁫‏⁪​​‭‫​‭⁮‪⁯​⁮‬‍‭‫‌‮([In] string obj0) => File.Delete(obj0);

  static void \u202D⁯​‭‎‎⁮‭‭⁪‭⁯⁪⁪‭‮⁯⁮‌‌‏‫​‬‬‫‌‫‫‌⁭‏‭‍‎‫‬⁮‫‭‮([In] IDisposable obj0)
  {
    obj0.Dispose();
  }

  static Button \u200C‭‪⁬‏​‬‬‌⁯‬⁯‭‭‮‭‍‎⁭‬⁫‫‬‎⁭‍⁭‪‌‪‭​⁯‍⁬‪‫⁪⁮⁬‮() => new Button();

  static Label \u200D‪‭‎​‌‫‍⁫‮⁭‬⁯‎‌‍⁯⁪⁭‭‪⁬‍⁬⁯⁫​⁯‫‏⁪⁮⁫⁪⁭‎⁯⁮⁭‬‮() => new Label();

  static void \u206D‌⁫‫⁪‍‭⁪‪⁯⁯‬‪⁮⁯⁮⁬⁭‭​‏‏‬‮‮‎‬⁮‫‏‮⁮⁫⁭⁯‍‮‏‮‪‮([In] Control obj0)
  {
    obj0.SuspendLayout();
  }

  static Cursor \u200F‬‎‭⁬⁪‎‍‍‏​‭⁫‮‫‬⁪⁫‪‎⁭‮‌‌⁯‭‎‭‫‫‍⁪⁭‎‫⁭‬‍​‫‮() => Cursors.Hand;

  static void \u202D‎⁯⁭⁮⁬‫‮⁬⁮⁭‮⁬‫‌‪​‫‬⁮‮‏​‮‪⁪‮⁭‏‬⁬⁯‬⁯‮⁯⁪‎⁯⁬‮([In] Control obj0, [In] Cursor obj1)
  {
    obj0.Cursor = obj1;
  }

  static void \u200D⁮‌⁮​‬‫⁯⁯⁭⁪⁮‫⁯‍‮‏⁪‌⁭‌‎‬⁫⁬‪‭​‫‪⁪‫⁫‮​‪‍⁯⁪⁪‮([In] ButtonBase obj0, [In] FlatStyle obj1)
  {
    obj0.FlatStyle = obj1;
  }

  static Font \u202C⁮‮‏⁭‮⁯‬‪⁭‌‬⁮⁭⁬‫​‍‌⁬​‬‍‮‌‮‍⁬‍‫‮‪‎⁯‎‮⁬‍‏⁫‮(
    [In] string obj0,
    [In] float obj1,
    [In] FontStyle obj2,
    [In] GraphicsUnit obj3,
    [In] byte obj4)
  {
    return new Font(obj0, obj1, obj2, obj3, obj4);
  }

  static void \u202B‍⁭‪⁬‬⁪‪⁭‎​⁫⁫‌‪‮⁪⁫‍‌‍‪‫⁫‬​‍‏⁪‎‭‌‎⁭‏⁮‏‪⁯‫‮([In] Control obj0, [In] Font obj1)
  {
    obj0.Font = obj1;
  }
}
