
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
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(34, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(298, 212);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.list_box_for_food_warehouse);
            // 
            // button_for_writing_in_file
            // 
            this.button_for_writing_in_file.Location = new System.Drawing.Point(99, 287);
            this.button_for_writing_in_file.Name = "button_for_writing_in_file";
            this.button_for_writing_in_file.Size = new System.Drawing.Size(84, 46);
            this.button_for_writing_in_file.TabIndex = 1;
            this.button_for_writing_in_file.Text = "Write in file";
            this.button_for_writing_in_file.UseVisualStyleBackColor = true;
            this.button_for_writing_in_file.Click += new System.EventHandler(this.button_write_in_file_Click);
            // 
            // ChiefForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_for_writing_in_file);
            this.Controls.Add(this.listBox1);
            this.Name = "ChiefForm";
            this.Text = "ChiefForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button_for_writing_in_file;
    }
}