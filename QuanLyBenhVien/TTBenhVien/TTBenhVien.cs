using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhVien.TTBenhVien
{
    public partial class TTBenhVien : Form
    {
        qlbenhvienEntities db = new qlbenhvienEntities();
        BindingSource listbv = new BindingSource();
        public TTBenhVien()
        {
            InitializeComponent();
            ShowDL();
            
        }
        void ShowDL()
        {
            var result = from c in db.BenhViens
                         where c.MaBenhVien=="BV1"
                         select c;

                foreach(var i in result)
            {
                txtMaBV.Text = i.MaBenhVien.ToString();
                txtTenBV.Text = i.TenBenhVien.ToString();
                txtDiachi.Text = i.DiaChi.ToString();
                txtSDT.Text = i.SDT.ToString();
                
            }
        }
        

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(txtMaBV.Text == "")
            {
                MessageBox.Show("Mời chọn bệnh viện để sửa thông tin!");
                return;
            }
            BenhVien bv = db.BenhViens.Find(txtMaBV.Text);
            bv.TenBenhVien = txtTenBV.Text;
            bv.DiaChi = txtDiachi.Text;
            bv.SDT = txtSDT.Text;

            db.SaveChanges();
            if(db.SaveChanges() == 0)
            {
                ShowDL();
                MessageBox.Show("Sửa thành công!");
            }    
        }
        
    }
}
