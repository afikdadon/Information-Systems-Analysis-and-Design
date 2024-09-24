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
    public partial class createOrderForm : Form
    {
        private HashSet<string> addedSkuCodes = new HashSet<string>();
        private Project project;

        public createOrderForm(Project project)  
        {
            InitializeComponent();
            this.project = project;
            projectNameTextBox.Text = this.project.ProjectName;
            projectNameTextBox.Enabled = false;
            orderIdTextBox.Text = GenerateUniqueOrderID();

            supplierComboBox.DataSource = Program.Suppliers;
            supplierComboBox.DisplayMember = "supplierName";
            supplierComboBox.SelectedIndex = -1;


            filterComboBox.Items.Add("Lower To Higher");
            filterComboBox.Items.Add("Higher To Lower");
            filterComboBox.Items.Add("No Filter");
        }

        private void createOrderForm_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Maiandra GD", 12, FontStyle.Bold);

        }

        private string GenerateUniqueOrderID()
        {
            string orderID = "";

            while (true)
            {
                // Generate a random 6-digit number
                Random random = new Random();
                int randomNumber = random.Next(100000, 999999);
                orderID = randomNumber.ToString();

                // Check if the generated order ID already exists
                bool exists = Program.Orders.Any(order => order.OrderID == orderID);

                if (!exists)
                {
                    // Unique order ID generated
                    break;
                }
            }

            return orderID;
        }

        private void supplierComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void productComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(supplierComboBox.SelectedText))
            {

                Console.WriteLine("You must first select a supplier.");
            }

            // Set the data source of the products ComboBox to the sorted products
            Supplier s = (Supplier)supplierComboBox.SelectedItem;
            productComboBox.DataSource = s.SupplierProducts;
            productComboBox.DisplayMember = "productNamePrice";
            productComboBox.SelectedIndex = -1;

            // Get the selected filter option
            string selectedFilter = filterComboBox.SelectedItem.ToString();
            List<Product> productOrderList = new List<Product>();

            // Sort the products based on the selected filter
            if (selectedFilter == "Higher To Lower")
            {
                // Sort products in descending order (highest price to lowest price)
                productOrderList = s.SupplierProducts.OrderByDescending(p => p.Price).ToList();
            }
            else if (selectedFilter == "Lower To Higher")
            {
                // Sort products in ascending order (lowest price to highest price)
                productOrderList = s.SupplierProducts.OrderBy(p => p.Price).ToList();
            }
            else
            {

                productOrderList = s.SupplierProducts;
            }

            
            // Clear the selection of the product ComboBox
            productComboBox.SelectedIndex = -1;
            productComboBox.DataSource = null;
            productComboBox.DataSource = productOrderList;
            productComboBox.DisplayMember = "productNamePrice";


        }

        private void amountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void backArrowPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ProjectForm pf = new ProjectForm(project);
            pf.Show();
            this.Hide();
        }

        private void checkOutButton_Click(object sender, EventArgs e)
        {
            
            //Order currentOrder = Program.seekEmployee(idEmployeeTextBox.Text);
            string mmessage = "Are you sure you want to finish the transaction? ";
            DialogResult result = MessageBox.Show(mmessage, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                 

                OrderStatus s = (OrderStatus)Enum.Parse(typeof(OrderStatus), "orderIsNotSentToSupplier");

                DateTime date = DateTime.Now;
                Supplier selectedSupplier = (Supplier)supplierComboBox.SelectedItem;
                string orderID = orderIdTextBox.Text;

                Order O = new Order(orderID, date, s, selectedSupplier, project, null,true); 
                
                Program.Orders.Add(O);

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // Check if the row is not the header row
                    if (!row.IsNewRow)
                    {
                        string skuCode = row.Cells["SkuCode"].Value.ToString();
                        int amount = Convert.ToInt32(row.Cells["Amount"].Value);

                        // Find the corresponding Product object
                        Product product = Program.seekProduct(skuCode);
                        //Product product = Program.Products.Find(p => p.SkuCode == skuCode);

                        OrderedProduct orderedProductList = new OrderedProduct(O, product, amount, true);
                        Program.OrderedProducts.Add(orderedProductList);


                    }
                }

                MessageBox.Show("The transaction was completed successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                if (dataGridView1.Columns.Count == 0)
                {
                    dataGridView1.Columns.Add("SkuCode", "SKU Code");
                    dataGridView1.Columns.Add("ProductName", "Product Name");
                    dataGridView1.Columns.Add("Price", "Price");
                    dataGridView1.Columns.Add("Amount", "Amount");
                    dataGridView1.Columns.Add("OverallPrice", "Overall Price");
                }

            }

            private void addProductButton_Click(object sender, EventArgs e)
            {

                Supplier selectedSupplier = (Supplier)supplierComboBox.SelectedItem;
                Product selectedProduct = (Product)productComboBox.SelectedItem;
                int amount = (int)amountNumericUpDown.Value;
                double overallPrice = selectedProduct.Price * amount;

                if (amount <= 0)
                {
                    MessageBox.Show("The amount must be greater than 0.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
               
                string skuCode = selectedProduct.SkuCode;
                if (addedSkuCodes.Contains(skuCode))
                {
                    MessageBox.Show("SKU code already exists. Please choose a different product.");
                    return;
                }
                addedSkuCodes.Add(skuCode);

                // Create a new row for the DataGridView
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridView1);

                // Set the values for each cell in the new row
                newRow.Cells[0].Value = selectedProduct.SkuCode;
                newRow.Cells[1].Value = selectedProduct.ProductName;
                newRow.Cells[2].Value = selectedProduct.Price;
                newRow.Cells[3].Value = amount;
                newRow.Cells[4].Value = overallPrice;

                // Add the new row to the DataGridView
                dataGridView1.Rows.Add(newRow);

                if (dataGridView1.Rows.Count > 0)
                {
                    supplierComboBox.Enabled = false; // Lock the supplier ComboBox
                }


                double totalSum = 0;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // Get the "overallPrice" value from the row
                    if (row.Cells["overallPrice"].Value != null && double.TryParse(row.Cells["overallPrice"].Value.ToString(), out double totalPrice))
                    {
                        // Accumulate the sum
                        totalSum += totalPrice;
                    }
                }

                // Set the sum value to the TextBox
                totalPriceTextBox.Text = totalSum.ToString();



            }

            private void amountLabel_Click(object sender, EventArgs e)
            {

            }

            private void productLabel_Click(object sender, EventArgs e)
            {

            }

            private void filterLabel_Click(object sender, EventArgs e)
            {

            }

            private void supplierLabel_Click(object sender, EventArgs e)
            {

            }

            private void createOrderLabel_Click(object sender, EventArgs e)
            {

            }

            private void removeProductButton_Click(object sender, EventArgs e)
            {


                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    // Retrieve the SKU code of the selected row
                    string skuCode = selectedRow.Cells[0].Value.ToString();

                    // Remove the selected row from the DataGridView
                    dataGridView1.Rows.RemoveAt(selectedRow.Index);

                    // Remove the SKU code from the addedSkuCodes collection
                    addedSkuCodes.Remove(skuCode);

                }

                double totalSum = 0;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // Get the "overallPrice" value from the row
                    if (row.Cells["overallPrice"].Value != null && double.TryParse(row.Cells["overallPrice"].Value.ToString(), out double totalPrice))
                    {
                        // Accumulate the sum
                        totalSum += totalPrice;
                    }
                }

                // Set the sum value to the TextBox
                totalPriceTextBox.Text = totalSum.ToString();



                if (dataGridView1.Rows.Count == 1)
                {
                    supplierComboBox.Enabled = true; // Lock the supplier ComboBox
                }


            }

            private void totalPriceTextBox_TextChanged(object sender, EventArgs e)
            {

            }

            private void totalPriceLabel_Click(object sender, EventArgs e)
            {

            }





            private void orderIdLabel_Click(object sender, EventArgs e)
            {

            }

            private void orderIdTextBox_TextChanged(object sender, EventArgs e)
            {

            }

        private void projectNameTextBox_TextChanged(object sender, EventArgs e)
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

