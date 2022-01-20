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
    public partial class Form4 : Form
    {
        public bool all_lights;

        public Form4()
        {
            InitializeComponent();
        }
        public Form4(String username)
        {
            InitializeComponent();
            userToolStripMenuItem.Text = username;
        }
        public Form4(String username,Form9 form9)
        {
            InitializeComponent();
            userToolStripMenuItem.Text = username;
            all_lights = form9.all_lights;
        }
        

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form2 = new Form2(userToolStripMenuItem.Text);
            form2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            String selection = toolTip1.GetToolTip(pictureBox1);
            Form9 form9 = new Form9(selection, userToolStripMenuItem.Text,this);
            form9.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            String selection = toolTip1.GetToolTip(pictureBox2);
            Form9 form9 = new Form9(selection, userToolStripMenuItem.Text,this);
            form9.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            String selection = toolTip1.GetToolTip(pictureBox3);
            Form9 form9 = new Form9(selection, userToolStripMenuItem.Text,this);
            form9.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            String selection = toolTip1.GetToolTip(pictureBox4);
            Form9 form9 = new Form9(selection, userToolStripMenuItem.Text,this);
            form9.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form2 = new Form2(userToolStripMenuItem.Text);
            form2.Show();
        }
    }
}
