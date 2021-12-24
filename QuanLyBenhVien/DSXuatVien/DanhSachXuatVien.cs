using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhVien.DSXuatVien
{
    public partial class DanhSachXuatVien : Form
    {
        qlbenhvienEntities db = new qlbenhvienEntities();
        BindingSource listXuatVien = new BindingSource();
        public DanhSachXuatVien()
        {
            InitializeComponent();
            dgvDSXuatVien.DataSource = listXuatVien;
            ShowDl();
            addbindding();


        }

        void ShowDl()
        {
            
            var result = from pnv in db.PhieuNhapViens
                         from pxv in db.PhieuXuatViens
                         from bn in db.BenhNhans
                         from kh in db.Khoas
                         where pnv.MaPhieuNhapVien == pxv.MaPhieuNhapVien
                         && pnv.MaBN == bn.MaBenhNhan && pnv.MaKhoa == kh.MaKhoa
                         select new
                          {
                              pnv.MaPhieuNhapVien,
                              pxv.MaPhieuXuatVien,
                              pxv.NgayXuatVien,
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
                              bn.CMND
                          };

            listXuatVien.DataSource = result.ToList();
        }
        void addbindding()
        {

            txtPhieuNV.DataBindings.Add(new Binding("Text", dgvDSXuatVien.DataSource, "MaPhieuNhapVien", false, DataSourceUpdateMode.Never));
            txtPhieuXV.DataBindings.Add(new Binding("Text", dgvDSXuatVien.DataSource, "MaPhieuXuatVien", false, DataSourceUpdateMode.Never));
            DateNgayXV.DataBindings.Add(new Binding("Value", dgvDSXuatVien.DataSource, "NgayXuatVien", false, DataSourceUpdateMode.Never));
            DateNgayNV.DataBindings.Add(new Binding("Value", dgvDSXuatVien.DataSource, "NgayNhapVien", false, DataSourceUpdateMode.Never));
            txtTenBN.DataBindings.Add(new Binding("Text", dgvDSXuatVien.DataSource, "TenBenhNhan", false, DataSourceUpdateMode.Never));
            txtTenKhoa.DataBindings.Add(new Binding("Text", dgvDSXuatVien.DataSource, "TenKhoa", false, DataSourceUpdateMode.Never));
            txtGioiTinh.DataBindings.Add(new Binding("Text", dgvDSXuatVien.DataSource, "GioiTinh", false, DataSourceUpdateMode.Never));
            txtDiaChi.DataBindings.Add(new Binding("Text", dgvDSXuatVien.DataSource, "DiaChi", false, DataSourceUpdateMode.Never));
            txtCMND.DataBindings.Add(new Binding("Text", dgvDSXuatVien.DataSource, "CMND", false, DataSourceUpdateMode.Never));
            txtBHYT.DataBindings.Add(new Binding("Text", dgvDSXuatVien.DataSource, "MaBaoHiem", false, DataSourceUpdateMode.Never));
            txtDanToc.DataBindings.Add(new Binding("Text", dgvDSXuatVien.DataSource, "DanToc", false, DataSourceUpdateMode.Never));
            DateNgaySinh.DataBindings.Add(new Binding("Value", dgvDSXuatVien.DataSource, "NgaySinh", false, DataSourceUpdateMode.Never));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maxv = txtPhieuXVV.Text;
            DateTime ngxv = dateNgayXVV.Value;
            var result = from pxv in db.PhieuXuatViens
                         from pnv in db.PhieuNhapViens
                         from bn in db.BenhNhans
                         from kh in db.Khoas
                         where ((pxv.MaPhieuXuatVien == maxv) || (pxv.NgayXuatVien == ngxv.Date)) && pnv.MaPhieuNhapVien == pxv.MaPhieuNhapVien
                         && pnv.MaBN == bn.MaBenhNhan && pnv.MaKhoa == kh.MaKhoa
                         select new
                         {
                             pnv.MaPhieuNhapVien,
                             pxv.MaPhieuXuatVien,
                             pxv.NgayXuatVien,
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
                             bn.CMND
                         };
            
            if (result.Count() == 0)
            {
                MessageBox.Show("Không tìm thấy phiếu xuất viện!");
                listXuatVien.DataSource.ToString();
                
            }
            else
            {
                MessageBox.Show("Tim Thanh Cong!");
                listXuatVien.DataSource = result.ToList();
               
            }

        }
    } 
}

