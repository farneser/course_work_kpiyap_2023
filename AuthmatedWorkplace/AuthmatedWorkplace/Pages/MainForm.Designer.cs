using AuthmatedWorkplace.Data;
using MaterialSkin.Controls;

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
            dataToolStripMenuItem = new ToolStripMenuItem();
            createToolStripMenuItem = new ToolStripMenuItem();
            refreshToolStripMenuItem = new ToolStripMenuItem();
            dataFlowLayoutPanel = new FlowLayoutPanel();
            idLabel = new MaterialLabel();
            nameLabel = new MaterialLabel();
            descriptionLabel = new MaterialLabel();
            numLabel = new MaterialLabel();
            typeLabel = new MaterialLabel();
            dateLabel = new MaterialLabel();
            mainFormMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // mainFormMenuStrip
            // 
            mainFormMenuStrip.BackColor = Color.FromArgb(50, 50, 50);
            mainFormMenuStrip.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            mainFormMenuStrip.ForeColor = Color.FromArgb(222, 255, 255, 255);
            mainFormMenuStrip.Items.AddRange(new ToolStripItem[] { applicationToolStripMenuItem, themeToolStripMenuItem, dataToolStripMenuItem });
            mainFormMenuStrip.Location = new Point(3, 64);
            mainFormMenuStrip.Name = "mainFormMenuStrip";
            mainFormMenuStrip.Size = new Size(864, 25);
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
            // dataToolStripMenuItem
            // 
            dataToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createToolStripMenuItem, refreshToolStripMenuItem });
            dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            dataToolStripMenuItem.Size = new Size(50, 21);
            dataToolStripMenuItem.Text = "Data";
            // 
            // createToolStripMenuItem
            // 
            createToolStripMenuItem.Name = "createToolStripMenuItem";
            createToolStripMenuItem.Size = new Size(126, 22);
            createToolStripMenuItem.Text = "Create";
            createToolStripMenuItem.Click += createToolStripMenuItem_Click_1;
            // 
            // refreshToolStripMenuItem
            // 
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.Size = new Size(126, 22);
            refreshToolStripMenuItem.Text = "Refresh";
            refreshToolStripMenuItem.Click += refreshToolStripMenuItem_Click;
            // 
            // dataFlowLayoutPanel
            // 
            dataFlowLayoutPanel.AutoScroll = true;
            dataFlowLayoutPanel.Location = new Point(5, 120);
            dataFlowLayoutPanel.Margin = new Padding(0);
            dataFlowLayoutPanel.Name = "dataFlowLayoutPanel";
            dataFlowLayoutPanel.Size = new Size(860, 325);
            dataFlowLayoutPanel.TabIndex = 1;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Depth = 0;
            idLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            idLabel.Location = new Point(8, 95);
            idLabel.Margin = new Padding(0);
            idLabel.MouseState = MaterialSkin.MouseState.HOVER;
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(14, 19);
            idLabel.TabIndex = 2;
            idLabel.Text = "Id";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Depth = 0;
            nameLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            nameLabel.Location = new Point(58, 95);
            nameLabel.Margin = new Padding(0);
            nameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(43, 19);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Depth = 0;
            descriptionLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            descriptionLabel.Location = new Point(158, 95);
            descriptionLabel.Margin = new Padding(0);
            descriptionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(81, 19);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = "Description";
            // 
            // numLabel
            // 
            numLabel.AutoSize = true;
            numLabel.Depth = 0;
            numLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            numLabel.Location = new Point(358, 95);
            numLabel.Margin = new Padding(0);
            numLabel.MouseState = MaterialSkin.MouseState.HOVER;
            numLabel.Name = "numLabel";
            numLabel.Size = new Size(35, 19);
            numLabel.TabIndex = 5;
            numLabel.Text = "Num";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Depth = 0;
            typeLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            typeLabel.Location = new Point(408, 95);
            typeLabel.Margin = new Padding(0);
            typeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(36, 19);
            typeLabel.TabIndex = 6;
            typeLabel.Text = "Type";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Depth = 0;
            dateLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dateLabel.Location = new Point(508, 95);
            dateLabel.Margin = new Padding(0);
            dateLabel.MouseState = MaterialSkin.MouseState.HOVER;
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(34, 19);
            dateLabel.TabIndex = 7;
            dateLabel.Text = "Date";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 450);
            Controls.Add(dateLabel);
            Controls.Add(typeLabel);
            Controls.Add(numLabel);
            Controls.Add(descriptionLabel);
            Controls.Add(nameLabel);
            Controls.Add(idLabel);
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
        private ToolStripMenuItem dataToolStripMenuItem;
        private ToolStripMenuItem createToolStripMenuItem;
        private ToolStripMenuItem refreshToolStripMenuItem;
        private MaterialLabel idLabel;
        private MaterialLabel nameLabel;
        private MaterialLabel descriptionLabel;
        private MaterialLabel numLabel;
        private MaterialLabel typeLabel;
        private MaterialLabel dateLabel;
    }
}