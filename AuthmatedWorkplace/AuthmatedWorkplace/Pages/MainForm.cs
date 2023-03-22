using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuthmatedWorkplace.Pages
{
    public partial class MainForm : BaseForm
    {
        public MainForm(AppDbContext context) : base(context)
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserID = null;
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
            ThemeManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green200, TextShade.WHITE);
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemeManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.Blue200, TextShade.WHITE);
        }

        private void orangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemeManager.ColorScheme = new ColorScheme(Primary.Orange800, Primary.Orange900, Primary.Orange500, Accent.Orange200, TextShade.WHITE);
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
        }
    }
}
