using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class DAOLop_HocSinh
    {
        ConnectorFactory ccf = new ConnectorFactory();
        public DataTable get_List_DanhSachLOP(LOP l)
        {
            String sql = String.Format("SELECT * FROM LOP_HOCSINH WHERE maLop = {0}", l.maLop);
            return ccf.getDatatable(sql);
        }
        public DataTable get_AllList_DanhSachLOP()
        {
            String sql = String.Format("SELECT * FROM LOP_HOCSINH");
            return ccf.getDatatable(sql);
        }

        public DataTable get_listHS_to_LOP(LOP l)
        {
            String sql = String.Format("select hs.maHocSinh, hoTen, gioiTinh, ngaySinh from LOP_HOCSINH lh, HOCSINH hs " +
                "where lh.maHocSinh = hs.maHocSinh AND lh.maLop = N'{0}'",l.maLop);
            return ccf.getDatatable(sql);
        }

        public int insert(LOP_HOCSINH lh)
        {
            String sql = String.Format("INSERT INTO LOP_HOCSINH VALUES({0},{1},{2})", lh.sTT, lh.maLop, lh.maHocSinh);
            return ccf.excuteNonQuery(sql);
        }

        public DataTable get_STT_Max_to_Lop(LOP l)
        {
            String sql = String.Format("SELECT TOP 1 sTT FROM LOP_HOCSINH WHERE maLop = {0} ORDER BY sTT DESC", l.maLop);
            return ccf.getDatatable(sql);
        }

        public DataTable get_count_sisi_lop(LOP l)
        {
            String sql = String.Format("Select COUNT(maHocSinh) as SiSo From LOP_HOCSINH Where maLop = {0}", l.maLop);
            return ccf.getDatatable(sql);
        }


        public int delete(int id)
        {
            String sql = String.Format("DELETE FROM LOP_HOCSINH WHERE maLop_HS = {0}",id);
            return ccf.excuteNonQuery(sql);
        }
    }
}
