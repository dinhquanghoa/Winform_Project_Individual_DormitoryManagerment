using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CONNECTTOR_TIER;
using MODEL;
using System.Data.SqlClient;
using System.Data;

namespace BUS_TIER
{
    public class Room_Bus
    {
        ConnectorFactory connector = null;
        public Room_Bus()
        {
            connector = new ConnectorFactory();
        }
        public List<Room> getListRoom()
        {
            SqlDataReader dr = null;
            List<Room> ds = null;
            try
            {
                dr = connector.getData("PHONG");
                ds = new List<Room>();
                while (dr.Read())
                {
                    Room l = new Room();
                    l.idRoom = dr.GetString(0);
                    l.nameRoom = dr.GetString(1);
                    l.currentPeople = dr.GetString(2);
                    l.capacity = dr.GetString(3);
                    l.typeRoom = dr.GetString(4);
                    l.idEmployee = dr.GetString(5);
                    ds.Add(l);
                }
                connector.closeConnnection();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
        public bool addNewRoom(Room l)
        {
            try
            {
                string SQL = string.Format("INSERT INTO PHONG VALUES (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}',N'{5}')",
                    l.idRoom,l.nameRoom,l.currentPeople,l.capacity,l.typeRoom, l.idEmployee);
                connector.openConnnection();
                SqlCommand cmd = new SqlCommand(SQL, connector.conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                connector.closeConnnection();
            }
            return false;
        }

        public bool deleteRoom(string id)
        {
            try
            {
                string SQL = string.Format("DELETE FROM PHONG WHERE maPhong = '" + id + "'");
                connector.openConnnection();
                SqlCommand cmd = new SqlCommand(SQL, connector.conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                connector.closeConnnection();
            }
            return false;
        }

        public bool editRoom(Room l)
        {
            try
            {
                string SQL = string.Format("UPDATE PHONG SET tenPhong = N'{0}', soluonghientai = N'{1}', succhua = '{2}', loaiPhong = '{3}', maNhanVien = N'{4}' WHERE maPhong = '{5}' ",
                    l.nameRoom, l.idEmployee, l.capacity, l.typeRoom, l.idRoom, l.currentPeople);
                connector.openConnnection();
                SqlCommand cmd = new SqlCommand(SQL, connector.conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                connector.closeConnnection();
            }
            return false;
        }

        public DataView search(string id)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\DTU\2.2 Winform\DormitoryManagerment\DormitoryManagement\DORMITORY_MANAGEMENT.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from PHONG", con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("maPhong like '%{0}%'", id);
            return dv;
        }
    }
}
