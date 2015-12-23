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
    public partial class frmAddMatrix : Form
    {
        public frmAddMatrix()
        {
            InitializeComponent();
        }

        private void comboBoxEx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxEx1.SelectedIndex;
            if(index==0)
            {
                Add2X2 frm2x2 = new Add2X2();
                frm2x2.TopLevel = false;
                frm2x2.FormBorderStyle = FormBorderStyle.None;
                frm2x2.Show();
                MyMath.getChild(frm2x2,tabControl1,DockStyle.None);
            }
            else if(index==1)
            {
                Add2X3 frm2X3 = new Add2X3();
                frm2X3.TopLevel = false;
                frm2X3.FormBorderStyle = FormBorderStyle.None;
                frm2X3.Show();
                MyMath.getChild(frm2X3, tabControl1, DockStyle.None);
            }
            else if(index==2)
            {
                Add2X4 frm2X4 = new Add2X4();
                frm2X4.TopLevel = false;
                frm2X4.FormBorderStyle = FormBorderStyle.None;
                frm2X4.Show();
                MyMath.getChild(frm2X4, tabControl1, DockStyle.None);
            }
            else if (index == 3)
            {
                Add3X2 frm3X2 = new Add3X2();
                frm3X2.TopLevel = false;
                frm3X2.FormBorderStyle = FormBorderStyle.None;
                frm3X2.Show();
                MyMath.getChild(frm3X2, tabControl1, DockStyle.None);
            }
            else if(index==4)
            {
                Add3X3 frm3X3 = new Add3X3();
                frm3X3.TopLevel = false;
                frm3X3.FormBorderStyle = FormBorderStyle.None;
                frm3X3.Show();
                MyMath.getChild(frm3X3, tabControl1, DockStyle.None);
            }
            else if(index==5)
            {
                Add3X4 frm3X4 = new Add3X4();
                frm3X4.TopLevel = false;
                frm3X4.FormBorderStyle = FormBorderStyle.None;
                frm3X4.Show();
                MyMath.getChild(frm3X4, tabControl1, DockStyle.None);
            }
            else if(index==6)
            {
                Add4X2 frm4X2 = new Add4X2();
                frm4X2.TopLevel = false;
                frm4X2.FormBorderStyle = FormBorderStyle.None;
                frm4X2.Show();
                MyMath.getChild(frm4X2, tabControl1, DockStyle.None);
            }
            else if(index==7)
            {
                Add4X3 frm4X3 = new Add4X3();
                frm4X3.TopLevel = false;
                frm4X3.FormBorderStyle = FormBorderStyle.None;
                frm4X3.Show();
                MyMath.getChild(frm4X3, tabControl1, DockStyle.None);
            }
            else if (index == 8)
            {
                Add4X4 frm4X4 = new Add4X4();
                frm4X4.TopLevel = false;
                frm4X4.FormBorderStyle = FormBorderStyle.None;
                frm4X4.Show();
                MyMath.getChild(frm4X4, tabControl1, DockStyle.None);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
