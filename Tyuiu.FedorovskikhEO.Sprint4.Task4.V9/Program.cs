using Tyuiu.FedorovskikhEO.Sprint4.Task4.V9.Lib;
namespace Tyuiu.FedorovskikhEO.Sprint4.Task4.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mtrx = new int[5, 5];

            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            DataService ds = new DataService();

            Console.WriteLine("********************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("********************************************");
            Console.WriteLine("Введите элементы массива:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)

                {
                    Console.Write($"Введите {i};{j} элемент : ");
                    mtrx[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.WriteLine("********************************************");
            Console.WriteLine("* МАССИВ:");
            Console.WriteLine("********************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j]}\t");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("********************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:");
            Console.WriteLine("********************************************");

            int res = ds.Calculate(mtrx);

            Console.WriteLine("Сумма четных элементов массива = " + res);

            Console.ReadKey();
        }
    }
}
