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
    public partial class AfterCreateProject : Form
    {
        private Project project;
        public AfterCreateProject(Project project)
        {
            InitializeComponent();
            this.project = project;

            nameTextBox.Text = project.ProjectName;
            cityTextBox.Text = project.City;
            addressTextBox.Text = project.Address;

            nameTextBox.Enabled = false;
            cityTextBox.Enabled = false;
            addressTextBox.Enabled = false;

            foreach(Stage s in Program.Stages)
            {
                if (s.Project.ProjectName.Equals(project.ProjectName))
                {
                    stagesDataGridView.Rows.Add(s.StageType.ToString(), s.Deadline.ToString(("yyyy-MM-dd")), s.StageStatus.ToString());
                }
            }

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void stagesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addStageButton_Click(object sender, EventArgs e)
        {
            manageCalendar mc = new manageCalendar();
            mc.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void stagesLabel_Click(object sender, EventArgs e)
        {

        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void homePageButton_Click(object sender, EventArgs e)
        {

        }

        private void backArrowPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {

        }

        private void AfterCreateProject_Load(object sender, EventArgs e)
        {
            stagesDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Maiandra GD", 12, FontStyle.Bold);
            stagesDataGridView.RowsDefaultCellStyle.Font = new Font("Maiandra GD", 9, FontStyle.Regular);


        }
    }
}
