using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int sumOfNumbers = 0;
            int maxValue = 100;
            int minValue = 0;
            int multipleOfThree = 3;
            int multipleOfFive = 5;
            int numberFromRandom = random.Next(minValue, maxValue);

            for (int i = 0; i < numberFromRandom; i++)
            {
                if(i % multipleOfThree == 0 || i % multipleOfFive == 0)
                {
                    sumOfNumbers += i;
                }
            }
            sumOfNumbers += numberFromRandom;
        }
    }
}
