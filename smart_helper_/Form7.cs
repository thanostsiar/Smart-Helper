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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        public Form7(String username)
        {
            InitializeComponent();
            userToolStripMenuItem.Text = username;
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form11 form11 = new Form11(userToolStripMenuItem.Text, "Feed Pet");
            form11.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
            Form11 form11 = new Form11(userToolStripMenuItem.Text, "Coffee");
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
            this.Close();
            Form12 form12 = new Form12();
            form12.Show();
        }
    }
}
