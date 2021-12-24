using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhVien.DSPhieuDichVu
{
    public partial class DSPhieuDichVu : Form
    {
        qlbenhvienEntities db = new qlbenhvienEntities();
        BindingSource listdsphieu = new BindingSource();
        BindingSource listchitiet = new BindingSource();
        public DSPhieuDichVu()
        {
            InitializeComponent();
            dgvDSPhieuDichVu.DataSource = listdsphieu;
            dgvChiTietDichVu.DataSource = listchitiet;
            showdata();
        }

        void showdata()
        {
            var ds = from pk in db.PhieuKhamBenhs
                     from pdv in db.PhieuDichVus
                     from bn in db.BenhNhans
                     where pk.MaPhieuDichVu == pdv.MaPhieuDichVu && bn.MaBenhNhan == pk.MaBenhNhan
                     select new { pk.MaPhieuKham, pk.MaPhieuDichVu, pdv.TongChiPhiDichVu, bn.MaBenhNhan, bn.TenBenhNhan, bn.CMND };

            listdsphieu.DataSource = ds.ToList();
        }

        void showchitiet()
        {
            int row = dgvDSPhieuDichVu.CurrentRow.Index;
            var mapdv = dgvDSPhieuDichVu[1, row].Value.ToString();

            var ct = from i in db.ChiTietPhieuDichVus
                     where i.MaPhieuDichVu == mapdv
                     select i;
            listchitiet.DataSource = ct.ToList();
        }

        private void dgvDSPhieuDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            showchitiet();
        }
    }
}
