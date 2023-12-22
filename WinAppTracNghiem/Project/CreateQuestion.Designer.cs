namespace Project
{
    partial class CreateQuestion
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
            grCreateQuestions = new GroupBox();
            cb2 = new CheckBox();
            cb1 = new CheckBox();
            txtAns2 = new TextBox();
            txtAns1 = new TextBox();
            btnAddAns = new Button();
            btnCreate = new Button();
            label5 = new Label();
            label4 = new Label();
            txtTitle = new TextBox();
            label3 = new Label();
            label2 = new Label();
            cboCourses = new ComboBox();
            cboType = new ComboBox();
            btnHome = new Button();
            btnBack = new Button();
            grCreateQuestions.SuspendLayout();
            SuspendLayout();
            // 
            // grCreateQuestions
            // 
            grCreateQuestions.Controls.Add(cb2);
            grCreateQuestions.Controls.Add(cb1);
            grCreateQuestions.Controls.Add(txtAns2);
            grCreateQuestions.Controls.Add(txtAns1);
            grCreateQuestions.Controls.Add(btnAddAns);
            grCreateQuestions.Controls.Add(btnCreate);
            grCreateQuestions.Controls.Add(label5);
            grCreateQuestions.Controls.Add(label4);
            grCreateQuestions.Controls.Add(txtTitle);
            grCreateQuestions.Controls.Add(label3);
            grCreateQuestions.Controls.Add(label2);
            grCreateQuestions.Controls.Add(cboCourses);
            grCreateQuestions.Controls.Add(cboType);
            grCreateQuestions.Location = new Point(12, 41);
            grCreateQuestions.Name = "grCreateQuestions";
            grCreateQuestions.Size = new Size(1000, 502);
            grCreateQuestions.TabIndex = 3;
            grCreateQuestions.TabStop = false;
            grCreateQuestions.Text = "Create";
            // 
            // cb2
            // 
            cb2.AutoSize = true;
            cb2.Location = new Point(734, 245);
            cb2.Name = "cb2";
            cb2.Size = new Size(56, 19);
            cb2.TabIndex = 13;
            cb2.Text = "isTrue";
            cb2.UseVisualStyleBackColor = true;
            // 
            // cb1
            // 
            cb1.AutoSize = true;
            cb1.Location = new Point(734, 201);
            cb1.Name = "cb1";
            cb1.Size = new Size(56, 19);
            cb1.TabIndex = 12;
            cb1.Text = "isTrue";
            cb1.UseVisualStyleBackColor = true;
            // 
            // txtAns2
            // 
            txtAns2.Location = new Point(218, 243);
            txtAns2.Name = "txtAns2";
            txtAns2.Size = new Size(499, 23);
            txtAns2.TabIndex = 11;
            // 
            // txtAns1
            // 
            txtAns1.Location = new Point(218, 199);
            txtAns1.Name = "txtAns1";
            txtAns1.Size = new Size(499, 23);
            txtAns1.TabIndex = 10;
            // 
            // btnAddAns
            // 
            btnAddAns.Location = new Point(93, 165);
            btnAddAns.Name = "btnAddAns";
            btnAddAns.Size = new Size(119, 23);
            btnAddAns.TabIndex = 9;
            btnAddAns.Text = "+Add new answer";
            btnAddAns.UseVisualStyleBackColor = true;
            btnAddAns.Click += btnAddAns_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(481, 473);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 8;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(218, 169);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 7;
            label5.Text = "Answer:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(218, 129);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 6;
            label4.Text = "Type:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(274, 50);
            txtTitle.Multiline = true;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(628, 62);
            txtTitle.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 72);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 4;
            label3.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(218, 24);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 3;
            label2.Text = "Course:";
            // 
            // cboCourses
            // 
            cboCourses.FormattingEnabled = true;
            cboCourses.Location = new Point(274, 21);
            cboCourses.Name = "cboCourses";
            cboCourses.Size = new Size(121, 23);
            cboCourses.TabIndex = 1;
            // 
            // cboType
            // 
            cboType.FormattingEnabled = true;
            cboType.Location = new Point(274, 126);
            cboType.Name = "cboType";
            cboType.Size = new Size(121, 23);
            cboType.TabIndex = 0;
            cboType.SelectedIndexChanged += cboType_SelectedIndexChanged;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(842, 12);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(75, 23);
            btnHome.TabIndex = 8;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(937, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // CreateQuestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 555);
            Controls.Add(btnBack);
            Controls.Add(grCreateQuestions);
            Controls.Add(btnHome);
            Name = "CreateQuestion";
            Text = "CreateQuestion";
            grCreateQuestions.ResumeLayout(false);
            grCreateQuestions.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grCreateQuestions;
        private Button btnBack;
        private Button btnHome;
        private Label label5;
        private Label label4;
        private TextBox txtTitle;
        private Label label3;
        private Label label2;
        private ComboBox cboCourses;
        private ComboBox cboType;
        private Button btnCreate;
        private Button btnAddAns;
        private TextBox txtAns2;
        private TextBox txtAns1;
        private CheckBox cb2;
        private CheckBox cb1;
    }
}