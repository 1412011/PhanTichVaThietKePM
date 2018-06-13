using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class DAOBangDiem
    {
        ConnectorFactory ccf = new ConnectorFactory();
        public int update(BANGDIEM b)
        {
           
            String sql = String.Format("UPDATE BANGDIEM SET diemMieng = {0}, diem15p = {1}, diemTiet = {2}" +
                " WHERE maBangDiem = {3}", b.diemMieng, b.diem15p, b.diemTiet, b.maBangDiem);
            return ccf.excuteNonQuery(sql);

        }
    }
}
