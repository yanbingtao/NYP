using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace currency_converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            decimal dollars = 0;
            string convertto = "0";
            decimal answer = 0;

            dollars = decimal.Parse(txtDollars.Text );
            convertto = txtConvertto.Text ;
            
            if (convertto.ToLower()  =="euros")
            {
                answer = dollars * 1.02M;

            }
            else if (convertto.ToLower() =="yen")
            {
                answer = dollars * 120M;

            }
            else if (convertto.ToLower () == "pesos")
            {
                answer = dollars * 10M;
            }

            else 
            {
                MessageBox .Show("plz input 'Euros' or 'Yen' or 'Pesos' in currency");
            }

            lblAnswer.Text = string.Format("{0:f}", answer);
        }
    }
}
