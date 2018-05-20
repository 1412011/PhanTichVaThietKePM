using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using BUS;

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
            BUSNguoiDung bus = new BUSNguoiDung();
            frmMain main = new frmMain();
            //Kt thông tin không được để trống
            if (tbTenDangNhap.Text.Length == 0 || tbMatKhau.Text.Length == 0)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Kt người đăng nhập là admin hay là khách hàng
            if (KTAdmin())
            {
                kq = 2;
                main.Show();
                this.Hide();
            }
            else
            {
                kq = bus.dangnhap(tbTenDangNhap.Text, tbMatKhau.Text);//Nhận kq trả về để kt ĐN thành công hay ko

                if (kq == 1)//Kq đn thành công
                {
                    main.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            frmDangKy DangKi = new frmDangKy();
            DangKi.Show();
        }
    }
}
