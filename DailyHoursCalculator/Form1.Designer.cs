
namespace DailyHoursCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.clockInHourTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clockOutHoursTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.breakMinsTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clockInMinsTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.clockOutMinsTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.daysWorkedTextBox = new System.Windows.Forms.TextBox();
            this.resultWeeklyTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clockInHourTextBox
            // 
            this.clockInHourTextBox.Location = new System.Drawing.Point(194, 68);
            this.clockInHourTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.clockInHourTextBox.Name = "clockInHourTextBox";
            this.clockInHourTextBox.Size = new System.Drawing.Size(64, 26);
            this.clockInHourTextBox.TabIndex = 0;
            this.clockInHourTextBox.Text = "8";
            this.clockInHourTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clock in Time    :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Clock out Time :";
            // 
            // clockOutHoursTextBox
            // 
            this.clockOutHoursTextBox.Location = new System.Drawing.Point(194, 115);
            this.clockOutHoursTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.clockOutHoursTextBox.Name = "clockOutHoursTextBox";
            this.clockOutHoursTextBox.Size = new System.Drawing.Size(64, 26);
            this.clockOutHoursTextBox.TabIndex = 3;
            this.clockOutHoursTextBox.Text = "17";
            this.clockOutHoursTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Daily Length of Break (in Mins) :";
            // 
            // breakMinsTextBox
            // 
            this.breakMinsTextBox.Location = new System.Drawing.Point(276, 168);
            this.breakMinsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.breakMinsTextBox.Name = "breakMinsTextBox";
            this.breakMinsTextBox.Size = new System.Drawing.Size(66, 26);
            this.breakMinsTextBox.TabIndex = 5;
            this.breakMinsTextBox.Text = "30";
            this.breakMinsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Source Sans Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(36, 254);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(308, 61);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 338);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Daily Hours        =";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(169, 335);
            this.resultTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(173, 26);
            this.resultTextBox.TabIndex = 8;
            this.resultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hours";
            // 
            // clockInMinsTextBox
            // 
            this.clockInMinsTextBox.Location = new System.Drawing.Point(278, 68);
            this.clockInMinsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.clockInMinsTextBox.Name = "clockInMinsTextBox";
            this.clockInMinsTextBox.Size = new System.Drawing.Size(64, 26);
            this.clockInMinsTextBox.TabIndex = 10;
            this.clockInMinsTextBox.Text = "30";
            this.clockInMinsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mins";
            // 
            // clockOutMinsTextBox
            // 
            this.clockOutMinsTextBox.Location = new System.Drawing.Point(278, 115);
            this.clockOutMinsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.clockOutMinsTextBox.Name = "clockOutMinsTextBox";
            this.clockOutMinsTextBox.Size = new System.Drawing.Size(64, 26);
            this.clockOutMinsTextBox.TabIndex = 12;
            this.clockOutMinsTextBox.Text = "00";
            this.clockOutMinsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 72);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(262, 119);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(36, 430);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 68);
            this.label9.TabIndex = 15;
            this.label9.Text = "Ensure all hour time\r\nentries are in 24hr\r\nformat.\r\nE.G (14 = 2pm)\r\n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Source Sans Pro", 8.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(224, 483);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Developed by David Nuzzo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 212);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(217, 19);
            this.label11.TabIndex = 17;
            this.label11.Text = "Days worked in the week            :";
            // 
            // daysWorkedTextBox
            // 
            this.daysWorkedTextBox.Location = new System.Drawing.Point(276, 209);
            this.daysWorkedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.daysWorkedTextBox.Name = "daysWorkedTextBox";
            this.daysWorkedTextBox.Size = new System.Drawing.Size(66, 26);
            this.daysWorkedTextBox.TabIndex = 18;
            this.daysWorkedTextBox.Text = "5";
            this.daysWorkedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resultWeeklyTextBox
            // 
            this.resultWeeklyTextBox.Location = new System.Drawing.Point(169, 378);
            this.resultWeeklyTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.resultWeeklyTextBox.Name = "resultWeeklyTextBox";
            this.resultWeeklyTextBox.Size = new System.Drawing.Size(175, 26);
            this.resultWeeklyTextBox.TabIndex = 20;
            this.resultWeeklyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(36, 378);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 19);
            this.label13.TabIndex = 21;
            this.label13.Text = "Weekly Hours   =";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 517);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.resultWeeklyTextBox);
            this.Controls.Add(this.daysWorkedTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.clockOutMinsTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.clockInMinsTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.breakMinsTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clockOutHoursTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clockInHourTextBox);
            this.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Work Hours Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox clockInHourTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox clockOutHoursTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox breakMinsTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox clockInMinsTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox clockOutMinsTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox daysWorkedTextBox;
        private System.Windows.Forms.TextBox resultWeeklyTextBox;
        private System.Windows.Forms.Label label13;
    }
}

