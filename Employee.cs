using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Group_1
{
    public class Employee
    {
        private string id;
        private string firstName;
        private string lastName;
        private Gender gender;
        private string phoneNumber;
        private string email;
        private string address;
        private DateTime birthdate;
        private EmployeeType employeeType;
        private string employeeId;
        private DateTime startWorkingDate;
        private AvailabilityStatus status;
        private int load; // number of open tasks
        private System.Collections.Generic.List<Task> tasks;
        private string fullNameLoad; //A field intended for visual display

        public Employee(string id, string firstName, string lastName, Gender gender, string phoneNumber, string email,string address, 
                        DateTime birthdate, EmployeeType employeeType, string employeeId, DateTime startWorkingDate, AvailabilityStatus status, int load, bool is_new)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.address = address;
            this.birthdate = birthdate;
            this.employeeType = employeeType;
            this.employeeId = employeeId;
            this.startWorkingDate = startWorkingDate;
            this.status = status;
            this.load = load;
            this.fullNameLoad = this.firstName + " " + this.lastName + ", עומס: " + this.load;
            this.tasks = new List<Task>();

            if (is_new)
            {
                this.createEmployee();
                Program.Employees.Add(this);
            }
        }

        public string Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public Gender Gender { get => gender; set => gender = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public DateTime Birthdate { get => birthdate; set => birthdate = value; }
        public EmployeeType EmployeeType { get => employeeType; set => employeeType = value; }
        public string EmployeeId { get => employeeId; set => employeeId = value; }
        public DateTime StartWorkingDate { get => startWorkingDate; set => startWorkingDate = value; }
        public AvailabilityStatus Status { get => status; set => status = value; }
        public int Load { get => load; set => load = value; }
        public string FullNameLoad { get => fullNameLoad; set => fullNameLoad = value; }
        public List<Task> Tasks { get => tasks; set => tasks = value; }

        public void createEmployee()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_employee @id , @firstName , @lastName , @gender, @phoneNumber, @email, @address, @birthDate, @employeeType, @employeeID, @startWorkingDate, @status";
            c.Parameters.AddWithValue("@id", this.id);
            c.Parameters.AddWithValue("@firstName", this.firstName);
            c.Parameters.AddWithValue("@lastName", this.lastName);
            c.Parameters.AddWithValue("@gender", this.gender.ToString());
            c.Parameters.AddWithValue("@phoneNumber", this.phoneNumber);
            c.Parameters.AddWithValue("@email", this.email);
            c.Parameters.AddWithValue("@address", this.address);
            c.Parameters.AddWithValue("@birthdate", this.birthdate);
            c.Parameters.AddWithValue("@employeeType", this.employeeType.ToString());
            c.Parameters.AddWithValue("@employeeId", this.employeeId);
            c.Parameters.AddWithValue("@startWorkingDate", this.startWorkingDate);
            c.Parameters.AddWithValue("@status", this.status.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void updateEmployee()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_employees @id , @firstName , @lastName , @gender, @phoneNumber, @email, @address, @birthDate, @employeeType, @employeeID, @startWorkingDate, @status";
            c.Parameters.AddWithValue("@id", this.id);
            c.Parameters.AddWithValue("@firstName", this.firstName);
            c.Parameters.AddWithValue("@lastName", this.lastName);
            c.Parameters.AddWithValue("@gender", this.gender.ToString());
            c.Parameters.AddWithValue("@phoneNumber", this.phoneNumber);
            c.Parameters.AddWithValue("@email", this.email);
            c.Parameters.AddWithValue("@address", this.address);
            c.Parameters.AddWithValue("@birthdate", this.birthdate);
            c.Parameters.AddWithValue("@employeeType", this.employeeType.ToString());
            c.Parameters.AddWithValue("@employeeId", this.employeeId);
            c.Parameters.AddWithValue("@startWorkingDate", this.startWorkingDate);
            c.Parameters.AddWithValue("@status", this.status.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);

        }

        public void moveEmployeeToArchive()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_move_archive_employee @id, @firstName, @lastName, @gender, @phoneNumber, @email, @address, @birthDate, @employeeType, @employeeID, @startWorkingDate, @status; " +
                "EXECUTE dbo.SP_delete_employees @id";
            c.Parameters.AddWithValue("@id", this.id);
            c.Parameters.AddWithValue("@firstName", this.firstName);
            c.Parameters.AddWithValue("@lastName", this.lastName);
            c.Parameters.AddWithValue("@gender", this.gender.ToString());
            c.Parameters.AddWithValue("@phoneNumber", this.phoneNumber);
            c.Parameters.AddWithValue("@email", this.email);
            c.Parameters.AddWithValue("@address", this.address);
            c.Parameters.AddWithValue("@birthdate", this.birthdate);
            c.Parameters.AddWithValue("@employeeType", this.employeeType.ToString());
            c.Parameters.AddWithValue("@employeeId", this.employeeId);
            c.Parameters.AddWithValue("@startWorkingDate", this.startWorkingDate);
            c.Parameters.AddWithValue("@status", this.status.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public int checkLoad()
        {
            this.load = 0;
            foreach (Task t in this.tasks)
            {
                if (t.TaskStatus.ToString().Equals("didntStartProgress") || t.TaskStatus.ToString().Equals("inProgress"))
                {
                    this.load++;
                }
            }

            this.fullNameLoad = this.firstName + " " + this.lastName + ", עומס: " + this.load;
            return load;
        }
    }
}
