using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace smart_helper_
{
    public partial class Form14 : Form
    {
        static List<Day> dayList = new List<Day>();
        String act;
        String dateTime;
        String trans;
        bool cof;
        Image maps;

        public Form14()
        {
            InitializeComponent();
        }

        public Form14(List<Day> dayList)
        {
            InitializeComponent();
            Form14.dayList = dayList;
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

        private void Form14_Load(object sender, EventArgs e)
        {
            foreach (Day day in dayList)
            {
                act = day.activity;
                dateTime = day.date;
                trans = day.transportation;
                cof = day.coffee;
                maps = day.route;

                dataGridView1.Rows.Add(act, dateTime, trans, cof, maps);
            }
            route.ImageLayout = (DataGridViewImageCellLayout)ImageLayout.Stretch;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("route"))
            {
                act = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                trans = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
    
                Form12 form12 = new Form12(userToolStripMenuItem.Text, trans, act);
                form12.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13("My Day", "In this form, your daily plan is being displayed. If you want " +
                            "to see the route to reach your activity's destination, click on the small image of the map " +
                            "that is displayed inside the 'ROUTE' cells. " +
                            "If you want to go back a page, click the blue arrow on the top - left. " +
                            "In case you want to sign-out, press the 'Sign-Out' button on the top-right next to your username. " +
                            "Finally, if you want to exit the application, press the 'Exit' button on the top-left of the form.");
            form13.Show();
        }
    }
}
