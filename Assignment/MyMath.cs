using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Assignment
{
    class MyMath
    {
        public static void ClearText(Form form1)
        {
            foreach (TextBox txt in form1.Controls.OfType<TextBox>())
            {
                txt.Clear();
            }
        }
        public static void getChild(Control frm, TabControl tabControl1, DockStyle DockStyle)
        {
            foreach (var item in tabControl1.TabPages.OfType<TabPage>())
            {
                if (frm.Name == item.Text)
                {
                    tabControl1.SelectTab(frm.Name);
                    return;
                }
            }
            frm.Dock = DockStyle;
            frm.Left = (tabControl1.Width - frm.Width) / 2;
            tabControl1.TabPages.Add(frm.Name, frm.Name, 0);
            tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(frm);
            tabControl1.SelectTab(frm.Name);
            hideTitleTabPage(tabControl1);
        }
        private static void hideTitleTabPage(TabControl TC)
        {
            foreach (TabPage tp in TC.TabPages)
            {
                TC.Region = new Region(new RectangleF(tp.Left, tp.Top, tp.Width, tp.Height));
            }

        }
    }
}
