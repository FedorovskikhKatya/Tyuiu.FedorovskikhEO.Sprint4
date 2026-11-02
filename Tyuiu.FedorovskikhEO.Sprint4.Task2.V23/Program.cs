using Tyuiu.FedorovskikhEO.Sprint4.Task2.V23.Lib;
namespace Tyuiu.FedorovskikhEO.Sprint4.Task2.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd= new Random();
            DataService ds = new DataService();
            int len;

            Console.Write("Введите количество элементов массива: ");
            len = Convert.ToInt32(Console.ReadLine());

            int[] numsArray = new int[len];

            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write("Введите значение " + i + " элемента массива: ");
                numsArray[i] = rnd.Next(3,8);
            }

            Console.WriteLine();
            Console.WriteLine("Массив: ");

            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write(numsArray[i] + "\t");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("**************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:");
            Console.WriteLine("**************************************");

            int res = ds.Calculate(numsArray);

            Console.WriteLine(res);
        }
    }
}
