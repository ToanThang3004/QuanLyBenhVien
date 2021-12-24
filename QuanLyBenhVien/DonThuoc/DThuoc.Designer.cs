
namespace QuanLyBenhVien.DThuoc
{
    partial class DThuoc
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtTenBN = new System.Windows.Forms.TextBox();
            this.txtMBN = new System.Windows.Forms.TextBox();
            this.txtMaPK = new System.Windows.Forms.TextBox();
            this.txtMaDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaDonThuoc = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtGiaThuoc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnThemDT = new System.Windows.Forms.Button();
            this.dgvThuoc = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtCachDung = new System.Windows.Forms.TextBox();
            this.txtSoLuongThuoc = new System.Windows.Forms.TextBox();
            this.cbbThuoc = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTongTien);
            this.groupBox3.Controls.Add(this.txtTenBN);
            this.groupBox3.Controls.Add(this.txtMBN);
            this.groupBox3.Controls.Add(this.txtMaPK);
            this.groupBox3.Controls.Add(this.txtMaDT);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtMaDonThuoc);
            this.groupBox3.Location = new System.Drawing.Point(4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(473, 168);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết đơn thuốc";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(106, 130);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(353, 20);
            this.txtTongTien.TabIndex = 8;
            // 
            // txtTenBN
            // 
            this.txtTenBN.Location = new System.Drawing.Point(106, 103);
            this.txtTenBN.Name = "txtTenBN";
            this.txtTenBN.ReadOnly = true;
            this.txtTenBN.Size = new System.Drawing.Size(353, 20);
            this.txtTenBN.TabIndex = 7;
            // 
            // txtMBN
            // 
            this.txtMBN.Location = new System.Drawing.Point(106, 76);
            this.txtMBN.Name = "txtMBN";
            this.txtMBN.ReadOnly = true;
            this.txtMBN.Size = new System.Drawing.Size(353, 20);
            this.txtMBN.TabIndex = 6;
            // 
            // txtMaPK
            // 
            this.txtMaPK.Location = new System.Drawing.Point(106, 49);
            this.txtMaPK.Name = "txtMaPK";
            this.txtMaPK.ReadOnly = true;
            this.txtMaPK.Size = new System.Drawing.Size(353, 20);
            this.txtMaPK.TabIndex = 5;
            this.txtMaPK.TextChanged += new System.EventHandler(this.txtMaPK_TextChanged);
            // 
            // txtMaDT
            // 
            this.txtMaDT.Location = new System.Drawing.Point(106, 22);
            this.txtMaDT.Name = "txtMaDT";
            this.txtMaDT.ReadOnly = true;
            this.txtMaDT.Size = new System.Drawing.Size(353, 20);
            this.txtMaDT.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tổng chi phí";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên bệnh nhân";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã bệnh nhân";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã phiếu khám";
            // 
            // txtMaDonThuoc
            // 
            this.txtMaDonThuoc.AutoSize = true;
            this.txtMaDonThuoc.Location = new System.Drawing.Point(7, 25);
            this.txtMaDonThuoc.Name = "txtMaDonThuoc";
            this.txtMaDonThuoc.Size = new System.Drawing.Size(74, 13);
            this.txtMaDonThuoc.TabIndex = 0;
            this.txtMaDonThuoc.Text = "Mã đơn thuốc";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnReset);
            this.groupBox4.Controls.Add(this.txtGiaThuoc);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.btnIn);
            this.groupBox4.Controls.Add(this.btnThemDT);
            this.groupBox4.Controls.Add(this.dgvThuoc);
            this.groupBox4.Controls.Add(this.btnThem);
            this.groupBox4.Controls.Add(this.txtCachDung);
            this.groupBox4.Controls.Add(this.txtSoLuongThuoc);
            this.groupBox4.Controls.Add(this.cbbThuoc);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(4, 174);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(473, 304);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi tiết thuốc";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(319, 258);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(131, 36);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Reset Form";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtGiaThuoc
            // 
            this.txtGiaThuoc.Location = new System.Drawing.Point(250, 27);
            this.txtGiaThuoc.Name = "txtGiaThuoc";
            this.txtGiaThuoc.ReadOnly = true;
            this.txtGiaThuoc.Size = new System.Drawing.Size(93, 20);
            this.txtGiaThuoc.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(221, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Giá";
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(170, 258);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(131, 36);
            this.btnIn.TabIndex = 17;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // btnThemDT
            // 
            this.btnThemDT.Location = new System.Drawing.Point(29, 258);
            this.btnThemDT.Name = "btnThemDT";
            this.btnThemDT.Size = new System.Drawing.Size(131, 36);
            this.btnThemDT.TabIndex = 16;
            this.btnThemDT.Text = "Thêm";
            this.btnThemDT.UseVisualStyleBackColor = true;
            this.btnThemDT.Click += new System.EventHandler(this.btnThemDT_Click);
            // 
            // dgvThuoc
            // 
            this.dgvThuoc.AllowUserToResizeColumns = false;
            this.dgvThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuoc.Location = new System.Drawing.Point(6, 80);
            this.dgvThuoc.MultiSelect = false;
            this.dgvThuoc.Name = "dgvThuoc";
            this.dgvThuoc.RowHeadersVisible = false;
            this.dgvThuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThuoc.Size = new System.Drawing.Size(461, 172);
            this.dgvThuoc.TabIndex = 15;
            this.dgvThuoc.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuoc_CellValueChanged);
            this.dgvThuoc.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvThuoc_RowsAdded);
            this.dgvThuoc.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvThuoc_RowsRemoved);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(319, 52);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(131, 23);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtCachDung
            // 
            this.txtCachDung.Location = new System.Drawing.Point(70, 54);
            this.txtCachDung.Name = "txtCachDung";
            this.txtCachDung.Size = new System.Drawing.Size(231, 20);
            this.txtCachDung.TabIndex = 14;
            // 
            // txtSoLuongThuoc
            // 
            this.txtSoLuongThuoc.Location = new System.Drawing.Point(404, 27);
            this.txtSoLuongThuoc.Name = "txtSoLuongThuoc";
            this.txtSoLuongThuoc.Size = new System.Drawing.Size(55, 20);
            this.txtSoLuongThuoc.TabIndex = 13;
            // 
            // cbbThuoc
            // 
            this.cbbThuoc.FormattingEnabled = true;
            this.cbbThuoc.Location = new System.Drawing.Point(70, 27);
            this.cbbThuoc.Name = "cbbThuoc";
            this.cbbThuoc.Size = new System.Drawing.Size(145, 21);
            this.cbbThuoc.TabIndex = 12;
            this.cbbThuoc.SelectedValueChanged += new System.EventHandler(this.cbbThuoc_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(349, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cách dùng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tên thuốc";
            // 
            // DThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 483);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "DThuoc";
            this.Text = "Đơn thuốc";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtTenBN;
        private System.Windows.Forms.TextBox txtMBN;
        private System.Windows.Forms.TextBox txtMaPK;
        private System.Windows.Forms.TextBox txtMaDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtMaDonThuoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbThuoc;
        private System.Windows.Forms.TextBox txtSoLuongThuoc;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtCachDung;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnThemDT;
        private System.Windows.Forms.DataGridView dgvThuoc;
        private System.Windows.Forms.TextBox txtGiaThuoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnReset;
    }
}