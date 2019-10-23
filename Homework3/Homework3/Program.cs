using System;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("Please select, if you want to convert Celsius into Fahrenheit \"CF\" or Fahrenheit into Celsius \"FC\": ");
            string userInput;
            userInput = Console.ReadLine().ToUpper();
            Console.WriteLine($"You choose to convert {userInput}.");
            Temperatuur(userInput);

        }
        public static void Temperatuur(string userAnswer)
        {
            if (userAnswer == "CF")
            {
                double fahrenheit;
                Console.WriteLine("Enter the amount of celsius: ");
                fahrenheit = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Fahrenheit = {0}", fahrenheit * 9 / 5 + 32);
                Console.ReadLine();
            }
            else if (userAnswer == "FC")
             {
                double celsius;
                Console.WriteLine("Enter the amount of fahrenheit: ");
                celsius = Convert.ToDouble(Console.ReadLine());
                celsius = (celsius - 32) * 5 / 9;
                Console.WriteLine("Celsius = " + celsius);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid entry!");
            }
        }
    }
}
