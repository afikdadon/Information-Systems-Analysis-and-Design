using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using iTextRectangle = iTextSharp.text.Rectangle;



namespace Group_1
{
    public partial class CreateAnExceptionReport : Form
    {


        public CreateAnExceptionReport()
        {
            InitializeComponent();
            Invoice enteredInvoice = Program.seekInvoice(ERInvoiceIDTextBox.Text);
            if (enteredInvoice != null)
            {
                Order receivedOrder = Program.seekOrder(enteredInvoice.Order.OrderID);
                ERorderIDTextBox.Text = receivedOrder.OrderID;
            }


            


            // Retrieve the invoice ID from the ERInvoiceIDTextBox
            string invoiceID = ERInvoiceIDTextBox.Text;

            // Retrieve the invoice by the invoice ID
            Invoice invoice = Program.seekInvoice(invoiceID);

            // Check if the invoice is found
            if (invoice != null)
            {
                // Loop through each product invoice in the invoice
                foreach (ProductInvoice productInvoice in Program.productInvoices)
                {
                    if (invoice.InvoiceID == productInvoice.Invoice.InvoiceID)
                    {
                        // Retrieve the product details
                        string skuCode = productInvoice.Product.SkuCode;
                        string productName = productInvoice.Product.ProductName;
                        double price = productInvoice.Product.Price;
                        int amount = productInvoice.Amount;
                        double overallPrice = price * amount;

                        DataGridViewRow newRow = new DataGridViewRow();
                        newRow.CreateCells(ERgridInvoice);

                        // Add a new row to the ERgridInvoice DataGridView with the product details
                        ERgridInvoice.Rows.Add(skuCode, productName, price, amount, overallPrice);

                        double totalSum = 0;

                        foreach (DataGridViewRow row in ERgridInvoice.Rows)
                        {
                            // Get the "overallPrice" value from the row
                            if (row.Cells["overallPrice"].Value != null && double.TryParse(row.Cells["overallPrice"].Value.ToString(), out double totalPrice))
                            {
                                // Accumulate the sum
                                totalSum += totalPrice;
                            }
                        }

                        // Set the sum value to the TextBox
                        ERInvoiceTotalSumCalc.Text = totalSum.ToString();
                    }


                }

            }

            string orderOne = ERorderIDTextBox.Text;

            Order order = Program.seekOrder(orderOne);

            if (order != null)
            {

                foreach (OrderedProduct orderedProduct in Program.OrderedProducts)
                {
                    if (order.OrderID == orderedProduct.Order.OrderID)
                    {
                        // Retrieve the product details
                        string skuCode = orderedProduct.Product.SkuCode;
                        string productName = orderedProduct.Product.ProductName;
                        double price = orderedProduct.Product.Price;
                        int amount = orderedProduct.Amount;
                        double overallPrice = price * amount;

                        DataGridViewRow newRow = new DataGridViewRow();
                        newRow.CreateCells(ERordergrid);

                        // Add a new row to the ERgridInvoice DataGridView with the product details
                        ERordergrid.Rows.Add(skuCode, productName, price, amount, overallPrice);



                        double totalSum = 0;

                        foreach (DataGridViewRow row in ERordergrid.Rows)
                        {
                            // Get the value from the last column of the row
                            if (row.Cells[ERordergrid.Columns.Count - 1].Value != null && double.TryParse(row.Cells[ERordergrid.Columns.Count - 1].Value.ToString(), out double value))
                            {
                                // Accumulate the sum
                                totalSum += value;
                            }
                        }
                        EROrderTotalSumCalc.Text = totalSum.ToString();


                    }
                }

                double final = double.Parse(ERInvoiceTotalSumCalc.Text) - double.Parse(EROrderTotalSumCalc.Text);
                ERtotalExceptioncalc.Text = final.ToString();

                // Assuming you have three DataGridViews named ERgridInvoice, ERordergrid, and ERexceptionPerProduct

                ERexceptionPerProduct.Rows.Clear(); // Clear the existing rows in ERexceptionPerProduct DataGridView

                int rowCount = Math.Min(ERgridInvoice.Rows.Count, ERordergrid.Rows.Count);

                for (int i = 0; i < rowCount; i++)
                {
                    // Get the overallPrice values from each DataGridView
                    string invoicePrice = ERgridInvoice.Rows[i].Cells["overallPrice"].Value?.ToString();
                    string orderPrice = ERordergrid.Rows[i].Cells["dataGridViewTextBoxColumn5"].Value?.ToString();

                    // Parse the overallPrice values to double
                    double invoicePriceValue, orderPriceValue;
                    bool invoicePriceParsed = double.TryParse(invoicePrice, out invoicePriceValue);
                    bool orderPriceParsed = double.TryParse(orderPrice, out orderPriceValue);

                    if (invoicePriceParsed && orderPriceParsed && invoicePriceValue != orderPriceValue)
                    {
                        // Prices are different
                        string skuCode = ERgridInvoice.Rows[i].Cells["skuCode"].Value?.ToString();
                        double priceDifference = invoicePriceValue - orderPriceValue;

                        // Add the SKU code and price difference to ERexceptionPerProduct DataGridView
                        ERexceptionPerProduct.Rows.Add(skuCode, priceDifference);
                    }
                }



            }




        }
        private void CreateAnExceptionReport_Load(object sender, EventArgs e)
        {
            
        }


