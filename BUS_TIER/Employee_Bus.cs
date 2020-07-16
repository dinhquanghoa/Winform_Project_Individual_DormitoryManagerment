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
    public class Employee_Bus
    {
        ConnectorFactory connector = null;
        public Employee_Bus()
        {
            connector = new ConnectorFactory();
        }
        public List<Employee> getListEmployee()
        {
            SqlDataReader dr = null;
            List<Employee> ds = null;
            try
            {
                dr = connector.getData("NHAN_VIEN");
                ds = new List<Employee>();
                while (dr.Read())
                {
                    Employee nv = new Employee();
                    nv.idEmployee = dr.GetString(0);
                    nv.nameEmployee = dr.GetString(1);
                    nv.genderEmployee = dr.GetString(2);
                    nv.position = dr.GetString(3);                    
                    nv.basicSalary = dr.GetString(4);
                    ds.Add(nv);
                }
                connector.closeConnnection();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }

        public bool addNewEmployee (Employee nv)
        {
            try
            {
                string SQL = string.Format("INSERT INTO NHAN_VIEN VALUES (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}')", 
                    nv.idEmployee, nv.nameEmployee, nv.genderEmployee, nv.position, nv.basicSalary);
                connector.openConnnection();
                SqlCommand cmd = new SqlCommand(SQL, connector.conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }catch(Exception e)
            {
                throw e;
            }
            finally { 
                connector.closeConnnection(); 
            }
            return false;
        }

        public bool deleteEmployee(string id)
        {
            try
            {
                string SQL = string.Format("DELETE FROM NHAN_VIEN WHERE maNhanVien = '"+id+"'");
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

        public bool editEmployee(Employee nv)
        {
            try
            {
                string SQL = string.Format("UPDATE NHAN_VIEN SET tenNhanVien = N'{0}',  gioitinh = N'{1}',chucvu = N'{2}', luongcoban = '{3}' WHERE maNhanVien = '{4}' ", 
                    nv.nameEmployee,  nv.genderEmployee, nv.position, nv.basicSalary, nv.idEmployee);
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
            SqlCommand cmd = new SqlCommand("select * from NHAN_VIEN", con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("maNhanVien like '%{0}%'", id);
            return dv;
        }
    }
}
