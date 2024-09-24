using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_1
{
    public partial class UpdateOrDeleteEmployeeForm : Form
    {
        public UpdateOrDeleteEmployeeForm()
        {
            InitializeComponent();
        }

        private void idEmployeeTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ChoseDeleteEmployeeButton_Click(object sender, EventArgs e)
        {
            if (!Program.isIdEmployeeExists(idEmployeeTextBox.Text))
            {

                string message = "אין עובד קיים במערכת עם תעודת הזהות " + idEmployeeTextBox.Text;
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Employee employeee = Program.seekEmployee(idEmployeeTextBox.Text);
            string mmessage = "Are you sure you want to delete " + employeee.FirstName + " " + employeee.LastName;
            DialogResult result = MessageBox.Show(mmessage, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                employeee.moveEmployeeToArchive();
                Program.Employees.Remove(employeee);
                Program.archiveEmployee.Add(employeee);

                MessageBox.Show("Employee deleted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // User clicked No, cancel the deletion
                MessageBox.Show("Deletion canceled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void ChoseUpdateEmployeeButton_Click(object sender, EventArgs e)
        {
            if (!Program.isIdEmployeeExists(idEmployeeTextBox.Text))
            {

                string message = "אין עובד קיים במערכת עם תעודת הזהות " + idEmployeeTextBox.Text;
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Employee employeee = Program.seekEmployee(idEmployeeTextBox.Text);
            UpdateEmployeeForm updateEmployeeForm = new UpdateEmployeeForm(employeee);
            updateEmployeeForm.Show();
            this.Hide();
        }

        private void idTypingLabel_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            CRUD_EmployeeForm cef = new CRUD_EmployeeForm();
            cef.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void homePageButton_Click(object sender, EventArgs e)
        {
            Employee employee = Program.seekEmployee(LogInForm.enterId);
            string ET = employee.EmployeeType.ToString();
            if (ET.Equals("teamWorker"))
            {
                TeamWorkerFunctionForm twf = new TeamWorkerFunctionForm();
                twf.Show();
                this.Hide();
            }
            else if (ET.Equals("officeManager"))
            {
                AllFunctionForm aff = new AllFunctionForm();
                aff.Show();
                this.Hide();
            }
            else if (ET.Equals("projectmanager"))
            {
                ProjectManagerFunctionForm pmf = new ProjectManagerFunctionForm();
                pmf.Show();
                this.Hide();
            }
            else if (ET.Equals("vicePresident"))
            {
                AllFunctionForm aff = new AllFunctionForm();
                aff.Show();
                this.Hide();
            }
            else // CEO
            {
                AllFunctionForm aff = new AllFunctionForm();
                aff.Show();
                this.Hide();
            }
        }
    }
}
