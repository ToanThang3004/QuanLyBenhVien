using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhVien.DSPhieuNhapVien
{
    public partial class DSPhieuNhapVien : Form
    {
        qlbenhvienEntities db = new qlbenhvienEntities();
        BindingSource listdscho = new BindingSource();
        BindingSource listdsdangtri = new BindingSource();

        public DSPhieuNhapVien()
        {
            InitializeComponent();
            dgvDSCho.DataSource = listdscho;
            dgvDSDangTri.DataSource = listdsdangtri;

            showdata();
        }

        public void showdata()
        {
            
            var dscho = from i in db.PhieuNhapViens
                        where i.TinhTrang == "Chờ Duyệt"
                        select i;

            var dsdangtri = from i in db.PhieuNhapViens
                        where i.TinhTrang == "Đang Điều Trị"
                        select i;

            listdscho.DataSource = dscho.ToList();
            listdsdangtri.DataSource = dsdangtri.ToList();
        }

        private void dgvDSCho_Click(object sender, EventArgs e)
        {
            if (dgvDSCho.RowCount == 0)
            {
                return;
            }

            int row = dgvDSCho.CurrentRow.Index;

            var maphieunhap = dgvDSCho[0, row].Value.ToString();
            var ngay = dgvDSCho[1, row].Value.ToString();
            var khoa = dgvDSCho[2, row].Value.ToString();
            var giuong = dgvDSCho[3, row].Value.ToString();
            var bn = dgvDSCho[4, row].Value.ToString();
            var tinhtrang = dgvDSCho[5, row].Value.ToString();

            var dsgiuong = from g in db.GiuongBenhs
                           from b in db.BuonBenhs
                           from k in db.Khoas
                           where g.MaBuong == b.MaBuong && b.MaKhoa == k.MaKhoa && k.MaKhoa == khoa && g.TrangThai == "Trống"
                           select g;

            cbGiuong.DataSource = dsgiuong.ToList();
            cbGiuong.DisplayMember = "MaGiuong";
            cbGiuong.ValueMember = "MaGiuong";


            txtMaPhieuNhap.Text = maphieunhap;
            datengaynhap.Value = Convert.ToDateTime(ngay);
            txtMaKhoa.Text = khoa;
            cbGiuong.Text = giuong;
            txtMaBenhNhan.Text = bn;
            txtTinhTrang.Text = tinhtrang;

            var tenkhoa = from i in db.Khoas
                          where i.MaKhoa == khoa
                          select i;

            var tenbn = from i in db.BenhNhans
                        where i.MaBenhNhan == bn
                        select i;

            foreach(var i in tenbn)
            {
                txtTenBn.Text = i.TenBenhNhan;
                break;
            }

            foreach(var i in tenkhoa)
            {
                txtTenKhoa.Text = i.TenKhoa;
                break;
            }
        }

        private void dgvDSDangTri_Click(object sender, EventArgs e)
        {
            if(dgvDSDangTri.RowCount == 0)
            {
                return;
            }
            int row = dgvDSDangTri.CurrentRow.Index;

            var maphieunhap = dgvDSDangTri[0, row].Value.ToString();
            var ngay = dgvDSDangTri[1, row].Value.ToString();
            var khoa = dgvDSDangTri[2, row].Value.ToString();
            var giuong = dgvDSDangTri[3, row].Value.ToString();
            var bn = dgvDSDangTri[4, row].Value.ToString();
            var tinhtrang = dgvDSDangTri[5, row].Value.ToString();

            var dsgiuong = from g in db.GiuongBenhs
                           from b in db.BuonBenhs
                           from k in db.Khoas
                           where g.MaBuong == b.MaBuong && b.MaKhoa == k.MaKhoa && k.MaKhoa == khoa && g.TrangThai == "Trống"
                           select g;

            cbGiuong.DataSource = dsgiuong.ToList();
            cbGiuong.DisplayMember = "MaGiuong";
            cbGiuong.ValueMember = "MaGiuong";


            txtMaPhieuNhap.Text = maphieunhap;
            datengaynhap.Value = Convert.ToDateTime(ngay);
            txtMaKhoa.Text = khoa;
            cbGiuong.Text = giuong;
            txtMaBenhNhan.Text = bn;
            txtTinhTrang.Text = tinhtrang;

            var tenkhoa = from i in db.Khoas
                          where i.MaKhoa == khoa
                          select i;

            var tenbn = from i in db.BenhNhans
                        where i.MaBenhNhan == bn
                        select i;

            foreach (var i in tenbn)
            {
                txtTenBn.Text = i.TenBenhNhan;
                break;
            }

            foreach (var i in tenkhoa)
            {
                txtTenKhoa.Text = i.TenKhoa;
                break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var maphieunham = txtMaPhieuNhap.Text;
            var ktbenhnhan = from i in db.PhieuNhapViens
                             where i.MaPhieuNhapVien == maphieunham && i.TinhTrang == "Đang Điều Trị"
                             select i;            
            if(ktbenhnhan.Count() != 0)
            {
                MessageBox.Show("Bệnh nhân này đang được điều trị");
                return;
            }

            PhieuNhapVien pn = db.PhieuNhapViens.Find(maphieunham);
            
            pn.TinhTrang = "Đang Điều Trị";

            db.SaveChanges();

            if(db.SaveChanges() == 0)
            {
                MessageBox.Show("Nhận thành công bệnh nhân");
                showdata();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtMaPhieuNhap.Text == "")
            {
                MessageBox.Show("Chưa chọn bệnh nhân cần sửa, vui lòng chọn lại");
                return;
            }

            var maphieunhap = txtMaPhieuNhap.Text;
            var magiuongmoi = cbGiuong.SelectedValue;

            var magiuongcu = from i in db.PhieuNhapViens
                             where i.MaPhieuNhapVien == maphieunhap
                             select i;

            foreach(var i in magiuongcu)
            {
                GiuongBenh gicu = db.GiuongBenhs.Find(i.MaGiuong);
                gicu.TrangThai = "Trống";

                //db.SaveChanges();
            }

            GiuongBenh gi = db.GiuongBenhs.Find(magiuongmoi.ToString());
            gi.TrangThai = "Có bệnh nhân";
            //db.SaveChanges();

            PhieuNhapVien pn = db.PhieuNhapViens.Find(maphieunhap);
            pn.MaGiuong = magiuongmoi.ToString();

            db.SaveChanges();

            if (db.SaveChanges() == 0)
            {
                MessageBox.Show("Thay đổi giường thành công");
                showdata();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(txtMaPhieuNhap.Text == "")
            {
                MessageBox.Show("Chưa chọn bệnh nhân cần chuyển viện, vui lòng chọn lại");
                return;
            }


            FormChuyenVien.ChuyenVien phc = new FormChuyenVien.ChuyenVien(txtMaPhieuNhap.Text);
            phc.Show();
            
        }

        private void dgvDSDangTri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            showdata();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var maphieunham = txtMaPhieuNhap.Text;
            var ktbenhnhan = from i in db.PhieuNhapViens
                             where i.MaPhieuNhapVien == maphieunham && i.TinhTrang == "Đang Điều Trị"
                             select i;
            if (ktbenhnhan.Count() == 0)
            {
                MessageBox.Show("Bệnh nhân này còn trong qua trình chờ ko thể xuất viện");
                return;
            }

            PhieuNhapVien pn = db.PhieuNhapViens.Find(maphieunham);
            pn.TinhTrang = "Xuất viện";
            

            foreach(var i in ktbenhnhan)
            {
                GiuongBenh giuong = db.GiuongBenhs.Find(i.MaGiuong);
                giuong.TrangThai = "Trống";
            }

            var tongphieuxuat = from i in db.PhieuXuatViens
                                select i;
            DateTime timenow = DateTime.Now;
            PhieuXuatVien pxuat = new PhieuXuatVien();
            pxuat.MaPhieuNhapVien = maphieunham;
            pxuat.MaPhieuXuatVien = "PX" + (tongphieuxuat.Count() + 1);
            pxuat.NgayXuatVien = timenow.Date;

            db.PhieuXuatViens.Add(pxuat);
            db.SaveChanges();

            if(db.SaveChanges() == 0)
            {
                MessageBox.Show("Cho bệnh nhân xuất viện thành công");
                showdata();
            }
        }

        private void dgvDSCho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            showdata();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DSChuyenVien.DanhSachChuyenVien dschuyen = new DSChuyenVien.DanhSachChuyenVien();
            dschuyen.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DSXuatVien.DanhSachXuatVien dsxuat = new DSXuatVien.DanhSachXuatVien();
            dsxuat.Show();
        }
    }
}
