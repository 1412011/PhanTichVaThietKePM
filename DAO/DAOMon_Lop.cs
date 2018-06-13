using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAOMon_Lop
    {
        ConnectorFactory ccf = new ConnectorFactory();

        public DataTable get_MonLop_to_MON_LOP(BOMON b, LOP l)
        {
            String sql = String.Format("SELECT * FROM MON_LOP WHERE maLop = {0} AND maMon = {1}",  l.maLop, b.maBoMon);
            return ccf.getDatatable(sql);
        }
    }
}
