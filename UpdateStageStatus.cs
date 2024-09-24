using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_1
{
    public partial class UpdateStageStatus : Form
    {
        private Project project;

        public UpdateStageStatus(Project project)
        {
            InitializeComponent();
            this.project = project;

            foreach (Stage s in Program.Stages)
            {
                if (s.Project.ProjectName.Equals(project.ProjectName))
                {
                    string stageType = Regex.Replace(s.StageType.ToString(), "([a-z])([A-Z])", "$1 $2");
                    string deadline = Convert.ToDateTime(s.Deadline).ToString("yyyy-MM-dd");

                    stagesDataGridView.Rows.Add(s.StageName, stageType,  deadline);

                }
            }
        }
        private void stagesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in stagesDataGridView.Rows)
            {
                int choseColumn = GetCheckedColumns(row);

                if (choseColumn > 2)
                {
                    foreach (Stage s in Program.Stages)
                    {
                        if (s.StageName.Equals(row.Cells[0].Value.ToString()))
                        {
                            if(choseColumn == 3)
                            {
                                s.StageStatus = (Status)Enum.Parse(typeof(Status), "didnt start progress");
                                s.updateStage();
                                MessageBox.Show("The steps have been successfully updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else if(choseColumn == 4)
                            {
                                s.StageStatus = (Status)Enum.Parse(typeof(Status), "inProgress");
                                s.updateStage();
                                MessageBox.Show("The steps have been successfully updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                s.StageStatus = (Status)Enum.Parse(typeof(Status), "completed");
                                s.updateStage();
                                MessageBox.Show("The steps have been successfully updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }

            }
        }


        private int GetCheckedColumns(DataGridViewRow row) // החזרת רשימת מספרי העמודות בהן יש תיבת סימון מסומנת בשורה
        {
            int number = 0;

            for (int columnIndex = 3; columnIndex < row.Cells.Count; columnIndex++) // מעבר על כל העמודות עם אפשרות הסימון
            {
                DataGridViewCheckBoxCell checkboxCell = row.Cells[columnIndex] as DataGridViewCheckBoxCell;
                if (checkboxCell != null && checkboxCell.Value != null && (bool)checkboxCell.Value) // אם התא הוא תיבת סימון והיא מסומנת
                {
                    number = columnIndex;
                }
            }
            return number;
        }

        private void backArrowPictureBox_Click(object sender, EventArgs e)
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

        private void UpdateStageStatus_Load(object sender, EventArgs e)
        {
            stagesDataGridView.CellContentClick += stagesDataGridView_CellContentClick;
            stagesDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Maiandra GD", 12, FontStyle.Bold);
            stagesDataGridView.RowsDefaultCellStyle.Font = new Font("Maiandra GD", 9, FontStyle.Regular);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ProjectForm pf = new ProjectForm(project);
            pf.Show();
            this.Hide();

        }
    }


}
