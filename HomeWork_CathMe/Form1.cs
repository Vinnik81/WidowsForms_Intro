using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork_CathMe
{
    public partial class Form1 : Form
    {
        int i;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"X : {e.X}, Y : {e.Y}";
        }

        private void buttonCatchMe_Click(object sender, EventArgs e)
        {
            if (progressBarStep.Value < 100)
            { 
                progressBarStep.Value += 5;
            labelStep.Text = "Step: " + ((i/2) + 1).ToString();
            i++;
            }
            else MessageBox.Show("You've run out of attempts!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            
        }

        private void buttonCatchMe_MouseMove(object sender, MouseEventArgs e)
        {
            if ((Location.X == 220 && Location.Y == 340) || (Location.X == 390 && Location.Y == 405) || (Location.X == 703 && Location.Y == 177)) 
            {
                this.buttonCatchMe_Click(sender, e);
                MessageBox.Show("You have won!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                Random rnd = new Random();
                this.buttonCatchMe.Location = new Point(rnd.Next(Location.X, 800), rnd.Next(Location.Y, 400));
            }
        }
    }
}
