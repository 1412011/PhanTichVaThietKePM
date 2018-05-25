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
    public partial class frmBoMon : DevExpress.XtraEditors.XtraForm
    {
        BindingSource bs = new BindingSource();
        public frmBoMon()
        {
            InitializeComponent();
        }

        private void frmBoMon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLYHOCSINHDataSet1.BOMON' table. You can move, or remove it, as needed.
            this.bOMONTableAdapter1.Fill(this.qUANLYHOCSINHDataSet1.BOMON);


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.bOMONBindingSource1.EndEdit();
                this.bOMONTableAdapter1.Update(qUANLYHOCSINHDataSet1.BOMON);
                MessageBox.Show("Lưu thành công !!!", "Thành công", MessageBoxButtons.OK);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thất bại: có lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmBoMon_Load(null, null);
        }
    }
}