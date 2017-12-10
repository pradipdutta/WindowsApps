namespace HelloWorld
{
    partial class Form1
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
            this.Toppanel1 = new System.Windows.Forms.Panel();
            this.Buttompanel1 = new System.Windows.Forms.Panel();
            this.Leftpanel1 = new System.Windows.Forms.Panel();
            this.Rightpanel1 = new System.Windows.Forms.Panel();
            this.Workpanel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Toppanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Toppanel1
            // 
            this.Toppanel1.Controls.Add(this.menuStrip1);
            this.Toppanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Toppanel1.Location = new System.Drawing.Point(0, 0);
            this.Toppanel1.Name = "Toppanel1";
            this.Toppanel1.Size = new System.Drawing.Size(938, 26);
            this.Toppanel1.TabIndex = 0;
            // 
            // Buttompanel1
            // 
            this.Buttompanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Buttompanel1.Location = new System.Drawing.Point(0, 613);
            this.Buttompanel1.Name = "Buttompanel1";
            this.Buttompanel1.Size = new System.Drawing.Size(938, 10);
            this.Buttompanel1.TabIndex = 1;
            // 
            // Leftpanel1
            // 
            this.Leftpanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Leftpanel1.Location = new System.Drawing.Point(0, 26);
            this.Leftpanel1.Name = "Leftpanel1";
            this.Leftpanel1.Size = new System.Drawing.Size(10, 587);
            this.Leftpanel1.TabIndex = 2;
            // 
            // Rightpanel1
            // 
            this.Rightpanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.Rightpanel1.Location = new System.Drawing.Point(928, 26);
            this.Rightpanel1.Name = "Rightpanel1";
            this.Rightpanel1.Size = new System.Drawing.Size(10, 587);
            this.Rightpanel1.TabIndex = 3;
            // 
            // Workpanel1
            // 
            this.Workpanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Workpanel1.Location = new System.Drawing.Point(10, 26);
            this.Workpanel1.Name = "Workpanel1";
            this.Workpanel1.Size = new System.Drawing.Size(918, 587);
            this.Workpanel1.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(938, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 623);
            this.Controls.Add(this.Workpanel1);
            this.Controls.Add(this.Rightpanel1);
            this.Controls.Add(this.Leftpanel1);
            this.Controls.Add(this.Buttompanel1);
            this.Controls.Add(this.Toppanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "HelloWorld";
            this.Toppanel1.ResumeLayout(false);
            this.Toppanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Toppanel1;
        private System.Windows.Forms.Panel Buttompanel1;
        private System.Windows.Forms.Panel Leftpanel1;
        private System.Windows.Forms.Panel Rightpanel1;
        private System.Windows.Forms.Panel Workpanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    }
}

