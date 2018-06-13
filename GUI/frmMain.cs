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
using DevExpress.XtraBars.Helpers;
using DTO;
using BUS;

namespace GUI
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
            init_form();
            //if(Session.userID==null)
            //{
            //    frmDangNhap dangnhap = new frmDangNhap();
            //    dangnhap.Show();
            //}
         
        }

        private void init_form()
        {
            if(Session.user_login == null)
            {
                barStaticTen.Caption = "Không có";
                barStaticQuyen.Caption = "Không có";
            }
            else
            {
                barStaticTen.Caption = Session.user_login.tenNguoiDung;
                barStaticQuyen.Caption = "Giáo viên";
            }
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _OpenForm_New(new frmKhoiLop());
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _OpenForm_New(new frmGiaoVien());
        }

        private bool existFormChild(XtraForm form)
        {
            foreach(XtraForm child in MdiChildren)
            {
                if(child.Name.Equals(form.Name))
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _OpenForm_New(new frmHocSinh());
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SkinHelper.InitSkinPopupMenu(barLinkContainerItem1);
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _OpenForm_New(new frmBoMon());
        }

        private void barButtonItemNamHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _OpenForm_New(new frmNamHoc());
        }
        private void _OpenForm_New(XtraForm f)
        {
            if (!existFormChild(f))
            {
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItemHanhKiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _OpenForm_New(new frmHanhKiem());
        }

        private void barButtonItemHocLuc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _OpenForm_New(new frmHocLuc());
        }

        private void barButtonItemHocKy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _OpenForm_New(new HocKy());
        }

        private void barButtonItemQuiDinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _OpenForm_New(new frmQuyDinh());
        }

        private void barStaticItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItemLopHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _OpenForm_New(new frmLopHoc());
        }

        private void barButtonItemPhanLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _OpenForm_New(new frmPhanLop());
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _OpenForm_New(new frmKetQuaThang());
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDangNhap dangnhap = new frmDangNhap();
            this.Hide();
            dangnhap.ShowDialog();
            this.Close();
        }
    }
}