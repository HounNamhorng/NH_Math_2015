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
    public partial class frmRD1 : Form
    {
        public frmRD1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int a, b,c,d;
            int.TryParse(txt1.Text, out a);
            int.TryParse(txt2.Text, out b);
            int.TryParse(txt3.Text, out c);
            int.TryParse(txt4.Text, out d);
            lblr1.Text = a + "x "+" + " + (a * b) + " = " + c + "x " + "+ " + d;

        }
    }
}
