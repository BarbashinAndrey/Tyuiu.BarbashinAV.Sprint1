namespace Tyuiu.BarbashinAV.Sprint1.Task1.V14.Test;
using Tyuiu.BarbashinAV.Sprint1.Task1.V14.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        Assert.AreEqual(1.5, new DataService().Calculate(1, 1, 1));
    }
}