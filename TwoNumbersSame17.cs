using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rm_Assignment_1
{
    internal class TwoNumbersSame17
    {
        static void Main(string[] args)
        {

            string str1, str2;

            Console.WriteLine("Enter First Word:");
            str1 =  Console.ReadLine();

            Console.WriteLine("Enter Second Word:");
            str2 = Console.ReadLine();

            if(str1 == str2)
            {
                Console.WriteLine("The given Words are Equal");

            }
            else
            {
                Console.WriteLine("The given Words are not equal");
            }
        }
    }
}
