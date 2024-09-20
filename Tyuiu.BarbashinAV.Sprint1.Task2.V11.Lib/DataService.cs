namespace Tyuiu.BarbashinAV.Sprint1.Task2.V11.Lib;
using tyuiu.cources.programming.interfaces.Sprint1;

public class DataService : ISprint1Task2V11
{
    public int ConvertHoursMinutesToSeconds(int value, int valueTwo)
        => value * 60 * 60 + valueTwo * 60;
}
