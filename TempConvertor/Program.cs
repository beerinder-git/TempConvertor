using System;

namespace TempConvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            while (true)
            {
                Console.WriteLine("1. Convert to Fehrenheit");
                Console.WriteLine("2. Convert to Celsius");
                Console.WriteLine("Please select the Option: ");

                int option = Convert.ToInt32(Console.ReadLine());
                double value = 0.0;
                double temperature = 0.0;

            
                switch (option)
                    {
                    case 1:
                        Console.WriteLine("Enter temperature in Celsius ");
                        value = Convert.ToInt32(Console.ReadLine());
                        temperature = (value * 9/5) + 32;
                        Console.WriteLine("Temperature in Celsius: " + temperature + "F");
                        break;
                    case 2:
                        Console.WriteLine("Enter temperature in Fehrenheit ");
                        value = Convert.ToInt32(Console.ReadLine());
                        temperature = (value - 32 ) * 0.5;
                        Console.WriteLine("Temperature in Celsius: " + temperature + "C");
                        break;
                
                    default:
                        break;
                }
            }
        }
    }
}
