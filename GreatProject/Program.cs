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
            warehouse Bob = new warehouse("Apteka", 5, 6);
            Food bob = new Food("pizza", 13,"09/10/2021");
            if(bob.Fresh_or_not())
            {
                Console.WriteLine("Yes you are right!");
            }
           // Bob.Print();
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
