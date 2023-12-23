using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rm_Assignment_1
{
    internal class Series07
    {
        static void Main()
        {
            Console.WriteLine("Series: ");

            for (int i = 0; i <= 25; i++)
            {
                int result = i * i;
                Console.Write($"{result} ");

               
                if (i < 25)
                {
                    Console.Write(", ");
                }
            }
        }
    }

}

