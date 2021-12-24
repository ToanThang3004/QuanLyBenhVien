using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhVien.HoaDon
{
    public partial class TTHoaDon : Form
    {
        qlbenhvienEntities db = new qlbenhvienEntities();
        BindingSource listHoaDon = new BindingSource();
        public TTHoaDon()
        {
            InitializeComponent();
            dgvHoaDon.DataSource = listHoaDon;
            ShowDL();
            addbindding();
        }
        void ShowDL()
        {
            var result = from vp in db.VienPhis
                         from bn in db.BenhNhans
                         where vp.MaBenhNhan == bn.MaBenhNhan
                         select new { 
                                         vp.MaVienPhi,
                                         vp.MaBenhNhan,
                                         vp.TienDichVu,
                                         vp.TienThuoc,
                                         vp.TienKham,
                                         vp.NgayLap,
                                         vp.TongTien,
                                         bn.TenBenhNhan,
                                         bn.GioiTinh,
                                         bn.MaBaoHiem,
                                         bn.DiaChi, 
                                         bn.CMND,
                                         bn.DanToc,
                                         vp.MaPK,
                                         vp.NgayThanhToan
                                     };

            listHoaDon.DataSource = result.ToList();
        }
        void addbindding()
        {
            txtMaHD.DataBindings.Add(new Binding("Text", dgvHoaDon.DataSource, "MaVienPhi", false, DataSourceUpdateMode.Never));
            txtTenBN.DataBindings.Add(new Binding("Text", dgvHoaDon.DataSource, "TenBenhNhan", false, DataSourceUpdateMode.Never));
            txtDiaChi.DataBindings.Add(new Binding("Text", dgvHoaDon.DataSource, "DiaChi", false, DataSourceUpdateMode.Never));
            dateThanhToan.DataBindings.Add(new Binding("Value", dgvHoaDon.DataSource, "NgayThanhToan", false, DataSourceUpdateMode.Never));
            txtGioiTinh.DataBindings.Add(new Binding("Text", dgvHoaDon.DataSource, "GioiTinh", false, DataSourceUpdateMode.Never));
            txtBHYT.DataBindings.Add(new Binding("Text", dgvHoaDon.DataSource, "MaBaoHiem", false, DataSourceUpdateMode.Never));
            txtCMND.DataBindings.Add(new Binding("Text", dgvHoaDon.DataSource, "CMND", false, DataSourceUpdateMode.Never));
            txtDanToc.DataBindings.Add(new Binding("Text", dgvHoaDon.DataSource, "DanToc", false, DataSourceUpdateMode.Never));
            txtTienKham.DataBindings.Add(new Binding("Text", dgvHoaDon.DataSource, "TienKham", false, DataSourceUpdateMode.Never));
            txtTongCPThuoc.DataBindings.Add(new Binding("Text", dgvHoaDon.DataSource, "TienThuoc", false, DataSourceUpdateMode.Never));
            txtTongCPDV.DataBindings.Add(new Binding("Text", dgvHoaDon.DataSource, "TienDichVu", false, DataSourceUpdateMode.Never));
            txtTongTienHoaDon.DataBindings.Add(new Binding("Text", dgvHoaDon.DataSource, "TongTien", false, DataSourceUpdateMode.Never));
           


        }

        private void bntTimKiem_Click(object sender, EventArgs e)
        {

            DateTime ngtt = dateNgayTT.Value;
            var result = from vp in db.VienPhis
                         from bn in db.BenhNhans
                         where vp.MaBenhNhan == bn.MaBenhNhan
                         select new
                         {
                             vp.MaVienPhi,
                             vp.MaBenhNhan,
                             vp.TienDichVu,
                             vp.TienThuoc,
                             vp.TienKham,
                             vp.NgayLap,
                             vp.TongTien,
                             bn.TenBenhNhan,
                             bn.GioiTinh,
                             bn.MaBaoHiem,
                             bn.DiaChi,
                             bn.CMND,
                             bn.DanToc,
                             vp.MaPK,
                             vp.NgayThanhToan
                         };

            if (result.Count() == 0)
            {
                MessageBox.Show("Không tìm thấy phiếu xuất viện!");
                listHoaDon.DataSource.ToString();

            }
            else
            {
                MessageBox.Show("Tim Thanh Cong!");
                listHoaDon.DataSource = result.ToList();

            }
        }

       
    }
}
