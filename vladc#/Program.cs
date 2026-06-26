namespace vladc_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Вася - Учиеть програмироваия ";
            int number = 30;
            Double number2 = 7.6;
            char symbol = '@';
            bool result = true;
            //зделали парочку переменных
            Console.WriteLine(text + "ему " + number + ".\nОн работает " + number2 + " лет\nЕго любимый символ - " + symbol);
            Console.WriteLine("Есть ли у него питомец? - " + result);
            string text2 = Console.ReadLine();
            Console.WriteLine("Привет! " + text2);
            

        }
    }
}
