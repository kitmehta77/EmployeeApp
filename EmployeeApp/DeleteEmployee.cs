using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApp
{
    public partial class DeleteEmployee : Form
    {
        public mainForm frmMain;
        public DeleteEmployee()
        {
            InitializeComponent();
        }

        private void DeleteEmployee_Load(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            DialogResult choice;
            Employee anEmployee = (Employee)lstEmployees.SelectedItem;
            if (anEmployee == null)
            {
                MessageBox.Show("Please select an employee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                choice = MessageBox.Show("Are you sure you want to delete this Employee?", "Warning",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (choice == DialogResult.Yes)
                {
                    lstEmployees.Items.Remove(anEmployee);
                    frmMain.employees.Remove(anEmployee);
                    MessageBox.Show("Employee deleted successfully", "Information", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    txtLastName.Text = "";
                    txtFirstName.Text = "";
                    txtEmployeeID.Text = "";
                }
            }

        }

        private void lstEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee anEmployee = (Employee)lstEmployees.SelectedItem;
            if (anEmployee != null)
            {
                txtLastName.Text = anEmployee.getLastName();
                txtFirstName.Text = anEmployee.getFirstName();
                txtEmployeeID.Text = anEmployee.getEmployeeID().ToString();
            }

        }

        private void DeleteEmployee_VisibleChanged(object sender, EventArgs e)
        {
            lstEmployees.Items.Clear();
            foreach (Employee anEmployee in frmMain.employees)
            {
                lstEmployees.Items.Add(anEmployee);
            }

        }
    }
}
