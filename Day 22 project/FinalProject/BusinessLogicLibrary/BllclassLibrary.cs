using System;
using DataAcessLayer;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLibrary
{
    public class EmployeeBLL
    {
        public static bool AddEmployee(int empid, string empname, int empsalary, int empage)
        {
            var result = EmployeeDAL.AddEmployee(empid, empname, empsalary, empage);
            return result;

        }
        public static List<string> GetEmployeeId(int id)
        {
            var result = EmployeeDAL.GetEmployeeId(id);
            return result;
        }
        public static List<string> GetEmployeeName(string name)
        {
            var result = EmployeeDAL.GetEmployeeName(name);
            return result;
        }
        public static string[] GetAllEmployees()
        {
            var result = EmployeeDAL.GetAllEmployees();
            return result;
        }
    }
}




