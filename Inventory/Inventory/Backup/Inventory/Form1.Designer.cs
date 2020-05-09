namespace Inventory
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
            this.lblCarton = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.txtCarton = new System.Windows.Forms.TextBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCarton
            // 
            this.lblCarton.Location = new System.Drawing.Point(27, 40);
            this.lblCarton.Name = "lblCarton";
            this.lblCarton.Size = new System.Drawing.Size(229, 21);
            this.lblCarton.TabIndex = 0;
            this.lblCarton.Text = "Cartons per shipment:";
            this.lblCarton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblItem
            // 
            this.lblItem.Location = new System.Drawing.Point(27, 93);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(98, 22);
            this.lblItem.TabIndex = 1;
            this.lblItem.Text = "Items per cartons:";
            this.lblItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(289, 38);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(57, 23);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAnswer
            // 
            this.lblAnswer.BackColor = System.Drawing.Color.White;
            this.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAnswer.Location = new System.Drawing.Point(370, 38);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(98, 23);
            this.lblAnswer.TabIndex = 3;
            this.lblAnswer.Text = "0";
            this.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCarton
            // 
            this.txtCarton.Location = new System.Drawing.Point(138, 41);
            this.txtCarton.Name = "txtCarton";
            this.txtCarton.Size = new System.Drawing.Size(84, 20);
            this.txtCarton.TabIndex = 4;
            this.txtCarton.Text = "0";
            this.txtCarton.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(134, 95);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(87, 20);
            this.txtItem.TabIndex = 5;
            this.txtItem.Text = "0";
            this.txtItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(292, 131);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(176, 27);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate Total";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(135, 143);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(86, 20);
            this.txtNumber.TabIndex = 7;
            this.txtNumber.Text = "0";
            this.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNumber
            // 
            this.lblNumber.Location = new System.Drawing.Point(27, 138);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(110, 28);
            this.lblNumber.TabIndex = 8;
            this.lblNumber.Text = "Shipments this week:";
            this.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 187);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.txtCarton);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblCarton);
            this.Name = "Form1";
            this.Text = "Inventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarton;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox txtCarton;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblNumber;
    }
}

