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
    public class BUSNguoiDung
    {
        DAONguoiDung dao_nguoidung = new DAONguoiDung();

        public NGUOIDUNG get_unique(int id)
        {
            DataTable dt = dao_nguoidung.get_unique(id);
            int countrows = dt.Rows.Count;

            if (countrows <= 0) return null; //data chưa có dòng nào, return
            DataRow row = dt.Rows[0];
            return ConvertNGUOIDUNG(row);
        }
        public int get_unique_last()
        {
            DataTable dt = dao_nguoidung.get_unique_last();
            int countrows = dt.Rows.Count;
            if (countrows <= 0) return -1; //data chưa có dòng nào, return
            return (int)dt.Rows[0]["maNguoiDung"];
        }
        public int delete(int id)
        {
            return dao_nguoidung.delete(id);
        }
        public int update(NGUOIDUNG entity)
        {
            return dao_nguoidung.update(entity);
        }
        public int insert(NGUOIDUNG entity)
        {
            return dao_nguoidung.insert(entity);
        }

        public NGUOIDUNG login(NGUOIDUNG nd)
        {
            DataTable dt = dao_nguoidung.login(nd);
            int countrows = dt.Rows.Count;

            if (countrows <= 0) return null; //data chưa có dòng nào, return
            DataRow row = dt.Rows[0];
            return ConvertNGUOIDUNG(row);
        }

        private NGUOIDUNG ConvertNGUOIDUNG(DataRow row)
        {
            return new NGUOIDUNG()
            {
                maNguoiDung = (row["maNguoiDung"] == DBNull.Value) ? (0) : (int)row["maNguoiDung"],
                tenNguoiDung = (row["tenNguoiDung"] == DBNull.Value) ? ("") : (String)row["tenNguoiDung"],
                ngaySinh = (row["ngaySinh"] == DBNull.Value) ? (new DateTime(0, 0, 0)) : (DateTime)row["ngaySinh"],
                gioiTinh = (row["gioiTinh"] == DBNull.Value) ? ("") : (String)row["gioiTinh"],
                email = (row["email"] == DBNull.Value) ? ("") : (String)row["email"],
                taiKhoan = (row["taiKhoan"] == DBNull.Value) ? ("") : (String)row["taiKhoan"],
                matKhau = (row["matKhau"] == DBNull.Value) ? ("") : (String)row["matKhau"],
                diaChi = (row["diaChi"] == DBNull.Value) ? (0) : (int)row["diaChi"],
            };
        }
    }
}
