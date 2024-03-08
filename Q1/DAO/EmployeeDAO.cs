using Q1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1.DAO
{
    public class EmployeeDAO
    {
        public static List<Employee> getListEmployee()
        {
            String Sql = "select e.Id, e.Name, Dob, Sex, Position, Department, d.Name as DepartmentName from Employee e join Department d on e.Department = d.Id";
            DataTable dt = DAO.GetDataBySQL(Sql);
            List<Employee> le = new List<Employee>();
            foreach (DataRow dr in dt.Rows)
            {
                Employee emp = new Employee();
                emp.Id = int.Parse(dr["Id"].ToString());
                emp.Name = (dr["Name"].ToString());
                emp.Dob = DateTime.Parse(dr["Dob"].ToString());
                emp.Sex = (dr["Sex"].ToString());
                emp.Position = (dr["Position"].ToString());
                emp.DepartmentId = int.Parse(dr["Department"].ToString());
                emp.DepartmentName = (dr["DepartmentName"].ToString());

                le.Add(emp);

            }
            return le;
        }
    }
}
