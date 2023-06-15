using AuthmatedWorkplace.Data.Models;
using MaterialSkin.Controls;

namespace AuthmatedWorkplace.Data.Forms
{
    public class EntityPanel : Panel
    {
        public EntityPanel(Entity entity)
        {

            this.Width = 500;
            this.Height = 100;

            var nameLabel = new MaterialLabel()
            {
                Text = entity.Name,
                Size = new Size(100, 20),
                Location = new Point(0, 50)
            };

            var descriptionLabel = new MaterialLabel()
            {
                Text = entity.Description,
                Size = new Size(100, 20),
                Location = new Point(100, 50)
            };

            var numLabel = new MaterialLabel()
            {
                Text = entity.Num.ToString(),
                Size = new Size(100, 20),
                Location = new Point(200, 50)
            };

            var typeLabel = new MaterialLabel()
            {
                Text = entity.Type ? Constants.TypeOne : Constants.TypeTwo,
                Size = new Size(100, 20),
                Location = new Point(300, 50)
            };

            var dateLabel = new MaterialLabel()
            {
                Text = entity.Date.ToString(),
                Size = new Size(100, 20),
                Location = new Point(400, 50)
            };

            this.Controls.Add(nameLabel);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(numLabel);
            this.Controls.Add(typeLabel);
            this.Controls.Add(dateLabel);
        }
    }
}
