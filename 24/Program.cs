using System;
using System.IO;

class Program
{
    static void Main()
    {
        string name,
            path = Directory.GetCurrentDirectory(),
            currFilePath = "",
            newFileName,
            newFilePath = "",
            ext = "";
        int key = 0,
            fileNum,
            lastSlash, 
            f = 0;

        Console.Write("Введите имя: ");
        name = Console.ReadLine();

        for (; ; )
        {
            do
            {
                Console.Clear();
                Console.WriteLine($"Здравствуйте, {name}, данная программа определяет имя текущего каталога и устанавливает новый текущий каталог, " +
                    $"копирует файл из одной директории в другую.");
                Console.WriteLine("Выберите пункт меню:\n" +
                    "1. Определить имя текущего каталога\n" +
                    "2. Установить новый текущий каталог\n" +
                    "3. Копировать файл\n" +
                    "4. Выйти из программы");
                try
                {
                    key = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.Write("Введите цифру!\n" +
                        "Нажмите любую клавишу...");
                    Console.ReadKey();
                }
            } while (key != 1 && key != 2 && key != 3 && key != 4);
            switch (key)
            {
                case 1: /* 1. Определить имя текущего каталога */
                    {
                        Console.Clear();
                        Console.WriteLine("1. Определить имя текущего каталога");
                        Console.Write("Текущий каталог: " + Directory.GetCurrentDirectory()); // Вывод текущего каталога
                    }
                    Console.Write("\nНажмите любую клавишу...");
                    Console.ReadKey();
                    break;
                case 2: /* 2. Установить новый текущий каталог */
                    {
                        Console.Clear();
                        Console.WriteLine("2. Установить новый текущий каталог");
                        Console.Write("Введите путь к новому каталогу: ");
                        path = Console.ReadLine();
                        try
                        {
                            Directory.SetCurrentDirectory(path); // Установление нового пути текущего каталога
                        }
                        catch (DirectoryNotFoundException) // Обработка ошибки неверно указанного пути к новому каталогу
                        {
                            Console.WriteLine("Неверно указан путь к каталогу");
                            Console.Write("Нажмите любую клавишу...");
                            Console.ReadKey();
                            return;
                        }
                        catch(IOException)
                        {
                            Console.WriteLine("Неверно указан путь к каталогу");
                            Console.Write("Нажмите любую клавишу...");
                            Console.ReadKey();
                            return;
                        }
                    }
                    Console.Write("\nНажмите любую клавишу...");
                    Console.ReadKey();
                    break;
                case 3: /* 3. Копировать файл */
                    {
                        Console.Clear();
                        Console.WriteLine("3. Копировать файл");

                        string[] files = Directory.GetFiles(path); // Получение списка файлов в текущем каталоге
                        if (files.Length != 0)
                        {
                            Console.WriteLine("Список файлов в текущем каталоге: ");
                            for (int i = 0; i < files.Length; i++)
                            {
                                Console.WriteLine((i + 1) + ") " + files[i]); // Вывод списка файлов в текущем каталоге
                            }
                            Console.Write("Введите номер файла, который хотите копировать: ");
                            fileNum = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < files.Length; i++)
                            {
                                if ((fileNum - 1) == i)
                                {
                                    currFilePath = files[i]; // Определение файла, выбранного пользователем
                                    ext = currFilePath.Substring(files[i].LastIndexOf('.')); // Запись расширения файла в переменную ext
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Файлы в данном каталоге отсутствуют.");
                            Console.Write("\nНажмите любую клавишу...");
                            Console.ReadKey();
                            break;
                        }

                        Console.Write("Укажите новое имя файла: ");
                        newFileName = Console.ReadLine();
                        Console.Write("Укажите путь к месту копирования файла: ");
                        try
                        {
                            for (; ; )
                            {
                                newFilePath = Console.ReadLine();
                                lastSlash = newFilePath.IndexOf('\\');
                                if (lastSlash == -1) // Проверка на то, чтобы в пути к месту копирования файла был хотя бы один '\'
                                {
                                    Console.WriteLine("Неверно указан путь!");
                                    Console.Write("Укажите путь к месту копирования файла: ");
                                }
                                else break;
                            }
                        }
                        catch (DirectoryNotFoundException) // Обработка ошибки неверно указанного пути к новому каталогу
                        {
                            Console.WriteLine("Неверно указан путь к каталогу");
                            Console.Write("Нажмите любую клавишу...");
                            Console.ReadKey();
                        }

                        FileInfo currPath = new FileInfo(currFilePath); // Создание объекта FileInfo
                        if (!File.Exists(newFilePath + newFileName + ext)) // Проверка на существование файла в указанном каталоге
                        {
                            currPath.CopyTo(newFilePath + newFileName + ext); // Копирование файла
                        }
                        else
                        {
                            Console.WriteLine("\nФайл с таким именем уже существует в указанном каталоге!");
                        }
                    }
                    Console.Write("\nНажмите любую клавишу...");
                    Console.ReadKey();
                    break;
                case 4:
                    Environment.Exit(0); /* 4. Выйти из программы */
                    break;
            }
        }
    }
}