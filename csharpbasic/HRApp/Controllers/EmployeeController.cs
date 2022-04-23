using Microsoft.AspNetCore.Mvc;
using HRApp.Models;
using HRApp.Enums;

namespace HRApp.Controllers
{

    public class EmployeeController: Controller
    {
        // public string Hello()
        // {
        //     return "Cotiviti";
        // }
        public IActionResult Home()
        {
            List<Employee> employees=new()
            {
                new Employee {Name="Dipesh Chapagain", Gender=Gender.Male,JoiningDate=DateTime.Now},
                new Employee {Name="Dipa sherstha", Gender=Gender.Female,JoiningDate=DateTime.Now}
            };
            return View(employees);
        }
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }

    }
}