namespace GUI
{
    partial class frmDangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKi));
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbTenDN = new System.Windows.Forms.Label();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.lbNhapLaiMK = new System.Windows.Forms.Label();
            this.lbCMND = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbMoTa = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.tbTenDangNhap = new System.Windows.Forms.TextBox();
            this.tbMatKhau = new System.Windows.Forms.TextBox();
            this.tbNhapLaiMK = new System.Windows.Forms.TextBox();
            this.tbCMND = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.tbMoTa = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btDangKi = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Location = new System.Drawing.Point(24, 41);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(52, 13);
            this.lbHoTen.TabIndex = 0;
            this.lbHoTen.Text = "Họ tên(*):";
            // 
            // lbTenDN
            // 
            this.lbTenDN.AutoSize = true;
            this.lbTenDN.Location = new System.Drawing.Point(24, 77);
            this.lbTenDN.Name = "lbTenDN";
            this.lbTenDN.Size = new System.Drawing.Size(94, 13);
            this.lbTenDN.TabIndex = 1;
            this.lbTenDN.Text = "Tên đăng nhập(*):";
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Location = new System.Drawing.Point(24, 117);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(65, 13);
            this.lbMatKhau.TabIndex = 2;
            this.lbMatKhau.Text = "Mật khẩu(*):";
            // 
            // lbNhapLaiMK
            // 
            this.lbNhapLaiMK.AutoSize = true;
            this.lbNhapLaiMK.Location = new System.Drawing.Point(24, 157);
            this.lbNhapLaiMK.Name = "lbNhapLaiMK";
            this.lbNhapLaiMK.Size = new System.Drawing.Size(106, 13);
            this.lbNhapLaiMK.TabIndex = 3;
            this.lbNhapLaiMK.Text = "Nhập lại mật khẩu(*):";
            // 
            // lbCMND
            // 
            this.lbCMND.AutoSize = true;
            this.lbCMND.Location = new System.Drawing.Point(24, 195);
            this.lbCMND.Name = "lbCMND";
            this.lbCMND.Size = new System.Drawing.Size(68, 13);
            this.lbCMND.TabIndex = 4;
            this.lbCMND.Text = "Số CMND(*):";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(24, 229);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(53, 13);
            this.lbDiaChi.TabIndex = 5;
            this.lbDiaChi.Text = "Địa chỉ(*):";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Location = new System.Drawing.Point(24, 266);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(83, 13);
            this.lbSDT.TabIndex = 6;
            this.lbSDT.Text = "Số điện thoại(*):";
            // 
            // lbMoTa
            // 
            this.lbMoTa.AutoSize = true;
            this.lbMoTa.Location = new System.Drawing.Point(24, 302);
            this.lbMoTa.Name = "lbMoTa";
            this.lbMoTa.Size = new System.Drawing.Size(37, 13);
            this.lbMoTa.TabIndex = 7;
            this.lbMoTa.Text = "Mô tả:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(24, 344);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(45, 13);
            this.lbEmail.TabIndex = 8;
            this.lbEmail.Text = "Email(*):";
            // 
            // tbHoTen
            // 
            this.tbHoTen.Location = new System.Drawing.Point(136, 38);
            this.tbHoTen.MaxLength = 30;
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(144, 20);
            this.tbHoTen.TabIndex = 9;
            // 
            // tbTenDangNhap
            // 
            this.tbTenDangNhap.Location = new System.Drawing.Point(136, 74);
            this.tbTenDangNhap.MaxLength = 15;
            this.tbTenDangNhap.Name = "tbTenDangNhap";
            this.tbTenDangNhap.Size = new System.Drawing.Size(144, 20);
            this.tbTenDangNhap.TabIndex = 10;
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.Location = new System.Drawing.Point(136, 114);
            this.tbMatKhau.MaxLength = 15;
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.Size = new System.Drawing.Size(144, 20);
            this.tbMatKhau.TabIndex = 11;
            this.tbMatKhau.UseSystemPasswordChar = true;
            // 
            // tbNhapLaiMK
            // 
            this.tbNhapLaiMK.Location = new System.Drawing.Point(136, 154);
            this.tbNhapLaiMK.MaxLength = 15;
            this.tbNhapLaiMK.Name = "tbNhapLaiMK";
            this.tbNhapLaiMK.Size = new System.Drawing.Size(144, 20);
            this.tbNhapLaiMK.TabIndex = 12;
            this.tbNhapLaiMK.UseSystemPasswordChar = true;
            // 
            // tbCMND
            // 
            this.tbCMND.Location = new System.Drawing.Point(136, 192);
            this.tbCMND.MaxLength = 9;
            this.tbCMND.Name = "tbCMND";
            this.tbCMND.Size = new System.Drawing.Size(144, 20);
            this.tbCMND.TabIndex = 13;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(136, 226);
            this.txtDiaChi.MaxLength = 30;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(240, 20);
            this.txtDiaChi.TabIndex = 14;
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(136, 263);
            this.tbSDT.MaxLength = 10;
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(144, 20);
            this.tbSDT.TabIndex = 15;
            // 
            // tbMoTa
            // 
            this.tbMoTa.Location = new System.Drawing.Point(136, 299);
            this.tbMoTa.MaxLength = 30;
            this.tbMoTa.Name = "tbMoTa";
            this.tbMoTa.Size = new System.Drawing.Size(215, 20);
            this.tbMoTa.TabIndex = 16;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(136, 341);
            this.tbEmail.MaxLength = 30;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(280, 20);
            this.tbEmail.TabIndex = 17;
            // 
            // btDangKi
            // 
            this.btDangKi.Location = new System.Drawing.Point(85, 395);
            this.btDangKi.Name = "btDangKi";
            this.btDangKi.Size = new System.Drawing.Size(75, 39);
            this.btDangKi.TabIndex = 18;
            this.btDangKi.Text = "Đăng ký";
            this.btDangKi.UseVisualStyleBackColor = true;
            this.btDangKi.Click += new System.EventHandler(this.btDangKi_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(249, 395);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 39);
            this.btThoat.TabIndex = 19;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(310, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // DangKi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 458);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btDangKi);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbMoTa);
            this.Controls.Add(this.tbSDT);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.tbCMND);
            this.Controls.Add(this.tbNhapLaiMK);
            this.Controls.Add(this.tbMatKhau);
            this.Controls.Add(this.tbTenDangNhap);
            this.Controls.Add(this.tbHoTen);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbMoTa);
            this.Controls.Add(this.lbSDT);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.lbCMND);
            this.Controls.Add(this.lbNhapLaiMK);
            this.Controls.Add(this.lbMatKhau);
            this.Controls.Add(this.lbTenDN);
            this.Controls.Add(this.lbHoTen);
            this.Name = "DangKi";
            this.Text = "DangKi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbTenDN;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.Label lbNhapLaiMK;
        private System.Windows.Forms.Label lbCMND;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbMoTa;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbHoTen;
        private System.Windows.Forms.TextBox tbTenDangNhap;
        private System.Windows.Forms.TextBox tbMatKhau;
        private System.Windows.Forms.TextBox tbNhapLaiMK;
        private System.Windows.Forms.TextBox tbCMND;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.TextBox tbMoTa;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btDangKi;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}