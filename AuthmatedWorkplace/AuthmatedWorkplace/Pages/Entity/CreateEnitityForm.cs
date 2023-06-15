using AuthmatedWorkplace.Data;

namespace AuthmatedWorkplace.Pages
{
    public partial class CreateEnitityForm : BaseForm
    {
        public CreateEnitityForm(AppDbContext context) : base(context)
        {
            InitializeComponent();
            Text = $"Create {Constants.EntityName} form";
        }

        private void numTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            _appDbContext.Entities.Add(new Data.Models.Entity()
            {
                Name = nameTextBox.Text,
                Description = descriptionTextBox.Text,
                Type = typeRadioButton1.Checked,
                Num = Convert.ToInt32(numTextBox.Text),
                Date = dateTimePicker.Value,
                UserId = Properties.Settings.Default.UserID
            });

            _appDbContext.SaveChanges();
            Close();
        }
    }
}
