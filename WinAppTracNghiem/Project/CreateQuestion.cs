using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Models;
namespace Project
{
    public partial class CreateQuestion : Form
    {
        bool check = false;
        List<TextBox> listAnswer = new List<TextBox>();
        List<CheckBox> listIsTrue = new List<CheckBox>();
        List<Button> listDelete = new List<Button>();
        Dictionary<int, bool> listIndex = new Dictionary<int, bool>();
        WinAppTracNghiemContext context = new WinAppTracNghiemContext();
        private int GetIndex()
        {
            int min = 0;
            foreach (int i in listIndex.Keys)
            {
                if (listIndex[i] == false)
                {
                    min = i; break;
                }
            }
            foreach (int i in listIndex.Keys)
            {
                if (min > i && listIndex[i] == false) min = i;
            }
            return min;
        }
        public CreateQuestion()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            LoadCourse();
            LoadType();
            listAnswer.Add(txtAns1);
            listAnswer.Add(txtAns2);
            listIsTrue.Add(cb1);
            listIsTrue.Add(cb2);
            for (int i = 1; i <= 4; i++)
            {
                listIndex.Add(i, false);
            }
        }

        private void LoadType()
        {
            cboType.DataSource = context.TypeOfQuestions.ToList();
            cboType.ValueMember = "Id";
            cboType.DisplayMember = "Name";
            cboType.SelectedItem = context.TypeOfQuestions.
                Where(t => t.Name.Equals("Multi answer")).FirstOrDefault();
        }

        private void LoadCourse()
        {
            cboCourses.DataSource = context.Courses.ToList();
            cboCourses.ValueMember = "Code";
            cboCourses.DisplayMember = "Code";
        }

        private void btnAddAns_Click(object sender, EventArgs e)
        {
            if (listAnswer.Count == 6)
            {
                MessageBox.Show("Can not add more than 6 answer!");
                return;
            }
            if (cboType.Text.Equals("True/False"))
            {
                MessageBox.Show("Can not add answer for True/False question!");
                return;
            }
            TextBox textBox = new TextBox();
            textBox.Location = new Point(218, 243 + GetIndex() * 44);
            textBox.Name = "txtAns" + (GetIndex() + 2);
            textBox.Size = new Size(499, 23);
            CheckBox checkBox = new CheckBox();
            checkBox.AutoSize = true;
            checkBox.Location = new Point(734, 247 + GetIndex() * 44);
            checkBox.Name = "cb" + (GetIndex() + 2);
            checkBox.Size = new Size(56, 19);
            checkBox.TabIndex = 12;
            checkBox.Text = "isTrue";
            checkBox.UseVisualStyleBackColor = true;
            Button button = new Button();
            button.Location = new Point(806, 242 + GetIndex() * 44);
            button.Name = "btnDelete" + (GetIndex() + 2);
            button.Size = new Size(75, 23);
            button.TabIndex = 16;
            button.Text = "Delete";
            button.UseVisualStyleBackColor = true;
            listAnswer.Add(textBox);
            listIsTrue.Add(checkBox);
            listDelete.Add(button);
            grCreateQuestions.Controls.Add(textBox);
            grCreateQuestions.Controls.Add(checkBox);
            grCreateQuestions.Controls.Add(button);
            listIndex[GetIndex()] = true;
            button.Click += Button_Click;
        }

