namespace QuanLyBenhVien.DSPhieuDichVu
{
    partial class DSPhieuDichVu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDSPhieuDichVu = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvChiTietDichVu = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhieuDichVu)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSPhieuDichVu);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phiếu dịch vụ";
            // 
            // dgvDSPhieuDichVu
            // 
            this.dgvDSPhieuDichVu.AllowUserToAddRows = false;
            this.dgvDSPhieuDichVu.AllowUserToDeleteRows = false;
            this.dgvDSPhieuDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPhieuDichVu.Location = new System.Drawing.Point(7, 20);
            this.dgvDSPhieuDichVu.Name = "dgvDSPhieuDichVu";
            this.dgvDSPhieuDichVu.ReadOnly = true;
            this.dgvDSPhieuDichVu.RowHeadersVisible = false;
            this.dgvDSPhieuDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSPhieuDichVu.Size = new System.Drawing.Size(464, 192);
            this.dgvDSPhieuDichVu.TabIndex = 0;
            this.dgvDSPhieuDichVu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSPhieuDichVu_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvChiTietDichVu);
            this.groupBox2.Location = new System.Drawing.Point(12, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(477, 202);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết phiếu dịch vụ";
            // 
            // dgvChiTietDichVu
            // 
            this.dgvChiTietDichVu.AllowUserToAddRows = false;
            this.dgvChiTietDichVu.AllowUserToDeleteRows = false;
            this.dgvChiTietDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietDichVu.Location = new System.Drawing.Point(7, 20);
            this.dgvChiTietDichVu.Name = "dgvChiTietDichVu";
            this.dgvChiTietDichVu.ReadOnly = true;
            this.dgvChiTietDichVu.RowHeadersVisible = false;
            this.dgvChiTietDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietDichVu.Size = new System.Drawing.Size(464, 176);
            this.dgvChiTietDichVu.TabIndex = 0;
            // 
            // DSPhieuDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DSPhieuDichVu";
            this.Text = "DSPhieuDichVu";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhieuDichVu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDichVu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDSPhieuDichVu;
        private System.Windows.Forms.DataGridView dgvChiTietDichVu;
    }
}