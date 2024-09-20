using Tyuiu.BarbashinAV.Sprint1.Task3.V1.Lib;

namespace Tyuiu.BarbashinAV.Sprint1.Task3.V1;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #1 | Выполнил: Барбашин А. В. | ИИПб-24-1";
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* Спринт #1                                                            *");
        Console.WriteLine("* Тема: Операторы составного присваивания                              *");
        Console.WriteLine("* Задание #3                                                           *");
        Console.WriteLine("* Вариант #1                                                           *");
        Console.WriteLine("* Выполнил: Барбашин Андрей Владиславович | ИИПб-24-1                  *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                             *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные      *");
        Console.WriteLine("* данные, выполняет указанные расчёты и печатает результат на экране   *");
        Console.WriteLine("*                                                                      *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
        Console.WriteLine("************************************************************************");

        Console.WriteLine("Введите радиус основания:");
        double r = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Введите высоту:");
        double h = double.Parse(Console.ReadLine()!);

        Console.WriteLine("************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine($"Объём цилиндра = {new DataService().CylinderVolume(r, h)}");
        Console.ReadKey();
    }
}
