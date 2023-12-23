using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rm_Assignment_1
{
    internal class Palindriome18
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Word:");
            string str = Console.ReadLine();

            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            string str_reverse = new string(arr);

            if (str.Equals(str_reverse))
            {
                Console.WriteLine($"{str} is a Palindrome");

            }
            else
            {
                Console.WriteLine($"{str} is not a palindrome");
            }




        }
    }
}
