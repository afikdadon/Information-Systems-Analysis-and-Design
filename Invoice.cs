using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Group_1
{
    public class Invoice
    {
        private string invoiceID;
        private DateTime date;
        private Invoicestatus invoicestatus;
        private Order order;
        private List<ProductInvoice> productInvoices;



        public Invoice(string invoiceID, DateTime date, Invoicestatus invoicestatus, Order order, bool is_new)
        {
            this.invoiceID = invoiceID;
            this.date = date;
            this.invoicestatus = invoicestatus;
            this.order = order;
            this.productInvoices = new List<ProductInvoice>();


            if (is_new)
            {
                this.createInvoice();
                Program.Invoices.Add(this);
            }

        }

        public string InvoiceID { get => invoiceID; set => invoiceID = value; }
        public DateTime Date { get => date; set => date = value; }
        public Invoicestatus Invoicestatus { get => invoicestatus; set => invoicestatus = value; }
        public Order Order { get => order; set => order = value; }

        public void createInvoice()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_invoice @invoiceID , @date , @invoicestatus , @orderID ";
            c.Parameters.AddWithValue("@invoiceID", this.invoiceID);
            c.Parameters.AddWithValue("@date", this.date);
            c.Parameters.AddWithValue("@invoicestatus", this.invoicestatus.ToString());
            c.Parameters.AddWithValue("@orderID", this.order.OrderID);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }
}
