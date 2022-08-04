using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace App_QL_CSDL
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
        }
        //check tk & mk
        public bool checkAccount(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$"); 
        }

        public bool checkEmail(string em)
        {
            return Regex.IsMatch(em,@"^[a-zA-Z0-9._]{3,20}@gmail.com(.vn|)$");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Close();
            frmDangNhap f = new frmDangNhap();
            f.ShowDialog();
        }

        Modify modify = new Modify();

        private void btnDangKyTaiKhoan_Click(object sender, EventArgs e)
        {
            string TenDangNhap = txtTenDangNhap.Text;
            string MatKhau = txtMatKhau.Text;
            string Email = txtEmail.Text;
            string XacNhanMatKhau = txtXacNhanMatKhau.Text;

            if (!checkAccount(TenDangNhap))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập dài khoảng 6 - 24 kí tự, với các kí tự chữ và số, chữ hoa và chữ thường!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (!checkAccount(MatKhau))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu dài khoảng 6 - 24 kí tự, với các kí tự chữ và số, chữ hoa và chữ thường!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!checkEmail(Email))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng email !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(XacNhanMatKhau != MatKhau)
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {

            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }
    }
}
