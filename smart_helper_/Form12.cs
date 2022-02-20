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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        public Form12(String username, String activity, String date, String transportation, bool coffee, String route)
        {
            InitializeComponent();
            userToolStripMenuItem.Text = username;
            dataGridView1.Rows.Add(activity,date, transportation, coffee, route);
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
    }
}
