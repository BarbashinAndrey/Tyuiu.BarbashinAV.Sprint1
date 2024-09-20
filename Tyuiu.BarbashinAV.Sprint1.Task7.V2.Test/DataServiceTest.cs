using Tyuiu.BarbashinAV.Sprint1.Task7.V2.Lib;

namespace Tyuiu.BarbashinAV.Sprint1.Task7.V2.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidExpression()
    {
        Assert.AreEqual(6.863, new DataService().Calculate(123, 456));
    }
}