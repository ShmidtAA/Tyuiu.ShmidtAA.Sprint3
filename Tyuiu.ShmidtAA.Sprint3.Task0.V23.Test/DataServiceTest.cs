using Tyuiu.ShmidtAA.Sprint3.Task0.V23.Lib;
namespace Tyuiu.ShmidtAA.Sprint3.Task0.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            Assert.AreEqual(0.298, ds.GetSumSeries(1.5, 1, 10));
        }
    }
}