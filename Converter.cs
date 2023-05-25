using System.Text.RegularExpressions;

namespace MultiplicationGame
{
    internal class Converter
    {
        private const string HUNDRED_TXT = " hundred";
        private const string THOUSAND_TXT = " thousand";
        private const string MILLION_TXT = " million";

        private static string words = "";
        
        private static List<string> ones = new List<string> { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        private static List<string> teens = new List<string> { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        private static List<string> tens = new List<string> { "", "", "twenty", "thirsty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        private static Dictionary<string, long> numberTable = new Dictionary<string, long>{
        {"zero",0},{"one",1},{"two",2},{"three",3},{"four",4},{"five",5},{"six",6},
        {"seven",7},{"eight",8},{"nine",9},{"ten",10},{"eleven",11},{"twelve",12},
        {"thirteen",13},{"fourteen",14},{"fifteen",15},{"sixteen",16},{"seventeen",17},
        {"eighteen",18},{"nineteen",19},{"twenty",20},{"thirty",30},{"forty",40},
        {"fifty",50},{"sixty",60},{"seventy",70},{"eighty",80},{"ninety",90},
        {"hundred",100},{"thousand",1000},{"lakh",100000},{"million",1000000},
        {"billion",1000000000},{"trillion",1000000000000},{"quadrillion",1000000000000000},
        {"quintillion",1000000000000000000}
        };

        public static long ConvertFromWordsToNumbers(string numberString)
        {
            var numbers = Regex.Matches(numberString, @"\w+").Cast<Match>()
                    .Select(m => m.Value.ToLowerInvariant())
                    .Where(v => numberTable.ContainsKey(v))
                    .Select(v => numberTable[v]);
            long acc = 0, total = 0L;
            foreach (var n in numbers)
            {
                if (n >= 1000)
                {
                    total += acc * n;
                    acc = 0;
                }
                else if (n >= 100)
                {
                    acc *= n;
                }
                else acc += n;
            }
            return (total + acc) * (numberString.StartsWith("minus",
                    StringComparison.InvariantCultureIgnoreCase) ? -1 : 1);
        }

        public static string ConvertFromNumbersToWords(int n)
        {
            if (n < 10)
            {
                getTheUnits(n);
            }
            else if (n < 20)
            {
                getTheTeens(n);
            }
            else if (n < 100)
            {
                getTheTens(n);
            }
            else if (n < 1000)
            {
                getTheHundreds(n);
            }
            else if (n < 1000000)
            {
                getTheThousands(n);
            }
            else if (n < 1000000000)
            {
                getTheMillions(n);
            }

            return words;
        }

        private static string getTheUnits(int n)
        {
            words = ones[n];
            return words;
        }

        private static string getTheTeens(int n)
        {
            words = teens[n - 10];
            return words;
        }

        private static string getTheTens(int n)
        {
            words = tens[n / 10] + ((n % 10 != 0) ? " " + getTheUnits(n % 10) : "");
            return words;
        }

        private static string getTheHundreds(int n)
        {
            if (n % 100 != 0 && n % 100 < 10)
            {
                words = getTheUnits(n / 100) + HUNDRED_TXT + " " + getTheUnits(n % 100);
            }
            else if (n % 100 != 0 && n % 100 > 10 && n % 100 < 20)
            {
                words = getTheUnits(n / 100) + HUNDRED_TXT + " " + getTheUnits(n % 100);
            }
            else
            {
                words = getTheUnits(n / 100) + HUNDRED_TXT + ((n % 100 != 0) ? " " + ConvertFromNumbersToWords(n % 100) : "");
            }

            return words;
        }

        private static string getTheThousands(int n)
        {
            words = ConvertFromNumbersToWords(n / 1000) + THOUSAND_TXT + ((n % 1000 != 0) ? " " + ConvertFromNumbersToWords(n % 1000) : "");
            return words;
        }

        private static string getTheMillions(int n)
        {
            words = ConvertFromNumbersToWords(n / 1000000) + MILLION_TXT + ((n % 1000000 != 0) ? " " + ConvertFromNumbersToWords(n % 1000000) : "");
            return words;
        }

    }
}
