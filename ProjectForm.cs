using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;



namespace Group_1
{
    public partial class ProjectForm : Form
    {
        private Project project;
        private DataTable dt;
        private DataView dv;
        public ProjectForm(Project project)
        {
            InitializeComponent();
            this.project = project;
            nameTextBox.Text = project.ProjectName;
            cityTextBox.Text = project.City;
            addressTextBox.Text = project.Address;

            nameTextBox.Enabled = false;
            cityTextBox.Enabled = false;
            addressTextBox.Enabled = false;

            projectslistView.SelectedIndexChanged += projectslistView_SelectedIndexChanged;

            projectslistView.View = View.Details;
            projectslistView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            projectslistView.Columns.Add("Name", 50);
            projectslistView.Columns.Add("Type", 250);
            projectslistView.Columns.Add("Deadline", 150);
            projectslistView.Columns.Add("Status", 150);
  
           projectslistView.SelectedIndexChanged += projectslistView_SelectedIndexChanged;


            dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Type");
            dt.Columns.Add("Deadline");
            dt.Columns.Add("Status");



            fillDataTable();

            dv = new DataView(dt);

            populateListView(dv);
        }

        private void fillDataTable()
        {
            foreach (Stage s in Program.Stages)
            {
                if (s.Project.ProjectName.Equals(this.project.ProjectName))
                    dt.Rows.Add(s.StageName, s.StageType, s.Deadline, s.StageStatus);
            }
        }

        private void populateListView(DataView dv)
        {
            projectslistView.Items.Clear();
            foreach (DataRow row in dv.ToTable().Rows)
            {
                string deadline = Convert.ToDateTime(row[2]).ToString("yyyy-MM-dd");
                string stageType = Regex.Replace(row[1].ToString(), "([a-z])([A-Z])", "$1 $2");
                projectslistView.Items.Add(new ListViewItem(new string[] { row[0].ToString(), stageType, deadline, row[3].ToString() }));
            }
        }


        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ProjectForm_Load(object sender, EventArgs e)
        {

        }

        private void stagesLabel_Click(object sender, EventArgs e)
        {

        }

        private void projectslistView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backArrowPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AllProjectForm apf = new AllProjectForm();
            apf.Show();
            this.Hide();
        }

        private void createProjectButton_Click(object sender, EventArgs e)
        {
            createOrderForm fof = new createOrderForm(project);
            fof.Show();
            this.Hide();
        }

        private void createNewOrderbutton_Click(object sender, EventArgs e)
        {
            UpdateStageStatus uss = new UpdateStageStatus(project);
            uss.Show();
            this.Hide();
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void employeeLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
