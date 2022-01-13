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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        public Form8(String selection)
        {
            InitializeComponent();
            this.Text = selection;
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            if (this.Text.Equals("Casual"))
            {
                this.BackgroundImage = Properties.Resources.casual;
                pictureBox1.Image = Properties.Resources.casual1;
                pictureBox2.Image = Properties.Resources.casual2;
                pictureBox3.Image = Properties.Resources.casual3;
            }
            else if (this.Text.Equals("Formal"))
            {
                this.BackgroundImage = Properties.Resources.formal;
                pictureBox1.Image = Properties.Resources.formal1;
                pictureBox2.Image = Properties.Resources.formal2;
                pictureBox3.Image = Properties.Resources.formal3;
            }
            else if (this.Text.Equals("Athletic"))
            {
                this.BackgroundImage = Properties.Resources.athletic;
                pictureBox1.Image = Properties.Resources.athletic1;
                pictureBox2.Image = Properties.Resources.athletic2;
                pictureBox3.Image = Properties.Resources.athletic3;
            }
            else if (this.Text.Equals("Rainy Day"))
            {
                this.BackgroundImage = Properties.Resources.rainy1;
            }
        }
    }
}
