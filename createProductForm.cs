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
    public partial class createProductForm : Form
    {
        public createProductForm()
        {
            InitializeComponent();
            supplierComboBox.DataSource = Program.Suppliers;//אתחול הקומבובוקס
            supplierComboBox.DisplayMember = "SupplierName";

        }

        private void createProductLabel_Click(object sender, EventArgs e)
        {

        }

        private void skuCodeLabel_Click(object sender, EventArgs e)
        {

        }

        private void skuCodeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void productNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void productNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void priceLabel_Click(object sender, EventArgs e)
        {

        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void backArrowPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            CRUD_ProductForm cpf = new CRUD_ProductForm();
            cpf.Show();
            this.Hide();

        }

        private void createProductButton_Click(object sender, EventArgs e)
        {
            if (!NullCheck())
                return;
            //price
            if (Program.isThereAChar(priceTextBox.Text))
            {
                MessageBox.Show("The price must include numbers only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //sku code
            if (Program.isSkuCodeExists(skuCodeTextBox.Text))
            {
                MessageBox.Show("There is a product with the same SKU code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            string sBN = Program.seekSupplierByName(supplierComboBox.Text);
            Supplier sp = Program.seekSupplier(sBN);
            Product p = new Product(skuCodeTextBox.Text, productNameTextBox.Text, double.Parse(priceTextBox.Text), sp, true);// create new product
            sp.SupplierProducts.Add(p);

            Program.Products.Add(p);
            string message = "The product " + productNameTextBox.Text + " added successfully!";
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CRUD_ProductForm cpf = new CRUD_ProductForm();
            cpf.Show();
            this.Hide();
        }

        private void createProductForm_Load(object sender, EventArgs e)
        {
            
        }

        private Boolean NullCheck() //return false if there a null cells
        {

            if (skuCodeTextBox.Text == "" || productNameTextBox.Text == "" || priceTextBox.Text == "" )
            {
                MessageBox.Show("Do not leave blank fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }//invalid input
            return true;
        }

        private void supplierLabel_Click(object sender, EventArgs e)
        {

        }

        private void supplierComboBox_SelectedIndexChanged(object sender, EventArgs e)
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
