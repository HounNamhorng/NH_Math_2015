﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class frmMinusFraction : Form
    {
        public frmMinusFraction()
        {
            InitializeComponent();
        }
        double rUp, rDown;
        private void btncalculate_Click(object sender, EventArgs e)
        {
            double a, b, c, d, resulton, resultunder;
            double.TryParse(lblresultUp.Text, out rUp);
            double.TryParse(lblresultDown.Text, out rDown);
            double.TryParse(txta.Text, out a);
            double.TryParse(txtb.Text, out b);
            double.TryParse(txtc.Text, out c);
            double.TryParse(txtd.Text, out d);
            
            if (a == 0 || b == 0 || c == 0 || d == 0)
            {
                MessageBox.Show("Cannot calculate if your fraction have value 0 or null", "Complete all");
            }
            else 
            {
                resulton = (a * d) - (b * c);
                resultunder = b * d;
                //txtresulton.Text = resulton.ToString();
                //txtresultunder.Text = resultunder.ToString();
                lblresultUp.Text = resulton.ToString();
                lblresultDown.Text = resultunder.ToString();
            }
            if (checkBox1.Checked == true)
            {
                //if (lblresultUp.Text != "0" || lblresultDown.Text != "0")
                if (rUp!=0 && rDown!=0 )
                {
                    //float.TryParse(lblresultUp.Text, out rUp);
                    //float.TryParse(lblresultDown.Text, out rDown);
                    double min = (rUp > rDown) ? rUp : rDown;
                    if (rUp % rDown == 0)
                    {
                        //txtresulton.Text = (rUp / rDown).ToString();
                        //txtresultunder.Text = 1.ToString();
                        lblresultUp.Text = (rUp / rDown).ToString();
                        lblresultDown.Text = 1.ToString();
                    }
                    else
                    {
                        for (int i = 2; i < min; i++)
                        {
                            if (rUp % i == 0 && rDown % i == 0)
                            {
                                for (int j = 0; j < min; j++)
                                {
                                    if (rUp % i == 0 && rDown % i == 0)
                                    {
                                        rUp = rUp / i;
                                        rDown = rDown / i;
                                        lblresultUp.Text = rUp.ToString();
                                        lblresultDown.Text = rDown.ToString();
                                    }
                                }
                            }

                        }

                    }
                }
            }
        }
        private void buttonX1_Click(object sender, EventArgs e)
        {
            MyMath.ClearText(this);
            lblresultUp.Text = "...";
            lblresultDown.Text = "...";
            txta.Focus();
        }

        private void txta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                SendKeys.Send("{Tab}");
            if ("0123456789-.\b".IndexOf(e.KeyChar) < 0)
                e.KeyChar = '\0';
        }
    }
}
