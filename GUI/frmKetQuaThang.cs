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
using DTO;
using BUS;
namespace GUI
{
    public partial class frmKetQuaThang : DevExpress.XtraEditors.XtraForm
    {
        const int _LOAIKETQUA_THANG_ = 1;

        BUSLop bus_lop = new BUSLop();
        BUSMon_Lop bus_monlop = new BUSMon_Lop();
        BUSKetQuaHocTap bus_ketquaht = new BUSKetQuaHocTap();
        BUSBangDiem bus_bangdiem = new BUSBangDiem();
        BUSNguoiDung bus_giaovien = new BUSNguoiDung();
        BindingSource bs = new BindingSource();
        public frmKetQuaThang()
        {
            InitializeComponent();
            _Load_lookup_Lop();
        }

        private void tvthang_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            //_BindingSource();
        }
        private int _trans_node_to_thang(String s)
        {
            int thang = 0;
            if (s.Equals("thang9")) thang = 9;
            else if (s.Equals("thang10")) thang = 10;
            else if (s.Equals("thang11")) thang = 11;
            else if (s.Equals("thang12")) thang = 12;
            else if (s.Equals("thang1")) thang = 1;
            else if (s.Equals("thang2")) thang = 2;
            else if (s.Equals("thang3")) thang = 3;
            else if (s.Equals("thang4")) thang = 4;

            return thang;
        }

