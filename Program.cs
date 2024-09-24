using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Net;

namespace Group_1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static System.Collections.Generic.List<Employee> Employees;
        public static System.Collections.Generic.List<Employee> archiveEmployee;
        public static System.Collections.Generic.List<Product> Products;
        public static System.Collections.Generic.List<Product> archiveProduct;
        public static System.Collections.Generic.List<Supplier> Suppliers;
        public static System.Collections.Generic.List<Supplier> archiveSupplier;
        public static System.Collections.Generic.List<Task> Tasks;
        public static System.Collections.Generic.List<Order> Orders;
        public static System.Collections.Generic.List<Invoice> Invoices;
        public static System.Collections.Generic.List<Project> Projects;
        public static System.Collections.Generic.List<Stage> Stages;
        public static System.Collections.Generic.List<OrderedProduct> OrderedProducts;
        public static System.Collections.Generic.List<ProductInvoice> productInvoices;



        [STAThread]


        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            initLists();
            //Application.Run(new ProjectForm());
           Application.Run(new LogInForm());
            //Application.Run(new createOrderForm());
         
        }


        // filling the lists from the DB
        public static void initLists()
        {
            init_employee();
            init_archiveEmployee();
            init_project();
            init_supplier();
            init_archiveSupplier();
            init_task();          
            init_order();
            init_product();
            init_archiveProduct();
            init_invoice();
            init_stage();
            init_orderedProduct();
            init_productInvoice();
        }


        //------------------------EMPLOYEE---------------------


        // filing an array with data
        public static void init_employee()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Employees";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Employees = new List<Employee>();
           

            while (rdr.Read())
            {
                Gender G = (Gender)Enum.Parse(typeof(Gender), rdr.GetValue(3).ToString());
                EmployeeType ET = (EmployeeType)Enum.Parse(typeof(EmployeeType), rdr.GetValue(8).ToString());
                AvailabilityStatus AS = (AvailabilityStatus)Enum.Parse(typeof(AvailabilityStatus), rdr.GetValue(11).ToString());
                int load = 0;
                Employee e = new Employee(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), G, rdr.GetValue(4).ToString(),
                    rdr.GetValue(5).ToString(), rdr.GetValue(6).ToString(), (DateTime)rdr.GetValue(7), ET, rdr.GetValue(9).ToString(), (DateTime)rdr.GetValue(10), AS, load, false);
                Employees.Add(e);
            }
        }

        // returns employee by his id number
        public static Employee seekEmployee(string id)
        {
            foreach (Employee e in Employees)
            {
                if (e.Id == id)
                {
                    return e;
                }
            }
            return null;
        }

        // returns employee by his id number
        public static Employee seekEmployeeByEmployeeId(string employeeId)
        {
            foreach (Employee e in Employees)
            {
                if (e.EmployeeId == employeeId)
                {
                    return e;
                }
            }
            return null;
        }

        public static bool isIdEmployeeExists (string id)  //true if the employee id is exists
        {
            foreach (Employee e in Employees)
            {
                if (e.Id == id)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool isEmployeeExistsByEmployeeId(string employeeId)  //true if the employee id is exists
        {
            foreach (Employee e in Employees)
            {
                if (e.EmployeeId == employeeId)
                {
                    return true;
                }
            }
            return false;
        }


        public static void init_archiveEmployee() //intial archive employees from the DB
        {

            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Employees_archive";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            archiveEmployee = new List<Employee>();

            while (rdr.Read())
            {
                Gender G = (Gender)Enum.Parse(typeof(Gender), rdr.GetValue(3).ToString());
                EmployeeType ET = (EmployeeType)Enum.Parse(typeof(EmployeeType), rdr.GetValue(8).ToString());
                AvailabilityStatus AS = (AvailabilityStatus)Enum.Parse(typeof(AvailabilityStatus), rdr.GetValue(11).ToString());
                int load = 0;
                Employee e = new Employee(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), G, rdr.GetValue(4).ToString(),
                    rdr.GetValue(5).ToString(), rdr.GetValue(6).ToString(), (DateTime)rdr.GetValue(7), ET, rdr.GetValue(9).ToString(), (DateTime)rdr.GetValue(10), AS, load, false);
                archiveEmployee.Add(e);
            }
        }


        //------------------------TASK----------------------

        // filing an array with data
        public static void init_task()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Get_all_tasks";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Tasks = new List<Task>();


            while (rdr.Read())
            {
                Status TS = (Status)Enum.Parse(typeof(Status), rdr.GetValue(5).ToString());
                ClassificationType C = (ClassificationType)Enum.Parse(typeof(ClassificationType), rdr.GetValue(4).ToString());
                Employee E = seekEmployee(rdr.GetValue(6).ToString());

                Task t = new Task(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), (DateTime)rdr.GetValue(2), (DateTime)rdr.GetValue(3), C, TS, E, rdr.GetValue(7).ToString(), false);
                Tasks.Add(t);
                E.Tasks.Add(t);
            }

        }

        public static void sendEmailTask(MailAddress receiver)
        {
            string fromMail = "galtamsystem@gmail.com"; //sender
            string fromPassword = "vrvkjxhtmohjgyix";

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(fromMail);
            mail.Subject = "You Have a New Task";
            mail.To.Add(receiver); // receiver
            mail.Body = "<html><body> Dear employee, a new task has been added for you, dont miss it. Thank you! </body></html>";
            mail.IsBodyHtml = true;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true,
            };

            smtpClient.Send(mail);
        }

        //------------------------PROJECT----------------------

        public static void init_project()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_projects";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Projects = new List<Project>();

            while (rdr.Read())
            {
                Project p = new Project(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), false);
                Projects.Add(p);
            }
        }

        public static Project seekProject(string name)
        {
            foreach (Project p in Projects)
            {
                if (p.ProjectName == name)
                {
                    return p;
                }
            }
            return null;
        }

        public static bool isProjectExists(string name)
        {
            foreach (Project p in Projects)
            {
                if (p.ProjectName == name)
                {
                    return true;
                }
            }
            return false;
        }


        //------------------------STAGE----------------------

        public static void init_stage()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE  dbo.Get_all_stages";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Stages = new List<Stage>();

            while (rdr.Read())
            {
                StageType st = (StageType)Enum.Parse(typeof(StageType), rdr.GetValue(1).ToString());
                Status s = (Status)Enum.Parse(typeof(Status), rdr.GetValue(3).ToString());
                Project p = seekProject(rdr.GetValue(4).ToString());

                Stage stage = new Stage(rdr.GetValue(0).ToString(), st, (DateTime)rdr.GetValue(2), s, p, false);
                Stages.Add(stage);
                p.ProjectStages.Add(stage);
            }
        }

        public static Stage seekStage(string name)
        {
            foreach(Stage s in Stages)
            {
                if (s.StageName.Equals(name))
                {
                    return s;
                }
            }
            return null;
        }

        //------------------------SUPPLIER----------------------

        public static void init_supplier()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_suppliers";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Suppliers = new List<Supplier>();

            while (rdr.Read())
            {
                Supplier s = new Supplier(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), false);
                Suppliers.Add(s);
            }
        }


        public static Supplier seekSupplier(string BN)
        {
            foreach (Supplier s in Suppliers)
            {
                if (s.SupplierBn == BN)
                {
                    return s;
                }
            }
            return null;
        }

        public static string seekSupplierByName(string name)
        {
            foreach (Supplier s in Suppliers)
            {
                if (s.SupplierName == name)
                {
                    return s.SupplierBn;
                }
            }
            return null;
        }


        public static bool isBnSupplierExists(string Bn)  //true if the supplier Bn is exists
        {
            foreach (Supplier s in Suppliers)
            {
                if (s.SupplierBn == Bn)
                {
                    return true;
                }
            }
            return false;
        }


        public static void init_archiveSupplier()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_suppliers_archive";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            archiveSupplier = new List<Supplier>();

            while (rdr.Read())
            {
                Supplier s = new Supplier(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), false);
                archiveSupplier.Add(s);
            }
        }


        //------------------------ORDER----------------------
        public static void init_order()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_orders";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Orders = new List<Order>();

            while (rdr.Read())
            {
                OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), rdr.GetValue(2).ToString());

                Supplier s = seekSupplier(rdr.GetValue(3).ToString());
                Project p = seekProject(rdr.GetValue(4).ToString());

                Order o = new Order(rdr.GetValue(0).ToString(), (DateTime)rdr.GetValue(1),os,s,p,null, false);
                Orders.Add(o);
                s.SupplierOrders.Add(o);
                p.ProjectOrders.Add(o);
            }
        }

            public static Order seekOrder(string orderID)
        {
            foreach (Order o in Orders)
            {
                if (o.OrderID == orderID)
                {
                    return o;
                }

            }
            return null;
        }


        public static bool isIdOrderExists(string id)  //true if the order id is exists
        {
            foreach (Order o in Orders)
            {
                if (o.OrderID == id)
                {
                    return true;
                }
            }
            return false;
        }

        

        //------------------------PRODUCT----------------------

        public static void init_product() //intial products from the DB
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_products";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Products = new List<Product>();

            while (rdr.Read())
            {
                Supplier s = seekSupplier(rdr.GetValue(3).ToString());
                Product p = new Product(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetDouble(2), s, false);
                Products.Add(p);
                s.SupplierProducts.Add(p);

            }

        }

        public static Product seekProduct(string skuCode)
        {
            foreach (Product p in Products)
            {
                if (p.SkuCode == skuCode)
                {
                    return p;
                }
            }
            return null;
        }

        public static bool isSkuCodeExists(string skuCode)  //true if the product id is exists
        {
            foreach (Product p in Products)
            {
                if (p.SkuCode == skuCode)
                {
                    return true;
                }
            }
            return false;
        }

        public static void init_archiveProduct()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Products_Archive";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            archiveProduct = new List<Product>();

            while (rdr.Read())
            {
                Supplier s = seekSupplier(rdr.GetValue(3).ToString());
                Product p = new Product(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetDouble(2), s, false);
                archiveProduct.Add(p);
            }
        }


        //------------------------ORDER_PRODUCT----------------------

        public static void init_orderedProduct()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_orderedProducts";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            OrderedProducts = new List<OrderedProduct>();

            while (rdr.Read())
            {
                Order OOP = seekOrder(rdr.GetValue(0).ToString());

                Product POP = seekProduct(rdr.GetValue(1).ToString());

                OrderedProduct op = new OrderedProduct(OOP, POP, (int)rdr.GetValue(2), false);
                OrderedProducts.Add(op);
                OOP.OrderedProducts.Add(op);
                POP.OrderedProducts1.Add(op);
            }
        }

        

        //------------------------INVOICE----------------------

        public static void init_invoice()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_invoices";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Invoices = new List<Invoice>();

            while (rdr.Read())
            {
                Invoicestatus IS = (Invoicestatus)Enum.Parse(typeof(Invoicestatus), rdr.GetValue(2).ToString());

                Order o = seekOrder(rdr.GetValue(3).ToString());

                Invoice i = new Invoice(rdr.GetValue(0).ToString(), (DateTime)rdr.GetValue(1), IS, o, false);

                Invoices.Add(i);
                o.Invoice = i;
            }
        }

        public static Invoice seekInvoice(string invoiceID)
        {
            foreach (Invoice i in Invoices)
            {
                if (i.InvoiceID == invoiceID)
                {
                    return i;
                }

            }
            return null;
        }

        //--------------------------productInvoice
        public static void init_productInvoice() //
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_productInvoices";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            productInvoices = new List<ProductInvoice>();

            while (rdr.Read())
            {
                Invoice Inv = seekInvoice(rdr.GetValue(1).ToString());

                Product Pro = seekProduct(rdr.GetValue(0).ToString());

                ProductInvoice pi = new ProductInvoice(Pro, Inv, double.Parse(rdr.GetValue(2).ToString()), Convert.ToInt32(rdr.GetValue(3).ToString()), false);
                productInvoices.Add(pi);
                Pro.ProductInvoice1.Add(pi);
            }
        }


        //------------------------OTHER FUNCTION----------------------


        public static bool isThereAChar(string str) //false if the string is only numbers
        {
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                    return true;
            }
            return false;
        }

        

        public static bool IsEmailValid(string email)
        {
            var emailPattern = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                               @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                               @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

            return Regex.IsMatch(email, emailPattern);
        }



        public static string AddSpacesBeforeCaps(string input)
        {
            string output = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (i > 0 && char.IsUpper(input[i]))
                {
                    output += " ";
                }

                output += input[i];
            }

            return output;
        }
        

        public static bool containsNumbers(string input) //return true if the string contains numbers or false if it doesn't
        {
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }


    }
}
