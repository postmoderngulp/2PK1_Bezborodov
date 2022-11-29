using System;

namespace PZ_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fileStream = new FileStream(@"D:\newFile.txt", FileMode.Create);
            Console.WriteLine("Введите произвольную строку в ваш файл:");
            string str = Console.ReadLine();
            StreamWriter streamwriter = new StreamWriter(fileStream);
            streamwriter.Write(str);
            streamwriter.Close();

            FileStream fileStream2 = new FileStream(@"D:\newFile.txt", FileMode.OpenOrCreate);
            StreamReader streamReader = new StreamReader(fileStream2);
            string strFromFile = streamReader.ReadToEnd();
            streamReader.Close();


            string[] words = strFromFile.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                string stroke = words[i];
                if (stroke[0] == stroke[stroke.Length - 1])
                {
                    Console.WriteLine(stroke + "\n");
                }
            }
        }
    }
}