using System;
using System.Windows.Forms;

namespace _3lab
{
    public partial class FormMain : Form
    {
        private System.Windows.Forms.Button btnSlarkStack;

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnFunctionGame_Click(object sender, EventArgs e)
        {
            using (var form = new FormFunctionGame())
            {
                form.ShowDialog();
            }
        }

        private void btnArrayWork_Click(object sender, EventArgs e)
        {
            using (var form = new FormArrayWork())
            {
                form.ShowDialog();
            }
        }

        private void btnConnectFour_Click(object sender, EventArgs e)
        {
            using (var form = new FormConnectFour())
            {
                form.ShowDialog();
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            using (var form = new FormAbout())
            {
                form.ShowDialog();
            }
        }
        private void btnSlarkStack_Click(object sender, EventArgs e)
        {
            using (var form = new FormSlarkStackSimulator())
            {
                form.ShowDialog();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnAbout_Click_1(object sender, EventArgs e)
        {

        }
    }
}