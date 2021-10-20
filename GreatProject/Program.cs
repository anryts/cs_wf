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
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new OurWarehouse());
            warehouse bob = new warehouse();
            warehouse.warehouse_for_food ada = new warehouse.warehouse_for_food();
            Food c = new Food("pizza",3,"20/12/2002");
            ada.list_of_food.Add(c);
            ada.Print_Info();
        }
    }
}
