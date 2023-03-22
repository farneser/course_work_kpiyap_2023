namespace AuthmatedWorkplace.Pages
{
    partial class MainForm
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
            mainFormMenuStrip = new MenuStrip();
            applicationToolStripMenuItem = new ToolStripMenuItem();
            themeToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            typeToolStripMenuItem = new ToolStripMenuItem();
            greenToolStripMenuItem = new ToolStripMenuItem();
            blueToolStripMenuItem = new ToolStripMenuItem();
            orangeToolStripMenuItem = new ToolStripMenuItem();
            lightToolStripMenuItem = new ToolStripMenuItem();
            darkToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            mainFormMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // mainFormMenuStrip
            // 
            mainFormMenuStrip.BackColor = Color.FromArgb(50, 50, 50);
            mainFormMenuStrip.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            mainFormMenuStrip.ForeColor = Color.FromArgb(222, 255, 255, 255);
            mainFormMenuStrip.Items.AddRange(new ToolStripItem[] { applicationToolStripMenuItem, themeToolStripMenuItem });
            mainFormMenuStrip.Location = new Point(3, 64);
            mainFormMenuStrip.Name = "mainFormMenuStrip";
            mainFormMenuStrip.Size = new Size(794, 25);
            mainFormMenuStrip.TabIndex = 0;
            mainFormMenuStrip.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            applicationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem, exitToolStripMenuItem });
            applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            applicationToolStripMenuItem.Size = new Size(90, 21);
            applicationToolStripMenuItem.Text = "Application";
            // 
            // themeToolStripMenuItem
            // 
            themeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { colorToolStripMenuItem, typeToolStripMenuItem });
            themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            themeToolStripMenuItem.Size = new Size(62, 21);
            themeToolStripMenuItem.Text = "Theme";
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { greenToolStripMenuItem, blueToolStripMenuItem, orangeToolStripMenuItem });
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(180, 22);
            colorToolStripMenuItem.Text = "Color";
            // 
            // typeToolStripMenuItem
            // 
            typeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lightToolStripMenuItem, darkToolStripMenuItem });
            typeToolStripMenuItem.Name = "typeToolStripMenuItem";
            typeToolStripMenuItem.Size = new Size(180, 22);
            typeToolStripMenuItem.Text = "Type";
            // 
            // greenToolStripMenuItem
            // 
            greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            greenToolStripMenuItem.Size = new Size(180, 22);
            greenToolStripMenuItem.Text = "Green";
            greenToolStripMenuItem.Click += greenToolStripMenuItem_Click;
            // 
            // blueToolStripMenuItem
            // 
            blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            blueToolStripMenuItem.Size = new Size(180, 22);
            blueToolStripMenuItem.Text = "Blue";
            blueToolStripMenuItem.Click += blueToolStripMenuItem_Click;
            // 
            // orangeToolStripMenuItem
            // 
            orangeToolStripMenuItem.Name = "orangeToolStripMenuItem";
            orangeToolStripMenuItem.Size = new Size(180, 22);
            orangeToolStripMenuItem.Text = "Orange";
            orangeToolStripMenuItem.Click += orangeToolStripMenuItem_Click;
            // 
            // lightToolStripMenuItem
            // 
            lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            lightToolStripMenuItem.Size = new Size(180, 22);
            lightToolStripMenuItem.Text = "Light";
            lightToolStripMenuItem.Click += lightToolStripMenuItem_Click;
            // 
            // darkToolStripMenuItem
            // 
            darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            darkToolStripMenuItem.Size = new Size(180, 22);
            darkToolStripMenuItem.Text = "Dark";
            darkToolStripMenuItem.Click += darkToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(180, 22);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mainFormMenuStrip);
            MainMenuStrip = mainFormMenuStrip;
            Name = "MainForm";
            Text = "MainForm";
            mainFormMenuStrip.ResumeLayout(false);
            mainFormMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mainFormMenuStrip;
        private ToolStripMenuItem applicationToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem themeToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem greenToolStripMenuItem;
        private ToolStripMenuItem blueToolStripMenuItem;
        private ToolStripMenuItem orangeToolStripMenuItem;
        private ToolStripMenuItem typeToolStripMenuItem;
        private ToolStripMenuItem lightToolStripMenuItem;
        private ToolStripMenuItem darkToolStripMenuItem;
    }
}