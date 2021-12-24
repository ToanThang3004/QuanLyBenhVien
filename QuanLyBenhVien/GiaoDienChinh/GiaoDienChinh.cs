using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhVien.GiaoDienChinh
{
    public partial class GiaoDienChinh : Form
    {
        public GiaoDienChinh()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QLNhanVien.QLNhanVien qlnv = new QLNhanVien.QLNhanVien();
            qlnv.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 bn = new Form1();
            bn.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QLGiuongBenh.QLGiuongBenh qlgiuong = new QLGiuongBenh.QLGiuongBenh();
            qlgiuong.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Thuoc.Thuoc qlthuoc = new Thuoc.Thuoc();
            qlthuoc.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            QLKhoa.QLKhoa qlkhoa = new QLKhoa.QLKhoa();
            qlkhoa.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            d1 qldichvu = new d1();
            qldichvu.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            TTBenhVien.TTBenhVien qlttbenhvien = new TTBenhVien.TTBenhVien();
            qlttbenhvien.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TraCuuDoanhThu.TraCuuDoanhThu qldoanhthu = new TraCuuDoanhThu.TraCuuDoanhThu();
            qldoanhthu.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            phieukham.PhieuKham lappk = new phieukham.PhieuKham();
            lappk.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DSPhieuNhapVien.DSPhieuNhapVien dsnhap = new DSPhieuNhapVien.DSPhieuNhapVien();
            dsnhap.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DSXuatVien.DanhSachXuatVien dsxuatvien = new DSXuatVien.DanhSachXuatVien();
            dsxuatvien.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            TTVienPhi.TTVienPhi ttvienphi = new TTVienPhi.TTVienPhi();
            ttvienphi.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            HoaDon.TTHoaDon hd = new HoaDon.TTHoaDon();
            hd.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DThuoc.DSDonThuoc qldonthuoc = new DThuoc.DSDonThuoc();
            qldonthuoc.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DSChuyenVien.DanhSachChuyenVien dschuyenvien = new DSChuyenVien.DanhSachChuyenVien();
            dschuyenvien.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            BenhAn.BenhAn dsbenhan = new BenhAn.BenhAn();
            dsbenhan.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            User.Register dangki = new User.Register();
            dangki.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            DSPhieuDichVu.DSPhieuDichVu pdv = new DSPhieuDichVu.DSPhieuDichVu();
            pdv.Show();
        }
    }
}
