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

namespace GUI
{
    public partial class frmKhoiLop : DevExpress.XtraEditors.XtraForm
    {
        public frmKhoiLop()
        {
            InitializeComponent();
        }

        private void frmKhoiLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLYHOCSINHDataSet.KHOILOP' table. You can move, or remove it, as needed.
            this.kHOILOPTableAdapter.Fill(this.qUANLYHOCSINHDataSet.KHOILOP);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.kHOILOPBindingSource.EndEdit();
                this.kHOILOPTableAdapter.Update(qUANLYHOCSINHDataSet.KHOILOP);
                MessageBox.Show("Lưu thành công !!!", "Thành công", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại: có lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.kHOILOPTableAdapter.Fill(this.qUANLYHOCSINHDataSet.KHOILOP);
        }
    }
}