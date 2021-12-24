namespace QuanLyBenhVien.TraCuuDoanhThu
{
    partial class TraCuuDoanhThu
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
            this.dateTraCuu = new System.Windows.Forms.DateTimePicker();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.txtDV = new System.Windows.Forms.TextBox();
            this.txtKB = new System.Windows.Forms.TextBox();
            this.dateDoanhThu = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTraCuu);
            this.groupBox1.Controls.Add(this.btnTraCuu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tra cứu";
            // 
            // dateTraCuu
            // 
            this.dateTraCuu.Location = new System.Drawing.Point(136, 27);
            this.dateTraCuu.Name = "dateTraCuu";
            this.dateTraCuu.Size = new System.Drawing.Size(241, 20);
            this.dateTraCuu.TabIndex = 5;
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Location = new System.Drawing.Point(398, 24);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(95, 23);
            this.btnTraCuu.TabIndex = 4;
            this.btnTraCuu.Text = "Tra Cứu";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày Tháng Tra  Cứu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTong);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtDT);
            this.groupBox2.Controls.Add(this.txtDV);
            this.groupBox2.Controls.Add(this.txtKB);
            this.groupBox2.Controls.Add(this.dateDoanhThu);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(13, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(515, 271);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết doanh thu";
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(135, 223);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(241, 20);
            this.txtTong.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tổng Doanh Thu";
            // 
            // txtDT
            // 
            this.txtDT.Location = new System.Drawing.Point(135, 180);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(241, 20);
            this.txtDT.TabIndex = 9;
            // 
            // txtDV
            // 
            this.txtDV.Location = new System.Drawing.Point(135, 134);
            this.txtDV.Name = "txtDV";
            this.txtDV.Size = new System.Drawing.Size(241, 20);
            this.txtDV.TabIndex = 8;
            // 
            // txtKB
            // 
            this.txtKB.Location = new System.Drawing.Point(135, 85);
            this.txtKB.Name = "txtKB";
            this.txtKB.Size = new System.Drawing.Size(241, 20);
            this.txtKB.TabIndex = 7;
            // 
            // dateDoanhThu
            // 
            this.dateDoanhThu.Location = new System.Drawing.Point(135, 35);
            this.dateDoanhThu.Name = "dateDoanhThu";
            this.dateDoanhThu.Size = new System.Drawing.Size(241, 20);
            this.dateDoanhThu.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Doanh Thu Đơn Thuốc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Doanh Thu Dịch Vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Doanh Thu Khám Bệnh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày Tháng Doanh Thu";
            // 
            // TraCuuDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 368);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TraCuuDoanhThu";
            this.Text = "TraCuuDoanhThu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTraCuu;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.TextBox txtDV;
        private System.Windows.Forms.TextBox txtKB;
        private System.Windows.Forms.DateTimePicker dateDoanhThu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}