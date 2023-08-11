using System;
using System.Net.Http.Headers;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using System.Text;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main()
    {
        string name, userText, textFromFile;
        string[] allStrings;
        int key, a = 0;
        byte[] array = { };
        byte[] buffer;
        FileStream fin, fout;


        Console.Write("Введите имя: ");
        name = Console.ReadLine();
        Console.ReadKey();

        for (; ; )
        {
            do
            {
                Console.Clear();
                Console.WriteLine($"Здравуствуйте, {name}, данная программа преобразовать введенный вами текст в массив строк, " +
                $"записать его в байтовый файл и выполнить операции над этим файлом, а затем вывести результат на экран");
                Console.WriteLine("Выберите пункт:\n" +
                "1. Ввести текст и преобразовать его в байтовый файл\n" +
                "2. Убрать из массива строк все пробелы, определить длины строк и вывести результаты в текстовый файл\n" +
                "3. Выйти из программы");
                key = Convert.ToInt32(Console.ReadLine());
            } while (key != 1 && key != 2 && key != 3);
            switch (key)
            {
                case 1: // 1. Ввести текст и преобразовать его в байтовый файл
                    {
                        Console.Clear();
                        Console.WriteLine("1. Ввести текст и преобразовать его в байтовый файл");
                        Console.Write("Введите любой текст, а когда закончите напишите \"стоп\": ");

                        using (fin = new FileStream(@"C:\users\1\Desktop\file.dat", FileMode.Create)) // Открытие файла на диске
                        {
                            do
                            {
                                userText = Console.ReadLine();
                                if (userText != "стоп")
                                {
                                    userText = userText + "\r\n"; // Добавление новой строки
                                    array = Encoding.Default.GetBytes(userText);
                                    fin.Write(array, 0, array.Length);
                                }
                            } while (userText != "стоп");
                            Console.WriteLine("Текст записан в файл");
                        }
                    }
                    Console.Write("Нажмите любую клавишу... ");
                    Console.ReadKey();
                    break;
                case 2: // 2. Убрать из массива строк все пробелы, определить длины строк и вывести результаты в текстовый файл
                    {
                        Console.Clear();
                        Console.WriteLine("2. Убрать из массива строк все пробелы, определить длины строк и вывести результаты в текстовый файл");
                        using (fin = new FileStream(@"C:\users\1\Desktop\file.dat", FileMode.Open))
                        {
                            buffer = new byte[fin.Length];
                            byte[] checkArray = new byte[fin.Length];
                            for (int i = 0; i < buffer.Length; i++)
                            {
                                checkArray[i] = (byte)fin.ReadByte();
                                if (checkArray[i] != (byte)' ')
                                {
                                    buffer[i] = checkArray[i];
                                    a++;
                                }
                            }
                        }
                        try
                        {
                            fin = new FileStream(@"C:\users\1\Desktop\file.dat", FileMode.Create);
                            fout = new FileStream(@"C:\users\1\Desktop\out.txt", FileMode.Create);

                            fin.Read(buffer, 0, buffer.Length);
                            fin.Write(buffer, 0, buffer.Length);

                            textFromFile = Encoding.Default.GetString(buffer);
                            StreamWriter sw = new StreamWriter(fout);
                            sw.Write(textFromFile);
                            sw.Close();
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                        finally
                        {
                            fin.Close();
                        }
                        using (StreamReader sr = new StreamReader(@"C:\users\1\Desktop\out.txt", Encoding.Default))
                        {
                            //textFromFile = sr.ReadToEnd();
                            Console.WriteLine("Строка: " + textFromFile);
                            Console.WriteLine(sr.ReadToEnd());
                        }
                        Console.WriteLine("Длина всех строк файла: " + a);
                    }
                    Console.Write("Нажмите любую клавишу... ");
                    Console.ReadKey();
                    break;
                case 3:
                    Environment.Exit(0); // 3. Выйти из программы
                    break;
            }
        }
    }
}