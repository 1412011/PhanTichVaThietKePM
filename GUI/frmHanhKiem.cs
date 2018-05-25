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
    public partial class frmHanhKiem : DevExpress.XtraEditors.XtraForm
    {
        public frmHanhKiem()
        {
            InitializeComponent();
        }

        private void frmHanhKiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLYHOCSINHDataSet1.HANHKIEM' table. You can move, or remove it, as needed.
            this.hANHKIEMTableAdapter1.Fill(this.qUANLYHOCSINHDataSet1.HANHKIEM);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.hANHKIEMBindingSource.EndEdit();
                this.hANHKIEMTableAdapter1.Update(qUANLYHOCSINHDataSet1.HANHKIEM);
                MessageBox.Show("Lưu thành công !!!", "Thành công", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại: có lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.hANHKIEMTableAdapter.Fill(this.qUANLYHOCSINHDataSet.HANHKIEM);
        }
    }
}