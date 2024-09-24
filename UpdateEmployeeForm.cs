using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_1
{
    public partial class UpdateEmployeeForm : Form
    {
        private Employee employee;

        public UpdateEmployeeForm(Employee employee)
        {
            InitializeComponent();

            this.employee = employee;

            // Set the values for text-based fields
            idTextBox.Text = employee.Id;
            firstNameTextBox.Text = employee.FirstName;
            lastNameTextBox.Text = employee.LastName;
            phoneNumberTextBox.Text = employee.PhoneNumber;
            addressTextBox.Text = employee.Address;
            employeeIdTextBox.Text = employee.EmployeeId;

            // Disable the fields you don't want the user to change
            idTextBox.Enabled = false;
            employeeIdTextBox.Enabled = false;

            // Set the values for combo box fields
            genderComboBox.DataSource = Enum.GetValues(typeof(Gender));
            genderComboBox.SelectedItem = employee.Gender;

            employeeTypeComboBox.DataSource = Enum.GetValues(typeof(EmployeeType));
            employeeTypeComboBox.SelectedItem = employee.EmployeeType;

            statusComboBox.DataSource = Enum.GetValues(typeof(AvailabilityStatus));
            statusComboBox.SelectedItem = employee.Status;

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {
   
        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateEmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void genderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void phoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void birthDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void employeeTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void employeeIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void StartWorkingDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateEmployeeButton_Click(object sender, EventArgs e)
        {
            if (!NullCheck())
                return;
            //id
            if (Program.isThereAChar(idTextBox.Text))
            {
                MessageBox.Show("An ID must consist of numbers only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (idTextBox.Text.Length < 9)
            {
                MessageBox.Show(" An ID must consist of at least 9 numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //phone number
            string phoneNumberPattern = @"^[0-9]{3}[0-9]{3}[0-9]{4}$";
            if (Regex.IsMatch(phoneNumberTextBox.Text, phoneNumberPattern))
            {
                // The text in the textbox is a valid phone number
            }
            else
            {
                MessageBox.Show("Phone number in incorrect format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //email

            if (!Program.IsEmailValid(emailTextBox.Text))
            {
                MessageBox.Show("The email must be of the form example@example.example", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // employee id
            if (Program.isThereAChar(idTextBox.Text))
            {
                MessageBox.Show("The employee ID must consist of numbers only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Program.Employees.Remove(employee);

            employee.FirstName = firstNameTextBox.Text;
            employee.LastName = lastNameTextBox.Text;
            employee.Gender = (Gender)Enum.Parse(typeof(Gender), genderComboBox.Text);
            employee.PhoneNumber = phoneNumberTextBox.Text;
            employee.Email = emailTextBox.Text;
            employee.Address = addressTextBox.Text;
            employee.EmployeeType = (EmployeeType)Enum.Parse(typeof(EmployeeType), employeeTypeComboBox.Text);
            employee.Status = (AvailabilityStatus)Enum.Parse(typeof(AvailabilityStatus), statusComboBox.Text);

            employee.updateEmployee();

            string message = "The employee " + firstNameTextBox.Text + " " + lastNameTextBox.Text + " was successfully updated!";
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            UpdateOrDeleteEmployeeForm udf = new UpdateOrDeleteEmployeeForm();
            udf.Show();
            this.Hide();

        }
        private Boolean NullCheck() //return false if there a null cells
        {

            if (idTextBox.Text == "" || firstNameTextBox.Text == "" || lastNameTextBox.Text == "" || phoneNumberTextBox.Text == "" || addressTextBox.Text == "" || employeeIdTextBox.Text == "")
            {
                MessageBox.Show("Do not leave blank fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }//invalid input
            return true;
        }

        private void updateEmployeeLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            UpdateOrDeleteEmployeeForm udf = new UpdateOrDeleteEmployeeForm();
            udf.Show();
            this.Hide();
        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
