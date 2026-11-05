using Tyuiu.FedorovskikhEO.Sprint4.Task7.V25.Lib;
namespace Tyuiu.FedorovskikhEO.Sprint4.Task7.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int rows = 4;
            int columns = 3;
            int[,] mtrx=new int[rows, columns];
            string value = "348561792486";
            DataService ds = new DataService();
            int res=ds.Calculate(rows, columns,value);
            int wait = 38;
            Assert.AreEqual(res, wait);
        }
    }
}
