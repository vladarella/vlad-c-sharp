using System.ComponentModel.Design;

namespace vladc_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //Console.Write("Введите четырехзначное число ");
            //int number;
            //while (!int.TryParse(Console.ReadLine(), out number) || number < 1000 || number > 9999)
            //{
            //    Console.WriteLine("Ошибка! Введите четырехзначное число: ");

            //}
            //int count = 0;
            //int digit = number % 10;
            //if (digit % 2 == 0)
            //    count++;

            //digit = (number / 10) % 10;
            //if (digit % 2 == 0)
            //    count++;

            //digit = (number / 100) % 10;
            //if (digit % 2 == 0)
            //    count++;

            //digit = (number / 1000) % 10;
            //if (digit % 2 == 0)
            //    count++;

            //Console.WriteLine($"Количество четных цыфр {count}");

            //2 не знаю





            //3
            string password = "78945";

            int attempts = 0;

            while (attempts < 5)
            {
                Console.Write("Введите пароль: ");
                string input = Console.ReadLine();

                if (input == password)
                {
                    Console.WriteLine("Добро пожаловать!");
                    break;
                }
                else
                {
                    attempts++;

                    if (attempts == 5)
                    {
                        Console.WriteLine("Ага , попытался меня взломать - не выйдет ,доступ запрешен!");
                    }
                    else
                    {
                        Console.WriteLine("Неверный пароль. Попробуйте еще.");
                    }
                }
            }
        }
    }
}
