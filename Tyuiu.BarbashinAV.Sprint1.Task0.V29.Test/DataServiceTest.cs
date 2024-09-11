using Tyuiu.BarbashinAV.Sprint1.Task0.V29.Lib;
namespace Tyuiu.BarbashinAV.Sprint1.Task0.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            Assert.AreEqual(32, new DataService().Calculate());
        }
    }
}