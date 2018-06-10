﻿using System;
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
    public partial class frmLopHoc : DevExpress.XtraEditors.XtraForm
    {
        BUSGiaoVien bus_GiaoVien = new BUSGiaoVien();
        BUSLop bus_Lop = new BUSLop();
        BUSLop_HocSinh bus_LopHocSinh = new BUSLop_HocSinh();

        BindingSource bsgvcn = new BindingSource();

        public frmLopHoc()
        {
            InitializeComponent();
        }

        private void frmLopHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLYHOCSINHDataSet.HOCSINH' table. You can move, or remove it, as needed.
            this.hOCSINHTableAdapter.Fill(this.qUANLYHOCSINHDataSet.HOCSINH);
            // TODO: This line of code loads data into the 'qUANLYHOCSINHDataSet.LOP_HOCSINH' table. You can move, or remove it, as needed.
            this.lOP_HOCSINHTableAdapter.Fill(this.qUANLYHOCSINHDataSet.LOP_HOCSINH);
            // TODO: This line of code loads data into the 'qUANLYHOCSINHDataSet.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.qUANLYHOCSINHDataSet.LOP);
            // TODO: This line of code loads data into the 'qUANLYHOCSINHDataSet.NAMHOC' table. You can move, or remove it, as needed.
            this.nAMHOCTableAdapter.Fill(this.qUANLYHOCSINHDataSet.NAMHOC);

            // TODO: This line of code loads data into the 'qUANLYHOCSINHDataSet.KHOILOP' table. You can move, or remove it, as needed.
            this.kHOILOPTableAdapter.Fill(this.qUANLYHOCSINHDataSet.KHOILOP);

            _bindingSource();
        }

        private void _bindingSource()
        {

            bsgvcn.DataSource = bus_GiaoVien.get_all_GV_LOP();
            LookupGVCN.DataSource = bsgvcn;
            LookupGVCN.DisplayMember = "tenNguoiDung";
            LookupGVCN.ValueMember = "maNguoiDung";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(gridViewLop.FocusedRowHandle.ToString(), "Lỗi", MessageBoxButtons.OK);
            //if(gridViewLop.FocusedRowHandle < 0) return;
            try
            {
                this.Validate();
                this.lOPBindingSource.EndEdit();
                this.lOPTableAdapter.Update(qUANLYHOCSINHDataSet.LOP);
                MessageBox.Show("Lưu thành công !!!", "Thành công", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại: có lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
            frmLopHoc_Load(null, null);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmLopHoc_Load(null, null);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            gridViewLop.AddNewRow();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            int malop = (int)gridViewLop.GetFocusedRowCellValue("maLop");
            DialogResult result = MessageBox.Show("Bạn có chắc xóa mã lớp: "+ malop, "Xóa",MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;
            gridViewLop.DeleteRow(gridViewLop.FocusedRowHandle);
            toolStripButton1_Click(null, null);
        }

        private void gridControlLop_Click(object sender, EventArgs e)
        {

        }

        private void gridViewLop_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.RowHandle < 0) return;
            int malop = (int)gridViewLop.GetFocusedRowCellValue("maLop");
            if(malop>0)
            {
                LOP lop = new LOP() { maLop = malop };
                this.gridControlDANHSACH.DataSource = bus_LopHocSinh.get_list_LOPHOCSINH(lop);

            }
        }
    }
}