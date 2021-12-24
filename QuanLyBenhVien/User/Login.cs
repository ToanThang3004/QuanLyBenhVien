using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyBenhVien.User
{
    public partial class Login : Form
    {
        qlbenhvienEntities db = new qlbenhvienEntities();
        public Login()
        {
            InitializeComponent();
        }
    
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tentk = txtTaiKhoan.Text;
            string matkhau = txtMatKhau.Text;

            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tài khoản");
                return;
            }
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu");
                return;
            }
            var result = from c in db.TaiKhoans where (c.TaiKhoan1 == tentk && c.MatKhau == matkhau) select c;
            if (result.Count() == 0)
            {
                MessageBox.Show("Chi tiết đăng nhập của bạn không chính xác. Vui lòng xem lại");
                return;
            }

            GiaoDienChinh.GiaoDienChinh gdchinh = new GiaoDienChinh.GiaoDienChinh();
            this.Hide();
            gdchinh.ShowDialog();
            this.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnForget_Click(object sender, EventArgs e)
        {
            Forget f_fg = new Forget();
            this.Hide();
            f_fg.ShowDialog();
            this.Show();
        }
    }
}
