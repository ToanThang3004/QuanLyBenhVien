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
    public partial class DThuoc : Form
    {
        qlbenhvienEntities db = new qlbenhvienEntities();
        BindingSource bsDT = new BindingSource();

        string maphieukham;
        public DThuoc()
        {
            InitializeComponent();
            ShowCBBDST();
        }

        public DThuoc(string maphieukhamtruyen) : this()
        {
            maphieukham = maphieukhamtruyen;
            txtMaPK.Text = maphieukham;
        }

        void ShowCBBDST()
        {
            var result = from c in db.DSThuocs where c.An == 0 select c;

            cbbThuoc.DataSource = result.ToList();
            cbbThuoc.DisplayMember = "TenThuoc";
            cbbThuoc.ValueMember = "MaThuoc";
        }

        void ResetForm()
        {
            txtMaDT.Text = string.Empty;
            txtMaPK.Text = string.Empty;
            txtMBN.Text = string.Empty;
            txtTenBN.Text = string.Empty;
            txtTongTien.Text = string.Empty;
            txtSoLuongThuoc.Text = string.Empty;
            txtCachDung.Text = string.Empty;
            txtMaPK.Text = string.Empty;
            dgvThuoc.DataSource = null;
            dgvThuoc.Rows.Clear();
            dgvThuoc.Refresh();
        }

        void TongChiPhi()
        {
            float tong = 0;
            float tien = 0;
            for (int i = 0; i < (dgvThuoc.Rows.Count - 1); i++)
            {
                tien = float.Parse(dgvThuoc[5, i].Value.ToString());
                tong = tong + tien;
            }
            txtTongTien.Text = tong.ToString();
        }

        private void cbbThuoc_SelectedValueChanged(object sender, EventArgs e)
        {
            string MThuoc = cbbThuoc.SelectedValue.ToString();
            var result = from c in db.DSThuocs where c.MaThuoc == MThuoc select new { c.Gia };
            foreach (var i in result)
            {
                txtGiaThuoc.Text = i.Gia.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtSoLuongThuoc.Text == "")
            {
                MessageBox.Show("Chưa nhập số lượng thuốc");
                return;
            }
            dgvThuoc.ColumnCount = 6;

            dgvThuoc.Columns[0].Name = "MaThuoc";
            dgvThuoc.Columns[1].Name = "TenThuoc";
            dgvThuoc.Columns[2].Name = "Gia";
            dgvThuoc.Columns[3].Name = "SoLuong";
            dgvThuoc.Columns[4].Name = "CachDung";
            dgvThuoc.Columns[5].Name = "ThanhTien";

            float gia = float.Parse(txtGiaThuoc.Text);
            int soluong = int.Parse(txtSoLuongThuoc.Text);
            float thanhtien = gia * soluong;

            string[] row1 = new string[] {
                    cbbThuoc.SelectedValue.ToString(),
                    cbbThuoc.Text,
                    txtGiaThuoc.Text,
                    txtSoLuongThuoc.Text,
                    txtCachDung.Text,
                    thanhtien.ToString()
                };
            dgvThuoc.Rows.Add(row1);
        }

        private void dgvThuoc_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            TongChiPhi();
        }

        private void dgvThuoc_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            TongChiPhi();
        }       

        private void dgvThuoc_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            TongChiPhi();
        }

        private void btnThemDT_Click(object sender, EventArgs e)
        {
            var result = from c in db.DonThuocs select c;
            int id = 0;
            foreach (var i in result)
            {
                id = id + 1;
            }

            DonThuoc dt = new DonThuoc()
            {
                MaDonThuoc = "DT" + (id + 1),
                MaPhieuKham = txtMaPK.Text,
                TongChiPhi = float.Parse(txtTongTien.Text)
            };
            db.DonThuocs.Add(dt);
            db.SaveChanges();

            if (db.SaveChanges() == 0)
            {
                for (int i = 0; i < dgvThuoc.Rows.Count - 1; i++)
                {
                    int id_ct = 0;
                    var re = from c in db.ChiTietDonThuocs select c;
                    foreach (var a in re)
                    {
                        id_ct = id_ct + 1;
                    }
                    ChiTietDonThuoc ctdt = new ChiTietDonThuoc()
                    {
                        MaChiTietDonThuoc = "CTDT" + (id_ct + 1),
                        TenThuoc = dgvThuoc[1, i].Value.ToString(),
                        SoLuongThuoc = int.Parse(dgvThuoc[3, i].Value.ToString()),
                        GiaThuoc = float.Parse(dgvThuoc[5, i].Value.ToString()),
                        MaDonThuoc = "DT" + (id + 1),
                        CachDung = dgvThuoc[4, i].Value.ToString(),
                        MaThuoc = dgvThuoc[0, i].Value.ToString()
                    };
                    db.ChiTietDonThuocs.Add(ctdt);
                    db.SaveChanges();
                }
                ResetForm();
                MessageBox.Show("Them don thuoc thanh cong");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
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
                txtMBN.Text = pk.MaBenhNhan;
                BenhNhan bn = db.BenhNhans.Find(pk.MaBenhNhan);
                txtTenBN.Text = bn.TenBenhNhan;
            }
        }
    }
}
