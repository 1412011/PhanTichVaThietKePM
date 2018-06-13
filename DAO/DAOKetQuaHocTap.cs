using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class DAOKetQuaHocTap
    {
        ConnectorFactory ccf = new ConnectorFactory();
        public DataTable get_list_full_info(int thang, int loai, MON_LOP ml)
        {
            String sql = String.Format("select sTT, hoTen, gioiTinh,hocKy, thangTrongNam,maKetQua, diemMieng, diem15p, diemTiet, diemTrungBinh,hocLuc, hanhKiem, xepHang, nhanXet " +
                "from HOCSINH h, LOP_HOCSINH l, KETQUAHOCTAP k, BANGDIEM b " +
                "WHERE l.maLop = {0} AND h.maHocSinh = l.maHocSinh AND k.maHocSinh = l.maLop_HS " +
                "AND k.maBangDiem = b.maBangDiem AND b.mon_lop = {1} AND loaiKetQua = {2} " +
                "AND thangTrongNam = {3}",ml.maLop,ml.maMon_Lop,loai,thang);

            return ccf.getDatatable(sql);
        }

        public DataTable get_unique(int makq)
        {
            String sql = String.Format("Select * from KETQUAHOCTAP WHERE maKetQua = {0}",makq);

            return ccf.getDatatable(sql);
        }

        public int update_hanhkiem(KETQUAHOCTAP k)
        {

            String sql = String.Format("UPDATE KETQUAHOCTAP SET hanhKiem = N'{0}'" +
                " WHERE maKetQua = {1}", k.hanhKiem, k.maKetQua);
            return ccf.excuteNonQuery(sql);

        }
    }
}
