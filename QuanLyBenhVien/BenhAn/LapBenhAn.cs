using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhVien.BenhAn
{
    public partial class LapBenhAn : Form
    {
        qlbenhvienEntities db = new qlbenhvienEntities();
        string mapk;
        public LapBenhAn()
        {
            InitializeComponent();

        }

        public LapBenhAn(string mapkchuyen) : this()
        {
            mapk = mapkchuyen;
            ShowData(mapk);
        }


        void ShowData(string mapk)
        {
            PhieuKhamBenh pk = db.PhieuKhamBenhs.Find(mapk);
            BenhNhan bn = db.BenhNhans.Find(pk.MaBenhNhan);
            txtMaPK.Text = mapk;
            txtMaBN.Text = pk.MaBenhNhan;
            txtTenBN.Text = bn.TenBenhNhan;
            txtCMND.Text = bn.CMND;
            var khoa = from c in db.Khoas
                       where c.TonTai == 1
                       select c;
            cbbKhoa.DataSource = khoa.ToList();
            cbbKhoa.DisplayMember = "TenKhoa";
            cbbKhoa.ValueMember = "MaKhoa";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string mabn = txtMaBN.Text;

            var checkbenhan = from c in db.HoSoBenhAns
                              from d in db.PhieuNhapViens
                              where (c.MaBN == mabn &&
                              c.MaBN == d.MaBN && (d.TinhTrang == "Chờ duyệt" || d.TinhTrang == "Đang điều trị"))
                              select new { c.MaBN, c.MaHoSoBenhAn, d.MaGiuong };
            if (checkbenhan.Count() != 0)
            {
                MessageBox.Show("Bệnh nhân này chưa xuất viện.");
                return;
            }
            if (rtxtBenhAn.Text == "")
            {
                MessageBox.Show("Bệnh án không được để trống.");
                return;
            }
            var benhan = from c in db.HoSoBenhAns select c;
            int id = benhan.Count() + 1;

            HoSoBenhAn ba = new HoSoBenhAn()
            {
                MaHoSoBenhAn = "BA" + id,
                MaBN = txtMaBN.Text,
                Benh = rtxtBenhAn.Rtf,
                MaPK = mapk
            };
            db.HoSoBenhAns.Add(ba);

            string makhoa = cbbKhoa.SelectedValue.ToString();
            var giuong = from c in db.GiuongBenhs
                         from d in db.BuonBenhs
                         where (c.MaBuong == d.MaBuong && d.MaKhoa == makhoa && c.TrangThai == "Trống")
                         select new { d.MaKhoa, d.MaBuong, c.MaGiuong, c.TrangThai };
            foreach (var a in giuong)
            {
                var phieunv = from c in db.PhieuNhapViens select c;
                int id_p = phieunv.Count() + 1;

                PhieuNhapVien pnv = new PhieuNhapVien()
                {
                    MaPhieuNhapVien = "PN" + id_p,
                    NgayNhapVien = DateTime.Now.Date,
                    MaKhoa = cbbKhoa.SelectedValue.ToString(),
                    MaGiuong = a.MaGiuong,
                    MaBN = txtMaBN.Text,
                    TinhTrang = "Chờ duyệt"
                };

                db.PhieuNhapViens.Add(pnv);

                GiuongBenh gb = db.GiuongBenhs.Find(a.MaGiuong);
                gb.TrangThai = "Có bệnh nhân";

                break;
            }

            PhieuKhamBenh pkb = db.PhieuKhamBenhs.Find(mapk);
            pkb.TrangThai = "Đã khám xong";

            db.SaveChanges();

            if (db.SaveChanges() == 0)
            {
                MessageBox.Show("Thêm hồ sơ bệnh án thành công.");
            }
        }
    }
}
