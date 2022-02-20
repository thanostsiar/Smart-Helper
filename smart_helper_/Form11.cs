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
    public partial class Form11 : Form
    {
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12(userToolStripMenuItem.Text, label4.Text, dateTimePicker1.Text, comboBox1.SelectedItem.ToString(), radioButton1.Checked, "Hi");
            form12.Show();
        }
    }
}
