using ApplicationServices.EmployeeFactory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeFactory _employeeFactory;

        public EmployeeController(EmployeeFactory employeeFactory)
        {
            _employeeFactory = employeeFactory;
        }
        
        [HttpGet("calculate-employee-salary/{employeeType}")]
        public IActionResult CalculateEmployeSalary(int employeeType) 
        {
            var employee = _employeeFactory.GetEmployeeType(employeeType);
            var salary = employee.CalculateEmployeeSalary();

            return Ok(salary);
        }
    }
}
