using System;
using System.Collections.Generic;
using System.Linq;

using System.IO;

namespace DataAcessLayer
{
    public static class EmployeeDAL
    {
        public static string filepath = "D:\\Day1 Assessment by Pallavi Mechineni\\Day 22 project\\EmployeeData.employee.txt";
        public static bool AddEmployee(int empid, string empname, int empsalary, int empage)
        {
            try
            {
                string Textcontent = string.Concat(empid, ",", empname, ",", empsalary, ",", empage);
                File.AppendAllText(filepath, Textcontent + Environment.NewLine);
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static List<string> GetEmployeeId(int id)
        {
            var allemployees = File.ReadAllLines(filepath);
            // bool isFound = false;
            List<string> employeeFound = new List<string>();

            foreach (string employee in allemployees)
            {
                var empDetails = employee.Split(',');
                if (Convert.ToInt32(empDetails[0]) == id)
                {
                    //isFound = true;
                    employeeFound.Add(employee);
                    break;
                }
            }
            return employeeFound;

        }
        public static List<string> GetEmployeeName(string name)
        {
            var allemployees = File.ReadAllLines(filepath);
            // bool isFound = false;
            List<string> employeeFound = new List<string>();

            foreach (string employee in allemployees)
            {
                var empDetails = employee.Split(',');

                if (empDetails[1].Contains(name))
                {
                    employeeFound.Add(employee);
                }
            }
            return employeeFound;
        }
        public static string[] GetAllEmployees()
        {
            
            var allemployees = File.ReadAllLines(filepath);
            return allemployees;
        }



    }
}



