using System.Data.Common;
using System.Reflection.Metadata.Ecma335;
using Domain;
using Domain.Models;
using Infrastructure.Servises;

var emp1 = new Employee();
emp1.Id = 1;
emp1.FirstName = "Mustafo";
emp1.LastName = "Barotov";
emp1.Salary = 120;




var emp2 = new Employee();
emp2.Id = 2;
emp2.FirstName = "Salom";
emp2.LastName = "Alek";
emp2.Salary = 10;
emp1.DateTime = new DateTime(2024,02,26);

var empservice = new EmployeeServisec();
empservice.AddEmployees(emp1);
empservice.AddEmployees(emp2);


var emplo = new List<Employee>();
emplo.Add(emp1);
emplo.Add(emp2);

foreach (var item in emplo)
{
    System.Console.WriteLine(item.Id);
    System.Console.WriteLine(item.FirstName);
    System.Console.WriteLine(item.LastName);
    System.Console.WriteLine(item.Department);
    System.Console.WriteLine(item.Salary);
    System.Console.WriteLine(item.DateTime);
}

empservice.DeleteEmployee(1);
empservice.UpdateEmployee(emp2);
empservice.GetEmployees();




var department1 = new Departments();
department1.Id = 5;
department1.Name = "Blabla";
department1.Description = "Ofarin";
department1.Manager = emp1;

var department2 = new Departments();
department2.Id = 6;
department2.Name = "Lalala";
department2.Description = "Bezeb";
department2.Manager = emp2;

var debser = new DepartmentService();
debser.AddDepartments(department1);
debser.AddDepartments(department2);

var depservice = new List<Departments>();

foreach (var item in depservice)
{
    System.Console.WriteLine(item.Id);
    System.Console.WriteLine(item.Name);
    System.Console.WriteLine(item.Manager);
}

debser.CountDepartments();
debser.DeleteDepartment(1);



