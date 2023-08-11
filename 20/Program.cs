using System;

public struct SPORT // Объявление структуры SPORT
{
    public string name, counrty, date;
    public int[] weight;
}

class Program
{
    static void Main()
    {
        SPORT a; // Объявление переменной типа структура
        string username;
        int key, g = 0;
        float kg = 0;

        a.name = "";
        a.counrty = "";
        a.date = "";
        a.weight = new int[5];

        Console.Write("Введите имя: ");
        username = Console.ReadLine();

        for ( ; ; )
        {
            do
            {
                Console.Clear();
                Console.WriteLine($"Здравствуйте, {username}, данная программа позволяет ввести данные о спортсмене пятиборце" +
                    $" и вывести данные о нем.");
                Console.Write("Выберите пункт:\n" +
                    "1. Ввести данные о спортсмене\n" +
                    "2. Вывести данные на экран\n" +
                    "3. Выйти из программы\n" +
                    "Ввод: ");
                key = Convert.ToInt32(Console.ReadLine());
            } while (key != 1 && key != 2 && key != 3);
            switch (key)
            {
                case 1: // 1. Ввести данные о спортсмене
                    {
                        Console.Clear();
                        Console.WriteLine("1. Ввести данные о спортсмене");
                        Console.Write("Имя спортсмена: ");
                        a.name = Console.ReadLine();
                        Console.Write("Страна, проводившая чемпионат: ");
                        a.counrty = Console.ReadLine();
                        Console.Write("Дата проведения чемпионата: ");
                        a.date = Console.ReadLine();
                        Console.WriteLine("Вес в граммах, потерянный спортсменом после пяти этапов соревнований: ");
                        for (int i = 0; i < a.weight.Length; i++) // Заполнение массива с потерянным весом
                        {
                            Console.Write($"{i + 1} этап: ");
                            a.weight[i] = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    Console.Write("Нажмите любую клавишу... ");
                    Console.ReadKey();
                    break;
                case 2: // 2. Вывести данные в консоль
                    {
                        Console.Clear();
                        Console.WriteLine("1. Вывести данные на экран");
                        Console.Write($"Имя спортсмена-пятиборца: {a.name} \nСтрана, проводившая чемпионат: {a.counrty}" +
                            $"\nДата проведения чемпионата: {a.date} \nВес, потерянный спортсменом в граммах: ");
                        for (int i = 0; i < a.weight.Length; i++) // вывод потерянного веса в граммах
                        {
                            g += a.weight[i];
                        }
                        g /= 5;
                        Console.WriteLine(g);
                        Console.Write("\n\tв килограммах: ");
                        kg = g / 1000;
                        g %= 1000;
                        Math.Round(kg);
                        Console.WriteLine(kg + " килограмм " + g + " грамм");
                    }
                    Console.Write("\nНажмите любую клавишу... ");
                    Console.ReadKey();
                    break;
                case 3: // 3. Выйти из программы
                    Environment.Exit(0);
                    break;
            }
        }
    }
}