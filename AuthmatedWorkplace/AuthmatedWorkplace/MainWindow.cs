using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuthmatedWorkplace
{
    public partial class MainWindow : Form
    {
        private AppDbContext? _context;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this._context = new AppDbContext();

            this._context.Entities.Load();

            this.entityBindingSource.DataSource = _context.Entities.Local.ToBindingList();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dialogResult = MessageBox.Show("Do You Want To Save Your Data", "CodeJuggler", MessageBoxButtons.YesNoCancel);
            if (dialogResult == DialogResult.Yes) this._context?.SaveChanges();
            else if (dialogResult == DialogResult.Cancel) e.Cancel = true;
        }
    }
}
