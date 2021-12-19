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
                if (!Date.name.Contains(textBox1.Text))
                {
                    value.Name = textBox1.Text;                  
                }
                else { MessageBox.Show($"{textBox1.Text} вже наявне"); return; }
                
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
            inform_about_add to_food = delegate (object example)
            {
                List<Food> list_of = example as List<Food>;
                return $"Name: {list_of.Last().Name}\nExpirationDate: {list_of.Last().Expiration_date}\nCount: {list_of.Count()}";
            };

            list_of_value.Add(value);
            listBox1.Items.Add($"Name:{value.Name}  Price:{value.price_of_item()}  Expiration Date:{value.Expiration_date}");
            if (to_food is not null)
            {
                MessageBox.Show(to_food(list_of_value));
            }
            dateTimePicker1.Value = DateTime.Now;
            // value.        
            textBox1.Clear();
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        void dispalay_to_list_box()
        {
            if (listBox1.Items.Count != 0 )
            {
                listBox1.Items.Clear();

                foreach (var value in list_of_value)
                {
                    if (value is not null)
                    {
                        listBox1.Items.Add($"Name:{value.Name}  Price:{value.price_of_item()}  Expiration Date:{value.Expiration_date}");
                    }
                }
            }
        }

        private void write_in_main_list_click(object sender, EventArgs e)
        {                    
            foreach (Food temp in list_of_value)
            {
                if (!Date.name.Contains(temp.Name))
                {
                    Date.name.Add(temp.Name);
                    Date.Property_for_dictionary.Add(temp.Name, DateTime.Now);
                    Date.Property_for_warehouse.list_of_food.Add(temp);
                }
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
            this.dispalay_to_list_box();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BIN_file<Food> temp = new();
            string path = "food.dat";
            if (temp.ReadFile(path) is not null)
            {
                foreach (Food tem in temp.ReadFile("food.dat"))
                {
                    list_of_value.Add(tem);
                }
                this.dispalay_to_list_box();
                (sender as Button).Enabled = false;
            }
            inform_about_add file_read = (path) => { return ($"У файлі - {path} пусто"); };
            MessageBox.Show(file_read(path));
            //Read_from_file temp = new();
            //temp.ReadFile();
            //foreach (Food value in Date.Property_for_warehouse.list_of_food)
            //{
            //    listBox1.Items.Add($"FILE Name:{value.Name}  Price:{value.price_of_item()} Expiration Date:{value.Expiration_date}");
            //}
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (list_of_value.Count !=0)
            {
                list_of_value[list_of_value.Count - 1] = null;
            }
            this.dispalay_to_list_box();

        }
    }
}
