using MaterialSkin;
using MaterialSkin.Controls;
using AuthmatedWorkplace.Data.Models;

namespace AuthmatedWorkplace.Pages
{
    public class BaseForm : MaterialForm
    {
        protected AppDbContext? _appDbContext;

        private MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;
        public BaseForm() { }
        public BaseForm(AppDbContext context) : base()
        {
            _appDbContext = context;
            ThemeManager.AddFormToManage(this);

            if (Properties.Settings.Default.Initial)
            {
                Properties.Settings.Default.Initial = false;
                Properties.Settings.Default.Save();
                ChangeThemeColor(new ColorData(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500,
                    Accent.LightBlue200, TextShade.WHITE));
            }
            else
            {
                ChangeThemeColor(new ColorData(Properties.Settings.Default.PrimaryColor,
                    Properties.Settings.Default.DarkPrimaryColor, Properties.Settings.Default.LightPrimaryColor,
                    Properties.Settings.Default.AccentColor, Properties.Settings.Default.TextShadeColor));
            }

            ChangeThemeType(Properties.Settings.Default.ThemeType);
        }

        protected void ChangeThemeType(MaterialSkinManager.Themes themes)
        {
            Properties.Settings.Default.ThemeType = themes;
            Properties.Settings.Default.Save();
            ThemeManager.Theme = Properties.Settings.Default.ThemeType;
        }

        protected void ChangeThemeColor(ColorData colorData)
        {
            Properties.Settings.Default.PrimaryColor = colorData.Primary;
            Properties.Settings.Default.DarkPrimaryColor = colorData.DarkPrimary;
            Properties.Settings.Default.LightPrimaryColor = colorData.LightPrimary;
            Properties.Settings.Default.AccentColor = colorData.Accent;
            Properties.Settings.Default.TextShadeColor = colorData.TextShade;
            Properties.Settings.Default.Save();
            var data = Properties.Settings.Default;
            ThemeManager.ColorScheme = new ColorScheme(data.PrimaryColor, data.DarkPrimaryColor, data.LightPrimaryColor,
                data.AccentColor,
                data.TextShadeColor);
        }
    }
}