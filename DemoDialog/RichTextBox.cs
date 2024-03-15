using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDialog
{
    public partial class RichTextBox : Form
    {
        public RichTextBox()
        {
            InitializeComponent();
        }

        private void fontChu_Click(object sender, EventArgs e)
        {
            FontDialog fd =new FontDialog();
            DialogResult dr = fd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                richTextBox1.SelectionFont= fd.Font;
            }
        }

        private void Color_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            DialogResult dr = cd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                richTextBox1.SelectionColor= cd.Color;
            }
        }

        private void btnSaoChep_Click(object sender, EventArgs e)
        {
            richTextBox2.Rtf = richTextBox1.Rtf;
        }
    }
}
