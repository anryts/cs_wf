﻿using System;
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
            warehouse Bob = new warehouse("Apteka",5,6);
           // Bob.Print();
            Person Adam = new Person();
            Person Chief = new Chief();
            Chief.Print();
            Item Value1 = new Food("Pizza", 10);
            Item Value2 = new Electronics();
            Item Value3 = new Materials();
            Value2.Print();
            Value2.Print();
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
