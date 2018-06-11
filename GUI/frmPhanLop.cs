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
using BUS;
using DTO;
namespace GUI
{
    public partial class frmPhanLop : DevExpress.XtraEditors.XtraForm
    {
        BUSLop bus_Lop = new BUSLop();
        BUSLop_HocSinh bus_lop_hs = new BUSLop_HocSinh();
        BUSHocSinh bus_hocsinh = new BUSHocSinh();
        List<HOCSINH> DanhSachThayDoi = new List<HOCSINH>();
        public frmPhanLop()
        {
            InitializeComponent();
        }

        private void frmPhanLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLYHOCSINHDataSet.KHOILOP' table. You can move, or remove it, as needed.
            this.kHOILOPTableAdapter.Fill(this.qUANLYHOCSINHDataSet.KHOILOP);
            // TODO: This line of code loads data into the 'qUANLYHOCSINHDataSet.NAMHOC' table. You can move, or remove it, as needed.
            this.nAMHOCTableAdapter.Fill(this.qUANLYHOCSINHDataSet.NAMHOC);

        }

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        #region xử lý check box
        private void checked_dannhsachlop()
        {
            if(rbdshs.Checked == true) rbdshs.Checked = false;
            groupControldanhsachlop.Visible = true;
            panelControldanhsachhocsinh.Visible = false;
        }
        private void checked_dannhsachHS()
        {
            if (rbdslop.Checked == true)  rbdslop.Checked = false;
            groupControldanhsachlop.Visible = false;
            panelControldanhsachhocsinh.Visible = true;
        }

        private void rbdslop_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void rbdslop_Click(object sender, EventArgs e)
        {
            checked_dannhsachlop();
            gridControlHocSinhLopCu.DataSource = null;
        }
        private void rbdshs_Click(object sender, EventArgs e)
        {
            checked_dannhsachHS();
            gridControlHocSinhLopCu.DataSource = bus_hocsinh.get_all();
        }
        #endregion

        private void lookUpEditNamHocCu_EditValueChanged(object sender, EventArgs e)
        {
            load_lookup_LopCu();
        }
        private void lookUpEditKhoiLopCu_EditValueChanged(object sender, EventArgs e)
        {
            load_lookup_LopCu();
        }
        private void load_lookup_LopCu()
        {
            String khoilop = (String)lookUpEditKhoiLopCu.EditValue;
            if (khoilop == null) return;
            KHOILOP kl = new KHOILOP() { tenKhoiLop = khoilop };

            String namhoc = (String)lookUpEditNamHocCu.EditValue;
            if (namhoc == null) return;
            NAMHOC nh = new NAMHOC() { tenNamHoc = namhoc };

            lookUpEditLopCu.Properties.DataSource = bus_Lop.get_LOP_Khoilop_namHoc(kl, nh);
            lookUpEditLopCu.ItemIndex = 0;
        }
        private void lookUpEditLopCu_EditValueChanged(object sender, EventArgs e)
        {
            int malop = (int)lookUpEditLopCu.EditValue;
            if (malop <= 0) return;
            gridControlHocSinhLopCu.DataSource = bus_lop_hs.get_listHS_to_LOP(new LOP() { maLop = malop });
        }

