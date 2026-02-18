using System.Globalization;

namespace MyDentist.Web.Shared.Components;

public partial class LanguageSwitch
{
    private readonly CultureInfo[] _supportedCultures =
    [
        new CultureInfo("uz-UZ"),
        new CultureInfo("ru-RU"),
        new CultureInfo("en-US")
    ];

    private static string GetDisplayName(CultureInfo culture)
    {
        return culture.Name switch
        {
            "uz-UZ" => "O'zbek",
            "ru-RU" => "Русский",
            "en-US" => "English",
            _ => culture.NativeName
        };
    }
}
