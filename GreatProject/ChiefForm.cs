using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;



namespace GreatProject
{
    public partial class ChiefForm : Form
    {
        public ChiefForm()
        {
            InitializeComponent();
            ToolTip t = new ToolTip();

            Date.chief_of_warehouse.Add_to_Queue(Date.Property_for_warehouse.list_of_food);
            Date.chief_of_warehouse.Add_to_Stack(Date.Property_for_warehouse_materials.list_of_materials);

            foreach (Food temp in Date.Property_for_warehouse.list_of_food)
            {
                listBox1.Items.Add(temp.Print_Info());
            }

            foreach (Materials temp in Date.Property_for_warehouse_materials.list_of_materials)
            {
                listBox2.Items.Add(temp.Print_Info());
            }
            progressBar2.MouseEnter += (s, a) => 
            { 
                t.SetToolTip(progressBar2, $"Capacity:{progressBar2.Value}/{progressBar2.Maximum}");   
            };
            //progressBar2.MouseLeave += (s, a) => { foreach (Process val in Process.GetProcessesByName("notepad")) val.Kill(); };
            this.Load += LoadEvent;       
        }

        void LoadEvent(object sender, EventArgs e)
        {
            progressBar2.Maximum = Date.Property_for_warehouse_materials.Property_for_max_cout;
            progressBar2.Value = Date.Property_for_warehouse_materials.Property_for_current_number;
        }

        private void list_box_for_food_warehouse(object sender, EventArgs e)
        {

        }

        private void button_write_in_file_Click(object sender, EventArgs e)
        {
            BIN_file<Food> temp = new();
            temp.WriteFile(Date.Property_for_warehouse.list_of_food, "food.dat");
            //Write_in_File temp = new();
            //List<IPrintable> list_of_value = new();  
            //foreach (Food tem in Date.Property_for_warehouse.list_of_food)
            //{
            //    list_of_value.Add(tem);
            //}
            //foreach (Materials tem in Date.Property_for_warehouse_materials.list_of_materials)
            //{
            //    list_of_value.Add(tem);
            //}
            //temp.ProcessWithData(list_of_value);

        }

        private void button_for_logs_writing(object sender, EventArgs e)
        {
            string writePath = @"C:\C#_dir\logs.txt";
            foreach (var temp in Date.Property_for_dictionary)
            {
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(temp.ToString());
                }

            }
        }

        private void button_Home_Click(object sender, EventArgs e)
        {
            //if(MouseButtons.Left)this.Close();
            this.Close();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            //progressBar1.Maximum = 
            //progressBar1.Value = 
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Convert.ToString(Date.Property_for_dictionary[textBox1.Text]
        }

        private void button_for_search_Click(object sender, EventArgs e)
        {
            if (Date.name.Contains(textBox1.Text))
            {
                MessageBox.Show($"Об'єкт {textBox1.Text} знаходиться на складі\nБув доданий о: {Convert.ToString(Date.Property_for_dictionary[textBox1.Text])}");
            }
            else { MessageBox.Show("Такого об'єкта нема :("); }
        }
    }
}
