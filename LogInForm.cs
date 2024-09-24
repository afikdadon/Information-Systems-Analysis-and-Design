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
    public partial class LogInForm : Form
    {
        public static string enterId;
        public LogInForm()
        {
            InitializeComponent();

        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            if (!NullCheck())
                return;

            if (!Program.isEmployeeExistsByEmployeeId(EmployeeIDTextBox.Text))
            {
                string message = "Employee number " + EmployeeIDTextBox.Text + " does not exist";
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            Employee employee = Program.seekEmployeeByEmployeeId(EmployeeIDTextBox.Text);
            enterId = employee.Id;
            employee.checkLoad();
            string ET = employee.EmployeeType.ToString();


            if (ET.Equals("teamWorker"))
            {
                TeamWorkerFunctionForm twf = new TeamWorkerFunctionForm ();
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

        private void EmployeeIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void employeeIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void LogoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void galtamLabel_Click(object sender, EventArgs e)
        {

        }

        private Boolean NullCheck() //return false if there a null cells
        {

            if (EmployeeIDTextBox.Text == "")
            {
                MessageBox.Show("Do not leave blank fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }//invalid input
            return true;
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }
    }
}
