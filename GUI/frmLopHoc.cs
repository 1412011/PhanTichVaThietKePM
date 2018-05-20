using BUS;
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
    public partial class frmLopHoc : DevExpress.XtraEditors.XtraForm
    {
        public frmLopHoc()
        {
            InitializeComponent();
        }
<<<<<<< HEAD:GUI/frmLopHoc.cs
=======
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BUSGiaoVien bus = new BUSGiaoVien();
            string namhoc = textBox1.Text;
            string hocky = textBox2.Text;
            string maHS = textBox3.Text;
            grvDanhSach.DataSource = bus.getBangDiem(namhoc, hocky, maHS);
        }
>>>>>>> eca7c7db6d230c53211bdcb082c565e3685241e0:GUI/frmBangDiem.cs
    }
}