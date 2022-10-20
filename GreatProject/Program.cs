using System;
using System.Windows.Forms;

namespace GreatProject;

internal static class Program

{
    /// <summary>
    ///     Главная точка входа для приложения.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        OurWarehouse Big_Dream = new();
        Application.Run(Big_Dream);
        //warehouse BigDream = new warehouse("Big Dream", 100);
    }
}