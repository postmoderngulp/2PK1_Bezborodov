namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string  enemy = "5";
            string[,] map = new string[25, 25];
            for (int i = 0; i < 10; i++)
            {
                map[random.Next(25), random.Next(25)] = enemy;
            }

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}