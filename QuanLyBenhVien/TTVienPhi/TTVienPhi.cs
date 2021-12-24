using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhVien.TTVienPhi
{
    public partial class TTVienPhi : Form
    {
        qlbenhvienEntities db = new qlbenhvienEntities();
        BindingSource bsVP = new BindingSource();

        public TTVienPhi()
        {
            InitializeComponent();
            ShowDSVP();
            Bindings();
        }

        void ShowDSVP()
        {
            var result = from c in db.VienPhis
                         from d in db.BenhNhans
                         where (c.MaBenhNhan == d.MaBenhNhan)
                         select new
                         {
                             c.MaVienPhi,
                             c.MaPK,
                             c.MaBenhNhan,
                             d.TenBenhNhan,
                             c.NgayLap,
                             c.TinhTrang,
                             c.TongTien
                         };
            bsVP.DataSource = result.ToList();
            dgvVienPhi.DataSource = bsVP;
        }

        void Bindings()
        {
            txtMaVienPhi.DataBindings.Add("Text", dgvVienPhi.DataSource, "MaVienPhi", false, DataSourceUpdateMode.Never);
        }

        void ResetForm()
        {
            txtMaVienPhi.Text = string.Empty;
            txtTinhTrang.Text = string.Empty;
            txtMaBN.Text = string.Empty;
            txtTenBn.Text = string.Empty;
            txtTienKham.Text = string.Empty;
            txtTienDichvu.Text = string.Empty;
            txtTienThuoc.Text = string.Empty;
            txtTongVienPhi.Text = string.Empty;
            txtNgayLap.Text = string.Empty;
            txtMaPK.Text = string.Empty;
        }

        private void btnThemVienPhi_Click(object sender, EventArgs e)
        {
            string mapk = txtMaPK.Text;
            var check = from c in db.VienPhis where c.MaPK == mapk select c;
            if (check.Count() != 0)
            {
                MessageBox.Show("Phiếu khám này đã có thông tin viện phí.");
                return;
            }
            string mavp = txtMaVienPhi.Text;
            VienPhi checkvp = db.VienPhis.Find(mavp);
            if (checkvp != null)
            {
                MessageBox.Show("Thông tin viện phí này đã tồn tại.");
                return;
            }
            if (txtMaPK.Text == "")
            {
                MessageBox.Show("Có lỗi xảy ra.");
                return;
            }
            var result = from c in db.VienPhis select c;
            int id = result.Count() + 1;

            VienPhi vp = new VienPhi()
            {
                MaVienPhi = "VP" + id,
                MaBenhNhan = txtMaBN.Text,
                TienKham = float.Parse(txtTienKham.Text),
                TienDichVu = float.Parse(txtTienDichvu.Text),
                TienThuoc = float.Parse(txtTienThuoc.Text),
                TongTien = float.Parse(txtTongVienPhi.Text),
                TinhTrang = "Chưa thanh toán",
                NgayLap = DateTime.Now,
                MaPK = txtMaPK.Text
            };
            db.VienPhis.Add(vp);

            db.SaveChanges();
            if (db.SaveChanges() == 0)
            {
                MessageBox.Show("Thêm thông tin viện phí thành công");
                ResetForm();
                ShowDSVP();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string mavp = txtMaVienPhi.Text;
            VienPhi vp = db.VienPhis.Find(mavp);
            if (vp == null)
            {
                MessageBox.Show("Thông tin viện phí này không tồn tại.");
                return;
            }
            if (vp.TinhTrang == "Đã thanh toán")
            {
                MessageBox.Show("Thông tin viện phí này đã được thanh toán.");
                return;
            }

            vp.TinhTrang = "Đã thanh toán";
            vp.NgayThanhToan = DateTime.Now;
            db.SaveChanges();

            MessageBox.Show("Thanh toán thành công.");
            ShowDSVP();
        }

        private void txtMaVienPhi_TextChanged(object sender, EventArgs e)
        {
            if (txtMaVienPhi.Text != "")
            {
                string mavp = txtMaVienPhi.Text;
                VienPhi vp = db.VienPhis.Find(mavp);
                BenhNhan bn = db.BenhNhans.Find(vp.MaBenhNhan);
                txtTinhTrang.Text = vp.TinhTrang;
                txtMaBN.Text = vp.MaBenhNhan;
                txtTenBn.Text = bn.TenBenhNhan;
                txtTienKham.Text = vp.TienKham.ToString();
                txtTienDichvu.Text = vp.TienDichVu.ToString();
                txtTienThuoc.Text = vp.TienThuoc.ToString();
                txtTongVienPhi.Text = vp.TongTien.ToString();
                txtNgayLap.Text = String.Format("{0:d/M/yyyy}", vp.NgayLap);
                txtMaPK.Text = vp.MaPK;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tenbn = txtSearchTBN.Text;
            var result = from c in db.VienPhis
                         from d in db.BenhNhans
                         where (c.MaBenhNhan == d.MaBenhNhan && d.TenBenhNhan.Contains(tenbn))
                         select new
                         {
                             c.MaVienPhi,
                             c.MaPK,
                             c.MaBenhNhan,
                             d.TenBenhNhan,
                             c.NgayLap,
                             c.TinhTrang,
                             c.TongTien
                         };
            if (result.Count() == 0)
            {
                MessageBox.Show("Không tìm kiếm được viện phí này.");
                return;
            }
            bsVP.DataSource = result.ToList();
        }

        private void txtMaPK_KeyPress(object sender, KeyPressEventArgs e)
        {
      
        }

        private void txtMaPK_TextChanged(object sender, EventArgs e)
        {
            PhieuKhamBenh pk = db.PhieuKhamBenhs.Find(txtMaPK.Text);
            if (pk == null)
            {

                return;
            }
            else
            {
                txtMaBN.Text = pk.MaBenhNhan;
                BenhNhan bn = db.BenhNhans.Find(pk.MaBenhNhan);
                txtTenBn.Text = bn.TenBenhNhan;
                double tienkham = 0;
                if (pk.TienKham == null)
                {
                    txtTienKham.Text = "0";
                    tienkham = 0;
                } else
                {
                    txtTienKham.Text = pk.TienKham.ToString();
                    tienkham = double.Parse(pk.TienKham.ToString());
                }

                PhieuDichVu pdv = db.PhieuDichVus.Find(pk.MaPhieuDichVu);
                double tiendv;
                if (pdv == null)
                {
                    txtTienDichvu.Text = "0";
                    tiendv = 0;
                    
                } else
                {
                    txtTienDichvu.Text = pdv.TongChiPhiDichVu.ToString();
                    tiendv = double.Parse(pdv.TongChiPhiDichVu.ToString());
                }
                var result = from c in db.DonThuocs where c.MaPhieuKham == pk.MaPhieuKham select c;
                double tienthuoc = 0;
                if (result.Count() == 0)
                {
                    tienthuoc = 0;
                    txtTienThuoc.Text = "0";
                } else
                {
                    foreach (var i in result)
                    {
                        tienthuoc = double.Parse(i.TongChiPhi.ToString());
                        txtTienThuoc.Text = i.TongChiPhi.ToString();
                    }
                }       
                double tong = (tienkham + tienthuoc + tiendv);
                txtTongVienPhi.Text = tong.ToString();
            }
        }
    }
}
