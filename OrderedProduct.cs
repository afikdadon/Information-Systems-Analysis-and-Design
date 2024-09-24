using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Group_1
{
    public class OrderedProduct
    {
        private Order order;
        private Product product;
        private int amount;



        public OrderedProduct(Order order, Product product, int amount, bool is_new)
        {
            this.order = order;
            this.product = product;
            this.amount = amount;

            if (is_new)
            {
                this.createOrderedProduct();
                Program.OrderedProducts.Add(this);
            }

        }


        public Order Order { get => order; set => order = value; }
        public Product Product { get => product; set => product = value; }
        public int Amount { get => amount; set => amount = value; }


        public void createOrderedProduct()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_orderedProduct @orderID , @skuCode , @amount ";
            c.Parameters.AddWithValue("@orderID", this.order.OrderID);
            c.Parameters.AddWithValue("@skuCode", this.product.SkuCode);
            c.Parameters.AddWithValue("@amount", this.amount);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }



    }
}
