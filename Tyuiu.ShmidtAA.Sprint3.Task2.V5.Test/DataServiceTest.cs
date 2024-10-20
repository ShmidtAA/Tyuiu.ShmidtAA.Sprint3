using Tyuiu.ShmidtAA.Sprint3.Task2.V5.Lib;
namespace Tyuiu.ShmidtAA.Sprint3.Task2.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int i = 1;
            int b = 20;
            double value = 0.75;

            double waot = 0.333;

            Assert.AreEqual(waot, ds.GetSumSeries(value,i,b));

        }
    }
}