using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Landing_Page
{
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();

            // Add event handlers
            this.newworkoutButton.Click += new System.EventHandler(this.newworkoutButton_Click);
            this.newWorkoutPagelabel.Click += new System.EventHandler(this.newWorkoutPageLabel_Click);
            this.exercisegoalsPagelabel.Click += new System.EventHandler(this.exerciseGoalsPageLabel_Click);
            this.calendarPagelabel.Click += new System.EventHandler(this.calendarPageLabel_Click);
            this.homeLabel.Click += new System.EventHandler(this.homeLabel_Click);
        }

        private void newworkoutButton_Click(object sender, EventArgs e)
        {
            NewWorkoutPage newWorkoutPage = new NewWorkoutPage();
            newWorkoutPage.Show();
            this.Hide();
        }

        private void newWorkoutPageLabel_Click(object sender, EventArgs e)
        {
            // Call the newWorkoutButton_Click event handler instead
            newworkoutButton_Click(sender, e);
        }

        private void exerciseGoalsPageLabel_Click(object sender, EventArgs e)
        {
            ExerciseGoalsPage exerciseGoalsPage = new ExerciseGoalsPage();
            exerciseGoalsPage.Show();
            this.Hide();
        }

        private void calendarPageLabel_Click(object sender, EventArgs e)
        {
            CalendarPage calendarPage = new CalendarPage();
            calendarPage.Show();
            this.Hide();
        }

        private void homeLabel_Click(object sender, EventArgs e)
        {
            LandingPage landingPage = new LandingPage();
            landingPage.Show();
            this.Hide();
        }

        private void logoPictureBox_Click(object sender, EventArgs e)
        {
            LandingPage landingPage = new LandingPage();
            landingPage.Show();
            this.Hide();
        }
    }
}

