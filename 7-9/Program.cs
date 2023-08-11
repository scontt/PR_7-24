using System;

namespace ConsoleApp
    {
        public class Program
        {
            static void Main()
            {
                string name;
                double a, b;
                Console.Write("Введите ваше имя: ");
                Console.ForegroundColor = ConsoleColor.Red;
                name = Console.ReadLine();
                Console.ResetColor();

                Console.WriteLine($"Здравствуй, {name}. Эта программа находит ответ выражения a = (y-cos(4x))/(2sin^2(x)+ytg^3(z))");

                Console.Write("Введите x: ");
                Console.ForegroundColor = ConsoleColor.Red;
                float x = (float)Convert.ToDouble(Console.ReadLine());
                Console.ResetColor();
                Console.Write("Введите y: ");
                Console.ForegroundColor = ConsoleColor.Red;
                long y = (long)Convert.ToDouble(Console.ReadLine());
                Console.ResetColor();
                Console.Write("Введите z: ");
                Console.ForegroundColor = ConsoleColor.Red;
                double z = Convert.ToDouble(Console.ReadLine());
                Console.ResetColor();

                a = (y - Math.Cos(4 * x)) / (2 * Math.Pow(Math.Sin(x), 2) + y * Math.Pow(Math.Tan(z), 3));
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"Вычисляемое выражение: a = (y-cos(4x))/(2sin^2(x)+ytg^3(z)) = ({y}-cos(4*{x}))/(2sin^2({x})+{y}tg^3({z})) = ");

                Console.Write("{0:<####.##>;[####.##];ноль}", a);
                Console.WriteLine($", при x = {x}, y = {y}, z = {z}");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("a = {0:C} - денежный формат", a);
                Console.WriteLine($"a = {a} - десятичный формат");
                Console.WriteLine("a = {0:E} - научный формат\n", a);
                

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Текущая дата и время: {0:hh'/'mm'/'ss dd-mm-yyyy}", DateTime.Now);

                Console.WriteLine($"Всего доброго, {name}");
                Console.ResetColor();
            }
        }
    }
