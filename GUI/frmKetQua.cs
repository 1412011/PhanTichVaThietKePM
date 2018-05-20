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
    public partial class frmKetQua : Form
    {
        public frmKetQua()
        {
            InitializeComponent();
        }
        public static string TenKH;
        public static string TenKS1;
        DataTable dsKS = new DataTable();
        public static int KT_DangNhap = 0; //0: Chưa đăng nhập, 1: KH đã đăng nhập, 2:Nhân viên đăng nhập

        //Hàm niêm phong không được sửa. Chỉ cho phép xem dữ liệu.
        private void setGridViewEditable(bool b)
        {
            dataGridView1.AllowUserToAddRows = b;
            dataGridView1.ReadOnly = !b;
            dataGridView1.AllowUserToDeleteRows = b;

        }
        //chinh sua backcolor trong datagridview
        private void SetBackColorDataGirdView()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (i % 2 == 0)
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Silver;
                else
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
            }
        }

        //phan quyen nguoi dung
        private void BatTatButton()
        {
            if (KT_DangNhap == 0)
            {
                //btDangKi.Enabled = true;
                //btDangNhap.Enabled = true;
                //btDatPhong.Enabled = false;
                //btTimHoaDon.Enabled = false;
                //btLapHoaDon.Enabled = false;
                //btXuatBaoBieu.Enabled = false;
                //btDangXuat.Hide();
            }
            else if (KT_DangNhap == 1)
            {
                //btDangKi.Enabled = false;
                //btDangNhap.Enabled = false;
                //btDatPhong.Enabled = true;
                //dataGridView1.Columns["column1"].Visible = true;
                //btDangXuat.Show();
            }
            else
            {
                //btDangKi.Enabled = false;
                //btDangNhap.Enabled = false;
                //btTimHoaDon.Enabled = true;
                //btLapHoaDon.Enabled = true;
                //btXuatBaoBieu.Enabled = true;
                //btDangXuat.Show();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (KT_DangNhap == 1)
            {
                BatTatButton();// Tắt nút đăng kí
                label2.Text = "Chào mừng " + TenKH;
            }
            else if (KT_DangNhap == 2)
            {
                BatTatButton();
                label2.Text = "Chào mừng admin";
            }
            else if (KT_DangNhap == 0)
            {
                BatTatButton();
                label2.Text = "Bạn chưa đăng nhập?";
            }
        }

        private void btDatPhong_Click(object sender, EventArgs e)
        {
            //DatPhong form = new DatPhong();
            //form.Show();

        }

        //Load DS các khách sạn lên màn hình
        private void Form1_Load(object sender, EventArgs e)
        {
            //TimKiemTuDong();
            //dsKS = new DataTable();
            //dsKS = KHACHSAN_DAO.GetList();
            //dataGridView1.DataSource = dsKS;
            //SetBackColorDataGirdView();
            //setGridViewEditable(false);
            //dataGridView1.Columns["column1"].Visible = false;
        }

        //Button Tìm kếm và xử lý tìm kiếm
        private void btTimKiemTP_Click(object sender, EventArgs e)
        {
            if (tbThanhPho.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //dataGridView1.DataSource = null;
            DataTable dsKhachSan = new DataTable();
            //try
            //{
            //    if (rdGiaCa.Checked) //Kiểm tra Radio giá cả có đc chọn ko 
            //    {
            //        dsKhachSan = KHACHSAN_DAO.TimKiemKS(1, tbThanhPho.Text);
            //    }
            //    else if (rdHangSao.Checked)//Kiểm tra Radio hạng sao có đc chọn ko 
            //    {
            //        dsKhachSan = KHACHSAN_DAO.TimKiemKS(2, tbThanhPho.Text);
            //    }
            //    else if (!rdGiaCa.Checked && !rdHangSao.Checked)// KT ko nút nào đc chọn?
            //    {
            //        dsKhachSan = KHACHSAN_DAO.TimKiemKS(0, tbThanhPho.Text);
            //    }
            //    dataGridView1.DataSource = dsKhachSan;
            //    SetBackColorDataGirdView();
            //}
            //catch (SqlException ex)
            //{
            //    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}


        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
