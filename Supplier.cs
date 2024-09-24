using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_1
{
    public class Supplier
    {
        private string supplierBn;
        private string supplierName;
        private string email;
        private string phoneNumber;
        private string bankAccount;
        private System.Collections.Generic.List<Product> supplierProducts;
        private System.Collections.Generic.List<Order> supplierOrders;


        public Supplier(string supplierBn, string supplierName,string email,string phoneNumber,string bankAccount, bool is_new)
        {
            this.supplierBn = supplierBn;
            this.supplierName = supplierName;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.bankAccount = bankAccount;

            this.supplierProducts = new List<Product>();
            this.supplierOrders = new List<Order>();

            if (is_new)
            {
                this.createSupplier();
                Program.Suppliers.Add(this);
            }
        }


        public string SupplierBn { get => supplierBn; set => supplierBn = value; }
        public string SupplierName { get => supplierName; set => supplierName = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string BankAccount { get => bankAccount; set => bankAccount = value; }
        public List<Product> SupplierProducts { get => supplierProducts; set => supplierProducts = value; }
        public List<Order> SupplierOrders { get => supplierOrders; set => supplierOrders = value; }

        public void createSupplier()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_supplier @supplierBn , @supplierName, @email, @phoneNumber, @bankAccount";
            c.Parameters.AddWithValue("@supplierBn", this.supplierBn);
            c.Parameters.AddWithValue("@supplierName", this.supplierName);
            c.Parameters.AddWithValue("@email", this.supplierName);
            c.Parameters.AddWithValue("@phoneNumber", this.supplierName);
            c.Parameters.AddWithValue("@bankAccount", this.supplierName);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void updateSupplier()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_supplier @supplierBn , @supplierName, @email, @phoneNumber, @bankAccount";
            c.Parameters.AddWithValue("@supplierBn", this.supplierBn);
            c.Parameters.AddWithValue("@supplierName", this.supplierName);
            c.Parameters.AddWithValue("@email", this.supplierName);
            c.Parameters.AddWithValue("@phoneNumber", this.supplierName);
            c.Parameters.AddWithValue("@bankAccount", this.supplierName);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void moveSupplierToArchive()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_move_archive_supplier @supplierBn, @supplierName, @email, @phoneNumber, @bankAccount; " +
                "EXECUTE dbo.SP_delete_supplier @supplierBn";
            c.Parameters.AddWithValue("@supplierBn", this.supplierBn);
            c.Parameters.AddWithValue("@supplierName", this.supplierName);
            c.Parameters.AddWithValue("@email", this.supplierName);
            c.Parameters.AddWithValue("@phoneNumber", this.supplierName);
            c.Parameters.AddWithValue("@bankAccount", this.supplierName);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);

        }
    }
}
