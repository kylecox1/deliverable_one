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
            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            Console.Write("What is your age? ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("What is the current year? ");
            int year = int.Parse(Console.ReadLine());

            int birthYear = year - age;

            Console.WriteLine(name + ", if you're " + age + " years old, you were probably born in " + birthYear + ".");
        }
    }
}
