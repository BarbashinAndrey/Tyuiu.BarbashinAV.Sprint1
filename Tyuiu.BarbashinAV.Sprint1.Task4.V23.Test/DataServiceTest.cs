using Tyuiu.BarbashinAV.Sprint1.Task4.V23.Lib;

namespace Tyuiu.BarbashinAV.Sprint1.Task4.V23.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidExpression()
    {
        Assert.AreEqual(1.5, new DataService().Calculate(5, -14));
    }
}