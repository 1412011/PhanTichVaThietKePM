using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class BUSLop_HocSinh
    {
        DAOLop_HocSinh dao_LopHocsinh = new DAOLop_HocSinh();
        public DataTable get_list_LOPHOCSINH(LOP l)
        {
            if (l == null) // get full
            {
                return dao_LopHocsinh.get_AllList_DanhSachLOP();
            }
            else return dao_LopHocsinh.get_List_DanhSachLOP(l);
        }
    }
}
