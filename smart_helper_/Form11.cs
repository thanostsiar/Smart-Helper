﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace smart_helper_
{
    public partial class Form11 : Form
    {
        static List<Day> dayList = new List<Day>();
        internal Form7 form7;

        public Form11()
        {
            InitializeComponent();
        }
        public Form11(String username, String activity)
        {
            InitializeComponent();
            userToolStripMenuItem.Text = username;
            label4.Text = activity;
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

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
            form7 = new Form7(userToolStripMenuItem.Text, dayList);
            form7.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value == null || comboBox1.SelectedItem == null || (radioButton1.Checked == false && radioButton2.Checked == false))
            {
                MessageBox.Show("Please fill all the information!", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String activity = label4.Text;
                String date = dateTimePicker1.Text;
                String transportation = comboBox1.SelectedItem.ToString();
                bool coffee = radioButton1.Checked;
                Image route = null;

                if (activity.Equals("University"))
                {
                    if (transportation.Equals("Car"))
                    {
                        route = Properties.Resources.papei_car;
                    }
                    else if (transportation.Equals("Public Transport"))
                    {
                        route = Properties.Resources.papei_mesa;
                    }
                }
                else if (activity.Equals("Gym"))
                {
                    if (transportation.Equals("Car"))
                    {
                        route = Properties.Resources.gym_car;
                    }
                    else if (transportation.Equals("Public Transport"))
                    {
                        route = Properties.Resources.gym_mesa;
                    }
                    else if (transportation.Equals("On foot"))
                    {
                        route = Properties.Resources.gym_podia;
                    }
                }
                else if (activity.Equals("Drivers' School"))
                {
                    if (transportation.Equals("Car"))
                    {
                        route = Properties.Resources.driver_car;
                    }
                    else if (transportation.Equals("Public Transport"))
                    {
                        route = Properties.Resources.driver_mesa;
                    }
                    else if (transportation.Equals("On foot"))
                    {
                        route = Properties.Resources.driver_podia;
                    }
                }
                else if (activity.Equals("Night Out"))
                {
                    if (transportation.Equals("Car"))
                    {
                        route = Properties.Resources.gazi_car;
                    }
                    else if (transportation.Equals("Public Transport"))
                    {
                        route = Properties.Resources.gazi_mesa;
                    }
                }
                else if (activity.Equals("Take Away Coffee"))
                {
                    if (transportation.Equals("Car"))
                    {
                        route = Properties.Resources.coffee_car;
                    }
                    else if (transportation.Equals("Public Transport"))
                    {
                        route = Properties.Resources.coffee_mesa;
                    }
                }

                bool activityExists = File.ReadAllText("day.txt").Contains(activity);

                Day day = new Day(activity, date, transportation, coffee, route);

                if (activityExists)
                {
                    MessageBox.Show("You have already made your plans for this activity!", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Activity saved!");

                    // When OK is clicked, the activity's info are saved and added in the list and then in the day file.
                    
                    if (dialogResult == DialogResult.OK)
                    {
                        dayList.Add(day);

                        StreamWriter sw = new StreamWriter("day.txt", true);
                        try
                        {
                            sw.WriteLine("Activity: " + day.activity + " | " + "Date: " + day.date + " | " +  "Transportation: " + day.transportation + " | " + "Coffee: " + day.coffee + " | " + day.route);
                            sw.WriteLine(Environment.NewLine);
                        }
                        catch (Exception x)
                        {
                            Console.WriteLine(x.Message);
                        }
                        finally
                        {
                            sw.Close();
                        }
                        MessageBox.Show("Activity saved!");
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13("Activity", "After having chosen the activity to add to your day, it's time to proceed. Choose the date and hour that " +
                            "the activity is going to take place and then select your way of transportation from the combobox. " +
                            "There is also an option if you want a take away coffee, by choosing 'YES' or 'NO' below. " +
                            "Finally, press the button 'Submit' in order to add the activity in your day plan. " +
                            "If you want to go back a page, click the blue arrow on the top - left. " +
                            "In case you want to sign-out, press the 'Sign-Out' button on the top-right next to your username. " +
                            "Finally, if you want to exit the application, press the 'Exit' button on the top-left of the form.");
            form13.Show();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            if (label4.Text.Equals("University") || label4.Text.Equals("Night Out") || label4.Text.Equals("Take Away Coffee"))
            {
                comboBox1.Items.RemoveAt(0);
            }
        }
    }
}
