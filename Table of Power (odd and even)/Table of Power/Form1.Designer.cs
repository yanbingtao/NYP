namespace Table_of_Power
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
            this.lblUpperlimit = new System.Windows.Forms.Label();
            this.txtUpperlimit = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lstAnswer = new System.Windows.Forms.ListBox();
            this.chkEvenandOdd = new System.Windows.Forms.CheckBox();
            this.chkOdd = new System.Windows.Forms.CheckBox();
            this.chkEven = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblUpperlimit
            // 
            this.lblUpperlimit.Location = new System.Drawing.Point(36, 51);
            this.lblUpperlimit.Name = "lblUpperlimit";
            this.lblUpperlimit.Size = new System.Drawing.Size(114, 25);
            this.lblUpperlimit.TabIndex = 0;
            this.lblUpperlimit.Text = "Upper limit:";
            this.lblUpperlimit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUpperlimit
            // 
            this.txtUpperlimit.Location = new System.Drawing.Point(156, 54);
            this.txtUpperlimit.Name = "txtUpperlimit";
            this.txtUpperlimit.Size = new System.Drawing.Size(98, 20);
            this.txtUpperlimit.TabIndex = 1;
            this.txtUpperlimit.Text = "0";
            this.txtUpperlimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(338, 54);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(143, 24);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lstAnswer
            // 
            this.lstAnswer.FormattingEnabled = true;
            this.lstAnswer.Location = new System.Drawing.Point(23, 121);
            this.lstAnswer.Name = "lstAnswer";
            this.lstAnswer.Size = new System.Drawing.Size(458, 264);
            this.lstAnswer.TabIndex = 3;
            // 
            // chkEvenandOdd
            // 
            this.chkEvenandOdd.Location = new System.Drawing.Point(543, 59);
            this.chkEvenandOdd.Name = "chkEvenandOdd";
            this.chkEvenandOdd.Size = new System.Drawing.Size(106, 20);
            this.chkEvenandOdd.TabIndex = 4;
            this.chkEvenandOdd.Text = "Even and Odd";
            this.chkEvenandOdd.UseVisualStyleBackColor = true;
            //this.chkEvenandOdd.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkOdd
            // 
            this.chkOdd.AutoSize = true;
            this.chkOdd.Location = new System.Drawing.Point(543, 94);
            this.chkOdd.Name = "chkOdd";
            this.chkOdd.Size = new System.Drawing.Size(46, 17);
            this.chkOdd.TabIndex = 5;
            this.chkOdd.Text = "Odd";
            this.chkOdd.UseVisualStyleBackColor = true;
            // 
            // chkEven
            // 
            this.chkEven.AutoSize = true;
            this.chkEven.Location = new System.Drawing.Point(543, 134);
            this.chkEven.Name = "chkEven";
            this.chkEven.Size = new System.Drawing.Size(51, 17);
            this.chkEven.TabIndex = 6;
            this.chkEven.Text = "Even";
            this.chkEven.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 459);
            this.Controls.Add(this.chkEven);
            this.Controls.Add(this.chkOdd);
            this.Controls.Add(this.chkEvenandOdd);
            this.Controls.Add(this.lstAnswer);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtUpperlimit);
            this.Controls.Add(this.lblUpperlimit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUpperlimit;
        private System.Windows.Forms.TextBox txtUpperlimit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ListBox lstAnswer;
        private System.Windows.Forms.CheckBox chkEvenandOdd;
        private System.Windows.Forms.CheckBox chkOdd;
        private System.Windows.Forms.CheckBox chkEven;
    }
}

