using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Group_1
{
    class ProductInvoice
    {
        private Product product;
        private Invoice invoice;
        private double pricePerUnit;
        private int amount;

        public ProductInvoice(Product product, Invoice invoice, double pricePerUnit, int amount, bool is_new)
        {
            this.product = product;
            this.invoice = invoice;
            this.pricePerUnit = pricePerUnit;
            this.amount = amount;


            if (is_new)
            {
                this.createProductInvoice();
                Program.productInvoices.Add(this);
            }
        }

        public Invoice Invoice { get => invoice; set => invoice = value; }
        public Product Product { get => product; set => product = value; }
        public int Amount { get => amount; set => amount = value; }
        public double PricePerUnit { get => pricePerUnit; set => pricePerUnit = value; }


        public void createProductInvoice()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_productInvoice @skuCode , @invoiceID , @pricePerUnit , @amount ";
            c.Parameters.AddWithValue("@skuCode", this.product.SkuCode);
            c.Parameters.AddWithValue("@invoiceID", this.invoice.InvoiceID);
            c.Parameters.AddWithValue("@pricePerUnit", this.pricePerUnit);
            c.Parameters.AddWithValue("@amount", this.amount);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }




    }
}
