using System;

namespace ThrillingStory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //no of children
            Console.Write("How many children are there? ");
            int numberOfChildren = int.Parse(Console.ReadLine());

            //no of sweets
            Console.Write("How many sweets do they each have? ");
            int sweetsPerChild = int.Parse(Console.ReadLine());

            //no of ducks
            Console.Write("How many ducks were there? ");
            int numberOfDucks = int.Parse(Console.ReadLine());

            //no of sweets given to ducks
            Console.Write("How many sweets did each child give each duck? ");
            int sweetsPerDuck = int.Parse(Console.ReadLine());

            // Calculate the total number of sweets
            int totalSweets = numberOfChildren * sweetsPerChild;

            // Calculate the total sweets given away
            int totalSweetsGivenAway = numberOfChildren * numberOfDucks * sweetsPerDuck;

            // Calculate the total sweets left after giving away and eating one
            int sweetsLeft = totalSweets - totalSweetsGivenAway - numberOfChildren;

            //All of the story is printed
            Console.WriteLine();
            Console.WriteLine("There were " + numberOfChildren + " children each with a bag containing " + sweetsPerChild + " sweets.");
            Console.WriteLine("They walked past " + numberOfDucks + " ducks.");
            Console.WriteLine("Each child gave " + sweetsPerDuck + " sweets to each of the ducks and ate one themself.");
            Console.WriteLine("They decided to put the rest into a pile.");
            Console.WriteLine("They counted the pile and found it contained " + sweetsLeft + " sweets.");

            
            Console.Read();
        }
    }
}
