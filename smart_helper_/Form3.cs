﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String selection = comboBox1.Text;
            Form8 form8 = new Form8(selection);
            form8.Show();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void Form3_MouseHover(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ah that smells nice!");
        }

        
    }
}