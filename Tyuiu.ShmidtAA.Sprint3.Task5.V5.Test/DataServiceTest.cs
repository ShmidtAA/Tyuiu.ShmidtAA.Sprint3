using Tyuiu.ShmidtAA.Sprint3.Task5.V5.Lib;
namespace Tyuiu.ShmidtAA.Sprint3.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 5;


            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 10;


            double wait  = 98.286d;
            DataService ds = new DataService(); 
            Assert.AreEqual(wait, ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));


        }
    }
}