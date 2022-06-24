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
            int numberFromRandom = random.Next(0, 100);

            for (int i = 0; i < numberFromRandom; i++)
            {
                if(i % 3 == 0 || i % 5 == 0)
                {
                    sumOfNumbers += i;
                }
            }
            sumOfNumbers += numberFromRandom;
        }
    }
}
