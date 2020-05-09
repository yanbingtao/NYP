using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WageCalculator
{
    public partial class wage : Form
    {
        public wage()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double  hourlywage = 0;
            double  weeklyhours = 0;
            decimal answer = 0;
            decimal FWT = 0;
            decimal netlearning=0;
          
            const int intHOUR = 40;
             try
             {
                 hourlywage = double.Parse (txtHourlywage.Text);
                 weeklyhours = double.Parse(txtWeeklyhours.Text);

          
                if (weeklyhours > intHOUR)
                {
                    answer = intHOUR  * (decimal)hourlywage + (decimal)(weeklyhours - intHOUR ) * (decimal)1.5 * (decimal)hourlywage;
                    
                }

                else
                {
                    answer = (decimal)hourlywage * (decimal)weeklyhours;
                   
                }

                FWT = (decimal)0.15 * answer;
                netlearning = answer - FWT;

                lblAnswer.Text = string.Format("{0:c}", answer);
                lblFWToutput.Text = string.Format("{0:c}", FWT);
                lblNetearningoutput.Text = string.Format("{0:c}", netlearning);
            }
            catch
            {
                MessageBox.Show("plz input numbers");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHourlywage.Text = "0";
            txtWeeklyhours.Text = "0";
            lblAnswer.Text = "0";
            lblFWToutput.Text = "0";
            lblNetearningoutput.Text = "0";
        }

       
    }
}
