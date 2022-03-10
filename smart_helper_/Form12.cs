using System;
using System.Windows.Forms;

namespace smart_helper_
{
    public partial class Form12 : Form
    {
        String trans;
        String actvt;

        public Form12()
        {
            InitializeComponent();
        }

        public Form12(String username, String transportation, String activity)
        {
            InitializeComponent();
            userToolStripMenuItem.Text = username;
            trans = transportation;
            actvt = activity;
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

        private void Form12_Load(object sender, EventArgs e)
        {
            if (actvt.Equals("University"))
            {
                if (trans.Equals("Car"))
                {
                    this.BackgroundImage = Properties.Resources.papei_car;
                }
                else if (trans.Equals("Public Transport"))
                {
                    this.BackgroundImage = Properties.Resources.papei_mesa;
                }
            }
            else if (actvt.Equals("Gym"))
            {
                if (trans.Equals("Car"))
                {
                    this.BackgroundImage = Properties.Resources.gym_car;
                }
                else if (trans.Equals("Public Transport"))
                {
                    this.BackgroundImage = Properties.Resources.gym_mesa;
                }
                else if (trans.Equals("On foot"))
                {
                    this.BackgroundImage = Properties.Resources.gym_podia;
                }
            }
            else if (actvt.Equals("Drivers' School"))
            {
                if (trans.Equals("Car"))
                {
                    this.BackgroundImage = Properties.Resources.driver_car;
                }
                else if (trans.Equals("Public Transport"))
                {
                    this.BackgroundImage = Properties.Resources.driver_mesa;
                }
                else if (trans.Equals("On foot"))
                {
                    this.BackgroundImage = Properties.Resources.driver_podia;
                }
            }
            else if (actvt.Equals("Night Out"))
            {
                if (trans.Equals("Car"))
                {
                    this.BackgroundImage = Properties.Resources.gazi_car;
                }
                else if (trans.Equals("Public Transport"))
                {
                    this.BackgroundImage = Properties.Resources.gazi_mesa;
                }
            }
            else if (actvt.Equals("Take Away Coffee"))
            {
                if (trans.Equals("Car"))
                {
                    this.BackgroundImage = Properties.Resources.coffee_car;
                }
                else if (trans.Equals("Public Transport"))
                {
                    this.BackgroundImage = Properties.Resources.coffee_mesa;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13("Map", "These are the possible routes to your destination, by the transportation of your choice. " +
                            "In case you want to sign -out, press the 'Sign-Out' button on the top - right next to your username. " +
                            "Finally, if you want to exit the application, press the 'Exit' button on the top-left of the form.");
            form13.Show();
        }
    }
}
