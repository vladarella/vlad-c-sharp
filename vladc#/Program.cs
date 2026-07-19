namespace vladc_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[,] numbers = new int[3, 5];

            //Console.WriteLine("Рандомные числа:");

            ////  Делаем саму таблицу с числами
            //for (int i = 0; i < numbers.GetLength(0); i++)
            //{
            //    for (int j = 0; j < numbers.GetLength(1); j++)
            //    {
            //        numbers[i, j] = new Random().Next(10, 21);
            //    }
            //}

            //// проводим вывод таблицы с числами
            //for (int i = 0; i < numbers.GetLength(0); i++)
            //{
            //    for (int j = 0; j < numbers.GetLength(1); j++)
            //    {
            //        Console.Write(numbers[i, j] + "\t");
            //    }

            //    Console.WriteLine("\n");
            //}



            //int line;
            //Console.Write(" Введите номер строки (0-2): ");
            //while (!int.TryParse(Console.ReadLine(), out line) ||
            //       line < 0 || line >= numbers.GetLength(0))
            //{
            //    Console.Write("Ошибка! Введите номер строки (0-2): ");
            //}

            //int sum = 0;

            //// Вычисляем сумму строки
            //for (int j = 0; j < numbers.GetLength(1); j++)
            //{
            //    sum += numbers[line, j];
            //}

            //Console.WriteLine($"Сумма элементов строки = {sum}");

            //2
            //int[,] numbers = new int[3, 4];

            //Console.WriteLine("Двумерный массив:");

            //// создаем таблицу с рандомными числами от 10 до 100
            //for (int i = 0; i < numbers.GetLength(0); i++)
            //{
            //    for (int j = 0; j < numbers.GetLength(1); j++)
            //    {
            //        numbers[i, j] = new Random().Next(10, 101);
            //    }
            //}

            //// Выводим числа масива в виде таблицы
            //for (int i = 0; i < numbers.GetLength(0); i++)
            //{
            //    for (int j = 0; j < numbers.GetLength(1); j++)
            //    {
            //        Console.Write(numbers[i, j] + "\t");
            //    }

            //    Console.WriteLine();
            //}

            //int maxSum = 0;
            //int maxColumn = 0;
            //int[] sums = new int[numbers.GetLength(1)];

            //// Вычисляем сумму каждого столбца
            //for (int j = 0; j < numbers.GetLength(1); j++)
            //{
            //    int sum = 0;

            //    for (int i = 0; i < numbers.GetLength(0); i++)
            //    {
            //        sum += numbers[i, j];
            //    }

            //    sums[j] = sum;

            //    if (j == 0 || sum > maxSum)
            //    {
            //        maxSum = sum;
            //        maxColumn = j;
            //    }
            //}

            //// Выводим суммы столбцов
            //for (int j = 0; j < numbers.GetLength(1); j++)
            //{
            //    Console.WriteLine($"Сумма {j + 1} столбца = {sums[j]}");
            //}

            //Console.WriteLine($"Столбец с максимальной суммой = {maxColumn + 1}");
            //Console.WriteLine($"Максимальная сумма = {maxSum}");
            //3
            //int[,] numbers = new int[4, 4];

            //Console.WriteLine("Матрица");

            //// Заполняем матрицу
            //for (int i = 0; i < numbers.GetLength(0); i++)
            //{
            //    for (int j = 0; j < numbers.GetLength(1); j++)
            //    {
            //        numbers[i, j] = new Random().Next(-10, 11);
            //    }
            //}

            //// Выводим числа масива в виде м
            //for (int i = 0; i < numbers.GetLength(0); i++)
            //{
            //    for (int j = 0; j < numbers.GetLength(1); j++)
            //    {
            //        Console.Write(numbers[i, j] + "\t");
            //    }

            //    Console.WriteLine();
            //}

            //bool mainFound = false;
            //bool sideFound = false;

            //Console.WriteLine("Положительные элементы главной диагонали:");

            //// Главная диагональ
            //for (int i = 0; i < numbers.GetLength(0); i++)
            //{
            //    if (numbers[i, i] > 0)
            //    {
            //        Console.Write(numbers[i, i] + " ");
            //        mainFound = true;
            //    }
            //}

            //if (!mainFound)
            //{
            //    Console.WriteLine("Положительных элементов нет.");
            //}

            //Console.WriteLine();

            //Console.WriteLine("Положительные элементы побочной диагонали:");

            //// Побочная диагональ
            //for (int i = 0; i < numbers.GetLength(0); i++)
            //{
            //    if (numbers[i, numbers.GetLength(1) - 1 - i] > 0)
            //    {
            //        Console.Write(numbers[i, numbers.GetLength(1) - 1 - i] + " ");
            //        sideFound = true;
            //    }
            //}

            //if (!sideFound)
            //{
            //    Console.WriteLine("Положительных элементов нет.");
            //}

        }
    }
}
