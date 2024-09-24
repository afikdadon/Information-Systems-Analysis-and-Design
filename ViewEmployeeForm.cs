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
    public partial class ViewEmployeeForm : Form
    {
        private Employee employee;
        public ViewEmployeeForm(Employee employee)
        {
            InitializeComponent();

            this.employee = employee;

            idTextBox.Text = employee.Id;
            firstNameTextBox.Text = employee.FirstName;
            lastNameTextBox.Text = employee.LastName;
            genderTextBox.Text = employee.Gender.ToString();
            phoneNumberTextBox.Text = employee.PhoneNumber;
            addressTextBox.Text = employee.Address;
            emailTextBox.Text = employee.Email;
            birthDateTextBox.Text = employee.Birthdate.ToString(("yyyy-MM-dd"));
            employeeTypeTextBox.Text = employee.EmployeeType.ToString();
            employeeIdTextBox.Text = employee.EmployeeId;
            startWorkingDateTextBox.Text = employee.StartWorkingDate.ToString(("yyyy-MM-dd"));
            statusTextBox.Text = employee.Status.ToString();


        }
        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void startWorkingDateTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void employeeTypeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void birthDateTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void genderTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void employeeIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void phoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void statusTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void statusLAbel_Click(object sender, EventArgs e)
        {

        }

        private void startWorkingDateLable_Click(object sender, EventArgs e)
        {

        }

        private void employeeIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void employeeTypeLabel_Click(object sender, EventArgs e)
        {

        }

        private void birthdateLabel_Click(object sender, EventArgs e)
        {

        }

        private void addressLabel_Click(object sender, EventArgs e)
        {

        }

        private void phoneNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void genderLabel_Click(object sender, EventArgs e)
        {

        }

        private void lastNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void firstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            IdForEmployeeForm ief = new IdForEmployeeForm();
            ief.Show();
            this.Hide();
        }

        private void createEmployeeLabel_Click(object sender, EventArgs e)
        {

        }

        private void viewEmployeeLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void ViewEmployeeForm_Load(object sender, EventArgs e)
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
