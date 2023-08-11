using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            string str = "";
            int i;
            double avg = 0;

            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Здравствуйте, {name}, эта программа проверяет заданный вами пароль и находит " +
                $"среднее арифметическое чисел из заданного вами диапозона ");

            Console.Write("Введите пароль: ");
            for (i = 0; i < 3 && (str != "пароль"); i++)
            {
                str = Console.ReadLine();
                if (str != "пароль")
                {
                    Console.Write("Неверный пароль!\n");
                    if (i != 2)
                    {
                        Console.Write("Повтоите попытку: ");
                    }
                }
            }
            if (i == 3 && (str != "пароль"))
            {
                Console.WriteLine("Вы использовали три попытки: доступ запрещен");
                return;
            }

            Console.WriteLine("Введите диапазон чисел");
            Console.Write("От: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("До: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int j = m; j <= n; j++)
            {
                avg += j;
            }
            avg /= (n - m + 1);

            Console.WriteLine($"Среднее арифметическое чисел в диапазоне от {m} до {n} равно {avg}");
        }
    }
}