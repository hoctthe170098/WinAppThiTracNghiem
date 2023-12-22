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
    public partial class Exam : Form
    {
        int done = 0;
        int num = 0;
        String user, examCode;
        WinAppTracNghiemContext context = new WinAppTracNghiemContext();
        List<Question> listQuestions = new List<Question>();
        List<int> chooseQuestion = new List<int>();
        List<List<TextBox>> listAnswer = new List<List<TextBox>>();
        List<List<CheckBox>> listIsTrue = new List<List<CheckBox>>();
        ExamCode exam = new ExamCode();
        int? time;
        public Exam()
        {
            InitializeComponent();

        }
        public Exam(String username, String code) : this()
        {
            user = username;
            examCode = code;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            exam = context.ExamCodes.Where(e => e.Code.Equals(code)).FirstOrDefault();
            List<int> data1 = context.QuestionOfCodes.Where(qc => qc.ExamCode.Equals(exam.Code)).Select(qc => qc.Question).ToList();
            List<Question> data = context.Questions.Where(q => q.Course.Equals(exam.Course)
            && data1.Contains(q.Id)).ToList();
            Random r = new Random();
            int count = data.Count;
            while (count > 0)
            {
                int index = r.Next(0, data.Count - 1);
                listQuestions.Add(data[index]);
                data.RemoveAt(index);
                count--;
            }
            CreateQuestion(listQuestions, listAnswer, listIsTrue, chooseQuestion);
            lbChoose.Text = "Choose " + chooseQuestion[num] + " answer";
            txtTitle.Text = listQuestions[num].Title;
            txtQuestionNow.Text = (num + 1).ToString();
            List<TextBox> text = listAnswer[num];
            List<CheckBox> check = listIsTrue[num];
            for (int i = 0; i < text.Count; i++)
            {
                groupBox1.Controls.Add(check[i]);
                groupBox1.Controls.Add(text[i]);
            }
            txtQuestionsDone.Text = done.ToString();
            time = exam.Long * 60;
            txtCode.Text = code;
            txtNumberOfQuestions.Text = exam.NumberOfQuestion.ToString();
            txtUserName.Text = username;
            timer1.Start();
        }
        private void CreateQuestion(List<Question> question, List<List<TextBox>> answer
            , List<List<CheckBox>> isTrue, List<int> chooseQuestion)
        {
            foreach (Question q in question)
            {
                int choose = context.AnswersOfQuestions
                    .Where(a => a.Question == q.Id && a.IsTrue == true).Count();
                chooseQuestion.Add(choose);
                List<TextBox> textBoxes = new List<TextBox>();
                List<CheckBox> checkBoxes = new List<CheckBox>();
                int dem = 0;
                List<Answer> data = context.Answers.Where(ans => context.AnswersOfQuestions.Where(a => a.Question == q.Id).Select(a => a.Answer).ToList().Contains(ans.Id)).ToList();
                foreach (Answer a in data)
                {
                    TextBox textBox = new TextBox();
                    textBox.Location = new Point(47, 124 + dem * 70);
                    textBox.Multiline = true;
                    textBox.Name = "ans" + a.Id;
                    textBox.ReadOnly = true;
                    textBox.Size = new Size(718, 62);
                    textBox.TabIndex = 15;
                    textBox.Text = a.Content;
                    textBoxes.Add(textBox);
                    CheckBox checkBox = new CheckBox();
                    checkBox.AutoSize = true;
                    checkBox.Location = new Point(26, 148 + dem * 70);
                    checkBox.Name = "cb" + a.Id;
                    checkBox.Size = new Size(15, 14);
                    checkBox.TabIndex = 14;
                    checkBox.UseVisualStyleBackColor = true;
                    checkBoxes.Add(checkBox);
                    dem++;
                }
                answer.Add(textBoxes);
                isTrue.Add(checkBoxes);

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            lbTime.Text = (time / 60) + ":" + ((time % 60 < 10) ? "0" : "") + (time % 60);
            if (time == 0)
            {
                int doTrue = 0;
                for (int i = 0; i < listQuestions.Count; i++)
                {
                    List<CheckBox> isTrue = listIsTrue[i];
                    if (checkIsTrue(listQuestions[i].Id, isTrue))
                    {
                        doTrue++;
                    }
                }
                timer1.Stop();
                Practice p = context.Practices.Where(p => p.Username.Equals(user) && p.ExamCode.Equals(examCode)
                && p.Status.Equals("Doing")).FirstOrDefault();
                p.Status = "Done";
                p.Long = exam.Long * 60 - time;
                double? mark = (double)doTrue / exam.NumberOfQuestion;
                p.Mark = Math.Round((decimal)(mark * 10), 2);
                context.SaveChanges();
                SaveFile();
                Submit f = new Submit(user, examCode, time);
                this.Hide();
                f.ShowDialog();
            }
        }
        private int checkDo()
        {
            int count = 0;
            foreach (var item in listIsTrue)
            {
                foreach (var item1 in item)
                {
                    if (item1.Checked)
                    {
                        count++;
                        break;
                    }
                }
            }
            return count;
        }
        private void display(int n)
        {
            List<TextBox> text = listAnswer[n];
            List<CheckBox> check = listIsTrue[n];
            for (int i = 0; i < text.Count; i++)
            {
                groupBox1.Controls.Add(check[i]);
                groupBox1.Controls.Add(text[i]);
            }
        }
        private void Remove(int n)
        {
            List<TextBox> text = listAnswer[n];
            List<CheckBox> check = listIsTrue[n];
            for (int i = 0; i < text.Count; i++)
            {
                groupBox1.Controls.Remove(check[i]);
                groupBox1.Controls.Remove(text[i]);
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cbSumbit.Checked)
            {
                int doTrue = 0;
                for (int i = 0; i < listQuestions.Count; i++)
                {
                    List<CheckBox> isTrue = listIsTrue[i];
                    if (checkIsTrue(listQuestions[i].Id, isTrue))
                    {
                        doTrue++;
                    }
                }
                timer1.Stop();
                Practice p = context.Practices.Where(p => p.Username.Equals(user) && p.ExamCode.Equals(examCode)
                && p.Status.Equals("Doing")).FirstOrDefault();
                p.Status = "Done";
                p.Long = exam.Long * 60 - time;
                double? mark = (double)doTrue / exam.NumberOfQuestion;
                p.Mark = Math.Round((decimal)(mark * 10), 2);
                context.SaveChanges();
                SaveFile();
                Submit f = new Submit(user, examCode, time);
                this.Hide();
                f.ShowDialog();
            }
        }

        private void SaveFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(user + "Do" + examCode+".txt"))
                {
                    int count = 0;
                    foreach (Question q in listQuestions)
                    {
                        String answer = "";
                        List<CheckBox> check = listIsTrue[count];
                        foreach (CheckBox c in check)
                        {
                            if (c.Checked)
                            {
                                answer += c.Name.Substring(2) + "   ";
                            }
                        }
                        writer.WriteLine("Q" + q.Id + "     " + answer);
                        count++;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private bool checkIsTrue(int idQ, List<CheckBox> list)
        {
            List<AnswersOfQuestion> answer = context.AnswersOfQuestions.Where(ans => ans.Question == idQ).ToList();
            foreach (CheckBox c in list)
            {
                int idA = Convert.ToInt32(c.Name.Substring(2));
                var a = answer.Where(an => an.Answer == idA).FirstOrDefault();
                if ((c.Checked && a.IsTrue == false) || (!c.Checked && a.IsTrue == true)) return false;
            }
            return true;
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            num++;
            txtQuestionsDone.Text = checkDo().ToString();
            if (num == listQuestions.Count) num = 0;
            lbChoose.Text = "Choose " + chooseQuestion[num] + " answer";
            txtTitle.Text = listQuestions[num].Title;
            txtQuestionNow.Text = (num + 1).ToString();
            if (num == 0) Remove(listQuestions.Count - 1);
            else Remove(num - 1);
            display(num);

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            num--;
            txtQuestionsDone.Text = checkDo().ToString();
            if (num == -1) num = listQuestions.Count - 1;
            lbChoose.Text = "Choose " + chooseQuestion[num] + " answer";
            txtTitle.Text = listQuestions[num].Title;
            txtQuestionNow.Text = (num + 1).ToString();
            if (num == listQuestions.Count - 1) Remove(0);
            else Remove(num + 1);
            display(num);
        }
    }
}
