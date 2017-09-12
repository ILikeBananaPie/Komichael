using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgrammingFunsies
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("String to be inverted: ");
            //string input = Console.ReadLine();

            string output = string.Empty;

            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    output = output + input[i];
            //}

            //Console.Write("\n\nOutput test 1: ");
            //Console.WriteLine("{0}\n\n", output);

            //Console.ReadKey();

            //output = string.Empty;

            //char[] splitter = {' '};

            //string[] words = input.Split(splitter);

            //for (int i = words.Length - 1; i >= 0; i--)
            //{
            //    output = output + words[i] + " ";
            //}

            //Console.Write("\n\nOutput test 3: ");
            //Console.WriteLine("{0}\n\n", output);

            //Console.ReadKey();

            Random rnd = new Random();
            int arrayLength = rnd.Next(5,20);
            int[] integers = new int[arrayLength];
            for (int i = integers.Length - 1; i >= 0; i--)
            {
                integers[i] = rnd.Next(9999);
            }

            int highest = 0;
            Console.Write("Current ints: ");
            foreach (int x in integers)
            {
                Console.Write("{0}, ", x);
                if (x > highest)
                {
                    highest = x;
                }
            }

            Console.Write("\n\n\n");

            Console.Write("Highest number being: {0}\n\n", highest);

            Console.ReadKey();
        }
    }
}
