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
    public class BUSMon_Lop
    {
        DAOMon_Lop dao_monlop = new DAOMon_Lop();
        public MON_LOP get_MonLop_to_MON_LOP(BOMON b, LOP l)
        {
            if (b == null || l == null) return null;
            DataTable dt = dao_monlop.get_MonLop_to_MON_LOP(b, l);
            if (dt.Rows.Count == 0) return null;

            return convertMON_LOP(dt.Rows[0]);
        }

        private MON_LOP convertMON_LOP(DataRow row)
        {
            return new MON_LOP()
            {
                maMon_Lop = (row["maMon_Lop"] == DBNull.Value) ? (0) : (int)row["maMon_Lop"],
                maLop = (row["maLop"] == DBNull.Value) ? (0) : (int)row["maLop"],
                maMon = (row["maMon"] == DBNull.Value) ? (0) : (int)row["maMon"],
                giaoVienPhuTrach = (row["giaoVienPhuTrach"] == DBNull.Value) ? (0) : (int)row["giaoVienPhuTrach"],
            };
        }
    }
}
