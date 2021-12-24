using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhVien.DSChuyenVien
{
    public partial class DanhSachChuyenVien : Form
    {
        qlbenhvienEntities db = new qlbenhvienEntities();
        BindingSource listChuyenVien = new BindingSource();
        public DanhSachChuyenVien()
        {
            InitializeComponent();
            dgvDSChuyenVien.DataSource = listChuyenVien;
            ShowDL();
            addbindding();
        }
        void ShowDL()
        {
       
        var result = from pnv in db.PhieuNhapViens
                          from pcv in db.PhieuChuyenViens
                          from bn in db.BenhNhans
                          from kh in db.Khoas
                          
                          where  pnv.MaPhieuNhapVien == pcv.MaPhieuNhapVien && pnv.MaBN == bn.MaBenhNhan
                          && pnv.MaKhoa == kh.MaKhoa 
                          select new
                          {
                              pnv.MaPhieuNhapVien,
                              pcv.MaPhieuChuyenVien,
                              pcv.NgayChuyenVien,
                              pcv.TenBenhVienChuyenDi,
                              pnv.NgayNhapVien,
                              pnv.MaBN,
                              pnv.MaKhoa,
                              kh.TenKhoa,
                              bn.TenBenhNhan,
                              bn.DiaChi,
                              bn.GioiTinh,
                              bn.MaBaoHiem,
                              bn.NgaySinh,
                              bn.DanToc,
                              bn.CMND,
                          };
            listChuyenVien.DataSource = result.ToList();

        }
        void addbindding()
        {
            txtPhieuNV.DataBindings.Add(new Binding("Text", dgvDSChuyenVien.DataSource, "MaPhieuNhapVien", false, DataSourceUpdateMode.Never));
            txtPhieuCV.DataBindings.Add(new Binding("Text", dgvDSChuyenVien.DataSource, "MaPhieuChuyenVien", false, DataSourceUpdateMode.Never));
            DateNgayCV.DataBindings.Add(new Binding("Value", dgvDSChuyenVien.DataSource, "NgayChuyenVien", false, DataSourceUpdateMode.Never));
            DateNgayNV.DataBindings.Add(new Binding("Value", dgvDSChuyenVien.DataSource, "NgayNhapVien", false, DataSourceUpdateMode.Never));
            txtTenBN.DataBindings.Add(new Binding("Text", dgvDSChuyenVien.DataSource, "TenBenhNhan", false, DataSourceUpdateMode.Never));
            txtTenKhoa.DataBindings.Add(new Binding("Text", dgvDSChuyenVien.DataSource, "TenKhoa", false, DataSourceUpdateMode.Never));
            txtGioiTinh.DataBindings.Add(new Binding("Text", dgvDSChuyenVien.DataSource, "GioiTinh", false, DataSourceUpdateMode.Never));
            txtDiaChi.DataBindings.Add(new Binding("Text", dgvDSChuyenVien.DataSource, "DiaChi", false, DataSourceUpdateMode.Never));
            txtCMND.DataBindings.Add(new Binding("Text", dgvDSChuyenVien.DataSource, "CMND", false, DataSourceUpdateMode.Never));
            txtBHYT.DataBindings.Add(new Binding("Text", dgvDSChuyenVien.DataSource, "MaBaoHiem", false, DataSourceUpdateMode.Never));
            txtDanToc.DataBindings.Add(new Binding("Text", dgvDSChuyenVien.DataSource, "DanToc", false, DataSourceUpdateMode.Never));
            DateNgaySinh.DataBindings.Add(new Binding("Value", dgvDSChuyenVien.DataSource, "NgaySinh", false, DataSourceUpdateMode.Never));
            txtTenBV.DataBindings.Add(new Binding("Text", dgvDSChuyenVien.DataSource, "TenBenhVienChuyenDi", false, DataSourceUpdateMode.Never));

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string macv = txtPhieuCVV.Text;
            DateTime ngvcv = dateNgayCVV.Value;
            var result = from pnv in db.PhieuNhapViens
                          from pcv in db.PhieuChuyenViens
                          from bn in db.BenhNhans
                          from kh in db.Khoas
                          from bv in db.BenhViens
                          where ((pcv.MaPhieuChuyenVien == macv )|| (pcv.NgayChuyenVien == ngvcv.Date))
                          && pnv.MaPhieuNhapVien == pcv.MaPhieuNhapVien && pnv.MaBN == bn.MaBenhNhan
                          && pnv.MaKhoa == kh.MaKhoa 
                          select new
                          {
                              pnv.MaPhieuNhapVien,
                              pcv.MaPhieuChuyenVien,
                              pcv.NgayChuyenVien,
                              pcv.TenBenhVienChuyenDi,
                              pnv.NgayNhapVien,
                              pnv.MaBN,
                              pnv.MaKhoa,
                              kh.TenKhoa,
                              bn.TenBenhNhan,
                              bn.DiaChi,
                              bn.GioiTinh,
                              bn.MaBaoHiem,
                              bn.NgaySinh,
                              bn.DanToc,
                              bn.CMND,
                              
                          };
            if(result.Count() == 0)
            {
                MessageBox.Show("Không tìm thấy phiều chuyển viện!");
                return;
            }
            else
            {
                MessageBox.Show("Tìm thành công!");
                listChuyenVien.DataSource = result.ToList();

            }
        }
    }
}
