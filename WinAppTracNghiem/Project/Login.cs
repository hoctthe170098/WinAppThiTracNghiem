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
    public partial class Login : Form
    {
        WinAppTracNghiemContext context = new WinAppTracNghiemContext();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim().Equals("") || txtPassword.Text.Trim().Equals(""))
            {
                MessageBox.Show("Username and Passwork can not be empty!");
            }
            else
            {
                var acc = context.Accounts
                    .Where(a => a.Username.Trim().ToLower().Equals(txtUsername.Text.ToLower())
                && a.Password.Equals(txtPassword.Text)).FirstOrDefault();
                if (acc == null)
                {
                    MessageBox.Show("Account is not exist!");
                }
                else
                {
                    if (acc.Role == 1)
                    {
                        HomeManager f = new HomeManager(acc);
                        Login f2 = new Login();
                        f2.Hide();
                        f.ShowDialog();

                    }
                    else
                    {
                        if (txtCode.Text.Trim().Equals(""))
                        {
                            MessageBox.Show("Code can not be empty!");
                            return;
                        }
                        ExamCode exam = context.ExamCodes.Where(e => e.Code.Equals(txtCode.Text)).FirstOrDefault();
                        if (exam == null)
                        {
                            MessageBox.Show("Code is not exist!");
                            return;
                        }
                        if (exam.Status.Equals("NonActive"))
                        {
                            MessageBox.Show("Code is not active!");
                            return;
                        }
                        Enroll enroll = context.Enrolls
                            .Where(e => e.Username.Equals(txtUsername.Text)
                            && e.Course.Equals(exam.Course)
                            && e.Semester.Equals(exam.Semester)).FirstOrDefault();
                        if (enroll == null)
                        {
                            MessageBox.Show("You can not do this test!");
                            return;
                        }
                        Practice p = context.Practices
                            .Where(p => p.Username.Equals(txtUsername.Text)
                            && p.ExamCode.Equals(txtCode.Text)).FirstOrDefault();
                        if (p != null && (p.Status.Equals("Doing") || p.Status.Equals("Done")))
                        {
                            MessageBox.Show("You have assigned this test!");
                            return;
                        }
                        Practice pra = new Practice
                        {
                            Username = txtUsername.Text,
                            ExamCode = txtCode.Text,
                            TimeBegin = DateTime.Now,
                            Status = "Doing"
                        };
                        context.Practices.Add(pra);
                        context.SaveChanges();
                        Exam f = new Exam(txtUsername.Text, txtCode.Text);
                        this.Hide();
                        f.ShowDialog();
                    }
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
