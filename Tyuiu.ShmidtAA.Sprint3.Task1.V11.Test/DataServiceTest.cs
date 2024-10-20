using Tyuiu.ShmidtAA.Sprint3.Task1.V11.Lib;
namespace Tyuiu.ShmidtAA.Sprint3.Task1.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int StartValue = 1;
            int StopValue = 14;
            double value = 0.75;

            double wait = 0.005;

            Assert.AreEqual(wait, ds.GetMultiplySeries(value, StartValue, StopValue));

        }
    }
}