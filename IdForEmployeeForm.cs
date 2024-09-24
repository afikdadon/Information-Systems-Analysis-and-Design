using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_1
{
    public partial class IdForEmployeeForm : Form
    {
        public IdForEmployeeForm()
        {
            InitializeComponent();
        }

        private void IdForEmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void enterEmployeeIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void employeeIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void viewButton_Click(object sender, EventArgs e)
        {

            if (!Program.isEmployeeExistsByEmployeeId(employeeIdTextBox.Text))
            {

                string message = "אין עובד קיים במערכת עם המספר המזהה " + employeeIdTextBox.Text;
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Employee employeee = Program.seekEmployeeByEmployeeId(employeeIdTextBox.Text);
            ViewEmployeeForm ViewEmployeeForm = new ViewEmployeeForm(employeee);
            ViewEmployeeForm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            CRUD_EmployeeForm cef = new CRUD_EmployeeForm();
            cef.Show();
            this.Hide();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
