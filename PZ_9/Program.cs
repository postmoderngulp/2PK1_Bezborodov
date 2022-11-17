using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_9
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            string[][] array = new string[5][];
            int k = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i] = new string[k = random.Next(2, 25)];
                for (int j = 0; j < k; j++)
                {
                    array[i][j] = random.Next(2, 25).ToString();
                    Console.Write(array[i][j] + " ");

                }
                Console.WriteLine();
            }
            Console.WriteLine();
            String[] array2 = new string[array.GetLength(0)];
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = array[i][array[i].Length - 1];
                Console.WriteLine(array2[i] + " ");

            }
            Console.WriteLine();

            Console.WriteLine("максимально значение : ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write((array2[i] = array[i].Max() + " "));
            }
            Console.WriteLine();


            string firstValue = "";
            string maxValue = "";
            for (int i = 0, j = 0; i < array.GetLength(0); i++)
            {
                maxValue = array[i].Max();
                int index = Array.IndexOf(array[i], maxValue);
                firstValue = array[i][j];
                array[i][j] = array[i].Max();
                array[i][index] = firstValue;
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();



            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = array[i].Length - 1; j >= 0; j--)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int amount = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write($"{i + 1} : {array[i].Length}" + " ");
                Console.WriteLine();
            }

        }
    
    }
}
