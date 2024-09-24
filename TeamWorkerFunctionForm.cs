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
    public partial class TeamWorkerFunctionForm : Form
    {
        private Employee employee;
        public TeamWorkerFunctionForm()
        {
            InitializeComponent();
            this.employee = Program.seekEmployee(LogInForm.enterId);
            openTaskTextBox.Text = employee.Load.ToString(); ///////checkLoad
            employeeNameTextBox.Text = employee.FirstName + " " + employee.LastName;
        }

        private void helloLabel_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            LogInForm lif = new LogInForm();
            lif.Show();
            this.Hide();
        }

        private void tasksButton_Click(object sender, EventArgs e)
        {
            manageCalendar mc = new manageCalendar();
            mc.Show();
            this.Hide();
        }

        private void openTaskTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void openTaskLabel_Click(object sender, EventArgs e)
        {

        }

        private void employeeNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void backArrowPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void TeamWorkerFunctionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
