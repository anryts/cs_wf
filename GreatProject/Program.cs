using System;
using System.Windows.Forms;

namespace GreatProject;

internal static class Program

{
    /// <summary>
    ///     Hello world
    /// </summary>
    [STAThread]
    private static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        OurWarehouse bigDream = new();
        Application.Run(bigDream);
        //warehouse BigDream = new warehouse("Big Dream", 100);
    }
}