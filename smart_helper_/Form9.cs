using System;
using System.Drawing;
using System.Windows.Forms;

namespace smart_helper_
{
    public partial class Form9 : Form
    {
        public bool all_lights;
        int seconds, minutes, hours;

        public Form9()
        {
            InitializeComponent();
        }

        public Form9(String selection, String username,Form4 form4)
        {
            InitializeComponent();
            this.Text = selection;
            userToolStripMenuItem.Text = username;
            all_lights = form4.all_lights;
        }


        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form2 = new Form2(userToolStripMenuItem.Text);
            form2.Show();
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

        private void Form9_Load(object sender, EventArgs e)
        {
            if (all_lights == false)
            {
                pictureBox1.Hide();
                if (this.Text.Equals("Living Room"))
                {
                    panel1.BackgroundImage = Properties.Resources.lights_off;
                }
                else if (this.Text.Equals("Kitchen"))
                {
                    panel1.BackgroundImage = Properties.Resources.kitchen_off;
                }
                else if (this.Text.Equals("Bedroom"))
                {
                    panel1.BackgroundImage = Properties.Resources.bedroom_off;
                }
                else
                {
                    panel1.BackgroundImage = Properties.Resources.bathroom_off;
                }
            }
            else if (all_lights == true)
            {
                pictureBox1.Show();
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible)
            {
                pictureBox1.Hide();

                if (this.Text.Equals("Living Room"))
                {
                    panel1.BackgroundImage = Properties.Resources.lights_off;
                }
                else if (this.Text.Equals("Kitchen"))
                {
                    panel1.BackgroundImage = Properties.Resources.kitchen_off;
                }
                else if (this.Text.Equals("Bedroom"))
                {
                    panel1.BackgroundImage = Properties.Resources.bedroom_off;
                }
                else
                {
                    panel1.BackgroundImage = Properties.Resources.bathroom_off;
                }
            }
            else
            {
                pictureBox1.Show();

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
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bitmap;
            Color c;
            int A, R, G, B;
            int width, height;

            // Creating a Bitmap instance of the panel's background image.

            if (this.Text.Equals("Living Room"))
            {
                bitmap = new Bitmap(Properties.Resources.living_room_background);
                width = bitmap.Width;
                height = bitmap.Height;

            }
            else if (this.Text.Equals("Kitchen"))
            {
                bitmap = new Bitmap(Properties.Resources.kitchen_background);
                width = bitmap.Width;
                height = bitmap.Height;
            }
            else if (this.Text.Equals("Bedroom"))
            {
                bitmap = new Bitmap(Properties.Resources.bedroom_background);
                width = bitmap.Width;
                height = bitmap.Height; ;
            }
            else
            {
                bitmap = new Bitmap(Properties.Resources.bathroom_background);
                width = bitmap.Width;
                height = bitmap.Height;
            }

            // Creating the new color using the old image's arbg, according to the user's choice of color. 

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                A = colorDialog1.Color.A;
                R = colorDialog1.Color.R;
                G = colorDialog1.Color.G;
                B = colorDialog1.Color.B;

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        c = bitmap.GetPixel(x, y);

                        int a = (int)(c.A + (1 - c.A / 255.0) * A);
                        int r = (int)(c.R + (1 - c.R / 255.0) * R);
                        int g = (int)(c.G + (1 - c.G / 255.0) * G);
                        int b = (int)(c.B + (1 - c.B / 255.0) * B);

                        bitmap.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                    }
                }
                panel1.BackgroundImage = bitmap;
                pictureBox3.BackColor = colorDialog1.Color;
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

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (this.Text.Equals("Living Room"))
            {
                switch (trackBar1.Value)
                {
                    case 0:
                        panel1.BackgroundImage = Properties.Resources.lights_off;
                        break;
                    case 1:
                        panel1.BackgroundImage = Properties.Resources.living_room_little;
                        break;
                    case 2:
                        panel1.BackgroundImage = Properties.Resources.living_room_semi;
                        break;
                    case 3:
                        panel1.BackgroundImage = Properties.Resources.living_room_background;
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
                        panel1.BackgroundImage = Properties.Resources.kitchen_off;
                        break;
                    case 1:
                        panel1.BackgroundImage = Properties.Resources.kitchen_little;
                        break;
                    case 2:
                        panel1.BackgroundImage = Properties.Resources.kitchen_semi;
                        break;
                    case 3:
                        panel1.BackgroundImage = Properties.Resources.kitchen_background;
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
                        panel1.BackgroundImage = Properties.Resources.bedroom_off;
                        break;
                    case 1:
                        panel1.BackgroundImage = Properties.Resources.bedroom_little;
                        break;
                    case 2:
                        panel1.BackgroundImage = Properties.Resources.bedroom_semi;
                        break;
                    case 3:
                        panel1.BackgroundImage = Properties.Resources.bedroom_background;
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
                        panel1.BackgroundImage = Properties.Resources.bathroom_off;
                        break;
                    case 1:
                        panel1.BackgroundImage = Properties.Resources.bathroom_little;
                        break;
                    case 2:
                        panel1.BackgroundImage = Properties.Resources.bathroom_semi;
                        break;
                    case 3:
                        panel1.BackgroundImage = Properties.Resources.bathroom_background;
                        break;
                    default:
                        break;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label6.Text = "0";
            label8.Text = "0";
            label10.Text = "0";

            timer1.Enabled = false;
            pictureBox2.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 form4 = new Form4(userToolStripMenuItem.Text, this);
            form4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13("Smart Lights", "If you want to open the room's lights, press the button 'Room Lights'. If you want to open the lights for every room, " +
                            "press the button 'All Lights'. In case you want to alter the brightness of the lights, use the slider with the label 'Intensity of Lights'. " +
                            "If you want to change the color of the lights, then press the button 'Change Color'. " +
                            "You have the capability to set a timer in order for the lights to open automatically. For this to happen, choose the hours, minutes and seconds " +
                            "through the comboboxes and then press the button 'Activate/Deactivate'. In order to reset the timer, press the button 'Reset'. " +
                            "In case you want to sign-out, press the 'Sign-Out' button on the top-right next to your username. " +
                            "If you want to go back a page, click the blue arrow on the top-left. " +
                            "If you want to exit the smart lights and go back to the devices' page, press the button 'Exit Lights' on the top-left. " +
                            "Finally, if you want to exit the application, press the 'Exit' button on the top-left of the form.");
            form13.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible)
            {
                pictureBox1.Hide();
                all_lights = false;

                if (this.Text.Equals("Living Room"))
                {
                    panel1.BackgroundImage = Properties.Resources.lights_off;
                }
                else if (this.Text.Equals("Kitchen"))
                {
                    panel1.BackgroundImage = Properties.Resources.kitchen_off;
                }
                else if (this.Text.Equals("Bedroom"))
                {
                    panel1.BackgroundImage = Properties.Resources.bedroom_off;
                }
                else
                {
                    panel1.BackgroundImage = Properties.Resources.bathroom_off;
                }
            }
            else
            {
                pictureBox1.Show();
                all_lights = true;

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
    }
}
