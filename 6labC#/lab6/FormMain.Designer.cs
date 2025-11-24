namespace _3lab
{
    partial class FormMain
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
            this.btnFunctionGame = new System.Windows.Forms.Button();
            this.btnArrayWork = new System.Windows.Forms.Button();
            this.btnConnectFour = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnSlarkStack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFunctionGame
            // 
            this.btnFunctionGame.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnFunctionGame.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFunctionGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFunctionGame.Location = new System.Drawing.Point(25, 50);
            this.btnFunctionGame.Name = "btnFunctionGame";
            this.btnFunctionGame.Size = new System.Drawing.Size(200, 35);
            this.btnFunctionGame.TabIndex = 0;
            this.btnFunctionGame.Text = "1. Игра с функцией";
            this.btnFunctionGame.UseVisualStyleBackColor = false;
            this.btnFunctionGame.Click += new System.EventHandler(this.btnFunctionGame_Click);
            // 
            // btnArrayWork
            // 
            this.btnArrayWork.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnArrayWork.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnArrayWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnArrayWork.Location = new System.Drawing.Point(25, 95);
            this.btnArrayWork.Name = "btnArrayWork";
            this.btnArrayWork.Size = new System.Drawing.Size(200, 35);
            this.btnArrayWork.TabIndex = 1;
            this.btnArrayWork.Text = "2. Работа с массивами";
            this.btnArrayWork.UseVisualStyleBackColor = false;
            this.btnArrayWork.Click += new System.EventHandler(this.btnArrayWork_Click);
            // 
            // btnConnectFour
            // 
            this.btnConnectFour.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnConnectFour.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConnectFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConnectFour.Location = new System.Drawing.Point(25, 140);
            this.btnConnectFour.Name = "btnConnectFour";
            this.btnConnectFour.Size = new System.Drawing.Size(200, 35);
            this.btnConnectFour.TabIndex = 2;
            this.btnConnectFour.Text = "3. Игра 4 в ряд";
            this.btnConnectFour.UseVisualStyleBackColor = false;
            this.btnConnectFour.Click += new System.EventHandler(this.btnConnectFour_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAbout.Location = new System.Drawing.Point(25, 185);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(200, 35);
            this.btnAbout.TabIndex = 3;
            this.btnAbout.Text = "4. Об авторе";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnSlarkStack
            // 
            this.btnSlarkStack.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSlarkStack.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSlarkStack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSlarkStack.Location = new System.Drawing.Point(25, 234);
            this.btnSlarkStack.Name = "btnSlarkStack";
            this.btnSlarkStack.Size = new System.Drawing.Size(200, 35);
            this.btnSlarkStack.TabIndex = 6;
            this.btnSlarkStack.Text = "5. Симулятор стаков Сларка";
            this.btnSlarkStack.UseVisualStyleBackColor = false;
            this.btnSlarkStack.Click += new System.EventHandler(this.btnSlarkStack_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(25, 275);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 35);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "6. Выход";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle.Location = new System.Drawing.Point(58, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(130, 20);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Главное меню";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            this.panelMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelMain.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelMain.Controls.Add(this.lblTitle);
            this.panelMain.Controls.Add(this.btnSlarkStack);
            this.panelMain.Controls.Add(this.btnExit);
            this.panelMain.Controls.Add(this.btnAbout);
            this.panelMain.Controls.Add(this.btnConnectFour);
            this.panelMain.Controls.Add(this.btnArrayWork);
            this.panelMain.Controls.Add(this.btnFunctionGame);
            this.panelMain.Location = new System.Drawing.Point(12, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(250, 325);
            this.panelMain.TabIndex = 6;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(274, 349);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFunctionGame;
        private System.Windows.Forms.Button btnArrayWork;
        private System.Windows.Forms.Button btnConnectFour;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelMain;
    }
}