namespace Project
{
    partial class Submit
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
            lbStatus = new Label();
            btnExit = new Button();
            lbTime = new Label();
            SuspendLayout();
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbStatus.ForeColor = Color.Red;
            lbStatus.Location = new Point(68, 337);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(55, 21);
            lbStatus.TabIndex = 0;
            lbStatus.Text = "label1";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(522, 338);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lbTime
            // 
            lbTime.AutoSize = true;
            lbTime.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbTime.ForeColor = Color.MidnightBlue;
            lbTime.Location = new Point(293, 162);
            lbTime.Name = "lbTime";
            lbTime.Size = new Size(116, 50);
            lbTime.TabIndex = 2;
            lbTime.Text = "00:00";
            // 
            // Submit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 433);
            Controls.Add(lbTime);
            Controls.Add(btnExit);
            Controls.Add(lbStatus);
            Name = "Submit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Submit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbStatus;
        private Button btnExit;
        private Label lbTime;
    }
}