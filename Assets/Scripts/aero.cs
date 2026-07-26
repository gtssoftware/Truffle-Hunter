using System;
using System.Runtime.InteropServices;
using UnityEngine;

public class ForceAeroTitleBar : MonoBehaviour
{
    [DllImport("user32.dll")]
    private static extern IntPtr GetActiveWindow();

    [DllImport("user32.dll")]
    private static extern uint GetWindowLong(IntPtr hWnd, int nIndex);

    [DllImport("user32.dll")]
    private static extern uint SetWindowLong(IntPtr hWnd, int nIndex, uint dwNewLong);

    [DllImport("user32.dll")]
    private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

    const int GWL_STYLE = -16;
    const uint WS_CAPTION = 0x00C00000;
    const uint WS_SIZEBOX = 0x00040000;
    const uint SWP_NOMOVE = 0x0002;
    const uint SWP_NOSIZE = 0x0001;
    const uint SWP_FRAMECHANGED = 0x0020;

    void Start()
    {
        // Only attempt this execution on Windows architectures
        if (Application.platform == RuntimePlatform.WindowsPlayer)
        {
            IntPtr hWnd = GetActiveWindow();
            
            // Fetch current window styles configured by Unity
            uint style = GetWindowLong(hWnd, GWL_STYLE);
            
            // Forcefully inject OS Caption (Title bar) and Sizebox (Borders) flags
            style |= (WS_CAPTION | WS_SIZEBOX);
            SetWindowLong(hWnd, GWL_STYLE, style);
            
            // Push frame changes to force DWM to redraw the window with Aero glass
            SetWindowPos(hWnd, IntPtr.Zero, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE | SWP_FRAMECHANGED);
        }
    }
}