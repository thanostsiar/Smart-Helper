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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        public Form8(String selection, String username)
        {
            InitializeComponent();
            this.Text = selection;
            userToolStripMenuItem.Text = username;
        }

        // Method that gets called after a pair of shoes has been clicked and shows his choise.

        private void showButton(Button b)
        {
            MessageBox.Show(b.Name + " have been chosen. Excellent choise!");
        }

        // Method that gets called as soon ass the user clicks on a pair of shoe.

        private void pressButton(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            showButton(button);
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // Altering the user's shoes, depending on his choise of day plan from the previous form. 

            if (this.Text.Equals("Casual"))
            {
                this.BackgroundImage = Properties.Resources.casual;
                button1.BackgroundImage = Properties.Resources.jordan1;
                button1.Name = "Your Jordan 1 low";
                button2.BackgroundImage = Properties.Resources.casual2;
                button2.Name = "Your blue sneakers";
                button3.BackgroundImage = Properties.Resources.casual3;
                button3.Name = "Your Adidas Stansmith";
                button4.BackgroundImage = Properties.Resources.vans;
                button4.Name = "Your Vans";
                webBrowser1.Hide();
            }
            else if (this.Text.Equals("Formal"))
            {
                this.BackgroundImage = Properties.Resources.formal;
                button1.BackgroundImage = Properties.Resources.formal1;
                button1.Name = "Your black brogues";
                button2.BackgroundImage = Properties.Resources.formal2;
                button2.Name = "Your brown brogues";
                button3.BackgroundImage = Properties.Resources.formal3;
                button3.Name = "Your black Oxfords";
                button4.Hide();
                webBrowser1.Hide();
            }
            else if (this.Text.Equals("Athletic"))
            {
                this.BackgroundImage = Properties.Resources.athletic;
                button1.BackgroundImage = Properties.Resources.athletic1;
                button1.Name = "Your black Jordans athletic shoes";
                button2.BackgroundImage = Properties.Resources.athletic2;
                button2.Name = "Your Adidas athletic shoes";
                button3.BackgroundImage = Properties.Resources.athletic3;
                button3.Name = "Your black Nike athletic shoes";
                button4.Hide();
                webBrowser1.Hide();
            }
            else 
            {
                this.BackgroundImage = Properties.Resources.rainy1;
                button1.Hide();
                button2.Hide();
                button3.Hide();
                button4.Hide();

                MessageBox.Show("Oops! It seems you have no shoes available... I think it's time for some shopping therapy ;)");

            }

            // A list with all the buttons that represent a pair of shoes.

            List<Button> buttons = new List<Button>();
            buttons.Add(button1);
            buttons.Add(button2);
            buttons.Add(button3);
            buttons.Add(button4);

            // Creating a click event for every button in my form.

            foreach (Button b in buttons)
            {
                b.Click += pressButton;
            }
        }

        // Button that when pressed it shows the status of the shoebox.

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.Text.Equals("Casual"))
            {
                MessageBox.Show("Your shoebox seems to be full!");
            }
            else if (this.Text.Equals("Formal") || this.Text.Equals("Athletic"))
            {
                MessageBox.Show("Your shoebox has space for 1 more item!");
            }
            else
            {
                MessageBox.Show("Your shoebox is empty!!!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            this.Close();
            frm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 form3 = new Form3(userToolStripMenuItem.Text);
            form3.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Form13 form13 = new Form13("Shoes", "Choose a pair of shoes of your choice in the category that you have already chosen. " +
                            "Click the button 'Show Status' in order to check the status of the smart shoebox. " +
                            "If no shoes appear, there will be a web page on the right side of the form so you can buy new shoes for this category." +
                            "In case you want to sign-out, press the 'Sign-Out' button on the top-right next to your username. " +
                            "If you want to go back a page, click the blue arrow on the top-left. " +
                            "Finally, if you want to exit the application, press the 'Exit' button on the top-left of the form.");
            form13.Show();
        }
    }
}
