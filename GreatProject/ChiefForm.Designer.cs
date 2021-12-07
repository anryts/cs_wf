
namespace GreatProject
{
    partial class ChiefForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button_for_writing_in_file = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(34, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 238);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.list_box_for_food_warehouse);
            // 
            // button_for_writing_in_file
            // 
            this.button_for_writing_in_file.Location = new System.Drawing.Point(12, 337);
            this.button_for_writing_in_file.Name = "button_for_writing_in_file";
            this.button_for_writing_in_file.Size = new System.Drawing.Size(142, 46);
            this.button_for_writing_in_file.TabIndex = 1;
            this.button_for_writing_in_file.Text = "Write in file";
            this.button_for_writing_in_file.UseVisualStyleBackColor = true;
            this.button_for_writing_in_file.Click += new System.EventHandler(this.button_write_in_file_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Write logs in file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_for_logs_writing);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(378, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "Home";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Home_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(608, 69);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(168, 23);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Value = 45;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(608, 108);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(168, 23);
            this.progressBar2.TabIndex = 5;
            this.progressBar2.Value = 67;
            this.progressBar2.Click += new System.EventHandler(this.progressBar2_Click);
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(608, 151);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(168, 23);
            this.progressBar3.TabIndex = 6;
            this.progressBar3.Value = 34;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(277, 35);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(215, 238);
            this.listBox2.TabIndex = 7;
            // 
            // ChiefForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_for_writing_in_file);
            this.Controls.Add(this.listBox1);
            this.Name = "ChiefForm";
            this.Text = "ChiefForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button_for_writing_in_file;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ListBox listBox2;
    }
}