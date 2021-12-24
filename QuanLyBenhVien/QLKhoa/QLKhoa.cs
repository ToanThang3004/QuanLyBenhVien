using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhVien.QLKhoa
{
    public partial class QLKhoa : Form
    {
        qlbenhvienEntities db = new qlbenhvienEntities();
        BindingSource listKhoa = new BindingSource();

        public QLKhoa()
        {
            InitializeComponent();
            dgvDSKhoa.DataSource = listKhoa;
            showdata();
            databinding();
        }

        void showdata()
        {
            var result = from i in db.Khoas
                         where i.TonTai == 1
                         select new { i.MaKhoa, i.TenKhoa, i.TruongKhoa};

            listKhoa.DataSource = result.ToList();
            
        }

        void databinding()
        {
            txtMaKhoa.DataBindings.Add(new Binding("Text", dgvDSKhoa.DataSource, "MaKhoa", false, DataSourceUpdateMode.Never));
            txtTenKhoa.DataBindings.Add(new Binding("Text", dgvDSKhoa.DataSource, "TenKhoa", false, DataSourceUpdateMode.Never));
            
        }
        

        private void txtMaKhoa_TextChanged(object sender, EventArgs e)
        {
            var makhoa = txtMaKhoa.Text;

            var trkh = from k in db.Khoas
                       from nv in db.NhanViens
                       where k.MaKhoa == nv.MaKhoa && k.MaKhoa == makhoa
                       select nv;
            if (trkh.Count() == 0)
            {
                cbTruongKhoa.DataSource = null;
                return;
            }
            cbTruongKhoa.DataSource = trkh.ToList();
            cbTruongKhoa.DisplayMember = "TenNhanVien";
            cbTruongKhoa.ValueMember = "MaNV";

            if(trkh.Count() == 0)
            {
                cbTruongKhoa.Text = null;
                return;
            }

            foreach (var i in trkh)
            {
                cbTruongKhoa.Text = i.TenNhanVien;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var khoa = from i in db.Khoas select i;

            var tenkhoa = txtTenKhoa.Text;

            var ktkhoa = from i in db.Khoas
                         where i.TenKhoa == tenkhoa
                         select i;
            if (ktkhoa.Count() != 0)
            {
                MessageBox.Show("Tên khoa bị trùng, vui lòng nhập tên khác");
                return;
            }

            Khoa kh = new Khoa();
            kh.MaKhoa = "KH" + (khoa.Count() + 1);
            kh.TenKhoa = txtTenKhoa.Text;
            kh.TruongKhoa = "";
            kh.TonTai = 1;
            kh.SLNV = 0;

            db.Khoas.Add(kh);
            db.SaveChanges();

            if (db.SaveChanges() == 0)
            {
                MessageBox.Show("Thêm khoa thành công");
                showdata();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            

            string truongkhoa;
            if (cbTruongKhoa.SelectedValue == null)
            {
                truongkhoa = null;
            } else
            {
                truongkhoa = cbTruongKhoa.SelectedValue.ToString();
            }
            var tenkhoa1 = txtTenKhoa.Text;
            var ktkhoa = from i in db.Khoas
                         where i.TenKhoa == tenkhoa1 && i.TruongKhoa == truongkhoa
                         select i;
            if (ktkhoa.Count() != 0)
            {
                MessageBox.Show("Tên khoa bị trùng, vui lòng nhập tên khác");
                return;
            }

            var tenkhoa = txtTenKhoa.Text;

            var ktten = from i in db.Khoas
                        where i.TenKhoa == tenkhoa
                        select i;

            var kttruongkhoa = from i in db.Khoas
                               where i.TruongKhoa == truongkhoa && i.TenKhoa == tenkhoa
                               select i;

            if (ktten.Count() != 0)
            {
                if (kttruongkhoa.Count() != 0)
                {
                    MessageBox.Show("Tên khoa bị trùng, mời nhập lại");
                    return;
                }

            }

            Khoa kh = db.Khoas.Find(txtMaKhoa.Text);
            kh.TenKhoa = txtTenKhoa.Text;
            if (cbTruongKhoa.SelectedValue == null)
            {
                kh.TruongKhoa = null;
            } else
            {
                kh.TruongKhoa = cbTruongKhoa.SelectedValue.ToString();
            }

            db.SaveChanges();
            if (db.SaveChanges() == 0)
            {
                MessageBox.Show("Thay đổi thành công");
                showdata();
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKhoa.Text == "")
            {
                MessageBox.Show("Có lỗi xảy ra.");
                return;
            }
            var makhoa = txtMaKhoa.Text;
            Khoa kh = db.Khoas.Find(makhoa);
            kh.TonTai = 0;

            db.SaveChanges();

            if (db.SaveChanges() == 0)
            {
                MessageBox.Show("Xóa thành công");
                showdata();
            }
        }
    }
}
