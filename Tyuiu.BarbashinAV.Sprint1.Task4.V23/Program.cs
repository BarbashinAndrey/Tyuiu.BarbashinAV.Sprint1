using Tyuiu.BarbashinAV.Sprint1.Task4.V23.Lib;

namespace Tyuiu.BarbashinAV.Sprint1.Task4.V23;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #1 | Выполнил: Барбашин А. В. | ИИПб-24-1";
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* Спринт #1                                                            *");
        Console.WriteLine("* Тема: Class Math                                                     *");
        Console.WriteLine("* Задание #4                                                           *");
        Console.WriteLine("* Вариант #23                                                          *");
        Console.WriteLine("* Выполнил: Барбашин Андрей Владиславович | ИИПб-24-1                  *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                             *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные      *");
        Console.WriteLine("* данные, вычисляет результат по формуле и печатает                    *");
        Console.WriteLine("* результат на экране                                                  *");
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
