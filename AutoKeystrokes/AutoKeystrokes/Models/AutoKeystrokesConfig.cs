namespace AutoKeystrokes.Models
{
    public class AutoKeystrokesConfig
    {
        public AutoKeystrokesConfig()
        {
            MillisecondsToWaitBetween = 500;
        }

        public string ProcessName { get; set; }

        public int MillisecondsToWaitBetween { get; set; }

    }
}
