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
    public partial class Add2X2 : Form
    {
        public Add2X2()
        {
            InitializeComponent();
        }

        private void btnCaculate_Click(object sender, EventArgs e)
        {
            double a11, a12, a21, a22, b11, b12, b21, b22;
            double.TryParse(txta11.Text, out a11);
            double.TryParse(txta12.Text, out a12);
            double.TryParse(txta21.Text, out a21);
            double.TryParse(txta22.Text, out a22);
            double.TryParse(txtb11.Text, out b11);
            double.TryParse(txtb12.Text, out b12);
            double.TryParse(txtb21.Text, out b21);
            double.TryParse(txtb22.Text, out b22);
            txtr1.Text = (a11 + b11).ToString();
            txtr2.Text = (a12 + b12).ToString();
            txtr3.Text = (a21 + b21).ToString();
            txtr4.Text = (a22 + b22).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txta11.Focus();
            MyMath.ClearText(this);

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
