using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace payment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            double time = 0;
            decimal  paymentperhr = 0;
            decimal  total = 0;

            time = double.Parse(txtTime.Text);
            paymentperhr = decimal.Parse(txtPaymentperhr.Text);

            if (time==0.0)

            {
                MessageBox.Show("plz go back and sleep");
            }
           
            else if (time > 40.0 && time<=80.0)
                {
                    total = 40 * paymentperhr + (decimal)(time - 40.0) * ((decimal)1.5 * paymentperhr);
                }
            else if (time <= 40.0)
            {
                total = (decimal)time * paymentperhr;
            }
            else
            {
                total = 40 * paymentperhr + 40 * ((decimal )1.5 * paymentperhr)+ (decimal)(time -80)*2*paymentperhr ;
            }

                lblAnswer.Text = string.Format("{0:c}", total);
                        
            

        }
    }
}
