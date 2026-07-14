namespace vladc_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //Random random = new Random();

            //int[] numbers = new int[10];
            //int sum = 0;

            //Console.WriteLine("Генерируються числа");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    //создаем случайное число от -10 до 10
            //    numbers[i] = random.Next(-10, 11);
            //    Console.Write(numbers[i] + " ");

            //    //отрицательное число или нет
            //    if (numbers[i] < 0)
            //    {
            //        //добавляем число в суму
            //        sum += numbers[i];
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine($"Сумма отрицательных элементов = {sum}");


            //2
            //Random random = new Random();

            //int[] numbers = new int[10];

            //Console.WriteLine("Рандомные числа");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = random.Next(-10, 11);
            //    Console.Write(numbers[i] + " ");
            //}
            ////разделяем вывод на экран
            //Console.WriteLine();

            //bool found = false;
            //int smallEvenNumber = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    //находим четное число
            //    if (numbers[i] % 2 == 0)
            //    {
            //        //первое четное число или нет
            //        if (!found)
            //        {
            //            smallEvenNumber = numbers[i];
            //            found = true;
            //        }
            //        // сравниваем текущее четное число с наименьшим найденным
            //        else if (numbers[i] < smallEvenNumber)
            //        {
            //            //ставим текущее четное число как наименьшее
            //            smallEvenNumber = numbers[i];
            //        }
            //    }
            //}

            //if (found)
            //{
            //    Console.WriteLine($"Наименьшое четное число = {smallEvenNumber}");
            //}
            //else
            //{
            //    Console.WriteLine("Четных чисел нет.");
            //    Console.WriteLine($"Первое число массива = {numbers[0]}");
            //}

            //3
            //Random random = new Random();

            //int[] numbers = new int[10];

            //Console.WriteLine("10 случайных чисел");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = random.Next(-10, 11);
            //    Console.Write(numbers[i] + " ");
            //}
            //Console.WriteLine();
            ////находим минимальный и максимальный элементы 
            //int min = numbers[0];
            //int max = numbers[0];
            ////запоминаем индексы минимального и максимального элементов
            //int minIndex = 0;
            //int maxIndex = 0;

            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] < min)
            //    {
            //        //смотрим новое число меньше минималного
            //        min = numbers[i];
            //        //также не забываем про индекс
            //        minIndex = i;
            //    }

            //    if (numbers[i] > max)
            //    {
            //        // тоже самое
            //        max = numbers[i];
            //        maxIndex = i;
            //    }
            //}

            //int SumaIndexov = minIndex + maxIndex;

            //Console.WriteLine($"Минимальное число = {min}, номер = {minIndex}");
            //Console.WriteLine($"Максимальное число = {max}, номер = {maxIndex}");
            //Console.WriteLine($"Сумма номеров = {SumaIndexov}");
        }
    }
}
