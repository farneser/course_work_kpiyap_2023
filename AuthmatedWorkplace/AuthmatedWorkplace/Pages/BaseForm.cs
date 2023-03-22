using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthmatedWorkplace.Pages
{
    public class BaseForm : MaterialForm
    {
        protected AppDbContext? _appDbContext;

        protected MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;

        public BaseForm()
        {
            ThemeManager.AddFormToManage(this);
            ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
            ThemeManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        public BaseForm(AppDbContext context) : base()
        {
            _appDbContext = context;
        }
    }
}
