using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trang56
{
    public partial class frmRadioButton : Form
    {
        public frmRadioButton()
        {
            InitializeComponent();
        }

        private void rbNam_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbNam.Checked)
            {
                MessageBox.Show("Gioi tinh cua ban la: " + rbNam.Text);
            }
        }

        private void rbNu_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbNu.Checked)
            {
                MessageBox.Show("Gioi tinh cua ban la: " + rbNu.Text);
            }
        }
    }
}
