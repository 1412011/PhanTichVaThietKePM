using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class DAOBoMon : ConnectorFactory
    {
        ConnectorFactory ccf = new ConnectorFactory();

        public DataTable get_unique(int id)
        {
            String sql = String.Format("SELECT* FROM BOMON WHERE maBoMon={0}", id);
            return ccf.getDatatable(sql);
        }
        public DataTable get_all()
        {
            String sql = String.Format("SELECT* FROM BOMON");
            return ccf.getDatatable(sql);
        }
        public int update(BOMON e)
        {
            String sql = String.Format("UPDATE BOMON " +
                "SET tenBoMon = N'{0}',soTietHoc = {1}, heSoMon = {2}, truongBoMon = {3} WHERE maBoMon={4}"
                , e.tenMonHoc, e.soTietHoc, e.heSoMon, e.truongBoMon, e.maBoMon);
            return ccf.excuteNonQuery(sql);
        }
        public int delete(int id)
        {
            String sql = String.Format("DELETE FROM BOMON WHERE maBoMon={0}", id);
            return ccf.excuteNonQuery(sql);
        }
        public int insert(BOMON e)
        {
            String sql = String.Format("INSERT INTO BOMON(tenBoMon, soTietHoc, heSoMon, truongBoMon) " +
                "VALUES(N'{0}', {1}, {2}, {3})", e.tenMonHoc, e.soTietHoc, e.heSoMon, e.truongBoMon);
            return ccf.excuteNonQuery(sql);
        }
        public DataTable get_unique_last()
        {
            String sql = String.Format("SELECT TOP 1 * FROM BOMON ORDER BY maBoMon DESC");
            return ccf.getDatatable(sql);
        }
    }
}
