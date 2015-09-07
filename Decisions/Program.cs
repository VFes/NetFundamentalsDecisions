using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Console.WriteLine("Please type something and press the Enter Key.");
            ////string userValue;
            ////userValue = Console.ReadLine();
            ////Console.WriteLine("You typed: " + userValue);

            Console.WriteLine("Would you prefer what is behind door number 1,2 or 3?");
            string userValue = Console.ReadLine();
            //string message = "";
            //if (userValue == "1")
            //    //Console.WriteLine("You won a new car!");
            //    //Console.ReadLine();
            //    message = "You won a new car!";
            //else if (userValue == "2")
            //    //Console.WriteLine("You won a new boat!");
            //    //Console.ReadLine();
            //    message = "You won a new boat!";
            //else if (userValue == "3")
            //    //Console.WriteLine("You won a new cat!");
            //    //Console.ReadLine();
            //    message = "You won a new cat!";
            //else
            //    //Console.WriteLine("Sorry, we did not understand. You lose!");
            //    //Console.ReadLine();
            //    message = "Sorry, we did not understand. You lose!";


            //Console.WriteLine(message);jyjyj

            string message = (userValue == "1") ? "boat" : "strand of lint";
            Console.WriteLine("You won a {0} {1}", message, userValue);
            Console.ReadLine();
        }
    }
}