        private void Button_Click(object? sender, EventArgs e)
        {
            Button b = sender as Button;
            int i = listDelete.IndexOf(b);
            grCreateQuestions.Controls.Remove(listAnswer[i + 2]);
            grCreateQuestions.Controls.Remove(listIsTrue[i + 2]);
            grCreateQuestions.Controls.Remove(listDelete[i]);
            listAnswer.RemoveAt(i + 2);
            listIsTrue.RemoveAt(i + 2);
            listDelete.RemoveAt(i);
            listIndex[Convert.ToInt32(b.Name.Substring(b.Name.Length - 1)) - 2] = false;
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboType.Text.Equals("True/False"))
            {
                txtAns1.Text = "True";
                txtAns2.Text = "False";
                txtAns1.ReadOnly = true;
                txtAns2.ReadOnly = true;
                check = true;
                if (listDelete.Count > 0)
                {
                    int dem = listDelete.Count;
                    for (int i = 1; i <= dem; i++)
                    {
                        grCreateQuestions.Controls.Remove(listAnswer[2]);
                        grCreateQuestions.Controls.Remove(listIsTrue[2]);
                        grCreateQuestions.Controls.Remove(listDelete[0]);
                        listIndex[Convert.ToInt32(listDelete[0].Name.Substring(listDelete[0].Name.Length - 1)) - 2] = false;
                        listAnswer.RemoveAt(2);
                        listIsTrue.RemoveAt(2);
                        listDelete.RemoveAt(0);
                    }
                }
            }
            else
            {
                if (check)
                {
                    txtAns1.Text = "";
                    txtAns2.Text = "";
                    txtAns1.ReadOnly = false;
                    txtAns2.ReadOnly = false;
                    check = false;
                }
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text.Trim().Equals("") || txtTitle.Text.Trim().Length > 300)
            {
                MessageBox.Show("Title can not be empty and must less than 300 chars!");
                return;
            }
            foreach (TextBox t in listAnswer)
            {
                if (t.Text.Trim().Equals("") || t.Text.Trim().Length > 300)
                {
                    MessageBox.Show("Answer can not be empty and must less than 300 chars!");
                    return;
                }
            }
            int count = 0;
            foreach (CheckBox b in listIsTrue)
            {
                if (b.Checked) count++;
            }
            if (count == 0)
            {
                MessageBox.Show("You must choose at least one answer right!");
                return;
            }
            if (cboType.Text.Equals("Multi answer") && count <= 1)
            {
                MessageBox.Show("You must choose more than one answer right!");
                return;
            }
            if (!cboType.Text.Equals("Multi answer") && count > 1)
            {
                MessageBox.Show("You can only choose one answer right!");
                return;
            }
            Question question1 = context.Questions.
                Where(qq => qq.Title.Equals(chuanhoa(txtTitle.Text))).FirstOrDefault();
            if (question1 != null)
            {
                MessageBox.Show("This questions is exist!");
                return;
            }
            Question q = new Question
            {
                Title = chuanhoa(txtTitle.Text),
                NumberOfAnswers = listAnswer.Count,
                Type = Convert.ToInt32(cboType.SelectedValue),
                Course = cboCourses.SelectedValue.ToString()
            };
            context.Questions.Add(q);
            context.SaveChanges();
            Question question = context.Questions.Where(qe => qe.Title.Equals(chuanhoa(txtTitle.Text))).FirstOrDefault();
            int d = 0;
            foreach (TextBox a in listAnswer)
            {
                Answer ans = context.Answers.Where(an => an.Content.Equals(chuanhoa(a.Text))).FirstOrDefault();
                if (ans != null)
                {
                    context.AnswersOfQuestions.Add(new AnswersOfQuestion
                    {
                        Question = question.Id,
                        Answer = ans.Id,
                        IsTrue = (listIsTrue[d].Checked) ? true : false
                    }
                        );
                }
                else
                {
                    context.Answers.Add(new Answer
                    {
                        Content = chuanhoa(a.Text)
                    }
                        );
                    context.SaveChanges();
                    Answer answer = context.Answers.Where(an => an.Content.Equals(chuanhoa(a.Text))).FirstOrDefault();
                    AnswersOfQuestion answersOfQuestion = new AnswersOfQuestion
                    {
                        Question = question.Id,
                        Answer = answer.Id,
                        IsTrue = (listIsTrue[d].Checked) ? true : false
                    };
                    context.AnswersOfQuestions.Add(answersOfQuestion);
                }
                context.SaveChanges();
                d++;
            }
            MessageBox.Show("Create Successfully!");
        }
        private string chuanhoa(string xau)
        {
            string kq = "";
            xau = xau.Trim();
            for (int i = 0; i < xau.Length; i++)
            {
                if (i == 0)
                    kq += xau[i].ToString().ToUpper();
                else
                    kq += xau[i];
                if (xau[i] == ' ')
                {
                    while (xau[i] == ' ')
                    {
                        i++;
                    }
                    kq += xau[i].ToString();
                }
            }
            return kq.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuestionsManage f = new QuestionsManage();
            f.ShowDialog();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeManager f = new HomeManager();
            f.ShowDialog();
        }
    }
}
