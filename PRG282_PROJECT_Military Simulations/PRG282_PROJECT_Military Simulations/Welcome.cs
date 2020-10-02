using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_PROJECT_Military_Simulations
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            loadinglbl.Parent = pictureBox1;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int one = rand.Next(0, 255);
            int two = rand.Next(0, 255);
            int three = rand.Next(0, 255);
            int four = rand.Next(0, 255);

            flashingLabel.ForeColor = Color.FromArgb(one, two, three, four);
            btnDone.ForeColor = Color.FromArgb(one, two, three, four);
            nameTxt.ForeColor = Color.FromArgb(one, two, three, four);
            surnameTxt.ForeColor = Color.FromArgb(one, two, three, four);
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;
        }

        private void LoadingTimer_Tick(object sender, EventArgs e)
        {
            loadingTimer.Stop();
            pictureBox1.Dispose();
            loadinglbl.Dispose();
        }
        private void btnDone_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            string surname = surnameTxt.Text;
            if (name == "" || surname == "")
            {
                MessageBox.Show("Non of the feilds are meant to be empty!!!");
            }
            else
            {
                FileHandler file = new FileHandler();
                if (file.insertUser(name, surname) == true)
                {
                    this.Hide();
                    Instructions inst = new Instructions();
                    inst.Show();
                }
                else
                {
                    DialogResult result = MessageBox.Show("User Already Exists?\nContinue as That user!", "User Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {

                        this.Hide();
                        Instructions inst = new Instructions();
                        inst.Show();
                    } 
                }
            }
            
        }
    }
}