        private void lookUpEditNamHocMoi_EditValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show((String)lookUpEditKhoiLopMoi.EditValue);
            load_lookupedit_LopMoi();
        }

        private void lookUpEditKhoiLopMoi_EditValueChanged(object sender, EventArgs e)
        {
            load_lookupedit_LopMoi();
        }
        private void load_lookupedit_LopMoi()
        {
            String khoilop = (String)lookUpEditKhoiLopMoi.EditValue;
            if (khoilop == null) return;
            KHOILOP kl = new KHOILOP() { tenKhoiLop = khoilop };

            String namhoc = (String)lookUpEditNamHocMoi.EditValue;
            if (namhoc == null) return;
            NAMHOC nh = new NAMHOC() { tenNamHoc = namhoc };
                       
            lookUpEditLopmoi.Properties.DataSource = bus_Lop.get_LOP_Khoilop_namHoc(kl, nh);
            lookUpEditLopmoi.ItemIndex = 0;
        }

        private void lookUpEditLopmoi_EditValueChanged(object sender, EventArgs e)
        {
            int malop = (int)lookUpEditLopmoi.EditValue;
            if (malop <= 0) return;
            DataTable dt = bus_lop_hs.get_listHS_to_LOP(new LOP() { maLop = malop });

            gridControlHocSinhLopMoi.DataSource = dt;
        }
        private void _Add_datarow_to_datatable(DataTable dt, HOCSINH hsnew)
        {
            DataRow rownew = dt.NewRow();
            _Convert_OBject_To_DataRow(hsnew, rownew);
            dt.Rows.Add(rownew);
        }
        private void _Convert_OBject_To_DataRow(HOCSINH hsnew, DataRow rownew)
        {
            rownew["maHocSinh"] = hsnew.maHocSinh;
            rownew["hoTen"] = hsnew.hoTen;
            rownew["gioiTinh"] = hsnew.gioiTinh;
            rownew["ngaySinh"] = hsnew.ngaySinh;
        }
        private void gridViewHocSinhlopCu_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
        }

        private void gridViewHocSinhlopCu_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
        }

        private void btnThemmot_Click(object sender, EventArgs e)
        {
            //int id = (int)gridViewHocSinhlopCu.GetFocusedRowCellValue("maHocSinh");
            //MessageBox.Show(id.ToString());
            Object ml = lookUpEditLopmoi.EditValue;
            if (ml == null)
            {
                MessageBox.Show("Vui lòng Chọn Lớp Mới để thêm !!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int malop = (int)lookUpEditLopmoi.EditValue;
            DataTable dt = bus_lop_hs.get_listHS_to_LOP(new LOP() { maLop = malop });
            //

            int[] dsId = gridViewHocSinhlopCu.GetSelectedRows();
            foreach(int i in dsId)
            {
                DataRowView drv = (DataRowView)gridViewHocSinhlopCu.GetRow(i);
                HOCSINH hs = new HOCSINH()
                {
                    maHocSinh = (int)drv["maHocSinh"],
                    hoTen = (String)drv["hoTen"],
                    gioiTinh = (String)drv["gioiTinh"],
                    ngaySinh = (DateTime)drv["ngaySinh"],
                };
                if (!ischeck_contain_datatable(dt,hs))
                {
                    if(!ischeck_contain_IList(DanhSachThayDoi, hs))
                    {
                        DanhSachThayDoi.Add(hs);
                    }
                }
            }
            
            foreach (HOCSINH h in DanhSachThayDoi)
            {
                _Add_datarow_to_datatable(dt, h);
            }
            gridControlHocSinhLopMoi.DataSource = dt;
        }

        #region hàm kiểm tra
        private bool ischeck_contain_datatable(DataTable dt, HOCSINH hs)
        {
            foreach(DataRow r in dt.Rows)
            {
                if (hs.maHocSinh == (int)r["maHocSinh"]) return true;
            }
            return false;
        }
        private bool ischeck_contain_IList(List<HOCSINH> l, HOCSINH hs)
        {
            foreach(HOCSINH h in l)
            {
                if (h.maHocSinh == hs.maHocSinh) return true;
            }
            return false;
        }
        #endregion

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DanhSachThayDoi.Clear();
            Object ml = lookUpEditLopmoi.EditValue;
            if (ml == null)
            {
                return;
            }
            int malop = (int)lookUpEditLopmoi.EditValue;
            gridControlHocSinhLopMoi.DataSource = bus_lop_hs.get_listHS_to_LOP(new LOP() { maLop = malop });
        }

        private void btnLuuThayDoi_Click(object sender, EventArgs e)
        {
            Object ml = lookUpEditLopmoi.EditValue;
            if (ml == null)
            {
                MessageBox.Show("Vui lòng Chọn Lớp Mới để thêm !!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int malop = (int)ml;
            int sttmax = bus_lop_hs.get_stt_max_lop(new LOP() { maLop = malop });
            int success = 0;
            foreach(HOCSINH hs in DanhSachThayDoi)
            {
                LOP_HOCSINH lh = new LOP_HOCSINH()
                {
                    sTT = ++sttmax,
                    maLop = malop,
                    maHocSinh = hs.maHocSinh,
                };
                int re = bus_lop_hs.insert(lh);
                if (re < 1)
                {
                    success++;
                    MessageBox.Show("Có lỗi trong quá trình insert !!!", "Lỗi", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            if(success == 0 && DanhSachThayDoi.Count>0) MessageBox.Show("Lưu tất cả thay đổi thành công ", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DanhSachThayDoi.Clear();
        }

        private void lookUpEditLopmoi_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (DanhSachThayDoi.Count() > 0)
            {
                DialogResult rs = MessageBox.Show("Bạn có muốn lưu những thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    btnLuuThayDoi_Click(null, null);
                }
            }

        }

        private void btnThemTatca_Click(object sender, EventArgs e)
        {
            Object ml = lookUpEditLopCu.EditValue;
            if (ml == null)
            {
                MessageBox.Show("Vui lòng Nguồn Danh sách học sinh để thêm !!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            gridViewHocSinhlopCu.SelectAll();
            btnThemmot_Click(null, null);
        }
    }
}