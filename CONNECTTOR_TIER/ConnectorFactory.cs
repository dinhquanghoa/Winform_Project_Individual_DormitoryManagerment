using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CONNECTTOR_TIER
{
    public class ConnectorFactory
    {
        public string strConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\DTU\2.2 Winform\DormitoryManagerment\DormitoryManagement\DORMITORY_MANAGEMENT.mdf;Integrated Security=True";
        public SqlCommand cmd = null;
        public SqlConnection conn = null;
        public SqlDataReader dr = null;
        public ConnectorFactory()
        {
            conn = new SqlConnection(strConn);
        }
        /// <summary>
        /// Open connection
        /// </summary>
        public void openConnnection()
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Close connection
        /// </summary>
        public void closeConnnection()
        {
            try
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       
        public SqlDataReader getData(string table)
        {
            try
            {
                string sql = "select * from " + table;
                cmd = new SqlCommand(sql);
                cmd.Connection = conn;
                this.openConnnection();
                dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dr;
        }

       
    }
}
