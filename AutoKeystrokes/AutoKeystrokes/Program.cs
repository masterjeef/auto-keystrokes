using AutoKeystrokes.Models;
using EasyArgs;

namespace AutoKeystrokes
{
    class Program
    {
        static void Main(string[] args)
        {
            var easyArgs = new Args
            {
                Arguments = args
            };

            var config = new AutoKeystrokesConfig
            {
                MillisecondsToWaitBetween = easyArgs["KeyWait"],
                ProcessName = easyArgs["Process"]
            };

            string keystrokes = easyArgs["Keys"];

            var keystrokesRunner = new AutoKeystrokesRunner
            {
                Config = config
            };

            keystrokesRunner.PressKeys(keystrokes);
        }
    }
}
