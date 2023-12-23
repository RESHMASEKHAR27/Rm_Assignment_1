using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rm_Assignment_1
{
    internal class Temp06
    {
      
        static void Main()
        {
           
            Console.Write("Enter temperature in Fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            
            double celsius = (fahrenheit - 32) * 5 / 9;

           
            Console.WriteLine($"Temperature in Celsius: {celsius:F2}°C");
        }
    }

}

