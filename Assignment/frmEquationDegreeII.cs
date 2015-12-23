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
    public partial class frmEquationDegreeII : Form
    {
        public frmEquationDegreeII()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            double a, b, c, delta = 0, delta1, x1, x2;
            //a = float.Parse(txt1.Text);
            //   float.TryParse(txt1.Text, out a);
            double.TryParse(txta.Text, out a);
            // b = float.Parse(txt2.Text);
            double.TryParse(txtb.Text, out b);
            //c = float.Parse(txt3.Text);
            double.TryParse(txtc.Text, out c);
            if (a == 0 && b == 0 && c == 0)
            {
                MessageBox.Show("Please input value a,b,c again!");
                txta.Focus();
                return;
            }
            else if (a == 0)
            {
                MessageBox.Show("Equation have mean if a ≠ 0, Please input value a again!");
                txta.Clear();
                txta.Focus();
                return;
            }
            delta = (b * b) - (4 * a * c);
            delta1 = System.Math.Sqrt(delta);
            lbl1.Text = "∆ = b² - 4ac";
            lbl2.Text = "∆ = " + (b * b) + " - " + "4" + " × " + a + " × " + c + "  = " + delta;
            //lbl3.Text = "=>" + "√∆ = " + delta1;
            if (delta > 0)
            {
                lbl3.Text = "=>" + "√∆ = " + delta1;
                x1 = ((-b) + delta1) / (2 * a);
                x2 = ((-b) - delta1) / (2 * a);
                lbl5.Text = "X1  = " + " - " + b + " + " + delta1 + " / " + "2 × " + a + " = " + x1;
                lbl4.Text = "X1 = -b + √∆ / 2a";
                lbl6.Text = "X2 = -b - √∆ / 2a";
                lbl7.Text = "X2  = " + " - " + b + " - " + delta1 + " / " + "2 × " + a + " = " + x2;

            }
            else if (delta < 0)
            {
                lbl3.Text = "=>" + "√∆ <0 ";
                lbl4.Text = "X1 = " + "No Root";
                lbl6.Text = "X2 = " + "No Root";
            }
            else if(delta == 0)
            {
                lbl3.Text = "=>" + "√∆ = " + delta1;
                lbl4.Text = "X1 = X2 = -b / 2a";
                x1 = x2 = (-b) / (2 * a);
                lbl5.Text = "X1 = " + "X2" + " = " + " - " + b + "/" + " 2 × " + a + " = " + x1;
            }
            
        }

        private void txta_TextChanged(object sender, EventArgs e)
        {
            lbl1.Text = lbl2.Text = lbl3.Text = lbl4.Text = lbl5.Text = lbl6.Text = lbl7.Text = "";
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            MyMath.ClearText(this);
            txta.Focus();
        }

        private void txta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                SendKeys.Send("{Tab}");
            if ("0123456789.\b-".IndexOf(e.KeyChar) < 0)
                e.KeyChar = '\0';

        }
    }
}
