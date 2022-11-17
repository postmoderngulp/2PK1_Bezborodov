namespace PZ_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2 вариант\n");
            Console.WriteLine("1 задание");
            for (int s = 0; s <= 90; s += 5)
            {
                Console.WriteLine(s);

            }
            Console.WriteLine();

            Console.WriteLine("2 задание");
            char al = 'b';
            for (char g = al; g <= 'h'; g++)
            {
                Console.WriteLine(g);
            }
            Console.WriteLine();

            Console.WriteLine("3 задание");
            for (int v = 0; v < 5; v++)
            {
                for (int w = 0; w < 4; w++)
                {
                    Console.Write('#' + " ");

                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("4 задание");
            for (int p = 0; p <= 100; p++)
            {
                if (p % 7 == 0)
                {
                    Console.WriteLine(p);
                }
            }
            Console.WriteLine();

            Console.WriteLine("5 задание");
            for (int i = 1, j = 40; j - i != 21; i++, j--)
            {
                Console.WriteLine($"i:{i} j:{j}");
            }

        }
    }
}