        private void ERgridInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            // Clear the existing rows in the ERgridInvoice DataGridView
            ERgridInvoice.Rows.Clear();

            // Retrieve the invoice ID from the ERInvoiceIDTextBox
            string invoiceID = ERInvoiceIDTextBox.Text;

            // Retrieve the invoice by the invoice ID
            Invoice invoice = Program.seekInvoice(invoiceID);

            // Check if the invoice is found
            if (invoice != null)
            {
                // Loop through each product invoice in the invoice
                foreach (ProductInvoice productInvoice in Program.productInvoices)
                {
                    // Retrieve the product details
                    string skuCode = productInvoice.Product.SkuCode;
                    string productName = productInvoice.Product.ProductName;
                    double price = productInvoice.Product.Price;
                    int amount = productInvoice.Amount;
                    double overallPrice = price * amount;

                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(ERgridInvoice);

                    // Add a new row to the ERgridInvoice DataGridView with the product details
                    //ERgridInvoice.Rows.Add(skuCode, productName, price, amount, overallPrice);
                    newRow.Cells[0].Value = skuCode;
                    newRow.Cells[1].Value = productName;
                    newRow.Cells[2].Value = price;
                    newRow.Cells[3].Value = amount;
                    newRow.Cells[4].Value = overallPrice;
                }
            }

            //// Allow user input in the DataGridView cells
            //ERgridInvoice.ReadOnly = false;

            //string selectedValue = ERInvoiceIDTextBox.Text; 


            //foreach (ProductInvoice proInv in Program.productInvoices)
            //{
            //    if (proInv.Invoice.InvoiceID == selectedValue)
            //    {
            //        {
            //            DataGridViewRow row = new DataGridViewRow();
            //            row.CreateCells(ERgridInvoice, proInv.Product.SkuCode, proInv.PricePerUnit, proInv.Amount);
            //            ERgridInvoice.Rows.Add(row);


            //        }


            //    }

            //}

        }
        //-----------------------------------------------------------


        //-------------------------------------------------------

        private void ERordergrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ERtotalExceptioncalc_TextChanged(object sender, EventArgs e)
        {

        }

        private void ERtotalExceptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void ERbackArrow_Click(object sender, EventArgs e)
        {

        }

        private void ERbackButton_Click(object sender, EventArgs e)
        {
            CreateInvoiceForm cif = new CreateInvoiceForm();
            cif.Show();
            this.Hide();
        }

        private void ERtotalPriceOrderlabel_Click(object sender, EventArgs e)
        {

        }

        private void EROrderTotalSumCalc_TextChanged(object sender, EventArgs e)
        {

        }

        private void ERtotalPriceInvoicelabel_Click(object sender, EventArgs e)
        {

        }

        private void ERInvoiceTotalSumCalc_TextChanged(object sender, EventArgs e)
        {

        }

        private void ERexceptionPerProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ERheadline_Click(object sender, EventArgs e)
        {

        }

        private void ERorderIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ERInvoiceIDTextBox_TextChanged(object sender, EventArgs e)
        {



        }

        private void ERinvoiceID_Click(object sender, EventArgs e)
        {

        }

        private void ERorderID_Click(object sender, EventArgs e)
        {

        }

