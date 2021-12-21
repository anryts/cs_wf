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
     partial class Form_For_Registation: Form
    {
        TransferChief example = new TransferChief();
        public Form_For_Registation()
        {
            InitializeComponent();
            KeyPreview = true;
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.Enter) button1.PerformClick(); };
            example.example_event += transfer_event;
        }


        void transfer_event(object s, ChiefTransferEventArgs e)
        {
            MessageBox.Show($"Welcome to the club buddy {e.GiveChief.Name_of_person}");
            Date.chief_of_warehouse.Name_of_person = e.GiveChief.Name_of_person;
            Date.chief_of_warehouse.PaswordProperty = e.GiveChief.PaswordProperty;
            this.Close();
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
            try
            {
                value.Name_of_person = textBox1.Text;
                value.PaswordProperty = textBox2.Text;
               
            }
            catch(ZeroLenghtException ex)
            {
                MessageBox.Show($"Помилка виникла в об'єкті під назвою:{ex.Value.Name}\n{ex.Message}");
                return;
            }
            if (value.Name_of_person.Length!=0 && value.PaswordProperty.Length!=0)
            {
                example.SimulateTransfer(value);
            }
        }
    }
}
