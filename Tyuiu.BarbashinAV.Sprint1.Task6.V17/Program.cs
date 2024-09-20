using Tyuiu.BarbashinAV.Sprint1.Task6.V17.Lib;

namespace Tyuiu.BarbashinAV.Sprint1.Task6.V17;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #1 | Выполнил: Барбашин А. В. | ИИПб-24-1";
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* Спринт #1                                                            *");
        Console.WriteLine("* Тема: Работа со строками класс String                                *");
        Console.WriteLine("* Задание #6                                                           *");
        Console.WriteLine("* Вариант #17                                                          *");
        Console.WriteLine("* Выполнил: Барбашин Андрей Владиславович | ИИПб-24-1                  *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                             *");
        Console.WriteLine("* Написать программу: пользователь вводит текст. Проверить, что строка *");
        Console.WriteLine("* является перевертышем.                                               *");
        Console.WriteLine("*                                                                      *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
        Console.WriteLine("************************************************************************");

        Console.WriteLine("Введите текст:");
        string text = Console.ReadLine()!;

        Console.WriteLine("************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
        Console.WriteLine("************************************************************************");
        var result = new DataService().CheckPalindrome(text);
        Console.WriteLine(result 
            ? "Строка является перевертышем" 
            : "Строка не является перевертышем");
        Console.ReadKey();
    }
}
