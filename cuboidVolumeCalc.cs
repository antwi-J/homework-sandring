using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuboidVolumeCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //length entered here
            Console.Write("Enter the length of the cuboid: ");
            double length = double.Parse(Console.ReadLine());

            //width entered here
            Console.Write("Enter the width of the cuboid: ");
            double width = double.Parse(Console.ReadLine());

            //height entered here
            Console.Write("Enter the height of the cuboid: ");
            double height = double.Parse(Console.ReadLine());

            //calculation
            double volume = length * width * height;

            //volume print
            Console.WriteLine("The volume of the cuboid is: " + volume);
            Console.Read();
        }
    }
}
