using Tyuiu.FedorovskikhEO.Sprint4.Task7.V25.Lib;
namespace Tyuiu.FedorovskikhEO.Sprint4.Task7.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 4;
            int columns = 3;

            int[,] mtrx = new int[rows, columns];

            string str = "348561792486";

            DataService ds = new DataService();

            Console.WriteLine("***********************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("***********************************************");

            int index = 0;

            Console.WriteLine("\nМатрица:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(str[index] + "\t");
                    index++;
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("***********************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:");
            Console.WriteLine("***********************************************");

            int res = ds.Calculate(rows, columns, str);

            Console.WriteLine("Сумма чётных чисел = " + res);

            Console.ReadKey();
        }
    }
}
