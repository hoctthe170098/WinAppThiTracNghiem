namespace Project
{
    partial class ExamCodeManager
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
            label1 = new Label();
            btnCreateExamCode = new Button();
            groupBox1 = new GroupBox();
            txtStatusAssign = new TextBox();
            label14 = new Label();
            btnReAssign = new Button();
            label13 = new Label();
            txtUsernameAssign = new TextBox();
            txtCodeAssign = new TextBox();
            label12 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox3 = new GroupBox();
            numQuestions = new NumericUpDown();
            label15 = new Label();
            cboStatus = new ComboBox();
            label8 = new Label();
            cboTime = new ComboBox();
            btnDelete = new Button();
            dgvExamCode = new DataGridView();
            btnDescription = new Button();
            btnUpdate = new Button();
            numLong = new NumericUpDown();
            txtCode = new TextBox();
            dtpDateBegin = new DateTimePicker();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            btnHome = new Button();
            btnBack = new Button();
            groupBox4 = new GroupBox();
            dgvListQuestion = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuestions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvExamCode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLong).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListQuestion).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(389, 9);
            label1.Name = "label1";
            label1.Size = new Size(322, 40);
            label1.TabIndex = 0;
            label1.Text = "Manage Exam Code";
            // 
            // btnCreateExamCode
            // 
            btnCreateExamCode.Location = new Point(501, 6);
            btnCreateExamCode.Name = "btnCreateExamCode";
            btnCreateExamCode.Size = new Size(121, 23);
            btnCreateExamCode.TabIndex = 1;
            btnCreateExamCode.Text = "+Create Exam Code";
            btnCreateExamCode.UseVisualStyleBackColor = true;
            btnCreateExamCode.Click += btnCreateExamCode_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtStatusAssign);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(btnReAssign);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txtUsernameAssign);
            groupBox1.Controls.Add(txtCodeAssign);
            groupBox1.Controls.Add(label12);
            groupBox1.Location = new Point(12, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(305, 685);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "ReAssign";
            // 
            // txtStatusAssign
            // 
            txtStatusAssign.Location = new Point(73, 150);
            txtStatusAssign.Name = "txtStatusAssign";
            txtStatusAssign.ReadOnly = true;
            txtStatusAssign.Size = new Size(144, 23);
            txtStatusAssign.TabIndex = 12;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 153);
            label14.Name = "label14";
            label14.Size = new Size(42, 15);
            label14.TabIndex = 11;
            label14.Text = "Status:";
            // 
            // btnReAssign
            // 
            btnReAssign.Location = new Point(108, 210);
            btnReAssign.Name = "btnReAssign";
            btnReAssign.Size = new Size(75, 23);
            btnReAssign.TabIndex = 10;
            btnReAssign.Text = "Reassign";
            btnReAssign.UseVisualStyleBackColor = true;
            btnReAssign.Click += btnReAssign_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 106);
            label13.Name = "label13";
            label13.Size = new Size(63, 15);
            label13.TabIndex = 9;
            label13.Text = "Username:";
            // 
            // txtUsernameAssign
            // 
            txtUsernameAssign.Location = new Point(73, 103);
            txtUsernameAssign.Name = "txtUsernameAssign";
            txtUsernameAssign.Size = new Size(226, 23);
            txtUsernameAssign.TabIndex = 8;
            txtUsernameAssign.TextChanged += txtUsernameAssign_TextChanged;
            // 
            // txtCodeAssign
            // 
            txtCodeAssign.Location = new Point(73, 52);
            txtCodeAssign.Name = "txtCodeAssign";
            txtCodeAssign.ReadOnly = true;
            txtCodeAssign.Size = new Size(226, 23);
            txtCodeAssign.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 55);
            label12.Name = "label12";
            label12.Size = new Size(38, 15);
            label12.TabIndex = 6;
            label12.Text = "Code:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(325, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(366, 418);
            dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 46);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "Code:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 91);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "Status:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 140);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 3;
            label4.Text = "Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 191);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 4;
            label5.Text = "Time:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 236);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 9;
            label6.Text = "Long:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvListQuestion);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Controls.Add(dgvExamCode);
            groupBox3.Controls.Add(btnCreateExamCode);
            groupBox3.Location = new Point(323, 52);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1048, 685);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "ExamCode";
            // 
            // numQuestions
            // 
            numQuestions.Location = new Point(81, 189);
            numQuestions.Maximum = new decimal(new int[] { 70, 0, 0, 0 });
            numQuestions.Minimum = new decimal(new int[] { 20, 0, 0, 0 });
            numQuestions.Name = "numQuestions";
            numQuestions.ReadOnly = true;
            numQuestions.Size = new Size(120, 23);
            numQuestions.TabIndex = 24;
            numQuestions.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(8, 191);
            label15.Name = "label15";
            label15.Size = new Size(63, 15);
            label15.TabIndex = 23;
            label15.Text = "Questions:";
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "Active", "NonActive" });
            cboStatus.Location = new Point(80, 61);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(121, 23);
            cboStatus.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 64);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 21;
            label8.Text = "Status";
            // 
            // cboTime
            // 
            cboTime.FormattingEnabled = true;
            cboTime.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            cboTime.Location = new Point(80, 126);
            cboTime.Name = "cboTime";
            cboTime.Size = new Size(121, 23);
            cboTime.TabIndex = 20;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(48, 231);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvExamCode
            // 
            dgvExamCode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExamCode.Location = new Point(501, 35);
            dgvExamCode.Name = "dgvExamCode";
            dgvExamCode.RowTemplate.Height = 25;
            dgvExamCode.Size = new Size(534, 643);
            dgvExamCode.TabIndex = 12;
            // 
            // btnDescription
            // 
            btnDescription.Location = new Point(346, 231);
            btnDescription.Name = "btnDescription";
            btnDescription.Size = new Size(75, 23);
            btnDescription.TabIndex = 11;
            btnDescription.Text = "Description";
            btnDescription.UseVisualStyleBackColor = true;
            btnDescription.Click += btnDescription_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(204, 231);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // numLong
            // 
            numLong.Location = new Point(81, 155);
            numLong.Maximum = new decimal(new int[] { 70, 0, 0, 0 });
            numLong.Minimum = new decimal(new int[] { 20, 0, 0, 0 });
            numLong.Name = "numLong";
            numLong.ReadOnly = true;
            numLong.Size = new Size(120, 23);
            numLong.TabIndex = 9;
            numLong.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // txtCode
            // 
            txtCode.Location = new Point(80, 29);
            txtCode.Name = "txtCode";
            txtCode.ReadOnly = true;
            txtCode.Size = new Size(199, 23);
            txtCode.TabIndex = 7;
            txtCode.TextChanged += txtCode_TextChanged;
            // 
            // dtpDateBegin
            // 
            dtpDateBegin.Location = new Point(80, 90);
            dtpDateBegin.Name = "dtpDateBegin";
            dtpDateBegin.Size = new Size(200, 23);
            dtpDateBegin.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(8, 163);
            label11.Name = "label11";
            label11.Size = new Size(37, 15);
            label11.TabIndex = 4;
            label11.Text = "Long:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 129);
            label10.Name = "label10";
            label10.Size = new Size(30, 15);
            label10.TabIndex = 3;
            label10.Text = "Slot:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 96);
            label9.Name = "label9";
            label9.Size = new Size(64, 15);
            label9.TabIndex = 2;
            label9.Text = "DateBegin:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 32);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 0;
            label7.Text = "Code:";
            // 
            // btnHome
            // 
            btnHome.Location = new Point(1191, 9);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(75, 23);
            btnHome.TabIndex = 9;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(1283, 9);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 10;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // groupBox4
            // 
            groupBox4.CausesValidation = false;
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(btnDelete);
            groupBox4.Controls.Add(numQuestions);
            groupBox4.Controls.Add(btnDescription);
            groupBox4.Controls.Add(txtCode);
            groupBox4.Controls.Add(btnUpdate);
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(cboTime);
            groupBox4.Controls.Add(cboStatus);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(dtpDateBegin);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(numLong);
            groupBox4.Controls.Add(label11);
            groupBox4.Location = new Point(6, 22);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(489, 271);
            groupBox4.TabIndex = 25;
            groupBox4.TabStop = false;
            groupBox4.Text = "Info";
            // 
            // dgvListQuestion
            // 
            dgvListQuestion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListQuestion.Location = new Point(6, 299);
            dgvListQuestion.Name = "dgvListQuestion";
            dgvListQuestion.RowTemplate.Height = 25;
            dgvListQuestion.Size = new Size(489, 379);
            dgvListQuestion.TabIndex = 26;
            // 
            // ExamCodeManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(btnBack);
            Controls.Add(btnHome);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "ExamCodeManager";
            Text = "ExamCodeManager";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numQuestions).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvExamCode).EndInit();
            ((System.ComponentModel.ISupportInitialize)numLong).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListQuestion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCreateExamCode;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtLong;
        private Label label6;
        private Button button4;
        private GroupBox groupBox3;
        private Label label7;
        private DateTimePicker dtpDateBegin;
        private Label label11;
        private Label label10;
        private Label label9;
        private DataGridView dgvExamCode;
        private Button btnDescription;
        private Button btnUpdate;
        private NumericUpDown numLong;
        private TextBox txtCode;
        private Button btnDelete;
        private Button btnHome;
        private Button btnBack;
        private TextBox txtStatusAssign;
        private Label label14;
        private Button btnReAssign;
        private Label label13;
        private TextBox txtUsernameAssign;
        private TextBox txtCodeAssign;
        private Label label12;
        private ComboBox cboTime;
        private ComboBox cboStatus;
        private Label label8;
        private NumericUpDown numQuestions;
        private Label label15;
        private GroupBox groupBox4;
        private DataGridView dgvListQuestion;
    }
}