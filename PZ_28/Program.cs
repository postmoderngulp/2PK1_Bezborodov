namespace PZ_28
{ /* 
    2. Создайте консольное приложение, в котором присутствуют:
    a. Класс, в методе реализующий постепенное увеличение температуры в 
    диапазоне от -30 до +40
    b. Класс, отслеживающий температуру и выводящий информационные сообщении 
    при значениях -25, 0, +25, +35
   */


    internal class Program
    {
       



        public class seeTemp
        {
            public delegate void MyDelegate(seeTemp temp);
            static public event MyDelegate myEvent;
             public void seeMyEvent(seeTemp see) => myEvent.Invoke(see);
            int val;

            public seeTemp(int i)
            {
                val = i;
            }
            

            

            public void track()
            {
                myEvent += compare;
            }

            void compare(seeTemp temp)
            {
                switch (temp.val)
                {
                    case -25:
                        Console.WriteLine("Температура достигла -25 градусов.");
                        break;
                    case 0:
                        Console.WriteLine("Температура достигла 0 градусов.");
                        break;
                    case 25:
                        Console.WriteLine("Температура достигла +25 градусов.");
                        break;
                    case 35:
                        Console.WriteLine("Температура достигла +35 градусов.");
                        break;
                }
            }
        }

        class Uptemp
        {

            public seeTemp see = new seeTemp(-40);

            public void up_temp()
            {
                
                for (int i = -30; i < 40; i++)
                {

                    see.seeMyEvent(new seeTemp(i));

                }

            }
        }

        
       class Wait
        {
            public delegate void  MyDelegate(Wait wait);

            public event MyDelegate myEvent;

            public void seeWait(Wait wait) => myEvent.Invoke(wait);
            public int val;

            public Wait(int i)
            {
                val = i;
            }

            public void track()
            {
                myEvent += compare;
            }

            void compare(Wait obj)
            {
                switch (obj.val)
                {
                    case 200:
                        Console.WriteLine("Значение достигло 200");
                        break;
                    case 800:
                        Console.WriteLine("Значение достигло 800");
                        break;
                }
            }
        }


       class Counter
        {
            public Wait wait = new Wait(0);

            public void counter()
            {
                for (int i = 0; i < 1000; i++)
                {
                    wait.seeWait(new Wait(i));
                }
            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine("1 вариант");
            Counter counter = new Counter();
            counter.wait.track();
            counter.counter();

            Console.WriteLine("2 вариант");
            Uptemp uptemp = new Uptemp();
            uptemp.see.track();
            uptemp.up_temp();
            

        }
    }
}