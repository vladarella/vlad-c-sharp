namespace vladc_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string text = "Вася - Учиеть програмироваия ";
            //int number = 30;
            //Double number2 = 7.6;
            //char symbol = '@';
            //bool result = true;
            //зделали парочку переменных
            //Console.WriteLine(text + "ему " + number + ".\nОн работает " + number2 + " лет\nЕго любимый символ - " + symbol);
            //Console.WriteLine("Есть ли у него питомец? - " + result);
            Console.Write("Введите ваше имя. ");
            string name = Console.ReadLine();

            Console.Write("Сколько вам лет?");
            int age = int.Parse(Console.ReadLine());

            Console.Write("На ваше усмотрение какой самый красивый символ?");
            char symbol = char.Parse(Console.ReadLine());

            Console.Write("Вы любите програмированрие?");
             string answer = (Console.ReadLine());
            bool result;
            if (answer == "да" || answer == "yes")
                result = true;
            else if (answer == "нет" || answer == "no")
                result = false;

            Console.WriteLine($"Ваше имя - {name}");
            Console.WriteLine($"Вам {age} лет");
            Console.WriteLine($"Ваш любимый символ - {symbol}");
            if (answer == "да") Console.WriteLine(" Да вы любите програмирование");
            else if (answer == "нет") Console.WriteLine("Нет вы не любите програмирование"); 
            
            

        }
    }
}
