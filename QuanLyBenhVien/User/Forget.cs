using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.IO;

namespace QuanLyBenhVien.User
{
    public partial class Forget : Form
    {
        qlbenhvienEntities db = new qlbenhvienEntities();
        public Forget()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string checktk = txtSearchTK.Text;

            var result = from c in db.TaiKhoans where c.Email == checktk select c;
            foreach (var i in result)
            {
                txtTaiKhoan.Text = i.TaiKhoan1;
                txtMaNV.Text = i.MaNhanVien;
            }
        }
     
        private void btnLayma_Click(object sender, EventArgs e)
        {
            txtMaXN.ReadOnly = false;
            string manv = txtMaNV.Text;
            var result = from c in db.TaiKhoans where c.MaNhanVien == manv select c;
            Random rd = new Random();
            int maxn = 0;
            maxn = rd.Next(100000, 999999);
            foreach (var i in result) {
                LayMatKhau lmk = new LayMatKhau()
                {
                    MaTaiKhoan = i.MaTaiKhoan,
                    MaXacNhan = maxn.ToString()
                };
                db.LayMatKhaus.Add(lmk);
            }
            db.SaveChanges();

            // tạo một tin nhắn và thêm những thông tin cần thiết như: ai gửi, người nhận, tên tiêu đề, và có đôi lời gì cần nhắn nhủ
            MailMessage mail = new MailMessage("quoctan342@gmail.com", txtSearchTK.Text, "Mã xác nhận tạo mật khẩu mới", "Mã xác nhận tạo mật khẩu mới của bạn là:" + maxn); //
            mail.IsBodyHtml = true;
            //gửi tin nhắn
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Host = "smtp.gmail.com";
            //ta không dùng cái mặc định đâu, mà sẽ dùng cái của riêng mình
            client.UseDefaultCredentials = false;
            client.Port = 587; //vì sử dụng Gmail nên mình dùng port 587
                               // thêm vào credential vì SMTP server cần nó để biết được email + password của email đó mà bạn đang dùng
            client.Credentials = new System.Net.NetworkCredential("quoctan342@gmail.com", "thachvi123@@@");
            client.EnableSsl = true; //vì ta cần thiết lập kết nối SSL với SMTP server nên cần gán nó bằng true
            client.Send(mail);
            MessageBox.Show("Đã gửi tin nhắn thành công!", "Thành Công", MessageBoxButtons.OK);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string manv = txtMaNV.Text;
            string maxn = txtMaXN.Text;
            var result = from c in db.TaiKhoans
                         where c.MaNhanVien == manv
                         select c;
            foreach (var i in result)
            {
                var re = from c in db.LayMatKhaus
                         where (c.MaTaiKhoan == i.MaTaiKhoan) select c;
                foreach (var a in re)
                {
                    if (a.MaTaiKhoan == i.MaTaiKhoan && a.MaXacNhan == maxn)
                    {
                        txtMKM.ReadOnly = false;
                        var xoamxn = from c in db.LayMatKhaus where c.MaXacNhan == maxn select c;
                        foreach (var b in xoamxn)
                        {
                            db.LayMatKhaus.Remove(b);
                        }

                        break;
                    } else
                    {
                        MessageBox.Show("Mã xác nhận không chính xác.");
                        break;
                    }
                }
            }
            db.SaveChanges();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDat_Click(object sender, EventArgs e)
        {
            string manv = txtMaNV.Text;
            string mk = txtMKM.Text;

            var result = from c in db.TaiKhoans
                         where c.MaNhanVien == manv
                         select c;
            foreach (var i in result)
            {
                TaiKhoan tk = db.TaiKhoans.Find(i.MaTaiKhoan);
                tk.MatKhau = mk;
            }

            db.SaveChanges();
            if (db.SaveChanges() == 0)
            {
                MessageBox.Show("Đặt mật khẩu mới thành công.");
                this.Close();
            }
        }
    }
}
