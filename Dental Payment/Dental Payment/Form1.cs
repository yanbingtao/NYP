using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dental_Payment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal decTotal = 0;
            decimal decOther = 0;

            if (txtPatientname.Text == "")
            {
                MessageBox.Show("plz input ur name");
            }
            else if (chkCavityfilling.Checked == false &&
                chkCleaning.Checked == false &&
                chkFluoride.Checked == false &&
                chkOther.Checked == false &&
                chkRootcanal.Checked == false &&
                chkXray.Checked == false)
            {
                MessageBox.Show("plz tick");
            }
            else
            {
                if (chkCleaning.Checked == true)
                {
                    decTotal += 35;
                }
                if (chkCavityfilling.Checked == true)
                {
                    decTotal += 150;
                }
                if (chkXray.Checked == true)
                {
                    decTotal += 85;
                }
                if (chkFluoride.Checked == true)
                {
                    decTotal += 50;

                }
                if (chkRootcanal.Checked == true)
                {
                    decTotal += 225;
                }
                if (chkOther.Checked == true)
                {

                    if (txtOther.Text == "0")
                    {
                        MessageBox.Show("plz input the price for 'other'");
                    }
                    else
                    {
                        try
                        {


                            {
                                decOther = decimal.Parse(txtOther.Text);
                                decTotal += decOther;
                            }
                        }
                        catch
                        {
                            MessageBox.Show("plz input number in other");
                        }
                    }
                    //output
                    lblAnswer.Text = string.Format("{0:c}", decTotal);

                }


               
            }

        }

     
    }
}
