using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GreatProject;

public partial class ChiefForm : Form
{
    public ChiefForm()
    {
        InitializeComponent();
        var t = new ToolTip();

        Date.chief_of_warehouse.Add_to_Queue(Date.Property_for_warehouse.list_of_food);
        Date.chief_of_warehouse.Add_to_Stack(Date.Property_for_warehouse_materials.list_of_materials);

        while (Date.chief_of_warehouse.PropertyQueueFood.Count != 0)
            listBox1.Items.Add(Date.chief_of_warehouse.PropertyQueueFood.Dequeue().Print_Info());
        while (Date.chief_of_warehouse.PropertyStackMaterials.Count != 0)
            listBox2.Items.Add(Date.chief_of_warehouse.PropertyStackMaterials.Pop().Print_Info());

        progressBar1.MouseEnter += (s, a) =>
        {
            t.SetToolTip(progressBar1, $"Capacity:{progressBar1.Value}/{progressBar1.Maximum}");
        };

        progressBar2.MouseEnter += (s, a) =>
        {
            t.SetToolTip(progressBar2, $"Capacity:{progressBar2.Value}/{progressBar2.Maximum}");
        };
        //progressBar2.MouseLeave += (s, a) => { foreach (Process val in Process.GetProcessesByName("notepad")) val.Kill(); };
        Load += LoadEvent;
    }

    private void LoadEvent(object sender, EventArgs e)
    {
        progressBar2.Maximum = Date.Property_for_warehouse_materials.PropertyForMaxCout;
        progressBar2.Value = Date.Property_for_warehouse_materials.PropertyForCurrentNumber;
        progressBar1.Maximum = 5;
        progressBar1.Value = Date.Property_for_warehouse.list_of_food.Count();
    }

    private void list_box_for_food_warehouse(object sender, EventArgs e)
    {
    }

    private void button_write_in_file_Click(object sender, EventArgs e)
    {
        BinFile<Food> temp = new();
        BinFile<Materials> temp1 = new();
        var check = true;
        if (Date.Property_for_warehouse_materials.list_of_materials.Count == 0 ||
            Date.Property_for_warehouse.list_of_food.Count == 0)
            check = false;
        temp1.WriteFile(Date.Property_for_warehouse_materials.list_of_materials, "materials.dat");

        temp.WriteFile(Date.Property_for_warehouse.list_of_food, "food.dat");
        if (check)
        {
            MessageBox.Show("Записано у два файли\n");
            return;
        }

        MessageBox.Show("Один з складів, пустий");
        (sender as Button).Enabled = false;
    }

    private void button_for_logs_writing(object sender, EventArgs e)
    {
        var writePath = @"C:\C#_dir\logs.txt";
        foreach (var temp in Date.Property_for_dictionary)
            using (var sw = new StreamWriter(writePath, true, Encoding.Default))
            {
                sw.WriteLine(temp.ToString());
            }

        MessageBox.Show("Записано");
        (sender as Button).Enabled = false;
    }

    private void button_Home_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void progressBar1_Click(object sender, EventArgs e)
    {
    }

    private void progressBar2_Click(object sender, EventArgs e)
    {
    }

    private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void button_for_search_Click(object sender, EventArgs e)
    {
        if (Date.name.Contains(textBox1.Text))
            MessageBox.Show(
                $"Об'єкт {textBox1.Text} знаходиться на складі\nБув доданий о: {Convert.ToString(Date.Property_for_dictionary[textBox1.Text])}");
        else
            MessageBox.Show("Такого об'єкта нема :(");
    }

    private void button4_Click(object sender, EventArgs e)
    {
        if (textBox2.Text.Length == 0) return;
        if (Date.sorted_list_example.ContainsKey(Convert.ToInt32(textBox2.Text)))
            MessageBox.Show($"Об'єкт {Date.sorted_list_example[Convert.ToInt32(textBox1.Text)]} знаходиться на складі");
        else
            MessageBox.Show("Такого об'єкта нема :(");
    }
}