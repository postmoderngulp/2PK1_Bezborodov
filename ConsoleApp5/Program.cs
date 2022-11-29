namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = {"ed","wdefdfsw"};
            for (int i = 0; i < array.Length; i++)
            {
                string str = array[i];
                if (str[0] == str[str.Length-1])
                {
                    Console.WriteLine(str);
                }
            }

        }
    }
}