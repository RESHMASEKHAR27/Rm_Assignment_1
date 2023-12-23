using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rm_Assignment_1
{
    internal class Reverseword16
    {

        static void Main()
        {
            
            Console.WriteLine("Enter First Word:");
            string str = Console.ReadLine();

            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
           
            string str_reverse = new string(arr);

            Console.WriteLine(str_reverse);



        }
    }
}
