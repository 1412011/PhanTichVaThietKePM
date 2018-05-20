using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }
        //Button ĐK
        private void btDangKi_Click(object sender, EventArgs e)
        {
            BUSNguoiDung bus = new BUSNguoiDung();
            NGUOIDUNG dto = new NGUOIDUNG();
            dto.tenNguoiDung = tbHoTen.Text;
            if (dto.tenNguoiDung == null || dto.tenNguoiDung == string.Empty)
            {
                MessageBox.Show("Tên ngườid dùng không được rỗng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dto.gioiTinh = "Nam";
            //dto.ngaySinh;
            dto.sDT = tbSDT.Text;
            dto.diaChi = 2018;
            dto.email = tbEmail.Text;
            dto.taiKhoan = tbTenDangNhap.Text;
            dto.matKhau = tbMatKhau.Text;
            bus.insert(dto);
            this.Close();
        }

        //Button Thoát
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
