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
    public partial class d1 : Form
    {
        qlbenhvienEntities db = new qlbenhvienEntities();
        BindingSource listDichVu = new BindingSource();
        public d1()
        {
            InitializeComponent();
            dgvDSDV.DataSource = listDichVu;
            ShowDS();
            AddDindding();
            ResetForm();
            
        }
        void ShowDS()
        {
            var result = from c in db.DichVus where c.An == 1 select c;
            listDichVu.DataSource = result.ToList();
        }
        void AddDindding()
        {

            txtMaDV.DataBindings.Add(new Binding("Text", dgvDSDV.DataSource, "MaDichVu", false, DataSourceUpdateMode.Never));
            txtTenDV.DataBindings.Add(new Binding("Text", dgvDSDV.DataSource, "TenDichVu", false, DataSourceUpdateMode.Never));
            txtGiaDV.DataBindings.Add(new Binding("Text", dgvDSDV.DataSource, "GiaDichVu", false, DataSourceUpdateMode.Never));
        }
        void ResetForm()
        {
            txtMaDV.Text = "";
            txtTenDV.Text = "";
            txtGiaDV.Text = "";
            txtMaDVV.Text = "";
            txtTenDVV.Text = "";



        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }








    private void txtGiaDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string madv = txtMaDVV.Text;
            string tendv = txtTenDVV.Text;
            var result = from c in db.DichVus where ((c.MaDichVu == madv || c.TenDichVu == tendv) && c.An==1) select c;
            if (result.Count() == 0)
            {
                ResetForm();
                MessageBox.Show("Không tìm thấy dịch vụ!");

            }
            else
            {
                listDichVu.DataSource = result.ToList();
            }    
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtTenDV.Text == "" || txtGiaDV.Text == "")
            {
                MessageBox.Show("Thêm không thành công, chưa nhập đầy đủ thông tin");
                return;
            }

            int id = 0;
            string tendv = txtTenDV.Text;
            var kq = from c in db.DichVus select c;
            var result1 = from c in db.DichVus where c.TenDichVu == tendv select c;
            if (result1.Count() != 0)
            {
                ResetForm();
                MessageBox.Show("Tên dịch vụ đã tồn tại!");
                return;
            }
            foreach (var i in kq)
            {
                id = id + 1;
            }
            DichVu dv = new DichVu()
            {
                MaDichVu = "DV" + (id + 1),
                TenDichVu = txtTenDV.Text,
                GiaDichVu = float.Parse(txtGiaDV.Text),
                An = 1
                
            };
            db.DichVus.Add(dv);
            db.SaveChanges();
            if (db.SaveChanges() == 0)
            {
                ResetForm();
                ShowDS();
                MessageBox.Show("Thêm dịch vụ mới thành công!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DichVu dv = db.DichVus.Find(txtMaDV.Text);
            dv.An = 0;
            db.SaveChanges();
            if (db.SaveChanges() == 0)
            {

                ShowDS();
                MessageBox.Show("Xóa Dịch Vụ Thành Công!");
            }


        }
    }
}
