using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class DAONguoiDung : ConnectorFactory
    {
        ConnectorFactory ccf = new ConnectorFactory();

        public DataTable get_unique(int id)
        {
            String sql = String.Format("SELECT* FROM NGUOIDUNG WHERE maNguoiDung={0}", id);
            return ccf.getDatatable(sql);
        }
        public DataTable get_all()
        {
            String sql = String.Format("SELECT* FROM NGUOIDUNG");
            return ccf.getDatatable(sql);
        }
        public int update(NGUOIDUNG ett)
        {
            String sql = String.Format("UPDATE NGUOIDUNG " +
                "SET(tenNguoiDung = N'{0}',gioiTinh = N'{1}',sDT = '{2}',email = '{3}',taiKhoan = '{4}',matKhau = '{5}')"
                , ett.tenNguoiDung, ett.gioiTinh, ett.sDT, ett.email, ett.taiKhoan, ett.matKhau);
            return ccf.excuteNonQuery(sql);
        }
        public int delete(int id)
        {
            String sql = String.Format("DELETE FROM NGUOIDUNG WHERE maNguoiDung={0}", id);
            return ccf.excuteNonQuery(sql);
        }
        public int insert(NGUOIDUNG e)
        {
            String sql = String.Format("INSERT INTO NGUOIDUNG(tenNguoiDung,gioiTinh,ngaySinh,sDT,diaChi,email,taiKhoan,matKhau) " +
                "VALUES(N'{0}',N'{1}','{2}', '{3}', '{4}', '{5}', '{6}', {7})", e.tenNguoiDung,e.gioiTinh,e.ngaySinh,e.sDT,e.diaChi,e.email,e.taiKhoan,e.matKhau);
            return ccf.excuteNonQuery(sql);
        }
        public DataTable get_unique_last()
        {
            String sql = String.Format("SELECT TOP 1 * FROM NGUOIDUNG ORDER BY maNguoiDung DESC");
            return ccf.getDatatable(sql);
        }
    }
}
