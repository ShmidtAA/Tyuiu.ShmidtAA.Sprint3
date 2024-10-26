using Tyuiu.ShmidtAA.Sprint3.Task4.V30.Lib;
namespace Tyuiu.ShmidtAA.Sprint3.Task4.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double res = ds.Calculate(-5,5);

            Assert.AreEqual(1.924, res);

        }
    }
}