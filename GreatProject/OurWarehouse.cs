using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GreatProject;

public partial class OurWarehouse : Form
{
    //static  warehouse_for_food mini_dream_food = new warehouse_for_food();       
    private string type_item;

    public OurWarehouse()
    {
        InitializeComponent();

        comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        KeyPreview = true;
        Date.Event_Handler = copying_to_Chief;
        KeyDown += (s, e) =>
        {
            if (e.KeyValue == (char)Keys.Enter) button2.PerformClick();
        };
        Load += LoadEvent;
    }


    private void LoadEvent(object sender, EventArgs e)
    {
        Form_For_Registation temp = new();
        temp.ShowDialog();
        WindowState = FormWindowState.Maximized;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    }

    public void go_to_exit_form_Click_1(object sender, EventArgs e)
    {
        Close();
    }


    private void button2_Click(object sender, EventArgs e)
    {
        if (type_item == "Food")
        {
            var temp = new AddFood();
            temp.Show();
        }
        else if (type_item == "Materials")
        {
            var temp = new AddMaterials();
            temp.Show();
        }
        else
        {
            var temp = new ForUpdates();
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
        // The password character is an asterisk.
        textBox1.PasswordChar = '*';
        // The control will allow no more than 14 characters.
        textBox1.MaxLength = 14;
    }

    private void button_for_Chief_Click(object sender, EventArgs e)
    {
        if (textBox1.Text == Date.chief_of_warehouse.PaswordProperty)
        {
            MessageBox.Show("Welcome!");
            ChiefForm temp = new();
            temp.Show();
        }
    }


    //private void button2_KeyDown(object sender, KeyEventArgs e)
    // {
    //     if(e.KeyValue == (char)Keys.Enter)
    //     {
    //         button2.PerformClick();

    //     }
    // }


    private void copying_to_Chief(Chief some_other)
    {
        Date.chief_of_warehouse.NameOfPerson = some_other.NameOfPerson;
        Date.chief_of_warehouse.PaswordProperty = some_other.PaswordProperty;
    }
}

internal static class Date
{
    public delegate void delegate_for_transef(Chief noob);

    public static HashSet<string> name = new();

    public static SortedList<int, string> sorted_list_example = new();


    public static Chief chief_of_warehouse = new();
    public static delegate_for_transef Event_Handler;


    public static Dictionary<string, DateTime> Property_for_dictionary { get; } = new();

    public static warehouse_for_materials Property_for_warehouse_materials { get; } = new();

    public static WarehouseForFood Property_for_warehouse { get; } = new();
}