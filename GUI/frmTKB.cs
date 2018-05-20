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
    public partial class frmTKB : Form
    {
        public frmTKB()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BUSHocSinh busHS = new BUSHocSinh();
            gtkb.DataSource = busHS.getTKB(textBox1.Text);
        }
    }
}
