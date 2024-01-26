using Domain;
namespace Infrastructure.Servises;

public class EmployeeServisec
{
    List<Employee> employees = new List<Employee>();
    public List<Employee> GetEmployees()
    {
        return employees;
    }
    public void AddEmployees(Employee emp)
    {
        employees.Add(emp);
    }
    public void UpdateEmployee(Employee emp)
    {
        emp.Id = 11;
        emp.FirstName = "Man";
        emp.LastName = "Tu";
        emp.Salary = 100;
        emp.DateTime = "26/01/2024";
    }
    public void CountEmployees()
    {
        System.Console.WriteLine(employees.Count());
    }
    public void DeleteEmployee(int id)
    {
        foreach (var item in employees)
        {
            if(item.Id== id)
            {
                employees.Remove(item);
            }
        }
    }
}
