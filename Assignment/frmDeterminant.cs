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
    public partial class frmDeterminant : Form
    {
        public frmDeterminant()
        {
            InitializeComponent();
        }

        private void comboBoxEx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index=comboBoxEx1.SelectedIndex;
            if(index==0)
            {
                Det2X2 d2X2 = new Det2X2();
                d2X2.TopLevel = false;
                d2X2.FormBorderStyle = FormBorderStyle.None;
                d2X2.Show();
                MyMath.getChild(d2X2, tabControl1, DockStyle.None);
            }
            else if(index==1)
            {
                det3X3 d3X3 = new det3X3();
                d3X3.TopLevel = false;
                d3X3.FormBorderStyle = FormBorderStyle.None;
                d3X3.Show();
                MyMath.getChild(d3X3, tabControl1, DockStyle.None);
            }
        }
    }
}
