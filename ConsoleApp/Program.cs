using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloWorld = "Hello World";
            int number = 1492;
            string dog = "dog at home";
            DateTime today = DateTime.Now;
            decimal amount = 5.45m;
            string letter = "X";

            Console.WriteLine(helloWorld);
            Console.WriteLine("Columbus Sailed the world in {0}", number);
            Console.WriteLine("It is true that I have a {0}", dog);
            Console.WriteLine("Today is {0}",today);
            Console.WriteLine("I spent {0:C} on a cheesburger", amount);
            Console.WriteLine("{0} marks the spot", letter);

            Console.WriteLine("Enter any random number");
            string random = Console.ReadLine();
            int value;
            bool realNumber = int.TryParse(random, out value);
            if (realNumber)
            {
                Console.WriteLine($"Thanks, {value} is your real number.");
            }
            else 
            {
                Console.WriteLine("Sorry, this is not a number, please try again");
                while (!int.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine("The value must be a number");
                }
            }
            
     

            

        }
    }
}
