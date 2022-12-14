using static PZ_18.Program;

namespace PZ_18
{
    internal class Program
    {
        public enum Marks
        {
            Poorly = 1,
            Unsatisfactory = 2,
            Satisfactorily = 3,
            Good = 4,
            Great = 5
        }
        public enum Seasons
        {
            Winter,
            Spring,
            Summer,
            Autumn,
        }
        static void MarkFun(Marks mark)
        {
            switch (mark)
            {
                case Marks.Poorly:
                    Console.WriteLine($"характеристика отметки {(int)mark}: Очень плохо");
                    break;
                case Marks.Unsatisfactory:
                    Console.WriteLine($"характеристика отметки {(int)mark}: Неудовлетворительно");
                    break;
                case Marks.Satisfactorily:
                    Console.WriteLine($"характеристика отметки {(int)mark}: Удовлетворительно");
                    break;
                case Marks.Good:
                    Console.WriteLine($"характеристика отметки {(int)mark}: Хорошо");
                    break;
                case Marks.Great:
                    Console.WriteLine($"характеристика отметки {(int)mark}: Отлично");
                    break;
            }
        }
        static void SeasonFun(Seasons season)
        {
            switch (season)
            {
                case Seasons.Winter:
                    Console.WriteLine("праздники в данный промежуток:\n09.12 День Героев Отечества России" +
                        "\n12.12 День Конституции России\n22.12 День энергетика\n27.12 День спасателя России\n01.01 Новый год" +
                        "\n02.02 День сурка\n28.02 Масленица");
                    break;
                case Seasons.Spring:
                    Console.WriteLine("праздники в данный промежуток:\n08.03 Международный женский день" +
                        "\n25.03 День работников культуры России\n01.04 День смеха\n17.04 Вербное воскресение\n01.05 Праздник весны и труда" +
                        "\n09.05 День победы\n29.05 День химика");
                    break;
                case Seasons.Summer:
                    Console.WriteLine("праздники в данный промежуток:\n01.06 Международный день защиты детей в России" +
                        "\n01.06 День северного флота в России\n12.06 День России\n07.07 Иван Купала\n28.07 День Крещения Руси" +
                        "\n02.09 День воздушно-десантных войск\n13.09 День физкультурника");
                    break;
                case Seasons.Autumn:
                    Console.WriteLine("праздники в данный промежуток:\n01.09 День знаний" +
                        "\n05.09 День окончания Второй Мировой Войны\n13.09 День программиста России\n05.10 День учителя\n16.10 День Отца в России" +
                        "\n07.11 День Октябрьской революции\n22.11 День психолога в России");
                    break;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите отметку");
            try
            {
                int Mark = int.Parse(Console.ReadLine());
                if (Mark > 0 && Mark < 6)
                {
                    Marks NewMark = (Marks)Mark;
                    MarkFun(NewMark);
                }
                else
                {
                    Console.WriteLine("Вы должны ввести отметку от 1 до 5");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Вы должны ввести отметку от 1 до 5");
                throw;
            }

            Console.WriteLine("Введите время года на русском");
            try
            {
                string SeasonTime = Console.ReadLine();

                if (SeasonTime == "зима")
                {
                    SeasonFun(Seasons.Winter);
                }
                else if (SeasonTime == "весна")
                {
                    SeasonFun(Seasons.Spring);
                }
                else if (SeasonTime == "лето")
                {
                    SeasonFun(Seasons.Summer);
                }
                else if (SeasonTime == "осень")
                {
                    SeasonFun(Seasons.Autumn);
                }
                else
                {
                    Console.WriteLine("Вы должны  ввести время года на русском,в меньшем регистре!!");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Вы должны  ввести время года на русском,в меньшем регистре!!");
                throw;
            }

        }
        
    }
}