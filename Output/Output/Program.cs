using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[3][];

           
            jaggedArray[0] = new int[] { 10, 20, 30 };
            jaggedArray[1] = new int[] { 5, 15 };
            jaggedArray[2] = new int[] { 1, 2, 3, 4 };

            // Printing the jagged array
            Console.WriteLine("Jagged Array Output:");

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write("Row " + i + ": ");
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
    }

