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

        public DataTable get_listHS_to_LOP(LOP l)
        {
            return dao_LopHocsinh.get_listHS_to_LOP(l);
        }

        public int insert(LOP_HOCSINH lh)
        {
            return dao_LopHocsinh.insert(lh);
        }

        public int get_stt_max_lop(LOP l)
        {
            DataTable dt = dao_LopHocsinh.get_STT_Max_to_Lop(l);
            if (dt.Rows.Count == 0) return 0;

            return (int)dt.Rows[0]["sTT"];
        }

        public int get_count_sisi_lop(LOP l)
        {
            DataTable dt = dao_LopHocsinh.get_count_sisi_lop(l);
            if (dt.Rows.Count == 0) return 0;
            return (int)dt.Rows[0]["SiSo"];
        }
        public int delete(int id)
        {
            return dao_LopHocsinh.delete(id);
        }
    }
}
