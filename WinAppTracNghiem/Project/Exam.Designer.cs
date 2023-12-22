namespace Project
{
    partial class Exam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            txtCode = new TextBox();
            txtNumberOfQuestions = new TextBox();
            cbSumbit = new CheckBox();
            btnSubmit = new Button();
            lbUser = new Label();
            txtUserName = new TextBox();
            lbTime = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1 = new GroupBox();
            txtTitle = new TextBox();
            label5 = new Label();
            txtQuestionsDone = new TextBox();
            groupBox2 = new GroupBox();
            btnBack = new Button();
            lbChoose = new Label();
            btnNext = new Button();
            txtQuestionNow = new TextBox();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 1;
            label2.Text = "Number of questions:";
            // 
            // txtCode
            // 
            txtCode.ForeColor = Color.Red;
            txtCode.Location = new Point(140, 19);
            txtCode.Name = "txtCode";
            txtCode.ReadOnly = true;
            txtCode.Size = new Size(180, 23);
            txtCode.TabIndex = 2;
            // 
            // txtNumberOfQuestions
            // 
            txtNumberOfQuestions.ForeColor = Color.Red;
            txtNumberOfQuestions.Location = new Point(140, 57);
            txtNumberOfQuestions.Name = "txtNumberOfQuestions";
            txtNumberOfQuestions.ReadOnly = true;
            txtNumberOfQuestions.Size = new Size(100, 23);
            txtNumberOfQuestions.TabIndex = 3;
            // 
            // cbSumbit
            // 
            cbSumbit.AutoSize = true;
            cbSumbit.Location = new Point(362, 14);
            cbSumbit.Name = "cbSumbit";
            cbSumbit.Size = new Size(154, 19);
            cbSumbit.TabIndex = 4;
            cbSumbit.Text = "I want to sumbit the test";
            cbSumbit.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(522, 11);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.Location = new Point(964, 18);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(33, 15);
            lbUser.TabIndex = 6;
            lbUser.Text = "User:";
            // 
            // txtUserName
            // 
            txtUserName.ForeColor = Color.Red;
            txtUserName.Location = new Point(1003, 14);
            txtUserName.Name = "txtUserName";
            txtUserName.ReadOnly = true;
            txtUserName.Size = new Size(254, 23);
            txtUserName.TabIndex = 7;
            // 
            // lbTime
            // 
            lbTime.AutoSize = true;
            lbTime.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbTime.ForeColor = Color.FromArgb(0, 0, 192);
            lbTime.Location = new Point(576, 46);
            lbTime.Name = "lbTime";
            lbTime.Size = new Size(104, 47);
            lbTime.TabIndex = 8;
            lbTime.Text = "00:00";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTitle);
            groupBox1.Location = new Point(232, 131);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(829, 606);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Question";
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitle.Location = new Point(16, 22);
            txtTitle.Multiline = true;
            txtTitle.Name = "txtTitle";
            txtTitle.ReadOnly = true;
            txtTitle.ScrollBars = ScrollBars.Vertical;
            txtTitle.Size = new Size(807, 84);
            txtTitle.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(235, 102);
            label5.Name = "label5";
            label5.Size = new Size(203, 15);
            label5.TabIndex = 10;
            label5.Text = "Number of questions you have done:";
            // 
            // txtQuestionsDone
            // 
            txtQuestionsDone.ForeColor = Color.Red;
            txtQuestionsDone.Location = new Point(444, 99);
            txtQuestionsDone.Name = "txtQuestionsDone";
            txtQuestionsDone.ReadOnly = true;
            txtQuestionsDone.Size = new Size(100, 23);
            txtQuestionsDone.TabIndex = 12;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBack);
            groupBox2.Controls.Add(lbChoose);
            groupBox2.Controls.Add(btnNext);
            groupBox2.Controls.Add(txtQuestionNow);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(6, 131);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(220, 606);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Info";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(11, 156);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 16;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lbChoose
            // 
            lbChoose.AutoSize = true;
            lbChoose.Location = new Point(20, 38);
            lbChoose.Name = "lbChoose";
            lbChoose.Size = new Size(96, 15);
            lbChoose.TabIndex = 15;
            lbChoose.Text = "Choose 1 answer";
            // 
            // btnNext
            // 
            btnNext.Location = new Point(106, 156);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 14;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // txtQuestionNow
            // 
            txtQuestionNow.Location = new Point(81, 88);
            txtQuestionNow.Name = "txtQuestionNow";
            txtQuestionNow.ReadOnly = true;
            txtQuestionNow.Size = new Size(86, 23);
            txtQuestionNow.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 91);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 0;
            label6.Text = "Question";
            // 
            // Exam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(groupBox2);
            Controls.Add(txtQuestionsDone);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(lbTime);
            Controls.Add(txtUserName);
            Controls.Add(lbUser);
            Controls.Add(btnSubmit);
            Controls.Add(cbSumbit);
            Controls.Add(txtNumberOfQuestions);
            Controls.Add(txtCode);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Exam";
            Text = "Exam";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCode;
        private TextBox txtNumberOfQuestions;
        private CheckBox cbSumbit;
        private Button btnSubmit;
        private Label lbUser;
        private TextBox txtUserName;
        private Label lbTime;
        private System.Windows.Forms.Timer timer1;
        private GroupBox groupBox1;
        private Label label5;
        private TextBox txtQuestionsDone;
        private GroupBox groupBox2;
        private Button btnNext;
        private TextBox txtQuestionNow;
        private Label label6;
        private TextBox txtTitle;
        private Label lbChoose;
        private Button btnBack;
    }
}