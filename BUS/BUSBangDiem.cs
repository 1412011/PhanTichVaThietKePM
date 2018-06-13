using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class BUSBangDiem
    {
        DAOBangDiem dao_bangdiem = new DAOBangDiem();
        public int update(BANGDIEM b)
        {
            return dao_bangdiem.update(b);
        }
    }
}
