using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example
{
    public partial class Form1 : Form
    {
        public string password { get; set; } = "admin";
        public string login { get; set; } = "admin";
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            this.textBoxPassword.Text = string.Empty;
            this.textBoxUsername.Text = string.Empty;
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry service not impl(", "Informtion", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void buttonSingIn_Click(object sender, EventArgs e)
        {
            if (this.textBoxUsername.Text.Equals(login) && this.textBoxPassword.Text.Equals(password))
            {
                MessageBox.Show($"Welcome {login}", "HI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.panel1.Visible = false;
            }
            else MessageBox.Show("Data error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (!String.IsNullOrWhiteSpace(this.textBoxUsername.Text))
            {
                this.labelUsername.Visible = false;
            }
            else
            {
                this.labelUsername.Visible = true;
            } 
            if (!String.IsNullOrWhiteSpace(this.textBoxPassword.Text))
            {
                this.labelPassword.Visible = false;
            }
            else
            {
                this.labelPassword.Visible = true;
            }
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //if (!String.IsNullOrWhiteSpace(this.textBoxUsername.Text) && !String.IsNullOrWhiteSpace(this.textBoxPassword.Text))
            //{

            //}
            //else
            //{
            //    MessageBox.Show("Data not enter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(this.textBoxUsername.Text))
            {
                this.labelUsername.Visible = false;

                if (!string.IsNullOrWhiteSpace(this.textBoxPassword.Text))
                {
                    this.buttonSingIn.Enabled = true;
                }
                else this.buttonSingIn.Enabled = false;
            }
            else
            {
                this.labelUsername.Visible = true;
                this.buttonSingIn.Enabled = false;
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(this.textBoxPassword.Text))
            {
                this.labelPassword.Visible = false;
                if (!string.IsNullOrWhiteSpace(this.textBoxUsername.Text))
                {
                    this.buttonSingIn.Enabled = true;
                }
                else this.buttonSingIn.Enabled = false;
            }
            else
            {
                this.labelPassword.Visible = true;
                this.buttonSingIn.Enabled = false;
            }
        }
    }
}
