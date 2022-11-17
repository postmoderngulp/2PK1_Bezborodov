namespace PZ_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x километров,которые пробежал спортсмен в первый день:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число y,которое будет означать конечное расстояние,которое спортсмен преодолел за n дней ");
            int y = int.Parse(Console.ReadLine());
            int day = 1;
            while (x < y)
            {
                day++;
                x += ((x * 10) / 100);
            }
            Console.WriteLine($"Номер дня:{day}");
            Console.WriteLine(  );
        }
    }
}