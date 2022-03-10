using System;
using System.Windows.Forms;

namespace smart_helper_
{
    public partial class Form10 : Form
    {
        public bool all_heat;
        int seconds, minutes, hours;
        public Form10()
        {
            InitializeComponent();
        }

        public Form10(String selection, String username,Form5 form5)
        {
            InitializeComponent();
            this.Text = selection;
            userToolStripMenuItem.Text = username;
            all_heat = form5.all_heat;
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form2 = new Form2(userToolStripMenuItem.Text);
            form2.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            if (all_heat == false)
            {
                pictureBox1.Hide();
                if (this.Text.Equals("Living Room"))
                {
                    panel1.BackgroundImage = Properties.Resources.living_room_background;
                }
                else if (this.Text.Equals("Kitchen"))
                {
                    panel1.BackgroundImage = Properties.Resources.kitchen_background;
                }
                else if (this.Text.Equals("Bedroom"))
                {
                    panel1.BackgroundImage = Properties.Resources.bedroom_background;
                }
                else
                {
                    panel1.BackgroundImage = Properties.Resources.bathroom_background;
                }
            }
            else if(all_heat == true)
            {
                pictureBox1.Show();
                if (this.Text.Equals("Living Room"))
                {
                    panel1.BackgroundImage = Properties.Resources.living_room_warm;
                }
                else if (this.Text.Equals("Kitchen"))
                {
                    panel1.BackgroundImage = Properties.Resources.kitchen_warm;
                }
                else if (this.Text.Equals("Bedroom"))
                {
                    panel1.BackgroundImage = Properties.Resources.bedroom_warm;
                }
                else
                {
                    panel1.BackgroundImage = Properties.Resources.bathroom_warm;
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible)
            {
                pictureBox1.Hide();

                if (this.Text.Equals("Living Room"))
                {
                    panel1.BackgroundImage = Properties.Resources.living_room_background;
                }
                else if (this.Text.Equals("Kitchen"))
                {
                    panel1.BackgroundImage = Properties.Resources.kitchen_background;
                }
                else if (this.Text.Equals("Bedroom"))
                {
                    panel1.BackgroundImage = Properties.Resources.bedroom_background;
                }
                else
                {
                    panel1.BackgroundImage = Properties.Resources.bathroom_background;
                }
            }
            else
            {
                pictureBox1.Show();

                if (this.Text.Equals("Living Room"))
                {
                    panel1.BackgroundImage = Properties.Resources.living_room_warm;
                }
                else if (this.Text.Equals("Kitchen"))
                {
                    panel1.BackgroundImage = Properties.Resources.kitchen_warm;
                }
                else if (this.Text.Equals("Bedroom"))
                {
                    panel1.BackgroundImage = Properties.Resources.bedroom_warm;
                }
                else
                {
                    panel1.BackgroundImage = Properties.Resources.bathroom_warm;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
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
                            pictureBox2.Hide();
                            seconds = 0;
                            minutes = 0;
                            button1_Click(sender, e);
                        }
                    }
                }
                else
                {
                    timer1.Enabled = false;
                    pictureBox2.Hide();
                    seconds = 0;
                    button1_Click(sender, e);
                }
            }

            label6.Text = hours.ToString();
            label8.Text = minutes.ToString();
            label10.Text = seconds.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label6.Text = "0";
            label8.Text = "0";
            label10.Text = "0";

