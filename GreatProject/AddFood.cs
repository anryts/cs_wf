﻿using System;
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
    public partial class AddFood : Form
    {
        Food value = new Food();
        List<Food> list_of_value = new List<Food>(); 
        public AddFood()
        {
            InitializeComponent();
                   
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
            if (textBox1.Text.Length != 0)
            {
                value.Name = textBox1.Text;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length != 0)
            {
                value.Expiration_date = textBox3.Text;
            }
        }

        private void Add_ToList_Click(object sender, EventArgs e)
        {
            if (value.Name.Length != 0 && value.Expiration_date.Length != 0)
            {
                list_of_value.Add(value);
                MessageBox.Show("Added!");
               
            }
           // value.
            textBox3.Clear();
            textBox1.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Food iterator in list_of_value)
            {
                iterator.Print_Info();
            }
        }
    }
}
