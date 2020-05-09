namespace currency_converter
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
            this.txtDollars = new System.Windows.Forms.TextBox();
            this.txtConvertto = new System.Windows.Forms.TextBox();
            this.lblDollars = new System.Windows.Forms.Label();
            this.lblconvertto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDollars
            // 
            this.txtDollars.Location = new System.Drawing.Point(286, 69);
            this.txtDollars.Name = "txtDollars";
            this.txtDollars.Size = new System.Drawing.Size(111, 20);
            this.txtDollars.TabIndex = 0;
            this.txtDollars.Text = "0";
            this.txtDollars.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtConvertto
            // 
            this.txtConvertto.Location = new System.Drawing.Point(286, 112);
            this.txtConvertto.Name = "txtConvertto";
            this.txtConvertto.Size = new System.Drawing.Size(110, 20);
            this.txtConvertto.TabIndex = 1;
            this.txtConvertto.Text = "Currency";
            this.txtConvertto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDollars
            // 
            this.lblDollars.Location = new System.Drawing.Point(148, 68);
            this.lblDollars.Name = "lblDollars";
            this.lblDollars.Size = new System.Drawing.Size(132, 21);
            this.lblDollars.TabIndex = 2;
            this.lblDollars.Text = "Dollars to Convert:";
            this.lblDollars.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblconvertto
            // 
            this.lblconvertto.Location = new System.Drawing.Point(148, 112);
            this.lblconvertto.Name = "lblconvertto";
            this.lblconvertto.Size = new System.Drawing.Size(132, 32);
            this.lblconvertto.TabIndex = 3;
            this.lblconvertto.Text = "Convert from Dollars to:";
            this.lblconvertto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(151, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Converted amount:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAnswer
            // 
            this.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAnswer.Location = new System.Drawing.Point(286, 173);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(116, 22);
            this.lblAnswer.TabIndex = 5;
            this.lblAnswer.Text = "0";
            this.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(226, 228);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(95, 31);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 312);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblconvertto);
            this.Controls.Add(this.lblDollars);
            this.Controls.Add(this.txtConvertto);
            this.Controls.Add(this.txtDollars);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDollars;
        private System.Windows.Forms.TextBox txtConvertto;
        private System.Windows.Forms.Label lblDollars;
        private System.Windows.Forms.Label lblconvertto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnConvert;
    }
}

