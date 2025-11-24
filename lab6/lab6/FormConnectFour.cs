using System;
using System.Drawing;
using System.Windows.Forms;

namespace _3lab
{
    public partial class FormConnectFour : Form
    {
        private ConnectFourGame game;
        private Button[,] boardButtons;

        public FormConnectFour()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            game = new ConnectFourGame();
            CreateBoardButtons();
            UpdateGameStatus();
        }

        private void CreateBoardButtons()
        {
            panelBoard.Controls.Clear();
            boardButtons = new Button[ConnectFourGame.ROWS, ConnectFourGame.COLS];

            for (int row = 0; row < ConnectFourGame.ROWS; row++)
            {
                for (int col = 0; col < ConnectFourGame.COLS; col++)
                {
                    Button button = new Button();
                    button.Size = new Size(50, 50);
                    button.Location = new Point(col * 55, row * 55);
                    button.Tag = col; 
                    button.Click += BoardButton_Click;
                    button.BackColor = Color.LightBlue;
                    button.Font = new Font("Arial", 12, FontStyle.Bold);
                    boardButtons[row, col] = button;
                    panelBoard.Controls.Add(button);
                }
            }
        }

        private void BoardButton_Click(object sender, EventArgs e)
        {
            if (game.GameOver)
            {
                MessageBox.Show("Игра завершена. Начните новую игру.");
                return;
            }

            Button clickedButton = (Button)sender;
            int col = (int)clickedButton.Tag;

            if (game.MakeMove(col))
            {
                UpdateBoard();
                UpdateGameStatus();

                if (game.GameOver)
                {
                    if (game.Winner != ConnectFourGame.EMPTY)
                    {
                        MessageBox.Show($"Игрок {game.Winner} победил!");
                    }
                    else
                    {
                        MessageBox.Show("Ничья!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Невозможно сделать ход в этот столбец. Он может быть заполнен.");
            }
        }

        private void UpdateBoard()
        {
            char[,] board = game.Board;

            for (int row = 0; row < ConnectFourGame.ROWS; row++)
            {
                for (int col = 0; col < ConnectFourGame.COLS; col++)
                {
                    Button button = boardButtons[row, col];
                    char cell = board[row, col];

                    if (cell == ConnectFourGame.PLAYER_X)
                    {
                        button.Text = "X";
                        button.BackColor = Color.Red;
                        button.ForeColor = Color.White;
                    }
                    else if (cell == ConnectFourGame.PLAYER_O)
                    {
                        button.Text = "O";
                        button.BackColor = Color.Blue;
                        button.ForeColor = Color.White;
                    }
                    else
                    {
                        button.Text = "";
                        button.BackColor = Color.LightBlue;
                    }
                }
            }
        }

        private void UpdateGameStatus()
        {
            if (game.GameOver)
            {
                if (game.Winner != ConnectFourGame.EMPTY)
                {
                    lblStatus.Text = $"Победил игрок {game.Winner}!";
                }
                else
                {
                    lblStatus.Text = "Ничья!";
                }
            }
            else
            {
                lblStatus.Text = $"Текущий ход: Игрок {game.CurrentPlayer}";
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            InitializeGame();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}