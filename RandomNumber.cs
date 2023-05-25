using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationGame
{
    internal class RandomNumber
    {
        public static int getRandomNumber()
        {
            Random random = new Random();
            int randNum = random.Next(13) + 2;
            while (randNum.Equals(10) || randNum.Equals(11) || randNum > 12)
            {
                randNum = random.Next(13) + 2;
            }
            return randNum;
        }
    }
}
