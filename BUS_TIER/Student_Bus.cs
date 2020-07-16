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
    public class Student_Bus
    {
        ConnectorFactory connector = null;
        public Student_Bus()
        {
            connector = new ConnectorFactory();
        }
        public List<Student> getListStudent()
        {
            SqlDataReader dr = null;
            List<Student> ds = null;
            try
            {
                dr = connector.getData("SINH_VIEN");
                ds = new List<Student>();
                while (dr.Read())
                {
                    Student sv = new Student();
                    sv.idStudent = dr.GetString(0);
                    sv.idRoom = dr.GetString(1);
                    sv.nameStudent = dr.GetString(2);
                    sv.dateOfBirthStudent = dr.GetString(3);
                    sv.addressStudent = dr.GetString(4);
                    sv.phoneNumberStudent = dr.GetString(5);
                    ds.Add(sv);
                }
                connector.closeConnnection();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }

        public bool addNewStudent(Student s)
        {
            try
            {
                string SQL = string.Format("INSERT INTO SINH_VIEN VALUES (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}',N'{5}')",
                s.idStudent , s.idRoom, s.nameStudent, s.dateOfBirthStudent, s.addressStudent, s.phoneNumberStudent);
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

        public bool deleteStudent(string id)
        {
            try
            {
                string SQL = string.Format("DELETE FROM SINH_VIEN WHERE masv = '" + id + "'");
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

        public bool editStudent(Student s)
        {
            try
            {
                string SQL = string.Format("UPDATE SINH_VIEN SET maPhong = '{0}', tensv = N'{1}', ngaysinh = N'{2}', diachi = N'{3}', sdt = '{4}' WHERE masv = '{5}' ",
                s.idRoom, s.nameStudent, s.dateOfBirthStudent, s.addressStudent, s.phoneNumberStudent, s.idStudent);
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
            SqlCommand cmd = new SqlCommand("select * from SINH_VIEN", con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("masv like '%{0}%'", id);
            return dv;
        }
    }
}
