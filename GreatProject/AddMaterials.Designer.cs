﻿
namespace GreatProject
{
    partial class AddMaterials
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_for_name = new System.Windows.Forms.TextBox();
            this.textBox_for_capacity = new System.Windows.Forms.TextBox();
            this.textBox_for_weight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_for_sort = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_for_name
            // 
            this.textBox_for_name.Location = new System.Drawing.Point(85, 58);
            this.textBox_for_name.Name = "textBox_for_name";
            this.textBox_for_name.Size = new System.Drawing.Size(121, 20);
            this.textBox_for_name.TabIndex = 0;
            this.textBox_for_name.TextChanged += new System.EventHandler(this.textBox_for_name_TextChanged);
            // 
            // textBox_for_capacity
            // 
            this.textBox_for_capacity.Location = new System.Drawing.Point(85, 84);
            this.textBox_for_capacity.Name = "textBox_for_capacity";
            this.textBox_for_capacity.Size = new System.Drawing.Size(121, 20);
            this.textBox_for_capacity.TabIndex = 2;
            this.textBox_for_capacity.TextChanged += new System.EventHandler(this.textBox_for_capacity_TextChanged);
            // 
            // textBox_for_weight
            // 
            this.textBox_for_weight.Location = new System.Drawing.Point(85, 110);
            this.textBox_for_weight.Name = "textBox_for_weight";
            this.textBox_for_weight.Size = new System.Drawing.Size(121, 20);
            this.textBox_for_weight.TabIndex = 3;
            this.textBox_for_weight.TextChanged += new System.EventHandler(this.textBox_for_weight_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Capacity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Weight";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(328, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(420, 264);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_for_add_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(354, 475);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 50);
            this.button2.TabIndex = 11;
            this.button2.Text = "Home";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_for_home_Click);
            // 
            // button_for_sort
            // 
            this.button_for_sort.Location = new System.Drawing.Point(328, 298);
            this.button_for_sort.Margin = new System.Windows.Forms.Padding(2);
            this.button_for_sort.Name = "button_for_sort";
            this.button_for_sort.Size = new System.Drawing.Size(95, 46);
            this.button_for_sort.TabIndex = 12;
            this.button_for_sort.Text = "Sort";
            this.button_for_sort.UseVisualStyleBackColor = true;
            this.button_for_sort.Click += new System.EventHandler(this.button_for_sort_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(21, 298);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 46);
            this.button3.TabIndex = 13;
            this.button3.Text = "Write in warehouse";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_for_materials);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(615, 298);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 46);
            this.button4.TabIndex = 14;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(439, 299);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 45);
            this.button5.TabIndex = 15;
            this.button5.Text = "Write from file(deser)";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(85, 214);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(121, 46);
            this.button6.TabIndex = 16;
            this.button6.Text = "Test";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // AddMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 573);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_for_sort);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_for_weight);
            this.Controls.Add(this.textBox_for_capacity);
            this.Controls.Add(this.textBox_for_name);
            this.Name = "AddMaterials";
            this.Text = "AddMaterials";
            this.Load += new System.EventHandler(this.AddMaterials_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_for_name;
        private System.Windows.Forms.TextBox textBox_for_capacity;
        private System.Windows.Forms.TextBox textBox_for_weight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_for_sort;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}