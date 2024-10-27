using Tyuiu.ShmidtAA.Sprint3.Task7.V9.Lib;
namespace Tyuiu.ShmidtAA.Sprint3.Task7.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int endValue = 5;

            int len = Math.Abs(startValue) + endValue + 1;
            double[] waitArray = new double[len];
            waitArray[0] = -27.22;
            waitArray[1] = -22.25;
            waitArray[2] = -16.66;
            waitArray[3] = -11.04;
            waitArray[4] = -6.13;
            waitArray[5] = -3.00;
            waitArray[6] = 4.84;
            waitArray[7] = 8.86;
            waitArray[8] = 14.43;
            waitArray[9] = 20.18;
            waitArray[10] = 25.24;

            double[] res = new double[len];
            res = ds.GetMassFunction(startValue, endValue);

            CollectionAssert.AreEqual(waitArray,res);
        }
    }
}