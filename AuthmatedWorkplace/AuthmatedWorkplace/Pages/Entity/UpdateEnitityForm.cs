using AuthmatedWorkplace.Data.Models;
using MaterialSkin.Controls;

namespace AuthmatedWorkplace.Pages
{
    public partial class UpdateEnitityForm : BaseForm
    {
        private Entity _entity;

        public UpdateEnitityForm(AppDbContext context, Entity entity) : base(context)
        {
            InitializeComponent();
            _entity = entity;
        }

        private void numTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            var entity = _appDbContext.Entities.FirstOrDefault(x => x.Id == _entity.Id);

            if (entity == null)
            {
                Close();
                MaterialMessageBox.Show($"Запись с номером \"{_entity.Id}\" не найдена", "ВНИМАНИЕ!!! ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            entity.Name = nameTextBox.Text;
            entity.Description = descriptionTextBox.Text;
            entity.Type = typeRadioButton1.Checked;
            entity.Num = Convert.ToInt32(numTextBox.Text);
            entity.Date = dateTimePicker.Value;

            _appDbContext.SaveChanges();
            MaterialMessageBox.Show($"Запись с номером \"{_entity.Id}\" успешно обновлена", "Запись успешно обновлена", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void UpdateEntityForm_Load(object sender, EventArgs e)
        {
            nameTextBox.Text = _entity.Name;
            descriptionTextBox.Text = _entity.Description;
            numTextBox.Text = _entity.Num.ToString();
            dateTimePicker.Value = _entity.Date;
            typeRadioButton2.Checked = !_entity.Type;
        }
    }
}
