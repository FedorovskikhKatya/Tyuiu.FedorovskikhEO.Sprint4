using Tyuiu.FedorovskikhEO.Sprint4.Task5.V9.Lib;
namespace Tyuiu.FedorovskikhEO.Sprint4.Task5.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd= new Random();

            Console.Write("Введите количество строк в массиве: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество столбцов в массиве: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] mtrx = new int[rows, columns];

            Console.WriteLine("****************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    mtrx[i, j] = rnd.Next(-4, 4);
                }
            }

            Console.WriteLine("\nМассив:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j]}\t");
                }

                Console.WriteLine();
            }
            int count = 0;


            Console.WriteLine();
            Console.WriteLine("****************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:");
            Console.WriteLine("****************************************");
            int res = ds.Calculate(mtrx);

            Console.WriteLine("Количество положительных элементов:" +res);

            Console.ReadKey();
        }
    }
}
