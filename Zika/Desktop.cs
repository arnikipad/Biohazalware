// Decompiled with JetBrains decompiler
// Type: Desktop
// Assembly: Zika, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C7CE6D81-E560-4B98-8463-4AED586D3B4E
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\GDI\Zika\Zika.exe

using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

#nullable disable
internal static class Desktop
{
  private const int STANDARD_RIGHTS_REQUIRED = 983040 /*0x0F0000*/;
  private const int SECTION_QUERY = 1;
  private const int SECTION_MAP_WRITE = 2;
  private const int SECTION_MAP_READ = 4;
  private const int SECTION_MAP_EXECUTE = 8;
  private const int SECTION_EXTEND_SIZE = 16 /*0x10*/;
  private const int SECTION_ALL_ACCESS = 983071;
  private const int PROCESS_VM_OPERATION = 8;
  private const int PROCESS_VM_READ = 16 /*0x10*/;
  private const int PROCESS_VM_WRITE = 32 /*0x20*/;
  public const int MEM_COMMIT = 4096 /*0x1000*/;
  private const int MEM_RESERVE = 8192 /*0x2000*/;
  public const int MEM_RELEASE = 32768 /*0x8000*/;
  public const int PAGE_READWRITE = 4;
  private const int GWL_STYLE = -16;
  private const int LVS_AUTOARRANGE = 256 /*0x0100*/;
  private const int LVM_FIRST = 4096 /*0x1000*/;
  private const int LVM_GETITEMCOUNT = 4100;
  private const int LVM_GETITEMRECT = 4110;
  public const int LVM_SETITEMPOSITION = 4111;
  private const int LVM_GETITEMPOSITION = 4112;
  private const int WM_COMMAND = 273;
  public const int LVM_GETEXTENDEDLISTVIEWSTYLE = 4151;
  public const int LVM_SETEXTENDEDLISTVIEWSTYLE = 4150;
  public const int LVS_EX_SNAPTOGRID = 524288 /*0x080000*/;
  private const int IDM_TOGGLEAUTOARRANGE = 28737;
  public static Desktop.RECTAPI[] m_OriginalPoint;
  public static Desktop.POINTAPI[] m_OriginalPos;
  private static bool m_AutoArrange;
  public static bool m_Message;

