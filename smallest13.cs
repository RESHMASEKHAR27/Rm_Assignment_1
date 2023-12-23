using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rm_Assignment_1
{
    internal class smallest13
    {

        static void Main()
        {
            int TotalNumbers = 5;

            double[] numbers = new double[TotalNumbers];

           
            for (int i = 0; i < TotalNumbers; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = Convert.ToDouble(Console.ReadLine());
            }

            
            double smallestNumber = numbers[0];

            for (int i = 1; i < TotalNumbers; i++)
            {
                if (numbers[i] < smallestNumber)
                {
                    smallestNumber = numbers[i];
                }
            }

            
            Console.WriteLine($"The smallest number is: {smallestNumber}");
        }
    }

}

