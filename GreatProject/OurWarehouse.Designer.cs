
namespace GreatProject
{
    partial class OurWarehouse
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.List_Items = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 93);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.go_to_second_form_Click_1);
            // 
            // List_Items
            // 
            this.List_Items.FormattingEnabled = true;
            this.List_Items.Items.AddRange(new object[] {
            "Food",
            "Electrics",
            "Materials"});
            this.List_Items.Location = new System.Drawing.Point(345, 82);
            this.List_Items.Name = "List_Items";
            this.List_Items.Size = new System.Drawing.Size(147, 56);
            this.List_Items.TabIndex = 1;
            this.List_Items.SelectedIndexChanged += new System.EventHandler(this.List_Items_SelectedIndexChanged_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // OurWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(613, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.List_Items);
            this.Controls.Add(this.button1);
            this.Name = "OurWarehouse";
            this.Text = "OurWarehouse";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox List_Items;
        private System.Windows.Forms.TextBox textBox1;
    }
}

