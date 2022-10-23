using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GreatProject;

public partial class AddMaterials : Form
{
    private List<Materials> list_of_value = new();


    private readonly InformAboutAdd to_materials = delegate(object example)
    {
        var list_of = example as List<Materials>;
        return $"Name:{list_of.Last().Name}\nCount:{list_of.Count()}";
    };

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
        Close();
    }

    private void button_for_add_Click(object sender, EventArgs e)
    {
        Materials value = new();
        try
        {
            if (!Date.Name.Contains(textBox_for_name.Text))
            {
                value.Name = textBox_for_name.Text;
            }
            else
            {
                MessageBox.Show($"{textBox_for_name.Text} вже наявне");
                return;
            }
        }
        catch (ZeroLenghtException ex)
        {
            MessageBox.Show($"Помилка виникла в об'єкті під назвою:{ex.Value.Name}\n{ex.Message}");
            return;
        }

        try
        {
            value.Capacity = Convert.ToInt32(textBox_for_capacity.Text);
        }

        catch (FormatException ex)
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

        list_of_value.Add(value);
        print_to_list_box();
        if (to_materials is not null) MessageBox.Show(to_materials(list_of_value));
        textBox_for_name.Clear();
        textBox_for_capacity.Clear();
        textBox_for_weight.Clear();
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void print_to_list_box()
    {
        if (listBox1.Items.Count != 0) listBox1.Items.Clear();
        foreach (var value in list_of_value)
            listBox1.Items.Add($"Name:{value.Name}  Price:{value.price_of_Materials()} ");
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void button_for_sort_Click(object sender, EventArgs e)
    {
        listBox1.Items.Clear();
        list_of_value.Sort(new CompareMaterials());

        print_to_list_box();
    }

    private void button_for_materials(object sender, EventArgs e)
    {
        //Date.Property_for_warehouse_materials.out_of_max_count += out_of_max_count;
        foreach (var temp in list_of_value)
            if (!Date.Name.Contains(temp.Name))
            {
                Date.Name.Add(temp.Name);
                Date.SortedListExample.Add(temp.price_of_item(), temp.Name);
                Date.PropertyForDictionary.Add(temp.Name, DateTime.Now);
                Date.PropertyForWarehouseMaterials.list_of_materials.Add(temp);
            }
    }

    private void button4_Click(object sender, EventArgs e)
    {
        if (list_of_value.Count != 0)
        {
            list_of_value.RemoveAt(list_of_value.Count - 1);
            print_to_list_box();
            return;
        }

        MessageBox.Show("У списку 0 об'єктів");
    }

    private void button5_Click(object sender, EventArgs e)
    {
        BinFile<Materials> temp = new();

        var path = "materials.dat";
        if (temp.ReadFile(path) is not null)
        {
            foreach (var tem in temp.ReadFile("materials.dat"))
                if (tem is not null)
                    list_of_value.Add(tem);
            print_to_list_box();
            (sender as Button).Enabled = false;
        }

        InformAboutAdd file_read = path => { return $"У файлі - {path} пусто"; };
        MessageBox.Show(file_read(path));
    }

    private void AddMaterials_Load(object sender, EventArgs e)
    {
    }

    private void button6_Click(object sender, EventArgs e)
    {
        var test_list = new List<Materials>
        {
            new("stone", 100, 2),
            new("brick", 300, 10),
            new("cement", 50, 1),
            new("clay", 600, 42),
            new("wood", 12, 8)
        };
        list_of_value = test_list;
        print_to_list_box();
        (sender as Button).Enabled = false;
    }
}