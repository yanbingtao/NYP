using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Table_of_Power
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
         
            int intPower2 = 0;
            int intPower3 = 0;

            int intControl=1;//==intpower1
            int intLimit = 1;

            intLimit = Int32.Parse(txtUpperlimit.Text);
            lstAnswer.Items.Clear();


            lstAnswer.Items.Add("N\t\tN^2\t\tN^3");

            if (chkEvenandOdd.Checked == true )
            {
                while (intLimit >= intControl)
                {



                    intPower2 = (int)Math.Pow(intControl, 2);
                    intPower3 = (int)Math.Pow(intControl, 3);

                    lstAnswer.Items.Add(intControl + "\t\t" + intPower2 + "\t\t" + intPower3);

                    intControl++;

                }
            }

            if (chkOdd.Checked  == true)
            {
                while (intControl <= intLimit)
                {
                    

                    intPower2 = (int)Math.Pow(intControl, 2);
                    intPower3 = (int)Math.Pow(intControl, 3);


                    if (intControl % 2 == 1)
                    {
                        lstAnswer.Items.Add(intControl + "\t\t" + intPower2 + "\t\t" + intPower3);
                    }

                    intControl=intControl +1;
                }
            }

            if (chkEven .Checked  == true)
            {
                while (intControl <= intLimit )
                {

                    intPower2 = (int)Math.Pow(intControl, 2);
                    intPower3 = (int)Math.Pow(intControl, 3);

                    if (intControl % 2 == 0)
                    {
                        lstAnswer.Items.Add(intControl + "\t\t" + intPower2 + "\t\t" + intPower3);
                    }
                    intControl = intControl +1 ;
                }
            }
        }

    }
}
