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
    public partial class frmAllMath : Form
    {
        public frmAllMath()
        {
            InitializeComponent();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            frmAddFraction frmadd = new frmAddFraction();
            frmadd.TopLevel = false;
            frmadd.FormBorderStyle = FormBorderStyle.None;
            frmadd.Show();
            MyMath.getChild(frmadd, tabControl1, DockStyle.None);
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            frmMinusFraction frmin = new frmMinusFraction();
            frmin.TopLevel = false;
            frmin.FormBorderStyle = FormBorderStyle.None;
            frmin.Show();
            MyMath.getChild(frmin, tabControl1, DockStyle.None);
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            frmMultipleFraction frmul = new frmMultipleFraction();
            frmul.TopLevel = false;
            frmul.FormBorderStyle = FormBorderStyle.None;
            frmul.Show();
            MyMath.getChild(frmul, tabControl1, DockStyle.None);
        }

        private void buttonX7_Click(object sender, EventArgs e)
        {
            frmDivideFraction frmdiv = new frmDivideFraction();
            frmdiv.TopLevel = false;
            frmdiv.FormBorderStyle = FormBorderStyle.None;
            frmdiv.Show();
            MyMath.getChild(frmdiv, tabControl1, DockStyle.None);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit", "Confirm you again", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                this.Close();
        }

        private void btnequation2_Click(object sender, EventArgs e)
        {
            frmEquationDegreeII frmEq = new frmEquationDegreeII();
            frmEq.TopLevel = false;
            frmEq.FormBorderStyle = FormBorderStyle.None;
            frmEq.Show();
            MyMath.getChild(frmEq, tabControl1, DockStyle.None);
        }

        private void btnaddmatrix_Click(object sender, EventArgs e)
        {
            frmAddMatrix frmAddM = new frmAddMatrix();
            frmAddM.TopLevel = false;
            frmAddM.FormBorderStyle = FormBorderStyle.None;
            frmAddM.Show();
            MyMath.getChild(frmAddM, tabControl1, DockStyle.None);
        }

        private void btnmultiplematrix_Click(object sender, EventArgs e)
        {
            frmMultipleMatrix frmMMul = new frmMultipleMatrix();
            frmMMul.TopLevel = false;
            frmMMul.FormBorderStyle = FormBorderStyle.None;
            frmMMul.Show();
            MyMath.getChild(frmMMul, tabControl1, DockStyle.None);
        }

        private void btnminusmatrix_Click(object sender, EventArgs e)
        {
            frmMinusMatrix frmMinusM = new frmMinusMatrix();
            frmMinusM.TopLevel = false;
            frmMinusM.FormBorderStyle = FormBorderStyle.None;
            frmMinusM.Show();
            MyMath.getChild(frmMinusM, tabControl1, DockStyle.None);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void btnsquarematrix_Click(object sender, EventArgs e)
        {
            frmDeterminant frmdet = new frmDeterminant();
            frmdet.TopLevel = false;
            frmdet.FormBorderStyle = FormBorderStyle.None;
            frmdet.Show();
            MyMath.getChild(frmdet, tabControl1, DockStyle.None);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            lbltimer.Left -= 2;
            if (lbltimer.Left <0)
                lbltimer.Left = this.Width;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAboutme aboutme = new frmAboutme();
            aboutme.ShowDialog();
        }
    }
}
