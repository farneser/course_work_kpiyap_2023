namespace AuthmatedWorkplace
{
    partial class Register
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
            userNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            emailTextBox = new TextBox();
            passwordTextBox = new TextBox();
            passwordConfirmTextBox = new TextBox();
            registerButton = new Button();
            firstNameLabel = new Label();
            userNameLabel = new Label();
            lastNameLabel = new Label();
            emailLabel = new Label();
            passwordLabel = new Label();
            passwordConfirmLabel = new Label();
            SuspendLayout();
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(139, 12);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(100, 23);
            userNameTextBox.TabIndex = 0;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(139, 41);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(100, 23);
            firstNameTextBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(139, 70);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(100, 23);
            lastNameTextBox.TabIndex = 2;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(139, 99);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(100, 23);
            emailTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(139, 128);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(100, 23);
            passwordTextBox.TabIndex = 4;
            // 
            // passwordConfirmTextBox
            // 
            passwordConfirmTextBox.Location = new Point(139, 157);
            passwordConfirmTextBox.Name = "passwordConfirmTextBox";
            passwordConfirmTextBox.Size = new Size(100, 23);
            passwordConfirmTextBox.TabIndex = 5;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(149, 186);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(75, 23);
            registerButton.TabIndex = 6;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(12, 44);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(60, 15);
            firstNameLabel.TabIndex = 7;
            firstNameLabel.Text = "first name";
            firstNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(12, 15);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(59, 15);
            userNameLabel.TabIndex = 8;
            userNameLabel.Text = "username";
            userNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(12, 73);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(58, 15);
            lastNameLabel.TabIndex = 9;
            lastNameLabel.Text = "last name";
            lastNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(12, 102);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(36, 15);
            emailLabel.TabIndex = 10;
            emailLabel.Text = "email";
            emailLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(12, 131);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(57, 15);
            passwordLabel.TabIndex = 11;
            passwordLabel.Text = "password";
            passwordLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passwordConfirmLabel
            // 
            passwordConfirmLabel.AutoSize = true;
            passwordConfirmLabel.Location = new Point(12, 160);
            passwordConfirmLabel.Name = "passwordConfirmLabel";
            passwordConfirmLabel.Size = new Size(102, 15);
            passwordConfirmLabel.TabIndex = 12;
            passwordConfirmLabel.Text = "confirm password";
            passwordConfirmLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 225);
            Controls.Add(passwordConfirmLabel);
            Controls.Add(passwordLabel);
            Controls.Add(emailLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(userNameLabel);
            Controls.Add(firstNameLabel);
            Controls.Add(registerButton);
            Controls.Add(passwordConfirmTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(userNameTextBox);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userNameTextBox;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox emailTextBox;
        private TextBox passwordTextBox;
        private TextBox passwordConfirmTextBox;
        private Button registerButton;
        private Label firstNameLabel;
        private Label userNameLabel;
        private Label lastNameLabel;
        private Label emailLabel;
        private Label passwordLabel;
        private Label passwordConfirmLabel;
    }
}