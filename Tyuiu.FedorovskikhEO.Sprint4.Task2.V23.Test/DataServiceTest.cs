using Tyuiu.FedorovskikhEO.Sprint4.Task2.V23.Lib;
namespace Tyuiu.FedorovskikhEO.Sprint4.Task2.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numsArray = { 4, 5, 6, 7, 8, 9, 4, 5, 6, 7, 8, 9, 5, 6, 7 };
            int res = ds.Calculate(numsArray);
            int wait = 42;
            Assert.AreEqual(res, wait);
        }
    }
}
