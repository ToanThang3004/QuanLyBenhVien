using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhVien.DThuoc
{
    public partial class DSDonThuoc : Form
    {
        qlbenhvienEntities db = new qlbenhvienEntities();
        BindingSource bsDT = new BindingSource();
        public DSDonThuoc()
        {
            InitializeComponent();
            ShowDSDonThuoc();
            Binding();
        }

        void ShowDSDonThuoc()
        {
            var result = from c in db.DonThuocs
                         from d in db.PhieuKhamBenhs
                         from a in db.BenhNhans
                         where (c.MaPhieuKham == d.MaPhieuKham && d.MaBenhNhan == a.MaBenhNhan)
                         select new
                         {
                             c.MaDonThuoc, c.MaPhieuKham, d.MaBenhNhan, a.TenBenhNhan, c.TongChiPhi
                         };
            bsDT.DataSource = result.ToList();
            dgvDonThuoc.DataSource = bsDT;

        }

        void Binding()
        {
            txtMaDT.DataBindings.Add("Text", dgvDonThuoc.DataSource, "MaDonThuoc", false, DataSourceUpdateMode.Never);

        }

        private void txtMaDT_TextChanged(object sender, EventArgs e)
        {
            string madt = txtMaDT.Text;
            DonThuoc dt = db.DonThuocs.Find(madt);
            PhieuKhamBenh pkb = db.PhieuKhamBenhs.Find(dt.MaPhieuKham);
            BenhNhan bn = db.BenhNhans.Find(pkb.MaBenhNhan);

            txtMaPK.Text = dt.MaPhieuKham;
            txtMaBN.Text = pkb.MaBenhNhan;
            txtTenBn.Text = bn.TenBenhNhan;
            txtTongChiPhi.Text = dt.TongChiPhi.ToString();
            var ctd = from c in db.ChiTietDonThuocs where c.MaDonThuoc == madt 
                      select new
                      {
                          c.MaThuoc, c.SoLuongThuoc, c.CachDung, c.GiaThuoc
                      };
            dgvCTDon.DataSource = ctd.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tenbn = txtSearchTBN.Text;
            var result = from c in db.BenhNhans
                         from d in db.DonThuocs
                         from a in db.PhieuKhamBenhs
                         where (c.TenBenhNhan.Contains(tenbn) && c.MaBenhNhan == a.MaBenhNhan && a.MaPhieuKham == d.MaPhieuKham)
                         select new
                         {
                             d.MaDonThuoc,
                             a.MaPhieuKham,
                             a.MaBenhNhan,
                             c.TenBenhNhan,
                             d.TongChiPhi
                         };
            bsDT.DataSource = result.ToList();
        }
    }
}
