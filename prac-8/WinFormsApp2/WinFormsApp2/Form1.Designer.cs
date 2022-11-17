namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitManuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowCascadeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowTileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.NewMenuItem,
            this.WindowMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(402, 28);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(46, 24);
            this.FileMenuItem.Text = "File";
            // 
            // NewMenuItem
            // 
            this.NewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitManuItem});
            this.NewMenuItem.Name = "NewMenuItem";
            this.NewMenuItem.Size = new System.Drawing.Size(53, 24);
            this.NewMenuItem.Text = "New";
            this.NewMenuItem.Click += new System.EventHandler(this.NewMenuItem_Click);
            // 
            // ExitManuItem
            // 
            this.ExitManuItem.Name = "ExitManuItem";
            this.ExitManuItem.Size = new System.Drawing.Size(224, 26);
            this.ExitManuItem.Text = "Exit";
            this.ExitManuItem.Click += new System.EventHandler(this.ExitManuItem_Click);
            // 
            // WindowMenuItem
            // 
            this.WindowMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WindowCascadeMenuItem,
            this.WindowTileMenuItem});
            this.WindowMenuItem.Name = "WindowMenuItem";
            this.WindowMenuItem.Size = new System.Drawing.Size(78, 24);
            this.WindowMenuItem.Text = "Window";
            // 
            // WindowCascadeMenuItem
            // 
            this.WindowCascadeMenuItem.Name = "WindowCascadeMenuItem";
            this.WindowCascadeMenuItem.Size = new System.Drawing.Size(224, 26);
            this.WindowCascadeMenuItem.Text = "Cascade";
            this.WindowCascadeMenuItem.Click += new System.EventHandler(this.WindowCascadeMenuItem_Click);
            // 
            // WindowTileMenuItem
            // 
            this.WindowTileMenuItem.Name = "WindowTileMenuItem";
            this.WindowTileMenuItem.Size = new System.Drawing.Size(224, 26);
            this.WindowTileMenuItem.Text = "Tile";
            this.WindowTileMenuItem.Click += new System.EventHandler(this.WindowTileMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 273);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "Form1";
            this.Text = "ParentForm";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip Menu;
        private ToolStripMenuItem FileMenuItem;
        private ToolStripMenuItem NewMenuItem;
        private ToolStripMenuItem ExitManuItem;
        private ToolStripMenuItem WindowMenuItem;
        private ToolStripMenuItem WindowCascadeMenuItem;
        private ToolStripMenuItem WindowTileMenuItem;
    }
}