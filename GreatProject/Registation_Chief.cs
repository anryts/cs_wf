using System;
using System.Windows.Forms;

namespace GreatProject;

internal partial class Form_For_Registation : Form
{
    private readonly TransferChief example = new();

    public Form_For_Registation()
    {
        InitializeComponent();
        KeyPreview = true;
        KeyDown += (s, e) =>
        {
            if (e.KeyValue == (char)Keys.Enter) button1.PerformClick();
        };
        example.ExampleEvent += transfer_event;
    }


    private void transfer_event(object s, ChiefTransferEventArgs e)
    {
        MessageBox.Show($"Welcome to the club buddy {e.GiveChief.NameOfPerson}");
        Date.ChiefOfWarehouse.NameOfPerson = e.GiveChief.NameOfPerson;
        Date.ChiefOfWarehouse.PasswordProperty = e.GiveChief.PasswordProperty;
        Close();
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
        var value = new Chief();
        try
        {
            value.NameOfPerson = textBox1.Text;
            value.PasswordProperty = textBox2.Text;
        }
        catch (ZeroLenghtException ex)
        {
            MessageBox.Show($"Помилка виникла в об'єкті під назвою:{ex.Value}\n{ex.Message}");
            return;
        }

        if (value.NameOfPerson.Length != 0 && value.PasswordProperty.Length != 0) example.SimulateTransfer(value);
    }
}