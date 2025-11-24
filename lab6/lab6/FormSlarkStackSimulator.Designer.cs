namespace _3lab
{
    partial class FormSlarkStackSimulator
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
            this.picSlark = new System.Windows.Forms.PictureBox();
            this.btnAddStack = new System.Windows.Forms.Button();
            this.lblStacksCount = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblAgility = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSlark)).BeginInit();
            this.SuspendLayout();
 
            this.picSlark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSlark.Location = new System.Drawing.Point(100, 60);
            this.picSlark.Name = "picSlark";
            this.picSlark.Size = new System.Drawing.Size(200, 200);
            this.picSlark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSlark.TabIndex = 0;
            this.picSlark.TabStop = false;

            this.btnAddStack.BackColor = System.Drawing.Color.LightBlue;
            this.btnAddStack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddStack.Location = new System.Drawing.Point(125, 270);
            this.btnAddStack.Name = "btnAddStack";
            this.btnAddStack.Size = new System.Drawing.Size(150, 40);
            this.btnAddStack.TabIndex = 1;
            this.btnAddStack.Text = "Добавить стак!";
            this.btnAddStack.UseVisualStyleBackColor = false;
            this.btnAddStack.Click += new System.EventHandler(this.btnAddStack_Click);

            this.lblStacksCount.AutoSize = true;
            this.lblStacksCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStacksCount.Location = new System.Drawing.Point(120, 20);
            this.lblStacksCount.Name = "lblStacksCount";
            this.lblStacksCount.Size = new System.Drawing.Size(100, 20);
            this.lblStacksCount.TabIndex = 2;
            this.lblStacksCount.Text = "Стаков: 0";
            this.lblStacksCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.btnBack.Location = new System.Drawing.Point(160, 320);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 30);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
 
            this.lblAgility.AutoSize = true;
            this.lblAgility.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAgility.Location = new System.Drawing.Point(120, 40);
            this.lblAgility.Name = "lblAgility";
            this.lblAgility.Size = new System.Drawing.Size(120, 20);
            this.lblAgility.TabIndex = 7;
            this.lblAgility.Text = "Ловкость: +0";
            this.lblAgility.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(120, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Каждый стак длится 35 сек";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 380);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAgility);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblStacksCount);
            this.Controls.Add(this.btnAddStack);
            this.Controls.Add(this.picSlark);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSlarkStackSimulator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Симулятор стаков ловкости Сларка";
            ((System.ComponentModel.ISupportInitialize)(this.picSlark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSlark;
        private System.Windows.Forms.Button btnAddStack;
        private System.Windows.Forms.Label lblStacksCount;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblAgility;
        private System.Windows.Forms.Label label1;
    }
}