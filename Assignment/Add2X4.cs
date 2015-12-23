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
    public partial class Add2X4 : Form
    {
        public Add2X4()
        {
            InitializeComponent();
        }

        private void btnCaculate_Click(object sender, EventArgs e)
        {
            double a11, a12, a13, a14, a21, a22, a23, a24, b11, b12, b13, b14, b21, b22, b23, b24;
            double.TryParse(txta11.Text, out a11);
            double.TryParse(txta12.Text, out a12);
            double.TryParse(txta13.Text, out a13);
            double.TryParse(txta14.Text, out a14);
            double.TryParse(txta21.Text, out a21);
            double.TryParse(txta22.Text, out a22);
            double.TryParse(txta23.Text, out a23);
            double.TryParse(txta24.Text, out a24);
            double.TryParse(txtb11.Text, out b11);
            double.TryParse(txtb12.Text, out b12);
            double.TryParse(txtb13.Text, out b13);
            double.TryParse(txtb14.Text, out b14);
            double.TryParse(txtb21.Text, out b21);
            double.TryParse(txtb22.Text, out b22);
            double.TryParse(txtb23.Text, out b23);
            double.TryParse(txtb24.Text, out b24);
            txtr1.Text = (a11 + b11).ToString();
            txtr2.Text = (a12 + b12).ToString();
            txtr3.Text = (a13 + b13).ToString();
            txtr4.Text = (a14 + b14).ToString();
            txtr5.Text = (a21 + b21).ToString();
            txtr6.Text = (a22 + b22).ToString();
            txtr7.Text = (a23 + b23).ToString();
            txtr8.Text = (a24 + b24).ToString();
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
