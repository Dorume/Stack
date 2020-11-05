using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            string words;
            words = Console.ReadLine();
            Order(words);
        }

        public static string Order(string words)
        {
            string answer;

            return answer;
        }

        public static int CountBits(int input)
        {
            int powerOfTwo = 1, countOfBits = 0;
            while (input > 0)
            {
                if (input >= powerOfTwo)
                {
                    powerOfTwo *= 2;
                }
                else
                {
                    countOfBits++;
                    input -= powerOfTwo/2;
                    powerOfTwo = 1;
                }

            }
            return countOfBits;
        }
    }
}
