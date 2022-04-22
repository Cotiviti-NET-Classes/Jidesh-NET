using System.Collections.Generic;


delegate bool IsPromotable(Employee emp);
class Employee
{
public int Id { get; set; }
public string Name { get; set; }
public int Salary { get; set; }
public int Experience { get; set; }

public void PromoteEmployee(List<Employee> employeeList, IsPromotable IEligibleToPromote )
{
    foreach(Employee employee in employeeList)
    {
        if(IEligibleToPromote(employee))
        {
            Console.Write(employee.Name+" promoted");
        }
    }
}
}