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
        public OurWarehouse()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void go_to_second_form_Click_1(object sender, EventArgs e)
        {
            FoodWarehouse temp = new FoodWarehouse();
            temp.Show();
            //this.Close();
        }

        private void List_Items_SelectedIndexChanged_1(object sender, EventArgs e)
        {
          
        }

        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
                FoodWarehouse temp = new FoodWarehouse();
                temp.Show();
            
        }
    }
}
