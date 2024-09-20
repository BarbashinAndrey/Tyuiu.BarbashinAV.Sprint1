using Tyuiu.BarbashinAV.Sprint1.Task6.V17.Lib;

namespace Tyuiu.BarbashinAV.Sprint1.Task6.V17.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidExpression()
    {
        Assert.AreEqual(true, new DataService().CheckPalindrome("топот"));
    }
}