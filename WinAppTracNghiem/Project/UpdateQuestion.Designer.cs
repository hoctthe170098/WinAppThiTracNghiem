namespace Project
{
    partial class UpdateQuestion
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
            lbType = new Label();
            lbCourse = new Label();
            btnAddAns = new Button();
            btnUpdate = new Button();
            label5 = new Label();
            label4 = new Label();
            txtTitle = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnHome = new Button();
            btnBack = new Button();
            grCreateQuestions.SuspendLayout();
            SuspendLayout();
            // 
            // grCreateQuestions
            // 
            grCreateQuestions.Controls.Add(lbType);
            grCreateQuestions.Controls.Add(lbCourse);
            grCreateQuestions.Controls.Add(btnAddAns);
            grCreateQuestions.Controls.Add(btnUpdate);
            grCreateQuestions.Controls.Add(label5);
            grCreateQuestions.Controls.Add(label4);
            grCreateQuestions.Controls.Add(txtTitle);
            grCreateQuestions.Controls.Add(label3);
            grCreateQuestions.Controls.Add(label2);
            grCreateQuestions.Location = new Point(12, 41);
            grCreateQuestions.Name = "grCreateQuestions";
            grCreateQuestions.Size = new Size(1000, 550);
            grCreateQuestions.TabIndex = 3;
            grCreateQuestions.TabStop = false;
            grCreateQuestions.Text = "Update";
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.Location = new Point(274, 129);
            lbType.Name = "lbType";
            lbType.Size = new Size(38, 15);
            lbType.TabIndex = 19;
            lbType.Text = "label6";
            // 
            // lbCourse
            // 
            lbCourse.AutoSize = true;
            lbCourse.Location = new Point(271, 24);
            lbCourse.Name = "lbCourse";
            lbCourse.Size = new Size(38, 15);
            lbCourse.TabIndex = 18;
            lbCourse.Text = "label1";
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
            // btnUpdate
            // 
            btnUpdate.Location = new Point(403, 506);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
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
            // UpdateQuestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 603);
            Controls.Add(btnBack);
            Controls.Add(grCreateQuestions);
            Controls.Add(btnHome);
            Name = "UpdateQuestion";
            Text = "UpdateQuestion";
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
        private Button btnUpdate;
        private Button btnAddAns;
        private Label lbType;
        private Label lbCourse;
    }
}