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
    public partial class UpdateOrDeleteSupplierForm : Form
    {
        public UpdateOrDeleteSupplierForm()
        {
            InitializeComponent();
        }

        private void idTypingLabel_Click(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            CRUD_SupplierForm csf = new CRUD_SupplierForm();
            csf.Show();
            this.Hide();

        }

        private void ChoseDeleteSupplierButton_Click(object sender, EventArgs e)
        {
            if (!Program.isBnSupplierExists(BnSupplierTextBox.Text))
            {

                string message = "There is no suuplier with the BN " + BnSupplierTextBox.Text;
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Supplier supplier = Program.seekSupplier(BnSupplierTextBox.Text);
            string mmessage = "Are you sure you want to delete " + supplier.SupplierName + "? ";
            DialogResult result = MessageBox.Show(mmessage, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                supplier.moveSupplierToArchive();
                Program.Suppliers.Remove(supplier);
                Program.archiveSupplier.Add(supplier);

                MessageBox.Show("Supplier deleted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // User clicked No, cancel the deletion
                MessageBox.Show("Deletion canceled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ChoseUpdateSupplierButton_Click(object sender, EventArgs e)
        {
            if (!Program.isBnSupplierExists(BnSupplierTextBox.Text))
            {

                string message = "There is no suuplier with the BN " + BnSupplierTextBox.Text;
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Supplier supplier = Program.seekSupplier(BnSupplierTextBox.Text);
            UpdateSupplierForm updateSupplierForm = new UpdateSupplierForm(supplier);
            updateSupplierForm.Show();
            this.Hide();
        }

        private void idEmployeeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UpdateOrDeleteSupplierForm_Load(object sender, EventArgs e)
        {

        }
    }
}
