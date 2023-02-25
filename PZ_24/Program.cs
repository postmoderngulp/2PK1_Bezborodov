namespace PZ_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pc = new Computer(id: 1,totalMemory: 1024);
            Console.WriteLine(pc.ID);
            var pc2 = (Computer)pc.Clone();
            pc2.ID = 5;
            Console.WriteLine(pc.ID);
            Console.WriteLine(pc2.ID);


            var tf = new Smartphone(id: 4, totalMemory: 128, procFrequency: 3.2, diagonal:5.6,diapazon:3);
            Console.WriteLine(tf.Diagonal);
            var tf2 = (Smartphone)tf.Clone();
            tf2.Diagonal = 6;
            Console.WriteLine(tf2.Diagonal);
            Console.WriteLine(tf.Diagonal);
        }
    }
}