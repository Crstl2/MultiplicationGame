namespace MultiplicationGame
{
    public partial class multiplicationGame : Form
    {
        private static int a = 0;
        private static int b = 0;

        private static int streak = 0;

        public static int getStreak()
        {
            return streak;
        }
        public static void setStreak(int streak)
        {
            multiplicationGame.streak = streak;
            Loader.loadStreak();
        }

        public static int getA()
        {
            return a;
        }
        public static int getB()
        {
            return b;
        }
        public static void setA(int a)
        {
            multiplicationGame.a = a;
        }
        public static void setB(int b)
        {
            multiplicationGame.b = b;
        }

        public multiplicationGame()
        {
            InitializeComponent();
        }

        private void multiplicationGame_Load(object sender, EventArgs e)
        {
            errMsg.Text = "";

            Program.questionLabel = questionLabel;
            Program.highScoreLabel = highScoreLabel;
            Program.streakLabel = streakLabel;

            Loader.loadNewLevel();
            if (!File.Exists(Program.pathToSaveFile))
            {
                Writer.writeToHighscore(0);
                return;
            }

            string highScore = Convert.ToString(Loader.getHighscore());
            if (highScore == "")
            {
                Writer.writeToHighscore(0);
            }
            highScoreLabel.Text = Program.highScorePrefix + highScore;
        }

        private void ansTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                checkBtn_Click(sender, e);
            }
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            if (ansTxtBox.Text == "")
            {
                errMsg.Text = "Enter a number.";
                return;
            }

            int userAns;
            try
            {
                userAns = Convert.ToUInt16(ansTxtBox.Text.Trim());
            }
            catch (Exception)
            {
                ansTxtBox.Text = "";
                errMsg.Text = "Enter a number.";
                return;
            }

            if (userAns != a * b)
            {
                ansTxtBox.Text = "";
                errMsg.Text = "Incorrect!";

                setStreak(0);
                Loader.loadStreak();
                Loader.loadNewLevel();
                return;
            }
            Loader.loadNewLevel(ansTxtBox, errMsg, streak);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
