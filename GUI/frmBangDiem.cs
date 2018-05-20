using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmBangDiem : Form
    {
        public frmBangDiem()
        {
            InitializeComponent();
        }
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
    }
}
