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
    public partial class frmLopHoc : DevExpress.XtraEditors.XtraForm
    {
        BUSGiaoVien bus_GiaoVien = new BUSGiaoVien();
        BUSLop bus_Lop = new BUSLop();
        BindingSource bs = new BindingSource();
        BindingSource bsgvcn = new BindingSource();

        public frmLopHoc()
        {
            InitializeComponent();
        }

        private void frmLopHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLYHOCSINHDataSet.NAMHOC' table. You can move, or remove it, as needed.
            this.nAMHOCTableAdapter.Fill(this.qUANLYHOCSINHDataSet.NAMHOC);
            // TODO: This line of code loads data into the 'qUANLYHOCSINHDataSet.NAMHOC' table. You can move, or remove it, as needed.
            this.nAMHOCTableAdapter.Fill(this.qUANLYHOCSINHDataSet.NAMHOC);
            // TODO: This line of code loads data into the 'qUANLYHOCSINHDataSet.KHOILOP' table. You can move, or remove it, as needed.
            this.kHOILOPTableAdapter.Fill(this.qUANLYHOCSINHDataSet.KHOILOP);
            _bindingSource();
        }

        private void _bindingSource()
        {
            bs.DataSource = bus_Lop.get_all_Lop_info();
            gridControlLop.DataSource = bs;

            bsgvcn.DataSource = bus_GiaoVien.get_all_GV_LOP();
            LookupGVCN.DataSource = bsgvcn;
            LookupGVCN.DisplayMember = "tenNguoiDung";
            LookupGVCN.ValueMember = "maNguoiDung";
        }
    }
}