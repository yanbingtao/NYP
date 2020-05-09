using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconvert_Click(object sender, EventArgs e)
        {
            int a1 = 0;
            int a2 = 0;
            int a3 = 0;
            int a4 = 0;
            int a5 = 0;
            int a = 0;

            a = Int32.Parse(txtInput.Text );

            a1 = a / 10000;
            a2 = a / 1000 - 10 * a1;
            a3 = a / 100 - 100 * a1 - 10 * a2;
            a4 = a / 10 - 1000 * a1 - 100 * a2 - 10 * a3;
            a5 = a % 10;

            lbl1.Text = Convert.ToString(a1);
            lbl2.Text=Convert.ToString(a2);
            lbl3.Text = Convert.ToString(a3);
            lbl4.Text = Convert.ToString(a4);
            lbl5.Text = Convert.ToString(a5);



        }
    }
}
