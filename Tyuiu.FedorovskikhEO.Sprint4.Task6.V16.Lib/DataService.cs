using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.FedorovskikhEO.Sprint4.Task6.V16.Lib
{
    public class DataService : ISprint4Task6V9
    {
        public int Calculate(string[] array)
        {
            string[] mas = Array.FindAll(array, transport => transport.Length == 7);
            return mas.Length;
        }
    }
}
