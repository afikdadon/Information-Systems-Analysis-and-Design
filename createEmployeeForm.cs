using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Text.RegularExpressions;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;



namespace Group_1
{
    public partial class createEmployeeForm : Form
    {
        public createEmployeeForm()
        {
            InitializeComponent();

            statusComboBox.DisplayMember = "Description";//אתחול הקומבובוקס
            statusComboBox.ValueMember = "Value";
            statusComboBox.DataSource = Enum.GetValues(typeof(AvailabilityStatus)).Cast<Enum>().Select(value => new
            { (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description, value }).OrderBy(item => item.value).ToList();


            employeeTypeComboBox.DisplayMember = "Description";//אתחול הקומבובוקס
            employeeTypeComboBox.ValueMember = "Value";
            employeeTypeComboBox.DataSource = Enum.GetValues(typeof(EmployeeType)).Cast<Enum>().Select(value => new
            { (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description, value }).OrderBy(item => item.value).ToList();


            genderComboBox.DisplayMember = "Description";//אתחול הקומבובוקס
            genderComboBox.ValueMember = "Value";
            genderComboBox.DataSource = Enum.GetValues(typeof(Gender)).Cast<Enum>().Select(value => new
            { (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description, value }).OrderBy(item => item.value).ToList();

        }
        private void createEmployeeLabel_Click(object sender, EventArgs e)
        {

        }
        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
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
      

        private void createCustomerButton_Click(object sender, EventArgs e)
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

            // employee in the system
            if (Program.seekEmployee(idTextBox.Text) != null)
            {
                DialogResult result = MessageBox.Show("This employee already exists in the system", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                 MessageBox.Show("Enter a different ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
             }

            // employee id
            if (Program.isThereAChar(idTextBox.Text))
            {
                MessageBox.Show("The employee ID must consist of numbers only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Program.isIdEmployeeExists(idTextBox.Text))
            {
                MessageBox.Show("There is an employee in the system with the same employee ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            string s = statusComboBox.Text;
            if (s.IndexOf(" ") != -1)
            {
                s = s.Remove(s.IndexOf(" "), 1);
            }

            string et = employeeTypeComboBox.Text;
            if (s.IndexOf(" ") != -1)
            {
                et = et.Remove(et.IndexOf(" "), 1);
            }

            string g = genderComboBox.Text;
            if (s.IndexOf(" ") != -1)
            {
                g = g.Remove(g.IndexOf(" "), 1);
            }


            Employee E = new Employee(idTextBox.Text, firstNameTextBox.Text, lastNameTextBox.Text, (Gender)Enum.Parse(typeof(Gender), genderComboBox.Text), phoneNumberTextBox.Text, emailTextBox.Text, addressTextBox.Text,
                birthDatePicker.Value, (EmployeeType)Enum.Parse(typeof(EmployeeType), employeeTypeComboBox.Text), employeeIdTextBox.Text, StartWorkingDateDateTimePicker.Value, (AvailabilityStatus)Enum.Parse(typeof(AvailabilityStatus), statusComboBox.Text),0, true);//create new employee

            Program.Employees.Add(E);
            string message = "The employee " + firstNameTextBox.Text + " " + lastNameTextBox.Text + " added successfully!";
            MessageBox.Show(message,"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


            //string name = firstNameTextBox.Text;
            //string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //string filePath = Path.Combine(desktopPath, "output.pdf");
            //Document document = new Document();
            //PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
            //document.Open();
            //document.Add(new Paragraph("Name: " + name));
            //document.Close();
            //MessageBox.Show("PDF created successfully and add to the desktop!");

            //CRUD_EmployeeForm cef = new CRUD_EmployeeForm();
            //cef.Show();
            //this.Hide();
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

        private void employeeLabel_Click(object sender, EventArgs e)
        {

        }

        private void createEmployeeForm_Load(object sender, EventArgs e)
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

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
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

