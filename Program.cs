using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Как Вас зовут? ");
        var Name = Console.ReadLine();

        Console.Write("Сколько Вам лет? ");
        var Age = checked((byte)int.Parse(Console.ReadLine()));

        Console.Write("Ваша дата рождения? ");
        var BirthDate = Console.ReadLine();

        Console.WriteLine("Спасибо {0}", Name);
        Console.WriteLine("Вы родились {0}, и Ваш возраст {1} лет", BirthDate, Age.ToString());

        Console.ReadKey();
    }
}