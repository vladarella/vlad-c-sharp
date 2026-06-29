namespace vladc_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Первая задача
            //Console.Write("Введите первое число: ");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write("Введите второе число: ");
            //int y = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Решим пример  - (a + b):2 Подставляем первое и второе числа и получаеться = {(double)(x + y)/(2)}");

            //Вторая задача
            //Console.Write("Введите первое число: ");
            //int A = int.Parse(Console.ReadLine());
            //Console.Write("Введите второе число: ");
            //int B = int.Parse(Console.ReadLine());
            //Console.Write("Введите третье число: ");
            //int C = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Решим пример - (a*b):3 + c Подставляем первое второе и третье числа и получаеться = {(double)(A*B)/3 + C}");

            //Третья задача
            Console.Write("Введите первое число: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int B = int.Parse(Console.ReadLine());
            Console.Write("Введите третье число: ");
            int C = int.Parse(Console.ReadLine());
            Console.Write("Введите четвертое число: ");
            int D = int.Parse(Console.ReadLine());
            Console.WriteLine($"Решим пример - ((a*b):2 + (c*d)):3 Подставляем первое второе третье и четвертое числа и получаеться = ");
            Console.WriteLine($"{(double)((A*B/2) + (C*D))/3}");
        }
    }
}
