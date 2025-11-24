using System;
using System.Windows.Forms;

namespace _3lab
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {
            lblAuthor.Text = "Гаврилов Дмитрий Сергеевич 6101-090301D";
        }
    }
}