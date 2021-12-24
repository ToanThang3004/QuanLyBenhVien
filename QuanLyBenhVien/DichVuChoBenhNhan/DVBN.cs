using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhVien
{
    public partial class DVBN : Form
    {
        string mapk;
        qlbenhvienEntities db = new qlbenhvienEntities();
        BindingSource listPhieuDichVu = new BindingSource();
        BindingSource listDichVu = new BindingSource();
        void LoadCbxDV()
        {
            var dv = from c in db.DichVus
                     where c.An == 1
                     select c;
            cbxPDV.DataSource = dv.ToList();
            cbxPDV.DisplayMember = "TenDichVu";
            cbxPDV.ValueMember = "MaDichVu";
        }
        
        
        void ShowDS(string maPhieuKham)
        {
            maPhieuKham = "1";
            var result = from c in db.PhieuDichVus select c; 
        }
        public DVBN()
        {
            InitializeComponent();
            //LoadCbxDV();
           
            //ShowDataBN();
        }
        
        public DVBN(string mess): this()
        {
            mapk = mess;
            LoadCbxDV();

            ShowDataBN();
        }

        void TinhTongCP()
        {
            float tien = 0;
            float tongtien = 0;
            for (int i = 0;i<dgvDV.Rows.Count-1;i++)
            {
                tien = float.Parse(dgvDV[2, i].Value.ToString());
                tongtien = tongtien + tien;

            }
            txtTongTien.Text = tongtien.ToString();
        }
        void ShowDataBN()
        {
            PhieuKhamBenh pkb = db.PhieuKhamBenhs.Find(mapk);

            if (pkb == null)
            {
                MessageBox.Show("Chưa có bệnh nhân ");
                return;
            }

            BenhNhan bn = db.BenhNhans.Find(pkb.MaBenhNhan);
            NhanVien nv = db.NhanViens.Find(pkb.MaNV);
            txtMaPK.Text = pkb.MaPhieuKham;
            txtMaBN.Text = pkb.MaBenhNhan;
            txtTenBN.Text = bn.TenBenhNhan;
            txtCMND.Text = bn.CMND;
            txtMaNV.Text = pkb.MaNV;
            txtTenNV.Text = nv.TenNhanVien;
            txtNgayKham.Text = pkb.NgayKham.ToString();
        }

        private void DVBN_Load(object sender, EventArgs e)
        {

        }

       

        

        private void txtThemDV_Click(object sender, EventArgs e)
        {
            dgvDV.ColumnCount = 3;

            dgvDV.Columns[0].Name = "Mã Dịch Vụ";
            dgvDV.Columns[1].Name = "Tên Dịch Vụ";
            dgvDV.Columns[2].Name = "Giá Dịch Vụ";


            DichVu dv = db.DichVus.Find(cbxPDV.SelectedValue.ToString());
            string[] row1 = new string[] {cbxPDV.SelectedValue.ToString(),cbxPDV.Text,dv.GiaDichVu.ToString() };
            dgvDV.Rows.Add(row1);

            
        }

        private void dgvDV_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            TinhTongCP();
        }

        private void dgvDV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            TinhTongCP();
        }

        private void dgvDV_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            TinhTongCP();
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {

            if (dgvDV.ColumnCount == 0)
            {
                MessageBox.Show("Chưa chỉ định dịch vụ cho bệnh nhân");
                return;
            }
            

            var result = from c in db.PhieuDichVus select c;
            int sodv = result.Count() + 1;
            PhieuDichVu pdv = new PhieuDichVu()
            {
                MaPhieuDichVu = "DV" + sodv,
                TongChiPhiDichVu = float.Parse(txtTongTien.Text),

            };

            PhieuKhamBenh pk = db.PhieuKhamBenhs.Find(mapk);
            pk.MaPhieuDichVu = "DV" + sodv;

            db.PhieuDichVus.Add(pdv);
            
                for (int i = 0; i < dgvDV.RowCount - 1;  i++)
                {
                
                    var result1 = from c in db.ChiTietPhieuDichVus select c;
                    ChiTietPhieuDichVu ctdv = new ChiTietPhieuDichVu()
                    {

                        MaChiTietDichVu = "CTDV" + (result1.Count() + 1),
                        TenDichVu = dgvDV[1, i].Value.ToString(),
                        GiaDichVu = float.Parse(dgvDV[2, i].Value.ToString()),
                        MaPhieuDichVu = "DV" + sodv,
                        MaDichVu = dgvDV[0, i].Value.ToString()

                    };
                    db.ChiTietPhieuDichVus.Add(ctdv);
                    db.SaveChanges();
                }

            

            db.SaveChanges();

            if(db.SaveChanges() == 0)
            {
                MessageBox.Show("Thêm dịch vụ thành công!");
                this.Close();
            }
                
        }

        private void cbxPDV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
