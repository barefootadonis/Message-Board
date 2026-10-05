namespace Final_project
{
    partial class WelcomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblGreeting = new Label();
            lblQuestion = new Label();
            txtUsername = new TextBox();
            btnEnter = new Button();
            lblWarning = new Label();
            btnLogin = new Button();
            btnSignUp = new Button();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblGreeting
            // 
            lblGreeting.AutoSize = true;
            lblGreeting.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGreeting.Location = new Point(380, 43);
            lblGreeting.Margin = new Padding(4, 0, 4, 0);
            lblGreeting.Name = "lblGreeting";
            lblGreeting.Size = new Size(429, 57);
            lblGreeting.TabIndex = 1;
            lblGreeting.Text = "Welcome To Mind Mingle";
            lblGreeting.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuestion.Location = new Point(344, 290);
            lblQuestion.Margin = new Padding(4, 0, 4, 0);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(103, 28);
            lblQuestion.TabIndex = 2;
            lblQuestion.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(344, 360);
            txtUsername.Margin = new Padding(4, 5, 4, 5);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(141, 31);
            txtUsername.TabIndex = 0;
            // 
            // btnEnter
            // 
            btnEnter.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEnter.Location = new Point(953, 605);
            btnEnter.Margin = new Padding(4, 5, 4, 5);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(131, 53);
            btnEnter.TabIndex = 2;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblWarning.Location = new Point(350, 225);
            lblWarning.Margin = new Padding(4, 0, 4, 0);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(0, 32);
            lblWarning.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(253, 280);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(120, 72);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(700, 280);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(126, 72);
            btnSignUp.TabIndex = 7;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(350, 437);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(91, 25);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(344, 495);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(150, 31);
            txtPassword.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(791, 607);
            btnBack.Margin = new Padding(4, 5, 4, 5);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(131, 53);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // WelcomePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(btnBack);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(btnSignUp);
            Controls.Add(btnLogin);
            Controls.Add(lblWarning);
            Controls.Add(btnEnter);
            Controls.Add(txtUsername);
            Controls.Add(lblQuestion);
            Controls.Add(lblGreeting);
            Margin = new Padding(4, 5, 4, 5);
            Name = "WelcomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            KeyDown += WelcomePage_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblGreeting;
        private Label lblQuestion;
        private TextBox txtUsername;
        private Button btnEnter;
        private Label lblWarning;
        private Button btnLogin;
        private Button btnSignUp;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnBack;
    }
}
