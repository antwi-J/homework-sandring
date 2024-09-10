using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvgCalc5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;

            //Where the 5 numbers are entered
            Console.Write("Enter number 1: ");
            double number1 = double.Parse(Console.ReadLine());
            sum += number1;

            Console.Write("Enter number 2: ");
            double number2 = double.Parse(Console.ReadLine());
            sum += number2;

            Console.Write("Enter number 3: ");
            double number3 = double.Parse(Console.ReadLine());
            sum += number3;

            Console.Write("Enter number 4: ");
            double number4 = double.Parse(Console.ReadLine());
            sum += number4;

            Console.Write("Enter number 5: ");
            double number5 = double.Parse(Console.ReadLine());
            sum += number5;

            // Calculate the average
            double average = sum / 5;

          
            Console.WriteLine("The average of the five numbers is: " + average);
            Console.Read();

        }
    }
}
