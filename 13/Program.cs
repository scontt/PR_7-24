using System;
using System.Collections.Specialized;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            double i = 0, 
                sum = 0,
                s = 0, 
                e;
            int p;
            string name;

            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            Console.WriteLine($"Здравствуйте, {name}, данная программа вычисляет сумму бесконечного ряда с заданной точностью");

            s = 1 / (Math.Pow(4, i) + Math.Pow(5, i + 2));
            for ( ; ; )
            {
                Console.WriteLine("Выберите пункт меню: " +
                "\n1. Вычислить бесконечную сумму с заданной точностью;" +
                "\n2. Выйти из программы.");
                do
                {
                    p = Convert.ToInt32(Console.ReadLine());
                } while (p != 1 && p != 2);
                switch (p)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("1. Вычислить бесконечную сумму с заданной точностью;");
                            Console.Write("Введите точность Е (от 0,00000001 до 0,0384): ");
                            e = Convert.ToDouble(Console.ReadLine());
                            while (Math.Abs(s) > e)
                            {
                                sum += s;
                                Console.WriteLine($"Шаг i: {i}; \tСлагаемое: {s}; \nСумма равна {sum}");
                                i++;
                                s = 1 / (Math.Pow(4, i) + Math.Pow(5, i + 2));
                            }
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("2. Выйти из программы.");
                        break;
                }
                break;
            }
            Console.WriteLine($"Всего доброго, {name}");
        }
    }
}