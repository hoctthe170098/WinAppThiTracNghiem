using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using Project.Models;
namespace Project
{
    public partial class CreateExamCode : Form
    {
        List<Question> Questions = new List<Question>();
        String course;
        WinAppTracNghiemContext context = new WinAppTracNghiemContext();
        public CreateExamCode()
        {

            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            LoadSemester();
            LoadCourse();
            LoadQuestions();
            cboTime.SelectedIndex = 0;
        }

        private void LoadQuestions()
        {
            var data = context.Questions.Where(q => q.Course.Equals(cboCourses.SelectedValue.ToString()))
               .Select(q => new
               {
                   ID = q.Id,
                   Answer = q.NumberOfAnswers,
                   Type = q.TypeNavigation.Name,
                   Title = q.Title
               }).ToList();
            dgvListQuestions.DataSource = data;
            txtTitle.DataBindings.Clear();
            txtTitle.DataBindings.Add("Text", data, "Title");
            txtIDQuestion.DataBindings.Clear();
            txtIDQuestion.DataBindings.Add("Text", data, "ID");
        }

        private void LoadCourse()
        {
            cboCourses.DataSource = context.Courses.ToList();
            cboCourses.ValueMember = "Code";
            cboCourses.DisplayMember = "Code";
        }

        private void LoadSemester()
        {
            cboSemesters.DataSource = context.Semesters.ToList();
            cboSemesters.ValueMember = "Code";
            cboSemesters.DisplayMember = "Code";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtCode.Text.Trim().Equals("") || txtCode.Text.Trim().Contains(" ") || txtCode.Text.Trim().Length > 50)

            {
                MessageBox.Show("Code can not be empty or contain space or more than 50 chars!");
                return;
            }
            Semester s = context.Semesters.Where(se => se.Code.Equals(cboSemesters.SelectedValue)).FirstOrDefault();
            DateTime date = dtpDate.Value;
            if (date < s.BeginDate || date > s.EndDate)
            {

                MessageBox.Show("Date is invalid, it must in range from BeginDate to EndDate");
                return;
            }
            if ((int)numQuestions.Value > Questions.Count)
            {
                MessageBox.Show("You haven't added enough question!");
                return;
            }
            ExamCode examCode = context.ExamCodes.Where(e => e.Code.Equals(txtCode.Text.Trim())).FirstOrDefault();
            if (examCode != null)
            {
                MessageBox.Show("Code is exist!");
                return;
            }
            ExamCode exam = new ExamCode
            {
                Code = txtCode.Text.Trim(),
                Semester = cboSemesters.Text,
                Course = course,
                DateBegin = dtpDate.Value,
                TimeBegin = Convert.ToInt32(cboTime.Text),
                Long = (int)numLong.Value,
                Status = "NonActive",
                NumberOfQuestion = (int)numQuestions.Value
            };
            context.ExamCodes.Add(exam);
            context.SaveChanges();
            foreach (Question q in Questions)
            {
                QuestionOfCode qc = new QuestionOfCode
                {
                    ExamCode = exam.Code,
                    Question = q.Id
                };
                context.QuestionOfCodes.Add(qc);
                context.SaveChanges();
            }
            MessageBox.Show("Create Successfully!");
        }

        private void cboCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadQuestions();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtIDQuestion.Text.Equals(""))
            {
                MessageBox.Show("ID Question can not be empty!");
                return;
            }
            if (Questions.Count == 0) course = cboCourses.Text;
            if (!course.Equals(cboCourses.Text))
            {
                MessageBox.Show("List questions is containing " + course + " questions, can not add " + cboCourses.Text + " question!");
                return;
            }
            Question q = context.Questions.Where(qa => qa.Id == Convert.ToInt32(txtIDQuestion.Text)).FirstOrDefault();
            if (Questions.Contains(q))
            {
                MessageBox.Show("This question has been added!");
            }
            else
            {
                Questions.Add(q);
                LoadListQuestions();
            }
        }

        private void LoadListQuestions()
        {
            lstQuestions.DataSource = Questions.ToList();
            lstQuestions.DisplayMember = "Id";
            lstQuestions.ValueMember = "Id";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox
                            .Show("Are you sure to delete this Question?", "Alert", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = Convert.ToInt32(lstQuestions.SelectedValue);
                Question question = Questions.Where(q => q.Id == id).FirstOrDefault();
                Questions.Remove(question);
                if (Questions.Count == 1)
                {
                    course = Questions[0].Course;
                }
                LoadListQuestions();
            }
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
            ExamCodeManager f = new ExamCodeManager();
            f.ShowDialog();
        }
    }
}
