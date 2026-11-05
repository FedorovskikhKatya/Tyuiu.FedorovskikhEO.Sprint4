using Tyuiu.FedorovskikhEO.Sprint4.Task6.V16.Lib;
namespace Tyuiu.FedorovskikhEO.Sprint4.Task6.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.WriteLine("**********************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("**********************************************");
            var transport = new string[] { "Автомобиль", "Велосипед", "Самолет", "Поезд", "Трамвай", "Троллейбус", "Метро" };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < transport.Length; i++)
            {
                Console.WriteLine(transport[i]);
            }

            Console.WriteLine("************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:");
            Console.WriteLine("************************************************************");
            Console.WriteLine("Количество элементов длина которых = 7:");

            int nums = ds.Calculate(transport);

            Console.WriteLine(nums);
            Console.ReadKey();
        }
    }
}
