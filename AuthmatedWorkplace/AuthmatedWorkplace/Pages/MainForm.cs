using MaterialSkin;
using AuthmatedWorkplace.Data.Models;
using AuthmatedWorkplace.Data.Forms;
using MaterialSkin.Controls;
using AuthmatedWorkplace.Data;

namespace AuthmatedWorkplace.Pages
{
    public partial class MainForm : BaseForm
    {
        public MainForm() : base(new AppDbContext())
        {
            InitializeComponent();
        }

        public MainForm(AppDbContext context) : base(context)
        {
            InitializeComponent();
            createToolStripMenuItem.Text = $"Создать {Constants.EntityName}";
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserID = Guid.Empty;
            Properties.Settings.Default.Save();

            Hide();

            var login = new Login();

            login.Closed += (s, args) => this.Close();
            login.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeThemeColor(new ColorData(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green200,
                TextShade.WHITE));
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeThemeColor(new ColorData(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.Blue200,
                TextShade.WHITE));
        }

        private void orangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeThemeColor(new ColorData(Primary.Orange800, Primary.Orange900, Primary.Orange500, Accent.Orange200,
                TextShade.WHITE));
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeThemeType(MaterialSkinManager.Themes.LIGHT);
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeThemeType(MaterialSkinManager.Themes.DARK);
        }

        private void RefreshData()
        {
            dataFlowLayoutPanel.Controls.Clear();

            foreach (var entity in _appDbContext.Entities.Where(e => e.UserId == Properties.Settings.Default.UserID).OrderBy(e => e.Date))
            {
                var panel = new Panel() { Width = 830, Height = 50, Padding = new Padding(0) };

                var updateButton = new MaterialButton() { Text = "✎", Location = new Point(680, 0) };

                updateButton.Click += (s, e) =>
                {
                    var update = new UpdateEnitityForm(_appDbContext, entity);
                    update.ShowDialog();
                    RefreshData();
                };

                var deleteButton = new MaterialButton() { Text = "🗑", Location = new Point(750, 0) };

                deleteButton.Click += (s, e) =>
                {
                    _appDbContext.Entities.Remove(entity);
                    _appDbContext.SaveChanges();
                    RefreshData();
                };

                panel.Controls.Add(new EntityPanel(entity));
                panel.Controls.Add(updateButton);
                panel.Controls.Add(deleteButton);

                dataFlowLayoutPanel.Controls.Add(panel);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void createToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var create = new CreateEnitityForm(_appDbContext);
            create.ShowDialog();
            RefreshData();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}