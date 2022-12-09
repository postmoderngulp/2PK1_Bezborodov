using System;

namespace PZ__17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                int m = sizeof(double) / sizeof(byte);
                double[] array = new double[2];
                fixed (double* parray = &array[0])
                {

                    //перебор блоков памяти 1 элемента массива с помощью указателя
                    for (int k = 0; k < m; k++)
                    {
                        parray[k] = (byte)(k + 1);           //запись значения байтов в блок памяти 1 элемента массива
                        Console.Write("|" + parray[k]);    //вывод значения байтов 1 элемента массива
                    }
                    Console.WriteLine("|");
                    Console.WriteLine(*parray);//вывод значения 1 элемента массива 

                }
                fixed (double* parray = &array[1])
                {


                    //перебор блоков памяти 2 элемента массива с помощью указателя
                    for (int k = 8; k < m*2; k++)
                    {
                        parray[k] = (byte)(k + 1);           //запись значения байтов в блок памяти 2 элемента массива
                        Console.Write("|" + parray[k]);    //вывод значения байтов 2 элемента массива
                    }
                    Console.WriteLine("|");
                    Console.WriteLine(*parray);//вывод значения 2 элемента массива 

                }
                //В результате получаем ответ: array[0] = 1,а array[1] = 2,
                //такие значения были получены из-за организованных нами ячеек памяти:
                //|1|2|3|4|5|6|7|8| и |9|10|11|12|13|14|15|16| - ячейки памяти для 1 и 2 элементов массива соответственно 
            }

        }
    }
}