
namespace QuanLyBenhVien.User
{
    partial class Forget
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchTK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaXN = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLayma = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMKM = new System.Windows.Forms.TextBox();
            this.btnDat = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vui lòng nhập Email để tìm tài khoản";
            // 
            // txtSearchTK
            // 
            this.txtSearchTK.Location = new System.Drawing.Point(15, 25);
            this.txtSearchTK.Name = "txtSearchTK";
            this.txtSearchTK.Size = new System.Drawing.Size(293, 20);
            this.txtSearchTK.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã nhân viên";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(73, 53);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.ReadOnly = true;
            this.txtTaiKhoan.Size = new System.Drawing.Size(142, 20);
            this.txtTaiKhoan.TabIndex = 4;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(299, 53);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(142, 20);
            this.txtMaNV.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(328, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mã xác nhận";
            // 
            // txtMaXN
            // 
            this.txtMaXN.Location = new System.Drawing.Point(87, 82);
            this.txtMaXN.Name = "txtMaXN";
            this.txtMaXN.ReadOnly = true;
            this.txtMaXN.Size = new System.Drawing.Size(185, 20);
            this.txtMaXN.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Xác nhận";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLayma
            // 
            this.btnLayma.Location = new System.Drawing.Point(367, 80);
            this.btnLayma.Name = "btnLayma";
            this.btnLayma.Size = new System.Drawing.Size(75, 23);
            this.btnLayma.TabIndex = 10;
            this.btnLayma.Text = "Lấy mã";
            this.btnLayma.UseVisualStyleBackColor = true;
            this.btnLayma.Click += new System.EventHandler(this.btnLayma_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mật khẩu mới";
            // 
            // txtMKM
            // 
            this.txtMKM.Location = new System.Drawing.Point(87, 111);
            this.txtMKM.Name = "txtMKM";
            this.txtMKM.ReadOnly = true;
            this.txtMKM.Size = new System.Drawing.Size(231, 20);
            this.txtMKM.TabIndex = 12;
            // 
            // btnDat
            // 
            this.btnDat.Location = new System.Drawing.Point(341, 109);
            this.btnDat.Name = "btnDat";
            this.btnDat.Size = new System.Drawing.Size(100, 23);
            this.btnDat.TabIndex = 13;
            this.btnDat.Text = "Đặt mật khẩu";
            this.btnDat.UseVisualStyleBackColor = true;
            this.btnDat.Click += new System.EventHandler(this.btnDat_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(197, 137);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Forget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 170);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDat);
            this.Controls.Add(this.txtMKM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLayma);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMaXN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchTK);
            this.Controls.Add(this.label1);
            this.Name = "Forget";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quên mật khẩu?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchTK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaXN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLayma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMKM;
        private System.Windows.Forms.Button btnDat;
        private System.Windows.Forms.Button btnCancel;
    }
}