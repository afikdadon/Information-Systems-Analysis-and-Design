using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_1
{
    public class Product
    {
        private string skuCode;
        private string productName;
        private double price;
        private string productNamePrice;//A field intended for visual display
        private Supplier supplier;
        private System.Collections.Generic.List<OrderedProduct> OrderedProducts;
        private System.Collections.Generic.List<ProductInvoice> ProductInvoice;

       

        public Product(string skuCode, string productName, double price, Supplier supplier, bool is_new)
        {
            this.skuCode = skuCode;
            this.productName = productName;
            this.price = price;
            this.supplier = supplier;
            this.productNamePrice = this.productName + " " + ", Price Per Unit: " + this.price;

            this.OrderedProducts = new List<OrderedProduct>();
            this.ProductInvoice = new List<ProductInvoice>();


            if (is_new)
            {
                this.createProduct();
                Program.Products.Add(this);
            }
        }

        public string SkuCode { get => skuCode; set => skuCode = value; }
        public string ProductName { get => productName; set => productName = value; }
        public double Price { get => price; set => price = value; }
        public string ProductNamePrice { get => productNamePrice; set => productNamePrice = value; }
        public Supplier Supplier { get => supplier; set => supplier = value; }
        public List<OrderedProduct> OrderedProducts1 { get => OrderedProducts; set => OrderedProducts = value; }
        internal List<ProductInvoice> ProductInvoice1 { get => ProductInvoice; set => ProductInvoice = value; }

        public void createProduct()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_product @skuCode, @productName , @price, @supplierBn";
            c.Parameters.AddWithValue("@skuCode", this.skuCode);
            c.Parameters.AddWithValue("@productName", this.productName);
            c.Parameters.AddWithValue("@price", this.price);
            c.Parameters.AddWithValue("@supplierBn", this.supplier.SupplierBn);


            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void updateProduct()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_product @skuCode , @productName, @price, @supplierBn";
            c.Parameters.AddWithValue("@skuCode", this.skuCode);
            c.Parameters.AddWithValue("@productName", this.productName);
            c.Parameters.AddWithValue("@price", this.price);
            c.Parameters.AddWithValue("@supplierBn", this.supplier.SupplierBn);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void moveProductToArchive()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_move_archive_product @skuCode, @productName, @price, @supplierBn; " +
                "EXECUTE dbo.SP_delete_product @skuCode";
            c.Parameters.AddWithValue("@skuCode", this.skuCode);
            c.Parameters.AddWithValue("@productName", this.productName);
            c.Parameters.AddWithValue("@price", this.price);
            c.Parameters.AddWithValue("@supplierBn", this.supplier.SupplierBn);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
            Program.Products.Remove(this);
            Program.archiveProduct.Add(this);
        }
    }
}