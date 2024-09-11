using Tyuiu.BarbashinAV.Sprint1.Task0.V29.Lib;
namespace Tyuiu.BarbashinAV.Sprint1.Task0.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Барбашин А. В. | ИИПб-24-1";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #1                                                            *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                     *");
            Console.WriteLine("* Задание #0                                                           *");
            Console.WriteLine("* Вариант #29                                                          *");
            Console.WriteLine("* Выполнил: Барбашин Андрей Владиславович | ИИПб-24-1                  *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                             *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение 2 * 9 + 7 * 2        *");
            Console.WriteLine("* и печатает результат на экране                                       *");
            Console.WriteLine("*                                                                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* 2 * 9 + 7 * 2                                                        *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine(new DataService().Calculate());
            Console.ReadKey();
        }
    }
}
