namespace vladc_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] field = CreatField();
            char player = 'X';
            

            while (true)
            {
                PrintField(field);

                int[] cordinates = PlayersCordinates();

                PlayerMove(field, cordinates, player);

                if (CheckWin(field, player))
                {
                    PrintField(field);
                    Console.WriteLine($"Игрок {player} победил!");
                    break;
                }
                if (IsFieldFull(field))
                {
                    PrintField(field);
                    Console.WriteLine("Ничья!");
                    break;
                }
                player = ChangePlayer(player);
            }
            
        }
        static char[,] CreatField()
        {
            char[,] field = new char[3, 3];
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    field[i, j] = ' ';
                }
            }
            return field;
            
        }
        static void PrintField(char[,] field)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("|");

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($" {field[i, j]} |");
                }

                Console.WriteLine();

                if (i < 2)
                {
                    Console.WriteLine("-------------");
                }
            }
        }
        static int[] PlayersCordinates()
        {
            int[] cordinates = new int [2];
            Console.WriteLine("Введите номер строки от 0 до 2");
            while (!int.TryParse(Console.ReadLine(), out cordinates[0]) || cordinates[0]<0 || cordinates[0]>2) 
            {
                Console.WriteLine("Ошибка! Введите целое число");
                
            }

            Console.WriteLine("Введите номер столбца от 0 до 2");
            while (!int.TryParse(Console.ReadLine(), out cordinates[1]) || cordinates[1] < 0 || cordinates[1] > 2)
            {
                Console.WriteLine("Ошибка! Введите целое число");
                
            }
            return cordinates;
        }

        static void PlayerMove(char[,] field, int[] cordinates, char playerSymbol)
        {
            while(field[cordinates[0], cordinates[1]] != ' ')
            {
                Console.WriteLine("Эта клетка уже занята! Введите новые координаты.");
                cordinates = PlayersCordinates();
            }
             field[cordinates[0], cordinates[1]] = playerSymbol;
        }

        static char ChangePlayer(char player)
        {
            if (player == 'X')
            {
                return 'O';
            }

            return 'X';
        }
        static bool IsFieldFull(char[,] field)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (field[i, j] == ' ')
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static bool CheckWin(char[,] field, char player)
        {
            // Проверка строк
            for (int i = 0; i < 3; i++)
            {
                if (field[i, 0] == player &&
                    field[i, 1] == player &&
                    field[i, 2] == player)
                {
                    return true;
                }
            }

            // Проверка столбцов
            for (int i = 0; i < 3; i++)
            {
                if (field[0, i] == player &&
                    field[1, i] == player &&
                    field[2, i] == player)
                {
                    return true;
                }
            }

            // Главная диагональ
            if (field[0, 0] == player &&
                field[1, 1] == player &&
                field[2, 2] == player)
            {
                return true;
            }

            // Побочная диагональ
            if (field[0, 2] == player &&
                field[1, 1] == player &&
                field[2, 0] == player)
            {
                return true;
            }

            return false;
            
        }
    }
}
