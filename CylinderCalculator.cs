using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CylinderCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask for radius of cylinder
            Console.Write("Enter the radius of the cylinder: ");
            double radius = double.Parse(Console.ReadLine());

            // Ask  height ofcylinder
            Console.Write("Enter the height of the cylinder: ");
            double height = double.Parse(Console.ReadLine());

            // Calculate volume
            double volume = Math.PI * radius * radius * height;

            // Calculate surface area 
            double surfaceArea = 2 * Math.PI * radius * (radius + height);

            //Print results
            Console.WriteLine("The volume of the cylinder is: " + volume);
            Console.WriteLine("The surface area of the cylinder is: " + surfaceArea);
            Console.Read();
        }
    }
}
