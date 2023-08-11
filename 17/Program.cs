using System;

class Program
{
    unsafe static void Main()
    {
        int[] arr = new int[9];
        int*[] ukz = new int*[9];
        string name;
        int key, index;
        ulong addr;

        for (int i = 0; i < 9; i++)
        {
            fixed (int* p = arr) ukz[i] = p + i;
        }

        Console.Write("Введите имя: ");
        name = Console.ReadLine();
        Console.WriteLine($"Здравствуйте, {name}!");
        Console.Write("\nНажмите любую клавишу... ");
        Console.ReadKey();

        for ( ; ; )
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Данная программа заполняет два ступенчатых массива и помещает результат выполнения операций " +
                    "над ними в третий массив");
                Console.Write("Выберите пункт: \n" +
                "1. Заполнить массив из девяти элементов\n" +
                "2. Вывести каждый нечетный элемент\n" +
                "3. Вывести на экран значение элемента, индекс которого меньше введенного вами индекса на 1\n" +
                "4. Выйти из программы\n" +
                "Ввод: ");
                key = Convert.ToInt32(Console.ReadLine());
            } while (key != 1 && key != 2 && key != 3 && key != 4);
            switch (key)
            {
                case 1: // 1. Заполнить массив из девяти элементов
                    {
                        Console.Clear();
                        Console.WriteLine("1. Заполнить массив из девяти элементов");
                        for (int i = 0; i < 9; i++) // Ввод массива
                        {
                            Console.Write($"Введите {i + 1} элемент: ");
                            *ukz[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.Write("Вы ввели массив: \n");
                        for (int i = 0; i < 9; i++) // Вывод массива
                        {
                            addr = (ulong)ukz[i];
                            Console.Write($"Индекс: {i}\tЗначение: {*ukz[i]}\tАдрес: {addr}\n");
                        }
                    }
                    Console.Write("\nНажмите любую клавишу... ");
                    Console.ReadKey();
                    break;
                case 2: // 2. Вывести каждый четный элемент
                    {
                        Console.Clear();
                        Console.WriteLine("2. Вывести каждый нечетный элемент");
                        Console.WriteLine("Массив: ");
                        for (int i = 0; i < 9; i++) // Вывод массива
                        {
                            addr = (ulong)ukz[i];
                            Console.Write($"Индекс: {i}\tЗначение: {*ukz[i]}\tАдрес: {addr}\n");
                        }
                        Console.Write("\nАдреса четных элементов массива: ");
                        foreach (int *i in ukz) // Вывод нечетных элементов массива
                        {
                            if (*i % 2 == 0)
                            {
                                addr = (ulong)i;
                                Console.Write(addr + " ");
                            }
                        }
                    }
                    Console.Write("\nНажмите любую клавишу... ");
                    Console.ReadKey();
                    break;
                case 3: // 3. Вывести на экран значение элемента, индекс которого меньше введенного вами индекса на 1
                    {
                        Console.Clear();
                        Console.WriteLine("3. Вывести на экран значение элемента, индекс которого меньше введенного вами индекса на 1");
                        Console.WriteLine("Массив: ");
                        for (int i = 0; i < 9; i++) // Вывод массива
                        {
                            addr = (ulong)ukz[i];
                            Console.Write($"Индекс: {i}\tЗначение: {*ukz[i]}\tАдрес: {addr}\n");
                        }
                        Console.Write("\nВведите индекс элемента: ");
                        index = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Элемент с введенным вами индексом ({index}): {*ukz[index]}");
                        Console.WriteLine($"Элемент с индексом {index - 1}: {*ukz[index - 1]}");
                    }
                    Console.Write("\nНажмите любую клавишу... ");
                    Console.ReadKey();
                    break;
                case 4: Environment.Exit(0); // 4. Выйти из программы
                    break;
                default:
                    break;
            }
        }
    }
}