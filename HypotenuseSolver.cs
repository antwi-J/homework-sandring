using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PythagorasTheorem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SideA
            Console.Write("Enter the length of side a: ");
            double a = double.Parse(Console.ReadLine());

            //SideB
            Console.Write("Enter the length of side b: ");
            double b = double.Parse(Console.ReadLine());

            //PythagorasCalculation
            double hypotenuse = Math.Sqrt(a * a + b * b);

            //roounding to 2 decimal places
            double roundedHypotenuse = Math.Round(hypotenuse, 2);

            //display result
            Console.WriteLine("The length of the hypotenuse is: " + roundedHypotenuse);
            Console.Read();
        }
    }
}
