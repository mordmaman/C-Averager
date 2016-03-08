using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace averager2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = new List<double>();
            bool go = true;
            //fish
            int i = 0;
            double average;

            while (go == true)
            {
                Console.WriteLine("Enter a number and press Enter to see the average (to stop type \"done\"): ");
                string number = Console.ReadLine();

                if (number.ToLower() == "done")
                {
                    go = false;
                }
                else
                {
                    try
                    {
                        double num = double.Parse(number);
                        numbers.Add(num);
                        i++;
                        average = (numbers.Sum()) / i;
                        Console.WriteLine("Your average is " + average.ToString("0.0"));
                        continue;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("That is not a valid input");
                        continue;
                    }
                }
            }
        }
    }
}
