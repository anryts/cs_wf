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

        Date.ChiefOfWarehouse.Add_to_Queue(Date.PropertyForWarehouse.list_of_food);
        Date.ChiefOfWarehouse.Add_to_Stack(Date.PropertyForWarehouseMaterials.list_of_materials);

        while (Date.ChiefOfWarehouse.PropertyQueueFood.Count != 0)
            listBox1.Items.Add(Date.ChiefOfWarehouse.PropertyQueueFood.Dequeue().Print_Info());
        while (Date.ChiefOfWarehouse.PropertyStackMaterials.Count != 0)
            listBox2.Items.Add(Date.ChiefOfWarehouse.PropertyStackMaterials.Pop().Print_Info());

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
        progressBar2.Maximum = Date.PropertyForWarehouseMaterials.PropertyForMaxCout;
        progressBar2.Value = Date.PropertyForWarehouseMaterials.PropertyForCurrentNumber;
        progressBar1.Maximum = 5;
        progressBar1.Value = Date.PropertyForWarehouse.list_of_food.Count();
    }

    private void list_box_for_food_warehouse(object sender, EventArgs e)
    {
    }

    private void button_write_in_file_Click(object sender, EventArgs e)
    {
        BinFile<Food> temp = new();
        BinFile<Materials> temp1 = new();
        var check = true;
        if (Date.PropertyForWarehouseMaterials.list_of_materials.Count == 0 ||
            Date.PropertyForWarehouse.list_of_food.Count == 0)
            check = false;
        temp1.WriteFile(Date.PropertyForWarehouseMaterials.list_of_materials, "materials.dat");

        temp.WriteFile(Date.PropertyForWarehouse.list_of_food, "food.dat");
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
        foreach (var temp in Date.PropertyForDictionary)
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
        if (Date.Name.Contains(textBox1.Text))
            MessageBox.Show(
                $"Об'єкт {textBox1.Text} знаходиться на складі\nБув доданий о: {Convert.ToString(Date.PropertyForDictionary[textBox1.Text])}");
        else
            MessageBox.Show("Такого об'єкта нема :(");
    }

    private void button4_Click(object sender, EventArgs e)
    {
        if (textBox2.Text.Length == 0) return;
        if (Date.SortedListExample.ContainsKey(Convert.ToInt32(textBox2.Text)))
            MessageBox.Show($"Об'єкт {Date.SortedListExample[Convert.ToInt32(textBox1.Text)]} знаходиться на складі");
        else
            MessageBox.Show("Такого об'єкта нема :(");
    }
}