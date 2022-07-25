
namespace Example
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonSingIn = new System.Windows.Forms.Button();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(209, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sing In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(18, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(18, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUsername.Location = new System.Drawing.Point(140, 76);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(267, 34);
            this.textBoxUsername.TabIndex = 3;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassword.Location = new System.Drawing.Point(140, 164);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(267, 34);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // buttonSingIn
            // 
            this.buttonSingIn.Enabled = false;
            this.buttonSingIn.Location = new System.Drawing.Point(101, 243);
            this.buttonSingIn.Name = "buttonSingIn";
            this.buttonSingIn.Size = new System.Drawing.Size(75, 23);
            this.buttonSingIn.TabIndex = 5;
            this.buttonSingIn.Text = "Sing In";
            this.buttonSingIn.UseVisualStyleBackColor = true;
            this.buttonSingIn.Click += new System.EventHandler(this.buttonSingIn_Click);
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.Location = new System.Drawing.Point(183, 243);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(91, 23);
            this.buttonRegistration.TabIndex = 6;
            this.buttonRegistration.Text = "Registration";
            this.buttonRegistration.UseVisualStyleBackColor = true;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(280, 243);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 7;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.ForeColor = System.Drawing.Color.Red;
            this.labelUsername.Location = new System.Drawing.Point(140, 113);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(138, 15);
            this.labelUsername.TabIndex = 8;
            this.labelUsername.Text = "Usewrname is not empty";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.ForeColor = System.Drawing.Color.Red;
            this.labelPassword.Location = new System.Drawing.Point(138, 201);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(126, 15);
            this.labelPassword.TabIndex = 9;
            this.labelPassword.Text = "Password is not empty";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxUsername);
            this.panel1.Controls.Add(this.labelPassword);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelUsername);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonReset);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonRegistration);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.buttonSingIn);
            this.panel1.Location = new System.Drawing.Point(53, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 282);
            this.panel1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 322);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonSingIn;
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Panel panel1;
    }
}

