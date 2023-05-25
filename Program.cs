namespace MultiplicationGame
{
    internal static class Program
    {
        public static Label streakLabel, questionLabel, highScoreLabel;


        public static string pathToSaveFile = "streak.txt";
        public static string streakPrefix = "Streak: ";
        public static string highScorePrefix = "High Score: ";


        public static string hash = "%4h&bn9873*7^><?:'";
        public const int KEY = 11;

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new multiplicationGame());
        }
    }
}