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
    public partial class ForUpdates : Form
    {
        public ForUpdates()
        {
            InitializeComponent();
        }

        private void Button_Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void link_to_git_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/anryts?tab=repositories");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
