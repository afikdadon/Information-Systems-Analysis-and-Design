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
    public partial class AllFunctionForm : Form
    {
        private Employee employee;
        public AllFunctionForm()
        {
            InitializeComponent();
            this.employee = Program.seekEmployee(LogInForm.enterId);
            employee.checkLoad();
            openMissionsTextBox.Text = employee.Load.ToString();
            employeeNameTextBox.Text = employee.FirstName + " " + employee.LastName;

        }

        private void employeeNameTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void AllFunctionForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            manageCalendar mn = new manageCalendar();
            mn.Show();
            this.Hide();
        }

        private void LogoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void accountManagementButton_Click(object sender, EventArgs e)
        {
            CreateInvoiceForm cif = new CreateInvoiceForm();
            cif.Show();
            this.Hide();
        }

        private void projectButton_Click(object sender, EventArgs e)
        {
            AllProjectForm pf = new AllProjectForm();
            pf.Show();
            this.Hide();
        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            CRUD_EmployeeForm cef = new CRUD_EmployeeForm();
            cef.Show();
            this.Hide();
        }

        private void openMissionLabel_Click(object sender, EventArgs e)
        {
           
        }

        private void helloLabel_Click(object sender, EventArgs e)
        {

        }

        private void openMissionsTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            LogInForm lif = new LogInForm();
            lif.Show();
            this.Hide();
        }

        private void productButton_Click(object sender, EventArgs e)
        {
            CRUD_ProductForm cpf = new CRUD_ProductForm();
            cpf.Show();
            this.Hide();
        }

        private void suppliersButton_Click(object sender, EventArgs e)
        {
            CRUD_SupplierForm csf = new CRUD_SupplierForm();
            csf.Show();
            this.Hide();
        }
    }
}
