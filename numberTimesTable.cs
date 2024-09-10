using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberTimesTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(number + " x 1 = " + (number * 1));
            Console.WriteLine(number + " x 2 = " + (number * 2));
            Console.WriteLine(number + " x 3 = " + (number * 3));
            Console.WriteLine(number + " x 4 = " + (number * 4));
            Console.WriteLine(number + " x 5 = " + (number * 5));
            Console.WriteLine(number + " x 6 = " + (number * 6));
            Console.Read();
        }
    }
}
