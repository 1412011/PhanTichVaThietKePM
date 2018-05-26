using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAOLop
    {
        ConnectorFactory ccf = new ConnectorFactory();
        public DataTable get_all_full_info()
        {
            String sql = String.Format("select maLop, tenLop, siSo, giaoVienCN, khoiLop, namHoc " +
                "From LOP l, KHOILOP kh, NAMHOC nh, GIAOVIEN gv " +
                "WHERE l.khoiLop = kh.tenKhoiLop AND l.namHoc = nh.tenNamHoc AND l.giaoVienCN = gv.maNguoiDung");

            return ccf.getDatatable(sql);
        }

        public DataTable get_all_Khoilop()
        {
            String sql = String.Format("Select tenKhoiLop From KHOILOP");

            return ccf.getDatatable(sql);
        }
        public DataTable get_all_NamHoc()
        {
            String sql = String.Format("Select tenNamHoc From NAMHOC");

            return ccf.getDatatable(sql);
        }

    }
}
