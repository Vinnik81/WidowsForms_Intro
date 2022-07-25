using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intro
{
    public partial class DesctopApp : Form
    {
        public DesctopApp()
        {
            InitializeComponent();
            //this.Text = "Vladimir";
            this.comboBox1.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ClickSurname(object sender, EventArgs e)
        {
            
            //Console.Beep(1000, 3000);
            //this.Text = "Vinnik";
           var result = MessageBox.Show("Are you exit?", "Infomation", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            this.Text = result.ToString();
            switch (result)
            {
                case DialogResult.Cancel:
                    MessageBox.Show("Cancel");
                    break;
                case DialogResult.Retry:
                    MessageBox.Show("Retry");
                    break;
                default:
                    break;
            }
        }

        private void ClickName(object sender, EventArgs e)
        {
            //Console.Beep(2000, 3000);
            //this.Text = "Vladimir";
            string str = "";
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 10;
            }
            else MessageBox.Show("Full");
            if (this.CheckNameBox1.Checked)
            {
                str = "Vladimir";
            }

            if (this.CheckSurnameBox2.Checked)
            {
                str += " Vinnik";
            }
            this.Text = str;
        }

        private void DesctopApp_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBoxName.Text = $"X : {e.X}, Y : {e.Y}";
            this.textBoxName.Text = this.dateTimePicker1.Value.ToString();
            //if (e.Button == MouseButtons.Right)
            //{
            //    this.ChangeBtnName.Text = "Vinnik";
            //    this.Text = "Vinnik";
            //}
            //else if (e.Button == MouseButtons.Left)
            //{
            //    this.ChangeBtnSurname.Text = "Vladimir";
            //    this.Text = "Vladimir";
            //}
        }

        private void DesctopApp_MouseMove(object sender, MouseEventArgs e)
        {
            //this.Text = $"X : {e.X}, Y : {e.Y}";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ClientSizeChanged(object sender, EventArgs e)
        {
          
        }

        private void numericUpDown1_Resize(object sender, EventArgs e)
        {
           
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            progressBar1.Value = (int)this.numericUpDown1.Value;
        }
    }
}
