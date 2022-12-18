using System.Text.RegularExpressions;

namespace PZ_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text1 = "1 RU161109-472905 PACK19697671 1 Ольга Каверзина +7 (918) 335-43-52 Наличные Плюс 0 \r\n09:00 - 13:00 Краснодар, красина, Дом 3/3, Кв. 76\r\n" +
                "2 RU161110-466130 PACK19651968 1 Софья назаретян +7 (918) 398-07-81 Наличные Плюс 0" +
                " \r\n09:00 - 13:00 Краснодар, Базовская, Дом д.61\r\n3 RU161111-260536 PACK19698066 3 Виктор Кипуров +7 (918) 441-97-56 Наличные Плюс 0 \r\n" +
                "09:00 - 13:00 Краснодар, Речная,Чехова , Дом 4, Кв. 52" +
                "\r\n4 RU161111-522664 PACK19697905 2 Ирина Концевик +7 (918) 045-77-00 Наличные Плюс 0 \r\n" +
                "09:00 - 13:00 Краснодар, ул им Братьев Дроздовых, Дом 41, Кв. 19\r\n5 RU161111-252357 PACK19697840 1 Ирина Концевик +7 (918) 045-77-00 Наличные Плюс 0 \r\n" +
                "09:00 - 13:00 Краснодар, ул им Братьев Дроздовых, Дом 41, Кв. 19\r\n" +
                "6 RU161104-298585 PACK19514804 3 Роман +7 (938) 435-93-29 Наличные Плюс 0 09:00 - 13:00 \r\nКраснодар, фурманова, Дом 62 9.11";


            string text2 = "213.180.195.231 - - [29/Jan/2007:00:07:17 +0000] \"GET /excel/lsn015.html HTTP/1.1\" 200 18918 \"-\r" +
                "\n\" \"YaDirectBot/1.0\"\r\n74.6.71.37 - - [29/Jan/2007:00:13:03 +0000] \"GET /eralash HTTP/1.0\" 301 317 \"-\" \"Mozilla/5.0 " +
                "\r\n(compatible; Yahoo! Slurp; http://help.yahoo.com/help/us/ysearch/slurp)\"\r\n74.6.71.37 - - [29/Jan/2007:00:13:06 +0000] " +
                "\"GET /eralash/ HTTP/1.0\" 200 12234 \"-\" \"Mozilla/5.0\r\n(compatible; Yahoo! Slurp; http://help.yahoo.com/help/us/ysearch/slurp)\"" +
                "\r\n213.186.116.166 - - [29/Jan/2007:00:26:51 +0000] \"GET /eralash/soft/speed.zip HTTP/1.0\" 200 " +
                "\r\n217872 \"-\" \"Wget/1.10.2 (Red Hat modified)\"\r" +
                "\n213.180.207.25 - - [29/Jan/2007:00:27:14 +0000] \"" +
                "GET /robots.txt HTTP/1.1\" 200 54 \"-\" \r\n\"Yandex/1.01.001 (compatible; Win16; I)\"";

            Console.WriteLine("1 Задание");
            string Pattern = @"([А-Я][а-я]+\s?[А-Я][а-я]+)\s[+7]";

            Regex regex = new Regex(Pattern);
            foreach (Match match  in regex.Matches(text1))
            {
                Console.WriteLine(match.Value);
            }

            Console.WriteLine("2 Задание");

            FileStream file = new FileStream("D:\\connects.log",FileMode.Open);
            StreamReader reader = new StreamReader(file);
            string text = reader.ReadToEnd();
            file.Close();

            string IpPattern = @"(\d+[.]+\d+[.]\d+[.]\d+\s)";
            Console.WriteLine("Ip-адреса:");
            Regex regexIp = new Regex(IpPattern);
            foreach (Match match  in regexIp.Matches(text))
            {
                Console.WriteLine(match.Value);
            }

            string DatePattern = @"(\d+[/]\w+[/]\d+)";

            Console.WriteLine("Даты:");
            Regex regexDate = new Regex(DatePattern);
            foreach (Match match   in regexDate.Matches(text))
            {
                Console.WriteLine(match.Value);
            }


        }
    }
}