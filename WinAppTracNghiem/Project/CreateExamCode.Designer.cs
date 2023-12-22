namespace Project
{
    partial class CreateExamCode
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
            dgvListQuestions = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnHome = new Button();
            btnBack = new Button();
            label5 = new Label();
            label6 = new Label();
            cboSemesters = new ComboBox();
            cboCourses = new ComboBox();
            btnRemove = new Button();
            label8 = new Label();
            txtCode = new TextBox();
            dtpDate = new DateTimePicker();
            numLong = new NumericUpDown();
            txtTitle = new TextBox();
            btnAdd = new Button();
            btnCreate = new Button();
            groupBox1 = new GroupBox();
            txtIDQuestion = new TextBox();
            label7 = new Label();
            groupBox2 = new GroupBox();
            numQuestions = new NumericUpDown();
            label9 = new Label();
            cboTime = new ComboBox();
            lstQuestions = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dgvListQuestions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLong).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuestions).BeginInit();
            SuspendLayout();
            // 
            // dgvListQuestions
            // 
            dgvListQuestions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListQuestions.Location = new Point(441, 41);
            dgvListQuestions.Name = "dgvListQuestions";
            dgvListQuestions.RowTemplate.Height = 25;
            dgvListQuestions.Size = new Size(926, 693);
            dgvListQuestions.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 111);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "Code:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 153);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 3;
            label2.Text = "Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 192);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 4;
            label3.Text = "Slot:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 232);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 5;
            label4.Text = "Long:";
            // 
            // btnHome
            // 
            btnHome.Location = new Point(1190, 12);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(75, 23);
            btnHome.TabIndex = 6;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(1283, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 29);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 8;
            label5.Text = "Semester:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 69);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 9;
            label6.Text = "Course:";
            // 
            // cboSemesters
            // 
            cboSemesters.FormattingEnabled = true;
            cboSemesters.Location = new Point(70, 26);
            cboSemesters.Name = "cboSemesters";
            cboSemesters.Size = new Size(121, 23);
            cboSemesters.TabIndex = 10;
            // 
            // cboCourses
            // 
            cboCourses.FormattingEnabled = true;
            cboCourses.Location = new Point(70, 66);
            cboCourses.Name = "cboCourses";
            cboCourses.Size = new Size(121, 23);
            cboCourses.TabIndex = 11;
            cboCourses.SelectedIndexChanged += cboCourses_SelectedIndexChanged;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(331, 714);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 12;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 94);
            label8.Name = "label8";
            label8.Size = new Size(32, 15);
            label8.TabIndex = 14;
            label8.Text = "Title:";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(70, 108);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(200, 23);
            txtCode.TabIndex = 15;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(70, 147);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 17;
            // 
            // numLong
            // 
            numLong.Location = new Point(70, 230);
            numLong.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            numLong.Minimum = new decimal(new int[] { 30, 0, 0, 0 });
            numLong.Name = "numLong";
            numLong.Size = new Size(120, 23);
            numLong.TabIndex = 18;
            numLong.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(58, 59);
            txtTitle.Multiline = true;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(217, 86);
            txtTitle.TabIndex = 19;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(94, 151);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(107, 714);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 21;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtIDQuestion);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtTitle);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Location = new Point(13, 519);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(281, 189);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Question:";
            // 
            // txtIDQuestion
            // 
            txtIDQuestion.Location = new Point(58, 26);
            txtIDQuestion.Name = "txtIDQuestion";
            txtIDQuestion.ReadOnly = true;
            txtIDQuestion.Size = new Size(100, 23);
            txtIDQuestion.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 29);
            label7.Name = "label7";
            label7.Size = new Size(21, 15);
            label7.TabIndex = 21;
            label7.Text = "ID:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numQuestions);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(cboTime);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(cboSemesters);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(numLong);
            groupBox2.Controls.Add(cboCourses);
            groupBox2.Controls.Add(dtpDate);
            groupBox2.Controls.Add(txtCode);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(13, 37);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(281, 476);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "Create Code:";
            // 
            // numQuestions
            // 
            numQuestions.Location = new Point(70, 268);
            numQuestions.Maximum = new decimal(new int[] { 70, 0, 0, 0 });
            numQuestions.Minimum = new decimal(new int[] { 20, 0, 0, 0 });
            numQuestions.Name = "numQuestions";
            numQuestions.Size = new Size(120, 23);
            numQuestions.TabIndex = 21;
            numQuestions.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 270);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 20;
            label9.Text = "Question:";
            // 
            // cboTime
            // 
            cboTime.FormattingEnabled = true;
            cboTime.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            cboTime.Location = new Point(70, 189);
            cboTime.Name = "cboTime";
            cboTime.Size = new Size(121, 23);
            cboTime.TabIndex = 19;
            // 
            // lstQuestions
            // 
            lstQuestions.FormattingEnabled = true;
            lstQuestions.ItemHeight = 15;
            lstQuestions.Location = new Point(300, 41);
            lstQuestions.Name = "lstQuestions";
            lstQuestions.Size = new Size(135, 664);
            lstQuestions.TabIndex = 24;
            // 
            // CreateExamCode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(lstQuestions);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnCreate);
            Controls.Add(btnRemove);
            Controls.Add(btnBack);
            Controls.Add(btnHome);
            Controls.Add(dgvListQuestions);
            Name = "CreateExamCode";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateExamCode";
            ((System.ComponentModel.ISupportInitialize)dgvListQuestions).EndInit();
            ((System.ComponentModel.ISupportInitialize)numLong).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuestions).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListQuestions;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnHome;
        private Button btnBack;
        private Label label5;
        private Label label6;
        private ComboBox cboSemesters;
        private ComboBox cboCourses;
        private Button btnRemove;
        private Label label8;
        private TextBox txtCode;
        private DateTimePicker dtpDate;
        private NumericUpDown numLong;
        private TextBox txtTitle;
        private Button btnAdd;
        private Button btnCreate;
        private GroupBox groupBox1;
        private TextBox txtIDQuestion;
        private Label label7;
        private GroupBox groupBox2;
        private ComboBox cboTime;
        private ListBox lstQuestions;
        private NumericUpDown numQuestions;
        private Label label9;
    }
}