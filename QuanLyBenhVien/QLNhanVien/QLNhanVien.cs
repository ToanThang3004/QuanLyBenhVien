using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhVien.QLNhanVien
{
    public partial class QLNhanVien : Form
    {
        qlbenhvienEntities db = new qlbenhvienEntities();
        BindingSource listnv = new BindingSource();
        public QLNhanVien()
        {
            InitializeComponent();
            dgvDSNV.DataSource = listnv;

            showdata();
            binding();
        }

        void showdata()
        {
            var dsnv = from i in db.NhanViens
                       where i.TonTai == 1
                       select i;

            listnv.DataSource = dsnv.ToList();
        }

        void binding()
        {
            txtMaNV.DataBindings.Add(new Binding("Text", dgvDSNV.DataSource, "MaNV", false, DataSourceUpdateMode.Never));
            txtTenNV.DataBindings.Add(new Binding("Text", dgvDSNV.DataSource, "TenNhanVien", false, DataSourceUpdateMode.Never));
            txtGioiTinh.DataBindings.Add(new Binding("Text", dgvDSNV.DataSource, "GioiTinh", false, DataSourceUpdateMode.Never));
            dateNgaySinh.DataBindings.Add(new Binding("Value", dgvDSNV.DataSource, "NgaySinh", false, DataSourceUpdateMode.Never));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tenbn = txtTenTimKiem.Text;

            var result = from i in db.NhanViens
                         where i.TenNhanVien.Contains(tenbn) && i.TonTai == 1
                         select i;

            listnv.DataSource = result.ToList();
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            var manv = txtMaNV.Text;

            var khoa = from k in db.Khoas
                       where k.TonTai == 1
                       select k;

            var khoacuanv = from nv in db.NhanViens
                            from k in db.Khoas
                            where nv.MaKhoa == k.MaKhoa && nv.MaNV == manv
                            select k;

            cbKhoa.DataSource = khoa.ToList();
            cbKhoa.DisplayMember = "TenKhoa";
            cbKhoa.ValueMember = "MaKhoa";

            foreach(var i in khoacuanv)
            {
                cbKhoa.Text = i.TenKhoa;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtGioiTinh.Text == "" || txtTenNV.Text == "")
            {
                MessageBox.Show("Có lỗi xảy ra");
                return;
            }
          
            var tongnv = from i in db.NhanViens
                         select i;

            NhanVien nv = new NhanVien();
            nv.MaNV = "NV" + (tongnv.Count() + 1);
            nv.TenNhanVien = txtTenNV.Text;
            nv.GioiTinh = txtGioiTinh.Text;
            nv.NgaySinh = dateNgaySinh.Value;
            nv.MaKhoa = cbKhoa.SelectedValue.ToString();
            nv.TonTai = 1;
           

            db.NhanViens.Add(nv);
            db.SaveChanges();

            if(db.SaveChanges() == 0)
            {
                MessageBox.Show("Thêm thành công nhân viên mới");
                showdata();
            }
            else
            {
                MessageBox.Show("Thêm không thành công!  Dữ liệu sai");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtGioiTinh.Text == "" || txtTenNV.Text == "")
            {
                MessageBox.Show("Có lỗi xảy ra");
                return;
            }
            var manv = txtMaNV.Text;
            var makhoa = cbKhoa.SelectedValue.ToString();

            var kttruongkhoa = from k in db.Khoas
                               from n in db.NhanViens
                               where k.MaKhoa == n.MaKhoa && k.TruongKhoa == manv
                               select n;
            var ktdoikhoa = from n in db.NhanViens
                            where n.MaNV == manv && n.MaKhoa != makhoa
                            select n;


            if(kttruongkhoa.Count() != 0 && kttruongkhoa.Count() != 0)
            {
                MessageBox.Show("Người này là trường khoa, không được đổi khoa");
                return;
            }

            NhanVien nv = db.NhanViens.Find(txtMaNV.Text);
            nv.TenNhanVien = txtTenNV.Text;
            nv.GioiTinh = txtGioiTinh.Text;
            nv.NgaySinh = dateNgaySinh.Value;
            nv.MaKhoa = cbKhoa.SelectedValue.ToString();
            
            db.SaveChanges();

            if(db.SaveChanges() == 0)
            {
                MessageBox.Show("Thay đổi thông tin nhân viên thành công");
                showdata();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var manv = txtMaNV.Text;
            var makhoa = cbKhoa.SelectedValue.ToString();

            var kttruongkhoa = from k in db.Khoas
                               from n in db.NhanViens
                               where k.MaKhoa == n.MaKhoa && k.TruongKhoa == manv
                               select n;
            var ktdoikhoa = from n in db.NhanViens
                            where n.MaNV == manv && n.MaKhoa != makhoa
                            select n;


            if (kttruongkhoa.Count() != 0 && kttruongkhoa.Count() != 0)
            {
                MessageBox.Show("Người này là trường khoa, không được XÓA");
                return;
            }

            NhanVien nv = db.NhanViens.Find(txtMaNV.Text);
            nv.TonTai = 0;

            db.SaveChanges();

            if (db.SaveChanges() == 0)
            {
                MessageBox.Show("Xóa thông tin nhân viên thành công");
                showdata();
            }
        }
    }
}
