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
       Item_ShowOnly_Name temp = new();
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
                    value.Name = textBox_for_name.Text;
                }
                catch (ZeroLenghtException ex)
                {
                    MessageBox.Show($"{ex.Message}");
                    return;
                }

                try
                {
                    value.Capacity = Convert.ToInt32(textBox_for_capacity.Text);
                }

                catch (InvalidCastException ex)
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
                value.Type_of_materials = Convert.ToString(comboBox1.SelectedItem);
                list_of_value.Add(value);
                listBox1.Items.Add($"Name:{value.Name}  Price:{value.price_of_Materials()}  Type:{value.Type_of_materials}");
              //  MessageBox.Show($"Added!\n{value.Print_Info()}");
                MessageBox.Show($"Added!\n{temp.Print(value)}");

            textBox_for_name.Clear();
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_for_sort_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            list_of_value.Sort(new Compare_Materials());
            foreach(Materials value in list_of_value)
            {
                listBox1.Items.Add($"Name:{value.Name}  Price:{value.price_of_Materials()}  Type:{value.Type_of_materials}");
            }
        }
    }
}

