namespace Project
{
    partial class QuestionsManage
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
            btnHome = new Button();
            btnBack = new Button();
            groupBox1 = new GroupBox();
            btnCreate = new Button();
            dgvQuestions = new DataGridView();
            groupBox2 = new GroupBox();
            txtSearchTitle = new TextBox();
            label4 = new Label();
            cboCourses = new ComboBox();
            cboTypeQuestions = new ComboBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            txtID = new TextBox();
            label6 = new Label();
            txtTitle = new TextBox();
            groupBox3 = new GroupBox();
            dgvAnswers = new DataGridView();
            btnUpdate = new Button();
            btnDelete = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQuestions).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnswers).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(334, 9);
            label1.Name = "label1";
            label1.Size = new Size(298, 40);
            label1.TabIndex = 1;
            label1.Text = "Manage Questions";
            // 
            // btnHome
            // 
            btnHome.Location = new Point(1100, 9);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(75, 23);
            btnHome.TabIndex = 4;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(1205, 9);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCreate);
            groupBox1.Controls.Add(dgvQuestions);
            groupBox1.Location = new Point(323, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(957, 466);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Questions";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(0, 23);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(153, 23);
            btnCreate.TabIndex = 15;
            btnCreate.Text = "+ Create new Question";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // dgvQuestions
            // 
            dgvQuestions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuestions.Location = new Point(0, 51);
            dgvQuestions.Name = "dgvQuestions";
            dgvQuestions.RowTemplate.Height = 25;
            dgvQuestions.Size = new Size(957, 409);
            dgvQuestions.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSearchTitle);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cboCourses);
            groupBox2.Controls.Add(cboTypeQuestions);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(12, 52);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(305, 460);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filter";
            // 
            // txtSearchTitle
            // 
            txtSearchTitle.Location = new Point(67, 209);
            txtSearchTitle.Multiline = true;
            txtSearchTitle.Name = "txtSearchTitle";
            txtSearchTitle.Size = new Size(238, 122);
            txtSearchTitle.TabIndex = 6;
            txtSearchTitle.TextChanged += txtSearchTitle_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 261);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 5;
            label4.Text = "Title";
            // 
            // cboCourses
            // 
            cboCourses.FormattingEnabled = true;
            cboCourses.Location = new Point(67, 112);
            cboCourses.Name = "cboCourses";
            cboCourses.Size = new Size(121, 23);
            cboCourses.TabIndex = 4;
            cboCourses.SelectedIndexChanged += cboCourses_SelectedIndexChanged;
            // 
            // cboTypeQuestions
            // 
            cboTypeQuestions.FormattingEnabled = true;
            cboTypeQuestions.Location = new Point(67, 163);
            cboTypeQuestions.Name = "cboTypeQuestions";
            cboTypeQuestions.Size = new Size(121, 23);
            cboTypeQuestions.TabIndex = 3;
            cboTypeQuestions.SelectedIndexChanged += cboTypeQuestions_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(994, 112);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 166);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 1;
            label3.Text = "Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 115);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 0;
            label2.Text = "Course:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 516);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 8;
            label5.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(66, 513);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 9;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 588);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 10;
            label6.Text = "Title";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(66, 546);
            txtTitle.Multiline = true;
            txtTitle.Name = "txtTitle";
            txtTitle.ReadOnly = true;
            txtTitle.Size = new Size(238, 104);
            txtTitle.TabIndex = 11;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvAnswers);
            groupBox3.Location = new Point(323, 524);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(944, 176);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Answers";
            // 
            // dgvAnswers
            // 
            dgvAnswers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnswers.Location = new Point(0, 22);
            dgvAnswers.Name = "dgvAnswers";
            dgvAnswers.RowTemplate.Height = 25;
            dgvAnswers.Size = new Size(957, 154);
            dgvAnswers.TabIndex = 0;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(207, 677);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(55, 677);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // QuestionsManage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1292, 712);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(groupBox3);
            Controls.Add(txtTitle);
            Controls.Add(label6);
            Controls.Add(txtID);
            Controls.Add(label5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnBack);
            Controls.Add(btnHome);
            Controls.Add(label1);
            Name = "QuestionsManage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Questions";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQuestions).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAnswers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnHome;
        private Button btnBack;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox cboCourses;
        private ComboBox cboTypeQuestions;
        private ComboBox comboBox1;
        private Label label3;
        private Label label2;
        private TextBox txtSearchTitle;
        private Label label4;
        private Button btnCreate;
        private DataGridView dgvQuestions;
        private Label label5;
        private TextBox txtID;
        private Label label6;
        private TextBox txtTitle;
        private GroupBox groupBox3;
        private DataGridView dgvAnswers;
        private Button btnUpdate;
        private Button btnDelete;
    }
}