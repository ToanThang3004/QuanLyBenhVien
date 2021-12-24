using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhVien.BenhAn
{
    public partial class BenhAn : Form
    {
        qlbenhvienEntities db = new qlbenhvienEntities();
        BindingSource bsBA = new BindingSource();
        public BenhAn()
        {
            InitializeComponent();
            ShowDGVBenhAn();
            Bindings();
        }

        void ShowDGVBenhAn()
        {
            var benhan = from c in db.HoSoBenhAns
                         from d in db.BenhNhans
                         where c.MaBN == d.MaBenhNhan
                         select new { c.MaHoSoBenhAn, c.MaBN, d.TenBenhNhan, d.CMND, c.MaPK };
            bsBA.DataSource = benhan.ToList();
            dgvBenhAn.DataSource = bsBA;
        }

        void Bindings()
        {
            txtMaBA.DataBindings.Add("Text", dgvBenhAn.DataSource, "MaHoSoBenhAn", false, DataSourceUpdateMode.Never);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string s_cmnd = txtSearchCMND.Text;
            string s_tenbn = txtSearchTen.Text;

            var result = from c in db.BenhNhans
                         from d in db.HoSoBenhAns
                         where (c.MaBenhNhan == d.MaBN && (c.CMND == s_cmnd || c.TenBenhNhan.Contains(s_tenbn)))
                         select new { d.MaHoSoBenhAn, d.MaBN, c.TenBenhNhan, c.CMND };
            bsBA.DataSource = result.ToList();
        }

        private void txtMaBA_TextChanged(object sender, EventArgs e)
        {
            string maba = txtMaBA.Text;
            var result = from c in db.HoSoBenhAns
                         from d in db.BenhNhans
                         from a in db.PhieuNhapViens
                         from b in db.Khoas
                         where (c.MaBN == d.MaBenhNhan && c.MaHoSoBenhAn == maba && c.MaBN == a.MaBN && a.MaKhoa == b.MaKhoa)
                         select new { c.MaBN, d.TenBenhNhan, d.CMND, a.MaKhoa, a.NgayNhapVien, c.Benh, b.TenKhoa, c.MaPK };
            foreach(var i in result)
            {
                txtMaPK.Text = i.MaPK;
                txtMaBN.Text = i.MaBN;
                txtTenBN.Text = i.TenBenhNhan;
                txtCMND.Text = i.CMND;
                txtKhoa.Text = i.TenKhoa;
                txtNgayLap.Text = String.Format("{0:d/M/yyyy}", i.NgayNhapVien);
                rtxtBenhAn.Rtf = i.Benh;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
