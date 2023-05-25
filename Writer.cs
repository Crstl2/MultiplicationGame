using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationGame
{
    internal class Writer
    {
        public static void writeToHighscore(int numberToType)
        {
            using (StreamWriter writer = new StreamWriter(Program.pathToSaveFile))
            {
                writer.Write(Encryptor.getEncrypted(numberToType));
            }
        }
    }
}