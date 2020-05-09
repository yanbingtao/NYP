namespace Car_Payment_Calculator
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
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDownpayment = new System.Windows.Forms.Label();
            this.lblAnnualinterestrate = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDownpayment = new System.Windows.Forms.TextBox();
            this.txtAnnualinterestrate = new System.Windows.Forms.TextBox();
            this.lstPayment = new System.Windows.Forms.ListBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrice
            // 
            this.lblPrice.Location = new System.Drawing.Point(60, 64);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(114, 25);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Price:";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDownpayment
            // 
            this.lblDownpayment.Location = new System.Drawing.Point(58, 99);
            this.lblDownpayment.Name = "lblDownpayment";
            this.lblDownpayment.Size = new System.Drawing.Size(116, 36);
            this.lblDownpayment.TabIndex = 1;
            this.lblDownpayment.Text = "Down payment:";
            this.lblDownpayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAnnualinterestrate
            // 
            this.lblAnnualinterestrate.Location = new System.Drawing.Point(55, 148);
            this.lblAnnualinterestrate.Name = "lblAnnualinterestrate";
            this.lblAnnualinterestrate.Size = new System.Drawing.Size(106, 20);
            this.lblAnnualinterestrate.TabIndex = 2;
            this.lblAnnualinterestrate.Text = "Annual interest rate:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(287, 64);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(85, 20);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.Text = "0";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDownpayment
            // 
            this.txtDownpayment.Location = new System.Drawing.Point(287, 108);
            this.txtDownpayment.Name = "txtDownpayment";
            this.txtDownpayment.Size = new System.Drawing.Size(82, 20);
            this.txtDownpayment.TabIndex = 4;
            this.txtDownpayment.Text = "0";
            this.txtDownpayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAnnualinterestrate
            // 
            this.txtAnnualinterestrate.Location = new System.Drawing.Point(287, 148);
            this.txtAnnualinterestrate.Name = "txtAnnualinterestrate";
            this.txtAnnualinterestrate.Size = new System.Drawing.Size(80, 20);
            this.txtAnnualinterestrate.TabIndex = 5;
            this.txtAnnualinterestrate.Text = "0";
            this.txtAnnualinterestrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lstPayment
            // 
            this.lstPayment.FormattingEnabled = true;
            this.lstPayment.Location = new System.Drawing.Point(58, 234);
            this.lstPayment.Name = "lstPayment";
            this.lstPayment.Size = new System.Drawing.Size(308, 173);
            this.lstPayment.TabIndex = 6;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(115, 188);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(151, 29);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 476);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lstPayment);
            this.Controls.Add(this.txtAnnualinterestrate);
            this.Controls.Add(this.txtDownpayment);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblAnnualinterestrate);
            this.Controls.Add(this.lblDownpayment);
            this.Controls.Add(this.lblPrice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDownpayment;
        private System.Windows.Forms.Label lblAnnualinterestrate;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDownpayment;
        private System.Windows.Forms.TextBox txtAnnualinterestrate;
        private System.Windows.Forms.ListBox lstPayment;
        private System.Windows.Forms.Button btnCalculate;
    }
}

