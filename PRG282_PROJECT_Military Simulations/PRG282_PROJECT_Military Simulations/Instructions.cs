using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PRG282_PROJECT_Military_Simulations
{
    public partial class Instructions : Form
    {
        private string nm;
        public string srnm;
        public string Name
        {
            get
            {
                return nm;
            }
            set
            {
                nm = value;
            }
        }
        public Instructions()
        {
            InitializeComponent();
        }
        private void Instructions_Load(object sender, EventArgs e)
        {

        }

        private void movement_timer(object sender, EventArgs e)
        {
            Random rand = new Random();
            int one = rand.Next(0, 255);
            int two = rand.Next(0, 255);
            int three = rand.Next(0, 255);
            int four = rand.Next(0, 255);

            label1.ForeColor = Color.FromArgb(one, two, three, four);
            label7.ForeColor = Color.FromArgb(one, two, three, four);
            label9.ForeColor = Color.FromArgb(one, two, three, four);
            for (int i = 0; i < 20; i++)
            {
                if (i == 19)
                {
                    this.Hide();
                    Form1 fr = new Form1();
                    fr.Show();
                    firsttimer.Stop();
                    firsttimer.Enabled = false;
                }
                Thread.Sleep(500);
            }
        }
    }
}
