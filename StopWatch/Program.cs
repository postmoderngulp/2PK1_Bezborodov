using System.Diagnostics;

/*
 По результатам измерений структуры оказались быстрее по причине 
нахождения напрямую в стеке,большое количество класов 
в куче достаточно тяжело перезаписывать и создавать,из-за опосредованного обращения по ссылке
,а не напрямую как в случае со структурами
 */
namespace StopWatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();
            Class[] arrCL = new Class[2500];
            for (int i = 0; i < arrCL.Length; i++)
            {
                arrCL[i] = new Class();
                Thread.Sleep(10);

            }
            sw.Stop();
            Console.WriteLine($" cl: {sw.ElapsedMilliseconds} milsec");


            sw.Restart();
            Struct[] arrST = new Struct[2500];
            for (int i = 0; i < arrCL.Length; i++)
            {
                arrST[i] = new Struct();
                Thread.Sleep(10);

            }
            sw.Stop();
            Console.WriteLine($" st: {sw.ElapsedMilliseconds} milsec");


            sw.Restart();
            for (int i = 0; i < arrCL.Length; i++)
            {
                arrCL[i].ID = i;
                Thread.Sleep(10);

            }
            sw.Stop();
            Console.WriteLine($" change cl: {sw.ElapsedMilliseconds} milsec");

            sw.Restart();
            for (int i = 0; i < arrCL.Length; i++)
            {
                arrST[i].ID = i;
                Thread.Sleep(10);

            }
            sw.Stop();
            Console.WriteLine($" change st: {sw.ElapsedMilliseconds} milsec");
        }
    }
}