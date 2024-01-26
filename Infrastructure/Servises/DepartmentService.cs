using Domain.Models;

namespace Infrastructure.Servises;

public class DepartmentService
{
    List<Departments> departments = new List<Departments>();
    public List<Departments> GetEmployees()
    {
        return departments;
    }
    public void AddDepartments(Departments dep)
    {
        departments.Add(dep);
    }
    public void UpdateEmployee(Departments dep)
    {
        dep.Id = 10;
        dep.Name = "Depart";
        dep.Description = "Desc";
    }
    public void CountDepartments()
    {
        System.Console.WriteLine(departments.Count());
    }
    public void DeleteDepartment(int id)
    {
        foreach (var item in departments)
        {
            if(item.Id== id)
            {
                departments.Remove(item);
            }
        }
    }
}

