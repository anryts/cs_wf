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

namespace GreatProject
{
    public partial class ChiefForm : Form
    {
        public ChiefForm()
        {
            InitializeComponent();
            foreach(Food temp in Date.Property_for_warehouse.list_of_food)
            {
                listBox1.Items.Add(temp.Print_Info());
            }
        }

        private void list_box_for_food_warehouse(object sender, EventArgs e)
        {

        }

        private void button_write_in_file_Click(object sender, EventArgs e)
        {
            Write_in_File_Food temp = new();
            List<IPrintable> list_of_value = new();  
            foreach (Food tem in Date.Property_for_warehouse.list_of_food)
            {
                list_of_value.Add(tem);
            }
            temp.ProcessWithData(list_of_value);

        }

        private void button_for_logs_writing(object sender, EventArgs e)
        {
            string writePath = @"C:\C#_dir\logs.txt";
            foreach (var temp in Date.Property_for_dictionary)
            {
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
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

        }
    }
}
