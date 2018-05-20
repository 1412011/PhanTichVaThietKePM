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

namespace GUI
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBangDiem bd = new frmBangDiem();
            bd.Show();
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmGiaoVien formgv = new frmGiaoVien();
            if(existFormChild(formgv))return;
            formgv.MdiParent = this;
            formgv.Show();
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
            frmHocSinh f = new frmHocSinh();
            if (existFormChild(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SkinHelper.InitSkinPopupMenu(barLinkContainerItem1);
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTKB tkb = new frmTKB();
            tkb.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKetQua kq = new frmKetQua();
            kq.Show();
        }
    }
}