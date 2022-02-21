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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        public Form13(String title, String message)
        {
            InitializeComponent();
            label1.Text = title;
            richTextBox1.Text = message;
        }
    }
}
