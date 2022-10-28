using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GreatProject;

public partial class OurWarehouse : Form
{
    private string _typeItem;

    public OurWarehouse()
    {
        InitializeComponent();

        comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        KeyPreview = true;
        Date.EventHandler = copying_to_Chief;
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
        switch (_typeItem)
        {
            case "Food":
            {
                var temp = new AddFood();
                temp.Show();
                break;
            }
            case "Materials":
            {
                var temp = new AddMaterials();
                temp.Show();
                break;
            }
            default:
            {
                var temp = new ForUpdates();
                temp.Show();
                break;
            }
        }
    }

    private void label1_Click(object sender, EventArgs e)
    {
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        _typeItem = comboBox1.SelectedItem.ToString();
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
        if (textBox1.Text == Date.ChiefOfWarehouse.PasswordProperty)
        {
            MessageBox.Show("Welcome!");
            ChiefForm temp = new();
            temp.Show();
        }
    }


    private void copying_to_Chief(Chief someOther)
    {
        Date.ChiefOfWarehouse.NameOfPerson = someOther.NameOfPerson;
        Date.ChiefOfWarehouse.PasswordProperty = someOther.PasswordProperty;
    }
}

internal static class Date
{
    public delegate void DelegateForTransef(Chief noob);

    public static HashSet<string> Name = new();

    public static SortedList<int, string> SortedListExample = new();


    public static Chief ChiefOfWarehouse = new();
    public static DelegateForTransef EventHandler;


    public static Dictionary<string, DateTime> PropertyForDictionary { get; } = new();

    public static WarehouseForMaterials PropertyForWarehouseMaterials { get; } = new();

    public static WarehouseForFood PropertyForWarehouse { get; } = new();
}