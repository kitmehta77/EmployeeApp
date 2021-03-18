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
    public partial class UpdateEmployee : Form
    {
        public mainForm frmMain;
        public UpdateEmployee()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            Employee anEmployee = (Employee)lstEmployees.SelectedItem;
            if (txtLastName.Text == "" || txtFirstName.Text == "" || txtHourlyRate.Text == "" ||
                txtHours.Text == "")
            {
                MessageBox.Show("One or more fields is blank", "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                lstEmployees.Items.Remove(anEmployee);
                anEmployee.setLastName(txtLastName.Text);
                anEmployee.setFirstName(txtFirstName.Text);
                anEmployee.setHourlyRate(Convert.ToDouble(txtHourlyRate.Text));
                anEmployee.setHours(Convert.ToInt32(txtHours.Text));
                lstEmployees.Items.Add(anEmployee);
                txtLastName.Text = "";
                txtFirstName.Text = "";
                txtHourlyRate.Text = "";
                txtHours.Text = "";
            }

        }

        private void lstEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee anEmployee = (Employee)lstEmployees.SelectedItem;
            if (anEmployee != null)
            {
                txtLastName.Text = anEmployee.getLastName();
                txtFirstName.Text = anEmployee.getFirstName();
                txtHourlyRate.Text = anEmployee.getHourlyRate().ToString();
                txtHours.Text = anEmployee.getHours().ToString();
            }

        }

        private void UpdateEmployee_VisibleChanged(object sender, EventArgs e)
        {
            lstEmployees.Items.Clear();
            foreach (Employee anEmployee in frmMain.employees)
            {
                lstEmployees.Items.Add(anEmployee);
            }

        }

        private void UpdateEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
