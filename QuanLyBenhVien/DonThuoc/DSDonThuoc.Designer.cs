
namespace QuanLyBenhVien.DThuoc
{
    partial class DSDonThuoc
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
            this.ss = new System.Windows.Forms.GroupBox();
            this.dgvDonThuoc = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTongChiPhi = new System.Windows.Forms.TextBox();
            this.txtTenBn = new System.Windows.Forms.TextBox();
            this.txtMaBN = new System.Windows.Forms.TextBox();
            this.txtMaPK = new System.Windows.Forms.TextBox();
            this.txtMaDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvCTDon = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearchTBN = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ss.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonThuoc)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDon)).BeginInit();
            this.SuspendLayout();
            // 
            // ss
            // 
            this.ss.Controls.Add(this.button1);
            this.ss.Controls.Add(this.txtSearchTBN);
            this.ss.Controls.Add(this.label5);
            this.ss.Location = new System.Drawing.Point(2, 3);
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(404, 100);
            this.ss.TabIndex = 0;
            this.ss.TabStop = false;
            this.ss.Text = "Tìm kiếm";
            // 
            // dgvDonThuoc
            // 
            this.dgvDonThuoc.AllowUserToAddRows = false;
            this.dgvDonThuoc.AllowUserToDeleteRows = false;
            this.dgvDonThuoc.AllowUserToOrderColumns = true;
            this.dgvDonThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonThuoc.Location = new System.Drawing.Point(6, 19);
            this.dgvDonThuoc.Name = "dgvDonThuoc";
            this.dgvDonThuoc.ReadOnly = true;
            this.dgvDonThuoc.RowHeadersVisible = false;
            this.dgvDonThuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonThuoc.Size = new System.Drawing.Size(392, 314);
            this.dgvDonThuoc.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDonThuoc);
            this.groupBox2.Location = new System.Drawing.Point(2, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 340);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách đơn thuốc";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTongChiPhi);
            this.groupBox3.Controls.Add(this.txtTenBn);
            this.groupBox3.Controls.Add(this.txtMaBN);
            this.groupBox3.Controls.Add(this.txtMaPK);
            this.groupBox3.Controls.Add(this.txtMaDT);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.dgvCTDon);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(412, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(343, 442);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết đơn thuốc";
            // 
            // txtTongChiPhi
            // 
            this.txtTongChiPhi.Location = new System.Drawing.Point(92, 415);
            this.txtTongChiPhi.Name = "txtTongChiPhi";
            this.txtTongChiPhi.ReadOnly = true;
            this.txtTongChiPhi.Size = new System.Drawing.Size(241, 20);
            this.txtTongChiPhi.TabIndex = 12;
            // 
            // txtTenBn
            // 
            this.txtTenBn.Location = new System.Drawing.Point(92, 116);
            this.txtTenBn.Name = "txtTenBn";
            this.txtTenBn.ReadOnly = true;
            this.txtTenBn.Size = new System.Drawing.Size(241, 20);
            this.txtTenBn.TabIndex = 10;
            // 
            // txtMaBN
            // 
            this.txtMaBN.Location = new System.Drawing.Point(92, 84);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.ReadOnly = true;
            this.txtMaBN.Size = new System.Drawing.Size(241, 20);
            this.txtMaBN.TabIndex = 9;
            // 
            // txtMaPK
            // 
            this.txtMaPK.Location = new System.Drawing.Point(92, 53);
            this.txtMaPK.Name = "txtMaPK";
            this.txtMaPK.ReadOnly = true;
            this.txtMaPK.Size = new System.Drawing.Size(241, 20);
            this.txtMaPK.TabIndex = 8;
            // 
            // txtMaDT
            // 
            this.txtMaDT.Location = new System.Drawing.Point(92, 22);
            this.txtMaDT.Name = "txtMaDT";
            this.txtMaDT.ReadOnly = true;
            this.txtMaDT.Size = new System.Drawing.Size(241, 20);
            this.txtMaDT.TabIndex = 7;
            this.txtMaDT.TextChanged += new System.EventHandler(this.txtMaDT_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tổng chi phí";
            // 
            // dgvCTDon
            // 
            this.dgvCTDon.AllowUserToAddRows = false;
            this.dgvCTDon.AllowUserToDeleteRows = false;
            this.dgvCTDon.AllowUserToOrderColumns = true;
            this.dgvCTDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTDon.Location = new System.Drawing.Point(9, 153);
            this.dgvCTDon.Name = "dgvCTDon";
            this.dgvCTDon.ReadOnly = true;
            this.dgvCTDon.RowHeadersVisible = false;
            this.dgvCTDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTDon.Size = new System.Drawing.Size(328, 248);
            this.dgvCTDon.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên bệnh nhân";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã bệnh nhân";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã phiếu khám";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đơn thuốc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên bệnh nhân";
            // 
            // txtSearchTBN
            // 
            this.txtSearchTBN.Location = new System.Drawing.Point(96, 40);
            this.txtSearchTBN.Name = "txtSearchTBN";
            this.txtSearchTBN.Size = new System.Drawing.Size(221, 20);
            this.txtSearchTBN.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DSDonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ss);
            this.Name = "DSDonThuoc";
            this.Text = "DSDonThuoc";
            this.ss.ResumeLayout(false);
            this.ss.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonThuoc)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ss;
        private System.Windows.Forms.DataGridView dgvDonThuoc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTongChiPhi;
        private System.Windows.Forms.TextBox txtTenBn;
        private System.Windows.Forms.TextBox txtMaBN;
        private System.Windows.Forms.TextBox txtMaPK;
        private System.Windows.Forms.TextBox txtMaDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvCTDon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSearchTBN;
        private System.Windows.Forms.Label label5;
    }
}