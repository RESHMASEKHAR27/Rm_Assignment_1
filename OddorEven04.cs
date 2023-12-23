using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rm_Assignment_1
{
    internal class OddorEven04
    {
        static void Main()
        {

            int num;
            Console.WriteLine("Enter a number:");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("The given number is Even");
            }
            else
            {
                Console.WriteLine("The given number is Odd");
            }
        }
    }
}
