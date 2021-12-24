using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBenhVien.phieukham;

namespace QuanLyBenhVien
{
    public partial class Form1 : Form
    {
        qlbenhvienEntities db = new qlbenhvienEntities();
        BindingSource listBN = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            dgvDSBN.DataSource = listBN;
            show();
            bindding();
        }
        void show()
        {
            var result = from c in db.BenhNhans
                         select c;
            listBN.DataSource = result.ToList();

        }

        void bindding()
        {
            txtTenBenhNhan.DataBindings.Add(new Binding("Text", dgvDSBN.DataSource, "TenBenhNhan", false, DataSourceUpdateMode.Never));
            txtMaBenhNhan.DataBindings.Add(new Binding("Text", dgvDSBN.DataSource, "MaBenhNhan", false, DataSourceUpdateMode.Never));
            txtCMND.DataBindings.Add(new Binding("Text", dgvDSBN.DataSource, "CMND", false, DataSourceUpdateMode.Never));
            txtDanToc.DataBindings.Add(new Binding("Text", dgvDSBN.DataSource, "DanToc", false, DataSourceUpdateMode.Never));
            dateNgaySinh.DataBindings.Add(new Binding("Text", dgvDSBN.DataSource, "NgaySinh", false, DataSourceUpdateMode.Never));
            txtDiaChi.DataBindings.Add(new Binding("Text", dgvDSBN.DataSource, "DiaChi", false, DataSourceUpdateMode.Never));
            txtGioiTinh.DataBindings.Add(new Binding("Text", dgvDSBN.DataSource, "GioiTinh", false, DataSourceUpdateMode.Never));
            txtBHYT.DataBindings.Add(new Binding("Text", dgvDSBN.DataSource, "MaBaoHiem", false, DataSourceUpdateMode.Never));
        }


        // btn timkiem
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string MaBN = txtMaTimKiem.Text;
            string TenBN = txtTenTimKiem.Text;
            

            var result = from c in db.BenhNhans
                         where (c.MaBenhNhan == MaBN || c.TenBenhNhan == TenBN)
                         select c;
            listBN.DataSource = result.ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenBenhNhan.Text == "" || txtCMND.Text == "" || txtGioiTinh.Text == "" || txtDanToc.Text == "" || txtBHYT.Text == "" || txtDiaChi.Text == "")
            {
                MessageBox.Show("Có lỗi xảy ra.");
                return;
            }
            var cmnd = txtCMND.Text;
            var ktcmd = from i in db.BenhNhans
                        where i.CMND == cmnd
                        select i;
            if(ktcmd.Count() != 0)
            {
                MessageBox.Show("CMND bị trùng, mời nhập lại!!!");
                return;
            }

            var result = from c in db.BenhNhans
                         select c;
            int slbn = result.Count() + 1;

            BenhNhan bn = new BenhNhan();
            bn.MaBenhNhan = "BN" + slbn;
            bn.TenBenhNhan = txtTenBenhNhan.Text;
            bn.CMND = txtCMND.Text;
            bn.GioiTinh = txtGioiTinh.Text;
            bn.DanToc = txtDanToc.Text;
            bn.NgaySinh = dateNgaySinh.Value;
            bn.DiaChi = txtDiaChi.Text;
            bn.MaBaoHiem = txtBHYT.Text;

            db.BenhNhans.Add(bn);
            db.SaveChanges();
            show();

            if(db.SaveChanges() == 0)
            {
                MessageBox.Show("Them thanh cong");
            }
            else
            {
                MessageBox.Show("Them loi");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenBenhNhan.Text == "" || txtCMND.Text == "" || txtGioiTinh.Text == "" || txtDanToc.Text == "" || txtBHYT.Text == "" || txtDiaChi.Text == "")
            {
                MessageBox.Show("Có lỗi xảy ra.");
                return;
            }
            string mabn = txtMaBenhNhan.Text;

            BenhNhan bn = db.BenhNhans.Find(mabn);

            bn.TenBenhNhan = txtTenBenhNhan.Text;
            bn.CMND = txtCMND.Text;
            bn.GioiTinh = txtGioiTinh.Text;
            bn.DanToc = txtDanToc.Text;
            bn.NgaySinh = dateNgaySinh.Value;
            bn.DiaChi = txtDiaChi.Text;
            bn.MaBaoHiem = txtBHYT.Text;

            db.SaveChanges();
            show();

            if(db.SaveChanges() == 0)
            {
                MessageBox.Show("Thay doi thanh cong");
            }
            else
            {
                MessageBox.Show("Thay doi thay bai");
            }
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnchuyen_Click(object sender, EventArgs e)
        {
            PhieuKham pk = new PhieuKham();
            pk.Show();
        }
    }
}
