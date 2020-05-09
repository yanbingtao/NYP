using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        double firstnumber = 0;
        double secondnumber = 0;
        double answer = 0;

      

       
    
        private void btnPlus_Click(object sender, EventArgs e)
        {
            //input

            try
            {
                
            firstnumber = double.Parse(txtFirstnumber.Text);
            secondnumber = double.Parse (txtSecondnumber.Text);
            //process

          
                answer = firstnumber + secondnumber;

                //output
                lblAnswer.Text = Convert.ToString(answer);
            }
            catch
            {
                MessageBox.Show("worng");
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {

            try
            {
                firstnumber = double.Parse(txtFirstnumber.Text);
                secondnumber = double.Parse(txtSecondnumber.Text);

                answer = firstnumber - secondnumber;

                //output
                lblAnswer.Text = Convert.ToString(answer);
            }
            catch
            {
                MessageBox.Show("worng");

            }
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {


            try
            {
                firstnumber = double.Parse(txtFirstnumber.Text);
                secondnumber = double.Parse(txtSecondnumber.Text);

                answer = firstnumber * secondnumber;

                //output
                lblAnswer.Text = Convert.ToString(answer);
            }
            catch
            {
                MessageBox.Show("wrong");
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {

            try
            {
                if (secondnumber == 0)
                {
                    MessageBox.Show("stupid lah");
                }

                else
                {
                    firstnumber = double.Parse(txtFirstnumber.Text);
                    secondnumber = double.Parse(txtSecondnumber.Text);

                    answer = firstnumber / secondnumber;

                    //output
                    lblAnswer.Text = Convert.ToString(answer);
                }
            }
            catch
            {
                MessageBox.Show("worng");
            }
            
        }
       

       
    }
}
