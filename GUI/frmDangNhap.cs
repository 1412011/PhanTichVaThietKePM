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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        
        private bool KTAdmin()//Kt tên đăng nhập là admin
        {
            if (tbTenDangNhap.Text == "admin" && tbMatKhau.Text == "admin")
                return true;
            return false;
        }
        //Buuton Đăng nhập

        private void KiemTraDangNhap()
        {
            int kq = 0;
            //Kt thông tin không được để trống
            if (tbTenDangNhap.Text.Length == 0 || tbMatKhau.Text.Length == 0)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Kt người đăng nhập là admin hay là khách hàng
            if (KTAdmin())
            {
                MainForm.KT_DangNhap = 2;    //Biến KTDangNhap đc bật lên 2. Admin đã đăng nhập               
                this.Hide();
            }
            else
            {
                kq = KHACHHANG_DAO.DangNhap(tbTenDangNhap.Text, tbMatKhau.Text);//Nhận kq trả về để kt ĐN thành công hay ko

                if (kq == 1)//Kq đn thành công
                {
                    MainForm.KT_DangNhap = 1;//Biến KTDangNhap đc bật lên 1. KH đã đăng nhập
                    MainForm.TenKH = KHACHHANG_DAO.TimTenKH(tbTenDangNhap.Text);
                    DatPhong.MaKH = KHACHHANG_DAO.TimMaKH(tbTenDangNhap.Text);
                    this.Hide();
                }
                else
                    MessageBox.Show("Đăng nhập không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void tbMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                KiemTraDangNhap();
            }
        }

        private void DN_Load(object sender, EventArgs e)
        {

        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            KiemTraDangNhap();
        }
    }
}
