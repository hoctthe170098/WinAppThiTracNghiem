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

namespace Project
{
    public partial class ExamCodeManager : Form
    {
        WinAppTracNghiemContext context = new WinAppTracNghiemContext();
        public ExamCodeManager()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            LoadExamCode();
        }

        private void LoadExamCode()
        {
            var data = context.ExamCodes
                .Select(e => new
                {
                    Semester = e.Semester,
                    Course = e.Course,
                    Code = e.Code
                }).ToList();
            dgvExamCode.DataSource = data;
            txtCode.DataBindings.Clear();
            txtCode.DataBindings.Add("Text", data, "Code");
            txtCodeAssign.DataBindings.Clear();
            txtCodeAssign.DataBindings.Add("Text", data, "Code");
        }

        private void btnCreateExamCode_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateExamCode f = new CreateExamCode();
            f.ShowDialog();
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            dgvListQuestion.DataSource=null;
            ExamCode ex = context.ExamCodes.Where(e => e.Code.Equals(txtCode.Text)).FirstOrDefault();
            dtpDateBegin.Text = ex.DateBegin.ToString();
            cboTime.Text = ex.TimeBegin.ToString();
            numLong.Value = (decimal)ex.Long;
            numQuestions.Value = (decimal)ex.NumberOfQuestion;
            cboStatus.Text = ex.Status;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox
                            .Show("Are you sure to delete this Question?", "Alert", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var Practice = context.Practices.Where(p => p.ExamCode.Equals(txtCode.Text)).FirstOrDefault();
                if (Practice != null)
                {
                    MessageBox.Show("Can not delete this code!");
                    return;
                }
                var data = context.QuestionOfCodes.Where(q => q.ExamCode == txtCode.Text).ToList();
                foreach (var item in data)
                {
                    context.QuestionOfCodes.Remove(item);
                    context.SaveChanges();
                }
                var exam = context.ExamCodes.Where(e => e.Code.Equals(txtCode.Text)).FirstOrDefault();
                context.ExamCodes.Remove(exam);
                context.SaveChanges();
                LoadExamCode();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Semester s = context.Semesters
                .Where(s => s.ExamCodes
                .Where(e => e.Code.Equals(txtCode.Text))
                .FirstOrDefault().Semester.Equals(s.Code)).FirstOrDefault();
            if (dtpDateBegin.Value < s.BeginDate || dtpDateBegin.Value > s.EndDate)
            {
                MessageBox.Show("Date is invalid, it must in range from BeginDate to EndDate");
                return;
            }
            ExamCode exam = context.ExamCodes.Where(e => e.Code.Equals(txtCode.Text)).FirstOrDefault();
            exam.DateBegin = dtpDateBegin.Value;
            exam.TimeBegin = Convert.ToInt32(cboTime.Text);
            exam.Status = cboStatus.Text;
            context.SaveChanges();
            MessageBox.Show("Update successfully!");
            LoadExamCode();
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

        private void txtUsernameAssign_TextChanged(object sender, EventArgs e)
        {
            if (txtUsernameAssign.Text.Trim() == "")
            {
                txtStatusAssign.Text = "";
                return;
            }
            var status = context.Practices.Where(p => p.Username.Equals(txtUsernameAssign.Text)
            && p.ExamCode.Equals(txtCodeAssign.Text)).Select(p => p.Status).FirstOrDefault();
            if (status == null)
            {
                txtStatusAssign.Text = "Not Yet";
            }
            else txtStatusAssign.Text = status;
        }

        private void btnReAssign_Click(object sender, EventArgs e)
        {
            if (txtStatusAssign.Text.Equals("Doing")|| txtStatusAssign.Text.Equals("Done"))
            {
                Practice p = context.Practices.Where(p => p.Username.Equals(txtUsernameAssign.Text)
            && p.ExamCode.Equals(txtCodeAssign.Text)).FirstOrDefault();
                context.Practices.Remove(p);
                context.SaveChanges();
                MessageBox.Show("Update successfully!");
                txtUsernameAssign_TextChanged(sender, e);
            }
        }

        private void btnDescription_Click(object sender, EventArgs e)
        {
            var data = context.Questions
                .Where(q => context.QuestionOfCodes
                .Where(qc => qc.ExamCode.Equals(txtCode.Text))
                .Select(qc=>qc.Question).ToList().Contains(q.Id))
                .Select(q => new
                {
                    ID=q.Id,
                    Title = q.Title,
                    Type=q.TypeNavigation.Name
                })
                .ToList();
            dgvListQuestion.DataSource = data;
        }
    }
}
