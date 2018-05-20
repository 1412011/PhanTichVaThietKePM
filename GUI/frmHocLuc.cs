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
    public partial class frmHocLuc : DevExpress.XtraEditors.XtraForm
    {
        public frmHocLuc()
        {
            InitializeComponent();
        }

        private void frmHocLuc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLYHOCSINHDataSet.HOCLUC' table. You can move, or remove it, as needed.
            this.hOCLUCTableAdapter.Fill(this.qUANLYHOCSINHDataSet.HOCLUC);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.hOCLUCBindingSource.EndEdit();
                this.hOCLUCTableAdapter.Update(qUANLYHOCSINHDataSet.HOCLUC);
                MessageBox.Show("Lưu thành công !!!", "Thành công", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại: có lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmHocLuc_Load(null, null);
        }
    }
}