using Tyuiu.NefedovIS.Sprint6.Task0.V15.Lib;
namespace Tyuiu.NefedovIS.Sprint6.Task0.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            Assert.AreEqual(res, 64);
        }
    }
}