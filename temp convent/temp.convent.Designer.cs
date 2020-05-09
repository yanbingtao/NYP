namespace Calculator
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
            this.lblFirstnumber = new System.Windows.Forms.Label();
            this.lblSecondnumber = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.txtFirstnumber = new System.Windows.Forms.TextBox();
            this.txtSecondnumber = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnTimes = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFirstnumber
            // 
            this.lblFirstnumber.Location = new System.Drawing.Point(2, 22);
            this.lblFirstnumber.Name = "lblFirstnumber";
            this.lblFirstnumber.Size = new System.Drawing.Size(114, 21);
            this.lblFirstnumber.TabIndex = 0;
            this.lblFirstnumber.Text = "Enter first number:";
            this.lblFirstnumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSecondnumber
            // 
            this.lblSecondnumber.Location = new System.Drawing.Point(2, 74);
            this.lblSecondnumber.Name = "lblSecondnumber";
            this.lblSecondnumber.Size = new System.Drawing.Size(181, 21);
            this.lblSecondnumber.TabIndex = 1;
            this.lblSecondnumber.Text = "Enter second number:";
            this.lblSecondnumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(2, 123);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(73, 32);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Result:";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAnswer
            // 
            this.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAnswer.Location = new System.Drawing.Point(114, 123);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(79, 32);
            this.lblAnswer.TabIndex = 3;
            this.lblAnswer.Text = "0";
            this.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFirstnumber
            // 
            this.txtFirstnumber.Location = new System.Drawing.Point(117, 24);
            this.txtFirstnumber.Name = "txtFirstnumber";
            this.txtFirstnumber.Size = new System.Drawing.Size(76, 20);
            this.txtFirstnumber.TabIndex = 4;
            this.txtFirstnumber.Text = "0";
            this.txtFirstnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSecondnumber
            // 
            this.txtSecondnumber.Location = new System.Drawing.Point(117, 75);
            this.txtSecondnumber.Name = "txtSecondnumber";
            this.txtSecondnumber.Size = new System.Drawing.Size(76, 20);
            this.txtSecondnumber.TabIndex = 5;
            this.txtSecondnumber.Text = "0";
            this.txtSecondnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(228, 22);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(50, 21);
            this.btnPlus.TabIndex = 6;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(321, 23);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(50, 20);
            this.btnMinus.TabIndex = 7;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnTimes
            // 
            this.btnTimes.Location = new System.Drawing.Point(228, 70);
            this.btnTimes.Name = "btnTimes";
            this.btnTimes.Size = new System.Drawing.Size(50, 25);
            this.btnTimes.TabIndex = 8;
            this.btnTimes.Text = "*";
            this.btnTimes.UseVisualStyleBackColor = true;
            this.btnTimes.Click += new System.EventHandler(this.btnTimes_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(321, 70);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(50, 25);
            this.btnDivide.TabIndex = 9;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 324);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnTimes);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtSecondnumber);
            this.Controls.Add(this.txtFirstnumber);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblSecondnumber);
            this.Controls.Add(this.lblFirstnumber);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstnumber;
        private System.Windows.Forms.Label lblSecondnumber;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox txtFirstnumber;
        private System.Windows.Forms.TextBox txtSecondnumber;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnTimes;
        private System.Windows.Forms.Button btnDivide;
    }
}

