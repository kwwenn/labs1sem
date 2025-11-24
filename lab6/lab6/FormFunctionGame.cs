using System;
using System.Windows.Forms;

namespace _3lab
{
    public partial class FormFunctionGame : Form
    {
        private double correctValue;
        private int attemptsLeft;
        private Timer gameTimer;
        private int timeLeft = 30;

        public FormFunctionGame()
        {
            InitializeComponent();
            SetupTimer();
        }

        private void SetupTimer()
        {
            gameTimer = new Timer();
            gameTimer.Interval = 1000;
            gameTimer.Tick += GameTimer_Tick;
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtA.Text, out int a))
            {
                MessageBox.Show("Введите корректное значение для a");
                return;
            }

            if (!int.TryParse(txtB.Text, out int b))
            {
                MessageBox.Show("Введите корректное значение для b");
                return;
            }

            if (!int.TryParse(txtAttempts.Text, out int maxAttempts) || maxAttempts <= 0)
            {
                MessageBox.Show("Введите корректное количество попыток");
                return;
            }

            correctValue = FunctionGame.CalculateFunction(a, b);
            attemptsLeft = maxAttempts;

            lblCorrectValue.Text = $"Правильный ответ: {Math.Round(correctValue, 2)}";
            lblCorrectValue.Visible = false;

            UpdateAttemptsLabel();
            EnableGameControls(true);
            StartTimer();
        }

        private void btnCheckAnswer_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtUserAnswer.Text, out double userAnswer))
            {
                MessageBox.Show("Введите корректное число");
                return;
            }

            if (Math.Abs(userAnswer - Math.Round(correctValue, 2)) < 0.01)
            {
                MessageBox.Show("Поздравляем! Вы угадали!");
                EndGame(true);
            }
            else
            {
                attemptsLeft--;
                UpdateAttemptsLabel();

                if (attemptsLeft <= 0)
                {
                    MessageBox.Show("Попытки закончились!");
                    lblCorrectValue.Visible = true;
                    EndGame(false);
                }
                else
                {
                    MessageBox.Show("Неверно! Попробуйте еще раз.");
                }
            }
        }

        private void UpdateAttemptsLabel()
        {
            lblAttemptsLeft.Text = $"Осталось попыток: {attemptsLeft}";
        }

        private void StartTimer()
        {
            timeLeft = 30;
            progressBarTime.Value = 100;
            lblTimeLeft.Text = $"Осталось времени: {timeLeft} сек";
            gameTimer.Start();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            progressBarTime.Value = (int)((timeLeft / 30.0) * 100);
            lblTimeLeft.Text = $"Осталось времени: {timeLeft} сек";

            if (timeLeft <= 0)
            {
                gameTimer.Stop();
                MessageBox.Show("Время вышло!");
                lblCorrectValue.Visible = true;
                EndGame(false);
            }
        }

        private void EnableGameControls(bool enable)
        {
            btnCheckAnswer.Enabled = enable;
            txtUserAnswer.Enabled = enable;
        }

        private void EndGame(bool isWin)
        {
            EnableGameControls(false);
            gameTimer.Stop();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (gameTimer != null && gameTimer.Enabled)
            {
                gameTimer.Stop();
            }
            this.Close();
        }
    }
}