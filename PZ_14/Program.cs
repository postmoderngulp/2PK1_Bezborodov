namespace PZ_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 задание");
            Z1();
            Console.WriteLine("2 задание");
            Z2();
            Console.WriteLine("3 задание");
            Z3();
            Console.WriteLine("4 задание");
            Z4();
        }








        private static int result = 2;
        static void Z1()
        {
            int i = 0;
            Console.WriteLine("Введите n-ый член");
            int number = int.Parse(Console.ReadLine());
            arithmetic(number, i);
        }
        static void arithmetic(int n, int i)
        {


            if (i < n)
            {
                int step = 6;
                i++;
                result += step;
                arithmetic(n, i);
            }
            else if (i == n)
            {
                Console.WriteLine(result);
            }

        }




        private static double result2 = 2;
        static void Z2()
        {
            double i = 0;
            Console.WriteLine("Введите n-ый член");
            double number = double.Parse(Console.ReadLine());
            geometric(number, i);
        }
        static void geometric(double n, double i)
        {
            if (i < n)
            {
                double step = 0.5;
                i++;
                result2 = Math.Pow(result2, step);
                geometric(n, i);
            }
            else if (i == n)
            {
                Console.WriteLine(result2);
            }

        }

        static void Z3()
        {

            Console.WriteLine("Введите число A");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число B");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine();
            OrderInference(A, B);

        }

        static void OrderInference(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine(a);
                a--;
                OrderInference(a, b);
            }
            else if (a < b)
            {
                Console.WriteLine(a);
                a++;
                OrderInference(a, b);
            }
            else if (a == b)
            {
                Console.WriteLine(a);
            }
        }





        private static int result3 = 0;
        static void Z4()
        {
            Console.WriteLine("Введите число n до которого нужно вывести последовательность");
            int n = int.Parse(Console.ReadLine());
            Summ(n);
        }

        static void Summ(int x)
        {
            if (x > 1)
            {
                result3 += x;
                x--;
                Summ(x);
            }
            else if (x == 1)
            {
                result3 += x;
                Console.WriteLine($"Сумма от введеного числа  до 1 составляет: {result3}");
            }
        }
    }
}