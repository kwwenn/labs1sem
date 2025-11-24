using System;

namespace _3lab
{
    public class ConnectFourGame
    {
        public const int ROWS = 6;
        public const int COLS = 7;
        public const char EMPTY = '.';
        public const char PLAYER_X = 'X';
        public const char PLAYER_O = 'O';

        private char[,] _board;
        private char _currentPlayer;
        private bool _gameOver;
        private char _winner;

        public ConnectFourGame()
        {
            _board = InitializeBoard();
            _currentPlayer = PLAYER_X;
            _gameOver = false;
            _winner = EMPTY;
        }
        public char[,] Board => (char[,])_board.Clone();
        public char CurrentPlayer => _currentPlayer;
        public bool GameOver => _gameOver;
        public char Winner => _winner;

        public bool MakeMove(int column)
        {
            if (_gameOver || column < 0 || column >= COLS || IsColumnFull(column))
                return false;

            for (int row = ROWS - 1; row >= 0; row--)
            {
                if (_board[row, column] == EMPTY)
                {
                    _board[row, column] = _currentPlayer;

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
                    return true;
                }
            }
            return false;
        }

        public void ResetGame()
        {
            _board = InitializeBoard();
            _currentPlayer = PLAYER_X;
            _gameOver = false;
            _winner = EMPTY;
        }

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

        private void SwitchPlayer()
        {
            _currentPlayer = (_currentPlayer == PLAYER_X) ? PLAYER_O : PLAYER_X;
        }

        private bool IsColumnFull(int column)
        {
            return _board[0, column] != EMPTY;
        }

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
    }
}