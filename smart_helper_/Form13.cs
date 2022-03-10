using System;
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
