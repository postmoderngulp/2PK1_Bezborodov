using System.Collections.Generic;

namespace PZ_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fileStream = new FileStream(@"D:\text.txt", FileMode.Create);
            Console.WriteLine("Введите произвольную строку в ваш файл:");
            string str = Console.ReadLine();
            StreamWriter streamwriter = new StreamWriter(fileStream);
            streamwriter.Write(str);
            streamwriter.Close();

            FileStream fileStream2 = new FileStream(@"D:\text.txt", FileMode.OpenOrCreate);
            Console.WriteLine("Введите номер строки,которую хотели бы удалить");
            int K = int.Parse(Console.ReadLine());
            StreamReader streamReader = new StreamReader(fileStream2);
            string strFromFile = streamReader.ReadToEnd();
            streamReader.Close();


            string[] words = strFromFile.Split(' ');
            string[] newWords = new string[words.Length - 1];
            try
            {
                if (K == words.Length)
                {
                    for (int i = 0; i < newWords.Length; i++)
                    {
                        newWords[i] = words[i];
                        string NewWords = string.Join(' ', newWords);
                        File.Delete(@"D:\text.txt");
                        FileStream fileStream3 = new FileStream(@"D:\text.txt", FileMode.Create);
                        StreamWriter streamwriter2 = new StreamWriter(fileStream3);
                        streamwriter2.Write(NewWords);
                        streamwriter2.Close();
                    }
                }
                else
                {
                    for (int i = 0; i < K; i++)
                    {
                        newWords[i] = words[i];
                    }
                    for (int i = K++; i < words.Length; i++)
                    {
                        newWords[i - 1] = words[i];
                    }
                    string NewWords = string.Join(' ', newWords);
                    File.Delete(@"D:\text.txt");
                    FileStream fileStream3 = new FileStream(@"D:\text.txt", FileMode.Create);
                    StreamWriter streamwriter2 = new StreamWriter(fileStream3);
                    streamwriter2.Write(NewWords);
                    streamwriter2.Close();
                }
                
            }
            catch (Exception)
            {
                Console.WriteLine("Строки с таким номером нет");
            }
        }
    }

    
}