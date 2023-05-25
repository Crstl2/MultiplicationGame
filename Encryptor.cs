namespace MultiplicationGame
{
    internal class Encryptor
    {
        public static string getEncrypted(int numberToEncrypt)
        {
            string output = string.Empty;
            string numberInWords = Converter.ConvertFromNumbersToWords(numberToEncrypt);

            foreach (char ch in numberInWords)
                output += cipher(ch, Program.KEY);

            return output;
        }

        public static char cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {

                return ch;
            }
            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);
        }
    }
}
