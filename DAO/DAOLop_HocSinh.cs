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
    }
}
