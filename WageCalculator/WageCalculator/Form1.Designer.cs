namespace WageCalculator
{
    partial class wage
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
            this.txtHourlywage = new System.Windows.Forms.TextBox();
            this.txtWeeklyhours = new System.Windows.Forms.TextBox();
            this.lblhourlywage = new System.Windows.Forms.Label();
            this.lblWeeklyhours = new System.Windows.Forms.Label();
            this.lblGrossearning = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblFWT = new System.Windows.Forms.Label();
            this.lblNestearning = new System.Windows.Forms.Label();
            this.lblFWToutput = new System.Windows.Forms.Label();
            this.lblNetearningoutput = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHourlywage
            // 
            this.txtHourlywage.Location = new System.Drawing.Point(274, 26);
            this.txtHourlywage.Name = "txtHourlywage";
            this.txtHourlywage.Size = new System.Drawing.Size(78, 20);
            this.txtHourlywage.TabIndex = 0;
            this.txtHourlywage.Text = "0";
            this.txtHourlywage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtWeeklyhours
            // 
            this.txtWeeklyhours.Location = new System.Drawing.Point(274, 86);
            this.txtWeeklyhours.Name = "txtWeeklyhours";
            this.txtWeeklyhours.Size = new System.Drawing.Size(77, 20);
            this.txtWeeklyhours.TabIndex = 1;
            this.txtWeeklyhours.Text = "0";
            this.txtWeeklyhours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblhourlywage
            // 
            this.lblhourlywage.Location = new System.Drawing.Point(94, 22);
            this.lblhourlywage.Name = "lblhourlywage";
            this.lblhourlywage.Size = new System.Drawing.Size(89, 26);
            this.lblhourlywage.TabIndex = 2;
            this.lblhourlywage.Text = "Hourly Wage:";
            this.lblhourlywage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWeeklyhours
            // 
            this.lblWeeklyhours.Location = new System.Drawing.Point(94, 86);
            this.lblWeeklyhours.Name = "lblWeeklyhours";
            this.lblWeeklyhours.Size = new System.Drawing.Size(76, 24);
            this.lblWeeklyhours.TabIndex = 3;
            this.lblWeeklyhours.Text = "Weekly hours:";
            this.lblWeeklyhours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGrossearning
            // 
            this.lblGrossearning.Location = new System.Drawing.Point(94, 160);
            this.lblGrossearning.Name = "lblGrossearning";
            this.lblGrossearning.Size = new System.Drawing.Size(140, 21);
            this.lblGrossearning.TabIndex = 4;
            this.lblGrossearning.Text = "Gross earnings:";
            this.lblGrossearning.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAnswer
            // 
            this.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAnswer.Location = new System.Drawing.Point(274, 160);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(87, 22);
            this.lblAnswer.TabIndex = 5;
            this.lblAnswer.Text = "0";
            this.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(146, 409);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(88, 25);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblFWT
            // 
            this.lblFWT.Location = new System.Drawing.Point(95, 252);
            this.lblFWT.Name = "lblFWT";
            this.lblFWT.Size = new System.Drawing.Size(75, 35);
            this.lblFWT.TabIndex = 7;
            this.lblFWT.Text = "Less FWT:";
            this.lblFWT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNestearning
            // 
            this.lblNestearning.Location = new System.Drawing.Point(94, 331);
            this.lblNestearning.Name = "lblNestearning";
            this.lblNestearning.Size = new System.Drawing.Size(75, 25);
            this.lblNestearning.TabIndex = 8;
            this.lblNestearning.Text = "Net earning:";
            this.lblNestearning.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFWToutput
            // 
            this.lblFWToutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFWToutput.Location = new System.Drawing.Point(275, 252);
            this.lblFWToutput.Name = "lblFWToutput";
            this.lblFWToutput.Size = new System.Drawing.Size(86, 25);
            this.lblFWToutput.TabIndex = 9;
            this.lblFWToutput.Text = "0";
            this.lblFWToutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNetearningoutput
            // 
            this.lblNetearningoutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNetearningoutput.Location = new System.Drawing.Point(274, 330);
            this.lblNetearningoutput.Name = "lblNetearningoutput";
            this.lblNetearningoutput.Size = new System.Drawing.Size(82, 26);
            this.lblNetearningoutput.TabIndex = 10;
            this.lblNetearningoutput.Text = "0";
            this.lblNetearningoutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(262, 409);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 24);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // wage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 513);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblNetearningoutput);
            this.Controls.Add(this.lblFWToutput);
            this.Controls.Add(this.lblNestearning);
            this.Controls.Add(this.lblFWT);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblGrossearning);
            this.Controls.Add(this.lblWeeklyhours);
            this.Controls.Add(this.lblhourlywage);
            this.Controls.Add(this.txtWeeklyhours);
            this.Controls.Add(this.txtHourlywage);
            this.Name = "wage";
            this.Text = "Wage Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHourlywage;
        private System.Windows.Forms.TextBox txtWeeklyhours;
        private System.Windows.Forms.Label lblhourlywage;
        private System.Windows.Forms.Label lblWeeklyhours;
        private System.Windows.Forms.Label lblGrossearning;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblFWT;
        private System.Windows.Forms.Label lblNestearning;
        private System.Windows.Forms.Label lblFWToutput;
        private System.Windows.Forms.Label lblNetearningoutput;
        private System.Windows.Forms.Button btnClear;
    }
}

