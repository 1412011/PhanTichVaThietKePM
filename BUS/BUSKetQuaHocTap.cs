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
    public class BUSKetQuaHocTap
    {
        DAOKetQuaHocTap dao_ketquaht = new DAOKetQuaHocTap();
        public DataTable get_list_full_info(int thang, int loai, MON_LOP ml)
        {
            return dao_ketquaht.get_list_full_info(thang, loai, ml);
        }

        public int get_mabangdiem_from_makq(int id)
        {
            DataTable dt = dao_ketquaht.get_unique(id);
            if (dt.Rows.Count == 0) return 0;
            return (dt.Rows[0]["maBangDiem"] == DBNull.Value) ? (0) : (int)dt.Rows[0]["maBangDiem"];
        }

        public int update_hanhkiem(KETQUAHOCTAP k)
        {
            return dao_ketquaht.update_hanhkiem(k);
        }
    }
}
