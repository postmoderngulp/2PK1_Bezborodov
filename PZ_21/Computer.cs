using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_21
{
    class Computer
    {
        int ID;
        double totalHDDMemory;
        double processorFrequency;

        public Computer()
        {

        }
        public Computer(int id,double totalMemory,double procFrequency)
        {
            ID = id;
            totalHDDMemory = totalMemory;
            processorFrequency = procFrequency;
        }
        public Computer(int id, double totalMemory)
        {
            ID = id;
            totalHDDMemory = totalMemory;
        }
        public Computer(double totalMemory, double procFrequency)
        {
            totalHDDMemory = totalMemory;
            processorFrequency = procFrequency;
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
