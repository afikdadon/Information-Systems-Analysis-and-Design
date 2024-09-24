using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace Group_1
{
    public partial class AllProjectForm : Form
    {
        private DataTable dt;
        private DataView dv;
        private Project project;
        private ListViewItem selectedListViewItem; // Track the selected item


        public AllProjectForm()
        {
            InitializeComponent();

            projectslistView.View = View.Details;
            projectslistView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            projectslistView.Columns.Add("Name", 450);

            projectslistView.SelectedIndexChanged += projectslistView_SelectedIndexChanged;


            dt = new DataTable();
            dt.Columns.Add("Name");

            fillDataTable();

            CultureInfo hebrewCulture = new CultureInfo("he-IL");

            dv = new DataView(dt);

            dv.Sort = "Name"; // Sort by the "Name" column
            populateListView(dv);
        }
        private void fillDataTable()
        {
            foreach (Project p in Program.Projects)
            {
                dt.Rows.Add(p.ProjectName);
            }
        }
        
        private void populateListView(DataView dv)
        {
            projectslistView.Items.Clear();
            foreach (DataRow row in dv.ToTable().Rows)
            {
                projectslistView.Items.Add(new ListViewItem(new String[] { row[0].ToString()}));
            }
        }

        private void fillterTextBox_TextChanged(object sender, EventArgs e)
        {

            dv.RowFilter = $"Name Like '%{fillterTextBox.Text}%'";
            populateListView(dv);
        }

        private void projectslistView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (projectslistView.SelectedItems.Count > 0)
            {
                // Get the selected item
                ListViewItem selectedItem = projectslistView.SelectedItems[0];

                // Store the selected item for future reference
                selectedListViewItem = selectedItem;

                // Access the sub-items (columns) of the selected item
                string name = selectedItem.SubItems[0].Text;

                project = Program.seekProject(name);

            }
        }

        private void ClearSelection()
        {
            // Deselect the previously selected item
            if (selectedListViewItem != null)
            {
                selectedListViewItem.Selected = false;
                selectedListViewItem = null;
            }
        }

        private void ProjectForm_Load(object sender, EventArgs e)
        {
            projectslistView.Font = new Font("Maiandra GD", 12, FontStyle.Regular);

            // Changing the font of individual ListViewItem objects
            foreach (ListViewItem item in projectslistView.Items)
            {
                item.Font = projectslistView.Font = new Font("Maiandra GD", 12, FontStyle.Regular);

            }
        }

        private void createNewOrderbutton_Click(object sender, EventArgs e)
        {
            ProjectForm pf = new ProjectForm(project);
            pf.Show();
            this.Hide();
        }

        private void createProjectButton_Click(object sender, EventArgs e)
        {
            CreateProjectForm cp = new CreateProjectForm();
            cp.Show();
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

        private void backButton_Click(object sender, EventArgs e)
        {

        }

        private void projectslistView_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }
    }
}
