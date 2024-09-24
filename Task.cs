using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Group_1
{
    public class Task
    {
        private static int idCounter = 16;
        private string taskID;
        private string taskName;
        private DateTime start;
        private DateTime end;
        private ClassificationType classification;
        private Status taskStatus;
        private string note;
        private Employee employee;
       
        

        public Task(string taskID, string taskName, DateTime start, DateTime end, ClassificationType classification, Status taskStatus, Employee employee, string note, bool is_new)
        {
            this.taskName = taskName;
            this.start = start;
            this.end = end;
            this.classification = classification;
            this.taskStatus = taskStatus;
            this.employee = employee;
            this.note = note;
            
            if (is_new)
            {
                this.taskID = idCounter.ToString();
                this.createTask();
                Program.Tasks.Add(this);
                idCounter++;
            }
            else this.taskID = taskID;



        }

        public string TaskID { get => taskID; set => taskID = value; }
        public string TaskName { get => taskName; set => taskName = value; }
        public DateTime Start { get => start; set => start = value; }
        public DateTime End { get => end; set => end = value; }
        public ClassificationType Classification { get => classification; set => classification = value; }
        public Status TaskStatus { get => taskStatus; set => taskStatus = value; }
        public Employee Employee { get => employee; set => employee = value; }

        

    public void createTask()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_task @taskID, @taskName, @start, @end, @classification, @taskStatus, @responsibleEmployee, @note";
            c.Parameters.AddWithValue("@taskID", this.taskID);
            c.Parameters.AddWithValue("@taskName", this.taskName);
            c.Parameters.AddWithValue("@start", this.start);
            c.Parameters.AddWithValue("@end", this.end);
            c.Parameters.AddWithValue("@classification", this.classification.ToString());
            c.Parameters.AddWithValue("@taskStatus", this.taskStatus.ToString());
            c.Parameters.AddWithValue("@responsibleEmployee", this.employee.Id);
            c.Parameters.AddWithValue("@note", this.note);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

    }
}
