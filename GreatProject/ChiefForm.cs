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
    }
}
