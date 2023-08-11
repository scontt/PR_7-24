using System;
using System.Text;

class Program
{
    static void Main()
    {
        string name, 
            user_text = " ";
        int key, 
            change_count = 0;
        char user_symb;
        char[] symb_arr = new char[100];

        Console.Write("Введите имя: ");
        name = Console.ReadLine();
        Console.WriteLine($"Здравствуй, {name}!");
        Console.Write("\nНажимте любую клавишу... ");
        Console.ReadKey();

        for ( ; ; )
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Данная программа позволяет вам ввести в консоль текст и преобразовать элементы строки");
                Console.Write("Выберите пункт меню:\n" +
                    "1. Ввести текст (не более 100 символов)\n" +
                    "2. Заменить символы, имеющие четный код, на выбранные символы\n" +
                    "3. Вывести количество замен в тексте\n" +
                    "4. Выйти из программы\n" +
                    "Ввод: ");
                key = Convert.ToInt32(Console.ReadLine());
            } while (key != 1 && key != 2 && key != 3 && key != 4);
            switch (key)
            {
                case 1: // 1. Ввести текст
                    {
                        Console.Clear();
                        Console.WriteLine("1. Ввести текст (не более 100 символов)");
                        user_text = Console.ReadLine();
                    }
                    Console.Write("\nНажимте любую клавишу... ");
                    Console.ReadKey();
                    break;
                case 2:
                    {
                        Console.Clear();
                        Console.WriteLine("2. Заменить символы, имеющие четный код, на выбранный символ");
                        Console.WriteLine(user_text);
                        symb_arr = user_text.ToCharArray(); // Преобразование строки в символьный массив
                        StringBuilder sb = new StringBuilder(user_text); // Создание объекта класса StringBuilder
                        Console.Write("Введите символ: ");
                        user_symb = Convert.ToChar(Console.ReadLine()); // Ввод символа пользователем
                        for (int i = 0; i < user_text.Length; i++) // Цикл с заменой символов
                        {
                            if ((int)symb_arr[i] % 2 == 0)
                            {
                                sb[i] = user_symb;
                                user_text = sb.ToString();
                                change_count++;
                            }
                        }
                        Console.WriteLine(user_text); // Вывод измененной строки
                    }
                    Console.Write("\nНажимте любую клавишу... ");
                    Console.ReadKey();
                    break;
                case 3: // 3. Вывести количество замен в тексте
                    {
                        Console.Clear();
                        Console.WriteLine("3. Вывести количество замен в тексте");
                        Console.WriteLine(user_text);
                        Console.WriteLine($"В строке было произведено {change_count} замен");
                    }
                    Console.Write("\nНажимте любую клавишу... ");
                    Console.ReadKey();
                    break;
                case 4: Environment.Exit(0);
                    Console.Write("\nНажимте любую клавишу... ");
                    Console.ReadKey();
                    break;
            }
        }
    }
}