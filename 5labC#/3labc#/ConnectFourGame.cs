using _5lab;
using System;

namespace _3lab
{
    /// <summary>
    /// Класс, реализующий игру "4 в ряд"
    /// </summary>
    public class ConnectFourGame
    {
        /// <summary>
        /// Размер игрового поля по вертикали (количество строк)
        /// </summary>
        public const int ROWS = 6;

        /// <summary>
        /// Размер игрового поля по горизонтали (количество столбцов)
        /// </summary>
        public const int COLS = 7;

        /// <summary>
        /// Обозначение пустой ячейки
        /// </summary>
        public const char EMPTY = '.';

        /// <summary>
        /// Обозначение фишки первого игрока
        /// </summary>
        public const char PLAYER_X = 'X';

        /// <summary>
        /// Обозначение фишки второго игрока
        /// </summary>
        public const char PLAYER_O = 'O';

        private char[,] _board;
        private char _currentPlayer;
        private bool _gameOver;
        private char _winner;

        /// <summary>
        /// Инициализирует новую игру "4 в ряд"
        /// </summary>
        public ConnectFourGame()
        {
            _board = InitializeBoard();
            _currentPlayer = PLAYER_X;
            _gameOver = false;
            _winner = EMPTY;
        }

        /// <summary>
        /// Запускает основной игровой цикл
        /// </summary>
        public void Play()
        {
            Console.WriteLine("Игра '4 в ряд'");
            Console.WriteLine("Игроки по очереди бросают фишки в столбцы");
            Console.WriteLine("Побеждает тот, кто первым соберет 4 фишки в ряд\n");
            Console.WriteLine("Нажмите любую клавишу для начала");
            Console.ReadKey();

            while (!_gameOver)
            {
                PrintBoard();
                int col = GetPlayerMove();
                MakeMove(col);

                if (CheckWin(_currentPlayer))
                {
                    _gameOver = true;
                    _winner = _currentPlayer;
                }
                else if (CheckDraw())
                {
                    _gameOver = true;
                }
                else
                {
                    SwitchPlayer();
                }
            }

            PrintBoard();
            DisplayGameResult();
        }

        /// <summary>
        /// Инициализирует пустое игровое поле
        /// </summary>
        /// <returns>Двумерный массив, представляющий игровое поле</returns>
        private char[,] InitializeBoard()
        {
            char[,] board = new char[ROWS, COLS];
            for (int row = 0; row < ROWS; row++)
            {
                for (int col = 0; col < COLS; col++)
                {
                    board[row, col] = EMPTY;
                }
            }
            return board;
        }

        /// <summary>
        /// Выводит текущее состояние игрового поля на экран
        /// </summary>
        private void PrintBoard()
        {
            Console.Clear();
            Console.WriteLine("=== ИГРА '4 В РЯД' ===\n");

            Console.Write("  ");
            for (int col = 0; col < COLS; col++)
            {
                Console.Write($"{col + 1} ");
            }
            Console.WriteLine();

            Console.Write(" ");
            for (int col = 0; col < COLS * 2 + 1; col++)
            {
                Console.Write("─");
            }
            Console.WriteLine();

            for (int row = 0; row < ROWS; row++)
            {
                Console.Write("│ ");
                for (int col = 0; col < COLS; col++)
                {
                    if (_board[row, col] == PLAYER_X)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("X ");
                        Console.ResetColor();
                    }
                    else if (_board[row, col] == PLAYER_O)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("O ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(". ");
                    }
                }
                Console.WriteLine("│");
            }

            Console.Write(" ");
            for (int col = 0; col < COLS * 2 + 1; col++)
            {
                Console.Write("─");
            }
            Console.WriteLine();

            Console.WriteLine($"\nХод игрока {_currentPlayer}");
        }

