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
    public partial class Add3X2 : Form
    {
        public Add3X2()
        {
            InitializeComponent();
        }

        private void btnCaculate_Click(object sender, EventArgs e)
        {
            double a11, a12, a21, a22, a31, a32, b11, b12, b21, b22, b31, b32;
            double.TryParse(txta11.Text, out a11);
            double.TryParse(txta12.Text, out a12);
            double.TryParse(txta21.Text, out a21);
            double.TryParse(txta22.Text, out a22);
            double.TryParse(txta31.Text, out a31);
            double.TryParse(txta32.Text, out a32);
            double.TryParse(txtb11.Text, out b11);
            double.TryParse(txtb12.Text, out b12);
            double.TryParse(txtb21.Text, out b21);
            double.TryParse(txtb22.Text, out b22);
            double.TryParse(txtb31.Text, out b31);
            double.TryParse(txtb32.Text, out b32);
            txtr1.Text = (a11 + b11).ToString();
            txtr2.Text = (a12 + b12).ToString();
            txtr3.Text = (a21 + b21).ToString();
            txtr4.Text = (a22 + b22).ToString();
            txtr5.Text = (a31 + b31).ToString();
            txtr6.Text = (a32 + b32).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            MyMath.ClearText(this);
            txta11.Focus();
        }

        private void txta11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                SendKeys.Send("{Tab}");
            if ("0123456789.\b-".IndexOf(e.KeyChar) < 0)
                e.KeyChar = '\0';
        }
    }
}
