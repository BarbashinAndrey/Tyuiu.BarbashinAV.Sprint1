using Tyuiu.BarbashinAV.Sprint1.Task5.V3.Lib;

namespace Tyuiu.BarbashinAV.Sprint1.Task5.V3.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidExpression()
    {
        Assert.AreEqual(2, new DataService().Calculate(1234));
    }
}