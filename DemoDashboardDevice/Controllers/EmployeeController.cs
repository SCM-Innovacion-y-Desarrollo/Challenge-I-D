using DemoDashboardDevice.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDashboardDevice.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public List<Person> GetListEmployee()
        {
            List<Person> employees = Tools.GetListEmployee(new List<Person>());
            return employees;
        }
    }
}