        /// <summary>
        /// Получает ход от текущего игрока
        /// </summary>
        /// <returns>Номер выбранного столбца (0-based)</returns>
        private int GetPlayerMove()
        {
            while (true)
            {
                Console.Write($"Игрок {_currentPlayer}, введите номер столбца (1 - {COLS}): ");
                int col = InputValidator.GetIntInput();
                if (col < 1 || col > COLS)
                {
                    Console.WriteLine($"Некорректный номер столбца. Введите число от 1 до {COLS}");
                    continue;
                }
                if (IsColumnFull(col - 1))
                {
                    Console.WriteLine("Этот столбец уже заполнен. Выберите другой столбец");
                    continue;
                }
                return col - 1;
            }
        }

        /// <summary>
        /// Выполняет ход - помещает фишку в указанный столбец
        /// </summary>
        /// <param name="column">Номер столбца (0-based)</param>
        private void MakeMove(int column)
        {
            for (int row = ROWS - 1; row >= 0; row--)
            {
                if (_board[row, column] == EMPTY)
                {
                    _board[row, column] = _currentPlayer;
                    break;
                }
            }
        }

        /// <summary>
        /// Переключает текущего игрока
        /// </summary>
        private void SwitchPlayer()
        {
            _currentPlayer = (_currentPlayer == PLAYER_X) ? PLAYER_O : PLAYER_X;
        }

        /// <summary>
        /// Проверяет, заполнен ли указанный столбец
        /// </summary>
        /// <param name="column">Номер столбца (0-based)</param>
        /// <returns>true - если столбец заполнен, иначе false</returns>
        private bool IsColumnFull(int column)
        {
            return _board[0, column] != EMPTY;
        }

        /// <summary>
        /// Проверяет победу текущего игрока
        /// </summary>
        /// <param name="player">Символ игрока для проверки</param>
        /// <returns>true - если игрок победил, иначе false</returns>
        private bool CheckWin(char player)
        {
            // Горизонтальная проверка
            for (int row = 0; row < ROWS; row++)
            {
                for (int col = 0; col < COLS - 3; col++)
                {
                    if (_board[row, col] == player &&
                        _board[row, col + 1] == player &&
                        _board[row, col + 2] == player &&
                        _board[row, col + 3] == player)
                    {
                        return true;
                    }
                }
            }

            // Вертикальная проверка
            for (int row = 0; row < ROWS - 3; row++)
            {
                for (int col = 0; col < COLS; col++)
                {
                    if (_board[row, col] == player &&
                        _board[row + 1, col] == player &&
                        _board[row + 2, col] == player &&
                        _board[row + 3, col] == player)
                    {
                        return true;
                    }
                }
            }

            // Диагональ: слева-сверху справа-вниз
            for (int row = 0; row < ROWS - 3; row++)
            {
                for (int col = 0; col < COLS - 3; col++)
                {
                    if (_board[row, col] == player &&
                        _board[row + 1, col + 1] == player &&
                        _board[row + 2, col + 2] == player &&
                        _board[row + 3, col + 3] == player)
                    {
                        return true;
                    }
                }
            }

            // Диагональ: справа-сверху слева-вниз
            for (int row = 0; row < ROWS - 3; row++)
            {
                for (int col = 3; col < COLS; col++)
                {
                    if (_board[row, col] == player &&
                        _board[row + 1, col - 1] == player &&
                        _board[row + 2, col - 2] == player &&
                        _board[row + 3, col - 3] == player)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Проверяет ничью (все столбцы заполнены)
        /// </summary>
        /// <returns>true - если ничья, иначе false</returns>
        private bool CheckDraw()
        {
            for (int col = 0; col < COLS; col++)
            {
                if (!IsColumnFull(col))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Отображает результат игры
        /// </summary>
        private void DisplayGameResult()
        {
            if (_winner != EMPTY)
            {
                Console.WriteLine($"\nПоздравляем! Игрок {_winner} победил!");
            }
            else
            {
                Console.WriteLine("\nНичья!");
            }
        }
    }
}