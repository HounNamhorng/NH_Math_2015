using System;
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
    public partial class det3X3 : Form
    {
        public det3X3()
        {
            InitializeComponent();
        }

        private void btnCaculate_Click(object sender, EventArgs e)
        {
            if (txta11.Text == "" && txta12.Text == "" && txta21.Text == "" && txta22.Text == "" && txta23.Text == "" && txta13.Text == "")
            {
                MessageBox.Show("Please input your matrix again!");
                txta11.Focus();
                return;
            }
            double a11, a12, a13, a21, a22, a23, a31, a32, a33;
            double.TryParse(txta11.Text, out a11);
            double.TryParse(txta12.Text, out a12);
            double.TryParse(txta13.Text, out a13);
            double.TryParse(txta21.Text, out a21);
            double.TryParse(txta22.Text, out a22);
            double.TryParse(txta23.Text, out a23);
            double.TryParse(txta31.Text, out a31);
            double.TryParse(txta32.Text, out a32);
            double.TryParse(txta33.Text, out a33);
            lblsqr1.Text = "3+1";
            lblsqr2.Text = "3+2";
            lblsqr3.Text = "3+3";
            txtr1.Text = a11.ToString();
            txtr2.Text = a12.ToString();
            txtr3.Text = a13.ToString();
            txtr4.Text = a21.ToString();
            txtr5.Text = a22.ToString();
            txtr6.Text = a23.ToString();
            txtr7.Text = a31.ToString();
            txtr8.Text = a32.ToString();
            txtr9.Text = a33.ToString();
            lbl1.Text = a31 + "(-1)" + "  (" + a12+" × "+a23+" - "+a22+" × "+a13+ ") " + " + " + a32 + "(-1)" + " (" + a11+" × "+a23 +" - "+a21+" × "+a13+ ") "+" + "+a33+"(-1)"+" ("+a11+" × "+a22+" - "+a21+" × "+a12+") ";
            lbl2.Text = "= " + a31 + "( " + (a12 * a23) + " - " + (a22 * a13) + " )" + " - " + a32 + "( " + (a11 * a23) + " - " + (a21 * a13) + " )" + " + " + a33 + " ( " + (a11 * a22) + " - " + (a21 * a12) + " )";
            double a1, b1, a2, b2, a3, b3;
            a1 = a12 * a23; b1 = a22 * a13; a2 = a11 * a23; b2 = a21 * a13; a3 = a11 * a22; b3 = a21 * a12;
            lbl3.Text = "= " + (a31 * a1) + " - " + (a31 * b1) + " - " + (a32 * a2) + " + " + (a32 * b2) + " + " + (a33 * a3) + " - " + (a33 * b3);
            lbl4.Text = "= " + (((a31 * a1) - (a31 * b1)) - ((a32 * a2) - (a32 * b2)) + ((a33 * a3) - (a33 * b3)));
        }

        private void txta33_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                SendKeys.Send("{Tab}");
            if ("0123456789.\b-".IndexOf(e.KeyChar) < 0)
                e.KeyChar = '\0';
        }

        private void txta33_TextChanged(object sender, EventArgs e)
        {
            lbl1.Text = lbl2.Text = lbl3.Text = lbl4.Text = lblsqr1.Text = lblsqr2.Text = lblsqr3.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            MyMath.ClearText(this);
            txta11.Focus();
        }
    }
}
