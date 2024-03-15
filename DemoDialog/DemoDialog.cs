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
    public partial class DemoDialog : Form
    {
        public DemoDialog()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Chon tap tin hinh anh";
            ofd.InitialDirectory = @"C:\\Windows";
            ofd.Filter = "Hinh anh |*.png,*.pdf";
            ofd.Multiselect = true;
            DialogResult dr = ofd.ShowDialog();
            if (dr != DialogResult.Cancel)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}
