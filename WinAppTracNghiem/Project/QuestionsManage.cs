using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Project.Models;
namespace Project
{
    public partial class QuestionsManage : Form
    {
        WinAppTracNghiemContext context = new WinAppTracNghiemContext();
        public QuestionsManage()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            LoadQuestion();
            LoadCourse();
            LoadType();
        }

        private void LoadType()
        {
            cboTypeQuestions.Items.Add("All");
            List<TypeOfQuestion> list = context.TypeOfQuestions.ToList();
            foreach (TypeOfQuestion t in list)
            {
                cboTypeQuestions.Items.Add(t.Name);
            }
            cboTypeQuestions.SelectedIndex = 0;
        }

        private void LoadCourse()
        {
            List<Course> list = context.Courses.ToList();
            cboCourses.Items.Add("All");
            foreach (Course c in list)
            {
                cboCourses.Items.Add(c.Code);
            }
            cboCourses.SelectedIndex = 0;
        }

        private void LoadQuestion()
        {
            var questions = context.Questions.Select(q => new
            {
                ID = q.Id,
                Type = q.TypeNavigation.Name,
                Course = q.CourseNavigation.Title,
                Title = q.Title
            }).ToList();
            dgvQuestions.DataSource = questions;
            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", questions, "ID");
            txtTitle.DataBindings.Clear();
            txtTitle.DataBindings.Add("Text", questions, "Title");
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateQuestion f = new CreateQuestion();
            f.ShowDialog();
        }

        private bool checkExist(int ans, int ques)
        {
            var check = context.AnswersOfQuestions.Where(a => a.Answer == ans && a.Question == ques).FirstOrDefault();
            if (check != null) return true;
            else
                return false;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            int IdQuestion = Convert.ToInt32(txtID.Text);
            var data = context.Answers
                .Where(an => an.AnswersOfQuestions
                .Where(ans => ans.Answer == an.Id && ans.Question == IdQuestion).FirstOrDefault() != null
                ).Select(an => new
                {
                    ID = an.Id,
                    Content = an.Content,
                    Istrue = an.AnswersOfQuestions.Where(ans => ans.Answer == an.Id && ans.Question == IdQuestion).FirstOrDefault().IsTrue
                }
                ).ToList();
            dgvAnswers.DataSource = data;
        }

        private void cboCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void Filter()
        {
            string course = cboCourses.Text;
            string type = cboTypeQuestions.Text;
            string title = txtSearchTitle.Text;
            var questions = (from q in context.Questions
                             where q.Title.Contains(title)
                             && ((course != "All") ? q.CourseNavigation.Code.Equals(course) : q.CourseNavigation.Code.Contains(""))
                             && ((type != "All") ? q.TypeNavigation.Name.Equals(type) : q.TypeNavigation.Id > 0)
                             select new
                             {
                                 ID = q.Id,
                                 Type = q.TypeNavigation.Name,
                                 Course = q.CourseNavigation.Title,
                                 Title = q.Title
                             }
                                         ).ToList();
            dgvQuestions.DataSource = questions;
            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", questions, "ID");

            txtTitle.DataBindings.Clear();
            txtTitle.DataBindings.Add("Text", questions, "Title");
        }

        private void cboTypeQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void txtSearchTitle_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            QuestionOfCode qc = context.QuestionOfCodes.Where(qoc=>qoc.Question==id).FirstOrDefault();
            if (qc != null)
            {
                MessageBox.Show("This question has been used for the exam code, can not delete!");
                return;
            }
            DialogResult dialogResult = MessageBox
                            .Show("Are you sure to delete this Question?", "Alert", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                List<AnswersOfQuestion> data = context.AnswersOfQuestions
                    .Where(a => a.Question == id).ToList();
                foreach (AnswersOfQuestion a in data)
                {
                    context.AnswersOfQuestions.Remove(a);
                }
                context.SaveChanges();
                Question q = context.Questions.Where(q => q.Id == id).FirstOrDefault();
                context.Questions.Remove(q);
                context.SaveChanges();
                MessageBox.Show("Delete successfully!");
                LoadQuestion();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txtID.Text);
            this.Hide();
            UpdateQuestion f = new UpdateQuestion(ID);
            f.ShowDialog();
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
    }
}
