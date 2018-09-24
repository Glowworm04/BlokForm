using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class fmMenu : Form
    {
        public fmMenu()
        {
            InitializeComponent();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            fmImage image = new fmImage();
            image.ShowDialog();
        }

        private void btnDGV_Click(object sender, EventArgs e)
        {
            fmDGV dgv = new fmDGV();
            dgv.ShowDialog();
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            fmData date = new fmData();
            date.ShowDialog();
        }
    }
}
