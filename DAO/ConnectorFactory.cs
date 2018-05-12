using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAO
{
    public class ConnectorFactory
    {
        protected static String stringConnect = "Data Source=DESKTOP-AQS6PEQ;Initial Catalog=QuanLySinhVien;Integrated Security=True";
        //protected static String stringConnect = ConfigurationManager.ConnectionStrings["QuanLyQuanAn"].ConnectionString;
        protected SqlConnection cnn = new SqlConnection(stringConnect);

        public ConnectorFactory()
        {
        }

        public ConnectorFactory(SqlConnection cnn)
        {
            this.cnn = cnn;
        }

        public void OpenConnect()
        {  
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void CloseConnect()
        {
            try
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable getDatatable(string sql)
        {
            try
            {
                this.OpenConnect();

                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, cnn);
                adapter.Fill(table);

                this.CloseConnect();
                return table;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public int excuteNonQuery(String sql)
        {
            try
            {
                this.OpenConnect();

                SqlCommand cmd = new SqlCommand(sql, cnn);
                int effecRow = cmd.ExecuteNonQuery();

                this.CloseConnect();

                return effecRow;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public SqlDataAdapter UpdateOnGrid(String sql)
        {
            try
            {
                this.OpenConnect();
                
                SqlDataAdapter adapter = new SqlDataAdapter(sql, cnn);

                this.CloseConnect();
                return adapter;

            }
            catch(Exception e)
            {
                throw e;
            }
        }

    }
}