            timer1.Enabled = false;
            pictureBox2.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible)
            {
                pictureBox1.Hide();
                all_heat = false;

                if (this.Text.Equals("Living Room"))
                {
                    panel1.BackgroundImage = Properties.Resources.living_room_background;
                }
                else if (this.Text.Equals("Kitchen"))
                {
                    panel1.BackgroundImage = Properties.Resources.kitchen_background;
                }
                else if (this.Text.Equals("Bedroom"))
                {
                    panel1.BackgroundImage = Properties.Resources.bedroom_background;
                }
                else
                {
                    panel1.BackgroundImage = Properties.Resources.bathroom_background;
                }
            }
            else
            {
                pictureBox1.Show();
                all_heat = true;

                if (this.Text.Equals("Living Room"))
                {
                    panel1.BackgroundImage = Properties.Resources.living_room_warm;
                }
                else if (this.Text.Equals("Kitchen"))
                {
                    panel1.BackgroundImage = Properties.Resources.kitchen_warm;
                }
                else if (this.Text.Equals("Bedroom"))
                {
                    panel1.BackgroundImage = Properties.Resources.bedroom_warm;
                }
                else
                {
                    panel1.BackgroundImage = Properties.Resources.bathroom_warm;
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
            Form5 form5 = new Form5(userToolStripMenuItem.Text, this);
            form5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13("Smart Heat", "If you want to turn on the room's heating, press the button 'Room Heat'. If you want to turn on the heating for every room, " +
                            "press the button 'House Heat'. In case you want to alter the temperature of the heating, use the slider with the label 'Adjust Heat'. " +
                            "You have the capability to set a timer in order for the heating to get turned on automatically. For this to happen, choose the hours, minutes and seconds " +
                            "through the comboboxes and then press the button 'Activate/Deactivate'. In order to reset the timer, press the button 'Reset'. " +
                            "In case you want to sign-out, press the 'Sign-Out' button on the top-right next to your username. " +
                            "If you want to go back a page, click the blue arrow on the top-left. " +
                            "If you want to exit the smart heat and go back to the devices' page, press the button 'Exit Heat' on the top-left. " +
                            "Finally, if you want to exit the application, press the 'Exit' button on the top-left of the form.");
            form13.Show();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (this.Text.Equals("Living Room"))
            {
                switch (trackBar1.Value)
                {
                    case 0:
                        panel1.BackgroundImage = Properties.Resources.living_room_background;
                        break;
                    case 1:
                        panel1.BackgroundImage = Properties.Resources.living_room_little_warm;
                        break;
                    case 2:
                        panel1.BackgroundImage = Properties.Resources.living_room_semi_warm;
                        break;
                    case 3:
                        panel1.BackgroundImage = Properties.Resources.living_room_warm;
                        break;
                    default:
                        break;
                }
            }
            else if (this.Text.Equals("Kitchen"))
            {
                switch (trackBar1.Value)
                {
                    case 0:
                        panel1.BackgroundImage = Properties.Resources.kitchen_background;
                        break;
                    case 1:
                        panel1.BackgroundImage = Properties.Resources.kitchen_little_warm;
                        break;
                    case 2:
                        panel1.BackgroundImage = Properties.Resources.kitchen_semi_warm;
                        break;
                    case 3:
                        panel1.BackgroundImage = Properties.Resources.kitchen_warm;
                        break;
                    default:
                        break;
                }
            }
            else if (this.Text.Equals("Bedroom"))
            {
                switch (trackBar1.Value)
                {
                    case 0:
                        panel1.BackgroundImage = Properties.Resources.bedroom_background;
                        break;
                    case 1:
                        panel1.BackgroundImage = Properties.Resources.bedroom_little_warm;
                        break;
                    case 2:
                        panel1.BackgroundImage = Properties.Resources.bedroom_semi_warm;
                        break;
                    case 3:
                        panel1.BackgroundImage = Properties.Resources.bedroom_warm;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (trackBar1.Value)
                {
                    case 0:
                        panel1.BackgroundImage = Properties.Resources.bathroom_background;
                        break;
                    case 1:
                        panel1.BackgroundImage = Properties.Resources.bathroom_little_warm;
                        break;
                    case 2:
                        panel1.BackgroundImage = Properties.Resources.bathroom_semi_warm;
                        break;
                    case 3:
                        panel1.BackgroundImage = Properties.Resources.bathroom_warm;
                        break;
                    default:
                        break;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                pictureBox2.Hide();
            }
            else
            {
                timer1.Enabled = true;
                pictureBox2.Show();
            }

            seconds = Int32.Parse(comboBox3.Text);
            minutes = Int32.Parse(comboBox2.Text);
            hours = Int32.Parse(comboBox1.Text);
        }
    }
}
