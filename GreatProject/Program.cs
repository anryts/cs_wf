using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GreatProject
{
    static class Program
        
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            OurWarehouse Big_Dream = new();
            Application.Run(Big_Dream);
            //warehouse BigDream = new warehouse("Big Dream", 100);
           
           
        }
    }
}
