namespace _3lab
{
    partial class FormFunctionGame
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAttempts = new System.Windows.Forms.TextBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserAnswer = new System.Windows.Forms.TextBox();
            this.btnCheckAnswer = new System.Windows.Forms.Button();
            this.lblAttemptsLeft = new System.Windows.Forms.Label();
            this.progressBarTime = new System.Windows.Forms.ProgressBar();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.lblCorrectValue = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFormula = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "A:";
 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "B:";

            this.txtA.Location = new System.Drawing.Point(50, 67);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 2;
            this.txtA.Text = "1";

            this.txtB.Location = new System.Drawing.Point(50, 97);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 3;
            this.txtB.Text = "2";

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Попытки:";

            this.txtAttempts.Location = new System.Drawing.Point(230, 67);
            this.txtAttempts.Name = "txtAttempts";
            this.txtAttempts.Size = new System.Drawing.Size(50, 20);
            this.txtAttempts.TabIndex = 5;
            this.txtAttempts.Text = "3";

            this.btnStartGame.Location = new System.Drawing.Point(300, 65);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(75, 50);
            this.btnStartGame.TabIndex = 6;
            this.btnStartGame.Text = "Начать игру";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);

            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ваш ответ (округлить до 2 знаков):";

            this.txtUserAnswer.Enabled = false;
            this.txtUserAnswer.Location = new System.Drawing.Point(140, 147);
            this.txtUserAnswer.Name = "txtUserAnswer";
            this.txtUserAnswer.Size = new System.Drawing.Size(100, 20);
            this.txtUserAnswer.TabIndex = 8;

            this.btnCheckAnswer.Enabled = false;
            this.btnCheckAnswer.Location = new System.Drawing.Point(264, 140);
            this.btnCheckAnswer.Name = "btnCheckAnswer";
            this.btnCheckAnswer.Size = new System.Drawing.Size(75, 23);
            this.btnCheckAnswer.TabIndex = 9;
            this.btnCheckAnswer.Text = "Проверить";
            this.btnCheckAnswer.UseVisualStyleBackColor = true;
            this.btnCheckAnswer.Click += new System.EventHandler(this.btnCheckAnswer_Click);

            this.lblAttemptsLeft.AutoSize = true;
            this.lblAttemptsLeft.Location = new System.Drawing.Point(20, 180);
            this.lblAttemptsLeft.Name = "lblAttemptsLeft";
            this.lblAttemptsLeft.Size = new System.Drawing.Size(0, 13);
            this.lblAttemptsLeft.TabIndex = 10;
 
            this.progressBarTime.Location = new System.Drawing.Point(20, 200);
            this.progressBarTime.Name = "progressBarTime";
            this.progressBarTime.Size = new System.Drawing.Size(355, 10);
            this.progressBarTime.TabIndex = 11;
 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Location = new System.Drawing.Point(20, 220);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(0, 13);
            this.lblTimeLeft.TabIndex = 12;

            this.lblCorrectValue.AutoSize = true;
            this.lblCorrectValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCorrectValue.ForeColor = System.Drawing.Color.Red;
            this.lblCorrectValue.Location = new System.Drawing.Point(20, 240);
            this.lblCorrectValue.Name = "lblCorrectValue";
            this.lblCorrectValue.Size = new System.Drawing.Size(0, 13);
            this.lblCorrectValue.TabIndex = 13;

            this.btnBack.Location = new System.Drawing.Point(300, 230);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(20, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(319, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Игра: Угадайте значение функции f(A, B)";

            this.lblFormula.AutoSize = true;
            this.lblFormula.Location = new System.Drawing.Point(20, 35);
            this.lblFormula.Name = "lblFormula";
            this.lblFormula.Size = new System.Drawing.Size(322, 13);
            this.lblFormula.TabIndex = 16;
            this.lblFormula.Text = "f(A,B) = (cos(π)⁷ + √ln(B⁴)) / sin²(π/2 + A)  (округлить до 2 знаков)";

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 270);
            this.Controls.Add(this.lblFormula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblCorrectValue);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.progressBarTime);
            this.Controls.Add(this.lblAttemptsLeft);
            this.Controls.Add(this.btnCheckAnswer);
            this.Controls.Add(this.txtUserAnswer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.txtAttempts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormFunctionGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра с функцией";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAttempts;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserAnswer;
        private System.Windows.Forms.Button btnCheckAnswer;
        private System.Windows.Forms.Label lblAttemptsLeft;
        private System.Windows.Forms.ProgressBar progressBarTime;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Label lblCorrectValue;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFormula;
    }
}