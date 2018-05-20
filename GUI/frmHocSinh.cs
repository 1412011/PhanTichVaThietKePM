using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using DevExpress.XtraEditors;

namespace GUI
{
    public partial class frmHocSinh : DevExpress.XtraEditors.XtraForm
    {
        HandleButtonCURD handleCURD = new HandleButtonCURD();
        BUSHocSinh bus_HocSinh = new BUSHocSinh();

        BindingSource bs = new BindingSource();

        const string _THEM_MOI = "Thêm";
        const string _SUA_ = "Sửa";
        const string _XOA_ = "Xóa";
        const string _KHONG_ = "Xem";

        public frmHocSinh()
        {
            InitializeComponent();
            _Load_BindingDataSource();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHocSinhTHPTDataSet.HOCSINH' table. You can move, or remove it, as needed.

        }

        private void gridControlHocSinh_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void _Load_BindingDataSource()
        {
            bs.DataSource = bus_HocSinh.get_all();
            bindingNavigatorDanhsachHS.BindingSource = bs;
            gridControlHS.DataSource = bs;
        }

        private void gridControlHS_Click(object sender, EventArgs e)
        {

        }

        private void gridViewHS_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
           
        }

        private void gridViewHS_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.RowHandle < 0) return;
            _Read_only_text(true);
            handleCURD._Handle_button_GridControl( btnThem,  btnSua,  btnLuu,  btnXoa);


            txtmahocsinh.Text = gridViewHS.GetFocusedRowCellValue("maHocSinh").ToString();
            txttenhocsinh.Text = gridViewHS.GetFocusedRowCellValue("hoTen").ToString();

            String gioitinh = gridViewHS.GetFocusedRowCellValue("gioiTinh").ToString();
            if (gioitinh.Equals("Nam"))
            {
                rbnam.Checked = true;
            }
            else
            {
                rbnu.Checked = true;
            }

            dtpNgaySinhHS.Text = gridViewHS.GetFocusedRowCellValue("ngaySinh").ToString();
            txtnoisinh.Text = gridViewHS.GetFocusedRowCellValue("noiSinh").ToString();
            txthotencha.Text = gridViewHS.GetFocusedRowCellValue("hoTenCha").ToString();
            txtnghenghiepcha.Text = gridViewHS.GetFocusedRowCellValue("ngheNghiepCha").ToString();
            txthotenme.Text = gridViewHS.GetFocusedRowCellValue("hoTenMe").ToString();
            txtnghenghiepme.Text = gridViewHS.GetFocusedRowCellValue("ngheNghiepMe").ToString();
        }

        #region handle text
        private void _Empty_All_Text()
        {
            txtmahocsinh.Text = "";
            txttenhocsinh.Text = "";
            rbnam.Checked = true;
            dtpNgaySinhHS.Text = "";
            txtnoisinh.Text = "";
            txthotencha.Text = "";
            txtnghenghiepcha.Text = "";
            txthotenme.Text = "";
            txtnghenghiepme.Text = "";
        }
        private void _Read_only_text(bool tt)
        {
            txttenhocsinh.ReadOnly = tt;
            rbnam.Enabled = !tt;
            rbnu.Enabled = !tt;
            dtpNgaySinhHS.Enabled = !tt;
            txtnoisinh.Enabled = !tt;
            txthotencha.ReadOnly = tt;
            txtnghenghiepcha.ReadOnly = tt;
            txthotenme.ReadOnly = tt;
            txtnghenghiepme.ReadOnly = tt;
        }
        private void _check_info_text()
        {
            if(txttenhocsinh.Text.Equals(""))
            {

            }
        }
        #endregion

        #region handle button curd
        private void btnNullEmpty_Click(object sender, EventArgs e)
        {
            _Empty_All_Text();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            handleCURD._Handle_button_Them(btnThem, btnSua, btnLuu, btnXoa);
            _Read_only_text(false);
            _Empty_All_Text();
            lblChucNang.Text = _THEM_MOI;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            handleCURD._Handle_button_Sua(btnThem, btnSua, btnLuu, btnXoa);
            _Read_only_text(false);
            lblChucNang.Text = _SUA_;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            HOCSINH hs = new HOCSINH()
            {
                hoTen = txttenhocsinh.Text,
                gioiTinh = (rbnam.Checked == true) ? "Nam" : "Nữ",
                ngaySinh = dtpNgaySinhHS.Value,
                noiSinh = txtnoisinh.Text,
                hoTenCha = txthotencha.Text,
                ngheNghiepCha = txtnghenghiepcha.Text,
                hoTenMe = txthotenme.Text,
                ngheNghiepMe = txtnghenghiepme.Text,
            };
            if(lblChucNang.Text.Equals(_THEM_MOI))
            {
                int re_hs = bus_HocSinh.insert(hs);
                if (re_hs < 1)
                {
                    MessageBox.Show("Có lỗi trong quá trình Thêm HỌC SINH !!!", "Lỗi", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    MessageBox.Show("Lưu thành công HỌC SINH !!!", "Thành công", MessageBoxButtons.OK);
                    _Empty_All_Text();
                    lblChucNang.Text = _KHONG_;
                    _Load_BindingDataSource();
                }
            }
            else
            {
                int idhs = Int32.Parse(txtmahocsinh.Text);
                hs.maHocSinh = idhs;
                int re = bus_HocSinh.update(hs);
                if(re<1)
                {
                    MessageBox.Show("Có lỗi trong quá trình Cập nhật HỌC SINH !!!", "Lỗi", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    MessageBox.Show("Lưu thành công HỌC SINH !!!", "Thành công", MessageBoxButtons.OK);
                    _Empty_All_Text();
                    lblChucNang.Text = _KHONG_;
                    _Load_BindingDataSource();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int idhs = Int32.Parse(txtmahocsinh.Text);
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn xóa Học sinh có mã là " + idhs + " ???", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int re = bus_HocSinh.delete(idhs);
                if (re < 1)
                {
                    MessageBox.Show("Có lỗi trong quá trình Xóa HỌC SINH !!!", "Lỗi", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa thành công HỌC SINH !!!", "Thành công", MessageBoxButtons.OK);
                    btnNaplai_Click(null, null);
                }
            }
        }

        private void btnNaplai_Click(object sender, EventArgs e)
        {
            handleCURD._Handle_button_Naplai(btnThem, btnSua, btnLuu, btnXoa);
            _Read_only_text(true);
            _Empty_All_Text();

            lblChucNang.Text = _KHONG_;
            _Load_BindingDataSource();
        }
        #endregion

        #region validating
        public bool ValidEmailAddress(string emailAddress, out string errorMessage)
        {
            // Confirm that the e-mail address string is not empty.
            if (emailAddress.Length == 0)
            {
                errorMessage = "e-mail address is required.";
                return false;
            }

            // Confirm that there is an "@" and a "." in the e-mail address, and in the correct order.
            if (emailAddress.IndexOf("@") > -1)
            {
                if (emailAddress.IndexOf(".", emailAddress.IndexOf("@")) > emailAddress.IndexOf("@"))
                {
                    errorMessage = "";
                    return true;
                }
            }

            errorMessage = "e-mail address must be valid e-mail address format.\n" +
               "For example 'someone@example.com' ";
            return false;
        }
        #endregion

        private void txtnoisinh_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (String.IsNullOrEmpty(txtnoisinh.Text) && txtnoisinh.Enabled == true)
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                txtnoisinh.Focus();
                this.errorProvider.SetError(txtnoisinh, "Nơi sinh không được trống");
            }
            else
            {
                e.Cancel = false;
                this.errorProvider.SetError(txtnoisinh, null);
            }
        }

        private void txtnoisinh_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(txtnoisinh, "");
        }

        private void txttenhocsinh_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (String.IsNullOrEmpty(txttenhocsinh.Text) && txttenhocsinh.ReadOnly == false)
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                txttenhocsinh.Focus();
                this.errorProvider.SetError(txttenhocsinh, "Họ tên học sinh không được trống");
            }
            else
            {
                e.Cancel = false;
                this.errorProvider.SetError(txttenhocsinh, null);
            }
        }

        private void txttenhocsinh_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(txtnoisinh, "");
        }
    }
}
