using Tyuiu.BarbashinAV.Sprint1.Task5.V3.Lib;

namespace Tyuiu.BarbashinAV.Sprint1.Task5.V3;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #1 | Выполнил: Барбашин А. В. | ИИПб-24-1";
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* Спринт #1                                                            *");
        Console.WriteLine("* Тема: Преобразование типов и класс Convert                           *");
        Console.WriteLine("* Задание #5                                                           *");
        Console.WriteLine("* Вариант #3                                                           *");
        Console.WriteLine("* Выполнил: Барбашин Андрей Владиславович | ИИПб-24-1                  *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                             *");
        Console.WriteLine("* Написать программу, которая решает следующую задачу:                 *");
        Console.WriteLine("* Присвоить целой переменной h третью от конца цифру в записи          *");
        Console.WriteLine("* положительного целого числа k (например, если k=130985, то h=9).     *");
        Console.WriteLine("*                                                                      *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
        Console.WriteLine("************************************************************************");

        Console.WriteLine("Введите число:");
        int k = int.Parse(Console.ReadLine()!);
        int h = new DataService().Calculate(k);

        Console.WriteLine("************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine($"Третья цифра от конца = {h}");
        Console.ReadKey();
    }
}
