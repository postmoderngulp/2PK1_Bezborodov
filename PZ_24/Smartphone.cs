using PZ_24;
using System;
using System.Collections.Generic;
using System.Text;

namespace PZ_24
{
    public class Smartphone : Computer 
    {
        public double Diagonal;
        public double Diapazon;

        public Smartphone()
        {

        }
        public Smartphone(int id, double totalMemory, double procFrequency)
        {
            ID = id;
            totalHDDMemory = totalMemory;
            processorFrequency = procFrequency;
        }
        public Smartphone(int id, double totalMemory)
        {
            ID = id;
            totalHDDMemory = totalMemory;
        }
        public Smartphone(double totalMemory, double procFrequency)
        {
            totalHDDMemory = totalMemory;
            processorFrequency = procFrequency;
        }


        public Smartphone(int id, double totalMemory, double procFrequency, double diagonal, double diapazon)
        {
            Diagonal = diagonal;
            Diapazon = diapazon;
            ID = id;
            totalHDDMemory = totalMemory;
            processorFrequency = procFrequency;
        }

        public override void GetCompName()
        {
            Console.WriteLine($"ID:{ID}");
            Console.WriteLine($"totalHDDMemory:{totalHDDMemory}Gb");
            Console.WriteLine($"processorFrequency:{processorFrequency}Ghz");
            Console.WriteLine($"Diagonal:{Diagonal} Dm");
            Console.WriteLine($"Diapazon:{Diapazon} Ghz");
            Console.WriteLine();
        }

         public override object Clone()
        {
            return MemberwiseClone();
        }
    }
}