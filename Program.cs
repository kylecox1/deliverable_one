using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro01
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Millenial Hipster conversion!");
            bool repeat = true;
            while (repeat == true)
            {
                Console.Write("Is your measurement type inches, feet, fidget spinners, or memes? ");
                string measurementType = Console.ReadLine();

                Console.Write("Please enter the amount: ");
                double amount = double.Parse(Console.ReadLine());

                if (measurementType == "inches")
                {
                    amount *= 3.5;
                    measurementType = "fidget spinners";
                }
                else if (measurementType == "feet")
                {
                    amount *= 5;
                    measurementType = "memes";
                }
                else if (measurementType == "fidget spinners")
                {
                    amount /= 3.5;
                    measurementType = "inches";
                }
                else if (measurementType == "memes")
                {
                    amount /= 5;
                    measurementType = "feet";
                }

                Console.WriteLine("That is " + amount + " " + measurementType + "!");

                Console.Write("Do you wish do to another calculation? ");
                string response = Console.ReadLine();
                if (response != "yes")
                {
                    repeat = false;
                }
            }
        }
    }
}
