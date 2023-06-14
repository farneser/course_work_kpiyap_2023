using MaterialSkin.Controls;

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
            userNameTextBox = new MaterialTextBox2();
            firstNameTextBox = new MaterialTextBox2();
            lastNameTextBox = new MaterialTextBox2();
            emailTextBox = new MaterialTextBox2();
            passwordTextBox = new MaterialTextBox2();
            passwordConfirmTextBox = new MaterialTextBox2();
            registerButton = new MaterialButton();
            canselButton = new MaterialButton();
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
            userNameTextBox.Location = new Point(26, 90);
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
            userNameTextBox.Size = new Size(321, 48);
            userNameTextBox.TabIndex = 0;
            userNameTextBox.TabStop = false;
            userNameTextBox.TextAlign = HorizontalAlignment.Left;
            userNameTextBox.TrailingIcon = null;
            userNameTextBox.UseSystemPasswordChar = false;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.AnimateReadOnly = false;
            firstNameTextBox.BackColor = Color.FromArgb(50, 50, 50);
            firstNameTextBox.BackgroundImageLayout = ImageLayout.None;
            firstNameTextBox.CharacterCasing = CharacterCasing.Normal;
            firstNameTextBox.Depth = 0;
            firstNameTextBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            firstNameTextBox.HideSelection = true;
            firstNameTextBox.Hint = "First name";
            firstNameTextBox.LeadingIcon = null;
            firstNameTextBox.Location = new Point(26, 163);
            firstNameTextBox.MaxLength = 32767;
            firstNameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.PasswordChar = '\0';
            firstNameTextBox.PrefixSuffixText = null;
            firstNameTextBox.ReadOnly = false;
            firstNameTextBox.RightToLeft = RightToLeft.No;
            firstNameTextBox.SelectedText = "";
            firstNameTextBox.SelectionLength = 0;
            firstNameTextBox.SelectionStart = 0;
            firstNameTextBox.ShortcutsEnabled = true;
            firstNameTextBox.Size = new Size(321, 48);
            firstNameTextBox.TabIndex = 1;
            firstNameTextBox.TabStop = false;
            firstNameTextBox.TextAlign = HorizontalAlignment.Left;
            firstNameTextBox.TrailingIcon = null;
            firstNameTextBox.UseSystemPasswordChar = false;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.AnimateReadOnly = false;
            lastNameTextBox.BackColor = Color.FromArgb(50, 50, 50);
            lastNameTextBox.BackgroundImageLayout = ImageLayout.None;
            lastNameTextBox.CharacterCasing = CharacterCasing.Normal;
            lastNameTextBox.Depth = 0;
            lastNameTextBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lastNameTextBox.HideSelection = true;
            lastNameTextBox.Hint = "Last name";
            lastNameTextBox.LeadingIcon = null;
            lastNameTextBox.Location = new Point(372, 163);
            lastNameTextBox.MaxLength = 32767;
            lastNameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.PasswordChar = '\0';
            lastNameTextBox.PrefixSuffixText = null;
            lastNameTextBox.ReadOnly = false;
            lastNameTextBox.RightToLeft = RightToLeft.No;
            lastNameTextBox.SelectedText = "";
            lastNameTextBox.SelectionLength = 0;
            lastNameTextBox.SelectionStart = 0;
            lastNameTextBox.ShortcutsEnabled = true;
            lastNameTextBox.Size = new Size(321, 48);
            lastNameTextBox.TabIndex = 2;
            lastNameTextBox.TabStop = false;
            lastNameTextBox.TextAlign = HorizontalAlignment.Left;
            lastNameTextBox.TrailingIcon = null;
            lastNameTextBox.UseSystemPasswordChar = false;
            // 
            // emailTextBox
            // 
            emailTextBox.AnimateReadOnly = false;
            emailTextBox.BackColor = Color.FromArgb(50, 50, 50);
            emailTextBox.BackgroundImageLayout = ImageLayout.None;
            emailTextBox.CharacterCasing = CharacterCasing.Normal;
            emailTextBox.Depth = 0;
            emailTextBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            emailTextBox.HideSelection = true;
            emailTextBox.Hint = "Email";
            emailTextBox.LeadingIcon = null;
            emailTextBox.Location = new Point(372, 90);
            emailTextBox.MaxLength = 32767;
            emailTextBox.MouseState = MaterialSkin.MouseState.OUT;
            emailTextBox.Name = "emailTextBox";
            emailTextBox.PasswordChar = '\0';
            emailTextBox.PrefixSuffixText = null;
            emailTextBox.ReadOnly = false;
            emailTextBox.RightToLeft = RightToLeft.No;
            emailTextBox.SelectedText = "";
            emailTextBox.SelectionLength = 0;
            emailTextBox.SelectionStart = 0;
            emailTextBox.ShortcutsEnabled = true;
            emailTextBox.Size = new Size(321, 48);
            emailTextBox.TabIndex = 3;
            emailTextBox.TabStop = false;
            emailTextBox.TextAlign = HorizontalAlignment.Left;
            emailTextBox.TrailingIcon = null;
            emailTextBox.UseSystemPasswordChar = false;
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
            passwordTextBox.Location = new Point(26, 239);
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
            passwordTextBox.Size = new Size(321, 48);
            passwordTextBox.TabIndex = 4;
            passwordTextBox.TabStop = false;
            passwordTextBox.TextAlign = HorizontalAlignment.Left;
            passwordTextBox.TrailingIcon = null;
            passwordTextBox.UseSystemPasswordChar = false;
            // 
            // passwordConfirmTextBox
            // 
            passwordConfirmTextBox.AnimateReadOnly = false;
            passwordConfirmTextBox.BackColor = Color.FromArgb(50, 50, 50);
            passwordConfirmTextBox.BackgroundImageLayout = ImageLayout.None;
            passwordConfirmTextBox.CharacterCasing = CharacterCasing.Normal;
            passwordConfirmTextBox.Depth = 0;
            passwordConfirmTextBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            passwordConfirmTextBox.HideSelection = true;
            passwordConfirmTextBox.Hint = "Confirm password";
            passwordConfirmTextBox.LeadingIcon = null;
            passwordConfirmTextBox.Location = new Point(372, 239);
            passwordConfirmTextBox.MaxLength = 32767;
            passwordConfirmTextBox.MouseState = MaterialSkin.MouseState.OUT;
            passwordConfirmTextBox.Name = "passwordConfirmTextBox";
            passwordConfirmTextBox.PasswordChar = '\0';
            passwordConfirmTextBox.PrefixSuffixText = null;
            passwordConfirmTextBox.ReadOnly = false;
            passwordConfirmTextBox.RightToLeft = RightToLeft.No;
            passwordConfirmTextBox.SelectedText = "";
            passwordConfirmTextBox.SelectionLength = 0;
            passwordConfirmTextBox.SelectionStart = 0;
            passwordConfirmTextBox.ShortcutsEnabled = true;
            passwordConfirmTextBox.Size = new Size(321, 48);
            passwordConfirmTextBox.TabIndex = 5;
            passwordConfirmTextBox.TabStop = false;
            passwordConfirmTextBox.TextAlign = HorizontalAlignment.Left;
            passwordConfirmTextBox.TrailingIcon = null;
            passwordConfirmTextBox.UseSystemPasswordChar = false;
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
            registerButton.Location = new Point(26, 312);
            registerButton.Margin = new Padding(4, 6, 4, 6);
            registerButton.MouseState = MaterialSkin.MouseState.HOVER;
            registerButton.Name = "registerButton";
            registerButton.NoAccentTextColor = Color.Empty;
            registerButton.Size = new Size(89, 36);
            registerButton.TabIndex = 6;
            registerButton.Text = "Register";
            registerButton.Type = MaterialButton.MaterialButtonType.Contained;
            registerButton.UseAccentColor = false;
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // canselButton
            // 
            canselButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            canselButton.BackColor = Color.FromArgb(50, 50, 50);
            canselButton.Density = MaterialButton.MaterialButtonDensity.Default;
            canselButton.Depth = 0;
            canselButton.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            canselButton.ForeColor = Color.FromArgb(222, 255, 255, 255);
            canselButton.HighEmphasis = true;
            canselButton.Icon = null;
            canselButton.Location = new Point(145, 312);
            canselButton.Margin = new Padding(4, 6, 4, 6);
            canselButton.MouseState = MaterialSkin.MouseState.HOVER;
            canselButton.Name = "canselButton";
            canselButton.NoAccentTextColor = Color.Empty;
            canselButton.Size = new Size(76, 36);
            canselButton.TabIndex = 7;
            canselButton.Text = "Cansel";
            canselButton.Type = MaterialButton.MaterialButtonType.Contained;
            canselButton.UseAccentColor = false;
            canselButton.UseVisualStyleBackColor = false;
            canselButton.Click += canselButton_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 376);
            Controls.Add(canselButton);
            Controls.Add(registerButton);
            Controls.Add(passwordConfirmTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(userNameTextBox);
            Name = "Register";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialTextBox2 userNameTextBox;
        private MaterialTextBox2 firstNameTextBox;
        private MaterialTextBox2 lastNameTextBox;
        private MaterialTextBox2 emailTextBox;
        private MaterialTextBox2 passwordTextBox;
        private MaterialTextBox2 passwordConfirmTextBox;
        private MaterialButton registerButton;
        private MaterialButton canselButton;
    }
}