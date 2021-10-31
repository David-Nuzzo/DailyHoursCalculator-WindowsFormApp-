using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            float breakAmount = float.Parse(breakMinsTextBox.Text) / 60;

            float daysWorkedAmount = float.Parse(daysWorkedTextBox.Text);

            // Calculate the hours and mins worked.
            float hours = endHour - startHour;
            float mins = (endMins - startMin) / 60;
            float dailyHours = hours + mins - breakAmount;
            float weeklyHours = dailyHours * daysWorkedAmount;

            // Present the result in the resultTextBox.
            resultTextBox.Text = dailyHours.ToString();
            resultWeeklyTextBox.Text = weeklyHours.ToString();
                        
        }
    }
}
