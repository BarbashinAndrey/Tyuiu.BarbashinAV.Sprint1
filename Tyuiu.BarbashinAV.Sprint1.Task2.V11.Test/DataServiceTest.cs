using Tyuiu.BarbashinAV.Sprint1.Task2.V11.Lib;

namespace Tyuiu.BarbashinAV.Sprint1.Task2.V11.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidExpression()
    {
        Assert.AreEqual(49920, new DataService().Calculate(13, 52));
    }
}