using System;
using System.Security.Cryptography;

struct Note // Объявление структуры Note
{
    public string firstName, lastName, number;
    public int[] birthday;
    public string birthSeason;
    public Note(string a, string b, string c, int[] d, string e) // Объявление конструктора структуры Note
    {
        firstName = a;
        lastName = b;
        number = c;
        birthday = d;
        birthSeason = e;
    }
}
class Program
{
    static void Main()
    {
        string name, ch, first, last, num;
        int key;
        int[] birth;
        string seasons = "";
        Note[] notes = new Note[6];
        Note no;

        Console.Write("Введите имя: ");
        name = Console.ReadLine();
        Console.Write("\nНажмите любую клавишу... ");
        Console.ReadKey();

        for (; ; )
        {
            do
            {
                Console.Clear();
                Console.WriteLine($"Здравствуйте, {name}, данная программа выводит информацию о людях " +
                $"в соответствии с введенным сезоном");
                Console.WriteLine("Выберите пункт:\n" +
                "1. Ввести данные о людях\n" +
                "2. Вывести данные о людях в соответствии с сезоном\n" +
                "3. Выйти из программы\n");
                ch = Console.ReadLine();
                if (ch != "") key = Convert.ToInt32(ch);
                else key = 0;
            } while (key != 1 && key != 2 && key != 3);
            switch (key)
            {
                case 1: // 1. Ввести данные о людях
                    {
                        Console.Clear();
                        Console.WriteLine("1. Ввести данные о людях");
                        for (int i = 0; i < notes.Length; i++)
                        {
                            Console.Write("Имя: ");
                            first = Console.ReadLine();
                            Console.Write("Фамилия: ");
                            last = Console.ReadLine();
                            Console.Write("Номер телефона: ");
                            num = Console.ReadLine();
                            Console.WriteLine("Дата рождения в формате дд.мм.гггг");
                            birth = new int[3];
                            for (int j = 0; j < 3; j++)
                            {
                                birth[j] = Convert.ToInt32(Console.ReadLine());
                            }
                            if (birth[1] == 12 || birth[1] == 01 || birth[1] == 02) seasons = "ЗИМА";
                            if (birth[1] == 03 || birth[1] == 04 || birth[1] == 05) seasons = "ВЕСНА";
                            if (birth[1] == 06 || birth[1] == 07 || birth[1] == 08) seasons = "ЛЕТО";
                            if (birth[1] == 09 || birth[1] == 10 || birth[1] == 11) seasons = "ОСЕНЬ";

                            Console.WriteLine();
                            notes[i] = new Note(first, last, num, birth, seasons);
                        }
                    }
                    Console.Write("Нажмите любую клавишу... ");
                    Console.ReadKey();
                    break;
                case 2: // 2. Вывести данные о людях в соответствии с сезоном
                    {
                        Console.Clear();
                        Console.WriteLine("2. Вывести данные о людях в соответствии с сезоном");
                        int k = 0;
                        Console.Write("Введите время года: ");
                        string season = Console.ReadLine();
                        Console.WriteLine("Люди родившиеся в сезон " + season + ": ");
                        season = season.Trim().ToUpper();
                        foreach (Note n in notes)
                        {
                            no.birthSeason = n.birthSeason;
                            if (no.birthSeason != null) no.birthSeason = no.birthSeason.Trim().ToUpper();
                            if (season == no.birthSeason)
                            {
                                Console.WriteLine($"{(k + 1)}. Имя: {n.firstName}\n" +
                                $"Фамилия: {n.lastName}\n" +
                                $"Номер телефона: {n.number}\n" +
                                $"Дата рождения: {n.birthday[0]}.{n.birthday[1]}.{n.birthday[2]}г.");
                                Console.WriteLine();
                                k++;
                            }
                        }
                        if (k == 0) Console.WriteLine("В списке нет людей, родившихся в это время года");
                    }
                    Console.Write("Нажмите любую клавишу... ");
                    Console.ReadKey();
                    break;
                case 3:
                    Environment.Exit(0); // 3. Выйти из программы
                    break;
                default:
                    break;
            }
        }
    }
}