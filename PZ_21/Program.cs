namespace PZ_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer pc1 = new Computer();
            Computer pc2 = new Computer(8800,512,3.2);
            Computer pc3 = new Computer(2900,256);
            Computer pc4 = new Computer( totalMemory :1024,4.4);

            pc1.GetCompName();
            pc2.GetCompName();
            pc3.GetCompName();
            pc4.GetCompName();
        }
    }
}