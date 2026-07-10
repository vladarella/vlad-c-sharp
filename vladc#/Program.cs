using System.ComponentModel.Design;

namespace vladc_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //console.write("введите положительное число: ");

            //int number;

            //while (!int.tryparse(console.readline(), out number) || number <= 0)
            //{
            //    console.write("введите положительное число: ");
            //}

            //// пасхалка
            //if (number == 67)
            //{
            //    console.writeline("уважаю тех, кто знает этот мем ");
            //}

            //int count = 0;

            //while (number > 0)
            //{
            //    count++;
            //    number /= 10;
            //}

            //console.writeline($"количество цифр = {count}");


            //2   
            //console.write("введите положительное число: ");

            //int number;

            //while (!int.tryparse(console.readline(), out number) || number <= 0)
            //{
            //    console.write("введите положительное число!!! ");
            //}

            //int max = 0;

            //while (number > 0)
            //{
            //    int digit = number % 10;

            //    if (digit > max)
            //    {
            //        max = digit;
            //    }

            //    number /= 10;
            //}

            //console.writeline($"самая большая цифра = {max}");


            //3 
            Console.Write("Введите положительное число: ");

            int number;

            while (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
            {
                Console.Write("Введите положительное число: ");
            }

            int first = number;
            int obratno = 0;

            while (number > 0)
            {
                int digit = number % 10;
                obratno = obratno * 10 + digit;
                number /= 10;
            }

            if (first == obratno)
            {
                Console.WriteLine("Число является палиндромом.");
            }
            else
            {
                Console.WriteLine("Число не является палиндромом.");
            }
        }
    }
}
