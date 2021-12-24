using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhVien.phieukham
{
    public partial class PhieuKham : Form
    {
        qlbenhvienEntities db = new qlbenhvienEntities();
        BindingSource listphieukham = new BindingSource();

        public PhieuKham()
        {
            InitializeComponent();
            dgvDSPhieuKham.DataSource = listphieukham;
            show();
            binding();
            customdgv();
        }
        
        void show()
        {
            var result = from c in db.PhieuKhamBenhs
                         select c;

            listphieukham.DataSource = result.ToList();
            
        }
        void binding()
        {
            txtMaBenhNhan.DataBindings.Add(new Binding("Text", dgvDSPhieuKham.DataSource, "MaBenhNhan", false, DataSourceUpdateMode.Never));
            txtMaNhanVien.DataBindings.Add(new Binding("Text", dgvDSPhieuKham.DataSource, "MaNV", false, DataSourceUpdateMode.Never));
            dateNgayKham.DataBindings.Add(new Binding("Text", dgvDSPhieuKham.DataSource, "NgayKham", false, DataSourceUpdateMode.Never));
            txtMaPK.DataBindings.Add(new Binding("Text", dgvDSPhieuKham.DataSource, "MaPhieuKham", false, DataSourceUpdateMode.Never));
            txtTrieuChung.DataBindings.Add(new Binding("Text", dgvDSPhieuKham.DataSource, "TrieuChung", false, DataSourceUpdateMode.Never));
            rtextChuanDoan.DataBindings.Add(new Binding("Text", dgvDSPhieuKham.DataSource, "ChuanDoan", false, DataSourceUpdateMode.Never));
            txtTrangThai.DataBindings.Add(new Binding("Text", dgvDSPhieuKham.DataSource, "TrangThai", false, DataSourceUpdateMode.Never));
            clickdgv();
        }

        void clickdgv()
        {
            if(dgvDSPhieuKham.RowCount == 0)
            {
                return;
            }

            int rowdgv = this.dgvDSPhieuKham.CurrentCell.RowIndex;

            string mabn = dgvDSPhieuKham.Rows[rowdgv].Cells[3].Value.ToString();
            string maNV = dgvDSPhieuKham.Rows[rowdgv].Cells[1].Value.ToString();

            var result = from c in db.BenhNhans
                         where (c.MaBenhNhan == mabn)
                         select c;

            foreach (var i in result)
            {
                txtTenBenhNhan.Text = i.TenBenhNhan;
                txtCMND.Text = i.CMND;
                txtGioiTinh.Text = i.GioiTinh;
                txtDanToc.Text = i.DanToc;
                txtDiaChi.Text = i.DiaChi;
                dateNgaySinh.Value = i.NgaySinh.Value;

            }

            var resultnv = from c in db.NhanViens
                           where (c.MaNV == maNV)
                           select c;

            foreach (var i in resultnv)
            {
                txtTenNhanVien.Text = i.TenNhanVien;
            }
        }

        void customdgv()
        {
            dgvDSPhieuKham.MultiSelect = false;
            dgvDSPhieuKham.AllowUserToAddRows = false;
            dgvDSPhieuKham.AllowUserToDeleteRows = false;
            dgvDSPhieuKham.AllowUserToOrderColumns = false;
            dgvDSPhieuKham.AllowUserToResizeRows = true;

        }

        private void dgvDSPhieuKham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clickdgv();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string mapk = txtMaPKTimKiem.Text;
            string ten = txtTenTimKiem.Text;
            DateTime date = dateNgayTimKiem.Value;
            
            var result = from p in db.PhieuKhamBenhs
                         from b in db.BenhNhans
                         where (p.MaBenhNhan == b.MaBenhNhan && (p.MaPhieuKham == mapk || b.TenBenhNhan == ten || p.NgayKham == date.Date))
                         select p;
            listphieukham.DataSource = result.ToList();
        }

        void them()
        {
            var cmnd = txtCMND.Text;
            var benhnhan = from i in db.BenhNhans
                           where i.CMND == cmnd
                           select i;

            var countphieukham = from i in db.PhieuKhamBenhs
                                 select i;

            if(benhnhan.Count() != 0)
            {
                foreach(var i in benhnhan)
                {
                    

                    PhieuKhamBenh pk = new PhieuKhamBenh();
                    pk.MaPhieuKham = "PK" + (countphieukham.Count() + 1);
                    pk.MaNV = txtMaNhanVien.Text;
                    pk.MaPhieuDichVu = "";
                    pk.MaBenhNhan = i.MaBenhNhan;
                    pk.NgayKham = DateTime.Now.Date;
                    pk.TienKham = 150000;
                    pk.TrangThai = "Đang khám";
                    pk.TrieuChung = txtTrieuChung.Text;
                    pk.ChuanDoan = rtextChuanDoan.Text;

                    db.PhieuKhamBenhs.Add(pk);

                    break;
                }
            }
            else
            {

                PhieuKhamBenh pk = new PhieuKhamBenh();
                pk.MaPhieuKham = "PK" + (countphieukham.Count() + 1);
                pk.MaBenhNhan = txtMaBenhNhan.Text;
                pk.MaNV = txtMaNhanVien.Text;
                pk.MaPhieuDichVu = "";
                pk.NgayKham = DateTime.Now.Date;
                pk.TrangThai = "Đang khám";
                pk.TrieuChung = txtTrieuChung.Text;
                pk.ChuanDoan = rtextChuanDoan.Text;
                pk.TienKham = 150000;

                db.PhieuKhamBenhs.Add(pk);
            }

            db.SaveChanges();

            if (db.SaveChanges() == 0)
            {
                MessageBox.Show("Thêm phiếu khám thành công");
                show();
            }
            else
            {
                MessageBox.Show("Thêm phiếu khám thất bại");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them();
        }

        private void btnChiDinhDichVu_Click(object sender, EventArgs e)
        {
            var mapk = txtMaPK.Text;
            var pk = from i in db.PhieuKhamBenhs
                     where i.MaPhieuKham == mapk
                     select i;

            var ktpk = from pk1 in db.PhieuKhamBenhs
                       from pdv in db.PhieuDichVus
                       where pk1.MaPhieuDichVu == pdv.MaPhieuDichVu && pk1.MaPhieuKham == mapk
                       select pdv;

            foreach(var i in pk)
            {
                if (i.TrangThai == "Đã khám xong")
                {
                    MessageBox.Show("Bệnh nhân không còn khám nữa, vui lòng chọn người khác");
                    return;
                }
                if (ktpk.Count() != 0)
                {
                    MessageBox.Show("Bệnh nhân đã được kê dịch vụ, chọn bệnh nhân khác");
                    return;
                }
                if(i.TrangThai == "Đang khám")
                {
                    DVBN a = new DVBN(txtMaPK.Text);
                    a.Show();
                }
            }

            

        }

        private void btnKeDonThuoc_Click(object sender, EventArgs e)
        {
            var mapk = txtMaPK.Text;
            var kiemtrakedon = from i in db.PhieuKhamBenhs
                               where i.MaPhieuKham == mapk && i.TrangThai == "Đã khám xong"
                               select i;

            if(kiemtrakedon.Count() != 0)
            {
                MessageBox.Show("Phieu kham này đã khám xong, không được tiếp tục kê đơn!!!");
                return;
            }
            

            DThuoc.DThuoc kedon = new DThuoc.DThuoc(txtMaPK.Text);
            kedon.Show();
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            var mapk = txtMaPK.Text;

            PhieuKhamBenh pk = db.PhieuKhamBenhs.Find(mapk);
            pk.TrangThai = "Đã khám xong";

            db.SaveChanges();

            if(db.SaveChanges() == 0)
            {
                MessageBox.Show("Đã hoàn thành việc khám");
                show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var mapk = txtMaPK.Text;
            var pk = from i in db.HoSoBenhAns
                     where i.MaPK == mapk
                     select i;

            if(pk.Count() == 0)
            {
                BenhAn.LapBenhAn benhan = new BenhAn.LapBenhAn(txtMaPK.Text);
                benhan.Show();
            }
            else
            {
                MessageBox.Show("Phiếu khám đã có hồ sơ bệnh án, vui lòng chọn phiếu khác !!!");
                return;
            }

            
        }
    }
}
