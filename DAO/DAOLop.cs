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
                "From LOP l" +
                "");

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
         public DataTable get_Lop_KL_NH(KHOILOP k, NAMHOC n)
        {
            String sql = String.Format("select * from LOP where khoiLop = N'{0}' AND namHoc = N'{1}'",k.tenKhoiLop,n.tenNamHoc);
            return ccf.getDatatable(sql);
        }
    }
}
