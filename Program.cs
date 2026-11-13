using AgenciaTours.Interfaz;

namespace AgenciaTours;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new AgenciaTours.Interfaz.FrmBienvenida());
    }
}
