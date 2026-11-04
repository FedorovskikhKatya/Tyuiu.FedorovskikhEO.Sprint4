using Tyuiu.FedorovskikhEO.Sprint4.Task5.V9.Lib;
namespace Tyuiu.FedorovskikhEO.Sprint4.Task5.V9.Test
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
                { -4, -3, -2, -1, 0 },
                { 1, 3, 2, 1, 2 },
                { 1, 3, 2, 4, 1 },
                { 5, 3, 1, -4, 1 },
                { 3, 3, 4, 4, -2 }};

            int res = ds.Calculate(mas);
            int wait = 18;

            Assert.AreEqual(wait, res); 
        }
    }
}
