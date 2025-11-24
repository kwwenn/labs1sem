using System;
using System.Drawing;
using System.Windows.Forms;

namespace _3lab
{
    public partial class FormArrayWork : Form
    {
        private ArrayWorker arrayWorker;
        private DataGridViewCellStyle highlightStyle;

        public FormArrayWork()
        {
            InitializeComponent();
            SetupDataGridView();
            SetupHighlightStyle();
        }

        private void SetupDataGridView()
        {
            dataGridViewArray.AutoGenerateColumns = false;
            dataGridViewArray.Columns.Clear();
            dataGridViewArray.Columns.Add("Index", "Индекс");
            dataGridViewArray.Columns.Add("Value", "Значение");
            dataGridViewArray.Columns[0].Width = 60;
            dataGridViewArray.Columns[1].Width = 100;
            dataGridViewArray.AllowUserToAddRows = false;
        }

        private void SetupHighlightStyle()
        {
            highlightStyle = new DataGridViewCellStyle();
            highlightStyle.BackColor = Color.Yellow;
        }

        private void btnCreateArray_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtArraySize.Text, out int size) && size > 0)
            {
                arrayWorker = new ArrayWorker(size);
                DisplayArray();
            }
            else
            {
                MessageBox.Show("Введите корректный размер массива");
            }
        }

        private void btnDefaultArray_Click(object sender, EventArgs e)
        {
            arrayWorker = new ArrayWorker();
            DisplayArray();
        }

        private void btnRandomize_Click(object sender, EventArgs e)
        {
            if (arrayWorker != null)
            {
                arrayWorker.Randomize();
                DisplayArray();
            }
            else
            {
                MessageBox.Show("Сначала создайте массив");
            }
        }

        private void DisplayArray()
        {
            dataGridViewArray.Rows.Clear();
            for (int i = 0; i < arrayWorker.Length; i++)
            {
                dataGridViewArray.Rows.Add(i, arrayWorker.Array[i]);
            }
            ClearHighlighting();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (arrayWorker != null)
            {
                double time = arrayWorker.BubbleSort();
                DisplayArray();
                MessageBox.Show($"Сортировка завершена. Время: {time:F6} мс");
            }
            else
            {
                MessageBox.Show("Сначала создайте массив");
            }
        }

        private void btnShellSort_Click(object sender, EventArgs e)
        {
            if (arrayWorker != null)
            {
                double time = arrayWorker.ShellSort();
                DisplayArray();
                MessageBox.Show($"Сортировка Шелла завершена. Время: {time:F6} мс");
            }
            else
            {
                MessageBox.Show("Сначала создайте массив");
            }
        }

        private void btnFindMinMax_Click(object sender, EventArgs e)
        {
            if (arrayWorker != null)
            {
                int min = arrayWorker.GetMin();
                int max = arrayWorker.GetMax();
                double average = arrayWorker.GetAverage();

                txtMin.Text = min.ToString();
                txtMax.Text = max.ToString();
                txtAverage.Text = average.ToString("F2");

                HighlightExtremeValues(min, max);
            }
            else
            {
                MessageBox.Show("Сначала создайте массив");
            }
        }

        private void HighlightExtremeValues(int min, int max)
        {
            ClearHighlighting();

            foreach (DataGridViewRow row in dataGridViewArray.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    int value = Convert.ToInt32(row.Cells[1].Value);
                    if (value == min || value == max)
                    {
                        row.DefaultCellStyle = highlightStyle;
                    }
                }
            }
        }

        private void ClearHighlighting()
        {
            foreach (DataGridViewRow row in dataGridViewArray.Rows)
            {
                row.DefaultCellStyle = null;
            }
        }

        private void dataGridViewArray_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && arrayWorker != null && e.RowIndex >= 0)
            {
                if (int.TryParse(dataGridViewArray.Rows[e.RowIndex].Cells[1].Value?.ToString(), out int newValue))
                {
                    arrayWorker.Array[e.RowIndex] = newValue;
                }
                else
                {
                    MessageBox.Show("Введите целое число");
                    dataGridViewArray.Rows[e.RowIndex].Cells[1].Value = arrayWorker.Array[e.RowIndex];
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}