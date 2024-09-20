﻿using Tyuiu.BarbashinAV.Sprint1.Task2.V11.Lib;

namespace Tyuiu.BarbashinAV.Sprint1.Task2.V11;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #1 | Выполнил: Барбашин А. В. | ИИПб-24-1";
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* Спринт #1                                                            *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                     *");
        Console.WriteLine("* Задание #2                                                           *");
        Console.WriteLine("* Вариант #11                                                          *");
        Console.WriteLine("* Выполнил: Барбашин Андрей Владиславович | ИИПб-24-1                  *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                             *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные      *");
        Console.WriteLine("* данные, выполняет указанные расчёты и печатает результат на экране   *");
        Console.WriteLine("*                                                                      *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
        Console.WriteLine("************************************************************************");

        int x = int.Parse(Console.ReadLine()!);
        int y = int.Parse(Console.ReadLine()!);

        Console.WriteLine("************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine(new DataService().Calculate(x, y));
        Console.ReadKey();
    }
}
