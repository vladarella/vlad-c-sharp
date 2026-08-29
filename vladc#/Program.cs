
using System;
using System.IO;

namespace vladc
{
    internal class Program
    {
        const int FieldSize = 3;
        const int CoordinatesCount = 2;
        const int FirstIndex = 0;
        const int LastIndex = FieldSize - 1;
        const int SecondCoordinate = 1;

        const string ScoreFile = "score.txt";

        static void Main()
        {
            Menu();
        }

        static void Menu()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("1. Начать новую игру");
                Console.WriteLine("2. Таблица матчей");
                Console.WriteLine("3. Выйти из игры");

                Console.Write("Выберите действие: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Ошибка! Введите число.");
                    Console.ReadLine();
                    continue;
                }

                if (choice == 1)
                {
                    StartGame();
                }
                else if (choice == 2)
                {
                    ShowTable();
                }
                else if (choice == 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка! Выберите 1, 2 или 3.");
                    Console.ReadLine();
                }
            }
        }

        static void StartGame()
        {
            // Кортеж для хранения информации о матче
            (string XPlayer, string OPlayer, GameResult Result, DateTime MatchTime) record;

            Console.Clear();

            // Опрос никнеймов
            Console.Write("Введите никнейм игрока X: ");
            record.XPlayer = Console.ReadLine();

            Console.Write("Введите никнейм игрока O: ");
            record.OPlayer = Console.ReadLine();

            char[,] field = CreatField();
            char player = 'X';

            while (true)
            {
                Console.Clear();

                PrintField(field);

                Console.WriteLine();



                if (player == 'X')
                {
                    Console.WriteLine($"Ход игрока X — {record.XPlayer}");
                }
                else
                {
                    Console.WriteLine($"Ход игрока O — {record.OPlayer}");
                }

                int[] cordinates = PlayersCordinates();

                PlayerMove(field, cordinates, player);

                if (CheckWin(field, player))
                {
                    Console.Clear();

                    PrintField(field);

                    Console.WriteLine();
                    Console.WriteLine($"Игрок {player} победил!");

                    if (player == 'X')
                    {
                        record.Result = GameResult.Win;
                    }
                    else
                    {
                        record.Result = GameResult.Over;
                    }

                    break;
                }

                if (IsFieldFull(field))
                {
                    Console.Clear();

                    PrintField(field);

                    Console.WriteLine();
                    Console.WriteLine("Ничья!");

                    record.Result = GameResult.Draw;

                    break;
                }

                player = ChangePlayer(player);
            }

            // Записываю дату и время после окончания матча
            record.MatchTime = DateTime.Now;

            // Добавляем матч в файл
            SaveRecord(record);

           
            Console.WriteLine();
            Console.WriteLine("Результат матча сохранён!");
            Console.WriteLine("Нажмите Enter...");
            Console.ReadLine();
        }

        static void SaveRecord((string XPlayer, string OPlayer, GameResult Result, DateTime MatchTime) record)
        {
            string line = $"{record.XPlayer}|{record.OPlayer}|{record.Result}|{record.MatchTime}";

            //добавление записи в файл с результатами матчей
            File.AppendAllText(ScoreFile,
            //переход на новую строку после каждой запис
            line + Environment.NewLine);
        }

        static void ShowTable()
        {
            Console.Clear();

            Console.WriteLine("______ Таблица Матчей ______");
            Console.WriteLine();

            if (!File.Exists(ScoreFile))
            {
                Console.WriteLine("Матчей пока нет.");
                Console.WriteLine();
                Console.WriteLine("Нажмите Enter...");
                Console.ReadLine();
                return;
            }

            string[] records = File.ReadAllLines(ScoreFile);

            if (records.Length == 0)
            {
                Console.WriteLine("Матчей пока нет.");
                Console.WriteLine();
                Console.WriteLine("Нажмите Enter...");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Игрок X\t\tИгрок O\t\tРезультат\t\tДата и время");
            Console.WriteLine(
            "-----------------------------------------------------------------------");

            foreach (string record in records)
            {
                string[] data = record.Split('|');

                if (data.Length != 4)
                {
                    continue;
                }

                string xPlayer = data[0];
                string oPlayer = data[1];
                string result = data[2];
                string matchTime = data[3];

                string resultText;

                if (result == GameResult.Win.ToString())
                {
                    resultText = "Победа X";
                }
                else if (result == GameResult.Over.ToString())
                {
                    resultText = "Победа O";
                }
                else
                {
                    resultText = "Ничья";
                }

                Console.WriteLine($"{xPlayer,-16} {oPlayer,-16} {resultText,-16} {matchTime}");
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите Enter Чтобы выйти из таблицы");
            Console.ReadLine();
        }

        static char[,] CreatField()
        {
            char[,] field = new char[FieldSize, FieldSize];

            for (int i = FirstIndex; i < field.GetLength(0); i++)
            {
                for (int j = FirstIndex; j < field.GetLength(1); j++)
                {
                    field[i, j] = ' ';
                }
            }

            return field;
        }

        static void PrintField(char[,] field)
        {
            for (int i = FirstIndex; i < field.GetLength(0); i++)
            {
                Console.Write("|");

                for (int j = FirstIndex; j < field.GetLength(1); j++)
                {
                    if (field[i, j] == 'X')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($" {field[i, j]} ");
                        Console.ResetColor();
                    }
                    else if (field[i, j] == 'O')
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($" {field[i, j]} ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write($" {field[i, j]} ");
                    }

                    Console.Write("|");
                }

                Console.WriteLine();

                
                if (i < field.GetLength(0) - 1)
                {
                    Console.WriteLine("-------------");
                }
            }
        }

        static int[] PlayersCordinates()
        {
            int[] cordinates = new int[CoordinatesCount];

            Console.WriteLine($"Введите номер строки от {FirstIndex} до {LastIndex}");

            while (!int.TryParse(
            Console.ReadLine(),
            out cordinates[FirstIndex]) ||
            cordinates[FirstIndex] < FirstIndex ||
            cordinates[FirstIndex] >= FieldSize)
            {
                Console.WriteLine("Ошибка! Введите целое число");
            }

            Console.WriteLine($"Введите номер столбца от {FirstIndex} до {LastIndex}");

            while (!int.TryParse(
            Console.ReadLine(),
            out cordinates[SecondCoordinate]) ||
            cordinates[SecondCoordinate] < FirstIndex ||
            cordinates[SecondCoordinate] >= FieldSize)
            {
                Console.WriteLine("Ошибка! Введите целое число");
            }

            return cordinates;
        }

        static void PlayerMove(
        char[,] field,
        int[] cordinates,
        char playerSymbol)
        {
            while (field[
            cordinates[FirstIndex],
            cordinates[SecondCoordinate]] != ' ')
            {
                Console.WriteLine(
                "Эта клетка уже занята! Введите новые координаты.");

                cordinates = PlayersCordinates();
            }

            field[
            cordinates[FirstIndex],
            cordinates[SecondCoordinate]] = playerSymbol;
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
            for (int i = FirstIndex; i < field.GetLength(0); i++)
            {
                for (int j = FirstIndex; j < field.GetLength(1); j++)
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
            for (int i = FirstIndex; i < field.GetLength(0); i++)
            {
                bool win = true;

                for (int j = FirstIndex; j < field.GetLength(1); j++)
                {
                    if (field[i, j] != player)
                    {
                        win = false;
                        break;
                    }
                }

                if (win)
                {
                    return true;
                }
            }

            // Проверка столбцов
            for (int j = FirstIndex; j < field.GetLength(1); j++)
            {
                bool win = true;

                for (int i = FirstIndex; i < field.GetLength(0); i++)
                {
                    if (field[i, j] != player)
                    {
                        win = false;
                        break;
                    }
                }

                if (win)
                {
                    return true;
                }
            }

            // Главная диагональ
            bool mainDiagonal = true;

            for (int i = FirstIndex; i < field.GetLength(0); i++)
            {
                if (field[i, i] != player)
                {
                    mainDiagonal = false;
                    break;
                }
            }

            if (mainDiagonal)
            {
                return true;
            }

            // Побочная диагональ
            bool secondaryDiagonal = true;

           
            for (int i = FirstIndex; i < field.GetLength(0); i++)
            {
                int j = LastIndex - i;

                if (field[i, j] != player)
                {
                    secondaryDiagonal = false;
                    break;
                }
            }

            return secondaryDiagonal;
        }
        enum GameResult
        {
            Win = 1,
            Over = 2,
            Draw = 3
        }
    }
}
