using AuthmatedWorkplace.Data.Models;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthmatedWorkplace.Data.Forms
{
    public class EntityPanel : Panel
    {
        public EntityPanel(Entity entity)
        {

            this.Width = 750;
            this.Height = 100;

            var nameLabel = new MaterialLabel() { Text = entity.Name };
            var descriptionLabel = new MaterialLabel() { Text = entity.Description };
            var numLabel = new MaterialLabel() { Text = entity.Num.ToString() };
            var typeLabel = new MaterialLabel() { Text = entity.Type.ToString() };
            var dateLabel = new MaterialLabel() { Text = entity.Date.ToString() };






            this.Controls.Add(nameLabel);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(numLabel);
            this.Controls.Add(typeLabel);
            this.Controls.Add(dateLabel);
        }
    }
}
