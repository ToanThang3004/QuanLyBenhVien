using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhVien.TraCuuDoanhThu
{
    public partial class TraCuuDoanhThu : Form
    {
        qlbenhvienEntities db = new qlbenhvienEntities();

        public TraCuuDoanhThu()
        {
            InitializeComponent();
            
        }
        
        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            DateTime ngtc = dateTraCuu.Value;

            var tienthuoc = from pk in db.PhieuKhamBenhs
                            from dt in db.DonThuocs
                            where pk.MaPhieuKham == dt.MaPhieuKham
                            && pk.NgayKham == ngtc.Date
                            select dt;

            var tiendv = from pk in db.PhieuKhamBenhs
                         from pdv in db.PhieuDichVus
                         where pk.MaPhieuDichVu == pdv.MaPhieuDichVu
                         && pk.NgayKham == ngtc.Date
                         select pdv;

            var tienpk = from pk in db.PhieuKhamBenhs
                         where pk.NgayKham == ngtc.Date
                         select pk;

            float tongtienkham = 0;
            float tongtiendv = 0;
            float tongtienthuoc = 0;
            
            if(tienpk.Count() == 0)
            {
                txtDV.Text = tongtiendv.ToString();
                txtDT.Text = tongtienthuoc.ToString();
                txtKB.Text = tongtienkham.ToString();
                txtTong.Text = (tongtiendv + tongtienkham + tongtienthuoc).ToString();
                dateDoanhThu.Value = ngtc.Date;
            }
            if(tiendv.Count() == 0)
            {
                tongtiendv = 0;
            }
            if(tienthuoc.Count() == 0)
            {
                tongtienthuoc = 0;
            }
           // co kham thuoc dv
            if(tienpk.Count() != 0 && tiendv.Count() != 0 && tienthuoc.Count() != 0)
            {
                foreach(var i in tienpk)
                {
                    tongtienkham = tongtienkham + float.Parse(i.TienKham.ToString());
                }
                foreach (var d in tiendv)
                {
                    tongtiendv = tongtiendv + float.Parse(d.TongChiPhiDichVu.ToString());
                }
                foreach (var t in tienthuoc)
                {
                    tongtienthuoc = tongtienthuoc + float.Parse(t.TongChiPhi.ToString());
                }
            }
            //co kham khong dv co thuoc
            if(tienpk.Count() != 0 && tiendv.Count() == 0 && tienthuoc.Count() != 0)
            {
                foreach (var i in tienpk)
                {
                    tongtienkham = tongtienkham + float.Parse(i.TienKham.ToString());
                }
                foreach (var t in tienthuoc)
                {
                    tongtienthuoc = tongtienthuoc + float.Parse(t.TongChiPhi.ToString());
                }
            }
            //co kham co dv khong thuoc
            if(tienpk.Count() != 0 && tienthuoc.Count() == 0 && tiendv.Count() != 0)
            {
                foreach (var i in tienpk)
                {
                    tongtienkham = tongtienkham + float.Parse(i.TienKham.ToString());
                }
                foreach (var d in tiendv)
                {
                    tongtiendv = tongtiendv + float.Parse(d.TongChiPhiDichVu.ToString());
                }
            }
            //co kham khong dv khong thuoc
            if(tienpk.Count() != 0 && tiendv.Count() == 0 && tienthuoc.Count() == 0)
            {
                foreach (var i in tienpk)
                {
                    tongtienkham = tongtienkham + float.Parse(i.TienKham.ToString());
                }
            }

            txtDV.Text = tongtiendv.ToString();
            txtDT.Text = tongtienthuoc.ToString();
            txtKB.Text = tongtienkham.ToString();
            txtTong.Text = (tongtiendv + tongtienkham + tongtienthuoc).ToString();
            dateDoanhThu.Value = ngtc.Date;
           


        }
       

    }
}
