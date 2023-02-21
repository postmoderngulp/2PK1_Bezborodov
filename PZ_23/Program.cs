using System;

namespace PZ_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Smartphone smart = new Smartphone(id: 4, totalMemory: 1024, procFrequency: 4.5, diagonal: 6.5, diapazon: 5);
            smart.GetCompName();

            Console.WriteLine(smart.ID);

        }
    }
}