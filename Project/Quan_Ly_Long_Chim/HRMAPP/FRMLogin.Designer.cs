namespace HRMAPP
{
    partial class FRMLogin
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
            txt_Email = new TextBox();
            txt_Password = new TextBox();
            label1 = new Label();
            label3 = new Label();
            bttn_Login = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(157, 96);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(179, 27);
            txt_Email.TabIndex = 0;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(157, 129);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(179, 27);
            txt_Password.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(88, 99);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 2;
            label1.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(64, 132);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // bttn_Login
            // 
            bttn_Login.BackColor = SystemColors.Highlight;
            bttn_Login.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bttn_Login.ForeColor = SystemColors.HighlightText;
            bttn_Login.Location = new Point(157, 173);
            bttn_Login.Name = "bttn_Login";
            bttn_Login.Size = new Size(94, 29);
            bttn_Login.TabIndex = 5;
            bttn_Login.Text = "Login";
            bttn_Login.UseVisualStyleBackColor = false;
            bttn_Login.Click += bttn_Login_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(179, 22);
            label2.Name = "label2";
            label2.Size = new Size(97, 41);
            label2.TabIndex = 6;
            label2.Text = "Login";
            // 
            // FRMLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 228);
            Controls.Add(label2);
            Controls.Add(bttn_Login);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txt_Password);
            Controls.Add(txt_Email);
            Name = "FRMLogin";
            Text = "FRMLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Email;
        private TextBox txt_Password;
        private Label label1;
        private Label label3;
        private Button bttn_Login;
        private Label label2;
    }
}