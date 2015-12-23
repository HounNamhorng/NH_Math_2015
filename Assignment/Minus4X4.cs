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
    public partial class Minus4X4 : Form
    {
        public Minus4X4()
        {
            InitializeComponent();
        }

        private void btnCaculate_Click(object sender, EventArgs e)
        {
            double a11, a12, a13, a14, a21, a22, a23, a24, a31, a32, a33, a34, a41, a42, a43, a44, b11, b12, b13, b14, b21, b22, b23, b24, b31, b32, b33, b34, b41, b42, b43, b44;
            double.TryParse(txta11.Text, out a11);
            double.TryParse(txta12.Text, out a12);
            double.TryParse(txta13.Text, out a13);
            double.TryParse(txta14.Text, out a14);
            double.TryParse(txta21.Text, out a21);
            double.TryParse(txta22.Text, out a22);
            double.TryParse(txta23.Text, out a23);
            double.TryParse(txta24.Text, out a24);
            double.TryParse(txta31.Text, out a31);
            double.TryParse(txta32.Text, out a32);
            double.TryParse(txta33.Text, out a33);
            double.TryParse(txta34.Text, out a34);
            double.TryParse(txta41.Text, out a41);
            double.TryParse(txta42.Text, out a42);
            double.TryParse(txta43.Text, out a43);
            double.TryParse(txta44.Text, out a44);
            double.TryParse(txtb11.Text, out b11);
            double.TryParse(txtb12.Text, out b12);
            double.TryParse(txtb13.Text, out b13);
            double.TryParse(txtb14.Text, out b14);
            double.TryParse(txtb21.Text, out b21);
            double.TryParse(txtb22.Text, out b22);
            double.TryParse(txtb23.Text, out b23);
            double.TryParse(txtb24.Text, out b24);
            double.TryParse(txtb31.Text, out b31);
            double.TryParse(txtb32.Text, out b32);
            double.TryParse(txtb33.Text, out b33);
            double.TryParse(txtb34.Text, out b34);
            double.TryParse(txtb41.Text, out b41);
            double.TryParse(txtb42.Text, out b42);
            double.TryParse(txtb43.Text, out b43);
            double.TryParse(txtb44.Text, out b44);
            txtr1.Text = (a11 - b11).ToString();
            txtr2.Text = (a12 - b12).ToString();
            txtr3.Text = (a13 - b13).ToString();
            txtr4.Text = (a14 - b14).ToString();
            txtr5.Text = (a21 - b21).ToString();
            txtr6.Text = (a22 - b22).ToString();
            txtr7.Text = (a23 - b23).ToString();
            txtr8.Text = (a24 - b24).ToString();
            txtr9.Text = (a31 - b31).ToString();
            txtr10.Text = (a32 - b32).ToString();
            txtr11.Text = (a33 - b33).ToString();
            txtr12.Text = (a34 - b34).ToString();
            txtr13.Text = (a41 - b41).ToString();
            txtr14.Text = (a42 - b42).ToString();
            txtr15.Text = (a43 - b43).ToString();
            txtr16.Text = (a44 - b44).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            MyMath.ClearText(this);
            txta11.Focus();
        }

        private void txta44_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                SendKeys.Send("{Tab}");
            if ("0123456789.\b-".IndexOf(e.KeyChar) < 0)
                e.KeyChar = '\0';
        }
    }
}
