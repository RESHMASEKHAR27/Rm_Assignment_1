using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rm_Assignment_1
{
    internal class Oddeven05
    {
        static void Main()
        {

                int[] arr = new int[5];
                int oddcount = 0, evencount = 0;

                Console.WriteLine("Enter Array Values");
                for (int i = 0; i < 5; i++)
                {
                    arr[i] = Convert.ToInt16(Console.ReadLine());
                }

                for (int i = 0; i < 5; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                    evencount++;
                    }
                    else
                    {
                    oddcount++;
                    }
                }
                Console.WriteLine("Total Even Numbers:" + evencount);
                Console.WriteLine("Total Odd Numbers:" + oddcount);
                Console.ReadLine();
            }

        }

}

