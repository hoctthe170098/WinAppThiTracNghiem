using Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
namespace Project
{
    public partial class Result : Form
    {
        WinAppTracNghiemContext context = new WinAppTracNghiemContext();
        public Result()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            LoadResult();
            LoadSemester();
            LoadCourse();
        }

        private void LoadCourse()
        {
            cboCourses.Items.Add("All");
            var data = context.Courses.ToList();
            foreach (var c in data)
            {
                cboCourses.Items.Add(c.Code);
            }
            cboCourses.SelectedIndex = 0;
        }

        private void LoadSemester()
        {
            cboSemesters.Items.Add("All");
            var data = context.Semesters.ToList();
            foreach (var c in data)
            {
                cboSemesters.Items.Add(c.Code);
            }
            cboSemesters.SelectedIndex = 0;
        }

        private void LoadResult()
        {
            var data = context.Practices.Where(p => p.Status.Equals("Done"))
               .Select(p => new
               {
                   Name = p.Username,
                   ExamCode = p.ExamCode,
                   Time = p.TimeBegin,
                   Long = (p.Long) / 60 + "p" + (p.Long) % 60 + "s",
                   Mark = p.Mark
               }).ToList();
            dgvResult.DataSource = data;
            txtUsername.DataBindings.Clear();
            txtUsername.DataBindings.Add("Text", data, "Name");
            txtCode.DataBindings.Clear();
            txtCode.DataBindings.Add("Text", data, "ExamCode");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeManager f = new HomeManager();
            f.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeManager f = new HomeManager();
            f.ShowDialog();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void cboSemesters_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void cboCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }
        private void Filter()
        {
            dgvDes.DataSource = null;
            String? semester = cboSemesters.Text;
            String? course = cboCourses.Text;
            var data = context.Practices.Where(p => p.Status.Equals("Done")
           && p.Username.Contains(txtName.Text)
           && ((semester != "All") ?
           p.ExamCodeNavigation.Semester.Equals(semester) :
           p.ExamCodeNavigation.Semester.Contains(""))
           && ((course != "All") ?
           p.ExamCodeNavigation.Course.Equals(course) :
           p.ExamCodeNavigation.Course.Contains("")))
    .Select(p => new
    {
        Name = p.Username,
        ExamCode = p.ExamCode,
        Time = p.TimeBegin,
        Long = (p.Long) / 60 + "p" + (p.Long) % 60 + "s",
        Mark = p.Mark
    }).ToList();
            dgvResult.DataSource = data;
            txtUsername.DataBindings.Clear();
            txtUsername.DataBindings.Add("Text", data, "Name");
            txtCode.DataBindings.Clear();
            txtCode.DataBindings.Add("Text", data, "ExamCode");
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            dgvDes.DataSource = null;
        }


        private void dgvDes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDes_Click(object sender, EventArgs e)
        {
            String user = txtUsername.Text;
            String Code = txtCode.Text;
            String fileName = user + "Do" + Code + ".txt";
            List<dynamic> data = new List<dynamic>();
            if (!string.IsNullOrEmpty(fileName))
            {
                try
                {
                    using (StreamReader reader = new StreamReader(fileName))
                    {

                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            List<int> listID = new List<int>();
                            string[] s = line.Split("     ");
                            string[] s2 = s[1].Trim().Split("   ");
                            String answer = "";
                            int idQ = Convert.ToInt32(s[0].Substring(1));
                            for (int i = 0; i < s2.Length; i++)
                            {
                                if (s2[i].Trim() != "")
                                {
                                    answer += s2[i] + " ";
                                    listID.Add(Convert.ToInt32(s2[i]));
                                }                              
                            }
                            List<int> ans = context.AnswersOfQuestions
                                .Where(qc => qc.Question == idQ && qc.IsTrue == true)
                                .Select(qc => qc.Answer).ToList();
                            String trueAns = "";
                            for (int j = 0; j < ans.Count; j++)
                            {
                                trueAns += ans[j] + " ";
                            }
                            bool check = true;
                            if (listID.Count != ans.Count)
                            {
                                check = false;
                            }
                            else
                            {
                                foreach (int i in listID)
                                {
                                    if (!ans.Contains(i))
                                    {
                                        check = false;
                                        break;
                                    }
                                }
                            }
                            var data1 = new
                            {
                                Ques = idQ.ToString(),
                                Answer = answer,
                                TrueAns = trueAns,
                                Istrue = (check == true) ? "True" : "False"
                            };
                            data.Add(data1);
                        }


                    }

                }
                catch (Exception ex)
                {
                }
            }
            else
            {
                MessageBox.Show("File is not exist!");
            }
            dgvDes.DataSource = data;
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            dgvDes.DataSource = null;
        }
    }
}
