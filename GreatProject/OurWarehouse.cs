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
        string type_item;
        public OurWarehouse()
        {
            InitializeComponent();
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void go_to_exit_form_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
                ForUpdates temp = new ForUpdates();
                temp.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            if(type_item == "Food")
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
           
        }

        private void button_for_Chief_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0123456789")
            {
                MessageBox.Show("Welcome!");
            }
        }
    }
}
