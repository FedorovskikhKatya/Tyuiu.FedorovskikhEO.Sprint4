using Tyuiu.FedorovskikhEO.Sprint4.Task3.V24.Lib;
namespace Tyuiu.FedorovskikhEO.Sprint4.Task3.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mtrx = new int[5, 5]
            {
                { 3, 6, 1, 7, 3 },
                { 2, 3, 7, 1, 1 },
                { 1, 2, 5, 5, 1 },
                { 7, 6, 7, 6, 2 },
                { 7, 6, 4, 5, 8 }
            };

            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            DataService ds = new DataService();

            Console.WriteLine("**********************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("**********************************************");
            Console.WriteLine("Матрица:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j]}\t");
                }

                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("**********************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:");
            Console.WriteLine("**********************************************");

            int res = ds.Calculate(mtrx);

            Console.WriteLine("Минимальный элемент второго столбца = " + res);

            Console.ReadKey();
        }
    }
}
