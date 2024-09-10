using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fav_film
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter your favorite film: ");
            string film = Console.ReadLine();

            
            Console.Write("How many times have you seen it? ");
            int timesSeen = int.Parse(Console.ReadLine());

            
            Console.WriteLine("Your favorite film is " + film + " and you have seen it " + timesSeen + " times.");
            Console.Read();
        }
    }
}
