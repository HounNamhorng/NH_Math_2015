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
    public partial class frmMinusMatrix : Form
    {
        public frmMinusMatrix()
        {
            InitializeComponent();
        }

        private void comboBoxEx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxEx1.SelectedIndex;
            if(index==0)
            {
                Minus2X2 frm2x2 = new Minus2X2();
                frm2x2.TopLevel = false;
                frm2x2.FormBorderStyle = FormBorderStyle.None;
                frm2x2.Show();
                MyMath.getChild(frm2x2,tabControl1,DockStyle.None);
            }
            else if(index==1)
            {
                Minus2X3 frm2X3 = new Minus2X3();
                frm2X3.TopLevel = false;
                frm2X3.FormBorderStyle = FormBorderStyle.None;
                frm2X3.Show();
                MyMath.getChild(frm2X3, tabControl1, DockStyle.None);
            }
            else if(index==2)
            {
                Minus2X4 frm2X4 = new Minus2X4();
                frm2X4.TopLevel = false;
                frm2X4.FormBorderStyle = FormBorderStyle.None;
                frm2X4.Show();
                MyMath.getChild(frm2X4, tabControl1, DockStyle.None);
            }
            else if (index == 3)
            {
                Minus3X2 frm3X2 = new Minus3X2();
                frm3X2.TopLevel = false;
                frm3X2.FormBorderStyle = FormBorderStyle.None;
                frm3X2.Show();
                MyMath.getChild(frm3X2, tabControl1, DockStyle.None);
            }
            else if(index==4)
            {
                Minus3X3 frm3X3 = new Minus3X3();
                frm3X3.TopLevel = false;
                frm3X3.FormBorderStyle = FormBorderStyle.None;
                frm3X3.Show();
                MyMath.getChild(frm3X3, tabControl1, DockStyle.None);
            }
            else if(index==5)
            {
                Minus3X4 frm3X4 = new Minus3X4();
                frm3X4.TopLevel = false;
                frm3X4.FormBorderStyle = FormBorderStyle.None;
                frm3X4.Show();
                MyMath.getChild(frm3X4, tabControl1, DockStyle.None);
            }
            else if(index==6)
            {
                Minus4X2 frm4X2 = new Minus4X2();
                frm4X2.TopLevel = false;
                frm4X2.FormBorderStyle = FormBorderStyle.None;
                frm4X2.Show();
                MyMath.getChild(frm4X2, tabControl1, DockStyle.None);
            }
            else if(index==7)
            {
                Minus4X3 frm4X3 = new Minus4X3();
                frm4X3.TopLevel = false;
                frm4X3.FormBorderStyle = FormBorderStyle.None;
                frm4X3.Show();
                MyMath.getChild(frm4X3, tabControl1, DockStyle.None);
            }
            else if (index == 8)
            {
                Minus4X4 frm4X4 = new Minus4X4();
                frm4X4.TopLevel = false;
                frm4X4.FormBorderStyle = FormBorderStyle.None;
                frm4X4.Show();
                MyMath.getChild(frm4X4, tabControl1, DockStyle.None);
            }
        }
    }
}
