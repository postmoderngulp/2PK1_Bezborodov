namespace PZ_23
    {
        public class Computer
        {
            public int ID;
            public double totalHDDMemory;
            public double processorFrequency;

            public Computer()
            {

            }
            public Computer(int id, double totalMemory, double procFrequency)
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

            virtual public void GetCompName()
            {
                Console.WriteLine($"ID:{ID}");
                Console.WriteLine($"totalHDDMemory:{totalHDDMemory}Gb");
                Console.WriteLine($"processorFrequency:{processorFrequency}Ghz");
                Console.WriteLine();
            }
        }
    }

