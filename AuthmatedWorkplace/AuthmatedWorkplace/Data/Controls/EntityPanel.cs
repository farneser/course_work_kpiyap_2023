using AuthmatedWorkplace.Data.Models;
using MaterialSkin.Controls;

namespace AuthmatedWorkplace.Data.Forms
{
    public class EntityPanel : Panel
    {
        public EntityPanel(Entity entity)
        {
            this.Padding = new Padding(0, 0, 0, 0);

            this.Width = 670;
            this.Height = 50;

            var idLabel = new MaterialLabel()
            {
                Text = entity.Id.ToString(),
                Size = new Size(50, 20),
                Location = new Point(0, 15)
            };

            var nameLabel = new MaterialLabel()
            {
                Text = entity.Name,
                Size = new Size(100, 20),
                Location = new Point(50, 15)
            };

            var descriptionLabel = new MaterialLabel()
            {
                Text = entity.Description,
                Size = new Size(200, 20),
                Location = new Point(150, 15)
            };

            var numLabel = new MaterialLabel()
            {
                Text = entity.Num.ToString(),
                Size = new Size(50, 20),
                Location = new Point(350, 15)
            };

            var typeLabel = new MaterialLabel()
            {
                Text = entity.Type ? Constants.TypeOne : Constants.TypeTwo,
                Size = new Size(100, 20),
                Location = new Point(400, 15)
            };

            var dateLabel = new MaterialLabel()
            {
                Text = entity.Date.ToString(),
                Size = new Size(170, 20),
                Location = new Point(500, 15)
            };

            this.Controls.Add(idLabel);
            this.Controls.Add(nameLabel);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(numLabel);
            this.Controls.Add(typeLabel);
            this.Controls.Add(dateLabel);
        }
    }
}
