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
    public partial class addStageForm : Form
    {
        private Project project;
        CreateProjectForm cpf;

        public addStageForm(Project project, CreateProjectForm cpf)
        {
            InitializeComponent();
            this.project = project;
            this.cpf = cpf;

            typeComboBox.DisplayMember = "Description";//אתחול הקומבובוקס
            typeComboBox.ValueMember = "Value";
            typeComboBox.DataSource = Enum.GetValues(typeof(StageType)).Cast<Enum>().Select(value => new
            { (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description, value }).OrderBy(item => item.value).ToList();

            statusComboBox.DisplayMember = "Description";//אתחול הקומבובוקס
            statusComboBox.ValueMember = "Value";
            statusComboBox.DataSource = Enum.GetValues(typeof(Status)).Cast<Enum>().Select(value => new
            { (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description, value }).OrderBy(item => item.value).ToList();
    }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {

        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void newProjectLabel_Click(object sender, EventArgs e)
        {

        }

        private void addStageButton_Click(object sender, EventArgs e)
        {
            string type = typeComboBox.Text; ;

            string[] words1 = type.Split(' ');

            for (int i = 0; i < words1.Length; i++)
            {
                if (i != 0)
                {
                    string word = words1[i];
                    words1[i] = char.ToUpper(word[0]) + word.Substring(1);
                }
            }
            string output1 = string.Join("", words1);
            Console.WriteLine(output1);

            string status = statusComboBox.Text; ;
            string[] words2 = status.Split(' ');
            for (int i = 0; i < words2.Length; i++)
            {
                if (i != 0)
                {
                    string word = words2[i];
                    words2[i] = char.ToUpper(word[0]) + word.Substring(1);
                }
            }
            string output2 = string.Join("", words2);

            Console.WriteLine(output2);

            Stage stage = new Stage(null, (StageType)Enum.Parse(typeof(StageType), output1), daedlinePicker.Value , (Status)Enum.Parse(typeof(Status), output2), project,  true);
            cpf.stagesDataGridView.Rows.Add(stage.StageType, stage.Deadline.ToString(("yyyy-MM-dd")), stage.StageStatus);
        }

        private void addStageForm_Load(object sender, EventArgs e)
        {

        }
    }
}