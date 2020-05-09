using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //input
            int intCarton = 0;
            int intItem = 0;
            int intTotal = 0;
            int intNumber = 0;

            try
            {
                //process
                intCarton = Int32.Parse(txtCarton.Text);
                intItem = Int32.Parse(txtItem.Text);
                intNumber = Int32.Parse(txtNumber.Text );

                intTotal = intCarton * intItem * intNumber ;


                //output
                lblAnswer.Text = Convert.ToString(intTotal);
            }

            catch
            {
                MessageBox.Show("wrong");
            }
        }

       

       
    }
}
