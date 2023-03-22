using AuthmatedWorkplace.Data.Models;
using AuthmatedWorkplace.Pages;
using MaterialSkin.Controls;

namespace AuthmatedWorkplace
{
    public partial class Login : BaseForm
    {
        public Login() : base(new AppDbContext())
        {
            InitializeComponent();

            Activated += AfterLoading;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var login = userNameTextBox.Text;
            var password = passwordTextBox.Text;

            var user = _appDbContext.Users.FirstOrDefault(u => u.UserName.ToLower() == login.ToLower() && u.Password == password);

            if (user != null)
            {
                Properties.Settings.Default.UserID = user.Id;
                Properties.Settings.Default.Save();

                LoginSucces();
            }
            else
            {
                MaterialMessageBox.Show("Неверный логин или пароль", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            var res = MaterialMessageBox.Show("Вы успешно вошли в аккаунт", "Успешный вход", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (res == DialogResult.OK)
            {
                var main = new MainForm(_appDbContext);
                main.Closed += (s, args) => this.Close();
                main.Show();
            }
            else
            {
                Properties.Settings.Default.UserID = null;
                Properties.Settings.Default.Save();
                Show();
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            var register = new Register(_appDbContext);

            register.ShowDialog();
        }
    }
}