        private void generateReportButton_Click(object sender, EventArgs e)
        {
            Invoice enteredInvoice = Program.seekInvoice(ERInvoiceIDTextBox.Text);
            if (enteredInvoice != null)
            {
                Order receivedOrder = Program.seekOrder(enteredInvoice.Order.OrderID);
                ERorderIDTextBox.Text = receivedOrder.OrderID;
            }


           

            // Retrieve the invoice ID from the ERInvoiceIDTextBox
            string invoiceID = ERInvoiceIDTextBox.Text;

            // Retrieve the invoice by the invoice ID
            Invoice invoice = Program.seekInvoice(invoiceID);

            // Check if the invoice is found
            if (invoice != null)
            {
                // Loop through each product invoice in the invoice
                foreach (ProductInvoice productInvoice in Program.productInvoices)
                {
                    if (invoice.InvoiceID == productInvoice.Invoice.InvoiceID)
                    {
                        // Retrieve the product details
                        string skuCode = productInvoice.Product.SkuCode;
                        string productName = productInvoice.Product.ProductName;
                        double price = productInvoice.Product.Price;
                        int amount = productInvoice.Amount;
                        double overallPrice = price * amount;

                        DataGridViewRow newRow = new DataGridViewRow();
                        newRow.CreateCells(ERgridInvoice);

                        // Add a new row to the ERgridInvoice DataGridView with the product details
                        ERgridInvoice.Rows.Add(skuCode, productName, price, amount, overallPrice);

                        double totalSum = 0;

                        foreach (DataGridViewRow row in ERgridInvoice.Rows)
                        {
                            // Get the "overallPrice" value from the row
                            if (row.Cells["overallPrice"].Value != null && double.TryParse(row.Cells["overallPrice"].Value.ToString(), out double totalPrice))
                            {
                                // Accumulate the sum
                                totalSum += totalPrice;
                            }
                        }

                        // Set the sum value to the TextBox
                        ERInvoiceTotalSumCalc.Text = totalSum.ToString();
                    }


                }

            }

            string orderOne = ERorderIDTextBox.Text;

            Order order = Program.seekOrder(orderOne);

            if (order != null)
            {

                foreach (OrderedProduct orderedProduct in Program.OrderedProducts)
                {
                    if (order.OrderID == orderedProduct.Order.OrderID)
                    {
                        // Retrieve the product details
                        string skuCode = orderedProduct.Product.SkuCode;
                        string productName = orderedProduct.Product.ProductName;
                        double price = orderedProduct.Product.Price;
                        int amount = orderedProduct.Amount;
                        double overallPrice = price * amount;

                        DataGridViewRow newRow = new DataGridViewRow();
                        newRow.CreateCells(ERordergrid);

                        // Add a new row to the ERgridInvoice DataGridView with the product details
                        ERordergrid.Rows.Add(skuCode, productName, price, amount, overallPrice);

                      

                        double totalSum = 0;

                        foreach (DataGridViewRow row in ERordergrid.Rows)
                        {
                            // Get the value from the last column of the row
                            if (row.Cells[ERordergrid.Columns.Count - 1].Value != null && double.TryParse(row.Cells[ERordergrid.Columns.Count - 1].Value.ToString(), out double value))
                            {
                                // Accumulate the sum
                                totalSum += value;
                            }
                        }
                        EROrderTotalSumCalc.Text = totalSum.ToString();


                    }
                }

                double final = double.Parse(ERInvoiceTotalSumCalc.Text) - double.Parse(EROrderTotalSumCalc.Text);
                ERtotalExceptioncalc.Text = final.ToString();

                // Assuming you have three DataGridViews named ERgridInvoice, ERordergrid, and ERexceptionPerProduct

                ERexceptionPerProduct.Rows.Clear(); // Clear the existing rows in ERexceptionPerProduct DataGridView

                int rowCount = Math.Min(ERgridInvoice.Rows.Count, ERordergrid.Rows.Count);

                for (int i = 0; i < rowCount; i++)
                {
                    // Get the overallPrice values from each DataGridView
                    string invoicePrice = ERgridInvoice.Rows[i].Cells["overallPrice"].Value?.ToString();
                    string orderPrice = ERordergrid.Rows[i].Cells["dataGridViewTextBoxColumn5"].Value?.ToString();

                    // Parse the overallPrice values to double
                    double invoicePriceValue, orderPriceValue;
                    bool invoicePriceParsed = double.TryParse(invoicePrice, out invoicePriceValue);
                    bool orderPriceParsed = double.TryParse(orderPrice, out orderPriceValue);

                    if (invoicePriceParsed && orderPriceParsed && invoicePriceValue != orderPriceValue)
                    {
                        // Prices are different
                        string skuCode = ERgridInvoice.Rows[i].Cells["skuCode"].Value?.ToString();
                        double priceDifference = invoicePriceValue - orderPriceValue;

                        // Add the SKU code and price difference to ERexceptionPerProduct DataGridView
                        ERexceptionPerProduct.Rows.Add(skuCode, priceDifference);
                    }
                }


            }


        }
        public void SetERorderIDContent(string content)
        {
            ERorderIDTextBox.Text = content;
        }

        public void SetEInvoiceIDContent(string content)
        {
            ERInvoiceIDTextBox.Text = content;
        }

        public void PopulateInvoiceGrid(string content) //
        {
            ERInvoiceIDTextBox.Text = content;
        }

        public void PopulateOrderGrid(string content) //
        {
            ERInvoiceIDTextBox.Text = content;
        }

        private void createPdfButton_Click(object sender, EventArgs e)
        {
            // Create a new PDF document
            Document document = new Document();

            // Create a new PDF writer
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\exceptionReport.pdf", FileMode.Create));

            // Open the PDF document
            document.Open();

            // Add content to the document

            // Add a title to the document
            string titleText = "Exception Report For Invoice: " + ERInvoiceIDTextBox.Text;
            BaseFont baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
            iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 18, iTextSharp.text.Font.BOLD);
            Paragraph title = new Paragraph(titleText, font);
            title.Alignment = Element.ALIGN_CENTER;
            document.Add(title);

            // Take a screenshot of the form
            Bitmap screenshot = new Bitmap(this.Width, this.Height);
            Graphics graphics = Graphics.FromImage(screenshot);
            graphics.CopyFromScreen(this.Location, Point.Empty, this.Size);

            // Convert the screenshot to an iTextSharp image
            iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(screenshot, System.Drawing.Imaging.ImageFormat.Jpeg);

            // Set the alignment and size of the image
            image.Alignment = Element.ALIGN_MIDDLE;
            image.ScaleToFit(500, 500);

            // Add the image to the document
            document.Add(image);

            // Close the PDF document
            document.Close();

            MessageBox.Show("PDF generated successfully.");
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
