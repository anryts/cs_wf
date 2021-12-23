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
    public partial class AddMaterials : Form
    {
        
        List<Materials> list_of_value  = new();


        inform_about_add to_materials = delegate (object example)
        {
            List<Materials> list_of = example as List<Materials>;
            return $"Name:{list_of.Last().Name}\nCount:{list_of.Count()}";
        };

        public AddMaterials()
        {
            InitializeComponent();
        }

        private void textBox_for_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_for_capacity_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_for_weight_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_for_home_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_for_add_Click(object sender, EventArgs e)
        {
            Materials value = new();
            try
            {
                if (!Date.name.Contains(textBox_for_name.Text))
                {
                    value.Name = textBox_for_name.Text;
                }
                else { MessageBox.Show($"{textBox_for_name.Text} вже наявне"); return; }
                }
                catch (ZeroLenghtException ex)
                {
                    MessageBox.Show($"Помилка виникла в об'єкті під назвою:{ex.Value.Name}\n{ex.Message}");
                    return;
                }

                try
                {
                    value.Capacity = Convert.ToInt32(textBox_for_capacity.Text);
                }

                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                catch (ZeroLenghtException ex)
                {
                    MessageBox.Show($"{ex.Message}");
                    return;
                }

                try
                {
                    value.Weight = Convert.ToInt32(textBox_for_weight.Text);
                }

                 catch (InvalidCastException ex)
                {
                 MessageBox.Show(ex.Message);
                  return;
                }
                 catch (Exception ex)
                {
                    MessageBox.Show($"Помилка :{ex.Message}");
                    return;
                }     
                list_of_value.Add(value);
            this.print_to_list_box();
            if (to_materials is not null)
            {
                MessageBox.Show(to_materials(list_of_value));
            }
                textBox_for_name.Clear();
                textBox_for_capacity.Clear();
                textBox_for_weight.Clear();   
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        void print_to_list_box()
        {
            if(listBox1.Items.Count != 0)
            {
                listBox1.Items.Clear();
            }
            foreach (var value in list_of_value)
            {
                listBox1.Items.Add($"Name:{value.Name}  Price:{value.price_of_Materials()} ");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_for_sort_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            list_of_value.Sort(new Compare_Materials());

            this.print_to_list_box();
        }

        private void button_for_materials(object sender, EventArgs e)
        {

            //Date.Property_for_warehouse_materials.out_of_max_count += out_of_max_count;
            foreach (Materials temp in list_of_value)
            {
                if (!Date.name.Contains(temp.Name))
                {
                    Date.name.Add(temp.Name);
                    Date.sorted_list_example.Add(temp.price_of_item(), temp.Name);
                    Date.Property_for_dictionary.Add(temp.Name, DateTime.Now);
                    Date.Property_for_warehouse_materials.list_of_materials.Add(temp);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (list_of_value.Count != 0)
            {
                list_of_value[list_of_value.Count - 1] = null;
            }
            this.print_to_list_box();
        }

        private void button5_Click(object sender, EventArgs e)
        { 
            BIN_file<Materials> temp = new();
           
            string path = "materials.dat";
            if (temp.ReadFile(path) is not null)
            {
                foreach (Materials tem in temp.ReadFile("materials.dat"))
                {
                    if (tem is not null)
                    {
                        list_of_value.Add(tem);
                    }
                }
                this.print_to_list_box();
                (sender as Button).Enabled = false;
            }
            inform_about_add file_read = (path) => { return ($"У файлі - {path} пусто"); };
            MessageBox.Show(file_read(path));
        }

        private void AddMaterials_Load(object sender, EventArgs e)
        {

        }
    }
}

