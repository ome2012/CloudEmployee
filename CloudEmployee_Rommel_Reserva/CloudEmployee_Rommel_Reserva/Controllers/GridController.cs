using CloudEmployee_Rommel_Reserva.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CloudEmployee_Rommel_Reserva.Controllers
{
    public class GridController : Controller
    {
        //
        // GET: /Grid/
        public ActionResult Grid()
        {
            List<Employee> employeeList = new List<Employee>();

            Employee employee1 = new Employee
            {
                EmployeeCode = "E-001",
                EmployeeName = "Rommel Reserva",
                EmployeeAddress = "Urgello, Cebu City",
                EmployeeSalary = 35000
            };

            Employee employee2 = new Employee
            {
                EmployeeCode = "E-002",
                EmployeeName = "Michael Bryan Lambo",
                EmployeeAddress = "Pardo, Cebu City",
                EmployeeSalary = 28000
            };

            Employee employee3 = new Employee
            {
                EmployeeCode = "E-003",
                EmployeeName = "May Quevedo",
                EmployeeAddress = "Bulcao, Cebu City",
                EmployeeSalary = 32000
            };

            Employee employee4 = new Employee
            {
                EmployeeCode = "E-004",
                EmployeeName = "Randy Alivo",
                EmployeeAddress = "Talisay City",
                EmployeeSalary = 50000
            };

            Employee employee5 = new Employee
            {
                EmployeeCode = "E-005",
                EmployeeName = "Jomily Paragele",
                EmployeeAddress = "Mabolo, Cebu City",
                EmployeeSalary = 23000
            };

            Employee employee6 = new Employee
            {
                EmployeeCode = "E-006",
                EmployeeName = "Rubilyn Hortelano",
                EmployeeAddress = "Bogo City",
                EmployeeSalary = 26000
            };

            Employee employee7 = new Employee
            {
                EmployeeCode = "E-007",
                EmployeeName = "Sachiko Heredia",
                EmployeeAddress = "Mabolo, Cebu City",
                EmployeeSalary = 23000
            };

            Employee employee8 = new Employee
            {
                EmployeeCode = "E-008",
                EmployeeName = "Jessa Managa",
                EmployeeAddress = "Mandaue City",
                EmployeeSalary = 23000
            };

            Employee employee9 = new Employee
            {
                EmployeeCode = "E-009",
                EmployeeName = "Harvey Esparcia",
                EmployeeAddress = "Lahug, Cebu City",
                EmployeeSalary = 43000
            };

            Employee employee10 = new Employee
            {
                EmployeeCode = "E-010",
                EmployeeName = "Johnrey Anthony",
                EmployeeAddress = "Mandaue City",
                EmployeeSalary = 36000
            };

            Employee employee11 = new Employee
            {
                EmployeeCode = "E-011",
                EmployeeName = "James Tan",
                EmployeeAddress = "Duljo Fatima, Cebu City",
                EmployeeSalary = 25000
            };

            Employee employee12 = new Employee
            {
                EmployeeCode = "E-012",
                EmployeeName = "Janet Necessario",
                EmployeeAddress = "Lapu-lapu City",
                EmployeeSalary = 26000
            };

            Employee employee13 = new Employee
            {
                EmployeeCode = "E-013",
                EmployeeName = "Felix Asenjo",
                EmployeeAddress = "Colon, Cebu City",
                EmployeeSalary = 23000
            };

            Employee employee14 = new Employee
            {
                EmployeeCode = "E-014",
                EmployeeName = "Romel Lauron",
                EmployeeAddress = "Tejero, Cebu City",
                EmployeeSalary = 38000
            };

            Employee employee15 = new Employee
            {
                EmployeeCode = "E-015",
                EmployeeName = "Rhon Brylle Delos Santos",
                EmployeeAddress = "Talisay City",
                EmployeeSalary = 60000
            };

            employeeList.Add(employee1);
            employeeList.Add(employee2);
            employeeList.Add(employee3);
            employeeList.Add(employee4);
            employeeList.Add(employee5);
            employeeList.Add(employee6);
            employeeList.Add(employee7);
            employeeList.Add(employee8);
            employeeList.Add(employee9);
            employeeList.Add(employee10);
            employeeList.Add(employee11);
            employeeList.Add(employee12);
            employeeList.Add(employee13);
            employeeList.Add(employee14);
            employeeList.Add(employee15);

            return View(employeeList);
        }
	}
}