using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhVien.QLGiuongBenh
{
    public partial class QLGiuongBenh : Form
    {
        qlbenhvienEntities db = new qlbenhvienEntities();
        BindingSource listgiuong = new BindingSource();
        BindingSource listkhoa = new BindingSource();
        BindingSource listbuong = new BindingSource();

        public QLGiuongBenh()
        {
            InitializeComponent();
            dgvKhoa.DataSource = listkhoa;
            dgvGiuong.DataSource = listgiuong;
            dgvBuong.DataSource = listbuong;

            showdata();
            binding();
        }

        void binding()
        {
            txtmakhoa.DataBindings.Add(new Binding("Text", dgvKhoa.DataSource, "MaKhoa", false, DataSourceUpdateMode.Never));
            txtmabuong.DataBindings.Add(new Binding("Text", dgvBuong.DataSource, "MaBuong", false, DataSourceUpdateMode.Never));
            txtmagiuong.DataBindings.Add(new Binding("Text", dgvGiuong.DataSource, "MaGiuong", false, DataSourceUpdateMode.Never));
            txttinhtrang.DataBindings.Add(new Binding("Text", dgvGiuong.DataSource, "TrangThai", false, DataSourceUpdateMode.Never));
        }

        void showdata()
        {
            var khoa = from i in db.Khoas
                       where i.TonTai == 1
                       select new { i.MaKhoa, i.TenKhoa };

            listkhoa.DataSource = khoa.ToList();

            var buong = from i in db.BuonBenhs
                        select i;
            listbuong.DataSource = buong.ToList();

            var giuong = from i in db.GiuongBenhs
                         select i;
            listgiuong.DataSource = giuong.ToList();
        }
        
        private void dgvBuong_VisibleChanged(object sender, EventArgs e)
        {
            int row = dgvKhoa.CurrentRow.Index;
            var makhoa = dgvKhoa.Rows[row].Cells["MaKhoa"].Value.ToString();

            var buong = from i in db.BuonBenhs
                        where i.MaKhoa == makhoa
                        select i;

            listbuong.DataSource = buong.ToList();
        }

        private void dgvGiuong_VisibleChanged(object sender, EventArgs e)
        {
            int row = dgvBuong.CurrentRow.Index;
            var mabuong = dgvBuong.Rows[row].Cells["MaBuong"].Value.ToString();

            var Giuong = from i in db.GiuongBenhs
                         where i.MaBuong == mabuong
                         select i;

            listgiuong.DataSource = Giuong.ToList();
        }

        private void dgvKhoa_Click(object sender, EventArgs e)
        {
            int row = dgvKhoa.CurrentRow.Index;
            var makhoa = dgvKhoa.Rows[row].Cells["MaKhoa"].Value.ToString();

            var buong = from i in db.BuonBenhs
                        where i.MaKhoa == makhoa
                        select i;

            listbuong.DataSource = buong.ToList();
        }

        private void dgvBuong_Click(object sender, EventArgs e)
        {
            int row = dgvBuong.CurrentRow.Index;
            var mabuong = dgvBuong.Rows[row].Cells["MaBuong"].Value.ToString();

            var Giuong = from i in db.GiuongBenhs
                         where i.MaBuong == mabuong
                         select i;

            listgiuong.DataSource = Giuong.ToList();
        }
        

        private void txtmakhoa_TextChanged(object sender, EventArgs e)
        {
            var makhoa = txtmakhoa.Text;

            var khoa = from i in db.Khoas
                       where i.TonTai == 1
                       select i;

            cbkhoa.DataSource = khoa.ToList();
            cbkhoa.DisplayMember = "TenKhoa";
            cbkhoa.ValueMember = "MaKhoa";

            var khoacuabuong = from i in db.Khoas
                               where i.TonTai == 1 && i.MaKhoa == makhoa
                               select i;
            foreach (var i in khoacuabuong)
            {
                cbkhoa.Text = i.TenKhoa;
            }
        }

        private void btnThemBuong_Click(object sender, EventArgs e)
        {
            var makhoa = txtmakhoa.Text;

            var buong = from i in db.BuonBenhs
                        select i;

            BuonBenh bb = new BuonBenh();
            bb.MaBuong = "B" + (buong.Count() + 1);
            bb.MaKhoa = makhoa;

            db.BuonBenhs.Add(bb);
            db.SaveChanges();

            if (db.SaveChanges() == 0)
            {
                MessageBox.Show("đã thêm thành công buồn");
                showdata();
            }
        }

        private void btnThemGiuong_Click(object sender, EventArgs e)
        {
            var mabuong = txtmabuong.Text;

            var giuong = from i in db.GiuongBenhs
                         select i;

            GiuongBenh gi = new GiuongBenh();
            gi.MaBuong = txtmabuong.Text;
            gi.MaGiuong = "G" + (giuong.Count() + 1);
            gi.TrangThai = "Trống";

            db.GiuongBenhs.Add(gi);
            db.SaveChanges();

            if (db.SaveChanges() == 0)
            {
                MessageBox.Show("đã thêm thành công giường bệnh");
                showdata();
            }

            
        }
    }
}
