using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class DAODiaChi : ConnectorFactory
    {
        ConnectorFactory ccf = new ConnectorFactory();

        public DataTable get_unique_DiaChi(int id)
        {
            String sql = String.Format("SELECT* FROM DIACHI WHERE maDiaChi={0}",id);
            return ccf.getDatatable(sql);
        }
        public DataTable get_all_DiaChi()
        {
            String sql = String.Format("SELECT* FROM DIACHI");
            return ccf.getDatatable(sql);
        }
        public int update(DIACHI dc)
        {
            String sql = String.Format("UPDATE DIACHI " +
                "SET soNha = N'{0}',duong = N'{1}',xa = N'{2}',huyen = N'{3}',tinh = N'{4}' WHERE maDiaChi={5}"
                ,dc.soNha, dc.duong, dc.xa, dc.huyen, dc.tinh, dc.maDiaChi);
            return ccf.excuteNonQuery(sql);
        }
        public int delete(int id)
        {
            String sql = String.Format("DELETE FROM DIACHI WHERE maDiaChi={0}",id);
            return ccf.excuteNonQuery(sql);
        }
        public int insert(DIACHI dc)
        {
            String sql = String.Format("INSERT INTO DIACHI(soNha,duong,xa,huyen,tinh) " +
                "VALUES(N'{0}',N'{1}',N'{2}', N'{3}', N'{4}')", dc.soNha, dc.duong, dc.xa, dc.huyen, dc.tinh);
            return ccf.excuteNonQuery(sql);
        }
        public DataTable get_DiaChi_last()
        {
            String sql = String.Format("SELECT TOP 1 * FROM DIACHI ORDER BY maDiaChi DESC");
            return ccf.getDatatable(sql);
        }
    }
}
