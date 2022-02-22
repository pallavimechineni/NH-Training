using System;
using BusinessLogicLibrary;
namespace ClientApp
{ 
public class program
{
    public static void Main(string[] args)
    {
        string choice;
        int ch;
        do
        {
            Console.WriteLine("Employee Management Application");
            Console.WriteLine("\t 1. Add Employee Details");
            Console.WriteLine("\t 2. get all employee details");
            Console.WriteLine("\t 3. Search Employee By ID");
            Console.WriteLine("\t 4. Search Employee by Name");

            Console.Write("\n Enter Your Choice :  ");
            ch = Convert.ToInt32(Console.ReadLine());

            switch (ch)
            {
                case 1: AddEmployee();
                        break;
                case 2: GetAllEmployees();
                        break;
                case 3: GetEmployeeById();
                        break;
                case 4: GetEmployeeByName();
                         break;
                default:Console.WriteLine("Invalid Option");
                        break;
            }
            Console.Write("\nDo You Wish to Continue to Main Menu (y/n): ");
            
            choice = Console.ReadLine();
            
        } while (choice == "y" || choice == "Y");

        Console.ReadLine();
    }
    public static void AddEmployee()
    {
        int id, salary, age;
        string name;

        Console.Write("\nEnter the Employee Id : ");
        id = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nEnter the Employee Name : ");
        name = Console.ReadLine();
        Console.Write("\nEnter the Employee Salary : ");
        salary = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nEnter the Employee Age : ");
        age = Convert.ToInt32(Console.ReadLine());

        var result = EmployeeBLL.AddEmployee(id, name, salary, age);

        if (result)
        {
            Console.WriteLine("\n  Employee Details Saved Succesfully");

        }
        else
        {

            Console.WriteLine("\n  Error occured During Saving The Given Data, Please Try Again");
        }
    }

    public static void GetEmployeeById()
    {
        int id;
        Console.Write("\nEnter any ID to Search Employee_Details_By_ID :  ");
        id = Convert.ToInt32(Console.ReadLine());
        var result = EmployeeBLL.GetEmployeeId(id);

        if (result.Count == 0)
        {
            
            Console.WriteLine("\nNo Records, Found With This ID");
            
        }
        else
        {
            Console.WriteLine("\n The Employee Details For Given Id : \n");
           
            result.ForEach(e => Console.WriteLine("\t{0}", e));
            
        }
    }
    public static void GetEmployeeByName()
    {
        string name;
        Console.Write("\nEnter any NAME, To Search_Employee_Details_By_Name :  ");
        name = Console.ReadLine();

        var result = EmployeeBLL.GetEmployeeName(name);

        if (result.Count == 0)
        {
            
            Console.WriteLine("\nNo Employee Details, Found with Given Name '{0}' ", name);        
        }
        else
        {
            Console.WriteLine("\n     The Employees, whose names Consists '{0}' are :  \n", name);
            
            result.ForEach(emp => Console.WriteLine("\t{0}", emp));
            
        }

    }
    public static void GetAllEmployees()
    {
        var employees = EmployeeBLL.GetAllEmployees();
        
        foreach (var employee in employees)
        {
            Console.WriteLine(employee);
        }
        
    }
}
