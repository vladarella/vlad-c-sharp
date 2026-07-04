using System.ComponentModel.Design;

namespace vladc_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ставку");
            int stavky = int.Parse(Console.ReadLine());

            if (stavky < 5 || stavky > 100 || stavky % 5 != 0)
            {
                Console.WriteLine("Ошибка! некорректная ставка");
                return;
            }

            Random numbers = new Random();
            int A = numbers.Next(1, 10);
            int B = numbers.Next(1, 10);
            int C = numbers.Next(1, 10);

            Console.WriteLine("Вращаем барабан");
            Console.WriteLine($"{A} {B} {C}");

            double koef = 0;

            // три подряд одинаковых числа
            if (A == B && B == C)
            {
                if (A == 7)
                {
                    koef = 150 * 1.5;
                    Console.WriteLine("Вы сорвали ДЖЕКПОТ");
                }
                else
                {
                    koef = A * 10 * 1.5;
                }
            }




            //два полряд одинаковых числа
            else if (A == B && B != C)
            {
                if (A == 7)
                {
                    koef = 150 * 1.5;
                    Console.WriteLine("Вы сорвали Мини-ДЖЕКПОТ");
                }
                else
                {
                    koef = A * 1.25;
                }
            }

            //хотябы одна 7
            else if (A == 7 || B == 7 || C == 7)
            {
                koef = 1.6;
            }

            //Хотябы одна 9
            else if (A == 9 || B == 9 || C == 9)
            {
                koef = 1.35;
            }

            if (koef == 0)
            {
                Console.WriteLine("К сожелению,вы проиграли.");
            }
            else
            {
                double win = stavky * koef;
                Console.WriteLine($"Поздравляе вы выиграли!");
                Console.WriteLine("Выигрыш состовлает" + win + "$");
            }
                
            
        }       
    }
}
