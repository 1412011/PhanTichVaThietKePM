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
    public class BUSHocSinh
    {
        DAOHocSinh dao_HocSinh = new DAO.DAOHocSinh();
        public int delete(int id)
        {
            return dao_HocSinh.delete(id);
        }
        public int update(HOCSINH entity)
        {
            return dao_HocSinh.update(entity);
        }
        public int insert(HOCSINH entity)
        {
            return dao_HocSinh.insert(entity);
        }
        public DataTable get_all()
        {
            return dao_HocSinh.get_all();
        }
        public DataTable getTKB(string lop)
        {
            return dao_HocSinh.getTKB(lop);
        }
    }
}