  [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
  public static extern IntPtr OpenProcess(int dwDesiredAccess, int bInheritHandle, int dwProcessId);

  [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
  public static extern IntPtr VirtualAllocEx(
    IntPtr hProcess,
    int lpAddress,
    int dwSize,
    int flAllocationType,
    int flProtect);

  [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
  public static extern int VirtualFreeEx(
    IntPtr hProcess,
    IntPtr lpAddress,
    int dwSize,
    int dwFreeType);

  [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
  public static extern int CloseHandle(IntPtr hObject);

  public static IntPtr GetMemSharedNT(int pid, int memSize, ref IntPtr hProcess)
  {
    hProcess = Desktop.OpenProcess(56, 0, pid);
    return Desktop.VirtualAllocEx(hProcess, 0, memSize, 12288 /*0x3000*/, 4);
  }

  public static void FreeMemSharedNT(IntPtr hProcess, IntPtr MemAddress, int memSize)
  {
    Desktop.VirtualFreeEx(hProcess, MemAddress, memSize, 32768 /*0x8000*/);
    Desktop.CloseHandle(hProcess);
  }

  [DllImport("user32", EntryPoint = "FindWindowA", CharSet = CharSet.Ansi, SetLastError = true)]
  private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

  [DllImport("user32", EntryPoint = "FindWindowExA", CharSet = CharSet.Ansi, SetLastError = true)]
  private static extern IntPtr FindWindowEx(
    IntPtr hWndParent,
    int hWndChildAfter,
    string lpClassName,
    string lpWindowName);

  [DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true)]
  private static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, ref int lpdwProcessId);

  [DllImport("user32", EntryPoint = "GetWindowLongA", CharSet = CharSet.Ansi, SetLastError = true)]
  private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

  [DllImport("Shell32.dll")]
  public static extern int SHChangeNotify(int eventId, int flags, IntPtr item1, IntPtr item2);

  [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
  private static extern int ReadProcessMemory(
    IntPtr hProcess,
    IntPtr lpBaseAddress,
    ref Desktop.RECTAPI lpBuffer,
    int nSize,
    ref int lpNumberOfBytesWritten);

  [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
  private static extern int WriteProcessMemory(
    IntPtr hProcess,
    IntPtr lpBaseAddress,
    ref Desktop.RECTAPI lpBuffer,
    int nSize,
    ref int lpNumberOfBytesWritten);

  [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
  private static extern int ReadProcessMemory(
    IntPtr hProcess,
    IntPtr lpBaseAddress,
    ref Desktop.POINTAPI lpBuffer,
    int nSize,
    ref int lpNumberOfBytesWritten);

  [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
  private static extern int WriteProcessMemory(
    IntPtr hProcess,
    IntPtr lpBaseAddress,
    ref Desktop.POINTAPI lpBuffer,
    int nSize,
    ref int lpNumberOfBytesWritten);

  [DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true)]
  private static extern IntPtr GetParent(IntPtr hWnd);

  [DllImport("user32", EntryPoint = "SendMessageA", CharSet = CharSet.Ansi, SetLastError = true)]
  public static extern int SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

  [DllImport("user32", EntryPoint = "SendMessageA", CharSet = CharSet.Ansi, SetLastError = true)]
  public static extern int SendMessage(IntPtr hWnd, int wMsg, int wParam, IntPtr lParam);

  public static bool SaveDesktop()
  {
    int lpdwProcessId = 0;
    IntPtr hProcess = new IntPtr();
    IntPtr num1 = new IntPtr();
    int lpNumberOfBytesWritten1 = 0;
    int lpNumberOfBytesWritten2 = 0;
    IntPtr num2 = new IntPtr();
    IntPtr sysLvHwnd = Desktop.GetSysLVHwnd();
    if (sysLvHwnd.Equals((object) IntPtr.Zero))
      return false;
    if ((Desktop.GetWindowLong(sysLvHwnd, -16) & 256 /*0x0100*/) == 256 /*0x0100*/)
    {
      Desktop.m_AutoArrange = true;
      Desktop.SendMessage(Desktop.GetParent(sysLvHwnd), 273, 28737, 0);
    }
    int length = Desktop.SendMessage(sysLvHwnd, 4100, 0, 0);
    if (length == 0)
      return false;
    Desktop.m_OriginalPoint = new Desktop.RECTAPI[length];
    Desktop.m_OriginalPos = new Desktop.POINTAPI[length];
    int num3 = Marshal.SizeOf((object) Desktop.m_OriginalPoint[0]);
    int num4 = Marshal.SizeOf((object) Desktop.m_OriginalPos[0]);
    Desktop.GetWindowThreadProcessId(sysLvHwnd, ref lpdwProcessId);
    IntPtr memSharedNt1 = Desktop.GetMemSharedNT(lpdwProcessId, num3, ref hProcess);
    Desktop.WriteProcessMemory(hProcess, memSharedNt1, ref Desktop.m_OriginalPoint[0], num3, ref lpNumberOfBytesWritten1);
    string text = "";
    for (int wParam = 0; wParam < length; ++wParam)
    {
      Desktop.m_OriginalPoint[wParam].left = 0;
      Desktop.SendMessage(sysLvHwnd, 4110, wParam, memSharedNt1);
      Desktop.ReadProcessMemory(hProcess, memSharedNt1, ref Desktop.m_OriginalPoint[wParam], num3, ref lpNumberOfBytesWritten2);
      text = $"{text}{(object) wParam}: {(object) Desktop.m_OriginalPoint[wParam].left}~{(object) Desktop.m_OriginalPoint[wParam].right} , {(object) Desktop.m_OriginalPoint[wParam].top}~{(object) Desktop.m_OriginalPoint[wParam].bottom}\n";
    }
    Desktop.FreeMemSharedNT(hProcess, memSharedNt1, num3);
    IntPtr memSharedNt2 = Desktop.GetMemSharedNT(lpdwProcessId, num4, ref hProcess);
    Desktop.WriteProcessMemory(hProcess, memSharedNt2, ref Desktop.m_OriginalPos[0], num4, ref lpNumberOfBytesWritten1);
    for (int wParam = 0; wParam < length; ++wParam)
    {
      Desktop.SendMessage(sysLvHwnd, 4112, wParam, memSharedNt2);
      Desktop.ReadProcessMemory(hProcess, memSharedNt2, ref Desktop.m_OriginalPos[wParam], num4, ref lpNumberOfBytesWritten2);
    }
    Desktop.FreeMemSharedNT(hProcess, memSharedNt2, num4);
    if (Desktop.m_Message)
    {
      int num5 = (int) MessageBox.Show(text);
    }
    int num6 = Desktop.m_AutoArrange ? 1 : 0;
    return true;
  }

  [DllImport("user32.dll")]
  private static extern IntPtr GetShellWindow();

  [DllImport("user32.dll")]
  public static extern bool EnumWindows(Desktop.EnumWindowsProc enumProc, IntPtr lParam);

  [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
  private static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

  public static IntPtr GetDesktopWindow(Desktop.DesktopWindow desktopWindow)
  {
    IntPtr shellWindow = Desktop.GetShellWindow();
    IntPtr _SHELLDLL_DefViewParent = shellWindow;
    IntPtr _SHELLDLL_DefView = Desktop.FindWindowEx(shellWindow, 0, "SHELLDLL_DefView", (string) null);
    IntPtr _SysListView32 = Desktop.FindWindowEx(_SHELLDLL_DefView, 0, "SysListView32", "FolderView");
    if (_SHELLDLL_DefView == IntPtr.Zero)
      Desktop.EnumWindows((Desktop.EnumWindowsProc) ((hwnd, lParam) =>
      {
        StringBuilder lpClassName = new StringBuilder(256 /*0x0100*/);
        if (Desktop.GetClassName(hwnd, lpClassName, 256 /*0x0100*/) > 0)
        {
          string str = lpClassName.ToString();
          if (str == "Progman" || str == "WorkerW")
          {
            IntPtr windowEx = Desktop.FindWindowEx(hwnd, 0, "SHELLDLL_DefView", (string) null);
            if (windowEx != IntPtr.Zero)
            {
              _SHELLDLL_DefViewParent = hwnd;
              _SHELLDLL_DefView = windowEx;
              _SysListView32 = Desktop.FindWindowEx(windowEx, 0, "SysListView32", "FolderView");
              return false;
            }
          }
        }
        return true;
      }), IntPtr.Zero);
    switch (desktopWindow)
    {
      case Desktop.DesktopWindow.ProgMan:
        return shellWindow;
      case Desktop.DesktopWindow.SHELLDLL_DefViewParent:
        return _SHELLDLL_DefViewParent;
      case Desktop.DesktopWindow.SHELLDLL_DefView:
        return _SHELLDLL_DefView;
      case Desktop.DesktopWindow.SysListView32:
        return _SysListView32;
      default:
        return IntPtr.Zero;
    }
  }

  public static IntPtr GetSysLVHwnd()
  {
    return Desktop.GetDesktopWindow(Desktop.DesktopWindow.SysListView32);
  }

  public struct POINTAPI
  {
    public int x;
    public int y;
  }

  public struct RECTAPI
  {
    public int left;
    public int top;
    public int right;
    public int bottom;
  }

  private struct LVITEM
  {
    public int mask;
    public int iItem;
    public int iSubItem;
    public int state;
    public int stateMask;
    public IntPtr pszText;
    public int cchTextMax;
    public int iImage;
    public int lParam;
    public int iIndent;
  }

  public enum DesktopWindow
  {
    ProgMan,
    SHELLDLL_DefViewParent,
    SHELLDLL_DefView,
    SysListView32,
  }

  public delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);
}
