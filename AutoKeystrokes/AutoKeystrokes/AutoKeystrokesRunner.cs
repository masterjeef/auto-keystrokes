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
using System.Windows.Forms;      

namespace AutoKeystrokes
{

    public class AutoKeystrokesRunner : IKeystrokesRunner
    {
        public AutoKeystrokesConfig Config { get; set; }

        [DllImport("User32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

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
                SendKeys.SendWait(keystroke.ToString());

                Thread.Sleep(Config.MillisecondsToWaitBetween);
            }
        }
    }
}
