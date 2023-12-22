namespace Project
{
    partial class Result
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
            dgvResult = new DataGridView();
            groupBox1 = new GroupBox();
            cboCourses = new ComboBox();
            cboSemesters = new ComboBox();
            txtName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvDes = new DataGridView();
            txtCode = new TextBox();
            Code = new Label();
            txtUsername = new TextBox();
            label4 = new Label();
            btnHome = new Button();
            btnBack = new Button();
            btnDes = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDes).BeginInit();
            SuspendLayout();
            // 
            // dgvResult
            // 
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Location = new Point(438, 47);
            dgvResult.Name = "dgvResult";
            dgvResult.RowTemplate.Height = 25;
            dgvResult.Size = new Size(929, 690);
            dgvResult.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboCourses);
            groupBox1.Controls.Add(cboSemesters);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(420, 167);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            // 
            // cboCourses
            // 
            cboCourses.FormattingEnabled = true;
            cboCourses.Location = new Point(90, 129);
            cboCourses.Name = "cboCourses";
            cboCourses.Size = new Size(121, 23);
            cboCourses.TabIndex = 5;
            cboCourses.SelectedIndexChanged += cboCourses_SelectedIndexChanged;
            // 
            // cboSemesters
            // 
            cboSemesters.FormattingEnabled = true;
            cboSemesters.Location = new Point(90, 91);
            cboSemesters.Name = "cboSemesters";
            cboSemesters.Size = new Size(121, 23);
            cboSemesters.TabIndex = 4;
            cboSemesters.SelectedIndexChanged += cboSemesters_SelectedIndexChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(90, 47);
            txtName.Name = "txtName";
            txtName.Size = new Size(121, 23);
            txtName.TabIndex = 3;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 132);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 2;
            label3.Text = "Courses:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 94);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Semesters:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 50);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // dgvDes
            // 
            dgvDes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDes.Location = new Point(12, 328);
            dgvDes.Name = "dgvDes";
            dgvDes.RowTemplate.Height = 25;
            dgvDes.Size = new Size(420, 409);
            dgvDes.TabIndex = 11;
            dgvDes.CellClick += dgvDes_CellClick;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(102, 256);
            txtCode.Name = "txtCode";
            txtCode.ReadOnly = true;
            txtCode.Size = new Size(201, 23);
            txtCode.TabIndex = 10;
            txtCode.TextChanged += txtCode_TextChanged;
            // 
            // Code
            // 
            Code.AutoSize = true;
            Code.Location = new Point(37, 259);
            Code.Name = "Code";
            Code.Size = new Size(38, 15);
            Code.TabIndex = 9;
            Code.Text = "Code:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(102, 224);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(121, 23);
            txtUsername.TabIndex = 8;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 227);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 7;
            label4.Text = "Name:";
            // 
            // btnHome
            // 
            btnHome.Location = new Point(1190, 9);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(75, 23);
            btnHome.TabIndex = 2;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(1283, 9);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnDes
            // 
            btnDes.Location = new Point(165, 285);
            btnDes.Name = "btnDes";
            btnDes.Size = new Size(75, 23);
            btnDes.TabIndex = 12;
            btnDes.Text = "Description";
            btnDes.UseVisualStyleBackColor = true;
            btnDes.Click += btnDes_Click;
            // 
            // Result
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(btnDes);
            Controls.Add(Code);
            Controls.Add(txtCode);
            Controls.Add(label4);
            Controls.Add(txtUsername);
            Controls.Add(dgvDes);
            Controls.Add(btnBack);
            Controls.Add(btnHome);
            Controls.Add(groupBox1);
            Controls.Add(dgvResult);
            Name = "Result";
            Text = "Result";
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvResult;
        private GroupBox groupBox1;
        private Button btnHome;
        private Button btnBack;
        private Label label2;
        private Label label1;
        private ComboBox cboCourses;
        private ComboBox cboSemesters;
        private TextBox txtName;
        private Label label3;
        private TextBox txtUsername;
        private Label label4;
        private TextBox txtCode;
        private Label Code;
        private DataGridView dgvDes;
        private Button btnDes;
    }
}