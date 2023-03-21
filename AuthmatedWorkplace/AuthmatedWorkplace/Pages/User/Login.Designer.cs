namespace AuthmatedWorkplace
{
    partial class Login
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
            userNameLabel = new Label();
            passwordLabel = new Label();
            userNameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            loginButton = new Button();
            registerButton = new Button();
            SuspendLayout();
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(12, 15);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(59, 15);
            userNameLabel.TabIndex = 0;
            userNameLabel.Text = "username";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(123, 15);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(57, 15);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "password";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(12, 50);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(100, 23);
            userNameTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(123, 50);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(100, 23);
            passwordTextBox.TabIndex = 3;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(12, 79);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(100, 23);
            loginButton.TabIndex = 4;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(123, 79);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(100, 23);
            registerButton.TabIndex = 5;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(236, 129);
            Controls.Add(registerButton);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(userNameTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(userNameLabel);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userNameLabel;
        private Label passwordLabel;
        private TextBox userNameTextBox;
        private TextBox passwordTextBox;
        private Button loginButton;
        private Button registerButton;
    }
}