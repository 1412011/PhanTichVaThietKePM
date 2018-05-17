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
    public class BUSGiaoVien
    {
        DAOGiaoVien dao_GiaoVien = new DAOGiaoVien();

        public GIAOVIEN get_unique(int id)
        {
            DataTable dt = dao_GiaoVien.get_unique(id);
            int countrows = dt.Rows.Count;

            if (countrows <= 0) return null; //data chưa có dòng nào, return
            DataRow row = dt.Rows[0];
            return new GIAOVIEN()
            {
                maNguoiDung = (int)row["maNguoiDung"],
                monDay = (int)row["monDay"],
            };
        }
        public int get_unique_last()
        {
            DataTable dt = dao_GiaoVien.get_unique_last();
            int countrows = dt.Rows.Count;
            if (countrows <= 0) return -1; //data chưa có dòng nào, return
            return (int)dt.Rows[0]["maNguoiDung"];
        }
        public int delete(int id)
        {
            return dao_GiaoVien.delete(id);
        }
        public int update(GIAOVIEN entity)
        {
            return dao_GiaoVien.update(entity);
        }
        public int insert(GIAOVIEN entity)
        {
            return dao_GiaoVien.insert(entity);
        }

        // add new operation
        public DataTable get_all_full_info()
        {
            return dao_GiaoVien.get_all_full_info();
        }
    }
}
