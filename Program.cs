// Assignment 3.2 Hurricane Category 
// By Addison Roy

using System;
class Program
{
    static void Main()
    {
        Console.Write("Simple Hurricane Category Calculator\n");
        Console.Write("Based on Saffir-Simpson Scale\n");
        Console.Write("Enter the wind speed (in MPH): ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double windSpeed))
        {
            if (windSpeed >= 74 && windSpeed <= 95)
            {
                Console.WriteLine("Category 1 Hurricane");
            }
            else if (windSpeed >= 96 && windSpeed <= 110)
            {
                Console.WriteLine("Category 2 Hurricane");
            }
            else if (windSpeed >= 111 && windSpeed <= 129)
            {
                Console.WriteLine("Category 3 Hurricane");
            }
            else if (windSpeed >= 130 && windSpeed <= 156)
            {
                Console.WriteLine("Category 4 Hurricane");
            }
            else if (windSpeed >= 157)
            {
                Console.WriteLine("Category 5 Hurricane");
            }
            else
            {
                Console.WriteLine("not a hurricane.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input (Just Enter a number!)");
        }
    }
}
