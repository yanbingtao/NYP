using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace counter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int a = 0;

            a = Int32.Parse(lblOutput.Text);


            if (a < 10)
            {

                a = a + 1;
                lblOutput.Text = Convert.ToString(a);

            }
            else
            {
                lblOutput.Text = Convert.ToString(0);

            }


        }
    }
}
