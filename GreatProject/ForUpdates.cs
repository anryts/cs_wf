using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace GreatProject;

public partial class ForUpdates : Form
{
    public ForUpdates()
    {
        InitializeComponent();
    }

    private void Button_Return_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void link_to_git_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Process.Start("https://github.com/anryts?tab=repositories");
    }

    private void label1_Click(object sender, EventArgs e)
    {
    }
}