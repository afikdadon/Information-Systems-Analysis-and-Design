using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Group_1
{
    public class Order
    {
        private string orderID;
        private DateTime date;
        private OrderStatus orderStatus;
        private Supplier supplier;
        private Project project;
        private Invoice invoice;
        private List<OrderedProduct> orderedProducts;


        public Order(string orderID, DateTime date, OrderStatus orderStatus, Supplier supplier, Project project, Invoice invoice,bool is_new)
        {
            this.orderID = orderID;
            this.date = date;
            this.orderStatus = orderStatus;
            this.supplier = supplier;
            this.project = project;
            this.invoice = invoice;
            this.orderedProducts = new List<OrderedProduct>();

            if (is_new)
            {
                this.createOrder();
                Program.Orders.Add(this);
            }
        }
      
        public string OrderID { get => orderID; set => orderID = value; }
        public DateTime Date { get => date; set => date = value; }
        public OrderStatus OrderStatus { get => orderStatus; set => orderStatus = value; }
        public Project Project { get => project; set => project = value; }
        public Supplier Supplier { get => supplier; set => supplier = value; }
        public Invoice Invoice { get => invoice; set => invoice = value; }
        public List<OrderedProduct> OrderedProducts { get => orderedProducts; set => orderedProducts = value; }

        public void createOrder()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_order @orderID, @date, @orderStatus, @supplierBn,@projectName";
            c.Parameters.AddWithValue("@orderID", this.orderID);
            c.Parameters.AddWithValue("@date", this.date);
            c.Parameters.AddWithValue("@orderStatus", this.orderStatus.ToString());
            c.Parameters.AddWithValue("@SupplierBn", this.Supplier.SupplierBn);
            c.Parameters.AddWithValue("@ProjectName", this.Project.ProjectName);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }








    }






}
