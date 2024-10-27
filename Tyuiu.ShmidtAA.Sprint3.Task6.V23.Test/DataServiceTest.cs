using Tyuiu.ShmidtAA.Sprint3.Task6.V23.Lib;
namespace Tyuiu.ShmidtAA.Sprint3.Task6.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService();

            int wait = 34;

            Assert.AreEqual(wait, ds.GetSumTheDivisors(18, 28));
        }
    }
}