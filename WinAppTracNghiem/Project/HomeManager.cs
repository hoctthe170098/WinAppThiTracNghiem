using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Models;
namespace Project
{
    public partial class HomeManager : Form
    {
        public HomeManager()
        {
            InitializeComponent();
        }
        public HomeManager(Account c) : this()
        {
            label1.Text += " " + c.Username;
        }

        private void btnManageQuestions_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuestionsManage f = new QuestionsManage();
            f.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login f = new Login();
            f.ShowDialog();
        }

        private void btnManageExam_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExamCodeManager f = new ExamCodeManager();
            f.ShowDialog();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            this.Hide();
            Result f = new Result();
            f.ShowDialog();
        }
    }
}
