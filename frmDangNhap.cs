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
using System.Data.SqlClient;

namespace App_QL_CSDL
{
    public partial class frmDangNhap : Form
    {

        public frmDangNhap()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn muốn đóng chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {

            frmDangKy fdk = new frmDangKy();
            fdk.ShowDialog();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=TRUONGTOAN\SQLEXPRESS2019;Initial Catalog=QLBanHang;Integrated Security=True");
            try
            {
                sqlCon.Open();
                string tk = txtTenDangNhap.Text;
                string mk = txtMatKhau.Text;
                String sql = "Select * from NGUOIDUNG where TENDANGNHAP = @tendangnhap and MATKHAU = @matKhau";
                SqlCommand cmd = new SqlCommand(sql,sqlCon);
                cmd.Parameters.Add(new SqlParameter("@tendangnhap", tk));
                cmd.Parameters.Add(new SqlParameter("@matKhau", mk));
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                if (sqlDataReader.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    frmShop fshop = new frmShop();
                    fshop.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }

        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienMatKhau.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }
    }
}
