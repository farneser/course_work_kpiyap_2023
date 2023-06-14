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
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            themeToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            greenToolStripMenuItem = new ToolStripMenuItem();
            blueToolStripMenuItem = new ToolStripMenuItem();
            orangeToolStripMenuItem = new ToolStripMenuItem();
            typeToolStripMenuItem = new ToolStripMenuItem();
            lightToolStripMenuItem = new ToolStripMenuItem();
            darkToolStripMenuItem = new ToolStripMenuItem();
            createToolStripMenuItem = new ToolStripMenuItem();
            dataFlowLayoutPanel = new FlowLayoutPanel();
            mainFormMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // mainFormMenuStrip
            // 
            mainFormMenuStrip.BackColor = Color.FromArgb(50, 50, 50);
            mainFormMenuStrip.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            mainFormMenuStrip.ForeColor = Color.FromArgb(222, 255, 255, 255);
            mainFormMenuStrip.Items.AddRange(new ToolStripItem[] { applicationToolStripMenuItem, themeToolStripMenuItem, createToolStripMenuItem });
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
            applicationToolStripMenuItem.Size = new Size(89, 21);
            applicationToolStripMenuItem.Text = "Application";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(120, 22);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(120, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // themeToolStripMenuItem
            // 
            themeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { colorToolStripMenuItem, typeToolStripMenuItem });
            themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            themeToolStripMenuItem.Size = new Size(64, 21);
            themeToolStripMenuItem.Text = "Theme";
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { greenToolStripMenuItem, blueToolStripMenuItem, orangeToolStripMenuItem });
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(109, 22);
            colorToolStripMenuItem.Text = "Color";
            // 
            // greenToolStripMenuItem
            // 
            greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            greenToolStripMenuItem.Size = new Size(124, 22);
            greenToolStripMenuItem.Text = "Green";
            greenToolStripMenuItem.Click += greenToolStripMenuItem_Click;
            // 
            // blueToolStripMenuItem
            // 
            blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            blueToolStripMenuItem.Size = new Size(124, 22);
            blueToolStripMenuItem.Text = "Blue";
            blueToolStripMenuItem.Click += blueToolStripMenuItem_Click;
            // 
            // orangeToolStripMenuItem
            // 
            orangeToolStripMenuItem.Name = "orangeToolStripMenuItem";
            orangeToolStripMenuItem.Size = new Size(124, 22);
            orangeToolStripMenuItem.Text = "Orange";
            orangeToolStripMenuItem.Click += orangeToolStripMenuItem_Click;
            // 
            // typeToolStripMenuItem
            // 
            typeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lightToolStripMenuItem, darkToolStripMenuItem });
            typeToolStripMenuItem.Name = "typeToolStripMenuItem";
            typeToolStripMenuItem.Size = new Size(109, 22);
            typeToolStripMenuItem.Text = "Type";
            // 
            // lightToolStripMenuItem
            // 
            lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            lightToolStripMenuItem.Size = new Size(107, 22);
            lightToolStripMenuItem.Text = "Light";
            lightToolStripMenuItem.Click += lightToolStripMenuItem_Click;
            // 
            // darkToolStripMenuItem
            // 
            darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            darkToolStripMenuItem.Size = new Size(107, 22);
            darkToolStripMenuItem.Text = "Dark";
            darkToolStripMenuItem.Click += darkToolStripMenuItem_Click;
            // 
            // createToolStripMenuItem
            // 
            createToolStripMenuItem.Name = "createToolStripMenuItem";
            createToolStripMenuItem.Size = new Size(62, 21);
            createToolStripMenuItem.Text = "Create";
            createToolStripMenuItem.Click += createToolStripMenuItem_Click;
            // 
            // dataFlowLayoutPanel
            // 
            dataFlowLayoutPanel.AutoScroll = true;
            dataFlowLayoutPanel.Location = new Point(6, 92);
            dataFlowLayoutPanel.Name = "dataFlowLayoutPanel";
            dataFlowLayoutPanel.Size = new Size(788, 352);
            dataFlowLayoutPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataFlowLayoutPanel);
            Controls.Add(mainFormMenuStrip);
            MainMenuStrip = mainFormMenuStrip;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
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
        private FlowLayoutPanel dataFlowLayoutPanel;
        private ToolStripMenuItem createToolStripMenuItem;
    }
}