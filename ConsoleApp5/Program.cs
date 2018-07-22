using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name, age, and location?");

            Console.WriteLine("What is your name?");
            Console.Write("Type name here:");
            string myName;
            myName = Console.ReadLine();

            Console.WriteLine("What is your Age");
            Console.Write("Type age here:");
            string myAge;
            myAge = Console.ReadLine();

            Console.WriteLine("What is your Location?");
            Console.Write("Type location here:");
            string myLocation;
            myLocation = Console.ReadLine();

            Console.WriteLine("Hello, "  + myName  +  " I am "  +  myAge  +  " years old, and I live in "  + myLocation);
            Console.ReadLine();




        }
    }
}
