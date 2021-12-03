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


    public partial class Form_For_Registation: Form
    {
        public Form_For_Registation()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox_for_name_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 10;

        }

        private void textBox_for_pasword_TextChanged(object sender, EventArgs e)
        {
            textBox2.MaxLength = 14;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Chief value = new Chief();
            value.Name_of_person = textBox1.Text;
            Date.Event_Handler(value);
        }
    }
}
