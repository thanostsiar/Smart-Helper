using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace smart_helper_
{
    public partial class Form7 : Form
    {
        static List<Day> dayList = new List<Day>();

        public Form7()
        {
            InitializeComponent();
        }

        public Form7(String username)
        {
            InitializeComponent();
            userToolStripMenuItem.Text = username;
        }
        public Form7(String username, List<Day>dayList)
        {
            InitializeComponent();
            userToolStripMenuItem.Text = username;
            Form7.dayList = dayList;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form11 form11 = new Form11(userToolStripMenuItem.Text, "University");
            form11.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form11 form11 = new Form11(userToolStripMenuItem.Text, "Gym");
            form11.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form11 form11 = new Form11(userToolStripMenuItem.Text, "Drivers' School");
            form11.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form11 form11 = new Form11(userToolStripMenuItem.Text, "Night Out");
            form11.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
            Form11 form11 = new Form11(userToolStripMenuItem.Text, "Take Away Coffee");
            form11.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14(Form7.dayList);
            form14.Show();
        }
                                                                                                                                                                                                               
        private void button4_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13("Day Planner", "Hover over the pictures of the activities to learn about them and click on them in order to proceed. " +
                            "If you want to see your day's plan, click the 'My Day' button. " +
                            "In case you want to sign-out, press the 'Sign-Out' button on the top-right next to your username. " +
                            "If you want to go back a page, click the blue arrow on the top-left. " +
                            "If you want to exit the day planner and go back to the devices' page, press the button 'Exit Day Planner' on the top-left. " +
                            "Finally, if you want to exit the application, press the 'Exit' button on the top-left of the form.");
            form13.Show();
        }

        private void exitDayPlannerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form2 = new Form2(userToolStripMenuItem.Text);
            form2.Show();
        }
    }
}
