using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class DAOHocSinh
    {
        ConnectorFactory ccf = new ConnectorFactory();

        public DataTable get_unique(int id)
        {
            String sql = String.Format("SELECT* FROM HOCSINH WHERE maHocSinh={0}", id);
            return ccf.getDatatable(sql);
        }
        public DataTable get_all()
        {
            String sql = String.Format("SELECT* FROM HOCSINH");
            return ccf.getDatatable(sql);
        }
        public int update(HOCSINH ett)
        {
            String sql = String.Format("UPDATE HOCSINH " +
                "SET hoTen = N'{0}',gioiTinh = N'{1}',ngaySinh = '{2}',noiSinh = N'{3}',hoTenCha = N'{4}',ngheNghiepCha = N'{5}', hoTenMe = N'{6}', ngheNghiepMe = N'{7}' " +
                " WHERE maHocSinh={8}"
                , ett.hoTen,ett.gioiTinh,ett.ngaySinh,ett.noiSinh,ett.hoTenCha,ett.ngheNghiepCha,ett.hoTenMe,ett.ngheNghiepMe,ett.maHocSinh);
            return ccf.excuteNonQuery(sql);
        }
        public int delete(int id)
        {
            String sql = String.Format("DELETE FROM HOCSINH WHERE maHocSinh={0}", id);
            return ccf.excuteNonQuery(sql);
        }
        public int insert(HOCSINH ett)
        {
            String sql = String.Format("INSERT INTO HOCSINH(hoTen,gioiTinh ,ngaySinh,noiSinh,hoTenCha,ngheNghiepCha, hoTenMe, ngheNghiepMe) " +
                "VALUES(N'{0}',N'{1}','{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}')"
                , ett.hoTen, ett.gioiTinh, ett.ngaySinh, ett.noiSinh, ett.hoTenCha, ett.ngheNghiepCha, ett.hoTenMe, ett.ngheNghiepMe);
            return ccf.excuteNonQuery(sql);
        }
        public DataTable get_unique_last()
        {
            String sql = String.Format("SELECT TOP 1 * FROM HOCSINH ORDER BY maNguoiDung DESC");
            return ccf.getDatatable(sql);
        }
    }
}
