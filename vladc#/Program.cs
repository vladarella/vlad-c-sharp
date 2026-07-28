namespace vladc_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            /*int start;
            Console.Write("Введите начало диапазона: ");

            while (!int.TryParse(Console.ReadLine(), out start))
            {
                Console.Write("Ошибка! Введите целое число: ");
            }

            int end;
            Console.Write("Введите конец диапазона: ");

            while (!int.TryParse(Console.ReadLine(), out end))
            {
                Console.Write("Ошибка! Введите целое число: ");
            }

            while (end <= start)
            {
                Console.Write("Ошибка! Конец диапазона должен быть больше первого числа ");

                while (!int.TryParse(Console.ReadLine(), out end))
                {
                    Console.Write("Ошибка! Введите целое число: ");
                }
            }

            PrintNumberSquares(start, end);

            static void PrintNumberSquares(int start, int end)
            {
                for (int i = start; i <= end; i++)
                {
                    Console.WriteLine($"Число: {i}, квадрат: {i * i}");
                }
            }*/
            // Задание 2
            /*int number;

            Console.Write("Введите число: ");

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Ошибка! Введите целое число: ");
            }

            Console.WriteLine($"Число положительное: {(IsPositive(number) ? "Да" : "Нет")}");
            Console.WriteLine($"Число чётное: {(IsEven(number) ? "Да" : "Нет")}");
            Console.WriteLine($"Квадрат числа = {Square(number)}");
            Console.WriteLine($"Куб числа = {Cube(number)}");

            static bool IsPositive(int number)
            {
                return number > 0;
            }

            static bool IsEven(int number)
            {
                return number % 2 == 0;
            }

            static int Square(int number)
            {
                return number * number;
            }

            static int Cube(int number)
            {
                return number * number * number;
            }*/

            // Задание 3
            int size;
            Console.Write("Введите размер массивов: ");
            while (!int.TryParse(Console.ReadLine(), out size)||size<=0)
            {
                Console.Write("Ошибка! Введите целое число: ");
            }

            int[] array1 = new int[size];
            int[] array2 = new int[size];

            FillArray(array1);
            FillArray(array2);

            Console.WriteLine("Первый массив:");
            PrintArray(array1);

            Console.WriteLine("Второй массив:");
            PrintArray(array2);

            int sum1 = SumArray(array1);
            int sum2 = SumArray(array2);

            Console.WriteLine($"Сумма элементов первого массива: {sum1}");
            Console.WriteLine($"Сумма элементов второго массива: {sum2}");

            CompareSum(sum1, sum2);


            
            void FillArray(int[] array)
            {
                Random random = new Random();

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(1, 101);
                }
            }


            // Метод вывода массива
            void PrintArray(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }

                Console.WriteLine();
            }


            // Метод подсчёта суммы
            int SumArray(int[] array)
            {
                int sum = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }

                return sum;
            }


            // Метод сравнения сумм
            void CompareSum(int sum1, int sum2)
            {
                if (sum1 > sum2)
                {
                    Console.WriteLine("Первый массив больше");
                }
                else if (sum2 > sum1)
                {
                    Console.WriteLine("Второй массив больше");
                }
                else
                {
                    Console.WriteLine("Суммы массивов равны");
                }
            }
        }
    }
}
