

namespace EmployeeApp
{


    partial class mainForm
    {

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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEmployees});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(691, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Menu";
            // 
            // mnuEmployees
            // 
            this.mnuEmployees.DropDown = this.contextMenuStrip1;
            this.mnuEmployees.Name = "mnuEmployees";
            this.mnuEmployees.Size = new System.Drawing.Size(60, 24);
            this.mnuEmployees.Text = "Menu";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateEmployeesToolStripMenuItem,
            this.deleteEmployeesToolStripMenuItem,
            this.exitEmployeesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.OwnerItem = this.mnuEmployees;
            this.contextMenuStrip1.Size = new System.Drawing.Size(198, 76);
            // 
            // updateEmployeesToolStripMenuItem
            // 
            this.updateEmployeesToolStripMenuItem.Name = "updateEmployeesToolStripMenuItem";
            this.updateEmployeesToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.updateEmployeesToolStripMenuItem.Text = "Update Employee";
            this.updateEmployeesToolStripMenuItem.Click += new System.EventHandler(this.UpdateEmployeesToolStripMenuItem_Click);
            // 
            // deleteEmployeesToolStripMenuItem
            // 
            this.deleteEmployeesToolStripMenuItem.Name = "deleteEmployeesToolStripMenuItem";
            this.deleteEmployeesToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.deleteEmployeesToolStripMenuItem.Text = "Delete Employee";
            this.deleteEmployeesToolStripMenuItem.Click += new System.EventHandler(this.DeleteEmployeesToolStripMenuItem_Click);
            // 
            // exitEmployeesToolStripMenuItem
            // 
            this.exitEmployeesToolStripMenuItem.Name = "exitEmployeesToolStripMenuItem";
            this.exitEmployeesToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.exitEmployeesToolStripMenuItem.Text = "Exit";
            this.exitEmployeesToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 515);
            this.Controls.Add(this.menuStrip1);
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuEmployees;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitEmployeesToolStripMenuItem;
    }



}