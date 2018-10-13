using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive
{
    class Program
    {
        // write a fuction that calculated factorial without recursion
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int number = int.Parse(Console.ReadLine());
            double factorial = Factorial(number);
            Console.WriteLine("Factorial of " + number.ToString() + " = " + factorial.ToString());
        }
        public static double Factorial(int number)
        {
            if (number == 0)
                return 1;

            double factorial = 1;

            for (int i = number; i >= 1; i--)
            {
                factorial = factorial * i;

            }
            return factorial;
        }


        // factorial of a number using recursion

        //public static double Factorial(int number)
        //{
        //    if (number == 0)
        //        return 1;

        //    return number * Factorial(number - 1);

        //}


        // Write a function that find the files in a folder and in all sub-folders in the hierarchy using recursion.
        // We must use system.IO;
        public static void FindFiles(string path)
        {
            foreach (string fileName in Directory.GetFiles(path))
            {
                Console.WriteLine(fileName);
            }

            foreach (string directory in Directory.GetDirectories(path))
            {
                // FindFiles() is calling itself
                FindFiles(directory);
            }
        }

    }
}




