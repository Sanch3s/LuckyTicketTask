using System;
using System.Collections.Generic;
using System.Linq;

namespace Lucky_ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Lottery");
            while (true)
            {
                Console.WriteLine("Enter your number");
                string number = Console.ReadLine();
                CalculateLuckyNumber(number);
            }
        }
        private static void CalculateLuckyNumber(string number)
        {
            double sumFirst = 0;
            double sumSecond = 0;
            List<double> numbers = new List<double>();
            foreach (char c in number)
            {
                numbers.Add(char.GetNumericValue(c));
            }
            int count = numbers.Count();
            if (count >= 4 && count <= 8)
            {
                if (count % 2 != 0)
                {
                    numbers.Insert(0, 0);
                    count = numbers.Count();
                }
                for (int i = 0; i < count / 2; i++)
                {
                    sumFirst += numbers[i];
                }
                for (int i = count / 2; i < count; i++)
                {
                    sumSecond += numbers[i];
                }
                Console.WriteLine("Sum of first part: " + sumFirst);
                Console.WriteLine("Sum of second part: " + sumSecond);
                if (sumFirst == sumSecond)
                {
                    Console.WriteLine("You win! :)");
                }
                else
                {
                    Console.WriteLine("Not lucky :(");
                }
            }
            else
            {
                Console.WriteLine("False number");
            }
            Console.ReadKey();
        }
    }
}