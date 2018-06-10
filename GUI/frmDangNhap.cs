using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Security.Cryptography;
using BUS;
using DTO;

namespace GUI
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        HandleButtonCURD handle = new HandleButtonCURD();
        BUSNguoiDung bus_nguoidung = new BUSNguoiDung();
        public frmDangNhap()
        {
            InitializeComponent();
            lblthongbaologin.Text = "";
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            NGUOIDUNG ng = new NGUOIDUNG()
            {
                taiKhoan = txtuser.Text,
                matKhau = handle.Encryptor(txtpassword.Text),
            };
            NGUOIDUNG userlogin = bus_nguoidung.login(ng);
            if(userlogin == null)
            {
                lblthongbaologin.Text = "Tài khoản hoặc mật khẩu không đúng !";
                return;
            }
            else
            {
                Session.user_login = userlogin;
                MessageBox.Show(userlogin.maNguoiDung.ToString() + userlogin.tenNguoiDung);
            }
        }

        private void frmDangNhap_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtuser_Validating(object sender, CancelEventArgs e)
        {
            handle._Validating(errorProvider1, txtuser, e, "Tài khoản không được trống");
        }

        private void txtpassword_Validating(object sender, CancelEventArgs e)
        {
            handle._Validating(errorProvider1, txtpassword, e, "Mật khẩu không được trống");
        }

        private void txtuser_Validated(object sender, EventArgs e)
        {
            handle._Validated(errorProvider1, txtuser);
        }

        private void txtpassword_Validated(object sender, EventArgs e)
        {
            handle._Validated(errorProvider1, txtpassword);
        }
    }
}