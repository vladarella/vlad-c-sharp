namespace vladc_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[,] numbers = new int[3, 5];

            //Console.WriteLine("рандомные числа:");
            ////строки
            //for (int i = 0; i < 3; i++)
            //{  //столбики
            //    for (int j = 0; j < 5; j++)
            //    {
            //        numbers[i, j] = new Random().Next(10, 21);
            //        Console.Write(numbers[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //Console.Write("Введите номер строки (0-2): ");
            //int line = Convert.ToInt32(Console.ReadLine());

            //int sum = 0;
            // //перебераем элементы строки и суммируем их
            //for (int j = 0; j < 5; j++)
            //{
            //    sum += numbers[line, j];
            //}

            //Console.WriteLine($"Сумма элементов строки = {sum}");

            //2
            //int[,] numbers = new int[3, 4];

            //Console.WriteLine("таблица с числами");
            //  //строки 
            //for (int i = 0; i < 3; i++)
            //{    //столбики
            //    for (int j = 0; j < 4; j++)
            //    {
            //        numbers[i, j] = new Random().Next(10, 101);
            //        Console.Write(numbers[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //int maxSum = 0;
            //int maxColumn = 0;
            //// перебираем столбцы
            //for (int j = 0; j < 4; j++)
            //{
            //    int sum = 0;

            //    for (int i = 0; i < 3; i++)
            //    {   //добавляем в очередь
            //        sum += numbers[i, j];
            //    }

            //    Console.WriteLine($"Сумма {j + 1} столбца = {sum}");

            //    if (j == 0 || sum > maxSum)
            //    {
            //        maxSum = sum;
            //        maxColumn = j + 1;
            //    }
            //}

            //Console.WriteLine($"Столбец с максимальной суммой = {maxColumn}");
            //Console.WriteLine($"Максимальная сумма = {maxSum}");

            //3
            int[,] numbers = new int[4, 4];

            Console.WriteLine("Матрица:");

            for (int i = 0; i < 4; i++)
            {             //создаем таблицу 4 на 4
                for (int j = 0; j < 4; j++)
                {
                    numbers[i, j] = new Random().Next(-10, 11);
                    Console.Write(numbers[i, j] + "\t");
                }
                Console.WriteLine();
            }

            bool mainFound = false;
            //главная диагональ
            bool sideFound = false;
            //побочная диагональ

            Console.WriteLine("Положительные элементы главной диагонали:");
            //перебираем элементы главной диагонали
            for (int i = 0; i < 4; i++)
            {
                if (numbers[i, i] > 0)
                {
                    Console.Write(numbers[i, i] + " ");
                    mainFound = true;
                }
            }
            // положительные элементы главной диагонали
            if (mainFound == false)
            {
                Console.WriteLine("Положительных элементов нет.");
            }

            Console.WriteLine();

            Console.WriteLine("Положительные элементы побочной диагонали:");
            //перебираем элементы побочной диагонали
            for (int i = 0; i < 4; i++)
            {
                if (numbers[i, 3 - i] > 0)
                {     //число на побочной диогонале 
                    Console.Write(numbers[i, 3 - i] + " ");
                    sideFound = true;
                }
            }
            // положительные элементы побочной диагонали
            if (sideFound == false)
            {
                Console.WriteLine("Положительных элементов нет.");
            }

        }
    }
}
