namespace _3lab
{
    partial class FormArrayWork
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
            this.txtArraySize = new System.Windows.Forms.TextBox();
            this.btnCreateArray = new System.Windows.Forms.Button();
            this.btnDefaultArray = new System.Windows.Forms.Button();
            this.dataGridViewArray = new System.Windows.Forms.DataGridView();
            this.btnRandomize = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnShellSort = new System.Windows.Forms.Button();
            this.btnFindMinMax = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArray)).BeginInit();
            this.SuspendLayout();

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Размер массива (ручной):";

            this.txtArraySize.Location = new System.Drawing.Point(175, 17);
            this.txtArraySize.Name = "txtArraySize";
            this.txtArraySize.Size = new System.Drawing.Size(50, 20);
            this.txtArraySize.TabIndex = 1;
            this.txtArraySize.Text = "10";
  
            this.btnCreateArray.Location = new System.Drawing.Point(230, 15);
            this.btnCreateArray.Name = "btnCreateArray";
            this.btnCreateArray.Size = new System.Drawing.Size(100, 23);
            this.btnCreateArray.TabIndex = 2;
            this.btnCreateArray.Text = "Создать массив";
            this.btnCreateArray.UseVisualStyleBackColor = true;
            this.btnCreateArray.Click += new System.EventHandler(this.btnCreateArray_Click);

            this.btnDefaultArray.Location = new System.Drawing.Point(340, 15);
            this.btnDefaultArray.Name = "btnDefaultArray";
            this.btnDefaultArray.Size = new System.Drawing.Size(130, 23);
            this.btnDefaultArray.TabIndex = 3;
            this.btnDefaultArray.Text = "Массив по умолчанию";
            this.btnDefaultArray.UseVisualStyleBackColor = true;
            this.btnDefaultArray.Click += new System.EventHandler(this.btnDefaultArray_Click);

            this.dataGridViewArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArray.Location = new System.Drawing.Point(20, 50);
            this.dataGridViewArray.Name = "dataGridViewArray";
            this.dataGridViewArray.Size = new System.Drawing.Size(450, 200);
            this.dataGridViewArray.TabIndex = 4;
            this.dataGridViewArray.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewArray_CellEndEdit);

            this.btnRandomize.Location = new System.Drawing.Point(20, 260);
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Size = new System.Drawing.Size(100, 23);
            this.btnRandomize.TabIndex = 5;
            this.btnRandomize.Text = "Заполнить случайно";
            this.btnRandomize.UseVisualStyleBackColor = true;
            this.btnRandomize.Click += new System.EventHandler(this.btnRandomize_Click);

            this.btnSort.Location = new System.Drawing.Point(130, 260);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(100, 23);
            this.btnSort.TabIndex = 6;
            this.btnSort.Text = "Сортировка";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
 
            this.btnShellSort.Location = new System.Drawing.Point(240, 260);
            this.btnShellSort.Name = "btnShellSort";
            this.btnShellSort.Size = new System.Drawing.Size(100, 23);
            this.btnShellSort.TabIndex = 7;
            this.btnShellSort.Text = "Сортировка Шелла";
            this.btnShellSort.UseVisualStyleBackColor = true;
            this.btnShellSort.Click += new System.EventHandler(this.btnShellSort_Click);

            this.btnFindMinMax.Location = new System.Drawing.Point(350, 260);
            this.btnFindMinMax.Name = "btnFindMinMax";
            this.btnFindMinMax.Size = new System.Drawing.Size(120, 23);
            this.btnFindMinMax.TabIndex = 8;
            this.btnFindMinMax.Text = "Найти min/max/среднее";
            this.btnFindMinMax.UseVisualStyleBackColor = true;
            this.btnFindMinMax.Click += new System.EventHandler(this.btnFindMinMax_Click);

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Минимал:";

            this.txtMin.Location = new System.Drawing.Point(80, 297);
            this.txtMin.Name = "txtMin";
            this.txtMin.ReadOnly = true;
            this.txtMin.Size = new System.Drawing.Size(50, 20);
            this.txtMin.TabIndex = 10;

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Максимум:";

            this.txtMax.Location = new System.Drawing.Point(210, 297);
            this.txtMax.Name = "txtMax";
            this.txtMax.ReadOnly = true;
            this.txtMax.Size = new System.Drawing.Size(50, 20);
            this.txtMax.TabIndex = 12;

            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Среднее арифм:";

            this.txtAverage.Location = new System.Drawing.Point(370, 297);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.ReadOnly = true;
            this.txtAverage.Size = new System.Drawing.Size(60, 20);
            this.txtAverage.TabIndex = 14;

            this.btnBack.Location = new System.Drawing.Point(395, 330);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFindMinMax);
            this.Controls.Add(this.btnShellSort);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnRandomize);
            this.Controls.Add(this.dataGridViewArray);
            this.Controls.Add(this.btnDefaultArray);
            this.Controls.Add(this.btnCreateArray);
            this.Controls.Add(this.txtArraySize);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormArrayWork";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа с массивами";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArray)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArraySize;
        private System.Windows.Forms.Button btnCreateArray;
        private System.Windows.Forms.Button btnDefaultArray;
        private System.Windows.Forms.DataGridView dataGridViewArray;
        private System.Windows.Forms.Button btnRandomize;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnShellSort;
        private System.Windows.Forms.Button btnFindMinMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.Button btnBack;
    }
}