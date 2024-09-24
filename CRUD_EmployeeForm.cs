using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_1
{
    public partial class CRUD_EmployeeForm : Form
    {
        public CRUD_EmployeeForm()
        {
            InitializeComponent();
        }

        private void employeeLabel_Click(object sender, EventArgs e)
        {

        }

        private void updateOrDeleteButton_Click(object sender, EventArgs e)
        {
            UpdateOrDeleteEmployeeForm udf = new UpdateOrDeleteEmployeeForm();
            udf.Show();
            this.Hide();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            IdForEmployeeForm vf = new IdForEmployeeForm();
            vf.Show();
            this.Hide();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            createEmployeeForm cef = new createEmployeeForm();
            cef.Show();
            this.Hide();
        }

        private void CRUD_EmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            UpdateOrDeleteEmployeeForm udf = new UpdateOrDeleteEmployeeForm();
            udf.Show();
            this.Hide();
        }

        private void viewPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void updatePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void deletePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void createPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void backArrowPictureBox_Click(object sender, EventArgs e)
        {
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AllFunctionForm lif = new AllFunctionForm();
            lif.Show();
            this.Hide();
        }
    }
}
