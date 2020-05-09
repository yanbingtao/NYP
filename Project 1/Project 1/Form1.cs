using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project_1
{
    public partial class Project1 : Form
    {
        int inta = 0;

        int int1 = 0;
        int int2 = 0;
        int int3 = 0;
        int int4 = 0;
        int int5 = 0;
        int int6 = 0;
        int int7 = 0;
        int int8 = 0;
        int int9 = 0;

        public Project1()
        {
            InitializeComponent();
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            if (inta % 2 == 0)
            {
                btn11.Text = "X";
                int1= 1;
                if ((int1 == int2 && int1 == int3&&int1 !=0) || (int4 == int5 && int5 == int6 &&int4!=0) || (int7 == int8 && int8 == int9&&int7!=0) || (int2 == int5 && int5 == int8&&int2!=0) || (int1 == int4 && int4 == int7&&int1!=0) || (int3 == int6 && int6 == int9&&int3 !=0) || (int1 == int5 && int5 == int9&&int1!=0) || (int3 == int5 && int5 == int7&&int3!=0))
                {
                    MessageBox.Show("WIN");
                }
            }
            else
            {
                btn11.Text = "o";
                int1=9;
                if ((int1 == int2 && int1 == int3 && int1 != 0) || (int4 == int5 && int5 == int6 && int4 != 0) || (int7 == int8 && int8 == int9 && int7 != 0) || (int2 == int5 && int5 == int8 && int2 != 0) || (int1 == int4 && int4 == int7 && int1 != 0) || (int3 == int6 && int6 == int9 && int3 != 0) || (int1 == int5 && int5 == int9 && int1 != 0) || (int3 == int5 && int5 == int7 && int3 != 0))
                {
                    MessageBox.Show("WIN");
                }
            }
            inta++;
            btn11.Enabled = false;
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            if (inta % 2 == 0)
            {
                btn12.Text = "X";
                int2= 1;
                if ((int1 == int2 && int1 == int3&&int1 !=0) || (int4 == int5 && int5 == int6 &&int4!=0) || (int7 == int8 && int8 == int9&&int7!=0) || (int2 == int5 && int5 == int8&&int2!=0) || (int1 == int4 && int4 == int7&&int1!=0) || (int3 == int6 && int6 == int9&&int3 !=0) || (int1 == int5 && int5 == int9&&int1!=0) || (int3 == int5 && int5 == int7&&int3!=0))
                {
                    MessageBox.Show("WIN");
                }
            }
            else
            {
                btn12.Text = "o";
                int2 = 9;
               if ((int1 == int2 && int1 == int3&&int1 !=0) || (int4 == int5 && int5 == int6 &&int4!=0) || (int7 == int8 && int8 == int9&&int7!=0) || (int2 == int5 && int5 == int8&&int2!=0) || (int1 == int4 && int4 == int7&&int1!=0) || (int3 == int6 && int6 == int9&&int3 !=0) || (int1 == int5 && int5 == int9&&int1!=0) || (int3 == int5 && int5 == int7&&int3!=0))
               {
                    MessageBox.Show("WIN");
                }

            }
            inta++;
            btn12.Enabled = false;
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            if (inta % 2 == 0)
            {
                btn13.Text = "X";
                int3 = 1;
                if ((int1 == int2 && int1 == int3&&int1 !=0) || (int4 == int5 && int5 == int6 &&int4!=0) || (int7 == int8 && int8 == int9&&int7!=0) || (int2 == int5 && int5 == int8&&int2!=0) || (int1 == int4 && int4 == int7&&int1!=0) || (int3 == int6 && int6 == int9&&int3 !=0) || (int1 == int5 && int5 == int9&&int1!=0) || (int3 == int5 && int5 == int7&&int3!=0))
                {
                    MessageBox.Show("WIN");
                }
            }
            else
            {
                btn13.Text = "o";
                int3 = 9;
                if ((int1 == int2 && int1 == int3&&int1 !=0) || (int4 == int5 && int5 == int6 &&int4!=0) || (int7 == int8 && int8 == int9&&int7!=0) || (int2 == int5 && int5 == int8&&int2!=0) || (int1 == int4 && int4 == int7&&int1!=0) || (int3 == int6 && int6 == int9&&int3 !=0) || (int1 == int5 && int5 == int9&&int1!=0) || (int3 == int5 && int5 == int7&&int3!=0))
                {
                    MessageBox.Show("WIN");
                }
            }
            inta++;
            btn13.Enabled = false;
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            if (inta % 2 == 0)
            {
                btn21.Text = "X";
                int4 = 1;
               if ((int1 == int2 && int1 == int3&&int1 !=0) || (int4 == int5 && int5 == int6 &&int4!=0) || (int7 == int8 && int8 == int9&&int7!=0) || (int2 == int5 && int5 == int8&&int2!=0) || (int1 == int4 && int4 == int7&&int1!=0) || (int3 == int6 && int6 == int9&&int3 !=0) || (int1 == int5 && int5 == int9&&int1!=0) || (int3 == int5 && int5 == int7&&int3!=0))
               {
                    MessageBox.Show("WIN");
                }
            }
            else
            {
                btn21.Text = "o";
                int4 = 9;
               if ((int1 == int2 && int1 == int3&&int1 !=0) || (int4 == int5 && int5 == int6 &&int4!=0) || (int7 == int8 && int8 == int9&&int7!=0) || (int2 == int5 && int5 == int8&&int2!=0) || (int1 == int4 && int4 == int7&&int1!=0) || (int3 == int6 && int6 == int9&&int3 !=0) || (int1 == int5 && int5 == int9&&int1!=0) || (int3 == int5 && int5 == int7&&int3!=0))
               {
                    MessageBox.Show("WIN");
                }
            }
            inta++;
            btn21.Enabled = false;
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            if (inta % 2 == 0)
            {
                btn22.Text = "X";
                int5 = 1;
                if ((int1 == int2 && int1 == int3&&int1 !=0) || (int4 == int5 && int5 == int6 &&int4!=0) || (int7 == int8 && int8 == int9&&int7!=0) || (int2 == int5 && int5 == int8&&int2!=0) || (int1 == int4 && int4 == int7&&int1!=0) || (int3 == int6 && int6 == int9&&int3 !=0) || (int1 == int5 && int5 == int9&&int1!=0) || (int3 == int5 && int5 == int7&&int3!=0))
                {
                    MessageBox.Show("WIN");
                }
            }
            else
            {
                btn22.Text = "o";
                int5 = 9;
               if ((int1 == int2 && int1 == int3&&int1 !=0) || (int4 == int5 && int5 == int6 &&int4!=0) || (int7 == int8 && int8 == int9&&int7!=0) || (int2 == int5 && int5 == int8&&int2!=0) || (int1 == int4 && int4 == int7&&int1!=0) || (int3 == int6 && int6 == int9&&int3 !=0) || (int1 == int5 && int5 == int9&&int1!=0) || (int3 == int5 && int5 == int7&&int3!=0))
               {
                    MessageBox.Show("WIN");
                }
            }
            inta++;
            btn22.Enabled = false;

        }

        private void btn23_Click(object sender, EventArgs e)
        {
            if (inta % 2 == 0)
            {
                btn23.Text = "X";
                int6=1;
               if ((int1 == int2 && int1 == int3&&int1 !=0) || (int4 == int5 && int5 == int6 &&int4!=0) || (int7 == int8 && int8 == int9&&int7!=0) || (int2 == int5 && int5 == int8&&int2!=0) || (int1 == int4 && int4 == int7&&int1!=0) || (int3 == int6 && int6 == int9&&int3 !=0) || (int1 == int5 && int5 == int9&&int1!=0) || (int3 == int5 && int5 == int7&&int3!=0))
               {
                    MessageBox.Show("WIN");
                }
            }
            else
            {
                btn23.Text = "o";
                int6= 9;
                if ((int1 == int2 && int1 == int3&&int1 !=0) || (int4 == int5 && int5 == int6 &&int4!=0) || (int7 == int8 && int8 == int9&&int7!=0) || (int2 == int5 && int5 == int8&&int2!=0) || (int1 == int4 && int4 == int7&&int1!=0) || (int3 == int6 && int6 == int9&&int3 !=0) || (int1 == int5 && int5 == int9&&int1!=0) || (int3 == int5 && int5 == int7&&int3!=0))
                {
                    MessageBox.Show("WIN");
                }
            }
            inta++;
            btn23.Enabled = false;
        }

        private void btn31_Click(object sender, EventArgs e)
        {
            if (inta % 2 == 0)
            {
                btn31.Text = "X";
                int7= 1;
                if ((int1 == int2 && int1 == int3&&int1 !=0) || (int4 == int5 && int5 == int6 &&int4!=0) || (int7 == int8 && int8 == int9&&int7!=0) || (int2 == int5 && int5 == int8&&int2!=0) || (int1 == int4 && int4 == int7&&int1!=0) || (int3 == int6 && int6 == int9&&int3 !=0) || (int1 == int5 && int5 == int9&&int1!=0) || (int3 == int5 && int5 == int7&&int3!=0))
                {
                    MessageBox.Show("WIN");
                }
            }
            else
            {
                btn31.Text = "o";
                int7= 9;
                if ((int1 == int2 && int1 == int3&&int1 !=0) || (int4 == int5 && int5 == int6 &&int4!=0) || (int7 == int8 && int8 == int9&&int7!=0) || (int2 == int5 && int5 == int8&&int2!=0) || (int1 == int4 && int4 == int7&&int1!=0) || (int3 == int6 && int6 == int9&&int3 !=0) || (int1 == int5 && int5 == int9&&int1!=0) || (int3 == int5 && int5 == int7&&int3!=0))
                {
                    MessageBox.Show("WIN");
                }
            }
            inta++;
            btn31.Enabled = false;
        }

        private void btn32_Click(object sender, EventArgs e)
        {
            if (inta % 2 == 0)
            {
                btn32.Text = "X";
                int8= 1;
                if ((int1 == int2 && int1 == int3&&int1 !=0) || (int4 == int5 && int5 == int6 &&int4!=0) || (int7 == int8 && int8 == int9&&int7!=0) || (int2 == int5 && int5 == int8&&int2!=0) || (int1 == int4 && int4 == int7&&int1!=0) || (int3 == int6 && int6 == int9&&int3 !=0) || (int1 == int5 && int5 == int9&&int1!=0) || (int3 == int5 && int5 == int7&&int3!=0))
                {
                    MessageBox.Show("WIN");
                }
            }
            else
            {
                btn32.Text = "o";
                int8= 9;
               if ((int1 == int2 && int1 == int3&&int1 !=0) || (int4 == int5 && int5 == int6 &&int4!=0) || (int7 == int8 && int8 == int9&&int7!=0) || (int2 == int5 && int5 == int8&&int2!=0) || (int1 == int4 && int4 == int7&&int1!=0) || (int3 == int6 && int6 == int9&&int3 !=0) || (int1 == int5 && int5 == int9&&int1!=0) || (int3 == int5 && int5 == int7&&int3!=0))
               {
                    MessageBox.Show("WIN");
                }
            }

            inta++;
            btn32.Enabled = false;
        }

        private void btn33_Click(object sender, EventArgs e)
        {
            if (inta % 2 == 0)
            {
                btn33.Text = "X";
                int9= 1;
                if ((int1 == int2 && int1 == int3&&int1 !=0) || (int4 == int5 && int5 == int6 &&int4!=0) || (int7 == int8 && int8 == int9&&int7!=0) || (int2 == int5 && int5 == int8&&int2!=0) || (int1 == int4 && int4 == int7&&int1!=0) || (int3 == int6 && int6 == int9&&int3 !=0) || (int1 == int5 && int5 == int9&&int1!=0) || (int3 == int5 && int5 == int7&&int3!=0))
                {
                    MessageBox.Show("WIN");
                }
            }
            else
            {
                btn33.Text = "o";
                int9= 9;
                if ((int1 == int2 && int1 == int3&&int1 !=0) || (int4 == int5 && int5 == int6 &&int4!=0) || (int7 == int8 && int8 == int9&&int7!=0) || (int2 == int5 && int5 == int8&&int2!=0) || (int1 == int4 && int4 == int7&&int1!=0) || (int3 == int6 && int6 == int9&&int3 !=0) || (int1 == int5 && int5 == int9&&int1!=0) || (int3 == int5 && int5 == int7&&int3!=0))
                {
                    MessageBox.Show("WIN");
                }
            }
            inta++;
            btn33.Enabled = false;
            
        }

    

        private void btnNewgame_Click(object sender, EventArgs e)
        {
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
            btn21.Text = "";
            btn22.Text = "";
            btn23.Text = "";
            btn31.Text = "";
            btn32.Text = "";
            btn33.Text = "";
            inta = 0;
            int1 = 0;
            int2 = 0;
            int3 = 0;
            int4 = 0;
            int5 = 0;
            int6 = 0;
            int7 = 0;
            int8 = 0;
            int9 = 0;
            btn11.Enabled = true;
            btn12.Enabled = true;
            btn13.Enabled = true;
            btn21.Enabled = true;
            btn22.Enabled = true;
            btn23.Enabled = true;
            btn31.Enabled = true;
            btn32.Enabled = true;
            btn33.Enabled = true;
        }
        
    }
}
