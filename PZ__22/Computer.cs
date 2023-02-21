using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_22
{
    class Computer
    {
        public double ID;
        public double totalHDDMemory;
        public double processorFrequency;
        public static double SumOfMemory;
        public Computer()
        {

        }
        public Computer(int id, double totalMemory, double procFrequency)

        {
            if (procFrequency >= 1.5 && procFrequency <= 5.0)
            {
                processorFrequency = procFrequency;
            }
            else
            {
                processorFrequency = 0;
            }
            totalHDDMemory = totalMemory;
            ID = id;
        }
        public Computer(int id, double totalMemory)
        {
            ID = id;
            totalHDDMemory = totalMemory;
        }
        public Computer(double totalMemory, double procFrequency)
        {
            if (procFrequency >= 1.5 && procFrequency <= 5.0)
            {
                processorFrequency = procFrequency;
            }
            else
            {
                processorFrequency = 0;
            }
            totalHDDMemory = totalMemory;
        }

        public void GetCompName()
        {
            Console.WriteLine($"ID:{ID}");
            Console.WriteLine($"totalHDDMemory:{totalHDDMemory}Gb");
            Console.WriteLine($"processorFrequency:{processorFrequency}Ghz");
            Console.WriteLine();
        }
    }
}
