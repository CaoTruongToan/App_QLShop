using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_QL_CSDL
{
    public partial class frmShop : Form
    {
        public frmShop()
        {
            InitializeComponent();
        }

        private void DangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DangXuatToolStripMenuItem.Enabled = false;
            Application.Exit();

        }

        private void DangXuatToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn muốn đăng xuất", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }

}
