using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BarbashinAV.Sprint1.Task3.V1.Lib;

public class DataService : ISprint1Task3V1
{
    public double CylinderVolume(double r, double h)
        => Math.Round(Math.PI * Math.Pow(r, 2) * h, 3);
}
