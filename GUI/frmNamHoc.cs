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
    public partial class frmNamHoc : DevExpress.XtraEditors.XtraForm
    {
        public frmNamHoc()
        {
            InitializeComponent();
        }

        private void frmNamHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLYHOCSINHDataSet1.NAMHOC' table. You can move, or remove it, as needed.
            this.nAMHOCTableAdapter1.Fill(this.qUANLYHOCSINHDataSet1.NAMHOC);

        }

        private void toolStripButtonNapLai_Click(object sender, EventArgs e)
        {
            frmNamHoc_Load(null, null);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButtonLuu_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.nAMHOCBindingSource.EndEdit();
                this.nAMHOCTableAdapter1.Update(qUANLYHOCSINHDataSet1.NAMHOC);
                MessageBox.Show("Lưu thành công !!!", "Thành công", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại: có lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
        }
    }
}