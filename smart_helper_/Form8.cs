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

        public Form8(String selection)
        {
            InitializeComponent();
            this.Text = selection;
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
    }
}
