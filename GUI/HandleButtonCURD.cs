using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DevExpress.XtraEditors;

namespace GUI
{
    public class HandleButtonCURD 
    {

        public void _Handle_button_Them(SimpleButton btnThem, SimpleButton btnSua, SimpleButton btnLuu, SimpleButton btnXoa)
        {
            _Enable_Button(btnThem);
            _Enable_Button(btnLuu);
            _Enable_Button(btnXoa, false);
            _Enable_Button(btnSua, false);
        }
        public void _Handle_button_GridControl(SimpleButton btnThem, SimpleButton btnSua, SimpleButton btnLuu, SimpleButton btnXoa)
        {
            _Enable_Button(btnThem);
            _Enable_Button(btnSua);
            _Enable_Button(btnXoa);
            _Enable_Button(btnLuu, false);
        }
        public void _Handle_button_Sua(SimpleButton btnThem, SimpleButton btnSua, SimpleButton btnLuu, SimpleButton btnXoa)
        {
            _Enable_Button(btnLuu);
            _Enable_Button(btnThem, false);
            _Enable_Button(btnXoa, false);
            _Enable_Button(btnSua, false);
        }
        public void _Handle_button_Naplai(SimpleButton btnThem, SimpleButton btnSua, SimpleButton btnLuu, SimpleButton btnXoa)
        {
            _Enable_Button(btnLuu, false);
            _Enable_Button(btnThem);
            _Enable_Button(btnXoa, false);
            _Enable_Button(btnSua, false);
        }
        public void _Enable_Button(SimpleButton btn, bool trangthai = true)
        {
            if (!btn.Enabled == trangthai) btn.Enabled = trangthai;
        }
    }
}
