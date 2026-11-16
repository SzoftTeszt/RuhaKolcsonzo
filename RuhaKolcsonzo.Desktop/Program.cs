using RuhaKolcsonzo.Data.Data;

namespace RuhaKolcsonzo.Desktop;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        SeedData.Betoltes();
        Application.Run(new MainForm());
    }
}
