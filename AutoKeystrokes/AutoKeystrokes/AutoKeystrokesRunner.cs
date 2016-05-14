using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoKeystrokes.Models;
using AutoKeystrokes.Interfaces;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Globalization;
using System.ComponentModel;      

namespace AutoKeystrokes
{

    public class AutoKeystrokesRunner : IKeystrokesRunner
    {
        public AutoKeystrokesConfig Config { get; set; }

        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern bool PostMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("User32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        private const int keyDown = 0x0100;

        public void PressKeys(string keyStrokes)
        {
            var process = Process.GetProcessesByName(Config.ProcessName).FirstOrDefault();

            if (process == null)
            {
                throw new InvalidOperationException(string.Format("Unable focus on process `{0}`", Config.ProcessName));
            }

            var windowFocused = SetForegroundWindow(process.MainWindowHandle);

            foreach(var keystroke in keyStrokes.ToCharArray())
            {
                Console.WriteLine("Enter keystroke {0}", keystroke);

                var key = (int) keystroke;

                var success = PostMessage(process.MainWindowHandle, keyDown, 0x41, 1);

                if (!success)
                {
                    throw new Win32Exception(Marshal.GetLastWin32Error());
                }

                Thread.Sleep(Config.MillisecondsToWaitBetween);
            }
        }
    }
}
