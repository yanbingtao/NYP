using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace equation__with_two_unknowns
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnCalculate_Click(object sender, EventArgs e)

    {
        double a=0;
        double b=0;
        double c=0;
        double d=0;
        double right1 = 0;
        double right2 = 0;

        double a1 = 0;
        double a2 = 0;
        double a3 = 0;
        double ay = 0;
        double ax = 0;


            //input;
        a = double.Parse(txta.Text);
        b = double.Parse(txtb .Text );
        c = double.Parse(txtc.Text);
        d = double.Parse(txtd.Text);
        right1 = double.Parse(txtright1.Text );
        right2 = double.Parse(txtright2.Text);
               


        a1 = (-(b) / a );

        a3  = c * a1;

        a2 = a3  + d;

        ay = (right2 - (right1 / a)*c ) / a2;
        ax=(right1  - (ay * b))/a ; 

            //output;

        lblx.Text = Convert.ToString(ax);
        lbly.Text = Convert.ToString(ay);


    }


        
    }
}
