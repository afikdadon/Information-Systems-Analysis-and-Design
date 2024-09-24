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
    public partial class CRUD_SupplierForm : Form
    {
        public CRUD_SupplierForm()
        {
            InitializeComponent();
        }

        private void supplierLabel_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
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

        private void deletePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void updatePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void viewPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void createPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void backArrowPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void updateOrDeleteButton_Click(object sender, EventArgs e)
        {
            UpdateOrDeleteSupplierForm uds = new UpdateOrDeleteSupplierForm();
            uds.Show();
            this.Hide();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            BnForSupplierForm vf = new BnForSupplierForm();
            vf.Show();
            this.Hide();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            createSupplierForm sf = new createSupplierForm();
            sf.Show();
            this.Hide();


        }
    }
}
