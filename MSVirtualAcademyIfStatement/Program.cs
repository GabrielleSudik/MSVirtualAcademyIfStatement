using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSVirtualAcademyIfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //practicing the IF statement

            Console.WriteLine("The Game");
            Console.WriteLine("Choose a door: 1, 2 or 3.");
            string userValue = Console.ReadLine();

            string message = "";

            if (userValue == "1")
            {
                message = "You win a goat!";
            }

            else if (userValue == "2")
                message = "You win one dollar!";

            else if (userValue == "3")
                message = "You win a cat!";

            else
            {
                message = "wut. ";
                message += "You lose.";
            }

            //when the if/else block of code is real small
            //you don't need the {}
            //but basically once you have a ; in the statement
            //you'll need {} to capture all relevant code

            Console.WriteLine(message);
            Console.ReadLine();

            //now here's something new!

            Console.WriteLine("The Second Game");
            Console.WriteLine("Choose a door: 1, 2 or 3.");
            string userValue2 = Console.ReadLine();

            //what the next line does is compare answer to "1"
            //if it's true, you get what is before the : (boat)
            //if false, you get what's after the : (hair)
            //looks most useful if only one choice produces desired result
            //and if the result is simple/short

            string message2 = (userValue2 == "1") ? "boat" : "strand of hair";
            Console.Write($"You won a {message2}.");

            Console.ReadLine();

        }
    }
}
