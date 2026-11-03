using Tyuiu.FedorovskikhEO.Sprint4.Task4.V9.Lib;
namespace Tyuiu.FedorovskikhEO.Sprint4.Task4.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] mas = new int[5, 5]
            {
                { 3, 7, 3, 1, 5 },
                { 6, 3, 2, 1, 2 },
                { 1, 3, 2, 8, 1 },
                { 5, 8, 1, 5, 1 },
                { 3, 3, 4, 4, 6 }};

            int res = ds.Calculate(mas);
            int wait = 42;

            Assert.AreEqual(wait, res);
        }
    }
}
