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
    public partial class ViewProductForm : Form
    {
        private Product product;

        public ViewProductForm(Product product)
        {
            InitializeComponent();
            this.product = product;

            skuCodeTextBox.Text = product.SkuCode;
            productNameTextBox.Text = product.ProductName;
            priceTextBox.Text = product.Price.ToString();
            supplierTextBox.Text = product.Supplier.SupplierName;

            skuCodeTextBox.Enabled = false;
            productNameTextBox.Enabled = false;
            priceTextBox.Enabled = false;
            supplierTextBox.Enabled = false;
        }

        private void skuCodeLabel_Click(object sender, EventArgs e)
        {

        }

        private void skuCodeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void productNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void productNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void ViewProductForm_Load(object sender, EventArgs e)
        {

        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void priceLabel_Click(object sender, EventArgs e)
        {

        }

        private void backArrowPictureBox_Click(object sender, EventArgs e)
        {

        }

        public void backButton_Click(object sender, EventArgs e)
        {
            skuCodeForProductForm skuf = new skuCodeForProductForm();
            skuf.Show();
            this.Hide();
        }

        private void viewEmployeeLabel_Click(object sender, EventArgs e)
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
