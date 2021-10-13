
namespace GreatProject
{
    partial class FoodWarehouse
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
            this.Button_Return = new System.Windows.Forms.Button();
            this.link_to_git = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Button_Return
            // 
            this.Button_Return.Location = new System.Drawing.Point(501, 365);
            this.Button_Return.Name = "Button_Return";
            this.Button_Return.Size = new System.Drawing.Size(193, 51);
            this.Button_Return.TabIndex = 0;
            this.Button_Return.Text = "button1";
            this.Button_Return.UseVisualStyleBackColor = true;
            this.Button_Return.Click += new System.EventHandler(this.Button_Return_Click);
            // 
            // link_to_git
            // 
            this.link_to_git.AutoSize = true;
            this.link_to_git.Location = new System.Drawing.Point(683, 306);
            this.link_to_git.Name = "link_to_git";
            this.link_to_git.Size = new System.Drawing.Size(105, 13);
            this.link_to_git.TabIndex = 1;
            this.link_to_git.TabStop = true;
            this.link_to_git.Text = "repository_of_project";
            this.link_to_git.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_to_git_LinkClicked);
            // 
            // FoodWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.link_to_git);
            this.Controls.Add(this.Button_Return);
            this.Name = "FoodWarehouse";
            this.Text = "FoodWarehouse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Return;
        private System.Windows.Forms.LinkLabel link_to_git;
    }
}