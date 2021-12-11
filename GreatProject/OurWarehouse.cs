using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreatProject
{
   

    public partial class OurWarehouse : Form
    {        
      //static  warehouse_for_food mini_dream_food = new warehouse_for_food();       
        string type_item;
        public OurWarehouse()
        {
            InitializeComponent();
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            KeyPreview = true;
            Date.Event_Handler = new(copying_to_Chief);
            KeyDown += (s,e) => { if (e.KeyValue == (char)Keys.Enter) button2.PerformClick(); };
            this.Load += LoadEvent;
        }
      

        private void LoadEvent(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world");
            Form_For_Registation temp = new();
            temp.ShowDialog();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        public void go_to_exit_form_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        

         void button2_Click(object sender, EventArgs e)
        {
            
            if (type_item == "Food" )
            {
               
                AddFood temp = new AddFood();
                temp.Show();
            }
            else if(type_item == "Materials")
            {
                AddMaterials temp = new AddMaterials();
                temp.Show();
            }
            else
            {
                ForUpdates temp = new ForUpdates();
                temp.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            type_item = comboBox1.SelectedItem.ToString();           

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {         
            // The password character is an asterisk.
            textBox1.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            textBox1.MaxLength = 14;
        }

        private void button_for_Chief_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == Date.chief_of_warehouse.PaswordProperty)
            {
                MessageBox.Show("Welcome!");
                ChiefForm temp = new();
                temp.Show();
            }
        }

       //private void button2_KeyDown(object sender, KeyEventArgs e)
       // {
       //     if(e.KeyValue == (char)Keys.Enter)
       //     {
       //         button2.PerformClick();
               
       //     }
       // }

        void copying_to_Chief(Chief some_other)
        {
            Date.chief_of_warehouse.Name_of_person = some_other.Name_of_person;
            Date.chief_of_warehouse.PaswordProperty = some_other.PaswordProperty;
        }

    }

    [Serializable]
    static class Date
    {
        static warehouse_for_food mini_dream_warehouse = new();
        public  static Chief chief_of_warehouse = new Chief();
        static warehouse_for_materials mini_dream_warehouse_materials = new();

        public delegate void delegate_for_transef(Chief noob);
        public  static delegate_for_transef Event_Handler; 
        static public warehouse_for_materials Property_for_warehouse_materials { get { return mini_dream_warehouse_materials; } }

        static public warehouse_for_food Property_for_warehouse { get { return mini_dream_warehouse; } }

        static public Dictionary<string, DateTime> Property_for_dictionary
        {
            get { return dictionary_for_logs; }
        }
        static Dictionary<string, DateTime> dictionary_for_logs = new();
    }
}
