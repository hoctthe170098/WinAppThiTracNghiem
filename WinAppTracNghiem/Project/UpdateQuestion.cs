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
using Project.Models;
using System.Net.Http.Headers;

namespace Project
{
    public partial class UpdateQuestion : Form
    {
        bool check = false;
        List<TextBox> listAnswer = new List<TextBox>();
        List<CheckBox> listIsTrue = new List<CheckBox>();
        List<Button> listDelete = new List<Button>();
        Dictionary<int, bool> listIndex = new Dictionary<int, bool>();
        Question q = new Question();
        WinAppTracNghiemContext context = new WinAppTracNghiemContext();
        public UpdateQuestion()
        {
            InitializeComponent();
        }
        public UpdateQuestion(int QID) : this()
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            q = context.Questions.Where(qe => qe.Id == QID).FirstOrDefault();
            txtTitle.Text = q.Title;
            Course c = context.Courses.Where(co => co.Code.Equals(q.Course)).FirstOrDefault();
            TypeOfQuestion t = context.TypeOfQuestions
                .Where(ty => ty.Id == q.Type).FirstOrDefault();
            lbCourse.Text = c.Title;
            lbType.Text = t.Name;
            List<Answer> data = context.Answers
                .Where(an => an.AnswersOfQuestions
                .Where(ans => ans.Answer == an.Id && ans.Question == q.Id).FirstOrDefault() != null
                ).ToList();
            for (int i = 1; i <= 4; i++)
            {
                listIndex.Add(i, false);
            }
            int count = 1;
            foreach (Answer item in data)
            {
                int id = data[count - 1].Id;
                AnswersOfQuestion answersOfQuestion = context.AnswersOfQuestions.Where(a => a.Answer == id && a.Question == q.Id).FirstOrDefault();
                TextBox textbox = new TextBox();
                textbox.Location = new Point(218, 201 + (count - 1) * 46);
                textbox.Name = "txtAns" + count;
                textbox.Size = new Size(387, 23);
                textbox.TabIndex = 11;
                textbox.Text = data[count - 1].Content;
                if (lbType.Equals("True/False"))
                {
                    textbox.ReadOnly = true;
                }
                listAnswer.Add(textbox);
                grCreateQuestions.Controls.Add(textbox);
                CheckBox checkBox = new CheckBox();
                checkBox.AutoSize = true;
                checkBox.Location = new Point(622, 203 + (count - 1) * 46);
                checkBox.Name = "cb" + count;
                checkBox.Size = new Size(83, 19);
                checkBox.TabIndex = 12;
                checkBox.Text = "IsTrue";
                checkBox.UseVisualStyleBackColor = true;
                checkBox.Checked = (data[count - 1].AnswersOfQuestions
                    .Where(ans => ans.Answer == id && ans.Question == q.Id)
                    .FirstOrDefault().IsTrue == true) ? true : false;
                listIsTrue.Add(checkBox);
                grCreateQuestions.Controls.Add(checkBox);
                if (count > 2)
                {
                    Button button = new Button();
                    button.Location = new Point(711, 292 + (count - 3) * 46);
                    button.Name = "btnDelete" + count;
                    button.Size = new Size(75, 23);
                    button.TabIndex = 17;
                    button.Text = "Delete";
                    button.UseVisualStyleBackColor = true;
                    listDelete.Add(button);
                    listIndex[count - 2] = true;
                    grCreateQuestions.Controls.Add(button);
                    button.Click += Button_Click;
                }
                count++;
            }
        }

        private void Button_Click(object? sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox
            .Show("Are you sure to remove this Answer from this Question?", "Alert", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
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
        private void btnAddAns_Click(object sender, EventArgs e)
        {
            if (listAnswer.Count == 6)
            {
                MessageBox.Show("Can not add more than 6 answer!");
                return;
            }
            if (lbType.Text.Equals("True/False"))
            {
                MessageBox.Show("Can not add answer for True/False question!");
                return;
            }
            TextBox textbox = new TextBox();
            textbox.Location = new Point(218, 201 + (GetIndex() + 1) * 46);
            textbox.Name = "txtAns" + (GetIndex() + 2);
            textbox.Size = new Size(387, 23);
            textbox.TabIndex = 11;
            listAnswer.Add(textbox);
            grCreateQuestions.Controls.Add(textbox);
            CheckBox checkBox = new CheckBox();
            checkBox.AutoSize = true;
            checkBox.Location = new Point(622, 203 + (GetIndex() + 1) * 46);
            checkBox.Name = "cb" + (GetIndex() + 2);
            checkBox.Size = new Size(83, 19);
            checkBox.TabIndex = 12;
            checkBox.Text = "IsTrue";
            checkBox.UseVisualStyleBackColor = true;
            listIsTrue.Add(checkBox);
            grCreateQuestions.Controls.Add(checkBox);
            Button button = new Button();
            button.Location = new Point(711, 292 + (GetIndex() - 1) * 46);
            button.Name = "btnDelete" + (GetIndex() + 2);
            button.Size = new Size(75, 23);
            button.TabIndex = 17;
            button.Text = "Delete";
            button.UseVisualStyleBackColor = true;
            listDelete.Add(button);
            listIndex[GetIndex()] = true;
            grCreateQuestions.Controls.Add(button);
            button.Click += Button_Click1;
        }

        private void Button_Click1(object? sender, EventArgs e)
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

        private void btnUpdate_Click(object sender, EventArgs e)
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
            if (lbType.Text.Equals("Multi answer") && count <= 1)
            {
                MessageBox.Show("You must choose more than one answer right!");
                return;
            }
            if (!lbType.Text.Equals("Multi answer") && count > 1)
            {
                MessageBox.Show("You can only choose one answer right!");
                return;
            }
            Question question1 = context.Questions.
                Where(qq => qq.Title.Equals(chuanhoa(txtTitle.Text))).FirstOrDefault();
            if (question1 != null && question1 != q)
            {
                MessageBox.Show("This questions is exist!");
                return;
            }
            bool check = false;
            foreach(TextBox t in listAnswer)
            {
                string content = t.Text;
                foreach(TextBox t1 in listAnswer)
                {
                    if (t1 != t && t1.Text.Equals(t.Text))
                    {
                        check = true;
                        break;
                    }
                }
            }
            if (check)
            {
                MessageBox.Show("The answer can not be duplicate!");
                return;
            }
            Question question = context.Questions.Where(qe => qe.Id == q.Id).FirstOrDefault();
            question.Title = chuanhoa(txtTitle.Text);
            question.NumberOfAnswers = listAnswer.Count;
            context.SaveChanges();
            List<AnswersOfQuestion> listToDelete = context.AnswersOfQuestions.Where(a => a.Question == q.Id).ToList();
            foreach (AnswersOfQuestion a in listToDelete)
            {
                context.AnswersOfQuestions.Remove(a);
                context.SaveChanges();
            }
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
                    context.SaveChanges();
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
                        Question = q.Id,
                        Answer = answer.Id,
                        IsTrue = (listIsTrue[d].Checked) ? true : false
                    };
                    context.AnswersOfQuestions.Add(answersOfQuestion);
                }
                context.SaveChanges();

                d++;
            }
            MessageBox.Show("Update Successfully!");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeManager f = new HomeManager();
            f.ShowDialog();
        }
    }
}
