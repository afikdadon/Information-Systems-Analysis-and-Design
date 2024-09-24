using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Group_1
{
    public partial class UserControlDays : UserControl
    {
        public static int mounth;
        public UserControlDays()
        {
            InitializeComponent();
 
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            displayTask();
            displayStages();

        }

        private void IbDays_Click(object sender, EventArgs e)
        {

        }

        public void days(int numday)
        {
            IbDays.Text = numday + "";
        }

        public void displayTask()
        {

            Console.WriteLine(Program.Tasks[0].End.ToString());
            foreach (Task t in Program.Tasks)
            {

                string currentDay = t.End.Day.ToString();
                string currentMonth = t.End.Month.ToString();
                string mounth1 = mounth.ToString();

                Console.WriteLine(IbDays.Text);
                if (IbDays.Text.Equals(currentDay) && mounth1.Equals(currentMonth))
                {
                    label2.Visible = true;
                    label2.Text = t.TaskName;
                }

            }
        }

        public void displayStages()
        {

            Console.WriteLine(Program.Stages[0].Deadline.ToString());
            foreach (Stage s in Program.Stages)
            {

                string currentDay = s.Deadline.Day.ToString();
                string currentMonth = s.Deadline.Month.ToString();
                string mounth1 = mounth.ToString();

                Console.WriteLine(IbDays.Text);
                if (IbDays.Text.Equals(currentDay) && mounth1.Equals(currentMonth))
                {
                    label2.Visible = true;
                    Project p = Program.seekProject(s.Project.ProjectName);
                    string stageType = Regex.Replace(s.StageType.ToString(), @"\B[A-Z]", " $&");
                    string show = p.ProjectName + "\n" + stageType;
                    label2.Text = show;
                }

            }
        }

        private void label2_Click_2(object sender, EventArgs e)
        {
            displayTask();
            displayStages();
        }

        
    }
}
