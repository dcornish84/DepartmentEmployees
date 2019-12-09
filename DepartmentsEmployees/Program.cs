using System;
using DepartmentsEmployees.Data;
using DepartmentsEmployees.Models;

namespace DepartmentsEmployees
{
    class Program
    {
        static void Main(string[] args)
        {
            var departmentRepo = new DepartmentRepository();

            var allDepartments = departmentRepo.GetAllDepartments();

            Console.WriteLine("All Departments");
            Console.WriteLine("----------------");
            foreach (var dept in allDepartments)
            {
                Console.WriteLine(dept.DepartmentName);
            }

            var hardCodeId = 3;

            var departmentWithId3 = departmentRepo.GetDepartmentById(hardCodeId);

            Console.WriteLine("-----------------");
            Console.WriteLine($"Department with id {hardCodeId} is {departmentWithId3.DepartmentName}");


            var employeeRepo = new EmployeeRepository();

            var allEmployees = employeeRepo.GetAllEmployees();

            Console.WriteLine("All Employees");
            Console.WriteLine("----------------");
            foreach (var emp in allEmployees)
            {
                Console.WriteLine(emp.FirstName);
                Console.WriteLine(emp.LastName);
            }

            var empHardCodeId = 3;

            var empWithId3 = employeeRepo.GetEmployeeById(empHardCodeId);

            Console.WriteLine("-----------------");
            Console.WriteLine($"Department with id {empHardCodeId} is {empWithId3.FirstName} {empWithId3.LastName}");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            var legal = new Department();
            Console.WriteLine("What department would you like to add?");

            legal.DepartmentName = Console.ReadLine();

            departmentRepo.AddDepartment(legal);

            Console.WriteLine("What Department (ID) would you like to update?");
            var departmentToUpdate = Int32.Parse(Console.ReadLine());

            Console.WriteLine("What should the new department name be called?");
            var newDepartmentName = Console.ReadLine();

            departmentRepo.UpdateDepartment(departmentToUpdate, new Department { DepartmentName = newDepartmentName });

            departmentRepo.DeleteDepartment(7);
            departmentRepo.DeleteDepartment(8);
            departmentRepo.DeleteDepartment(9);


        }
    }
}