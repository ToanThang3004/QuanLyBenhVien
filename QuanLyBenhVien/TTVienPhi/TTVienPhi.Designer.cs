
namespace QuanLyBenhVien.TTVienPhi
{
    partial class TTVienPhi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvVienPhi = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMaPK = new System.Windows.Forms.TextBox();
            this.t = new System.Windows.Forms.Label();
            this.txtNgayLap = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTongVienPhi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTienThuoc = new System.Windows.Forms.TextBox();
            this.txtTienDichvu = new System.Windows.Forms.TextBox();
            this.btnThemVienPhi = new System.Windows.Forms.Button();
            this.txtTienKham = new System.Windows.Forms.TextBox();
            this.txtTenBn = new System.Windows.Forms.TextBox();
            this.txtMaBN = new System.Windows.Forms.TextBox();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.txtMaVienPhi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSearchTBN = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVienPhi)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvVienPhi);
            this.groupBox2.Location = new System.Drawing.Point(5, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 360);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách thông tin viện phí ";
            // 
            // dgvVienPhi
            // 
            this.dgvVienPhi.AllowUserToAddRows = false;
            this.dgvVienPhi.AllowUserToDeleteRows = false;
            this.dgvVienPhi.AllowUserToResizeColumns = false;
            this.dgvVienPhi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVienPhi.Location = new System.Drawing.Point(7, 19);
            this.dgvVienPhi.Name = "dgvVienPhi";
            this.dgvVienPhi.ReadOnly = true;
            this.dgvVienPhi.RowHeadersVisible = false;
            this.dgvVienPhi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVienPhi.Size = new System.Drawing.Size(422, 335);
            this.dgvVienPhi.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMaPK);
            this.groupBox3.Controls.Add(this.t);
            this.groupBox3.Controls.Add(this.txtNgayLap);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtTongVienPhi);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnThanhToan);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtTienThuoc);
            this.groupBox3.Controls.Add(this.txtTienDichvu);
            this.groupBox3.Controls.Add(this.btnThemVienPhi);
            this.groupBox3.Controls.Add(this.txtTienKham);
            this.groupBox3.Controls.Add(this.txtTenBn);
            this.groupBox3.Controls.Add(this.txtMaBN);
            this.groupBox3.Controls.Add(this.txtTinhTrang);
            this.groupBox3.Controls.Add(this.txtMaVienPhi);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(444, 99);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(351, 360);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin viện phí ";
            // 
            // txtMaPK
            // 
            this.txtMaPK.Location = new System.Drawing.Point(88, 81);
            this.txtMaPK.Name = "txtMaPK";
            this.txtMaPK.Size = new System.Drawing.Size(256, 20);
            this.txtMaPK.TabIndex = 21;
            this.txtMaPK.TextChanged += new System.EventHandler(this.txtMaPK_TextChanged);
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Location = new System.Drawing.Point(6, 84);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(80, 13);
            this.t.TabIndex = 20;
            this.t.Text = "Mã phiếu khám";
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.Location = new System.Drawing.Point(88, 291);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.ReadOnly = true;
            this.txtNgayLap.Size = new System.Drawing.Size(256, 20);
            this.txtNgayLap.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Ngày lập";
            // 
            // txtTongVienPhi
            // 
            this.txtTongVienPhi.Location = new System.Drawing.Point(88, 260);
            this.txtTongVienPhi.Name = "txtTongVienPhi";
            this.txtTongVienPhi.ReadOnly = true;
            this.txtTongVienPhi.Size = new System.Drawing.Size(256, 20);
            this.txtTongVienPhi.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tổng viện phí";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(183, 326);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(90, 23);
            this.btnThanhToan.TabIndex = 15;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tình trạng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mã viện phí";
            // 
            // txtTienThuoc
            // 
            this.txtTienThuoc.Location = new System.Drawing.Point(88, 229);
            this.txtTienThuoc.Name = "txtTienThuoc";
            this.txtTienThuoc.ReadOnly = true;
            this.txtTienThuoc.Size = new System.Drawing.Size(256, 20);
            this.txtTienThuoc.TabIndex = 12;
            // 
            // txtTienDichvu
            // 
            this.txtTienDichvu.Location = new System.Drawing.Point(88, 199);
            this.txtTienDichvu.Name = "txtTienDichvu";
            this.txtTienDichvu.ReadOnly = true;
            this.txtTienDichvu.Size = new System.Drawing.Size(256, 20);
            this.txtTienDichvu.TabIndex = 11;
            // 
            // btnThemVienPhi
            // 
            this.btnThemVienPhi.Location = new System.Drawing.Point(87, 326);
            this.btnThemVienPhi.Name = "btnThemVienPhi";
            this.btnThemVienPhi.Size = new System.Drawing.Size(88, 23);
            this.btnThemVienPhi.TabIndex = 10;
            this.btnThemVienPhi.Text = "Thêm viện phí";
            this.btnThemVienPhi.UseVisualStyleBackColor = true;
            this.btnThemVienPhi.Click += new System.EventHandler(this.btnThemVienPhi_Click);
            // 
            // txtTienKham
            // 
            this.txtTienKham.Location = new System.Drawing.Point(88, 169);
            this.txtTienKham.Name = "txtTienKham";
            this.txtTienKham.ReadOnly = true;
            this.txtTienKham.Size = new System.Drawing.Size(256, 20);
            this.txtTienKham.TabIndex = 9;
            // 
            // txtTenBn
            // 
            this.txtTenBn.Location = new System.Drawing.Point(88, 140);
            this.txtTenBn.Name = "txtTenBn";
            this.txtTenBn.ReadOnly = true;
            this.txtTenBn.Size = new System.Drawing.Size(256, 20);
            this.txtTenBn.TabIndex = 8;
            // 
            // txtMaBN
            // 
            this.txtMaBN.Location = new System.Drawing.Point(88, 111);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.ReadOnly = true;
            this.txtMaBN.Size = new System.Drawing.Size(256, 20);
            this.txtMaBN.TabIndex = 7;
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(88, 51);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.ReadOnly = true;
            this.txtTinhTrang.Size = new System.Drawing.Size(256, 20);
            this.txtTinhTrang.TabIndex = 6;
            // 
            // txtMaVienPhi
            // 
            this.txtMaVienPhi.Location = new System.Drawing.Point(88, 22);
            this.txtMaVienPhi.Name = "txtMaVienPhi";
            this.txtMaVienPhi.ReadOnly = true;
            this.txtMaVienPhi.Size = new System.Drawing.Size(256, 20);
            this.txtMaVienPhi.TabIndex = 5;
            this.txtMaVienPhi.TextChanged += new System.EventHandler(this.txtMaVienPhi_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tiền thuốc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tiền dịch vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tiền khám";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên bệnh nhân";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã bệnh nhân";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnReset);
            this.groupBox4.Location = new System.Drawing.Point(444, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(351, 100);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(95, 31);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(178, 37);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset Form";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Tên bệnh nhân";
            // 
            // txtSearchTBN
            // 
            this.txtSearchTBN.Location = new System.Drawing.Point(91, 40);
            this.txtSearchTBN.Name = "txtSearchTBN";
            this.txtSearchTBN.Size = new System.Drawing.Size(231, 20);
            this.txtSearchTBN.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(346, 31);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 37);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.txtSearchTBN);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(4, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // TTVienPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TTVienPhi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin viện phí";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVienPhi)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTienKham;
        private System.Windows.Forms.TextBox txtTenBn;
        private System.Windows.Forms.TextBox txtMaBN;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.TextBox txtMaVienPhi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTienThuoc;
        private System.Windows.Forms.TextBox txtTienDichvu;
        private System.Windows.Forms.Button btnThemVienPhi;
        private System.Windows.Forms.TextBox txtTongVienPhi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvVienPhi;
        private System.Windows.Forms.TextBox txtNgayLap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtMaPK;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSearchTBN;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}