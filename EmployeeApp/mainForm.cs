using System.Windows.Forms;
using System.Collections;
using System.IO;
using System;
using System.Text;

namespace EmployeeApp
{
    public partial class mainForm : Form
    {
        public ArrayList employees = new ArrayList();
        public UpdateEmployee frmUpdateEmployee;
        public DeleteEmployee frmDeleteEmployee;

        public mainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {

            {
                StreamReader inputStream = new StreamReader("c:/temp/employees.txt");
                string temp = inputStream.ReadLine();
                while (temp != null)
                {
                    string[] parts = temp.Split(',');
                    Employee anEmployee = new Employee(Convert.ToInt32(parts[0]), parts[1], parts[2],
                        Convert.ToDouble(parts[3]), Convert.ToInt32(parts[4]));
                    employees.Add(anEmployee);
                    temp = inputStream.ReadLine();
                }
                inputStream.Close();
            }

        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter outputStream = new StreamWriter("c:/temp/employees.txt");
            StringBuilder employeesString = new StringBuilder(2000);
            foreach (Employee anEmployee in employees)
            {
                employeesString.Append(anEmployee.CommaText() + "\r\n");
            }
            outputStream.Write(employeesString.ToString());
            outputStream.Close();
            Close();
        }

        private void UpdateEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmUpdateEmployee == null)
            {
                frmUpdateEmployee = new UpdateEmployee();
                frmUpdateEmployee.frmMain = this;
            }
            frmUpdateEmployee.Show();
        }

        private void DeleteEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmDeleteEmployee == null)
            {
                frmDeleteEmployee = new DeleteEmployee();
                frmDeleteEmployee.frmMain = this;
            }
            frmDeleteEmployee.Show();
        }

    }


}
