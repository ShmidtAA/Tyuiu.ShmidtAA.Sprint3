using Tyuiu.ShmidtAA.Sprint3.Task3.V5.Lib;
namespace Tyuiu.ShmidtAA.Sprint3.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string value = "fifa al fall";
            char replaceable = 'a';
            char replace = '*';

            DataService ds = new DataService();

            string wait = "fif* *l f*ll";

            Assert.AreEqual(wait, ds.ReplaceCharInString(value, replaceable, replace));
        }
    }
}