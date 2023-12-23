using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rm_Assignment_1
{
    internal class Largest12
    { 
            static void Main()
            {
                int TotalNumbers = 3;

                double[] numbers = new double[TotalNumbers];

                
                for (int i = 0; i < TotalNumbers; i++)
                {
                    Console.Write($"Enter number {i + 1}: ");
                    numbers[i] = Convert.ToDouble(Console.ReadLine());
                }

                
                double largestNumber = numbers[0];

                for (int i = 1; i < TotalNumbers; i++)
                {
                    if (numbers[i] > largestNumber)
                    {
                        largestNumber = numbers[i];
                    }
                }

                
                Console.WriteLine($"The largest number is: {largestNumber}");
            }

    }
}

