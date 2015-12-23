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
    public partial class frmMultipleMatrix : Form
    {
        public frmMultipleMatrix()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int row, col;
            int.TryParse(txtRow.Text, out row);
            int.TryParse(txtColumn.Text, out col);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    TextBox texbox = new TextBox();
                    texbox.Size=new Size(30,10);
                    texbox.Location = new Point(i, 10);
                    Controls.Add(texbox);
                }
            }
        }
    }
}
