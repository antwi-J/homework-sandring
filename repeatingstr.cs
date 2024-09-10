using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repeating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

         
           

            
            string message = "" + name;

            
            string repeatedMessage = message + " " + message + " " + message + " " + message + " " + message;

            
            Console.WriteLine(repeatedMessage);
            Console.Read();
             
        }
    }
}
