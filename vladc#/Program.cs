using System.ComponentModel.Design;

namespace vladc_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ставку");
            int ставки = int.Parse(Console.ReadLine());

            if (ставки < 5 || ставки > 100 || ставки % 5 != 0)
            {
                Console.WriteLine("Ошибка! некорректная ставка");
                return;
            }

            Random чиселки = new Random();
            int A = чиселки.Next(1, 10);
            int B = чиселки.Next(1, 10);
            int C = чиселки.Next(1, 10);

            Console.WriteLine("Вращаем барабан");
            Console.WriteLine($"{A} {B} {C}");

            double коэффициент = 0;

            // три подряд одинаковых числа
            if (A == B && B == C)
            {
                if (A == 1) коэффициент = 10 * 1.5;
                else if (A == 2) коэффициент = 20 * 1.5;
                else if (A == 3) коэффициент = 30 * 1.5;
                else if (A == 4) коэффициент = 40 * 1.5;
                else if (A == 5) коэффициент = 50 * 1.5;
                else if (A == 6) коэффициент = 60 * 1.5;
                else if (A == 7)
                {
                    коэффициент = 150 * 1.5;
                    Console.WriteLine("Вы сорвали ДЖЕКПОТ!");
                }
                else if (A == 5) коэффициент = 80 * 1.5;
                else if (A == 6) коэффициент = 90 * 1.5;
            }

            //два полряд одинаковых числа
            else if (A == B && B != C)
            {
                if (A == 1) коэффициент = 1 * 1.25;
                else if (A == 2) коэффициент = 2 * 1.25;
                else if (A == 3) коэффициент = 3 * 1.25;
                else if (A == 4) коэффициент = 4 * 1.25;
                else if (A == 5) коэффициент = 5 * 1.25;
                else if (A == 6) коэффициент = 6 * 1.25;
                if (A == 7)
                {
                    коэффициент = 15 * 1.25;
                    Console.WriteLine("Вы сорвали Мини-ДЖЕКПОТ");
                }
                else if (A == 8) коэффициент = 8 * 1.25;
                else if (A == 9) коэффициент = 9 * 1.25;
            }

            //хотябы одна 7
            else if (A == 7 || B == 7 || C == 7)
            {
                коэффициент = 1.6;
            }

            //Хотябы одна 9
            else if (A == 9 || B == 9 || C == 9)
            {
                коэффициент = 1.35;
            }

            if (коэффициент == 0)
            {
                Console.WriteLine("К сожелению,вы проиграли.");
            }
            else
            {
                double награда = ставки * коэффициент;
                Console.WriteLine($"Поздравляе вы выиграли!");
                Console.WriteLine("Выигрыш состовлает" + награда + "$");
            }
                
            
        }       
    }
}
