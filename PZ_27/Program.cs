namespace PZ_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] stud1 = new Student[10];
            Console.WriteLine("Заполните список студентов");
            for (int i = 1; i < stud1.Length + 1; i++)
            {
                Console.WriteLine($"Студент №{i}:");
                Console.Write($"Заполните фамилию и инициалы студента №{i}:");
                stud1[i].Name = Console.ReadLine();
                Console.Write($"Заполните номер группы студента №{i}:");
                stud1[i].Group = int.Parse(Console.ReadLine());
                Console.Write($"Заполните успеваемость студента №{i}:");
                for (int j = 1; j < stud1[i].Ses.Length + 1; j++)
                {
                    Console.Write($"Введите {j}-ую оценку студента №{i}");
                    stud1[i].Ses[j] = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}