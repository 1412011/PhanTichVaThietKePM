using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;

namespace BUS
{
    public class BUSBoMon
    {
        DAOBoMon dao_BoMon = new DAOBoMon();

        #region CURD cơ bản
        public BOMON get_unique(int id)
        {
            DataTable dt = dao_BoMon.get_unique(id);
            int countrows = dt.Rows.Count;

            if (countrows <= 0) return null; //data chưa có dòng nào, return
            DataRow row = dt.Rows[0];
            return new BOMON()
            {
                truongBoMon = (row["truongBoMon"] == DBNull.Value) ? (-1) : (int)row["truongBoMon"],
                maBoMon = (row["maBoMon"] == DBNull.Value) ? (-1) : (int)row["maBoMon"],
                heSoMon = (row["heSoMon"] == DBNull.Value) ? (-1) : (int)row["heSoMon"],
                soTietHoc = (row["soTietHoc"] == DBNull.Value) ? (-1) : (int)row["soTietHoc"],
                tenMonHoc = (String)row["tenMonHoc"],
            };
        }
        public int get_unique_last()
        {
            DataTable dt = dao_BoMon.get_unique_last();
            int countrows = dt.Rows.Count;
            if (countrows <= 0) return -1; //data chưa có dòng nào, return
            return (int)dt.Rows[0]["maBoMon"];
        }
        public List<BOMON> get_all()
        {
            List<BOMON> lst = new List<BOMON>();
            DataTable dt = dao_BoMon.get_all();
            foreach(DataRow row in dt.Rows)
            {
                lst.Add(new BOMON()
                {
                    truongBoMon = (row["truongBoMon"]== DBNull.Value) ? (-1) : (int)row["truongBoMon"],
                    maBoMon = (row["maBoMon"] == DBNull.Value) ? (-1) : (int)row["maBoMon"],
                    heSoMon = (row["heSoMon"] == DBNull.Value) ? (-1) : (int)row["heSoMon"],
                    soTietHoc = (row["soTietHoc"] == DBNull.Value) ? (-1) : (int)row["soTietHoc"],
                    tenMonHoc = (String)row["tenMonHoc"],
                });
            }

            return lst;
        }
        public DataTable get_all_datatable()
        {
            return dao_BoMon.get_all();
        }

        public int delete(int id)
        {
            return dao_BoMon.delete(id);
        }
        public int update(BOMON entity)
        {
            return dao_BoMon.update(entity);
        }
        public int insert(BOMON entity)
        {
            return dao_BoMon.insert(entity);
        }
        #endregion

        // add new operation 

        public int fill_data_Combobox(ComboBoxEdit cb)
        {
            List<BOMON> listBM = get_all();
            cb.Properties.Items.AddRange(listBM);
            cb.SelectedIndex = 0;
            return listBM.Count();
        }
        public int fill_data_RepositoryCombobox(RepositoryItemComboBox cb)
        {
            List<BOMON> listBM = get_all();
            cb.Items.AddRange(listBM.ToArray<BOMON>());
           
            return listBM.Count();
        }
        public BOMON test()
        {
            return get_unique(1);
        }
    }
}
