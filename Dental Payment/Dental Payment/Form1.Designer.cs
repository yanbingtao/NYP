namespace Dental_Payment
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPatientname = new System.Windows.Forms.Label();
            this.lbl35 = new System.Windows.Forms.Label();
            this.lbl150 = new System.Windows.Forms.Label();
            this.lbl85 = new System.Windows.Forms.Label();
            this.lbl50 = new System.Windows.Forms.Label();
            this.lbl225 = new System.Windows.Forms.Label();
            this.lblOther = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.chkCleaning = new System.Windows.Forms.CheckBox();
            this.chkCavityfilling = new System.Windows.Forms.CheckBox();
            this.chkXray = new System.Windows.Forms.CheckBox();
            this.chkFluoride = new System.Windows.Forms.CheckBox();
            this.chkRootcanal = new System.Windows.Forms.CheckBox();
            this.chkOther = new System.Windows.Forms.CheckBox();
            this.txtPatientname = new System.Windows.Forms.TextBox();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(434, 68);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dental Payment Form";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPatientname
            // 
            this.lblPatientname.Location = new System.Drawing.Point(46, 99);
            this.lblPatientname.Name = "lblPatientname";
            this.lblPatientname.Size = new System.Drawing.Size(89, 21);
            this.lblPatientname.TabIndex = 1;
            this.lblPatientname.Text = "Patient name:";
            this.lblPatientname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl35
            // 
            this.lbl35.Location = new System.Drawing.Point(351, 184);
            this.lbl35.Name = "lbl35";
            this.lbl35.Size = new System.Drawing.Size(47, 19);
            this.lbl35.TabIndex = 2;
            this.lbl35.Text = "$35";
            this.lbl35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl150
            // 
            this.lbl150.Location = new System.Drawing.Point(351, 215);
            this.lbl150.Name = "lbl150";
            this.lbl150.Size = new System.Drawing.Size(47, 19);
            this.lbl150.TabIndex = 3;
            this.lbl150.Text = "$150";
            this.lbl150.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl85
            // 
            this.lbl85.Location = new System.Drawing.Point(351, 246);
            this.lbl85.Name = "lbl85";
            this.lbl85.Size = new System.Drawing.Size(47, 20);
            this.lbl85.TabIndex = 4;
            this.lbl85.Text = "$85";
            this.lbl85.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl50
            // 
            this.lbl50.Location = new System.Drawing.Point(351, 278);
            this.lbl50.Name = "lbl50";
            this.lbl50.Size = new System.Drawing.Size(47, 16);
            this.lbl50.TabIndex = 5;
            this.lbl50.Text = "$50";
            this.lbl50.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl225
            // 
            this.lbl225.Location = new System.Drawing.Point(361, 306);
            this.lbl225.Name = "lbl225";
            this.lbl225.Size = new System.Drawing.Size(37, 16);
            this.lbl225.TabIndex = 6;
            this.lbl225.Text = "$225";
            this.lbl225.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOther
            // 
            this.lblOther.Location = new System.Drawing.Point(351, 335);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(14, 22);
            this.lblOther.TabIndex = 7;
            this.lblOther.Text = "$";
            this.lblOther.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(267, 404);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(42, 20);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAnswer
            // 
            this.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAnswer.Location = new System.Drawing.Point(315, 404);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(96, 20);
            this.lblAnswer.TabIndex = 9;
            this.lblAnswer.Text = "0";
            this.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkCleaning
            // 
            this.chkCleaning.AutoSize = true;
            this.chkCleaning.Location = new System.Drawing.Point(56, 184);
            this.chkCleaning.Name = "chkCleaning";
            this.chkCleaning.Size = new System.Drawing.Size(67, 17);
            this.chkCleaning.TabIndex = 10;
            this.chkCleaning.Text = "Cleaning";
            this.chkCleaning.UseVisualStyleBackColor = true;
            // 
            // chkCavityfilling
            // 
            this.chkCavityfilling.AutoSize = true;
            this.chkCavityfilling.Location = new System.Drawing.Point(56, 217);
            this.chkCavityfilling.Name = "chkCavityfilling";
            this.chkCavityfilling.Size = new System.Drawing.Size(84, 17);
            this.chkCavityfilling.TabIndex = 11;
            this.chkCavityfilling.Text = "Cavity Filling";
            this.chkCavityfilling.UseVisualStyleBackColor = true;
            // 
            // chkXray
            // 
            this.chkXray.AutoSize = true;
            this.chkXray.Location = new System.Drawing.Point(56, 246);
            this.chkXray.Name = "chkXray";
            this.chkXray.Size = new System.Drawing.Size(55, 17);
            this.chkXray.TabIndex = 12;
            this.chkXray.Text = "X-Ray";
            this.chkXray.UseVisualStyleBackColor = true;
            // 
            // chkFluoride
            // 
            this.chkFluoride.AutoSize = true;
            this.chkFluoride.Location = new System.Drawing.Point(56, 276);
            this.chkFluoride.Name = "chkFluoride";
            this.chkFluoride.Size = new System.Drawing.Size(63, 17);
            this.chkFluoride.TabIndex = 13;
            this.chkFluoride.Text = "Fluoride";
            this.chkFluoride.UseVisualStyleBackColor = true;
            // 
            // chkRootcanal
            // 
            this.chkRootcanal.AutoSize = true;
            this.chkRootcanal.Location = new System.Drawing.Point(56, 307);
            this.chkRootcanal.Name = "chkRootcanal";
            this.chkRootcanal.Size = new System.Drawing.Size(79, 17);
            this.chkRootcanal.TabIndex = 14;
            this.chkRootcanal.Text = "Root Canal";
            this.chkRootcanal.UseVisualStyleBackColor = true;
            // 
            // chkOther
            // 
            this.chkOther.AutoSize = true;
            this.chkOther.Location = new System.Drawing.Point(56, 340);
            this.chkOther.Name = "chkOther";
            this.chkOther.Size = new System.Drawing.Size(52, 17);
            this.chkOther.TabIndex = 15;
            this.chkOther.Text = "Other";
            this.chkOther.UseVisualStyleBackColor = true;
            // 
            // txtPatientname
            // 
            this.txtPatientname.Location = new System.Drawing.Point(145, 100);
            this.txtPatientname.Name = "txtPatientname";
            this.txtPatientname.Size = new System.Drawing.Size(179, 20);
            this.txtPatientname.TabIndex = 16;
            // 
            // txtOther
            // 
            this.txtOther.Location = new System.Drawing.Point(364, 340);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(34, 20);
            this.txtOther.TabIndex = 17;
            this.txtOther.Text = "0";
            this.txtOther.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(270, 452);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(140, 28);
            this.btnCalculate.TabIndex = 18;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 508);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtOther);
            this.Controls.Add(this.txtPatientname);
            this.Controls.Add(this.chkOther);
            this.Controls.Add(this.chkRootcanal);
            this.Controls.Add(this.chkFluoride);
            this.Controls.Add(this.chkXray);
            this.Controls.Add(this.chkCavityfilling);
            this.Controls.Add(this.chkCleaning);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblOther);
            this.Controls.Add(this.lbl225);
            this.Controls.Add(this.lbl50);
            this.Controls.Add(this.lbl85);
            this.Controls.Add(this.lbl150);
            this.Controls.Add(this.lbl35);
            this.Controls.Add(this.lblPatientname);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPatientname;
        private System.Windows.Forms.Label lbl35;
        private System.Windows.Forms.Label lbl150;
        private System.Windows.Forms.Label lbl85;
        private System.Windows.Forms.Label lbl50;
        private System.Windows.Forms.Label lbl225;
        private System.Windows.Forms.Label lblOther;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.CheckBox chkCleaning;
        private System.Windows.Forms.CheckBox chkCavityfilling;
        private System.Windows.Forms.CheckBox chkXray;
        private System.Windows.Forms.CheckBox chkFluoride;
        private System.Windows.Forms.CheckBox chkRootcanal;
        private System.Windows.Forms.CheckBox chkOther;
        private System.Windows.Forms.TextBox txtPatientname;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.Button btnCalculate;
    }
}

