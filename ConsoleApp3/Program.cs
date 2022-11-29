namespace ConsoleApp3
{
    internal class Program
    {
       
            private static double a = 7;
        static void rec2(double n, double i)
        {
            if (i < n)
            {
                double shag = 5;
                i++;
                a += (Math.Pow(a, shag));
                rec2(n, i);
            }
            else if (i == n)
            {
                Console.WriteLine(a);
            }
        }
        static void Main(string[] args)
        {
            double i = 0;
            Console.WriteLine("Введите n-ый член прогрессии");
            double n1 = double.Parse(Console.ReadLine());
            rec2(n1, i);
            Console.ReadKey();
        }

    }
}
