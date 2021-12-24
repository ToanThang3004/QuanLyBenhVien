using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhVien.User
{
    public partial class Register : Form
    {
        qlbenhvienEntities db = new qlbenhvienEntities();
        public Register()
        {
            InitializeComponent();
        }
        public static bool isValidEmail(string inputEmail)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
      

        private void btnReg_Click(object sender, EventArgs e)
        {
            string manv = txtMaNhanVien.Text;
            string tentk = txtTaiKhoan.Text;
            string mk = txtMatKhau.Text;
            string email = txtEmail.Text;
            string sdt = txtSDT.Text;

            //check textbox ma nhan vien
            // check o ma nhan vien bi bo trong
            if (txtMaNhanVien.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên.");
                return;
            }
            // check nhan vien khong ton tai 
            var checknv = from c in db.NhanViens where c.MaNV == manv select c;
            if (checknv.Count() == 0)
            {
                MessageBox.Show("Không tồn tại nhân viên bạn vừa nhập, không thể lập tài khoản.");
                return;
            }
            // check nhan vien da duoc tao tai khoan su dung phan mem
            var checknv2 = from c in db.TaiKhoans where c.MaNhanVien == manv select c;
            if (checknv2.Count() != 0)
            {
                MessageBox.Show("Nhân viên này đã được tạo tài khoản sử dụng phần mềm rồi.");
                return;
            }
            //check o textbox tai khoan
            // check o tai khoan bi bo trong
            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tài khoản.");
                return;
            }
            // check tai khoan phai 4 ki tu tro len
            if (txtTaiKhoan.Text.Length < 4)
            {
                MessageBox.Show("Tài khoản phải từ 4 kí tự trở lên");
                return;
            }
            // check tai khoan da ton tai
            var checktk2 = from c in db.TaiKhoans where c.TaiKhoan1 == tentk select c;
            if (checktk2.Count() != 0)
            {
                MessageBox.Show("Tên tài khoản này đã tồn tại. Vui lòng đặt tên tài khoản khác.");
                return;
            }
            // check o textbox mat khau
            // check o textbox mat khau bi bo trong
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu");
                return;
            }
            // check mat khau phai tu 4 ki tu tro len
            if (txtMatKhau.Text.Length < 4)
            {
                MessageBox.Show("Mật khẩu phải từ 4 kí tự trở lên");
                return;
            }
            // check textbox email         
            // check textbox email empty
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Email.");
                return;
            }
            // check dinh dang email dang ky
            if (isValidEmail(email) == false)
            {
                MessageBox.Show("Sai định dạng Email. Vui lòng nhập lại");
                return;
            }
            // check email da ton tai
            var checkemail = from c in db.TaiKhoans where c.Email == email select c;
            if (checkemail.Count() != 0)
            {
                MessageBox.Show("Email này đã tồn tại.");
                return;
            }
            // check textbox sdt
            // check textbox sdt empty
            if (txtSDT.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại.");
                return;
            }
            //check sdt da ton tai
            var checksdt = from c in db.TaiKhoans where c.SDT == sdt select c;
            if (checksdt.Count() != 0)
            {
                MessageBox.Show("Số điện thoại này đã tồn tại.");
                return;
            }


            var result = from c in db.TaiKhoans select c;
            int id = 0;
            foreach (var i in result)
            {
                id = id + 1;
            }

            TaiKhoan tk = new TaiKhoan()
            {
                MaTaiKhoan = "TK" + (id + 1),
                MaNhanVien = manv,
                TaiKhoan1 = tentk,
                MatKhau = mk,
                Email = email,
                SDT = sdt
            };
            db.TaiKhoans.Add(tk);
            db.SaveChanges();

            if (db.SaveChanges() == 0)
            {
                MessageBox.Show("Đăng kí tài khoản thành công. \n" +
                    "Mã nhân viên: " + manv + "\n" +
                    "Mã tài khoản: TK" + (id + 1) + "\n" +
                    "Tài khoản: " + tentk + "\n" +
                    "Mật khẩu: " + mk
                    );
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
