using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smart_helper_
{
    public partial class Form6 : Form
    {
        int seconds, minutes, hours;
        public Form6()
        {
            InitializeComponent();
        }
        public Form6(String username)
        {
            InitializeComponent();
            userToolStripMenuItem.Text = username;
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form2 = new Form2(userToolStripMenuItem.Text);
            form2.Show();
        }


        private void Form6_Shown(object sender, EventArgs e)
        {
            //Picks a random number from 0 to 100
            Random rand = new Random();
            int random = rand.Next(0, 100);
            if (random > 50)
            {
                pictureBox2.BackgroundImage = Properties.Resources.pet_food;
                MessageBox.Show("The pet kicked the food!", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if(random > 60)
                {
                    MessageBox.Show("The pet has eaten all the previous food");
                    pictureBox1.BackgroundImage = Properties.Resources.feeder_empty;
                }
            }
            else if (random >25)
            {
                MessageBox.Show("The pet has eaten half of the previous food");
                pictureBox1.BackgroundImage = Properties.Resources.feeder_half;
            }
            else
            {
                MessageBox.Show("The pet did not eat the previous food");
                pictureBox1.BackgroundImage = Properties.Resources.feeder_full;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (timer1.Enabled)
            {
                timer1.Enabled = false;
            }
            else
            {
                timer1.Enabled = true;
            }

            seconds = Int32.Parse(comboBox3.Text);
            minutes = Int32.Parse(comboBox2.Text);
            hours = Int32.Parse(comboBox1.Text);

            MessageBox.Show("Schedule for feeder is set!");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Hide();
            MessageBox.Show("Good, you cleaned the mess");
        }

        
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            seconds--;

            if (seconds == 0)
            {
                if (minutes != 0)
                {
                    seconds = 59;
                    minutes--;

                    if (minutes == 0)
                    {
                        if (hours != 0)
                        {
                            minutes = 59;
                            hours--;
                        }
                        else if (hours == 0 && seconds == 0)
                        {
                            timer1.Enabled = false;
                            seconds = 0;
                            minutes = 0;
                            if (radioButton2.Checked)
                            {
                                pictureBox1.BackgroundImage = Properties.Resources.feeder_half;
                            }
                            else
                            {
                                pictureBox1.BackgroundImage = Properties.Resources.feeder_full;
                            }
                            MessageBox.Show("Food dropped");
                        }
                    }
                }
                else
                {
                    timer1.Enabled = false;
                    seconds = 0;
                    if (radioButton2.Checked)
                    {
                        pictureBox1.BackgroundImage = Properties.Resources.feeder_half;
                    }
                    else
                    {
                        pictureBox1.BackgroundImage = Properties.Resources.feeder_full;
                    }
                    MessageBox.Show("Food dropped");

                }
                
            }
            label5.Text = hours.ToString();
            label6.Text = minutes.ToString();
            label8.Text = seconds.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13("Pet Feeder", "If a message pops up with a warning that your pet has done something bad, search the room for a stain and press on it to clean it up. " +
                            "To schedule when the automatic pet feeder will drop food, set the timer by choosing the hours and minutes through the comboboxes and then choose the ammount of the food to get dropped, by choosing a radio button. " +
                            "Finally press the button 'Set Timer' to activate it. " +
                            "In case you want to sign-out, press the 'Sign-Out' button on the top-right next to your username. " +
                            "If you want to go back a page, click the blue arrow on the top-left. " +
                            "If you want to exit the Pet Feeder and go back to the devices' page, press the button 'Exit Pet Feeder' on the top-left. " +
                            "Finally, if you want to exit the application, press the 'Exit' button on the top-left of the form.");
            form13.Show();
        }

        private void exitPetFeederToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form2 = new Form2(userToolStripMenuItem.Text);
            form2.Show();
        }
    }
}
