using AuthmatedWorkplace.Data.Models;
using AuthmatedWorkplace.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace AuthmatedWorkplace
{
    public partial class Register : BaseForm
    {
        public Register(AppDbContext context) : base(context)
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (!(passwordTextBox.Text == passwordConfirmTextBox.Text))
            {
                MessageBox.Show("Пароли должны совпадать", "Пароли не совпадают", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var user = new User()
            {
                Email = emailTextBox.Text,
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                UserName = userNameTextBox.Text,
                Password = passwordTextBox.Text,
                Id = Guid.NewGuid().ToString(),
            };

            var context = new AppDbContext();

            context.Users.Add(user);

            context.SaveChanges();

            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
