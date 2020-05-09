using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace FuzzyDiceOrderForm
{
   /// <summary>
   /// Summary description for FrmFuzzyDiceOrderForm.
   /// </summary>
   public class FrmFuzzyDiceOrderForm : System.Windows.Forms.Form
   {
      // Label to display the Form's title
      private System.Windows.Forms.Label lblTitle;

      // Label and TextBox to input order number
      private System.Windows.Forms.Label lblOrderNumber;
      private System.Windows.Forms.TextBox txtOrderNumber;

      // Label and TextBox to input name
      private System.Windows.Forms.Label lblCompanyName;
      private System.Windows.Forms.TextBox txtName;

      // Label and TextBoxes to input address, city, state and zip
      private System.Windows.Forms.Label lblAddress;
      private System.Windows.Forms.TextBox txtAddressLine1;
      private System.Windows.Forms.TextBox txtAddressLine2;
      private System.Windows.Forms.TextBox txtCityStateZip;

      // Labels that serve as column headings for type, quantity,
      // price and total cost
      private System.Windows.Forms.Label lblType;
      private System.Windows.Forms.Label lblQuantity;
      private System.Windows.Forms.Label lblPrice;
      private System.Windows.Forms.Label lblTotals;

      // TextBox and Labels for white and black fuzzy dice
      private System.Windows.Forms.TextBox txtWhiteBlackQuantity;
      private System.Windows.Forms.Label lblWhiteBlackPrice;
      private System.Windows.Forms.Label lblWhiteBlackTotals;

      // TextBox and Labels for red and black fuzzy dice
      private System.Windows.Forms.TextBox txtRedBlackQuantity;
      private System.Windows.Forms.Label lblRedBlackPrice;
      private System.Windows.Forms.Label lblRedBlackTotals;

      // TextBox and Labels for blue and black fuzzy dice
      private System.Windows.Forms.TextBox txtBlueBlackQuantity;
      private System.Windows.Forms.Label lblBlueBlackPrice;
      private System.Windows.Forms.Label lblBlueBlackTotals;
      
      // Labels to display subtotal
      private System.Windows.Forms.Label lblSubtotal;
      private System.Windows.Forms.Label lblSubtotalResult;

      // Labels to display tax
      private System.Windows.Forms.Label lblTax;
      private System.Windows.Forms.Label lblTaxResult;

      // Labels to display shipping cost
      private System.Windows.Forms.Label lblShipping;
      private System.Windows.Forms.Label lblShippingResult;

      // Labels to display total cost after tax and shipping
      private System.Windows.Forms.Label lblTotal;
      private System.Windows.Forms.Label lblTotalResult;
      
      // Button to calculate costs
      private System.Windows.Forms.Button btnCalculate;

      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

      public FrmFuzzyDiceOrderForm()
      {
         //
         // Required for Windows Form Designer support
         //
         InitializeComponent();

         //
         // TODO: Add any constructor code after InitializeComponent call
         //
      }

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      protected override void Dispose( bool disposing )
      {
         if( disposing )
         {
            if (components != null) 
            {
               components.Dispose();
            }
         }
         base.Dispose( disposing );
      }

      #region Windows Form Designer generated code
      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.lblTitle = new System.Windows.Forms.Label();
         this.lblOrderNumber = new System.Windows.Forms.Label();
         this.txtOrderNumber = new System.Windows.Forms.TextBox();
         this.lblCompanyName = new System.Windows.Forms.Label();
         this.txtName = new System.Windows.Forms.TextBox();
         this.lblAddress = new System.Windows.Forms.Label();
         this.txtAddressLine1 = new System.Windows.Forms.TextBox();
         this.txtAddressLine2 = new System.Windows.Forms.TextBox();
         this.txtCityStateZip = new System.Windows.Forms.TextBox();
         this.lblType = new System.Windows.Forms.Label();
         this.lblQuantity = new System.Windows.Forms.Label();
         this.txtWhiteBlackQuantity = new System.Windows.Forms.TextBox();
         this.txtRedBlackQuantity = new System.Windows.Forms.TextBox();
         this.txtBlueBlackQuantity = new System.Windows.Forms.TextBox();
         this.lblPrice = new System.Windows.Forms.Label();
         this.lblWhiteBlackPrice = new System.Windows.Forms.Label();
         this.lblRedBlackPrice = new System.Windows.Forms.Label();
         this.lblBlueBlackPrice = new System.Windows.Forms.Label();
         this.lblSubtotal = new System.Windows.Forms.Label();
         this.lblTax = new System.Windows.Forms.Label();
         this.lblShipping = new System.Windows.Forms.Label();
         this.lblTotal = new System.Windows.Forms.Label();
         this.lblTotals = new System.Windows.Forms.Label();
         this.lblWhiteBlackTotals = new System.Windows.Forms.Label();
         this.lblRedBlackTotals = new System.Windows.Forms.Label();
         this.lblBlueBlackTotals = new System.Windows.Forms.Label();
         this.lblSubtotalResult = new System.Windows.Forms.Label();
         this.lblTaxResult = new System.Windows.Forms.Label();
         this.lblShippingResult = new System.Windows.Forms.Label();
         this.lblTotalResult = new System.Windows.Forms.Label();
         this.btnCalculate = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // lblTitle
         // 
         this.lblTitle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.lblTitle.Location = new System.Drawing.Point(64, 8);
         this.lblTitle.Name = "lblTitle";
         this.lblTitle.Size = new System.Drawing.Size(256, 24);
         this.lblTitle.TabIndex = 18;
         this.lblTitle.Text = "Fuzzy Dice";
         this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // lblOrderNumber
         // 
         this.lblOrderNumber.Location = new System.Drawing.Point(24, 56);
         this.lblOrderNumber.Name = "lblOrderNumber";
         this.lblOrderNumber.Size = new System.Drawing.Size(80, 16);
         this.lblOrderNumber.TabIndex = 19;
         this.lblOrderNumber.Text = "Order Number:";
         // 
         // txtOrderNumber
         // 
         this.txtOrderNumber.Location = new System.Drawing.Point(112, 56);
         this.txtOrderNumber.Name = "txtOrderNumber";
         this.txtOrderNumber.Size = new System.Drawing.Size(48, 21);
         this.txtOrderNumber.TabIndex = 20;
         this.txtOrderNumber.Text = "0";
         this.txtOrderNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // lblCompanyName
         // 
         this.lblCompanyName.Location = new System.Drawing.Point(24, 104);
         this.lblCompanyName.Name = "lblCompanyName";
         this.lblCompanyName.Size = new System.Drawing.Size(40, 16);
         this.lblCompanyName.TabIndex = 21;
         this.lblCompanyName.Text = "Name:";
         // 
         // txtName
         // 
         this.txtName.Location = new System.Drawing.Point(112, 104);
         this.txtName.Name = "txtName";
         this.txtName.Size = new System.Drawing.Size(248, 21);
         this.txtName.TabIndex = 22;
         this.txtName.Text = "Enter name here";
         // 
         // lblAddress
         // 
         this.lblAddress.Location = new System.Drawing.Point(24, 128);
         this.lblAddress.Name = "lblAddress";
         this.lblAddress.Size = new System.Drawing.Size(56, 16);
         this.lblAddress.TabIndex = 23;
         this.lblAddress.Text = "Address:";
         // 
         // txtAddressLine1
         // 
         this.txtAddressLine1.Location = new System.Drawing.Point(112, 128);
         this.txtAddressLine1.Name = "txtAddressLine1";
         this.txtAddressLine1.Size = new System.Drawing.Size(248, 21);
         this.txtAddressLine1.TabIndex = 24;
         this.txtAddressLine1.Text = "Address Line 1";
         // 
         // txtAddressLine2
         // 
         this.txtAddressLine2.Location = new System.Drawing.Point(112, 152);
         this.txtAddressLine2.Name = "txtAddressLine2";
         this.txtAddressLine2.Size = new System.Drawing.Size(248, 21);
         this.txtAddressLine2.TabIndex = 25;
         this.txtAddressLine2.Text = "Address Line 2";
         // 
         // txtCityStateZip
         // 
         this.txtCityStateZip.Location = new System.Drawing.Point(112, 176);
         this.txtCityStateZip.Name = "txtCityStateZip";
         this.txtCityStateZip.Size = new System.Drawing.Size(248, 21);
         this.txtCityStateZip.TabIndex = 26;
         this.txtCityStateZip.Text = "City, State, zip";
         // 
         // lblType
         // 
         this.lblType.Location = new System.Drawing.Point(24, 216);
         this.lblType.Name = "lblType";
         this.lblType.Size = new System.Drawing.Size(40, 16);
         this.lblType.TabIndex = 27;
         this.lblType.Text = "Type:";
         // 
         // lblQuantity
         // 
         this.lblQuantity.Location = new System.Drawing.Point(112, 216);
         this.lblQuantity.Name = "lblQuantity";
         this.lblQuantity.Size = new System.Drawing.Size(72, 16);
         this.lblQuantity.TabIndex = 28;
         this.lblQuantity.Text = "Quantity:";
         // 
         // txtWhiteBlackQuantity
         // 
         this.txtWhiteBlackQuantity.Location = new System.Drawing.Point(112, 240);
         this.txtWhiteBlackQuantity.Name = "txtWhiteBlackQuantity";
         this.txtWhiteBlackQuantity.Size = new System.Drawing.Size(80, 21);
         this.txtWhiteBlackQuantity.TabIndex = 29;
         this.txtWhiteBlackQuantity.Text = "0";
         this.txtWhiteBlackQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // txtRedBlackQuantity
         // 
         this.txtRedBlackQuantity.Location = new System.Drawing.Point(112, 264);
         this.txtRedBlackQuantity.Name = "txtRedBlackQuantity";
         this.txtRedBlackQuantity.Size = new System.Drawing.Size(80, 21);
         this.txtRedBlackQuantity.TabIndex = 30;
         this.txtRedBlackQuantity.Text = "0";
         this.txtRedBlackQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // txtBlueBlackQuantity
         // 
         this.txtBlueBlackQuantity.Location = new System.Drawing.Point(112, 288);
         this.txtBlueBlackQuantity.Name = "txtBlueBlackQuantity";
         this.txtBlueBlackQuantity.Size = new System.Drawing.Size(80, 21);
         this.txtBlueBlackQuantity.TabIndex = 31;
         this.txtBlueBlackQuantity.Text = "0";
         this.txtBlueBlackQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // lblPrice
         // 
         this.lblPrice.Location = new System.Drawing.Point(208, 216);
         this.lblPrice.Name = "lblPrice";
         this.lblPrice.Size = new System.Drawing.Size(72, 16);
         this.lblPrice.TabIndex = 32;
         this.lblPrice.Text = "Price:";
         // 
         // lblWhiteBlackPrice
         // 
         this.lblWhiteBlackPrice.Location = new System.Drawing.Point(208, 240);
         this.lblWhiteBlackPrice.Name = "lblWhiteBlackPrice";
         this.lblWhiteBlackPrice.Size = new System.Drawing.Size(80, 21);
         this.lblWhiteBlackPrice.TabIndex = 33;
         this.lblWhiteBlackPrice.Text = "$6.25";
         this.lblWhiteBlackPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // lblRedBlackPrice
         // 
         this.lblRedBlackPrice.Location = new System.Drawing.Point(208, 264);
         this.lblRedBlackPrice.Name = "lblRedBlackPrice";
         this.lblRedBlackPrice.Size = new System.Drawing.Size(80, 21);
         this.lblRedBlackPrice.TabIndex = 34;
         this.lblRedBlackPrice.Text = "$5.00";
         this.lblRedBlackPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // lblBlueBlackPrice
         // 
         this.lblBlueBlackPrice.Location = new System.Drawing.Point(208, 288);
         this.lblBlueBlackPrice.Name = "lblBlueBlackPrice";
         this.lblBlueBlackPrice.Size = new System.Drawing.Size(80, 21);
         this.lblBlueBlackPrice.TabIndex = 35;
         this.lblBlueBlackPrice.Text = "$7.50";
         this.lblBlueBlackPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // lblSubtotal
         // 
         this.lblSubtotal.Location = new System.Drawing.Point(216, 320);
         this.lblSubtotal.Name = "lblSubtotal";
         this.lblSubtotal.Size = new System.Drawing.Size(72, 16);
         this.lblSubtotal.TabIndex = 36;
         this.lblSubtotal.Text = "Subtotal:";
         // 
         // lblTax
         // 
         this.lblTax.Location = new System.Drawing.Point(216, 344);
         this.lblTax.Name = "lblTax";
         this.lblTax.Size = new System.Drawing.Size(72, 16);
         this.lblTax.TabIndex = 37;
         this.lblTax.Text = "Tax:";
         // 
         // lblShipping
         // 
         this.lblShipping.Location = new System.Drawing.Point(216, 368);
         this.lblShipping.Name = "lblShipping";
         this.lblShipping.Size = new System.Drawing.Size(72, 16);
         this.lblShipping.TabIndex = 38;
         this.lblShipping.Text = "Shipping:";
         // 
         // lblTotal
         // 
         this.lblTotal.Location = new System.Drawing.Point(216, 392);
         this.lblTotal.Name = "lblTotal";
         this.lblTotal.Size = new System.Drawing.Size(72, 16);
         this.lblTotal.TabIndex = 39;
         this.lblTotal.Text = "Total:";
         // 
         // lblTotals
         // 
         this.lblTotals.Location = new System.Drawing.Point(296, 216);
         this.lblTotals.Name = "lblTotals";
         this.lblTotals.Size = new System.Drawing.Size(72, 16);
         this.lblTotals.TabIndex = 40;
         this.lblTotals.Text = "Totals:";
         // 
         // lblWhiteBlackTotals
         // 
         this.lblWhiteBlackTotals.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.lblWhiteBlackTotals.Location = new System.Drawing.Point(296, 240);
         this.lblWhiteBlackTotals.Name = "lblWhiteBlackTotals";
         this.lblWhiteBlackTotals.Size = new System.Drawing.Size(72, 16);
         this.lblWhiteBlackTotals.TabIndex = 41;
         this.lblWhiteBlackTotals.Text = "$0.00";
         this.lblWhiteBlackTotals.TextAlign = System.Drawing.ContentAlignment.TopRight;
         // 
         // lblRedBlackTotals
         // 
         this.lblRedBlackTotals.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.lblRedBlackTotals.Location = new System.Drawing.Point(296, 264);
         this.lblRedBlackTotals.Name = "lblRedBlackTotals";
         this.lblRedBlackTotals.Size = new System.Drawing.Size(72, 16);
         this.lblRedBlackTotals.TabIndex = 42;
         this.lblRedBlackTotals.Text = "$0.00";
         this.lblRedBlackTotals.TextAlign = System.Drawing.ContentAlignment.TopRight;
         // 
         // lblBlueBlackTotals
         // 
         this.lblBlueBlackTotals.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.lblBlueBlackTotals.Location = new System.Drawing.Point(296, 288);
         this.lblBlueBlackTotals.Name = "lblBlueBlackTotals";
         this.lblBlueBlackTotals.Size = new System.Drawing.Size(72, 16);
         this.lblBlueBlackTotals.TabIndex = 43;
         this.lblBlueBlackTotals.Text = "$0.00";
         this.lblBlueBlackTotals.TextAlign = System.Drawing.ContentAlignment.TopRight;
         // 
         // lblSubtotalResult
         // 
         this.lblSubtotalResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.lblSubtotalResult.Location = new System.Drawing.Point(296, 320);
         this.lblSubtotalResult.Name = "lblSubtotalResult";
         this.lblSubtotalResult.Size = new System.Drawing.Size(72, 16);
         this.lblSubtotalResult.TabIndex = 44;
         this.lblSubtotalResult.Text = "$0.00";
         this.lblSubtotalResult.TextAlign = System.Drawing.ContentAlignment.TopRight;
         // 
         // lblTaxResult
         // 
         this.lblTaxResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.lblTaxResult.Location = new System.Drawing.Point(296, 344);
         this.lblTaxResult.Name = "lblTaxResult";
         this.lblTaxResult.Size = new System.Drawing.Size(72, 16);
         this.lblTaxResult.TabIndex = 45;
         this.lblTaxResult.Text = "$0.00";
         this.lblTaxResult.TextAlign = System.Drawing.ContentAlignment.TopRight;
         // 
         // lblShippingResult
         // 
         this.lblShippingResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.lblShippingResult.Location = new System.Drawing.Point(296, 368);
         this.lblShippingResult.Name = "lblShippingResult";
         this.lblShippingResult.Size = new System.Drawing.Size(72, 16);
         this.lblShippingResult.TabIndex = 46;
         this.lblShippingResult.Text = "$0.00";
         this.lblShippingResult.TextAlign = System.Drawing.ContentAlignment.TopRight;
         // 
         // lblTotalResult
         // 
         this.lblTotalResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.lblTotalResult.Location = new System.Drawing.Point(296, 392);
         this.lblTotalResult.Name = "lblTotalResult";
         this.lblTotalResult.Size = new System.Drawing.Size(72, 16);
         this.lblTotalResult.TabIndex = 47;
         this.lblTotalResult.Text = "$0.00";
         this.lblTotalResult.TextAlign = System.Drawing.ContentAlignment.TopRight;
         // 
         // btnCalculate
         // 
         this.btnCalculate.Location = new System.Drawing.Point(296, 424);
         this.btnCalculate.Name = "btnCalculate";
         this.btnCalculate.TabIndex = 48;
         this.btnCalculate.Text = "Calculate";
         // 
         // FrmFuzzyDiceOrderForm
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
         this.ClientSize = new System.Drawing.Size(392, 461);
         this.Controls.Add(this.btnCalculate);
         this.Controls.Add(this.lblTotalResult);
         this.Controls.Add(this.lblShippingResult);
         this.Controls.Add(this.lblTaxResult);
         this.Controls.Add(this.lblSubtotalResult);
         this.Controls.Add(this.lblBlueBlackTotals);
         this.Controls.Add(this.lblRedBlackTotals);
         this.Controls.Add(this.lblWhiteBlackTotals);
         this.Controls.Add(this.lblTotals);
         this.Controls.Add(this.lblTotal);
         this.Controls.Add(this.lblShipping);
         this.Controls.Add(this.lblTax);
         this.Controls.Add(this.lblSubtotal);
         this.Controls.Add(this.lblBlueBlackPrice);
         this.Controls.Add(this.lblRedBlackPrice);
         this.Controls.Add(this.lblWhiteBlackPrice);
         this.Controls.Add(this.lblPrice);
         this.Controls.Add(this.txtBlueBlackQuantity);
         this.Controls.Add(this.txtRedBlackQuantity);
         this.Controls.Add(this.txtWhiteBlackQuantity);
         this.Controls.Add(this.lblQuantity);
         this.Controls.Add(this.lblType);
         this.Controls.Add(this.txtCityStateZip);
         this.Controls.Add(this.txtAddressLine2);
         this.Controls.Add(this.txtAddressLine1);
         this.Controls.Add(this.lblAddress);
         this.Controls.Add(this.txtName);
         this.Controls.Add(this.lblCompanyName);
         this.Controls.Add(this.txtOrderNumber);
         this.Controls.Add(this.lblOrderNumber);
         this.Controls.Add(this.lblTitle);
         this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.Name = "FrmFuzzyDiceOrderForm";
         this.Text = "Fuzzy Dice Order Form";
         this.ResumeLayout(false);

      }
      #endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new FrmFuzzyDiceOrderForm() );
      }

   } // end class FrmFuzzyDiceOrderForm
}

/**************************************************************************
 * (C) Copyright 1992-2004 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/