using Tyuiu.BarbashinAV.Sprint1.Task3.V1.Lib;

namespace Tyuiu.BarbashinAV.Sprint1.Task3.V1.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidExpression()
    {
        Assert.AreEqual(254.469, new DataService().CylinderVolume(3, 9));
    }
}