using AuthmatedWorkplace.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AuthmatedWorkplace
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            this.Activated += AfterLoading;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var login = userNameTextBox.Text;
            var password = passwordTextBox.Text;

            var context = new AppDbContext();

            var user = context.Users.FirstOrDefault(u => u.UserName.ToLower() == login.ToLower() && u.Password == password);

            user = new User() { Id = "idididid", UserName = "username" };

            if (user != null)
            {
                Properties.Settings.Default.UserID = user.Id;
                Properties.Settings.Default.Save();

                LoginSucces();
            }

            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AfterLoading(object sender, EventArgs e)
        {
            this.Activated -= AfterLoading;

            if (!string.IsNullOrEmpty(Properties.Settings.Default.UserID))
            {
                LoginSucces();
            }
        }

        private void LoginSucces()
        {

            Hide();
            
            MessageBox.Show(Properties.Settings.Default.UserID, "Успешный вход");

            var main = new MainWindow();
            main.Closed += (s, args) => this.Close();
            main.Show();

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
        }
    }
}
