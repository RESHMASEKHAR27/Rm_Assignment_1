using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Rm_Assignment_1
{
    internal class TenMarks14
    {

        static void Main()
        {

            int TotalInput = 10;

            double total = 0;
            double[] marks = new double[TotalInput];

            for (int i = 0; i < TotalInput; i++)
            {
                Console.Write($"Enter mark {i + 1}: ");
                marks[i] = Convert.ToDouble(Console.ReadLine());
                total += marks[i];
            }

         
            double average = total / TotalInput;
            double minMark = marks[0];
            double maxMark = marks[0];

            for (int i = 1; i < TotalInput; i++)
            {
                if (marks[i] < minMark)
                {
                    minMark = marks[i];
                }

                if (marks[i] > maxMark)
                {
                    maxMark = marks[i];
                }
            }

           
            Array.Sort(marks);

       
            Console.WriteLine($"Total: {total:F}");
            Console.WriteLine($"Average: {average:F2}");
            Console.WriteLine($"Minimum Mark: {minMark}");
            Console.WriteLine($"Maximum Mark: {maxMark}");

            Console.WriteLine("\nMarks in ascending order:");
            foreach (double mark in marks)
            {
                Console.WriteLine(mark);
            }

            Console.WriteLine("\nMarks in descending order:");
            Array.Reverse(marks);
            foreach (double mark in marks)
            {
                Console.WriteLine(mark);
            }


        }
    }
}
