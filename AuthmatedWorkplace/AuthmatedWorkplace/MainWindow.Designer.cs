namespace AuthmatedWorkplace
{
    partial class MainWindow
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
            components = new System.ComponentModel.Container();
            entityDataGridView = new DataGridView();
            entityBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)entityDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)entityBindingSource).BeginInit();
            SuspendLayout();
            // 
            // entityDataGridView
            // 
            entityDataGridView.AutoGenerateColumns = false;
            entityDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            entityDataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, numDataGridViewTextBoxColumn });
            entityDataGridView.DataSource = entityBindingSource;
            entityDataGridView.Dock = DockStyle.Fill;
            entityDataGridView.Location = new Point(0, 0);
            entityDataGridView.Name = "entityDataGridView";
            entityDataGridView.RowTemplate.Height = 25;
            entityDataGridView.Size = new Size(800, 450);
            entityDataGridView.TabIndex = 0;
            // 
            // entityBindingSource
            // 
            entityBindingSource.DataSource = typeof(Data.Models.Entity);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // numDataGridViewTextBoxColumn
            // 
            numDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            numDataGridViewTextBoxColumn.DataPropertyName = "Num";
            numDataGridViewTextBoxColumn.HeaderText = "Num";
            numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(entityDataGridView);
            Name = "MainWindow";
            Text = "Entities";
            FormClosing += MainWindow_FormClosing;
            Load += MainWindow_Load;
            ((System.ComponentModel.ISupportInitialize)entityDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)entityBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView entityDataGridView;
        private BindingSource entityBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
    }
}