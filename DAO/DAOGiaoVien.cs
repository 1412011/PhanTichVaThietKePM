using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class DAOGiaoVien : ConnectorFactory
    {
        ConnectorFactory ccf = new ConnectorFactory();

        public DataTable get_unique(int id)
        {
            String sql = String.Format("SELECT* FROM GIAOVIEN WHERE maNguoiDung={0}", id);
            return ccf.getDatatable(sql);
        }
        public DataTable get_all()
        {
            String sql = String.Format("SELECT* FROM GIAOVIEN");
            return ccf.getDatatable(sql);
        }
        public int update(GIAOVIEN ett)
        {
            String sql = String.Format("UPDATE GIAOVIEN SET monDay={0} WHERE maNguoiDung = {1}",ett.monDay,ett.maNguoiDung);
            return ccf.excuteNonQuery(sql);
        }
        public int delete(int id)
        {
            String sql = String.Format("DELETE FROM GIAOVIEN WHERE maNguoiDung={0}", id);
            return ccf.excuteNonQuery(sql);
        }
        public int insert(GIAOVIEN e)
        {
            String sql = String.Format("INSERT INTO GIAOVIEN VALUES({0},{1})",e.monDay, e.maNguoiDung);
            return ccf.excuteNonQuery(sql);
        }
        public DataTable get_unique_last()
        {
            String sql = String.Format("SELECT TOP 1 * FROM GIAOVIEN ORDER BY maNguoiDung DESC");
            return ccf.getDatatable(sql);
        }
        // add new operation
        public DataTable get_all_full_info()
        {
            String sql = String.Format("select gv.maNguoiDung, tenNguoiDung, bm.tenMonHoc, gioiTinh, ngaySinh, sDT, email, taiKhoan, matKhau, maDiaChi, soNha, duong, xa, huyen, tinh " +
                "FROM BoMon bm, GIAOVIEN gv, NGUOIDUNG ng, DIACHI dc " +
                "WHERE bm.maBoMon = gv.monDay AND ng.maNguoiDung = gv.maNguoiDung AND dc.maDiaChi = ng.diaChi");

            return ccf.getDatatable(sql);
        }
    }
}
