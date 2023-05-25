namespace MultiplicationGame
{
    internal class Decryptor
    {
        public static string getDecrypted(string txtToDencrypt)
        {
            string output = string.Empty;

            foreach (char ch in txtToDencrypt)
                output += Encryptor.cipher(ch, 26 - Program.KEY);

            return Convert.ToString(Converter.ConvertFromWordsToNumbers(output));
        }

    }
}
