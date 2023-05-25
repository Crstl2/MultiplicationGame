using System.Windows.Forms;

namespace MultiplicationGame
{
    internal class Loader
    {
        public static void loadNewLevel(TextBox ansTxtBox, Label errMsg, int streak)
        {
            multiplicationGame.setStreak(streak + 1);

            if (getHighscore() < streak+1)
            {
                Writer.writeToHighscore(streak+1);
                loadHighScore(Program.highScoreLabel);
            }
            ansTxtBox.Text = "";
            errMsg.Text = "";

            loadNewLevel();
        }
        public static void loadNewLevel()
        {
            multiplicationGame.setA(RandomNumber.getRandomNumber());
            multiplicationGame.setB(RandomNumber.getRandomNumber());
            Program.questionLabel.Text = multiplicationGame.getA() + " x " + multiplicationGame.getB();
            Program.questionLabel.Left = (Form.ActiveForm.Width - Program.questionLabel.Width) / 2;
        }

        public static void loadStreak()
        {
            Program.streakLabel.Text = Program.streakPrefix + multiplicationGame.getStreak();
        }
        public static void loadHighScore(Label highScoreLabel)
        {
            int score = 0;
            using (var reader = new StreamReader(Program.pathToSaveFile))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    score = Convert.ToUInt16(Decryptor.getDecrypted(line));
                }
            }
            highScoreLabel.Text = Program.highScorePrefix + score;
        }
        public static int getHighscore()
        {
            if (!File.Exists(Program.pathToSaveFile))
            {
                return -1;
            }
            int score = 0;
            using (StreamReader reader = new StreamReader(Program.pathToSaveFile))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    score = Convert.ToUInt16(Decryptor.getDecrypted(line));
                }
            }
            return score;
        }
    }
}
