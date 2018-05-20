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
            return new NGUOIDUNG()
            {
                maNguoiDung = (row["maNguoiDung"] == DBNull.Value) ? (-1) : (int)row["maNguoiDung"],
                tenNguoiDung = (String)row["tenNguoiDung"],
                ngaySinh = (DateTime)row["ngaySinh"],
                gioiTinh = (String)row["gioiTinh"],
                email = (String)row["email"],
                taiKhoan = (String)row["taiKhoan"],
                matKhau = (String)row["matKhau"],

            };
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
        public int dangnhap(string text1, string text2)
        {
            DataTable rs = dao_nguoidung.DangNhap(text1, text2);
            return rs.Rows.Count;
        }
    }
}
