using System;

class Program
{
    enum Instruments { Ручка, Карандаш, Ластик, Линейка, Выход };

    static void Main()
    {

        string name, choice;
        string[] info = {"Длина - 11,3 см; цена - 15 руб.", "Длина - 10,2 см; цена - 14 руб.", "Длина - 4,1 см; цена - 8 руб.",
                         "Длина - 30 см; цена - 34 руб."}; // Массив строк с данными о принадлежностях
        Instruments j; // Объявление переменной перечислимого типа

        Console.Write("Введите имя: ");
        name = Console.ReadLine();
        Console.Write("Нажмите любую клавишу... ");
        Console.ReadKey();

        for ( ; ; )
        {
            do
            {
                Console.Clear();
                Console.WriteLine($"Здравствуйте, {name}, данная программа выводит на экран данные, взятые из массива строк, " +
                    $"о письменных принадлежностях, объявленных в перечисляемом типе данных.");
                Console.Write("Выберите принадлежность, о которой хотите получить информацию:\n" +
                "- Ручка\n" +
                "- Карандаш\n" +
                "- Ластик\n" +
                "- Линейка\n" +
                "- Выход\n" +
                "Ввод: ");
                choice = Console.ReadLine();
                j = (Instruments)Enum.Parse(typeof(Instruments), choice);
            } while (j != Instruments.Ручка && j != Instruments.Карандаш &&
            j != Instruments.Ластик && j != Instruments.Линейка && j != Instruments.Выход);
            switch (j)
            {
                case Instruments.Ручка: // Ручка
                    {
                        Console.Clear();
                        Console.WriteLine("1. Вывести данные о ручке"); 
                        Console.WriteLine($"{j}:\n" +
                        $"{info[(int)j]}");
                    }
                    Console.Write("Нажмите любую клавишу... ");
                    Console.ReadKey();
                    break;
                case Instruments.Карандаш: // Карандаш
                    {
                        Console.Clear();
                        Console.WriteLine("2. Вывести данные о карандаше");
                        Console.WriteLine($"{j}:\n" +
                        $"{info[(int)j]}");
                    }
                    Console.Write("Нажмите любую клавишу... ");
                    Console.ReadKey();
                    break;
                case Instruments.Ластик: // Ластик
                    {
                        Console.Clear();
                        Console.WriteLine("3. Вывести данные о ластике");
                        Console.WriteLine($"{j}:\n" +
                        $"{info[(int)j]}");
                    }
                    Console.Write("Нажмите любую клавишу... ");
                    Console.ReadKey();
                    break;
                case Instruments.Линейка: // Линейка
                    {
                        Console.Clear();
                        Console.WriteLine("4. Вывести данные о линейке");
                        Console.WriteLine($"{j}:\n" +
                        $"{info[(int)j]}");
                    }
                    Console.Write("Нажмите любую клавишу... ");
                    Console.ReadKey();
                    break;
                case Instruments.Выход: Environment.Exit(0); // Выход
                    break;
            }
        }
    }
}