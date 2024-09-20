namespace Tyuiu.BarbashinAV.Sprint1.Task1.V14.Lib;
using tyuiu.cources.programming.interfaces.Sprint1;

public class DataService : ISprint1Task1V14
{
    public double Calculate(double a, double b, double c)
        => a * b / c + (a / (b + c));
}
