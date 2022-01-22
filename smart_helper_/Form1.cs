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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text;
            String password = textBox2.Text;

            User user = new User(username, password);

            if (String.IsNullOrWhiteSpace(user.Username) || String.IsNullOrWhiteSpace(user.Password))
            {
                MessageBox.Show("Please fill all the blanks!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Form2 form2 = new Form2(user.Username);
                form2.Show();
                this.Hide();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // The textbox for inserting the username will only accept letters, numbers and the underscore.

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)08) || e.KeyChar.Equals((char)95)))
            {
                e.Handled = true;
            }
        }
    }
}
