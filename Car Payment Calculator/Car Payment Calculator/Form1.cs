using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Car_Payment_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int intYear = 2;
            int intMonths = 0;
            int intPrice = 0;
            int intDownPayment = 0;
            double dblInterest = 0;
            decimal decMonthlyPayment = 0;
            int intLoanAmount = 0;
            double dblMonthlyInterest = 0;

            lstPayment.Items.Clear();

            lstPayment.Items.Add("Months\t\tMonthly Payment");

            intDownPayment = Int32.Parse(txtDownpayment.Text);
            intPrice = Int32.Parse(txtPrice.Text);
            dblInterest = double.Parse(txtAnnualinterestrate.Text)/100;

            intLoanAmount = intPrice - intDownPayment;
            dblMonthlyInterest = dblInterest / 12;
            while (intYear <= 5)
            {
                intMonths = 12 * intYear;

                decMonthlyPayment = (decimal)(intLoanAmount * dblMonthlyInterest * Math.Pow(1 + dblMonthlyInterest, intMonths) / (Math.Pow(1 + dblMonthlyInterest, intMonths) - 1));

                lstPayment.Items.Add(intMonths + "\t\t" + string.Format("{0:c}", decMonthlyPayment));

                intYear++;
            }
        }
    }
}
