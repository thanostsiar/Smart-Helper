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
        int counter = 0;
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
            Form7 form7 = new Form7();
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
                counter++;

                if (counter == 2)
                {
                    MessageBox.Show("You have already made your plans for this activity!", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    dataGridView1.Rows.Add(label4.Text, dateTimePicker1.Text, comboBox1.SelectedItem.ToString(), radioButton1.Checked, route);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "route")
            {
                Form12 form12 = new Form12(userToolStripMenuItem.Text, comboBox1.SelectedItem.ToString(), label4.Text);
                form12.Show();
            }
        }
    }
}
