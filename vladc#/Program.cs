using System.ComponentModel.Design;

namespace vladc_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Введите положительное число: ");

            //int number;

            //while (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
            //{
            //    Console.Write("Введите положительное число: ");
            //}

            //// Пасхалка
            //if (number == 67)
            //{
            //    Console.WriteLine("Уважаю тех, кто знает этот мем ");
            //}

            //int count = 0;

            //while (number > 0)
            //{
            //    count++;
            //    number /= 10;
            //}

            //Console.WriteLine($"Количество цифр = {count}");


            //2  не знаю 
            Console.Write("Введите положительное число: ");

            int number;

            while (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
            {
                Console.Write("Введите положительное число: ");
            }

            //3 не знаю

        }
    }
}
