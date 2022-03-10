using System;
using System.Windows.Forms;

namespace smart_helper_
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(String username)
        {
            InitializeComponent();
            userToolStripMenuItem.Text = username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String selection = comboBox1.Text;
            Form8 form8 = new Form8(selection, userToolStripMenuItem.Text);
            form8.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ah that smells nice!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            this.Close();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You exited the smart showbox!");
            this.Close();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
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

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form2 = new Form2(userToolStripMenuItem.Text);
            form2.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form13 form13 = new Form13("Smart Shoebox", "Choose one of the daily options in the combobox (Casual, Formal, Athletic, Rainy Day) and then press the " +
                            "button 'Submit' in order to select the appropriate shoes for the occasion. Press the spray can on top, in order to spray perfume inside the shoebox. " +
                            "In case you want to sign-out, press the 'Sign-Out' button on the top-right next to your username. " +
                            "If you want to go back a page, click the blue arrow on the top-left. " +
                            "If you want to exit the shoebox and go back to the devices' page, press the button 'Exit Shoebox' on the top-left. " +
                            "Finally, if you want to exit the application, press the 'Exit' button on the top-left of the form.");
            form13.Show();
        }
    }
}
