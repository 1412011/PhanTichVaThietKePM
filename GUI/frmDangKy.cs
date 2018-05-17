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
            try
            {
                //Kt lỗi còn trống thông tin trên giao diện
                if (tbHoTen.Text.Length == 0 || tbTenDangNhap.Text.Length == 0 || tbMatKhau.Text.Length == 0 || tbNhapLaiMK.Text.Length == 0 || tbSDT.Text.Length == 0 || tbEmail.Text.Length == 0)
                {
                    MessageBox.Show("Chưa nhập đầy đủ thông tin. Vui lòng kiểm tra lại thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //Kt phân quyền admin và khách hàng
                if (tbTenDangNhap.Text == "admin")
                {
                    MessageBox.Show("Tài khoản đã tồn tại. Vui lòng nhập lại tên đăng nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //Kt mật khẩu nhập vào và mật khẩu nhập lại
                if (tbMatKhau.Text != tbNhapLaiMK.Text)
                {
                    MessageBox.Show("Mật khẩu xác nhận không trùng khớp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //Kt CMND có đủ 9 số
                if (tbCMND.Text.Length != 9)
                {
                    MessageBox.Show("CMND của bạn không đủ 9 kí tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                KHACHHANG_DAO.DangKi(tbHoTen.Text, tbTenDangNhap.Text, tbMatKhau.Text, tbCMND.Text, txtDiaChi.Text, tbSDT.Text, tbMoTa.Text, tbEmail.Text);//Truyền tham số vào hàm thực thi đăng kí
                MessageBox.Show("Đăng kí thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);//Hiển thị thông báo thành công
                MainForm.KT_DangNhap = 1;
                MainForm.TenKH = KHACHHANG_DAO.TimTenKH(tbTenDangNhap.Text);//Lấy tên Khách hàng để hiện lên giao diện chính
                DatPhong.MaKH = KHACHHANG_DAO.TimMaKH(tbTenDangNhap.Text);
                this.Hide();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);//Bắt lỗi thực thi trong store
            }
        }

        //Button Thoát
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
