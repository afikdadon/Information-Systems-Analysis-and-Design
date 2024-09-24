using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_1
{
    public partial class manageCalendar : Form
    {
        int month;
        int year;
        public manageCalendar()
        {
            InitializeComponent();
        }

        private void previousLabel_Click(object sender, EventArgs e)
        {

        }

   
        private void previousButton_Click(object sender, EventArgs e)
        {
            calendarPanel.Controls.Clear();

            month--;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            yearMonthLabel.Text = monthname + " " + year;

            DateTime startOfTheMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);

            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) ; //עבד לנו בלי מינוס 1
            for (int i = 1; i <= dayOfTheWeek; i++)
            {
                UserControlBlank unblank = new UserControlBlank();
                calendarPanel.Controls.Add(unblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                UserControlDays.mounth = month;
                ucdays.days(i);
                calendarPanel.Controls.Add(ucdays);
            }

        }

        private void nextLabel_Click(object sender, EventArgs e)
        {

        }

        private void saturdayLabel_Click(object sender, EventArgs e)
        {

        }

        private void fridayLabel_Click(object sender, EventArgs e)
        {

        }

        private void thursdayLabel_Click(object sender, EventArgs e)
        {

        }

        private void wednesdayLabel_Click(object sender, EventArgs e)
        {

        }

        private void tuesdayLabel_Click(object sender, EventArgs e)
        {

        }

        private void mondayLabel_Click(object sender, EventArgs e)
        {

        }

        private void yearMonthLabel_Click(object sender, EventArgs e)
        {

        }

        private void sundayLabel_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            calendarPanel.Controls.Clear();

            month++;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            yearMonthLabel.Text = monthname + " " + year;

            DateTime startOfTheMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);

            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")); //עבד בלי מינוס 1
            for (int i = 1; i <= dayOfTheWeek; i++)
            {
                UserControlBlank unblank = new UserControlBlank();
                calendarPanel.Controls.Add(unblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                UserControlDays.mounth = month;
                ucdays.days(i);
                calendarPanel.Controls.Add(ucdays);
            }
        }

 
        private void manageCalendar_Load(object sender, EventArgs e)
        {
            displayDays();
            this.nextButton_Click(sender, e);
            this.previousButton_Click(sender, e);
        }

      
        private void displayDays()
        {
            calendarPanel.Controls.Clear();
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void newTaskButton_Click(object sender, EventArgs e)
        {
            createTaskForm ctf = new createTaskForm();
            ctf.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
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
    }
}
