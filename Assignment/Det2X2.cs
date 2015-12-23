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
    public partial class Det2X2 : Form
    {
        public Det2X2()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            MyMath.ClearText(this);
            txta11.Focus();
        }

        private void btnCaculate_Click(object sender, EventArgs e)
        {
            if (txta11.Text == "" && txta12.Text == "" && txta21.Text == "" && txta22.Text == "")
            {
                MessageBox.Show("Please input your matrix again!");
                txta11.Focus();
                return ;
            }
            double a11, a12, a21, a22;
            double.TryParse(txta11.Text, out a11);
            double.TryParse(txta12.Text, out a12);
            double.TryParse(txta21.Text, out a21);
            double.TryParse(txta22.Text, out a22);
            lblsqr1.Text="2+1";
            lblsqr2.Text="2+2";
            txtr1.Text = a11.ToString();
            txtr2.Text = a12.ToString();
            txtr3.Text = a21.ToString();
            txtr4.Text = a22.ToString();
            lbl1.Text = a21 + "(-1)" + "  (" + a12 + ") " + " + " + a22 + "(-1)" + "  (" + a11 + ") ";
            lbl2.Text = "= "+"-"+a21 + " × " + "(" + a12 + ")" + " + " + a22 + " × " + "(" + a11 + ")";
            lbl3.Text = "= "+(-a21 * a12 + a22 * a11).ToString();
            
        }

        private void txta22_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                SendKeys.Send("{Tab}");
            if ("0123456789.\b-".IndexOf(e.KeyChar) < 0)
                e.KeyChar = '\0';
        }

        private void txta11_TextChanged(object sender, EventArgs e)
        {
            lbl1.Text = lbl2.Text = lbl3.Text = lblsqr1.Text = lblsqr2.Text = "";
        }
    }
}
