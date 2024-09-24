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
    public partial class UpdateOrDeleteProductForm : Form
    {
        public UpdateOrDeleteProductForm()
        {
            InitializeComponent();
        }

        private void ChoseDeleteProductButton_Click(object sender, EventArgs e)
        {
            if (!Program.isSkuCodeExists(skuCodeTextBox.Text))
            {

                string message = "There is no product in the system with the SKU: " + skuCodeTextBox.Text;
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Product product = Program.seekProduct(skuCodeTextBox.Text);
            string mmessage = "Are you sure you want to delete " + product.ProductName;
            DialogResult result = MessageBox.Show(mmessage, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                product.moveProductToArchive();
                Program.Products.Remove(product);
                Program.archiveProduct.Add(product);

                MessageBox.Show("Product deleted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // User clicked No, cancel the deletion
                MessageBox.Show("Deletion canceled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ChoseUpdateProductButton_Click(object sender, EventArgs e)
        {
            if (!Program.isSkuCodeExists(skuCodeTextBox.Text))
            {

                string message = "There is no product in the system with the SKU: " + skuCodeTextBox.Text;
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Product product = Program.seekProduct(skuCodeTextBox.Text);
            UpdateProductForm upf = new UpdateProductForm(product);
            upf.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            CRUD_ProductForm cpf = new CRUD_ProductForm();
            cpf.Show();
            this.Hide();
        }

        private void skuCodeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void enterEmployeeIdLabel_Click(object sender, EventArgs e)
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
