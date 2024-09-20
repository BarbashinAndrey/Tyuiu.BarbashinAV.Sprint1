using Tyuiu.BarbashinAV.Sprint1.Task7.V2.Lib;

namespace Tyuiu.BarbashinAV.Sprint1.Task7.V2;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #1 | Выполнил: Барбашин А. В. | ИИПб-24-1";
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* Спринт #1                                                            *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту              *");
        Console.WriteLine("* Задание #7                                                           *");
        Console.WriteLine("* Вариант #2                                                           *");
        Console.WriteLine("* Выполнил: Барбашин Андрей Владиславович | ИИПб-24-1                  *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                             *");
        Console.WriteLine("* Написать программу, которая вычисляет математическое выражение       *");
        Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                *");
        Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                           *");
        Console.WriteLine("*                                                                      *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
        Console.WriteLine("************************************************************************");

        Console.WriteLine("Введите значение X:");
        double x = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Введите значение Y:");
        double y = double.Parse(Console.ReadLine()!);

        Console.WriteLine("************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine($"Ответ = {new DataService().Calculate(x, y)}");
        Console.ReadKey();
    }
}
