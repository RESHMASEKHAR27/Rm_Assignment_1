using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rm_Assignment_1
{
    internal class Twonumbers03
    {
        static void Main()
        {
            int i,num1, num2,n;
            int Count = 0;

            Console.WriteLine("Enter the first number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            num2 = Convert.ToInt32(Console.ReadLine());

            for (i = num1; i<= num2; i++)
                {
                Console.Write($"{i} ");
            }
            
        }
    }
}
