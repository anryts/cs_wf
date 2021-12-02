using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using GreatProject.Properties;
namespace GreatProject
{
    
    public partial class AddFood : Form
    {
             
        List<Food> list_of_value = new List<Food>();
       
        public AddFood()
        {
          
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Short;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //if (textBox3.Text.Length != 0)
            //{
            //    value.Expiration_date = textBox3.Text;
            //}
        }

        private void Add_ToList_Click(object sender, EventArgs e)
        {  

            Food value = new();
                try
                {
                    value.Name = textBox1.Text;
                }
                catch (ZeroLenghtException ex)
                {
                    MessageBox.Show($"Помилка виникла в об'єкті під назвою:{ex.Value.Name}\n{ex.Message}");
                    return;
                }
                try
                {
                    value.Expiration_date = dateTimePicker1.Value;
                }
                catch (ExpirationDateException ex)
                {
                    MessageBox.Show($"Помилка виникла в об'єкті під назвою:{ex.Temp_for_exception.Name}\n{ex.Message}");
                    return;
                }
                    list_of_value.Add(value);
                    listBox1.Items.Add($"Name:{value.Name}  Price:{value.price_of_item()}  Expiration Date:{value.Expiration_date}");
                    MessageBox.Show($"Added!\n{value.Print_Info()}");
           
           // value.        
            textBox1.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void write_in_main_list_click(object sender, EventArgs e)
        {
            Date.Property_for_warehouse.Add_to_list_of_food(list_of_value);
            foreach(Food temp in list_of_value)
            {
                Date.Property_for_dictionary.Add(temp.Name, DateTime.Now);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //dateTimePicker1.Format = DateTimePickerFormat.Short;
            //DateTime? selectedDate = dateTimePicker1.Value;
           
        }

        private void button_for_sort_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            list_of_value.Sort(new Compare_Food());
            foreach (Food value in list_of_value)
            {
                listBox1.Items.Add($"Name:{value.Name}  Price:{value.price_of_item()}  Expiration Date:{value.Expiration_date}");
            }
        }
    }
}
