
namespace GreatProject
{
    partial class ForUpdates
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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_Return
            // 
            this.Button_Return.Location = new System.Drawing.Point(313, 160);
            this.Button_Return.Name = "Button_Return";
            this.Button_Return.Size = new System.Drawing.Size(193, 51);
            this.Button_Return.TabIndex = 0;
            this.Button_Return.Text = "Home";
            this.Button_Return.UseVisualStyleBackColor = true;
            this.Button_Return.Click += new System.EventHandler(this.Button_Return_Click);
            // 
            // link_to_git
            // 
            this.link_to_git.AutoSize = true;
            this.link_to_git.Location = new System.Drawing.Point(387, 73);
            this.link_to_git.Name = "link_to_git";
            this.link_to_git.Size = new System.Drawing.Size(105, 13);
            this.link_to_git.TabIndex = 1;
            this.link_to_git.TabStop = true;
            this.link_to_git.Text = "repository_of_project";
            this.link_to_git.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_to_git_LinkClicked);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(560, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "Home";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Maybe in later...\r\nChecking updates on\r\n\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ForUpdates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.link_to_git);
            this.Controls.Add(this.Button_Return);
            this.Name = "ForUpdates";
            this.Text = "FoodWarehouse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Return;
        private System.Windows.Forms.LinkLabel link_to_git;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}