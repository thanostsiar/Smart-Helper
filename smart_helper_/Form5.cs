using System;
using System.Windows.Forms;

namespace smart_helper_
{
    public partial class Form5 : Form
    {
        public bool all_heat;

        public Form5()
        {
            InitializeComponent();
        }
        public Form5(String username)
        {
            InitializeComponent();
            userToolStripMenuItem.Text = username;
        }
        public Form5(String username,Form10 form10)
        {
            InitializeComponent();
            userToolStripMenuItem.Text = username;
            all_heat = form10.all_heat;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            String selection = toolTip1.GetToolTip(pictureBox1);
            Form10 form10 = new Form10(selection, userToolStripMenuItem.Text,this);
            form10.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            String selection = toolTip1.GetToolTip(pictureBox2);
            Form10 form10 = new Form10(selection, userToolStripMenuItem.Text,this);
            form10.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            String selection = toolTip1.GetToolTip(pictureBox3);
            Form10 form10 = new Form10(selection, userToolStripMenuItem.Text,this);
            form10.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            String selection = toolTip1.GetToolTip(pictureBox4);
            Form10 form10 = new Form10(selection, userToolStripMenuItem.Text,this);
            form10.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form2 = new Form2(userToolStripMenuItem.Text);
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13("Smart Heat", "Hover over the pictures of the rooms to learn about them and click on them in order to proceed. " +
                            "In case you want to sign-out, press the 'Sign-Out' button on the top-right next to your username. " +
                            "If you want to go back a page, click the blue arrow on the top-left. " +
                            "If you want to exit the smart lights and go back to the devices' page, press the button 'Exit Heat' on the top-left. " +
                            "Finally, if you want to exit the application, press the 'Exit' button on the top-left of the form.");
            form13.Show();
        }
    }
}
