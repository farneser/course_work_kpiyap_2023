using AuthmatedWorkplace.Data;

namespace AuthmatedWorkplace.Pages
{
    partial class UpdateEnitityForm
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
            nameTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            descriptionTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            typeRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            typeRadioButton2 = new MaterialSkin.Controls.MaterialRadioButton();
            numTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            updateButton = new MaterialSkin.Controls.MaterialButton();
            dateTimePicker = new DateTimePicker();
            dateLabel = new MaterialSkin.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.AnimateReadOnly = false;
            nameTextBox.BackColor = SystemColors.Control;
            nameTextBox.BackgroundImageLayout = ImageLayout.None;
            nameTextBox.CharacterCasing = CharacterCasing.Normal;
            nameTextBox.Depth = 0;
            nameTextBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            nameTextBox.HideSelection = true;
            nameTextBox.Hint = Constants.Name;
            nameTextBox.LeadingIcon = null;
            nameTextBox.Location = new Point(19, 83);
            nameTextBox.MaxLength = 32767;
            nameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PasswordChar = '\0';
            nameTextBox.PrefixSuffixText = null;
            nameTextBox.ReadOnly = false;
            nameTextBox.RightToLeft = RightToLeft.No;
            nameTextBox.SelectedText = "";
            nameTextBox.SelectionLength = 0;
            nameTextBox.SelectionStart = 0;
            nameTextBox.ShortcutsEnabled = true;
            nameTextBox.Size = new Size(321, 48);
            nameTextBox.TabIndex = 1;
            nameTextBox.TabStop = false;
            nameTextBox.TextAlign = HorizontalAlignment.Left;
            nameTextBox.TrailingIcon = null;
            nameTextBox.UseSystemPasswordChar = false;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.AnimateReadOnly = false;
            descriptionTextBox.BackColor = SystemColors.Control;
            descriptionTextBox.BackgroundImageLayout = ImageLayout.None;
            descriptionTextBox.CharacterCasing = CharacterCasing.Normal;
            descriptionTextBox.Depth = 0;
            descriptionTextBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            descriptionTextBox.HideSelection = true;
            descriptionTextBox.Hint = Constants.Description;
            descriptionTextBox.LeadingIcon = null;
            descriptionTextBox.Location = new Point(19, 156);
            descriptionTextBox.MaxLength = 32767;
            descriptionTextBox.MouseState = MaterialSkin.MouseState.OUT;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.PasswordChar = '\0';
            descriptionTextBox.PrefixSuffixText = null;
            descriptionTextBox.ReadOnly = false;
            descriptionTextBox.RightToLeft = RightToLeft.No;
            descriptionTextBox.SelectedText = "";
            descriptionTextBox.SelectionLength = 0;
            descriptionTextBox.SelectionStart = 0;
            descriptionTextBox.ShortcutsEnabled = true;
            descriptionTextBox.Size = new Size(321, 48);
            descriptionTextBox.TabIndex = 2;
            descriptionTextBox.TabStop = false;
            descriptionTextBox.TextAlign = HorizontalAlignment.Left;
            descriptionTextBox.TrailingIcon = null;
            descriptionTextBox.UseSystemPasswordChar = false;
            // 
            // typeRadioButton1
            // 
            typeRadioButton1.AutoSize = true;
            typeRadioButton1.Checked = true;
            typeRadioButton1.Depth = 0;
            typeRadioButton1.Location = new Point(360, 83);
            typeRadioButton1.Margin = new Padding(0);
            typeRadioButton1.MouseLocation = new Point(-1, -1);
            typeRadioButton1.MouseState = MaterialSkin.MouseState.HOVER;
            typeRadioButton1.Name = "typeRadioButton1";
            typeRadioButton1.Ripple = true;
            typeRadioButton1.Size = new Size(100, 37);
            typeRadioButton1.TabIndex = 4;
            typeRadioButton1.TabStop = true;
            typeRadioButton1.Text = Constants.TypeOne;
            typeRadioButton1.UseVisualStyleBackColor = true;
            // 
            // typeRadioButton2
            // 
            typeRadioButton2.AutoSize = true;
            typeRadioButton2.Depth = 0;
            typeRadioButton2.Location = new Point(486, 83);
            typeRadioButton2.Margin = new Padding(0);
            typeRadioButton2.MouseLocation = new Point(-1, -1);
            typeRadioButton2.MouseState = MaterialSkin.MouseState.HOVER;
            typeRadioButton2.Name = "typeRadioButton2";
            typeRadioButton2.Ripple = true;
            typeRadioButton2.Size = new Size(122, 37);
            typeRadioButton2.TabIndex = 5;
            typeRadioButton2.TabStop = true;
            typeRadioButton2.Text = Constants.TypeTwo;
            typeRadioButton2.UseVisualStyleBackColor = true;
            // 
            // numTextBox
            // 
            numTextBox.AnimateReadOnly = false;
            numTextBox.BackColor = SystemColors.Control;
            numTextBox.BackgroundImageLayout = ImageLayout.None;
            numTextBox.CharacterCasing = CharacterCasing.Normal;
            numTextBox.Depth = 0;
            numTextBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            numTextBox.HideSelection = true;
            numTextBox.Hint = Constants.Num;
            numTextBox.LeadingIcon = null;
            numTextBox.Location = new Point(360, 156);
            numTextBox.MaxLength = 32767;
            numTextBox.MouseState = MaterialSkin.MouseState.OUT;
            numTextBox.Name = "numTextBox";
            numTextBox.PasswordChar = '\0';
            numTextBox.PrefixSuffixText = null;
            numTextBox.ReadOnly = false;
            numTextBox.RightToLeft = RightToLeft.No;
            numTextBox.SelectedText = "";
            numTextBox.SelectionLength = 0;
            numTextBox.SelectionStart = 0;
            numTextBox.ShortcutsEnabled = true;
            numTextBox.Size = new Size(321, 48);
            numTextBox.TabIndex = 6;
            numTextBox.TabStop = false;
            numTextBox.TextAlign = HorizontalAlignment.Left;
            numTextBox.TrailingIcon = null;
            numTextBox.UseSystemPasswordChar = false;
            numTextBox.KeyPress += numTextBox_KeyPress;
            // 
            // updateButton
            // 
            updateButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            updateButton.BackColor = Color.FromArgb(50, 50, 50);
            updateButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            updateButton.Depth = 0;
            updateButton.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            updateButton.ForeColor = Color.FromArgb(222, 255, 255, 255);
            updateButton.HighEmphasis = true;
            updateButton.Icon = null;
            updateButton.Location = new Point(605, 224);
            updateButton.Margin = new Padding(4, 6, 4, 6);
            updateButton.MouseState = MaterialSkin.MouseState.HOVER;
            updateButton.Name = "updateButton";
            updateButton.NoAccentTextColor = Color.Empty;
            updateButton.Size = new Size(76, 36);
            updateButton.TabIndex = 7;
            updateButton.Text = "Update";
            updateButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            updateButton.UseAccentColor = false;
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dateTimePicker.Location = new Point(66, 229);
            dateTimePicker.Margin = new Padding(10);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(321, 23);
            dateTimePicker.TabIndex = 8;
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Depth = 0;
            dateLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dateLabel.Location = new Point(19, 229);
            dateLabel.MouseState = MaterialSkin.MouseState.HOVER;
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(34, 19);
            dateLabel.TabIndex = 9;
            dateLabel.Text = Constants.Date;
            // 
            // UpdateEnitityForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 278);
            Controls.Add(dateLabel);
            Controls.Add(dateTimePicker);
            Controls.Add(updateButton);
            Controls.Add(numTextBox);
            Controls.Add(typeRadioButton2);
            Controls.Add(typeRadioButton1);
            Controls.Add(descriptionTextBox);
            Controls.Add(nameTextBox);
            Name = "UpdateEnitityForm";
            Text = $"Update";
            Load += UpdateEntityForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 nameTextBox;
        private MaterialSkin.Controls.MaterialTextBox2 descriptionTextBox;
        private MaterialSkin.Controls.MaterialRadioButton typeRadioButton1;
        private MaterialSkin.Controls.MaterialRadioButton typeRadioButton2;
        private MaterialSkin.Controls.MaterialTextBox2 numTextBox;
        private MaterialSkin.Controls.MaterialButton updateButton;
        private DateTimePicker dateTimePicker;
        private MaterialSkin.Controls.MaterialLabel dateLabel;
    }
}