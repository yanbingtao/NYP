namespace payment
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTime = new System.Windows.Forms.Label();
            this.lblPaymentperhr = new System.Windows.Forms.Label();
            this.lblPaymentintotal = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtPaymentperhr = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(39, 112);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(113, 33);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Weekly time:";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPaymentperhr
            // 
            this.lblPaymentperhr.Location = new System.Drawing.Point(39, 77);
            this.lblPaymentperhr.Name = "lblPaymentperhr";
            this.lblPaymentperhr.Size = new System.Drawing.Size(100, 21);
            this.lblPaymentperhr.TabIndex = 1;
            this.lblPaymentperhr.Text = "Hourly wage:";
            this.lblPaymentperhr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPaymentintotal
            // 
            this.lblPaymentintotal.Location = new System.Drawing.Point(49, 241);
            this.lblPaymentintotal.Name = "lblPaymentintotal";
            this.lblPaymentintotal.Size = new System.Drawing.Size(126, 26);
            this.lblPaymentintotal.TabIndex = 2;
            this.lblPaymentintotal.Text = "Gross Earnings:";
            this.lblPaymentintotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(160, 125);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(86, 20);
            this.txtTime.TabIndex = 3;
            this.txtTime.Text = "0";
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPaymentperhr
            // 
            this.txtPaymentperhr.Location = new System.Drawing.Point(158, 78);
            this.txtPaymentperhr.Name = "txtPaymentperhr";
            this.txtPaymentperhr.Size = new System.Drawing.Size(88, 20);
            this.txtPaymentperhr.TabIndex = 4;
            this.txtPaymentperhr.Text = "0";
            this.txtPaymentperhr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAnswer
            // 
            this.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAnswer.Location = new System.Drawing.Point(155, 241);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(91, 26);
            this.lblAnswer.TabIndex = 5;
            this.lblAnswer.Text = "0";
            this.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 375);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.txtPaymentperhr);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lblPaymentintotal);
            this.Controls.Add(this.lblPaymentperhr);
            this.Controls.Add(this.lblTime);
            this.Name = "Form1";
            this.Text = "Form1";
            //this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblPaymentperhr;
        private System.Windows.Forms.Label lblPaymentintotal;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtPaymentperhr;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button button1;
    }
}

