namespace Project
{
    partial class HomeManager
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
            btnLogout = new Button();
            btnManageExam = new Button();
            btnManageQuestions = new Button();
            btnResult = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 19);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 0;
            label1.Text = "Welcome: ";
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.Location = new Point(315, 290);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(187, 33);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnManageExam
            // 
            btnManageExam.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnManageExam.Location = new Point(315, 99);
            btnManageExam.Name = "btnManageExam";
            btnManageExam.Size = new Size(187, 37);
            btnManageExam.TabIndex = 2;
            btnManageExam.Text = "Manage Exam Code";
            btnManageExam.UseVisualStyleBackColor = true;
            btnManageExam.Click += btnManageExam_Click;
            // 
            // btnManageQuestions
            // 
            btnManageQuestions.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnManageQuestions.Location = new Point(315, 167);
            btnManageQuestions.Name = "btnManageQuestions";
            btnManageQuestions.Size = new Size(187, 33);
            btnManageQuestions.TabIndex = 3;
            btnManageQuestions.Text = "Manage Questions";
            btnManageQuestions.UseVisualStyleBackColor = true;
            btnManageQuestions.Click += btnManageQuestions_Click;
            // 
            // btnResult
            // 
            btnResult.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnResult.Location = new Point(315, 229);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(187, 33);
            btnResult.TabIndex = 4;
            btnResult.Text = "View Result";
            btnResult.UseVisualStyleBackColor = true;
            btnResult.Click += btnResult_Click;
            // 
            // HomeManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnResult);
            Controls.Add(btnManageQuestions);
            Controls.Add(btnManageExam);
            Controls.Add(btnLogout);
            Controls.Add(label1);
            Name = "HomeManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomeManager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLogout;
        private Button btnManageExam;
        private Button btnManageQuestions;
        private Button btnResult;
    }
}