using Tyuiu.BarbashinAV.Sprint1.Task1.V14.Lib;

namespace Tyuiu.BarbashinAV.Sprint1.Task1.V14;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #1 | Выполнил: Барбашин А. В. | ИИПб-24-1";
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* Спринт #1                                                            *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                     *");
        Console.WriteLine("* Задание #1                                                           *");
        Console.WriteLine("* Вариант #14                                                          *");
        Console.WriteLine("* Выполнил: Барбашин Андрей Владиславович | ИИПб-24-1                  *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                             *");
        Console.WriteLine("* Написать программу, которая вычисляет выражение a*b/c+(a/(b+c))      *");
        Console.WriteLine("* и печатает результат на экране                                       *");
        Console.WriteLine("*                                                                      *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
        Console.WriteLine("************************************************************************");

        Console.WriteLine("Введите значение A:");
        int a = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Введите значение B:");
        int b = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Введите значение C:");
        int c = int.Parse(Console.ReadLine()!);

        Console.WriteLine("************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine(new DataService().Calculate(a, b, c));
        Console.ReadKey();
    }
}
