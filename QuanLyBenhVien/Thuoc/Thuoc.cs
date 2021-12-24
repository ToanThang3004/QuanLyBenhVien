using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhVien.Thuoc
{
    public partial class Thuoc : Form
    {
        qlbenhvienEntities db = new qlbenhvienEntities();
        BindingSource bsTH = new BindingSource();

        public Thuoc()
        {
            InitializeComponent();
            ShowDanhSach();
            AddBindings();
        }
       
        public void ShowDanhSach()
        {
            var result = from c in db.DSThuocs where c.An == 0 select new { c.MaThuoc, c.TenThuoc, c.Gia };
            bsTH.DataSource = result.ToList();
            dgvDSThuoc.DataSource = bsTH;
        }

        void AddBindings()
        {
            txtMaThuoc.DataBindings.Add("Text", dgvDSThuoc.DataSource, "MaThuoc", false, DataSourceUpdateMode.Never);
            txtTenThuoc.DataBindings.Add("Text", dgvDSThuoc.DataSource, "TenThuoc", false, DataSourceUpdateMode.Never);
            txtGiaThuoc.DataBindings.Add("Text", dgvDSThuoc.DataSource, "Gia", false, DataSourceUpdateMode.Never);
        }

        void ResetForm()
        {
            txtMaThuoc.Text = string.Empty;
            txtTenThuoc.Text = string.Empty;
            txtGiaThuoc.Text = string.Empty;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtTenThuoc.Text == "" || txtGiaThuoc.Text == "")
            {
                MessageBox.Show("Thêm không thành công, chưa nhập đủ thông tin thuốc");
                return;
            }
            var result = from c in db.DSThuocs select c;
            int id = 0;
            foreach (var i in result)
            {
                if (txtTenThuoc.Text == i.TenThuoc.ToString())
                {
                    MessageBox.Show("Tên thuốc đã tồn tại");
                    return;
                }
                id = id + 1;
            }

            DSThuoc th = new DSThuoc()
            {
                MaThuoc = "T" + (id + 1),
                TenThuoc = txtTenThuoc.Text,
                Gia = float.Parse(txtGiaThuoc.Text),
                An = 0
            };

            db.DSThuocs.Add(th);
            db.SaveChanges();

            if (db.SaveChanges() == 0)
            {
                ResetForm();
                ShowDanhSach();
                MessageBox.Show("Thêm thuốc mới thành công");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaThuoc.Text == "")
            {
                MessageBox.Show("Thuốc không tồn tại.");
                return;
            }
            DSThuoc th = db.DSThuocs.Find(txtMaThuoc.Text);
            th.An = 1;
            db.SaveChanges();
            if (db.SaveChanges() == 0)
            {
                ShowDanhSach();
                MessageBox.Show("Xóa thuốc thành công");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtMaThuoc.Text == "")
            {
                MessageBox.Show("Thuốc không tồn tại.");
                return;
            }
            if (txtGiaThuoc.Text == "" || txtTenThuoc.Text == "")
            {
                MessageBox.Show("Có lỗi xảy ra");
                return;
            }
            DSThuoc th = db.DSThuocs.Find(txtMaThuoc.Text);
            th.TenThuoc = txtTenThuoc.Text;
            th.Gia = float.Parse(txtGiaThuoc.Text);
            db.SaveChanges();
            if (db.SaveChanges() == 0)
            {
                ShowDanhSach();
                MessageBox.Show("Cập nhật thuốc thành công");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string MThuoc = txtSearchMT.Text;
            string TThuoc = txtSearchTT.Text;
            var result = from c in db.DSThuocs where (c.MaThuoc == MThuoc || c.TenThuoc == TThuoc)
                         select new { c.MaThuoc, c.TenThuoc, c.Gia };
            if (result.Count() == 0)
            {
                MessageBox.Show("Không tìm thấy thuốc cần tìm");
            }
            else
            {
                bsTH.DataSource = result.ToList();
            }
        }

        private void txtGiaThuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
