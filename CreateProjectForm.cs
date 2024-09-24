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
    public partial class CreateProjectForm : Form
    {
        private bool create;
        private Project project;

        public CreateProjectForm()
        {
            InitializeComponent();
            create = false;
        }

        private void stagesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addStageButton_Click(object sender, EventArgs e)
        {
            if (!create)
            {
                MessageBox.Show("You must create a project before adding stage", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            addStageForm asf = new addStageForm(project, this);
            asf.Show();
            this.Show();
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

        private void nameTextBox_TextChanged(object sender, EventArgs e)
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

        private void backArrowPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AllFunctionForm aff = new AllFunctionForm();
            aff.Show();
            this.Hide();
        }

        private void newProjectLabel_Click(object sender, EventArgs e)
        {

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (!NullCheck())
                return;
             //name
            if (Program.isProjectExists(nameTextBox.Text))
            {
                MessageBox.Show("A project with this name exists in the system", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Program.containsNumbers(cityTextBox.Text))
            {
                MessageBox.Show("A city cannot contain numbers. Please write a city only with letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Project p = new Project(nameTextBox.Text, cityTextBox.Text, addressTextBox.Text, true);
            this.project = p;
            create = true;

            string message = "The project " + nameTextBox.Text + " added successfully!";
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private Boolean NullCheck() //return false if there a null cells
        {

            if (nameTextBox.Text == "" || cityTextBox.Text == "" || addressTextBox.Text == "" )
            {
                MessageBox.Show("Do not leave blank fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }//invalid input
            return true;
        }

        private void CreateProjectForm_Load(object sender, EventArgs e)
        {
            stagesDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Maiandra GD", 12, FontStyle.Bold);
            stagesDataGridView.RowsDefaultCellStyle.Font = new Font("Maiandra GD", 9, FontStyle.Regular);
        }

        private void satisfactionFillingSurvey_CellContentClick(object sender, DataGridViewCellEventArgs e)// הגבלת בחירת דירוג אחד בלבד בכל שאלה
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 1) // בדיקה שהתא הנבדק בתוך גבולות הטבלה
            {
                DataGridViewCell clickedCell = stagesDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (clickedCell is DataGridViewCheckBoxCell checkboxCell) // checkbox אם התא הנבחר הוא
                {
                    // חסימת האפשרות לסימון וי בשאר המקומות בשורה
                    foreach (DataGridViewCell cell in stagesDataGridView.Rows[e.RowIndex].Cells)
                    {
                        if (cell != clickedCell && cell is DataGridViewCheckBoxCell otherCheckboxCell)
                            otherCheckboxCell.Value = false;
                    }
                }
            }
        }

        private void doneButton_Click(object sender, EventArgs e)
        {

            AfterCreateProject acp = new AfterCreateProject(project);
            acp.Show();
            this.Hide();
        }
    }
}
