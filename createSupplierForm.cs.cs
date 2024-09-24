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
    public partial class createSupplierForm : Form
    {
        public createSupplierForm()
        {
            InitializeComponent();
        }

        private void createSupplierLabel_Click(object sender, EventArgs e)
        {

        }

        private void bankAcoountLabel_Click(object sender, EventArgs e)
        {

        }

        private void phoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void phoneNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void createSupplierButton_Click(object sender, EventArgs e)
        {
            if (!NullCheck())
                return;
            //Supplier is already exists
            if (Program.isBnSupplierExists(BNTextBox.Text))
            {
                MessageBox.Show("There is already a supplier with this BN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //BN
            if (Program.isThereAChar(BNTextBox.Text))
            {
                MessageBox.Show("The price must include numbers only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //email

            if (!Program.IsEmailValid(emailTextBox.Text))
            {
                MessageBox.Show("The email must be of the form example@example.example", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            Supplier s = new Supplier(BNTextBox.Text, supplierNameTextBox.Text, emailTextBox.Text, phoneNumberTextBox.Text, bankAccountTextBox.Text, true);
            Program.Suppliers.Add(s);
            string message = "The supplier " + supplierNameTextBox.Text + " " + " added successfully!";
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void supplierNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BNTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void supplierNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void BNLabel_Click(object sender, EventArgs e)
        {

        }

        private void bankAccountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void backArrowPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            CRUD_SupplierForm csf = new CRUD_SupplierForm();
            csf.Show();
            this.Hide();
        }

        private Boolean NullCheck() //return false if there a null cells
        {

            if (BNTextBox.Text == "" || supplierNameTextBox.Text == "" || emailTextBox.Text == "" || phoneNumberTextBox.Text == "" || bankAccountTextBox.Text == "")
            {
                MessageBox.Show("Do not leave blank fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }//invalid input
            return true;
        }

        private void createSupplierForm_Load(object sender, EventArgs e)
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
