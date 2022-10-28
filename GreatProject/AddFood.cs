using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GreatProject;

public partial class AddFood : Form
{
    private List<Food> _listOfValue = new();


    public AddFood()
    {
        InitializeComponent();
        dateTimePicker1.Format = DateTimePickerFormat.Short;
    }

    private void label1_Click(object sender, EventArgs e)
    {
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {
    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {
        //if (textBox3.Text.Length != 0)
        //{
        //    value.Expiration_date = textBox3.Text;
        //}
    }

    private void Add_ToList_Click(object sender, EventArgs e)
    {
        Food value = new();
        try
        {
            if (!Date.Name.Contains(textBox1.Text))
            {
                value.Name = textBox1.Text;
            }
            else
            {
                MessageBox.Show($"{textBox1.Text} вже наявне");
                return;
            }
        }
        catch (ZeroLenghtException ex)
        {
            MessageBox.Show($"Помилка виникла в об'єкті під назвою:{ex.Value}\n{ex.Message}");
            return;
        }

        try
        {
            value.ExpirationDate = dateTimePicker1.Value;
        }
        catch (ExpirationDateException ex)
        {
            MessageBox.Show($"Помилка виникла в об'єкті під назвою:{ex.TempForException.Name}\n{ex.Message}");
            return;
        }

        InformAboutAdd to_food = delegate(object example)
        {
            var list_of = example as List<Food>;
            return
                $"Name: {list_of.Last().Name}\nExpirationDate: {list_of.Last().ExpirationDate}\nCount: {list_of.Count()}";
        };

        _listOfValue.Add(value);
        listBox1.Items.Add(
            $"Name:{value.Name}  Price:{value.price_of_item()}  Expiration Date:{value.ExpirationDate}");
        if (to_food is not null) MessageBox.Show(to_food(_listOfValue));
        dateTimePicker1.Value = DateTime.Now;
        // value.        
        textBox1.Clear();
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void dispalay_to_list_box()
    {
        if (listBox1.Items.Count != 0) listBox1.Items.Clear();
        foreach (var value in _listOfValue)
            if (value is not null)
                listBox1.Items.Add(
                    $"Name:{value.Name}  Price:{value.price_of_item()}  Expiration Date:{value.ExpirationDate}");
    }

    private void write_in_main_list_click(object sender, EventArgs e)
    {
        foreach (var temp in _listOfValue)
            if (!Date.Name.Contains(temp.Name) && !Date.SortedListExample.ContainsKey(temp.price_of_item()))
            {
                Date.Name.Add(temp.Name);
                Date.SortedListExample.Add(temp.price_of_item(), temp.Name);
                Date.PropertyForDictionary.Add(temp.Name, DateTime.Now);
                Date.PropertyForWarehouse.list_of_food.Add(temp);
            }
    }

    private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
    {
        //dateTimePicker1.Format = DateTimePickerFormat.Short;
        //DateTime? selectedDate = dateTimePicker1.Value;
    }

    private void button_for_sort_Click(object sender, EventArgs e)
    {
        if (_listOfValue.Count <= 1)
        {
            MessageBox.Show("У списку мало об'єктів для сортування");
            return;
        }

        listBox1.Items.Clear();
        _listOfValue.Sort(new CompareFood());
        dispalay_to_list_box();
    }

    private void button4_Click(object sender, EventArgs e)
    {
        BinFile<Food> temp = new();
        var path = "food.dat";
        if (temp.ReadFile(path) is not null)
        {
            _listOfValue = temp.ReadFile(path);
            if (_listOfValue.Count == 0) MessageBox.Show("Щось пішло не так");
            dispalay_to_list_box();
            (sender as Button).Enabled = false;
            return;
        }

        InformAboutAdd file_read = path => { return $"У файлі - {path} пусто"; };
        MessageBox.Show(file_read(path));
        //Read_from_file temp = new();
        //temp.ReadFile();
        //foreach (Food value in Date.Property_for_warehouse.list_of_food)
        //{
        //    listBox1.Items.Add($"FILE Name:{value.Name}  Price:{value.price_of_item()} Expiration Date:{value.Expiration_date}");
        //}
    }

    private void button5_Click(object sender, EventArgs e)
    {
        if (_listOfValue.Count != 0)
        {
            _listOfValue.RemoveAt(_listOfValue.Count - 1);
            dispalay_to_list_box();
            return;
        }

        MessageBox.Show("У списку 0 об'єктів");
    }

    private void button6_Click(object sender, EventArgs e)
    {
        var testList = new List<Food>
        {
            new("Apple", Convert.ToDateTime("1/01/2023")),
            new("pear", Convert.ToDateTime("5/01/2023")),
            new("watermelon", Convert.ToDateTime("1/3/2027")),
            new("Strawberry", Convert.ToDateTime("5/12/2024")),
            new("butter", Convert.ToDateTime("1/7/2025"))
        };
        _listOfValue = testList;
        dispalay_to_list_box();
        ((Button)sender).Enabled = false;
    }
}