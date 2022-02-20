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

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void Form6_Shown(object sender, EventArgs e)
        {
            Random rand = new Random();
            int random = rand.Next(0, 100);
            if (random > 50)
            {
                pictureBox2.BackgroundImage = Properties.Resources.pet_food;
                MessageBox.Show("The pet kicked the food!", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                pictureBox1.BackgroundImage = Properties.Resources.feeder_empty;
            }
            else 
            {
                pictureBox1.BackgroundImage = Properties.Resources.feeder_full;
            }
            
            MessageBox.Show("Schedule for feeder is set!");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Hide();
            MessageBox.Show("Good, you cleaned the mess");
        }
    }
}
