
namespace HomeWork_CathMe
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
            this.buttonCatchMe = new System.Windows.Forms.Button();
            this.progressBarStep = new System.Windows.Forms.ProgressBar();
            this.labelStep = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCatchMe
            // 
            this.buttonCatchMe.Location = new System.Drawing.Point(350, 391);
            this.buttonCatchMe.Name = "buttonCatchMe";
            this.buttonCatchMe.Size = new System.Drawing.Size(75, 23);
            this.buttonCatchMe.TabIndex = 0;
            this.buttonCatchMe.Text = "Catch Me";
            this.buttonCatchMe.UseVisualStyleBackColor = true;
            this.buttonCatchMe.Click += new System.EventHandler(this.Form1_Load);
            this.buttonCatchMe.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonCatchMe_MouseMove);
            // 
            // progressBarStep
            // 
            this.progressBarStep.Location = new System.Drawing.Point(27, 68);
            this.progressBarStep.Name = "progressBarStep";
            this.progressBarStep.Size = new System.Drawing.Size(747, 23);
            this.progressBarStep.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarStep.TabIndex = 1;
            this.progressBarStep.Click += new System.EventHandler(this.buttonCatchMe_Click);
            // 
            // labelStep
            // 
            this.labelStep.AutoSize = true;
            this.labelStep.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStep.Location = new System.Drawing.Point(27, 28);
            this.labelStep.Name = "labelStep";
            this.labelStep.Size = new System.Drawing.Size(52, 25);
            this.labelStep.TabIndex = 2;
            this.labelStep.Text = "Step:";
            this.labelStep.TextChanged += new System.EventHandler(this.buttonCatchMe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.labelStep);
            this.Controls.Add(this.progressBarStep);
            this.Controls.Add(this.buttonCatchMe);
            this.MaximumSize = new System.Drawing.Size(900, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.buttonCatchMe_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCatchMe;
        private System.Windows.Forms.ProgressBar progressBarStep;
        private System.Windows.Forms.Label labelStep;
    }
}

