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
    public partial class ProjectManagerFunctionForm : Form
    {
        private Employee employee;
        public ProjectManagerFunctionForm()
        {
            InitializeComponent();
            this.employee = Program.seekEmployee(LogInForm.enterId);
            openTaskTextBox.Text = employee.Load.ToString(); ///////checkLoad
            employeeNameTextBox.Text = employee.FirstName + " " + employee.LastName;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            LogInForm lif = new LogInForm();
            lif.Show();
            this.Hide();
        }

        private void backArrowPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void openTaskTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void tasksButton_Click(object sender, EventArgs e)
        {
            manageCalendar mc = new manageCalendar();
            mc.Show();
            this.Hide();
        }

        private void projectButton_Click(object sender, EventArgs e)
        {
            AllProjectForm aff = new AllProjectForm();
            aff.Show();
            this.Hide();
        }

        private void openTaskLabel_Click(object sender, EventArgs e)
        {

        }

        private void employeeNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void helloLabel_Click(object sender, EventArgs e)
        {

        }

        private void ProjectManagerFunctionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
