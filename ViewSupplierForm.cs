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
    public partial class ViewSupplierForm : Form
    {
        private Supplier supplier;

        public ViewSupplierForm (Supplier supplier)
        {
            InitializeComponent();
            this.supplier = supplier;
            BNTextBox.Text = supplier.SupplierBn;
            supplierNameTextBox.Text = supplier.SupplierName;
            emailTextBox.Text = supplier.Email;
            phoneNumberTextBox.Text = supplier.PhoneNumber;
            bankAccountTextBox.Text = supplier.BankAccount;

            BNTextBox.Enabled = false;
            supplierNameTextBox.Enabled = false;
            emailTextBox.Enabled = false;
            phoneNumberTextBox.Enabled = false;
            bankAccountTextBox.Enabled = false;
        }

        private void viewSupplierLabel_Click(object sender, EventArgs e)
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

        private void bankAccountTextBox_TextChanged(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backArrowPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            BnForSupplierForm bns = new BnForSupplierForm();
            bns.Show();
            this.Hide();
        }

        private void ViewSupplierForm_Load(object sender, EventArgs e)
        {

        }
    }
}
