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
    public class BUSLop
    {
        DAOLop dao_Lop = new DAOLop();

        public DataTable get_all_Lop_info()
        {
            return dao_Lop.get_all_full_info();
        }

        public DataTable get_all_KhoiLop()
        {
            return dao_Lop.get_all_Khoilop();
        }

        public DataTable get_all_NamHoc()
        {
            return dao_Lop.get_all_NamHoc();
        }

        public DataTable get_LOP_Khoilop_namHoc(KHOILOP k, NAMHOC n)
        {
            return dao_Lop.get_Lop_KL_NH(k, n);
        }
    }
}
