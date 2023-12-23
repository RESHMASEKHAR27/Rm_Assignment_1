using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rm_Assignment_1
{
    internal class WordLength15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Word:");
            string str = Console.ReadLine();

            int wordLength = str.Length;
            Console.WriteLine($"The length of the word is: {wordLength}");


        }
    }
}
