using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace power
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int intPower = 1;
          
            lstOutput.Items.Clear();
            lstOutput .Items .Add ("N"+"\t\t"+"N^2"+"\t\t"+"N^3");

            while (intPower <= Int64.Parse(txtPower.Text))
            {
                lstOutput.Items.Add(intPower + "\t\t" + Math.Pow(intPower, 2) + "\t\t" + Math.Pow(intPower, 3));
                intPower++;

            }
        }
    }
}