        private void frmKetQuaThang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLYHOCSINHDataSet.HANHKIEM' table. You can move, or remove it, as needed.
            this.hANHKIEMTableAdapter.Fill(this.qUANLYHOCSINHDataSet.HANHKIEM);
            // TODO: This line of code loads data into the 'qUANLYHOCSINHDataSet.HOCLUC' table. You can move, or remove it, as needed.
            this.hOCLUCTableAdapter.Fill(this.qUANLYHOCSINHDataSet.HOCLUC);
            // TODO: This line of code loads data into the 'qUANLYHOCSINHDataSet.BOMON' table. You can move, or remove it, as needed.
            this.bOMONTableAdapter.Fill(this.qUANLYHOCSINHDataSet.BOMON);
            // TODO: This line of code loads data into the 'qUANLYHOCSINHDataSet.KHOILOP' table. You can move, or remove it, as needed.
            this.kHOILOPTableAdapter.Fill(this.qUANLYHOCSINHDataSet.KHOILOP);
            // TODO: This line of code loads data into the 'qUANLYHOCSINHDataSet.NAMHOC' table. You can move, or remove it, as needed.
            this.nAMHOCTableAdapter.Fill(this.qUANLYHOCSINHDataSet.NAMHOC);

        }

        public void _BindingSource()
        {
            LOP obj = get_Lop_lookup();
            if (obj == null)
            {
                return;
            }

            BOMON obj2 = get_BoMon_lookup();
            if (obj2 == null)
            {
                MessageBox.Show("Chưa chọn Môn học !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MON_LOP ml = bus_monlop.get_MonLop_to_MON_LOP(obj2, obj);
            if (ml == null)
            {
                MessageBox.Show("Chưa có Môn của lớp này trong csdl !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ml.giaoVienPhuTrach == null || ml.giaoVienPhuTrach == 0)
            {
                lblGVMon.Text = "Chưa có";
            }
            else
            {
                int id = (int)ml.giaoVienPhuTrach;
                lblGVMon.Text = bus_giaovien.get_unique(id).tenNguoiDung;
            }

            TreeNode tn = tvthang.SelectedNode;
            if (tn == null) return;

            String namenode = tn.Name;
            int thang = _trans_node_to_thang(namenode);
            if (thang == 0) return;


            bs.DataSource = bus_ketquaht.get_list_full_info(thang, _LOAIKETQUA_THANG_, ml);
            gridControlKQThang.DataSource = bs;
            bindingNavigatorKetquahoctap.BindingSource = bs;

        }

        #region get data lookup edit
        private NAMHOC get_NamHoc_lookup()
        {
            Object obj = lookUpEditNamHoc.EditValue;
            if (obj == null) return null;
            String dt = (String)obj;
            return new NAMHOC() { tenNamHoc = dt };
        }
        private KHOILOP get_KhoiLop_lookup()
        {
            Object obj = lookUpEditKhoiLop.EditValue;
            if (obj == null) return null;
            String dt = (String)obj;
            return new KHOILOP() { tenKhoiLop = dt };
        }
        private BOMON get_BoMon_lookup()
        {
            Object obj = lookUpEditBoMon.EditValue;
            if (obj == null) return null;
            int dt = (int)obj;
            return new BOMON() { maBoMon = dt };
        }
        private LOP get_Lop_lookup()
        {
            Object obj = lookUpEditLop.EditValue;
            if (obj == null) return null;
            int dt = (int)obj;
            return new LOP() { maLop = dt };
        }
        #endregion

        private void _Load_lookup_Lop()
        {
            NAMHOC namhoc = get_NamHoc_lookup();
            if (namhoc == null) return;
            KHOILOP khoilop = get_KhoiLop_lookup();
            if (khoilop == null) return;

            DataTable dt = bus_lop.get_LOP_Khoilop_namHoc(khoilop,namhoc);
            lookUpEditLop.Properties.DataSource = dt;
            lookUpEditLop.ItemIndex = 0;
        }

        private void lookUpEditNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            _Load_lookup_Lop();
        }

        private void lookUpEditKhoiLop_EditValueChanged(object sender, EventArgs e)
        {
            _Load_lookup_Lop();
        }

        private void lookUpEditLop_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void lookUpEditLop_EditValueChanged_1(object sender, EventArgs e)
        {
            _BindingSource();
        }

        private void lookUpEditBoMon_EditValueChanged(object sender, EventArgs e)
        {
            _BindingSource();
        }

        private void tvthang_AfterSelect(object sender, TreeViewEventArgs e)
        {
            _BindingSource();
        }
        private void gridViewKqThang_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int stt = (int)gridViewKqThang.GetFocusedRowCellValue("sTT");
            String name = (String)gridViewKqThang.GetFocusedRowCellValue("hoTen");
            String hanhkiem = (String)gridViewKqThang.GetFocusedRowCellValue("tenHanhKiem");
            double mieng = (double)gridViewKqThang.GetFocusedRowCellValue("diemMieng");
            double diem15 = (double)gridViewKqThang.GetFocusedRowCellValue("diem15p");
            double tiet = (double)gridViewKqThang.GetFocusedRowCellValue("diemTiet");
 

            txtSTT.Text = stt.ToString();
            txtHoTen.Text = name;
            txtHanhkiem.Text = hanhkiem;
            txtmieng.Text = mieng.ToString();
            txt15.Text = diem15.ToString();
            txttiet.Text = tiet.ToString();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int makq = (int)gridViewKqThang.GetFocusedRowCellValue("maKetQua");
            int mabangdiem = bus_ketquaht.get_mabangdiem_from_makq(makq);

            String hanhkiem = (String)txtHanhkiem.EditValue;
            double mieng = double.Parse(txtmieng.Text);
            double diem15 = double.Parse(txt15.Text);
            double tiet = double.Parse(txttiet.Text);

            BANGDIEM bd = new BANGDIEM()
            {
                maBangDiem = mabangdiem,
                diemMieng = mieng,
                diem15p = diem15,
                diemTiet = tiet,
            };

            KETQUAHOCTAP kqthang = new KETQUAHOCTAP() { hanhKiem = hanhkiem, maKetQua = makq };
            int rebd = bus_bangdiem.update(bd);
            if(rebd < 1)
            {
                MessageBox.Show("Có lỗi trong quá trình cập nhật Bảng điêm !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int rekq = bus_ketquaht.update_hanhkiem(kqthang);
            if (rekq < 1)
            {
                MessageBox.Show("Có lỗi trong quá trình cập nhật Hạnh kiểm !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Cập nhật thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _BindingSource();
        }
    }
}