using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.FedorovskikhEO.Sprint4.Task1.V23.Lib
{
    public class DataService : ISprint4Task1V23
    {
        public int Calculate(int[] array)
        {
            int sumArray = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sumArray += array[i];
                }
            }
            return sumArray;
        }
    }
}
