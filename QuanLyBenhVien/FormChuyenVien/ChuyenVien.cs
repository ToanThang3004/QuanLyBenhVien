using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhVien.FormChuyenVien
{
    public partial class ChuyenVien : Form
    {
        qlbenhvienEntities db = new qlbenhvienEntities();
        private string manhapvien1;
        public ChuyenVien()
        {
            InitializeComponent();
        }

        public ChuyenVien(string manhapvien): this()
        {
            manhapvien1 = manhapvien;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtTenBenhVienChuyen.Text == "")
            {
                MessageBox.Show("Chưa nhập thông tin bệnh viện cần chuyển đến !!!");
                return;
            }

            DateTime now = DateTime.Now;

            var result = from i in db.PhieuChuyenViens
                         select i;

            PhieuNhapVien pn = db.PhieuNhapViens.Find(manhapvien1);
            pn.TinhTrang = "Đã chuyển viện";
            db.SaveChanges();

            PhieuChuyenVien pc = new PhieuChuyenVien();
            pc.MaPhieuNhapVien = manhapvien1;
            pc.MaPhieuChuyenVien = "PC" + (result.Count() + 1);
            pc.TenBenhVienChuyenDi = txtTenBenhVienChuyen.Text;
            pc.NgayChuyenVien = now.Date;

            db.PhieuChuyenViens.Add(pc);

            var giuongcu = from i in db.PhieuNhapViens
                           where i.MaPhieuNhapVien == manhapvien1
                           select new { i.MaGiuong};

            foreach(var i in giuongcu)
            {
                GiuongBenh giuong = db.GiuongBenhs.Find(i.MaGiuong);
                giuong.TrangThai = "Trống";
                break;
            }

            db.SaveChanges();

            if (db.SaveChanges() == 0)
            {
                MessageBox.Show("chuyển viện thành công");
            }
            

            this.Close();

        }
    }
}
