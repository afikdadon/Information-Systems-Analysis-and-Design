using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Group_1
{
    public partial class createTaskForm : Form
    {

        private List<Employee> employeesTask = new List<Employee>();

        public createTaskForm()
        {
            InitializeComponent();
            classificationComboBox.DataSource = Enum.GetValues(typeof(ClassificationType)); // אתחול הקומבובוקס

            foreach (Employee employee in Program.Employees)
            {
                employee.checkLoad();
                employeesTask.Add(employee);
            }


            var sortedEmployees = employeesTask.OrderBy(emp => emp.Load).ToList();

            responsibleComboBox.DataSource = sortedEmployees;
            responsibleComboBox.DisplayMember = "fullNameLoad";

        }

        private void CreateTaskForm_Load(object sender, EventArgs e)
        {

        }

        private void newTaskLabel_Click(object sender, EventArgs e)
        {

        }

        private void createTaskButton_Click(object sender, EventArgs e)
        {

        }

        private void taskLeaderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void subjectTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void taskTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void endDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void startDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {

        }

        private void taskLeaderLabel_Click(object sender, EventArgs e)
        {

        }

        private void taskTypeLabel_Click(object sender, EventArgs e)
        {

        }

        private void endDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void startDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void subjectLabel_Click(object sender, EventArgs e)
        {

        }

        private void createProductLabel_Click(object sender, EventArgs e)
        {

        }

        private void responsibleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void classificationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void endDatePicker_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void startDatePicker_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void noteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void noteLabel_Click(object sender, EventArgs e)
        {

        }

        private void responsibleLabel_Click(object sender, EventArgs e)
        {

        }

        private void classificationLabel_Click(object sender, EventArgs e)
        {

        }

        private void createTaskButton_Click_1(object sender, EventArgs e)
        {
            if (!NullCheck())
                return;

            Status s = (Status)Enum.Parse(typeof(Status), "didntStartProgress");
            Employee selectedEmployee = (Employee)responsibleComboBox.SelectedItem;


            Task t = new Task(null, subjectTextBox.Text, startDatePicker.Value, endDatePicker.Value, (ClassificationType)Enum.Parse(typeof(ClassificationType), classificationComboBox.Text), s, selectedEmployee, noteTextBox.Text.ToString(),true);

            Program.Tasks.Add(t);
            selectedEmployee.Tasks.Add(t);

            string email = selectedEmployee.Email;
            MailAddress receiver = new MailAddress(email);
            Program.sendEmailTask(receiver);

            string m = "The task has been added and an email has sent to the employee!";
            MessageBox.Show(m, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


            manageCalendar mcf = new manageCalendar();
            mcf.Show();
            this.Hide();




        }

        private void subjectTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void endDateLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void startDateLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void SubjectLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void backArrowPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            manageCalendar mcf = new manageCalendar();
            mcf.Show();
            this.Hide();
        }

        private void sortEmployeeLabel_Click(object sender, EventArgs e)
        {

        }



        private Boolean NullCheck() //return false if there a null cells
        {

            if (SubjectLabel.Text == "" || startDateLabel.Text == "" || endDateLabel.Text == "" || classificationComboBox.Text == "" || responsibleComboBox.Text == "" )
            {
                MessageBox.Show("Do not leave blank fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }//invalid input
            return true;
        }

        private void createTaskForm_Load_1(object sender, EventArgs e)
        {

        }

        private void homePageButton_Click(object sender, EventArgs e)
        {
            Employee employee = Program.seekEmployee(LogInForm.enterId);
            string ET = employee.EmployeeType.ToString();
            if (ET.Equals("teamWorker"))
            {
                TeamWorkerFunctionForm twf = new TeamWorkerFunctionForm();
                twf.Show();
                this.Hide();
            }
            else if (ET.Equals("officeManager"))
            {
                AllFunctionForm aff = new AllFunctionForm();
                aff.Show();
                this.Hide();
            }
            else if (ET.Equals("projectmanager"))
            {
                ProjectManagerFunctionForm pmf = new ProjectManagerFunctionForm();
                pmf.Show();
                this.Hide();
            }
            else if (ET.Equals("vicePresident"))
            {
                AllFunctionForm aff = new AllFunctionForm();
                aff.Show();
                this.Hide();
            }
            else // CEO
            {
                AllFunctionForm aff = new AllFunctionForm();
                aff.Show();
                this.Hide();
            }
        }
    }
}
