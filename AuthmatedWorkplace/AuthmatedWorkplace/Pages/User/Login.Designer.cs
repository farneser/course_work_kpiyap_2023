using MaterialSkin.Controls;

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
            userNameTextBox = new MaterialTextBox2();
            passwordTextBox = new MaterialTextBox2();
            loginButton = new MaterialButton();
            registerButton = new MaterialButton();
            SuspendLayout();
            // 
            // userNameTextBox
            // 
            userNameTextBox.AnimateReadOnly = false;
            userNameTextBox.BackColor = Color.FromArgb(50, 50, 50);
            userNameTextBox.BackgroundImageLayout = ImageLayout.None;
            userNameTextBox.CharacterCasing = CharacterCasing.Normal;
            userNameTextBox.Depth = 0;
            userNameTextBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            userNameTextBox.HideSelection = true;
            userNameTextBox.Hint = "UserName";
            userNameTextBox.LeadingIcon = null;
            userNameTextBox.Location = new Point(30, 89);
            userNameTextBox.MaxLength = 32767;
            userNameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.PasswordChar = '\0';
            userNameTextBox.PrefixSuffixText = null;
            userNameTextBox.ReadOnly = false;
            userNameTextBox.RightToLeft = RightToLeft.No;
            userNameTextBox.SelectedText = "";
            userNameTextBox.SelectionLength = 0;
            userNameTextBox.SelectionStart = 0;
            userNameTextBox.ShortcutsEnabled = true;
            userNameTextBox.Size = new Size(275, 48);
            userNameTextBox.TabIndex = 2;
            userNameTextBox.TabStop = false;
            userNameTextBox.TextAlign = HorizontalAlignment.Left;
            userNameTextBox.TrailingIcon = null;
            userNameTextBox.UseSystemPasswordChar = false;
            // 
            // passwordTextBox
            // 
            passwordTextBox.AnimateReadOnly = false;
            passwordTextBox.BackColor = Color.FromArgb(50, 50, 50);
            passwordTextBox.BackgroundImageLayout = ImageLayout.None;
            passwordTextBox.CharacterCasing = CharacterCasing.Normal;
            passwordTextBox.Depth = 0;
            passwordTextBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            passwordTextBox.HideSelection = true;
            passwordTextBox.Hint = "Password";
            passwordTextBox.LeadingIcon = null;
            passwordTextBox.Location = new Point(30, 165);
            passwordTextBox.MaxLength = 32767;
            passwordTextBox.MouseState = MaterialSkin.MouseState.OUT;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '\0';
            passwordTextBox.PrefixSuffixText = null;
            passwordTextBox.ReadOnly = false;
            passwordTextBox.RightToLeft = RightToLeft.No;
            passwordTextBox.SelectedText = "";
            passwordTextBox.SelectionLength = 0;
            passwordTextBox.SelectionStart = 0;
            passwordTextBox.ShortcutsEnabled = true;
            passwordTextBox.Size = new Size(275, 48);
            passwordTextBox.TabIndex = 3;
            passwordTextBox.TabStop = false;
            passwordTextBox.TextAlign = HorizontalAlignment.Left;
            passwordTextBox.TrailingIcon = null;
            passwordTextBox.UseSystemPasswordChar = false;
            // 
            // loginButton
            // 
            loginButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loginButton.BackColor = Color.FromArgb(50, 50, 50);
            loginButton.Density = MaterialButton.MaterialButtonDensity.Default;
            loginButton.Depth = 0;
            loginButton.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            loginButton.ForeColor = Color.FromArgb(222, 255, 255, 255);
            loginButton.HighEmphasis = true;
            loginButton.Icon = null;
            loginButton.Location = new Point(30, 234);
            loginButton.Margin = new Padding(4, 6, 4, 6);
            loginButton.MouseState = MaterialSkin.MouseState.HOVER;
            loginButton.Name = "loginButton";
            loginButton.NoAccentTextColor = Color.Empty;
            loginButton.Size = new Size(64, 36);
            loginButton.TabIndex = 4;
            loginButton.Text = "Login";
            loginButton.Type = MaterialButton.MaterialButtonType.Contained;
            loginButton.UseAccentColor = false;
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // registerButton
            // 
            registerButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            registerButton.BackColor = Color.FromArgb(50, 50, 50);
            registerButton.Density = MaterialButton.MaterialButtonDensity.Default;
            registerButton.Depth = 0;
            registerButton.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            registerButton.ForeColor = Color.FromArgb(222, 255, 255, 255);
            registerButton.HighEmphasis = true;
            registerButton.Icon = null;
            registerButton.Location = new Point(123, 234);
            registerButton.Margin = new Padding(4, 6, 4, 6);
            registerButton.MouseState = MaterialSkin.MouseState.HOVER;
            registerButton.Name = "registerButton";
            registerButton.NoAccentTextColor = Color.Empty;
            registerButton.Size = new Size(89, 36);
            registerButton.TabIndex = 5;
            registerButton.Text = "Register";
            registerButton.Type = MaterialButton.MaterialButtonType.Contained;
            registerButton.UseAccentColor = false;
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 298);
            Controls.Add(registerButton);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(userNameTextBox);
            Name = "Login";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialTextBox2 userNameTextBox;
        private MaterialTextBox2 passwordTextBox;
        private MaterialButton loginButton;
        private MaterialButton registerButton;
    }
}