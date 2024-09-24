using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_1
{
    public partial class CreateInvoiceForm : Form
    {
        private HashSet<string> addedSkuCode = new HashSet<string>();



        public CreateInvoiceForm()
        {
            InitializeComponent();
            HideTextBox();
        }


        private string GenerateUniqueInvoiceID()
        {
            string invoiceID = "";

            while (true)
            {
                // Generate a random 6-digit number
                Random random = new Random();
                int randomNumber = random.Next(100000, 999999);
                invoiceID = randomNumber.ToString();

                // Check if the generated order ID already exists
                bool exists = Program.Invoices.Any(invoice => invoice.InvoiceID == invoiceID);

                if (!exists)
                {
                    // Unique order ID generated
                    break;
                }
            }

            return invoiceID;
        }

        public void HideTextBox()
        {
            InvoiceSupplierLabel.Visible = false;
            InvoiceSupplier.Visible = false;
            InvoiceProductLabel.Visible = false;
            InvoiceProductComboBox.Visible = false;
            InvoiceAmountLabel.Visible = false;
            InvoiceAmountNumericUpDown.Visible = false;
            InvoiceaddProductButton.Visible = false;
            InvoiceRemoveProductButton.Visible = false;
            InvoiceDataGridView1.Visible = false;
            InvoiceBackArrowPictureBox.Visible = false;
            InvoiceBackButton.Visible = false;
            InvoiceCheckOutButton.Visible = false;
            InvoiceTotalPriceLabel.Visible = false;
            InvoiceTotalSumCalc.Visible = false;
            InvoiceIDtextbox.Visible = false;
            InvoiceIDlabel.Visible = false;
            generateExceptionReport.Visible = false;
            priceTextBox.Visible = false;
            invoicePriceLabel.Visible = false;
        }

        public void ShowTextBox()
        {
            InvoiceSupplierLabel.Visible = true;
            InvoiceSupplier.Visible = true;
            InvoiceProductLabel.Visible = true;
            InvoiceProductComboBox.Visible = true;
            InvoiceAmountLabel.Visible = true;
            InvoiceAmountNumericUpDown.Visible = true;
            InvoiceaddProductButton.Visible = true;
            InvoiceRemoveProductButton.Visible = true;
            InvoiceDataGridView1.Visible = true;
            InvoiceBackArrowPictureBox.Visible = true;
            InvoiceBackButton.Visible = true;
            InvoiceCheckOutButton.Visible = true;
            InvoiceTotalPriceLabel.Visible = true;
            InvoiceTotalSumCalc.Visible = true;
            InvoiceIDtextbox.Visible = true;
            InvoiceIDlabel.Visible = true;
            priceTextBox.Visible = true;
            invoicePriceLabel.Visible = true;


        }
        private void InvoiceCheckOutButton_Click(object sender, EventArgs e)
        {
            //Order currentOrder = Program.seekEmployee(idEmployeeTextBox.Text);
            string mmessage = "Are you sure you want to add this invoice to the system? ";
            DialogResult result1 = MessageBox.Show(mmessage, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result1 == DialogResult.Yes)
            {

                Invoicestatus IS = (Invoicestatus)Enum.Parse(typeof(Invoicestatus), "invoiceIsNotCheckedYet");
                //OrderStatus s = OrderStatus.orderIsNotSentToSupplier;

                DateTime date = DateTime.Now;
                Order orderID = Program.seekOrder(OrderIDTextBox.Text);
                string invoiceID = InvoiceIDtextbox.Text;

                Invoice INV = new Invoice(invoiceID, date, IS, orderID, true); // this.project

                Program.Invoices.Add(INV);

                foreach (DataGridViewRow row in InvoiceDataGridView1.Rows)
                {
                    // Check if the row is not the header row
                    if (!row.IsNewRow)
                    {
                        string skuCode = row.Cells["SkuCode"].Value.ToString();
                        int amount = Convert.ToInt32(row.Cells["Amount"].Value);
                        double pricePerUnit = double.Parse(priceTextBox.Text);

                        // Find the corresponding Product object
                        Product product = Program.seekProduct(skuCode);
                        //Product product = Program.Products.Find(p => p.SkuCode == skuCode);

                        ProductInvoice productInvoiceList = new ProductInvoice(product, INV, pricePerUnit, amount, true);
                        Program.productInvoices.Add(productInvoiceList);


                    }
                }

                MessageBox.Show("The transaction was completed successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                generateExceptionReport.Visible = true;

            }

            string invoiceNumber = InvoiceIDtextbox.Text;
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, $"Invoice_{invoiceNumber}.pdf");

            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

            document.Open();

            Paragraph title = new Paragraph($"Invoice Number: {invoiceNumber}");
            title.Alignment = Element.ALIGN_CENTER;
            document.Add(title);

            // Create a table with the same number of columns as the DataGridView
            PdfPTable table = new PdfPTable(InvoiceDataGridView1.Columns.Count);

            // Add the column headers to the table
            foreach (DataGridViewColumn column in InvoiceDataGridView1.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                table.AddCell(cell);
            }

            // Add the rows from the DataGridView to the table
            foreach (DataGridViewRow row in InvoiceDataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    table.AddCell(cell.Value != null ? cell.Value.ToString() : string.Empty);
                }
            }

            document.Add(table);

            Paragraph overallCost = new Paragraph($"Overall Cost: {InvoiceTotalSumCalc.Text}");
            overallCost.Alignment = Element.ALIGN_RIGHT;
            document.Add(overallCost);

            document.Close();

            MessageBox.Show("PDF generated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void InvoiceBackButton_Click(object sender, EventArgs e)
        {

        }

        private void InvoiceBackArrowPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void InvoiceDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (InvoiceDataGridView1.Columns.Count == 0)
            {
                InvoiceDataGridView1.Columns.Add("SkuCode", "SKU Code");
                InvoiceDataGridView1.Columns.Add("ProductName", "Product Name");
                InvoiceDataGridView1.Columns.Add("Price", "Price");
                InvoiceDataGridView1.Columns.Add("Amount", "Amount");
                InvoiceDataGridView1.Columns.Add("OverallPrice", "Overall Price");
            }


        }

        private void InvoiceRemoveProductButton_Click(object sender, EventArgs e)
        {

            if (InvoiceDataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = InvoiceDataGridView1.SelectedRows[0];

                // Retrieve the SKU code of the selected row
                string skuCode = selectedRow.Cells[0].Value.ToString();

                // Remove the selected row from the DataGridView
                InvoiceDataGridView1.Rows.RemoveAt(selectedRow.Index);

                // Remove the SKU code from the addedSkuCodes collection
                addedSkuCode.Remove(skuCode);

            }

            double totalSum = 0;

            foreach (DataGridViewRow row in InvoiceDataGridView1.Rows)
            {
                // Get the "overallPrice" value from the row
                if (row.Cells["overallPrice"].Value != null && double.TryParse(row.Cells["overallPrice"].Value.ToString(), out double totalPrice))
                {
                    // Accumulate the sum
                    totalSum += totalPrice;
                }
            }

            // Set the sum value to the TextBox
            InvoiceTotalSumCalc.Text = totalSum.ToString();


        }

        private void InvoiceAmountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void InvoiceaddProductButton_Click(object sender, EventArgs e)
        {

            string selectedSupplier = (string)InvoiceSupplier.Text;
            Product selectedProduct = (Product)InvoiceProductComboBox.SelectedItem;
            int amount = (int)InvoiceAmountNumericUpDown.Value;

            if (amount <= 0)
            {
                MessageBox.Show("The amount must be greater than 0.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            string skuCode = selectedProduct.SkuCode;
            if (addedSkuCode.Contains(skuCode))
            {
                MessageBox.Show("SKU code already exists. Please choose a different product.");
                return;
            }
            addedSkuCode.Add(skuCode);


            // Retrieve the price from the TextBox -------------
            string priceInput = priceTextBox.Text;

            // Validate the price input
            if (!double.TryParse(priceInput, out double price))
            {
                MessageBox.Show("Invalid price. Please enter a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double overallPrice = double.Parse(priceTextBox.Text) * amount;

            ////-----------------------------------------------

            // Create a new row for the DataGridView
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(InvoiceDataGridView1);



            // Set the values for each cell in the new row
            newRow.Cells[0].Value = selectedProduct.SkuCode;
            newRow.Cells[1].Value = selectedProduct.ProductName;
            newRow.Cells[2].Value = priceInput;
            newRow.Cells[3].Value = amount;
            newRow.Cells[4].Value = overallPrice;

            // Add the new row to the DataGridView
            InvoiceDataGridView1.Rows.Add(newRow);



            double totalSum = 0;

            foreach (DataGridViewRow row in InvoiceDataGridView1.Rows)
            {
                // Get the "overallPrice" value from the row
                if (row.Cells["overallPrice"].Value != null && double.TryParse(row.Cells["overallPrice"].Value.ToString(), out double totalPrice))
                {
                    // Accumulate the sum
                    totalSum += totalPrice;
                }
            }

            // Set the sum value to the TextBox
            InvoiceTotalSumCalc.Text = totalSum.ToString();
        }

        private void InvoiceAmountLabel_Click(object sender, EventArgs e)
        {

        }

        private void InvoiceProductComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void InvoiceFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InvoiceSupplierComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InvoiceProductLabel_Click(object sender, EventArgs e)
        {

        }

        private void InvoiceFilterLabel_Click(object sender, EventArgs e)
        {

        }

        private void InvoiceSupplierLabel_Click(object sender, EventArgs e)
        {

        }

        private void createInvoiceLabel_Click(object sender, EventArgs e)
        {

        }

        private void OrderIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SerchIDButton_Click(object sender, EventArgs e)
        {
            if (OrderIDTextBox.Text == "")
            {
                MessageBox.Show("You must enter order ID to generate a new invoice", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (OrderIDTextBox != null)
            {
                //String orderSupplier = ;
                Order ord = Program.seekOrder(OrderIDTextBox.Text);  //locating the order
                                                                     //String orderSupplier = supplier.SupplierBn.ToString();


                if (ord != null)
                {
                    Supplier supplier = ord.Supplier;
                    this.ShowTextBox();


                    InvoiceSupplier.Text = supplier.SupplierName;

                    // Filter the products based on the selected supplier
                    IEnumerable<Product> filteredInvoiceProducts = Program.Products.Where(p => p.Supplier.SupplierBn == supplier.SupplierBn);

                    // Set the data source of the product ComboBox to null
                    InvoiceProductComboBox.DataSource = null;

                    // Clear the existing items in the product ComboBox
                    InvoiceProductComboBox.Items.Clear();

                    //Add the filtered products to the product ComboBox
                    foreach (Product product in filteredInvoiceProducts)
                    {
                        InvoiceProductComboBox.Items.Add(product);
                    }

                    InvoiceProductComboBox.DisplayMember = "productName";
                }
                else
                {
                    MessageBox.Show("Oops! Order does not exist in the system. Please enter an existing order id", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                }




            }
        }

        private void InvoiceSupplier_TextChanged(object sender, EventArgs e)
        {

        }

        private void InvoiceTotalSumCalc_TextChanged(object sender, EventArgs e)
        {

        }

        private void InvoiceTotalPriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void CreateInvoiceForm_Load(object sender, EventArgs e)
        {
            InvoiceDataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Maiandra GD", 12, FontStyle.Bold);

            // Generate unique order ID
            string invoiceID = GenerateUniqueInvoiceID();

            // Assign the order ID to the textbox for display
            InvoiceIDtextbox.Text = invoiceID;

        }

        private void generateExceptionReport_Click(object sender, EventArgs e)
        {
            string orderId = OrderIDTextBox.Text;
            string invoiceId = InvoiceIDtextbox.Text;
            CreateAnExceptionReport exceptionReportForm = new CreateAnExceptionReport();
            exceptionReportForm.SetERorderIDContent(orderId);
            exceptionReportForm.SetEInvoiceIDContent(invoiceId);

            string thisInvoiceId = InvoiceIDtextbox.Text;
            exceptionReportForm.Show();

        }

        private void InvoiceIDtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void InvoiceIDlabel_Click(object sender, EventArgs e)
        {

        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void invoicePriceLabel_Click(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}