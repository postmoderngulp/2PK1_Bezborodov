namespace PZ_22

    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Computer pc1 = new Computer(id: 1, totalMemory: 1024, procFrequency: 1.7);
                Computer pc2 = new Computer(id: 2, totalMemory: 102, procFrequency: 1.0);
                Computer pc3 = new Computer(id: 3, totalMemory: 124, procFrequency: 2.9);
                Computer pc4 = new Computer(id: 4, totalMemory: 24, procFrequency: 3.7);
                Computer pc5 = new Computer(id: 5, totalMemory: 4, procFrequency: 6.7);

                Computer.SumOfMemory = pc1.totalHDDMemory + pc2.totalHDDMemory + pc3.totalHDDMemory + pc4.totalHDDMemory + pc5.totalHDDMemory;
                Console.WriteLine($"Сумма памяти всех пк {Computer.SumOfMemory} гб");
            }
        }
   }
