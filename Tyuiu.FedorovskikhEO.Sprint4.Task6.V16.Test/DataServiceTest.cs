using Tyuiu.FedorovskikhEO.Sprint4.Task6.V16.Lib;
namespace Tyuiu.FedorovskikhEO.Sprint4.Task6.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var transport = new string[] { "Автомобиль", "Велосипед", "Самолет", "Поезд", "Трамвай", "Троллейбус", "Метро" };
            int res = ds.Calculate(transport);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }   
    }
}
