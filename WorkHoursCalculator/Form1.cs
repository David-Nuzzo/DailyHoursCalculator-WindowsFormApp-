using System;
using System.Windows.Forms;

namespace DailyHoursCalculator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Read all values from user inputs.
            float startHour = float.Parse(clockInHourTextBox.Text);
            float startMin = float.Parse(clockInMinsTextBox.Text);
            float endHour = float.Parse(clockOutHoursTextBox.Text);
            float endMins = float.Parse(clockOutMinsTextBox.Text);
            float breakAmount = float.Parse(breakMinsTextBox.Text);
            float daysInWeekDecimal = float.Parse(daysWorkedTextBox.Text);


            // Calculate the daily mins worked.        
                            //                  hours              +            mins           -      break 
            float allDailyMinutes = ((endHour - startHour) * 60)   +   (endMins - startMin)    -   breakAmount;            
            

            // Convert the mins into hours and mins for a single day and then for the full week.
            TimeSpan t = TimeSpan.FromMinutes(allDailyMinutes);
            int dailyWorkHours = (int)t.Hours;
            int dailyWorkMins = (int)t.Minutes;

            t = TimeSpan.FromMinutes(allDailyMinutes * daysInWeekDecimal);
            int weeklyWorkHours = (int)t.TotalHours;
            int weeklyWorkMins = (int)t.Minutes;


            // Present the results in the resultTextBoxes.
            resultTextBox.Text       = "Hours: " + dailyWorkHours.ToString()  + "    Mins: " + dailyWorkMins.ToString();
            resultWeeklyTextBox.Text = "Hours: " + weeklyWorkHours.ToString() + "    Mins: " + weeklyWorkMins.ToString();

        }
    }
}
