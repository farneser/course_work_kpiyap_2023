using System.Configuration;
using MaterialSkin;

namespace AuthmatedWorkplace.Data.Models;

[Serializable]
public class ColorData : ApplicationSettingsBase
{
    public ColorData()
    {
    }

    public ColorData(Primary primary, Primary darkPrimary, Primary lightPrimary, Accent accent,
        TextShade textShade)
    {
        Primary = primary;
        DarkPrimary = darkPrimary;
        LightPrimary = lightPrimary;
        Accent = accent;
        TextShade = textShade;
    }

    public Primary Primary { get; set; }
    public Primary DarkPrimary { get; set; }
    public Primary LightPrimary { get; set; }
    public Accent Accent { get; set; }
    public TextShade TextShade { get; set; }

    public override string ToString()
    {
        return $"{Primary} {DarkPrimary} {LightPrimary} {Accent} {TextShade}";
    }
}