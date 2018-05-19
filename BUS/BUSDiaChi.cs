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
  
    public class BUSDiaChi
    {
        DAODiaChi dao_DiaChi = new DAODiaChi();

        public DIACHI get_unique(int id)
        {
            DataTable dt = dao_DiaChi.get_unique_DiaChi(id);
            int countrows = dt.Rows.Count;

            if (countrows <= 0) return null; //data chưa có dòng nào, return
            DataRow row = dt.Rows[0];
            return new DIACHI()
            {
                maDiaChi = (row["maDiaChi"] == DBNull.Value) ? (-1) : (int)row["maDiaChi"],
                soNha = (String)row["soNha"],
                duong = (String)row["duong"],
                xa = (String)row["xa"],
                huyen = (String)row["huyen"],
                tinh = (String)row["tinh"]
            };
        }
        public int get_unique_last()
        {
            DataTable dt = dao_DiaChi.get_DiaChi_last();
            int countrows = dt.Rows.Count;
            if (countrows <= 0) return -1; //data chưa có dòng nào, return
            return (int)dt.Rows[0]["maDiaChi"];
        }
        public int delete(int id)
        {
            return dao_DiaChi.delete(id);
        }
        public int update(DIACHI entity)
        {
            return dao_DiaChi.update(entity);
        }
        public int insert(DIACHI entity)
        {
            return dao_DiaChi.insert(entity);
        }
    }
}
