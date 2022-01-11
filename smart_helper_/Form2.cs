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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(String username)
        {
            InitializeComponent();
            label8.Text = username;
        }

        private void Form2_MouseHover(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            label3.Visible = true;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            label4.Visible = true;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            label5.Visible = true;
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            label6.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
        }
    }
}
