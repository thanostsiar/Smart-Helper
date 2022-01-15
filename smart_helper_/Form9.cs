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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        public Form9(String selection, String username)
        {
            InitializeComponent();
            this.Text = selection;
            userToolStripMenuItem.Text = username;
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

        private void Form9_Load(object sender, EventArgs e)
        {
            if (this.Text.Equals("Living Room"))
            {
                panel1.BackgroundImage = Properties.Resources.living_room_background;
            }
            else if (this.Text.Equals("Kitchen"))
            {
                panel1.BackgroundImage = Properties.Resources.kitchen_background;
            }
            else if (this.Text.Equals("Bedroom"))
            {
                panel1.BackgroundImage = Properties.Resources.bedroom_background;
            }
            else
            {
                panel1.BackgroundImage = Properties.Resources.bathroom_background;
            }



        }
    }
}
