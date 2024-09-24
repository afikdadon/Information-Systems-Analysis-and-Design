using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_1
{
    public class Project
    {
        private string projectName;
        private string city;
        private string address;
        private System.Collections.Generic.List<Stage> projectStages;
        private System.Collections.Generic.List<Order> projectOrders;


        public Project(string projectName, string city, string address, bool is_new)
        {
            this.projectName = projectName;
            this.city = city;
            this.address = address;

            this.projectStages = new List<Stage>();
            this.projectOrders = new List<Order>();

            if (is_new)
            {
                this.createProject();
                Program.Projects.Add(this);
            }

        }

        public string ProjectName { get => projectName; set => projectName = value; }
        public string City { get => city; set => city = value; }
        public string Address { get => address; set => address = value; }
        public List<Order> ProjectOrders { get => projectOrders; set => projectOrders = value; }
        public List<Stage> ProjectStages { get => projectStages; set => projectStages = value; }

        public void createProject()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_project @projectName, @city , @address ";
            c.Parameters.AddWithValue("@projectName", this.projectName);
            c.Parameters.AddWithValue("@city", this.city);
            c.Parameters.AddWithValue("@address", this.address);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }
}
